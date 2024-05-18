using QuanLyCuaHangMayTinh.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace QuanLyCuaHangMayTinh.Presenter
{
    public class PreCustomer
    {
        Entity db= new Entity();
        prsMain pre= new prsMain();
        public Entity Db { get => db; set => db = value; }

        private List<KhachHang> listCustomer()
        {
            var khachhangs = Db.KhachHangs.ToList();
            return khachhangs;
        }
        private List<NhanVien> listEmployee()
        {
            var nhanviens = Db.NhanViens.ToList();
            return nhanviens;
        }
        public DataTable loadDTGV()
        {
            var khachHangs = listCustomer();
            DataTable a = pre.ConvertToDataTable(khachHangs);
            return a;
        }

        public DataTable loadCreateManBox()
        {
            var nhanViens = listEmployee();
            DataTable a = pre.ConvertToDataTable(nhanViens);
            return a;
        }
    }
}
