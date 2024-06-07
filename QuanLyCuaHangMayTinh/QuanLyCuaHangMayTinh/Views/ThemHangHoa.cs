using QuanLyCuaHangMayTinh.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangMayTinh.Views
{
    public partial class ThemHangHoa : Form
    {
        PreComputer present = new PreComputer();
        PreMain PreMain = new PreMain();
        byte[] imageData;
        public ThemHangHoa()
        {
            InitializeComponent();
            loadCBInFormAdd();
            btnLuu.Enabled = false;
            txtBaoHanh.Enabled = false;
            txtSoluong.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có muốn hủy bỏ việc thêm không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void loadCBInFormAdd()
        {
            // Loai May Tinh
            DataTable type = present.loadComputerType();

            if (type != null && type.Rows.Count > 0)
            {
                foreach (DataRow row in type.Rows)
                {
                    cbLoaiMay.Items.Add(row["TenLm"].ToString());
                }
            }
            // Loai Chip
            DataTable chip = present.loadChip();

            if (chip != null && chip.Rows.Count > 0)
            {
                foreach (DataRow row in chip.Rows)
                {
                    cbChip.Items.Add(row["TenChip"].ToString());
                }
            }
            // Loai O Cung
            DataTable Ocung = present.loadOCung();

            if (Ocung != null && Ocung.Rows.Count > 0)
            {
                foreach (DataRow row in Ocung.Rows)
                {
                    cbOCung.Items.Add(row["TenOC"].ToString());
                }
            }
            // Loai OCD
            DataTable OCD = present.loadOCD();

            if (OCD != null && OCD.Rows.Count > 0)
            {
                foreach (DataRow row in OCD.Rows)
                {
                    cbOCD.Items.Add(row["TenO"].ToString());
                }
            }
            // Co Man Hinh
            DataTable CoMH = present.loadCoManHinh();

            if (CoMH != null && CoMH.Rows.Count > 0)
            {
                foreach (DataRow row in CoMH.Rows)
                {
                    cbCoMH.Items.Add(row["TenCo"].ToString());
                }
            }

            // O USB
            DataTable USB = present.loadUSB();

            if (USB != null && USB.Rows.Count > 0)
            {
                foreach (DataRow row in USB.Rows)
                {
                    cbUSB.Items.Add(row["TenOUSB"].ToString());
                }
            }
            // Ram
            DataTable Ram = present.loadRam();

            if (Ram != null && Ram.Rows.Count > 0)
            {
                foreach (DataRow row in Ram.Rows)
                {
                    cbRam.Items.Add(row["TenR"].ToString());
                }
            }
            // Hang
            DataTable HSX = present.loadHSX();

            if (HSX != null && HSX.Rows.Count > 0)
            {
                foreach (DataRow row in HSX.Rows)
                {
                    cbHSX.Items.Add(row["TenHSX"].ToString());
                }
            }
            // Toc Do
            DataTable Speed = present.loadTocDo();

            if (Speed != null && Speed.Rows.Count > 0)
            {
                foreach (DataRow row in Speed.Rows)
                {
                    cbTocDo.Items.Add(row["TenTD"].ToString());
                }
            }
            // Dung Luong
            DataTable dungLuong = present.loadDungLuong();

            if (dungLuong != null && dungLuong.Rows.Count > 0)
            {
                foreach (DataRow row in dungLuong.Rows)
                {
                    cbDungLuong.Items.Add(row["TenDL"].ToString());
                }
            }
            // Man Hinh
            DataTable scr = present.loadScreen();

            if (scr != null && scr.Rows.Count > 0)
            {
                foreach (DataRow row in scr.Rows)
                {
                    cbManHinh.Items.Add(row["TenMH"].ToString());
                }
            }
            // Chuot 
            DataTable mouse = present.loadChuot();
            if (mouse != null && mouse.Rows.Count > 0)
            {
                foreach (DataRow row in mouse.Rows)
                {
                    cbChuot.Items.Add(row["TenChuot"].ToString());
                }
            }
            // Ban Phim
            DataTable keyboard = present.loadKeyBoard();

            if (keyboard != null && keyboard.Rows.Count > 0)
            {
                foreach (DataRow row in keyboard.Rows)
                {
                    cbBanPhim.Items.Add(row["TenBP"].ToString());
                }
            }
            // Loa
            DataTable speaker = present.loadSpeaker();

            if (speaker != null && speaker.Rows.Count > 0)
            {
                foreach (DataRow row in speaker.Rows)
                {
                    cbLoa.Items.Add(row["TenLoa"].ToString());
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkInvalid() == false)
            {
                string MaLm = PreMain.getCodeByNameChoice(cbLoaiMay.Text, "LM");
                string MaChip = PreMain.getCodeByNameChoice(cbChip.Text, "Chip");
                String MaOC = PreMain.getCodeByNameChoice(cbOCung.Text, "OC");
                String MaDL = PreMain.getCodeByNameChoice(cbDungLuong.Text, "DL");
                String MaTD = PreMain.getCodeByNameChoice(cbTocDo.Text, "TD");
                String MaO = PreMain.getCodeByNameChoice(cbOCD.Text, "OCD");
                String MaMH = PreMain.getCodeByNameChoice(cbManHinh.Text, "MH");
                String MaCo = PreMain.getCodeByNameChoice(cbCoMH.Text, "COMH");
                String MaChuot = PreMain.getCodeByNameChoice(cbChuot.Text, "C");
                String MaBP = PreMain.getCodeByNameChoice(cbBanPhim.Text, "BP");
                String MaOUSB = PreMain.getCodeByNameChoice(cbUSB.Text, "USB");
                String MaR = PreMain.getCodeByNameChoice(cbRam.Text, "RAM");
                String MaLoa = PreMain.getCodeByNameChoice(cbLoa.Text, "LOA");
                String MaHSX = PreMain.getCodeByNameChoice(cbHSX.Text, "HSX");
                DataTable a = present.loadComputer();
                bool found = false;
                foreach (DataRow row in a.Rows)
                {
                    if (row["TenMVT"].ToString() == txtTenMVT.Text)
                    {
                        MessageBox.Show("Máy tính này đã tồn tại trong CSDL", "Thông báo", MessageBoxButtons.OK);
                        found = true;
                        return;
                    }
                }
                double Giaban = Convert.ToDouble(txtGiaBan.Text);
                double Gianhap = Convert.ToDouble(txtGiaNhap.Text);
                DateTime thoiGianHienTai = DateTime.Now;
                if (found == false)
                {
                    present.AddMayVT(txtTenMVT.Text, MaLm, MaChip, MaOC,
                        MaDL, MaTD, MaO, MaMH, MaCo, MaChuot, MaBP,
                        MaOUSB, MaR, MaLoa, MaHSX, Giaban, Gianhap, thoiGianHienTai, imageData, txtNote.Text);
                    MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                    reSetForm();
                    return;
                }
            }
        }
        private void reSetForm()
        {
            txtTenMVT.Text = "";
            txtNote.Text = "";
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
            cbBanPhim.Text = "";
            cbChip.Text = "";
            cbChuot.Text = "";
            cbCoMH.Text = "";
            cbDungLuong.Text = "";
            cbHSX.Text = "";
            cbLoa.Text = "";
            cbLoaiMay.Text = "";
            cbManHinh.Text = "";
            cbOCD.Text = "";
            cbOCung.Text = "";
            cbRam.Text = "";
            cbTocDo.Text = "";
            cbUSB.Text = "";
            imgMayTinh.Image = null;

        }
        private bool checkInvalid()
        {
            if (txtTenMVT.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Tên máy vi tính", "Thông báo", MessageBoxButtons.OK);
                txtTenMVT.Focus();
                return true;
            }
            if (cbLoaiMay.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn loại máy", "Thông báo", MessageBoxButtons.OK);
                cbLoaiMay.Focus();
                return true;
            }
            if (cbChip.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn loại Chip", "Thông báo", MessageBoxButtons.OK);
                cbChip.Focus();
                return true;
            }
            if (cbOCung.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn ổ cứng", "Thông báo", MessageBoxButtons.OK);
                cbOCung.Focus();
                return true;
            }
            if (cbOCD.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn loại OCD", "Thông báo", MessageBoxButtons.OK);
                cbOCD.Focus();
                return true;
            }
            if (cbCoMH.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn cỡ màn hình", "Thông báo", MessageBoxButtons.OK);
                cbCoMH.Focus();
                return true;
            }
            if (cbUSB.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn ổ USB", "Thông báo", MessageBoxButtons.OK);
                cbUSB.Focus();
                return true;
            }
            if (cbRam.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn Ram", "Thông báo", MessageBoxButtons.OK);
                cbRam.Focus();
                return true;
            }
            if (cbHSX.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn hãng sản xuất", "Thông báo", MessageBoxButtons.OK);
                cbHSX.Focus();
                return true;
            }
            if (cbTocDo.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn tốc độ", "Thông báo", MessageBoxButtons.OK);
                cbTocDo.Focus();
                return true;
            }
            if (cbDungLuong.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn dung lượng", "Thông báo", MessageBoxButtons.OK);
                cbDungLuong.Focus();
                return true;
            }
            if (cbManHinh.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn loại màn hình", "Thông báo", MessageBoxButtons.OK);
                cbManHinh.Focus();
                return true;
            }
            if (cbChuot.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn chuột", "Thông báo", MessageBoxButtons.OK);
                cbChuot.Focus();
                return true;
            }
            if (cbBanPhim.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bàn phím", "Thông báo", MessageBoxButtons.OK);
                cbBanPhim.Focus();
                return true;
            }
            if (cbLoa.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn loa", "Thông báo", MessageBoxButtons.OK);
                cbLoa.Focus();
                return true;
            }
            if (txtGiaBan.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập giá bán", "Thông báo", MessageBoxButtons.OK);
                txtGiaBan.Focus();
                return true;
            }
            if (txtGiaNhap.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập giá nhập", "Thông báo", MessageBoxButtons.OK);
                txtGiaNhap.Focus();
                return true;
            }
            if (imageData == null)
            {
                MessageBox.Show("Bạn hãy vui lòng chọn ảnh", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            string imgFilePath = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgFilePath = openFileDialog.FileName;
                imgMayTinh.Image = Image.FromFile(imgFilePath);
            }
            using (FileStream stream = new FileStream(imgFilePath, FileMode.Open, FileAccess.Read))
            {
                imageData = new byte[stream.Length];
                stream.Read(imageData, 0, (int)stream.Length);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            reSetForm();
            MessageBox.Show("Bạn đang trong chế độ thêm mới", " Thông báo", MessageBoxButtons.OK);
            btnLuu.Enabled = true;
            return;
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
