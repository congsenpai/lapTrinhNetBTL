using QuanLyCuaHangMayTinh.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangMayTinh.Views
{
    public partial class ThemHangHoa : Form
    {
        preComputer present = new preComputer();
        public ThemHangHoa()
        {
            InitializeComponent();
            loadCBInFormAdd();
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

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                imgMayTinh.Image = Image.FromFile(filePath);
            }
        }

    }
}
