using QuanLyCuaHangMayTinh.Model;
using System.Linq;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
namespace QuanLyCuaHangMayTinh.Presenter
{

    public class prsMain
    {
        public String takeCode(string className)
        {
            switch (className)
            {
                case "BanPhim":
                    BanPhim bp = new BanPhim();
                    return bp.autoGenCode();

                case "Chip":
                    Chip c = new Chip();
                    return c.autoGenCode();

                // Thêm các trường hợp khác cần xử lý ở đây

                default:
                    return "Error Class Name";
            }
        }
        public void addBanPhim(string Name)
        {
            BanPhim b = new BanPhim();
            b.addData(Name);
        }
        public void removeBanPhim(string ID)
        {
            BanPhim banPhim = new BanPhim();
            banPhim.removeData(ID);
        }
    }
}
