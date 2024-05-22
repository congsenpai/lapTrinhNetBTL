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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace QuanLyCuaHangMayTinh.Views
{
    public partial class Sale : Form
    {
        PreSale present = new PreSale();
        preEmployee employees = new preEmployee();
        PreCustomer customers = new PreCustomer();
        preComputer computers = new preComputer();
        List<String> originalItemsEmploy = new List<string>();
        List<String> originalItemsCus = new List<string>();
        public Sale()
        {
            InitializeComponent();
            loadCBEmployee();
            loadCBCustomer();
        }
        private void Sale_Load(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString(" dd/MM/yyyy HH:mm");
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }
        public void loadCBEmployee()
        {
            DataTable dt = employees.loadEmployee();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    cbEmployee.Items.Add(row["TenNV"].ToString());
                    originalItemsEmploy.Add(row["TenNV"].ToString());
                }
            }
        }

        private void cbEmployee_TextChanged(object sender, EventArgs e)
        {
            if (cbEmployee.Text != null)
            {
                DataTable a = employees.loadEmployee();

                // search
                List<string> foundItems = originalItemsEmploy.FindAll(x => x.ToLower().Contains(cbEmployee.Text.ToLower()));
                cbEmployee.Items.Clear();
                foreach (string item in foundItems)
                {
                    cbEmployee.Items.Add(item);
                }
                cbEmployee.SelectionStart = cbEmployee.Text.Length;

                if (cbEmployee.Items.Count > 0)
                {
                    cbEmployee.DroppedDown = true;
                }
            }
            else
            {
                loadCBEmployee();
            }
        }
        public void loadCBCustomer()
        {
            DataTable dt = customers.loadCustomer();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    cbKhachHang.Items.Add(row["TenKH"].ToString());
                    originalItemsCus.Add(row["TenKH"].ToString());
                }
            }

        }

        private void cbKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (cbEmployee.Text != null)
            {
                DataTable a = employees.loadEmployee();
                List<string> foundItems = originalItemsCus.FindAll(x => x.ToLower().Contains(cbKhachHang.Text.ToLower()));
                cbKhachHang.Items.Clear();
                foreach (string item in foundItems)
                {
                    cbKhachHang.Items.Add(item);
                }
                cbKhachHang.SelectionStart = cbKhachHang.Text.Length;

                if (cbKhachHang.Items.Count > 0)
                {
                    cbKhachHang.DroppedDown = true;
                }
            }
            else
            {
                loadCBCustomer();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DtgvItems.DataSource = computers.findComputer(txtSearch.Text);
        }
    }
    }
