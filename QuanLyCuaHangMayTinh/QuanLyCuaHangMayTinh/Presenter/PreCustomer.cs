using QuanLyCuaHangMayTinh.Model;
using QuanLyCuaHangMayTinh.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Xml.Linq;

namespace QuanLyCuaHangMayTinh.Presenter
{
    public class PreCustomer
    {
        Entity db = new Entity();
        prsMain pre = new prsMain();
        public Entity Db { get => db; set => db = value; }

        private List<KhachHang> listCustomer()
        {
            var khachhangs = Db.KhachHangs.ToList();
            return khachhangs;
        }
        public DataTable loadCustomer()
        {
            var khachHangs = listCustomer();
            DataTable a = pre.ConvertToDataTable(khachHangs);
            return a;
        }

        public DataTable findByID(string id, string typeSort)
        {
            if (typeSort == "ASC")
            {
                var query = Db.KhachHangs
                 .Where(kh => kh.MaKH == id)
                 .OrderBy(kh => kh.MaKH)
                 .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
            else
            {
                var query = Db.KhachHangs
               .Where(kh => kh.MaKH == id)
               .OrderByDescending(kh => kh.MaKH)
               .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }

        }
        public DataTable findByName(string name, string typeSort)
        {
            if (typeSort == "ASC")
            {
                var query = Db.KhachHangs
               .Where(kh => kh.TenKH == name)
               .OrderBy(kh => kh.MaKH)
               .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
            else
            {
                var query = Db.KhachHangs
              .Where(kh => kh.TenKH == name)
              .OrderByDescending(kh => kh.MaKH)
              .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
        }
        public DataTable findByPhone(string phone, string typeSort)
        {
            if (typeSort == "ASC")
            {
                var query = Db.KhachHangs
                 .Where(kh => kh.Dienthoai == phone)
                 .OrderBy(kh => kh.MaKH)
                 .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
            else
            {
                var query = Db.KhachHangs
                 .Where(kh => kh.Dienthoai == phone)
                 .OrderByDescending(kh => kh.MaKH)
                 .ToList();

                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
        }
        public DataTable findByAddress(string address, string typeSort)
        {
            if (typeSort == "ASC")
            {
                var query = Db.KhachHangs
              .Where(kh => kh.DiaChi == address)
              .OrderBy(kh => kh.MaKH)
              .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
            else
            {
                var query = Db.KhachHangs
              .Where(kh => kh.DiaChi == address)
              .OrderByDescending(kh => kh.MaKH)
              .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
        }


    }

}

