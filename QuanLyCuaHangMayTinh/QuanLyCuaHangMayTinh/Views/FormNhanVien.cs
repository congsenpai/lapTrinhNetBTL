using QuanLyCuaHangMayTinh.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangMayTinh.Views
{
    public partial class FormNhanVien : Form
    {
        preEmployee present=new preEmployee();
        public FormNhanVien()
        {
            InitializeComponent();
            prsMain.AddMenuStripToForm(this);
        }
        private void nhanvien_Load(object sender, EventArgs e)
        {
            DTGV.DataSource = present.loadEmployee();
            rdID.Checked = true;
            rdASC.Checked = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (rdASC.Checked == true)
            {
                if (rdID.Checked == true)
                {
                    DTGV.DataSource = present.findByID(txtSearch.Text, "ASC");
                }
                if (rdName.Checked == true)
                {
                    DTGV.DataSource = present.findByName(txtSearch.Text, "ASC");
                }
                if (rdGioitinh.Checked == true)
                {
                    DTGV.DataSource = present.findByGioitinh(txtSearch.Text, "ASC");
                }
                if (rdPhone.Checked == true)
                {
                    DTGV.DataSource = present.findByPhone(txtSearch.Text, "ASC");
                }
                if (rdNgaySinh.Checked == true)
                {
                    DateTime dt = dateTimePicker1.Value;
                    DTGV.DataSource = present.findByBirthDay(dt, "ASC");
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
                if (rdGioitinh.Checked == true)
                {
                    DTGV.DataSource = present.findByGioitinh(txtSearch.Text, "DESC");
                }
                if (rdPhone.Checked == true)
                {
                    DTGV.DataSource = present.findByPhone(txtSearch.Text, "DESC");
                }
                if (rdNgaySinh.Checked == true)
                {
                    DateTime dt = dateTimePicker1.Value;
                    DTGV.DataSource = present.findByBirthDay(dt, "DESC");
                }

            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            DTGV.DataSource = present.loadEmployee();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Hiển thị Form AddNV
            AddNV addNVForm = new AddNV(this);
            addNVForm.Show();
        }
    }
}
