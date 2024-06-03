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
    public partial class hanghoa : Form
    {
        preComputer present = new preComputer();
        public hanghoa()
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

    }
}
