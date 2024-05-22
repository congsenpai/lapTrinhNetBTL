using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangMayTinh.Model;

namespace QuanLyCuaHangMayTinh.Presenter
{


    public class preComputer
    {
        prsMain prsMain = new prsMain();
        Entity db = new Entity();


        public Entity Db { get => db; set => db = value; }
        public List<MayVT> listComputer()
        {
            var computers = Db.MayVTs.ToList();
            return computers;
        }
        public DataTable loadComputer()
        {

            var computers=listComputer();
            DataTable a = prsMain.ConvertToDataTable(computers);
            return a;
        }
        public DataTable findComputer(string SearchString)
        {
            var computers = Db.MayVTs
                      .Where(m => m.TenMVT.Contains(SearchString) || m.MaMVT.Contains(SearchString))
                      .ToList();
            DataTable a= prsMain.ConvertToDataTable(computers);
            return a;
        }
    }
}
