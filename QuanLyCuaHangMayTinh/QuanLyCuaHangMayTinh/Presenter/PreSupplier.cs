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
        prsMain pre = new prsMain();
        public Entity Db { get => db; set => db = value; }

        private List<NhaCC> listSupplier()
        {
            var suppliers = Db.NhaCCs.ToList();
            return suppliers;
        }
        public DataTable loadSupplier()
        {
            var NCCs = listSupplier();
            DataTable a = pre.ConvertToDataTable(NCCs);
            return a;
        }
        public bool CheckExits(String MaNCC)
        {
            return Db.NhaCCs.Any(nv => nv.MaNCC == MaNCC);
        }
    }
}