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
    public class PreSupplier
    {
        Entity db = new Entity();
        PreMain pre = new PreMain();
        public Entity Db { get => db; set => db = value; }

        private List<NhaCC> listSupplier()
        {
            var suppliers = Db.NhaCCs.ToList();
            return suppliers;
        }
        public void AddSupplier(String TenNCC, String DiaChi, String SoDienThoai)
        {
            NhaCC a = new NhaCC();
            NhaCC NhaCCMoi = new NhaCC
            {
                TenNCC = TenNCC,
                DiaChi = DiaChi,
                Dienthoai = SoDienThoai
            };
            a.addData(NhaCCMoi);
        }
        public DataTable loadSupplier()
        {
            var NCCs = listSupplier();
            DataTable a = pre.ConvertToDataTable(NCCs);
            return a;
        }
                public DataTable findByID(string id, string typeSort)
        {
            if (typeSort == "ASC")
            {
                var query = Db.NhaCCs
                 .Where(NCC => NCC.MaNCC == id)
                 .OrderBy(NCC => NCC.MaNCC)
                 .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
            else
            {
                var query = Db.NhaCCs
               .Where(NCC => NCC.MaNCC == id)
               .OrderByDescending(NCC => NCC.MaNCC)
               .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }

        }
        public DataTable findByName(string name, string typeSort)
        {
            if (typeSort == "ASC")
            {
                var query = Db.NhaCCs
               .Where(NCC => NCC.TenNCC == name)
               .OrderBy(NCC => NCC.MaNCC)
               .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
            else
            {
                var query = Db.NhaCCs
              .Where(NCC => NCC.TenNCC == name)
              .OrderByDescending(NCC => NCC.MaNCC)
              .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
        }
        public DataTable findByPhone(string phone, string typeSort)
        {
            if (typeSort == "ASC")
            {
                var query = Db.NhaCCs
                 .Where(NCC => NCC.Dienthoai == phone)
                 .OrderBy(NCC => NCC.MaNCC)
                 .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
            else
            {
                var query = Db.NhaCCs
                 .Where(NCC => NCC.Dienthoai == phone)
                 .OrderByDescending(NCC => NCC.MaNCC)
                 .ToList();

                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
        }
        public DataTable findByAddress(string address, string typeSort)
        {
            if (typeSort == "ASC")
            {
                var query = Db.NhaCCs
              .Where(NCC => NCC.DiaChi == address)
              .OrderBy(NCC => NCC.MaNCC)
              .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
            else
            {
                var query = Db.NhaCCs
              .Where(NCC => NCC.DiaChi == address)
              .OrderByDescending(NCC => NCC.MaNCC)
              .ToList();
                DataTable a = pre.ConvertToDataTable(query);
                return a;
            }
        }
    }
}