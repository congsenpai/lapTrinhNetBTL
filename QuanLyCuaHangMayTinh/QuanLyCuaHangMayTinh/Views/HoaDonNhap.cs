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
    public partial class HoaDonNhap : Form
    {
        PreImport present = new PreImport();
        preEmployee employees = new preEmployee();
        PreSupplier suppliers = new PreSupplier();
        preComputer computers = new preComputer();
        List<String> originalItemsEmploy = new List<string>();
        List<String> originalItemsCus = new List<string>();
        List<String> originalItemsCom = new List<string>();
        public HoaDonNhap()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loadCBEmployee();
            loadCBsupplier();

        }

        public void loadCBEmployee()
        {
            DataTable dt = employees.loadEmployee();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    cbNhanVien.Items.Add(row["TenNV"].ToString());
                    originalItemsEmploy.Add(row["TenNV"].ToString());
                }
            }
        }

        public void loadCBsupplier()
        {
            DataTable dt = suppliers.loadSupplier();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    cbNCC.Items.Add(row["TenNCC"].ToString());
                    originalItemsCus.Add(row["TenNCC"].ToString());
                }
            }

        }


        private void Orders_Load(object sender, EventArgs e)
        {
            DTGV.DataSource = present.loadHoaDonNhap();
        }
        private string getCodeByNameChoice(String name, string type)
        {
            if (type == "NV")
            {
                DataTable NV = employees.loadEmployee();
                foreach (DataRow row in NV.Rows)
                {
                    if (row["TenNV"].ToString() == name)
                    {
                        return row["MaNV"].ToString();
                    }
                }
            }
            if (type == "NCC")
            {
                DataTable NCC = suppliers.loadSupplier();
                foreach (DataRow row in NCC.Rows)
                {
                    if (row["TenNCC"].ToString() == name)
                    {
                        return row["MaNCC"].ToString();
                    }
                }
            }
            return null;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string manv = getCodeByNameChoice(cbNhanVien.Text, "NV");
            string maNCC = getCodeByNameChoice(cbNhanVien.Text, "NCC");
            DateTime From = dateTimePicker1.Value;
            DateTime To = dateTimePicker2.Value;
            DTGV.DataSource = present.FindHoaDon(txtSearch.Text, From, To, manv, maNCC);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DTGV.DataSource = present.loadHoaDonNhap();
        }
    }
}

