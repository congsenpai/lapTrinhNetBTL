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
        }
        private void hanghoa_Load(object sender, EventArgs e)
        {
            DTGV.DataSource = present.loadComputer();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (TimTheoNgoaiVi.GetItemChecked(0))
            {
                DTGV.DataSource = present.findbyTenMay(txtSearch.Text);
            }
            if (TimTheoNgoaiVi.GetItemChecked(1))
            {
                DTGV.DataSource = present.findbyLoaiMay(txtSearch.Text);
            }
            if (TimTheoNgoaiVi.GetItemChecked(2))
            {
                DTGV.DataSource = present.findbyChip(txtSearch.Text);
            }
            if (TimTheoNgoaiVi.GetItemChecked(3))
            {
                DTGV.DataSource = present.findbyOC(txtSearch.Text);
            }
            if (TimTheoNgoaiVi.GetItemChecked(4))
            {
                DTGV.DataSource = present.findbyO(txtSearch.Text);
            }
            if (TimTheoNgoaiVi.GetItemChecked(5))
            {
                DTGV.DataSource = present.findbyCo(txtSearch.Text);
            }
            if (TimTheoNgoaiVi.GetItemChecked(6))
            {
                DTGV.DataSource = present.findbyUSB(txtSearch.Text);
            }
            if (TimTheoNgoaiVi.GetItemChecked(7))
            {
                DTGV.DataSource = present.findbyRAM(txtSearch.Text);
            }
            if (TimTheoNgoaiVi.GetItemChecked(8))
            {
                DTGV.DataSource = present.findbyNSX(txtSearch.Text);
            }
            if (TimTheoNgoaiVi.GetItemChecked(9))
            {
                DTGV.DataSource = present.findbyTocdo(txtSearch.Text);
            }
            if (TimTheoNgoaiVi.GetItemChecked(10))
            {
                DTGV.DataSource = present.findbyDL(txtSearch.Text);
            }
            if (TimTheoNoiVi.GetItemChecked(0))
            {
                DTGV.DataSource = present.findbyScreen(txtSearch.Text);
            }
            if (TimTheoNoiVi.GetItemChecked(1))
            {
                DTGV.DataSource = present.findbyMouse(txtSearch.Text);
            }
            if (TimTheoNoiVi.GetItemChecked(2))
            {
                DTGV.DataSource = present.findbyKeyboard(txtSearch.Text);
            }
            if (TimTheoNoiVi.GetItemChecked(3))
            {
                DTGV.DataSource = present.findbyLoa(txtSearch.Text);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DTGV.DataSource = present.loadComputer();
        }
    }
}
