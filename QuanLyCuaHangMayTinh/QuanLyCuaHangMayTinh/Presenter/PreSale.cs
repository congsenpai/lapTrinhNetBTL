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

        prsMain prsMain = new prsMain();
        PreCustomer customers = new PreCustomer();
        preEmployee employees = new preEmployee();
        preComputer computers = new preComputer();
        private List<HoaDonBan> listHoaDon()
        {
            var hoadon = Db.HoaDonBans.ToList();
            return hoadon;
        }
        public DataTable loadHoaDonBan()
        {
            var hoadons = listHoaDon();
            DataTable a = prsMain.ConvertToDataTable(hoadons);
            return a;
        }
        public DataTable FindHoaDon(String SearchString, DateTime From, DateTime To, String MaNV, String MaKH)
        {
            List<HoaDonBan> hoadons = null;
            if (employees.CheckExits(MaNV) == false)
            {
                if (customers.CheckExits(MaKH) == false)
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
                if (customers.CheckExits(MaKH) == false)
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
