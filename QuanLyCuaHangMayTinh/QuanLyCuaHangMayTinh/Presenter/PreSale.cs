using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangMayTinh.Model;
namespace QuanLyCuaHangMayTinh.Presenter
{
    public class PreSale
    {
        Entity db = new Entity();

        public Entity Db { get => db; set => db = value; }

        PreMain prsMain = new PreMain();
        PreCustomer customers = new PreCustomer();
        PreEmployee employees = new PreEmployee();
        PreComputer computers = new PreComputer();
        private List<HoaDonBan> listHoaDon()
        {
            var hoadon = Db.HoaDonBans.ToList();
            return hoadon;
        }
        public int SumOfOrder(DataTable a)
        {
            int i = 0;
            foreach(DataRow dr in a.Rows)
            {
                i += 1;
            }
            return i;
        }
        public DataTable loadHoaDonBan()
        {
            var hoadons = listHoaDon();
            DataTable a = prsMain.ConvertToDataTable(hoadons);
            return a;
        }
        public DataTable getOrderByDay(DateTime date)
        {
            var invoices = listHoaDon();
            DataTable resultTable = new DataTable();
            resultTable.Columns.Add("Date", typeof(DateTime));
            resultTable.Columns.Add("TotalAmount", typeof(decimal));
            var dailySales = from invoice in invoices
                             where invoice.NgayBan.GetValueOrDefault().Day == date.Day
                             group invoice by invoice.NgayBan into g
                             select new
                             {
                                 Date = g.Key,
                                 TotalAmount = g.Sum(i => i.TongTien)
                             };

            foreach (var dailySale in dailySales)
            {
                resultTable.Rows.Add(dailySale.Date, dailySale.TotalAmount);
            }
            return resultTable;
        }
        public DataTable getOrderByMonth(DateTime date)
        {
            var invoices = listHoaDon();
            DataTable resultTable = new DataTable();
            resultTable.Columns.Add("Date", typeof(DateTime));
            resultTable.Columns.Add("TotalAmount", typeof(decimal));
            var dailySales = from invoice in invoices
                             where invoice.NgayBan.GetValueOrDefault().Month == date.Month && invoice.NgayBan.GetValueOrDefault().Year == date.Year
                             group invoice by invoice.NgayBan into g
                             select new
                             {
                                 Date = g.Key,
                                 TotalAmount = g.Sum(i => i.TongTien)
                             };

            foreach (var dailySale in dailySales)
            {
                resultTable.Rows.Add(dailySale.Date, dailySale.TotalAmount);
            }
            return resultTable;
        }
        public DataTable getOrderByCurrentWeek()
        {
            var invoices = listHoaDon();
            DataTable resultTable = new DataTable();
            resultTable.Columns.Add("Date", typeof(DateTime));
            resultTable.Columns.Add("TotalAmount", typeof(decimal));
            DateTime Monday = GetMostRecentMonday();
            var dailySales = from invoice in invoices
                             where invoice.NgayBan.GetValueOrDefault() >= Monday && invoice.NgayBan.GetValueOrDefault() <= DateTime.Today
                             group invoice by invoice.NgayBan into g
                             select new
                             {
                                 Date = g.Key,
                                 TotalAmount = g.Sum(i => i.TongTien)
                             };


            foreach (var dailySale in dailySales)
            {
                resultTable.Rows.Add(dailySale.Date, dailySale.TotalAmount);
            }
            return resultTable;
        }
        public DateTime GetMostRecentMonday()
        {
            DateTime today = DateTime.Today;
            int daysSinceMonday = ((int)today.DayOfWeek - (int)DayOfWeek.Monday + 7) % 7;
            return today.AddDays(-daysSinceMonday);
        }

        public DataTable FindHoaDon(String SearchString, DateTime From, DateTime To, String MaNV, String MaKH)
        {
            List<HoaDonBan> hoadons = null;
            if (prsMain.CheckExits(MaNV,"NV") == false)
            {
                if (prsMain.CheckExits(MaKH,"KH") == false)
                {
                    hoadons = Db.HoaDonBans
                          .Where(m => m.MaHDB.Contains(SearchString)
                                  && m.NgayBan >= From
                                  && m.NgayBan <= To)
                                  .ToList();
                }
                else
                {
                    hoadons = Db.HoaDonBans
                         .Where(m => m.MaHDB.Contains(SearchString)
                                 && m.NgayBan >= From
                                 && m.NgayBan <= To
                                 && m.MaKH == MaKH)
                                .ToList();
                }
            }
            else
            {
                if (prsMain.CheckExits(MaKH,"KH") == false)
                {
                    hoadons = Db.HoaDonBans
                          .Where(m => m.MaHDB.Contains(SearchString)
                                  && m.NgayBan >= From
                                  && m.NgayBan <= To
                                  && m.MaNV == MaNV)
                                  .ToList();
                }
                else
                {
                    hoadons = Db.HoaDonBans
                         .Where(m => m.MaHDB.Contains(SearchString)
                                 && m.NgayBan >= From
                                 && m.NgayBan <= To
                                 && m.MaNV == MaNV
                                 && m.MaKH == MaKH)
                                .ToList();
                }
            }


            DataTable a = prsMain.ConvertToDataTable(hoadons);
            return a;
        }

        private HoaDonBan Buy(DateTime ngayban, String maNV, String maKH, Double TongTien)
        {
            HoaDonBan newHoadon = new HoaDonBan();
            HoaDonBan a = newHoadon.addData(ngayban, maNV, maKH, TongTien);
            return a;
        }
        public void AddBuyDetails(DataTable hoadon, DateTime ngayban, String maNV, String maKH, Double TongTien)
        {
            HoaDonBan a = Buy(ngayban, maNV, maKH, TongTien);
            foreach (DataRow dr in hoadon.Rows)
            {
                ChiTietHDB chitiet = new ChiTietHDB
                {
                    MaHDB = a.MaHDB,
                    MaMVT = dr["MaMVT"].ToString(),
                    Soluong = (int?)dr["SoLuong"],
                    Dongia = (double?)dr["DonGia"]
                };
                Db.ChiTietHDBs.Add(chitiet);

                Db.SaveChanges();
                var mayVTToUpdate = Db.MayVTs.FirstOrDefault(m => m.MaMVT == chitiet.MaMVT);
                if (mayVTToUpdate != null)
                {
                    mayVTToUpdate.SoLuong -= chitiet.Soluong ?? 0;
                    Db.SaveChanges();
                }
            }
        }

    }
}
