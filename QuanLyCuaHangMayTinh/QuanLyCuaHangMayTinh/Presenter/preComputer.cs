using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangMayTinh.Model;
using QuanLyCuaHangMayTinh.Presenter;

namespace QuanLyCuaHangMayTinh.Presenter
{


    public class PreComputer
    {
        PreMain prs = new PreMain();
        Entity db = new Entity();


        public Entity Db { get => db; set => db = value; }
        public int checkAmount(String MaMVT)
        {
            var result = Db.MayVTs
            .Where(b => b.MaMVT == MaMVT)
            .Select(b => b.SoLuong)
            .FirstOrDefault();
            return (int)result;
        }

        // Call List From DB
        private List<MayVT> listComputer()
        {
            var computers = Db.MayVTs.ToList();
            return computers;
        }
        private List<LoaiMay> listComputerType()
        {
            var type = Db.LoaiMays.ToList();
            return type;
        }
        private List<Chip> listChip()
        {
            var chip = Db.Chips.ToList();
            return chip;
        }
        private List<OCung> listOCung()
        {
            var O = Db.OCungs.ToList();
            return O;
        }
        private List<OCD> listOCD()
        {
            var OCD = Db.OCDs.ToList();
            return OCD;
        }
        private List<CoMH> listCoMH()
        {
            var co = Db.CoMHs.ToList();
            return co;
        }
        private List<USB> listUSB()
        {
            var USB = Db.USBs.ToList();
            return USB;
        }
        private List<Ram> listRam()
        {
            var type = Db.Rams.ToList();
            return type;
        }
        private List<HangSX> listHSX()
        {
            var type = Db.HangSXes.ToList();
            return type;
        }
        private List<TocDo> listTocDo()
        {
            var type = Db.TocDoes.ToList();
            return type;
        }
        private List<Dungluong> listDL()
        {
            var type = Db.Dungluongs.ToList();
            return type;
        }
        private List<ManHinh> listMH()
        {
            var type = Db.ManHinhs.ToList();
            return type;
        }
        private List<Chuot> listMouse()
        {
            var type = Db.Chuots.ToList();
            return type;
        }
        private List<BanPhim> listBP()
        {
            var type = Db.BanPhims.ToList();
            return type;
        }
        private List<Loa> listLoa()
        {
            var type = Db.Loas.ToList();
            return type;
        }

        // Convert to Datatable

        public DataTable loadComputerType()
        {

            var type = listComputerType();
            DataTable a = prs.ConvertToDataTable(type);
            return a;
        }
        public DataTable loadComputer()
        {

            var computers = listComputer();
            DataTable a = prs.ConvertToDataTable(computers);
            return a;
        }
        public DataTable loadChip()
        {

            var computers = listChip();
            DataTable a = prs.ConvertToDataTable(computers);
            return a;
        }
        public DataTable loadOCung()
        {

            var computers = listOCung();
            DataTable a = prs.ConvertToDataTable(computers);
            return a;
        }
        public DataTable loadOCD()
        {

            var computers = listOCD();
            DataTable a = prs.ConvertToDataTable(computers);
            return a;
        }
        public DataTable loadCoManHinh()
        {

            var computers = listCoMH();
            DataTable a = prs.ConvertToDataTable(computers);
            return a;
        }
        public DataTable loadUSB()
        {

            var computers = listUSB();
            DataTable a = prs.ConvertToDataTable(computers);
            return a;
        }
        public DataTable loadRam()
        {

            var computers = listRam();
            DataTable a = prs.ConvertToDataTable(computers);
            return a;
        }
        public DataTable loadHSX()
        {

            var computers = listHSX();
            DataTable a = prs.ConvertToDataTable(computers);
            return a;
        }
        public DataTable loadTocDo()
        {

            var computers = listTocDo();
            DataTable a = prs.ConvertToDataTable(computers);
            return a;
        }
        public DataTable loadDungLuong()
        {

            var computers = listDL();
            DataTable a = prs.ConvertToDataTable(computers);
            return a;
        }
        public DataTable loadScreen()
        {

            var computers = listMH();
            DataTable a = prs.ConvertToDataTable(computers);
            return a;
        }
        public DataTable loadChuot()
        {

            var computers = listMouse();
            DataTable a = prs.ConvertToDataTable(computers);
            return a;
        }
        public DataTable loadKeyBoard()
        {

            var computers = listBP();
            DataTable a = prs.ConvertToDataTable(computers);
            return a;
        }
        public DataTable loadSpeaker()
        {

            var computers = listLoa();
            DataTable a = prs.ConvertToDataTable(computers);
            return a;
        }

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
            dataTable.Columns.Add("Ghi chú", typeof(string));
            dataTable.Columns.Add("Ảnh", typeof(string));

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
                        b.HangSX.TenHSX,
                        b.Ghichu,
                        b.Anh
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
                    row["Ghi chú"] = comp["Ghichu"];
                    row["Ảnh"] = result.Anh != null ? Convert.ToBase64String(result.Anh) : string.Empty; // Chuyển đổi kiểu dữ liệu sang dạng base64String
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
            return a;
        }
        public void AddMayVT(string TenMVT, string Loai, string Chip, String OC,
            string DL, string TD, string OCD, string MH, string CoMH, string Chuot,
            string BP, string USB, string Ram, string Loa, string HSX, double giaNhap,
            double giaBan, DateTime Thoigianhientai, byte[] imageData, string ghiChu)
        {
            DateTime baoHanh = Thoigianhientai.AddYears(2);
            MayVT newMayVT = new MayVT();
            newMayVT.addData(TenMVT, Loai, Chip, OC, DL, TD, OCD, MH, CoMH, Chuot, BP, USB, Ram, Loa, HSX, giaNhap, giaBan, baoHanh, imageData, ghiChu);

        }

    }

}






