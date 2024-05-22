using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangMayTinh.Model;
namespace QuanLyCuaHangMayTinh.Presenter
{
    public class PreSale
    {
        Entity db= new Entity();

        public Entity Db { get => db; set => db = value; }
        prsMain prsMain = new prsMain();
        PreCustomer customers= new PreCustomer();
        preEmployee employees=new preEmployee();
        preComputer computers=new preComputer();
        
    }
}
