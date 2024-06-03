using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangMayTinh.Model;
using QuanLyCuaHangMayTinh.Presenter;

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
<<<<<<< Updated upstream
        public DataTable findComputer(string SearchString)
        {
            var computers = Db.MayVTs
                      .Where(m => m.TenMVT.Contains(SearchString) || m.MaMVT.Contains(SearchString))
                      .ToList();
            DataTable a= prsMain.ConvertToDataTable(computers);
=======
        public DataTable ComputerListHasName(DataTable a)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Mã máy", typeof(string));
            dataTable.Columns.Add("Tên máy", typeof(string));
            dataTable.Columns.Add("Loại máy", typeof(string));
            dataTable.Columns.Add("Chip", typeof(string));
            dataTable.Columns.Add("Ổ cứng", typeof(string));
            dataTable.Columns.Add("Dung lượng", typeof(string));
            dataTable.Columns.Add("Tốc độ", typeof(string));
            dataTable.Columns.Add("OCD", typeof(string));
            dataTable.Columns.Add("Loại Màn hình", typeof(string));
            dataTable.Columns.Add("Cỡ màn hình", typeof(string));
            dataTable.Columns.Add("Chuột", typeof(string));
            dataTable.Columns.Add("Bàn phím", typeof(string));
            dataTable.Columns.Add("USB", typeof(string));
            dataTable.Columns.Add("Ram", typeof(string));
            dataTable.Columns.Add("Loa", typeof(string));
            dataTable.Columns.Add("Hãng sản xuất", typeof(string));
            dataTable.Columns.Add("Giá nhập", typeof(string));
            dataTable.Columns.Add("Giá bán", typeof(string));
            dataTable.Columns.Add("Thời gian bảo hành", typeof(string));
            dataTable.Columns.Add("Số lượng", typeof(string));

            foreach (DataRow comp in a.Rows)
            {
                string maMVT = comp["MaMVT"].ToString();

                var result = Db.MayVTs
                    .Where(b => b.MaMVT == maMVT)
                    .Select(b => new
                    {
                        b.MaMVT,
                        b.LoaiMay.TenLm,
                        b.Chip.TenChip,
                        b.OCung.TenOC,
                        b.Dungluong.TenDL,
                        b.TocDo.TenTD,
                        b.OCD.TenO,
                        b.ManHinh.TenMH,
                        b.CoMH.TenCo,
                        b.Chuot.TenChuot,
                        b.BanPhim.TenBP,
                        b.USB.TenOUSB,
                        b.Ram.TenR,
                        b.Loa.TenLoa,
                        b.HangSX.TenHSX
                    })
                    .FirstOrDefault();

                if (result != null)
                {
                    DataRow row = dataTable.NewRow();
                    row["Mã máy"] = comp["MaMVT"];
                    row["Tên máy"] = comp["TenMVT"];
                    row["Loại máy"] = result.TenLm;
                    row["Chip"] = result.TenChip;
                    row["Ổ cứng"] = result.TenOC;
                    row["Dung lượng"] = result.TenDL;
                    row["Tốc độ"] = result.TenTD;
                    row["OCD"] = result.TenO;
                    row["Loại Màn hình"] = result.TenMH;
                    row["Cỡ màn hình"] = result.TenCo;
                    row["Chuột"] = result.TenChuot;
                    row["Bàn phím"] = result.TenBP;
                    row["USB"] = result.TenOUSB;
                    row["Ram"] = result.TenR;
                    row["Loa"] = result.TenLoa;
                    row["Hãng sản xuất"] = result.TenHSX;
                    row["Giá nhập"] = comp["Gianhap"];
                    row["Giá bán"] = comp["Giaban"];
                    row["Thời gian bảo hành"] = comp["ThoiGianBH"];
                    row["Số lượng"] = comp["SoLuong"];
                    dataTable.Rows.Add(row);
                }
            }

            return dataTable;
        }

        public DataTable findComputer(string SearchString)
        {
            var computers = Db.MayVTs
                      .Where(m => m.TenMVT.Contains(SearchString) || m.MaMVT.Contains(SearchString))
                      .ToList();
            DataTable a = prs.ConvertToDataTable(computers);
            return a;
        }
        public DataTable findbyLoaiMay(string type)
        {
            var query = Db.MayVTs
                .Where(m => m.LoaiMay.MaLm.Contains(type) || m.LoaiMay.TenLm.Contains(type))
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyChip(string chip)
        {
            var query = Db.MayVTs
                  .Where(m => m.Chip.MaChip.Contains(chip) || m.Chip.TenChip.Contains(chip))
                  .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyOC(string oc)
        {
            var query = Db.MayVTs
                   .Where(m => m.OCung.MaOC.Contains(oc) || m.OCung.TenOC.Contains(oc))
                   .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyO(string o)
        {
            var query = Db.MayVTs
               .Where(m => m.OCD.MaO.Contains(o) || m.OCD.TenO.Contains(o))
               .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyCo(string co)
        {
            var query = Db.MayVTs
               .Where(m => m.CoMH.MaCo.Contains(co) || m.CoMH.TenCo.Contains(co))
               .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyUSB(string usb)
        {
            var query = Db.MayVTs
                .Where(m => m.USB.MaOUSB.Contains(usb) || m.USB.TenOUSB.Contains(usb))
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyRAM(string ram)
        {
            var query = Db.MayVTs
                .Where(m => m.Ram.MaR.Contains(ram) || m.Ram.TenR.Contains(ram))
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyNSX(string nsx)
        {
            var query = Db.MayVTs
               .Where(m => m.HangSX.MaHSX.Contains(nsx) || m.HangSX.TenHSX.Contains(nsx))
               .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyTocdo(string spd)
        {
            var query = Db.MayVTs
                           .Where(m => m.TocDo.MaTD.Contains(spd) || m.TocDo.TenTD.Contains(spd))
                           .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyDL(string dluong)
        {
            var query = Db.MayVTs
                           .Where(m => m.Dungluong.MaDL.Contains(dluong) || m.Dungluong.TenDL.Contains(dluong))
                           .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyScreen(string screen)
        {
            var query = Db.MayVTs
               .Where(m => m.ManHinh.MaMH.Contains(screen) || m.ManHinh.TenMH.Contains(screen))
               .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyMouse(string mouse)
        {
            var query = Db.MayVTs
                .Where(m => m.Chuot.MaChuot.Contains(mouse) || m.Chuot.TenChuot.Contains(mouse))
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyKeyboard(string keybd)
        {
            var query = Db.MayVTs
               .Where(m => m.BanPhim.MaBP.Contains(keybd) || m.BanPhim.TenBP.Contains(keybd))
               .ToList();
            DataTable a = prs.ConvertToDataTable(query);
            return a;
        }
        public DataTable findbyLoa(string spkr)
        {
            var query = Db.MayVTs
                .Where(m => m.Loa.MaLoa.Contains(spkr) || m.Loa.TenLoa.Contains(spkr))
                .ToList();
            DataTable a = prs.ConvertToDataTable(query);
>>>>>>> Stashed changes
            return a;
        }

    }
}






