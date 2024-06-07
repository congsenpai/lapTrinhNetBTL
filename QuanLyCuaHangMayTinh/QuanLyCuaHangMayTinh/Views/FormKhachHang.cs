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
using OfficeOpenXml;
using QuanLyCuaHangMayTinh.Presenter;
namespace QuanLyCuaHangMayTinh.Views
{
    public partial class FormKhachHang : Form
    {
        PreCustomer present=new PreCustomer();
        public FormKhachHang()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PreMain.AddMenuStripToForm(this);
        }
        private void khachhang_Load(object sender, EventArgs e)
        {
            DTGV.DataSource = present.loadCustomer();
            rdID.Checked = true;
            rdASC.Checked = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (rdASC.Checked == true)
            {
                if(rdID.Checked == true)
                {
                    DTGV.DataSource=present.findByID(txtSearch.Text,"ASC");
                }
                if(rdName.Checked == true)
                {
                    DTGV.DataSource = present.findByName(txtSearch.Text, "ASC");
                }
                if(rdAddress.Checked == true)
                {
                    DTGV.DataSource = present.findByAddress(txtSearch.Text, "ASC");
                }
                if (rdPhone.Checked == true)
                {
                    DTGV.DataSource = present.findByPhone(txtSearch.Text, "ASC");
                }

            }
            if (rdDESC.Checked == true)
            {
                if (rdID.Checked == true)
                {
                    DTGV.DataSource = present.findByID(txtSearch.Text, "DESC");
                }
                if (rdName.Checked == true)
                {
                    DTGV.DataSource = present.findByName(txtSearch.Text, "DESC");
                }
                if (rdAddress.Checked == true)
                {
                    DTGV.DataSource = present.findByAddress(txtSearch.Text, "DESC");
                }
                if (rdPhone.Checked == true)
                {
                    DTGV.DataSource = present.findByPhone(txtSearch.Text, "DESC");
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTGV.DataSource = present.loadCustomer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Addkhachhang addkhachhang = new Addkhachhang();
            addkhachhang.Show();
        }
    }
}
