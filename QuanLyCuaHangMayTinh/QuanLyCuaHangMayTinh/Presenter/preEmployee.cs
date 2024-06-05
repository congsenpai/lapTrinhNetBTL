using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangMayTinh.Model;

namespace QuanLyCuaHangMayTinh.Presenter
{
    

    public class preEmployee
    {
        prsMain pre=new prsMain();
        Entity db=new Entity();
       

        public Entity Db { get => db; set => db = value; }
        public List<NhanVien> listEmployee()
        {
            var nhanviens=Db.NhanViens.ToList();
            return nhanviens;
        }  
        public DataTable loadEmployee()
        {
                var nhanViens = listEmployee();
                DataTable a = pre.ConvertToDataTable(nhanViens);
                return a;
        }
        public bool CheckExits(String MaNV)
        {
            return Db.NhanViens.Any(nv => nv.MaNV == MaNV);
        }
        public DataTable findByBirthDay(DateTime birth, string typeSort)
        {
            if (typeSort == "ASC")
            {
                var query = Db.NhanViens
                 .Where(NV => NV.NgaySinh.GetValueOrDefault().Date==birth.Date)
                 .OrderBy(NV => NV.MaNV)
                 .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
            else
            {
                var query = Db.NhanViens
               .Where(NV => NV.NgaySinh.GetValueOrDefault().Date == birth.Date)
               .OrderByDescending(NV => NV.MaNV)
               .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }

        }
        public DataTable findByID(string id, string typeSort)
        {
            if (typeSort == "ASC")
            {
                var query = Db.NhanViens
                 .Where(NV => NV.MaNV == id)
                 .OrderBy(NV => NV.MaNV)
                 .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
            else
            {
                var query = Db.NhanViens
               .Where(NV => NV.MaNV == id)
               .OrderByDescending(NV => NV.MaNV)
               .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }

        }
        public DataTable findByName(string name, string typeSort)
        {
            if (typeSort == "ASC")
            {
                var query = Db.NhanViens
               .Where(NV => NV.TenNV == name)
               .OrderBy(NV => NV.MaNV)
               .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
            else
            {
                var query = Db.NhanViens
              .Where(NV => NV.TenNV == name)
              .OrderByDescending(NV => NV.MaNV)
              .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
        }
        public DataTable findByPhone(string phone, string typeSort)
        {
            if (typeSort == "ASC")
            {
                var query = Db.NhanViens
                 .Where(NV => NV.Dienthoai == phone)
                 .OrderBy(NV => NV.MaNV)
                 .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
            else
            {
                var query = Db.NhanViens
                 .Where(NV => NV.Dienthoai == phone)
                 .OrderByDescending(NV => NV.MaNV)
                 .ToList();

                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
        }
        public DataTable findByGioitinh(string gioitinh, string typeSort)
        {
            if (typeSort == "ASC")
            {
                var query = Db.NhanViens
              .Where(NV => NV.Gioitinh == gioitinh)
              .OrderBy(NV => NV.MaNV)
              .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
            else
            {
                var query = Db.NhanViens
              .Where(NV => NV.Gioitinh == gioitinh)
              .OrderByDescending(NV => NV.MaNV)
              .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
        }
        public void AddEmployee(String TenNV, DateTime ngaysinh, String gioitinh, String dienthoai)
        {
            NhanVien a = new NhanVien();
            NhanVien NhanVienMoi = new NhanVien
            {
                TenNV = TenNV,
                NgaySinh = ngaysinh,
                Gioitinh = gioitinh,
                Dienthoai = dienthoai
            };
            a.addData(NhanVienMoi);
        }
    }
}
