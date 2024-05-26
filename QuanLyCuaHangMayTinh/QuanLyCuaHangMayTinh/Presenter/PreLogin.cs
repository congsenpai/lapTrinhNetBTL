using QuanLyCuaHangMayTinh.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangMayTinh.Model;
namespace QuanLyCuaHangMayTinh.Presenter
{
    internal class PreLogin
    {
        Entity db = new Entity();
        public Entity Db { get => db; set => db = value; }

        private List<loginAccout> listLogin()
        {
            var khachhangs = Db.loginAccouts.ToList();
            return khachhangs;
        }

        public bool findByID(string tk, string mk)
        {
            bool accountExists = Db.loginAccouts
                 .Any(kh => kh.MaNV == tk && kh.Password == mk);

            return accountExists;
        }


        //}
        //public DataTable findByName(string name, string typeSort)
        //{
        //    if (typeSort == "ASC")
        //    {
        //        var query = Db.KhachHangs
        //       .Where(kh => kh.TenKH == name)
        //       .OrderBy(kh => kh.MaKH)
        //       .ToList();
        //        DataTable a = pre.ConvertToDataTable(query);
        //        return a;
        //    }
        //    else
        //    {
        //        var query = Db.KhachHangs
        //      .Where(kh => kh.TenKH == name)
        //      .OrderByDescending(kh => kh.MaKH)
        //      .ToList();
        //        DataTable a = pre.ConvertToDataTable(query);
        //        return a;
        //    }
        //}
        //public DataTable findByPhone(string phone, string typeSort)
        //{
        //    if (typeSort == "ASC")
        //    {
        //        var query = Db.KhachHangs
        //         .Where(kh => kh.Dienthoai == phone)
        //         .OrderBy(kh => kh.MaKH)
        //         .ToList();
        //        DataTable a = pre.ConvertToDataTable(query);
        //        return a;
        //    }
        //    else
        //    {
        //        var query = Db.KhachHangs
        //         .Where(kh => kh.Dienthoai == phone)
        //         .OrderByDescending(kh => kh.MaKH)
        //         .ToList();

        //        DataTable a = pre.ConvertToDataTable(query);
        //        return a;
        //    }
        //}
        //public DataTable findByAddress(string address, string typeSort)
        //{
        //    if (typeSort == "ASC")
        //    {
        //        var query = Db.KhachHangs
        //      .Where(kh => kh.DiaChi == address)
        //      .OrderBy(kh => kh.MaKH)
        //      .ToList();
        //        DataTable a = pre.ConvertToDataTable(query);
        //        return a;
        //    }
        //    else
        //    {
        //        var query = Db.KhachHangs
        //      .Where(kh => kh.DiaChi == address)
        //      .OrderByDescending(kh => kh.MaKH)
        //      .ToList();
        //        DataTable a = pre.ConvertToDataTable(query);
        //        return a;
        //    }
        //}


    }

}
