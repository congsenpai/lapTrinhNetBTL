using QuanLyCuaHangMayTinh.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyCuaHangMayTinh.Presenter
{
    internal class PreLogin
    {
        Entity db = new Entity();
        public Entity Db { get => db; set => db = value; }

        public bool findByID(string tk, string mk)
        {
            bool accountExists = Db.loginAccouts
                 .Any(kh => kh.MaNV == tk && kh.Password == mk);

            return accountExists;
        }

    }

}
