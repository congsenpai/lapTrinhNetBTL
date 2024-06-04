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
    public class PreImport
    {
        Entity db = new Entity();

        public Entity Db { get => db; set => db = value; }

        prsMain prsMain = new prsMain();
        PreSupplier suppliers = new PreSupplier();
        preEmployee employees = new preEmployee();
        preComputer computers = new preComputer();
        private List<HoaDonNhap> listHoaDon()
        {
            var hoadon = Db.HoaDonNhaps.ToList();
            return hoadon;
        }
        public DataTable loadHoaDonNhap()
        {
            var hoadons = listHoaDon();
            DataTable a = prsMain.ConvertToDataTable(hoadons);
            return a;
        }
        public DataTable FindHoaDon(String SearchString, DateTime From, DateTime To, String MaNV, String MaNCC)
        {
            List<HoaDonNhap> hoadons = null;
            if (employees.CheckExits(MaNV) == false)
            {
                if (suppliers.CheckExits(MaNCC) == false)
                {
                    hoadons = Db.HoaDonNhaps
                          .Where(m => m.MaHDN.Contains(SearchString)
                                  && m.NgayNhap >= From
                                  && m.NgayNhap <= To)
                                  .ToList();
                }
                else
                {
                    hoadons = Db.HoaDonNhaps
                         .Where(m => m.MaHDN.Contains(SearchString)
                                 && m.NgayNhap >= From
                                 && m.NgayNhap <= To
                                 && m.MaNCC == MaNCC)
                                .ToList();
                }
            }
            else
            {
                if (suppliers.CheckExits(MaNCC) == false)
                {
                    hoadons = Db.HoaDonNhaps
                          .Where(m => m.MaHDN.Contains(SearchString)
                                  && m.NgayNhap >= From
                                  && m.NgayNhap <= To
                                  && m.MaNV == MaNV)
                                  .ToList();
                }
                else
                {
                    hoadons = Db.HoaDonNhaps
                         .Where(m => m.MaHDN.Contains(SearchString)
                                 && m.NgayNhap >= From
                                 && m.NgayNhap <= To
                                 && m.MaNV == MaNV
                                 && m.MaNCC == MaNCC)
                                .ToList();
                }
            }


            DataTable a = prsMain.ConvertToDataTable(hoadons);
            return a;
        }

        public void AddImportDetails(DataTable hoadon, DateTime NgayNhap, String maNV, String maNCC, Double TongTien)
        {
            using (var db = new Entity())
            {
                HoaDonNhap a = Import(db, NgayNhap, maNV, maNCC, TongTien);
                foreach (DataRow dr in hoadon.Rows)
                {
                    ChiTietHDN chitiet = new ChiTietHDN
                    {
                        MaHDN = a.MaHDN,
                        MaMVT = dr["MaMVT"].ToString(),
                        Soluong = (int?)dr["SoLuong"],
                        Dongia = (double?)dr["DonGia"]
                    };
                    db.ChiTietHDNs.Add(chitiet);
                    db.SaveChanges();
                    var mayVTToUpdate = Db.MayVTs.FirstOrDefault(m => m.MaMVT == chitiet.MaMVT);
                    if (mayVTToUpdate != null)
                    {
                        mayVTToUpdate.SoLuong += chitiet.Soluong ?? 0;
                        Db.SaveChanges();
                    }
                }
                
            }
        }

        private HoaDonNhap Import(Entity db, DateTime NgayNhap, String maNV, String maNCC, Double TongTien)
        {
            HoaDonNhap newHoadon = new HoaDonNhap();
            HoaDonNhap a=newHoadon.addData(db, NgayNhap, maNV, maNCC, TongTien);
            return a;
        }

    }
}
