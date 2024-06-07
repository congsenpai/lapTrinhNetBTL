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
    public partial class FormHoaDonNhap : Form
    {
        PreImport present = new PreImport();
        PreEmployee employees = new PreEmployee();
        PreSupplier suppliers = new PreSupplier();
        PreMain main = new PreMain();
        public FormHoaDonNhap()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loadCB();
            PreMain.AddMenuStripToForm(this);

        }

        public void loadCB()
        {
            DataTable dt = employees.loadEmployee();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    cbNhanVien.Items.Add(row["TenNV"].ToString());
                }
            }

            DataTable dt1 = suppliers.loadSupplier();
            if (dt1 != null && dt1.Rows.Count > 0)
            {
                foreach (DataRow row in dt1.Rows)
                {
                    cbNCC.Items.Add(row["TenNCC"].ToString());
                }
            }

        }


        private void Orders_Load(object sender, EventArgs e)
        {
            DTGV.DataSource = present.loadHoaDonNhap();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string manv = main.getCodeByNameChoice(cbNhanVien.Text, "NV");
            string maNCC = main.getCodeByNameChoice(cbNCC.Text, "NCC");
            DateTime From = dateTimePicker1.Value;
            DateTime To = dateTimePicker2.Value;
            DTGV.DataSource = present.FindHoaDon(txtSearch.Text, From, To, manv, maNCC);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DTGV.DataSource = present.loadHoaDonNhap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapHang nhaphang = new NhapHang();
            nhaphang.ShowDialog();
            this.Dispose();
        }
    }
}

