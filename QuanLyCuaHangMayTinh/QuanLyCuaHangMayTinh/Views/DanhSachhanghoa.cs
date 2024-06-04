﻿using QuanLyCuaHangMayTinh.Presenter;
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
    public partial class DanhSachhanghoa : Form
    {
        preComputer present = new preComputer();
        public DanhSachhanghoa()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            InitializeRadioButtons();
        }

        private void hanghoa_Load(object sender, EventArgs e)
        {
            DTGV.DataSource = present.ComputerListHasName(present.loadComputer());
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (rdTenMay.Checked==true)
            {
                DTGV.DataSource = present.ComputerListHasName(present.findComputer(txtSearch.Text));
            }
            if (rdLoaiMay.Checked==true)
            {
                DTGV.DataSource = present.ComputerListHasName(present.findbyLoaiMay(txtSearch.Text));
            }
            if (rdLoaiChip.Checked==true)
            {
                DTGV.DataSource = present.ComputerListHasName(present.findbyChip(txtSearch.Text));
            }
            if (rdOCung.Checked==true)
            {
                DTGV.DataSource = present.ComputerListHasName(present.findbyOC(txtSearch.Text));
            }
            if (rdOCD.Checked==true)
            {
                DTGV.DataSource = present.ComputerListHasName(present.findbyO(txtSearch.Text));
            }
            if (rdCoManHinh.Checked==true)
            {
                DTGV.DataSource = present.ComputerListHasName(present.findbyCo(txtSearch.Text));
            }
            if (rdUSB.Checked==true)
            {
                DTGV.DataSource = present.ComputerListHasName(present.findbyUSB(txtSearch.Text));
            }
            if (rdRam.Checked==true)
            {
                DTGV.DataSource = present.ComputerListHasName(present.findbyRAM(txtSearch.Text));
            }
            if (rdHSX.Checked==true)
            {
                DTGV.DataSource = present.ComputerListHasName(present.findbyNSX(txtSearch.Text));
            }
            if (rdTD.Checked==true)
            {
                DTGV.DataSource = present.ComputerListHasName(present.findbyTocdo(txtSearch.Text));
            }
            if (rdDL.Checked==true)
            {
                DTGV.DataSource = present.ComputerListHasName(present.findbyDL(txtSearch.Text));
            }
            if (rdManHinh.Checked==true)
            {
                DTGV.DataSource = present.ComputerListHasName(present.findbyScreen(txtSearch.Text));
            }
            if (rdMouse.Checked==true)
            {
                DTGV.DataSource = present.ComputerListHasName(present.findbyMouse(txtSearch.Text));
            }
            if (rdKeyBoard.Checked==true)
            {
                DTGV.DataSource = present.ComputerListHasName(present.findbyKeyboard(txtSearch.Text));
            }
            if (rdSpeaker.Checked==true)
            {
                DTGV.DataSource = present.ComputerListHasName(present.findbyLoa(txtSearch.Text));
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DTGV.DataSource = present.ComputerListHasName(present.loadComputer());
        }
        private void InitializeRadioButtons()
        {
            // Thêm sự kiện CheckedChanged cho tất cả các radio button trong các FlowLayoutPanel
            foreach (RadioButton radioButton in flowLayoutPanel1.Controls)
            {
                radioButton.CheckedChanged += RadioButton_CheckedChanged;
            }

            foreach (RadioButton radioButton in flowLayoutPanel2.Controls)
            {
                radioButton.CheckedChanged += RadioButton_CheckedChanged;
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem radio button nào đã được chọn
            RadioButton selectedRadioButton = (RadioButton)sender;

            // Lấy FlowLayoutPanel chứa radio button đó
            FlowLayoutPanel parentPanel = (FlowLayoutPanel)selectedRadioButton.Parent;

            // Nếu radio button được chọn thuộc về flowLayoutPanel1
            // Thì uncheck tất cả các radio button trong flowLayoutPanel2
            if (parentPanel == flowLayoutPanel1)
            {
                foreach (RadioButton radioButton in flowLayoutPanel2.Controls)
                {
                    radioButton.Checked = false;
                }
            }
            // Ngược lại, uncheck tất cả các radio button trong flowLayoutPanel1
            else if (parentPanel == flowLayoutPanel2)
            {
                foreach (RadioButton radioButton in flowLayoutPanel1.Controls)
                {
                    radioButton.Checked = false;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemHangHoa form = new ThemHangHoa();
            form.Show();
        }

        private void DTGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ThemHangHoa form = new ThemHangHoa();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row= this.DTGV.Rows[e.RowIndex];
                form.txtTenMVT.Text = row.Cells["Tên máy"].Value.ToString();
                form.cbLoaiMay.Text = row.Cells["Loại máy"].Value.ToString();
                form.cbChip.Text = row.Cells["Chip"].Value.ToString();
                form.cbOCung.Text = row.Cells["Ổ cứng"].Value.ToString();
                form.cbDungLuong.Text = row.Cells["Dung lượng"].Value.ToString();
                form.cbTocDo.Text = row.Cells["Tốc độ"].Value.ToString();
                form.cbOCD.Text = row.Cells["OCD"].Value.ToString();
                form.cbManHinh.Text = row.Cells["Loại màn hình"].Value.ToString();
                form.cbCoMH.Text = row.Cells["Cỡ màn hình"].Value.ToString();
                form.cbChuot.Text = row.Cells["Chuột"].Value.ToString();
                form.cbBanPhim.Text = row.Cells["Bàn phím"].Value.ToString();
                form.cbUSB.Text = row.Cells["USB"].Value.ToString();
                form.cbRam.Text = row.Cells["Ram"].Value.ToString();
                form.cbLoa.Text = row.Cells["Loa"].Value.ToString();
                form.cbHSX.Text = row.Cells["Hãng sản xuất"].Value.ToString();
                form.txtGiaNhap.Text = row.Cells["Giá nhập"].Value.ToString();
                form.txtGiaBan.Text = row.Cells["Giá bán"].Value.ToString();
                form.txtBaoHanh.Text = row.Cells["Thời gian bảo hành"].Value.ToString();
                form.txtSoluong.Text = row.Cells["Số lượng"].Value.ToString();
                string imageDataString = row.Cells["Ảnh"].Value.ToString();
                byte[] imageData = Convert.FromBase64String(imageDataString);
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    form.imgMayTinh.Image = Image.FromStream(ms);
                }
                form.txtNote.Text = row.Cells["Ghi chú"].Value.ToString();
            }
            form.Show();
        }
    }
}
