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
        prsMain prsMain=new prsMain();
        Entity db=new Entity();
       

        public Entity Db { get => db; set => db = value; }
        public List<NhanVien> listEmployee()
        {
            var nhanviens= Db.NhanViens.ToList();
            return nhanviens;
        }
        public DataTable loadEmployee()
        {

                var nhanViens = listEmployee();
                DataTable a = prsMain.ConvertToDataTable(nhanViens);
                return a;
        }
    }
}
