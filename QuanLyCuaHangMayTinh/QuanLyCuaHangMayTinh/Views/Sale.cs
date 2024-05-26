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
        List<String> originalItemsCom = new List<string>();
        DataTable hoadon= new DataTable()
        {
            Columns =
            {
                new DataColumn("MaMVT", typeof(string)),
                new DataColumn("TenMVT", typeof(string)),
                new DataColumn("SoLuong", typeof(int)),
                new DataColumn("DonGia", typeof(double))
            }
        };
        public Sale()
        {
            InitializeComponent();
            loadCBEmployee();
            loadCBCustomer();
            loadCBComputers();
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
            if (cbKhachHang.Text != null)
            {
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
        public void loadCBComputers()
        {
            DataTable dt = computers.loadComputer();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    cbSearch.Items.Add(row["TenMVT"].ToString());
                    originalItemsCom.Add(row["TenMVT"].ToString());
                }
            }
        }
        private void cbSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbSearch.Text != null)
            {
                DataTable a = computers.loadComputer();
                List<string> foundItems = originalItemsCom.FindAll(x => x.ToLower().Contains(cbSearch.Text.ToLower()));
                cbSearch.Items.Clear();
                foreach (string item in foundItems)
                {
                    cbSearch.Items.Add(item);
                }
                cbSearch.SelectionStart = cbSearch.Text.Length;

                if (cbSearch.Items.Count > 0)
                {
                    cbSearch.DroppedDown = true;
                }
            }
            else
            {
                loadCBComputers();
            }
        }
        private int checkExit()
        {
            if (hoadon.Rows.Count == 0)
            {
                return -1;
            }
            DataTable source = computers.findComputer(cbSearch.Text);
            for (int i = 0; i < hoadon.Rows.Count; i++)
            {
                if (hoadon.Rows[i]["MaMVT"].ToString() == source.Rows[0]["MaMVT"].ToString())
                {
                    return i;
                }
            }
            return -1;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSoluong.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoluong.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbSearch.Text))
            {
                MessageBox.Show("Chưa chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DataTable source = computers.findComputer(cbSearch.Text);
                if (checkExit() <0)
                {
                    foreach (DataRow row in source.Rows)
                    {
                        DataRow newRow = hoadon.NewRow();
                        newRow["MaMVT"] = row["MaMVT"];
                        newRow["TenMVT"] = row["TenMVT"];
                        newRow["SoLuong"] = Convert.ToInt32(txtSoluong.Text);
                        newRow["DonGia"] = row["Giaban"];
                        hoadon.Rows.Add(newRow);
                    }
                }
                else
                {
                    hoadon.Rows[checkExit()]["Soluong"]=Convert.ToInt32(txtSoluong.Text)+ Convert.ToInt32(hoadon.Rows[checkExit()]["Soluong"].ToString());
                }
                
                DtgvItems.DataSource = hoadon;
            }
            double cost = 0, cuspay = 0;
            foreach(DataRow row in hoadon.Rows)
            {
                cost = cost + (double)row["DonGia"] * (int)row["SoLuong"];
            }
            lbTotalCost.Text = cost.ToString();
            if (txtCusPay.Text.Length == 0)
            {
                cuspay = -cost;
            }
            else
            {
                cuspay=cost - Convert.ToDouble(txtCusPay.Text);
            }
            lbPayBack.Text = cuspay.ToString();
        }

        private void txtCusPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCusPay_TextChanged(object sender, EventArgs e)
        {
            double cost=Convert.ToDouble(lbTotalCost.Text);
            double cuspay = 0;
            if (txtCusPay.Text.Length == 0)
            {
                cuspay = -cost;
            }
            else
            {
                cuspay = cost - Convert.ToDouble(txtCusPay.Text);
            }
            lbPayBack.Text = cuspay.ToString();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            string manv="", makh="";
            DateTime ngayban= DateTime.Now;
            double totalcost= Convert.ToDouble(lbTotalCost.Text);
            // kiểm tra xem nhập nhân viên chưa, nếu chưa thì bắt nhập
            if(cbEmployee.Text.Length ==0) 
            {
                MessageBox.Show("Chưa nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                manv = cbEmployee.Text;
            }
            if(cbKhachHang.Text.Length == 0)
            {
                makh = "KH0";
            }
            else
            {
                makh = cbKhachHang.Text;
            }
            present.AddBuyDetails(hoadon, ngayban, manv, makh, totalcost);
            resetOrder();
        }
        public void resetOrder()
        {
            cbSearch.Text = "";
            cbEmployee.Text = "";
            cbKhachHang.Text = "";
            lbTotalCost.Text = "";
            lbPayBack.Text = "";
            txtCusPay.Text = "";
            DtgvItems.Rows.Clear();
        }
    }
}
