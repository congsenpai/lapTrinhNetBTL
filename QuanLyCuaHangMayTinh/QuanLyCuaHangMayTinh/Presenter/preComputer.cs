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
        prsMain prs = new prsMain();
        Entity db = new Entity();


        public Entity Db { get => db; set => db = value; }
        public List<MayVT> listComputer()
        {
            var computers = Db.MayVTs.ToList();
            return computers;
        }
        public DataTable loadComputer()
        {

            var computers = listComputer();
            DataTable a = prs.ConvertToDataTable(computers);
            return a;
        }
        public DataTable findbyTenMay(string name)
        {
            var query = Db.MayVTs
                .Where(m => m.TenMVT == name)
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyLoaiMay(string type)
        {
            var query = Db.MayVTs
                .Where(m => m.MaLm == type)
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyChip(string chip)
        {
            var query = Db.MayVTs
                .Where(m => m.MaChip == chip)
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyOC(string oc)
        {
            var query = Db.MayVTs
                .Where(m => m.MaOC == oc)
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyO(string o)
        {
            var query = Db.MayVTs
                .Where(m => m.MaO == o)
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyCo(string co)
        {
            var query = Db.MayVTs
                .Where(m => m.MaCo == co)
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyUSB(string usb)
        {
            var query = Db.MayVTs
                .Where(m => m.MaOUSB == usb)
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyRAM(string ram)
        {
            var query = Db.MayVTs
                .Where(m => m.MaR == ram)
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyNSX(string nsx)
        {
            var query = Db.MayVTs
                .Where(m => m.MaHSX == nsx)
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyTocdo(string spd)
        {
            var query = Db.MayVTs
                .Where(m => m.MaTD == spd)
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyDL(string dluong)
        {
            var query = Db.MayVTs
                .Where(m => m.MaDL == dluong)
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyScreen(string screen)
        {
            var query = Db.MayVTs
                .Where(m => m.MaMH == screen)
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyMouse(string mouse)
        {
            var query = Db.MayVTs
                .Where(m => m.MaChuot == mouse)
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyKeyboard(string keybd)
        {
            var query = Db.MayVTs
                .Where(m => m.MaBP == keybd)
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyLoa(string spkr)
        {
            var query = Db.MayVTs
                .Where(m => m.MaLoa == spkr)
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
    }
}
