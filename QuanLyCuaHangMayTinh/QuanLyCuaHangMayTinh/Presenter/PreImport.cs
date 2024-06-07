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

        PreMain prsMain = new PreMain();
        PreSupplier suppliers = new PreSupplier();
        PreEmployee employees = new PreEmployee();
        PreComputer computers = new PreComputer();
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
            if (prsMain.CheckExits(MaNV, "NV") == false)
            {
                if (prsMain.CheckExits(MaNCC, "NCC") == false)
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
                if (prsMain.CheckExits(MaNCC, "NCC") == false)
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
            HoaDonNhap a = Import(NgayNhap, maNV, maNCC, TongTien);
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
                    mayVTToUpdate.SoLuong += chitiet.Soluong;
                    Db.SaveChanges();
                }
            }

        }

        private HoaDonNhap Import(DateTime NgayNhap, String maNV, String maNCC, Double TongTien)
        {
            HoaDonNhap newHoadon = new HoaDonNhap();
            HoaDonNhap a = newHoadon.addData(NgayNhap, maNV, maNCC, TongTien);
            return a;
        }
    }

}
