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
using System.Runtime.CompilerServices;
namespace QuanLyCuaHangMayTinh.Views
{
    public partial class BanHang : Form
    {
        PreSale present = new PreSale();
        PreEmployee employees = new PreEmployee();
        PreCustomer customers = new PreCustomer();
        PreComputer computers = new PreComputer();
        PreMain main = new PreMain();
        List<String> originalItemsCus = new List<string>();
        List<String> originalItemsCom = new List<string>();
        DataTable hoadon = new DataTable()
        {
            Columns =
            {
                new DataColumn("MaMVT", typeof(string)),
                new DataColumn("TenMVT", typeof(string)),
                new DataColumn("SoLuong", typeof(int)),
                new DataColumn("DonGia", typeof(double))
            }
        };
        public BanHang()
        {
            InitializeComponent();
            loadCBEmployee();
            loadLBCustomer();
            loadLBComputers();
            PreMain.AddMenuStripToForm(this);
        }
        public void FocusChanged(bool a,bool b)
        {
            if (a == true)
            {
                if (b == true)
                {
                    lbComputerItems.Visible = false;
                    lbCustomer.Visible = false;
                }
                else
                {
                    lbComputerItems.Visible = false;
                }
            }
            else
            {
                if (b == true)
                {
                    lbCustomer.Visible = false;
                }
            }

        }
        private void Sale1_Load(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString(" dd/MM/yyyy HH:mm");
            timer1.Start();
            lbComputerItems.Visible = false;
            lbCustomer.Visible = false;
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
                }
            }
        }

        public void loadLBCustomer()
        {
            DataTable dt = customers.loadCustomer();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lbCustomer.Items.Add(row["TenKH"].ToString());
                    originalItemsCus.Add(row["TenKH"].ToString());
                }
            }

        }

        public void loadLBComputers()
        {
            DataTable dt = computers.loadComputer();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lbComputerItems.Items.Add(row["TenMVT"].ToString());
                    originalItemsCom.Add(row["TenMVT"].ToString());
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lbComputerItems.Visible = true;
            if (txtSearch.Text != null)
            {
                List<string> foundItems = originalItemsCom.FindAll(x => x.ToLower().Contains(txtSearch.Text.ToLower()));
                lbComputerItems.Items.Clear();
                foreach (string item in foundItems)
                {
                    lbComputerItems.Items.Add(item);
                }
                txtSearch.SelectionStart = txtSearch.Text.Length;
            }
            else
            {
                loadLBComputers();
            }
        }
        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            loadLBCustomer();
            lbCustomer.Visible = true;
            if (txtCustomer.Text != null)
            {
                List<string> foundItems = originalItemsCus.FindAll(x => x.ToLower().Contains(txtCustomer.Text.ToLower()));
                lbCustomer.Items.Clear();
                foreach (string item in foundItems)
                {
                    lbCustomer.Items.Add(item);
                }
                txtCustomer.SelectionStart = txtCustomer.Text.Length;
            }
        }

        private int checkExit()
        {
            if (hoadon.Rows.Count == 0)
            {
                return -1;
            }
            DataTable source = computers.findComputer(txtSearch.Text);
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
            FocusChanged(true, true);
            if (txtSoluong.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoluong.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Chưa chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
               string maMVT= main.getCodeByNameChoice(txtSearch.Text, "COM");
                int soLuong = computers.checkAmount(maMVT);
                if (soLuong < Convert.ToInt32(txtSoluong.Text))
                {
                    MessageBox.Show("Số lượng hàng trong kho không đủ", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                DataTable source = computers.findComputer(txtSearch.Text);
                if (checkExit() < 0)
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
                    hoadon.Rows[checkExit()]["Soluong"] = Convert.ToInt32(txtSoluong.Text) + Convert.ToInt32(hoadon.Rows[checkExit()]["Soluong"].ToString());
                }

                DtgvItems.DataSource = hoadon;
            }

            
           
            double cost = 0, cuspay = 0;
            foreach (DataRow row in hoadon.Rows)
            {
                cost = cost + (double)((double)row["DonGia"] * (int)row["SoLuong"]);
            }
            lbTotalCost.Text = cost.ToString();
            if (txtCusPay.Text.Length == 0)
            {
                cuspay = -cost;
            }
            else
            {
                cuspay = Convert.ToDouble(txtCusPay.Text) - cost;
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
            double cost = 0; double cuspay = 0; double payback = 0;
            Double.TryParse(lbTotalCost.Text, out cost);
            if (string.IsNullOrEmpty(txtCusPay.Text))
            {
                cuspay = -cost;
            }
            else
            {
                cuspay = Convert.ToDouble(txtCusPay.Text);
                payback = cuspay - cost;
            }

            lbPayBack.Text = payback.ToString();
        }


        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (hoadon.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string manv = "", makh = "";
            DateTime ngayban = DateTime.Now;
            double totalcost = 0;
            if (lbTotalCost.Text.Length == 0)
            {

                MessageBox.Show("Chưa có sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                totalcost = Convert.ToDouble(lbTotalCost.Text);
            }
            // kiểm tra xem nhập nhân viên chưa, nếu chưa thì bắt nhập
            if (cbEmployee.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                manv = main.getCodeByNameChoice(cbEmployee.Text, "NV");

            }
            if (txtCustomer.Text.Length == 0)
            {
                makh = "KH0";
            }
            else
            {
                makh = main.getCodeByNameChoice(txtCustomer.Text, "NV");
            }
            present.AddBuyDetails(hoadon, ngayban, manv, makh, totalcost);
            resetOrder();
        }
        public void resetOrder()
        {
            txtSearch.Text = "";
            txtSoluong.Text = "";
            txtCustomer.Text = "";
            lbComputerItems.Items.Clear();
            lbComputerItems.Visible = false;
            lbCustomer.Items.Clear();
            lbCustomer.Visible = false;
            lbTotalCost.Text = "";
            lbPayBack.Text = "";
            txtCusPay.Text = "";
            DtgvItems.DataSource = null;
        }



        private void lbComputerItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbComputerItems.SelectedItem != null)
            {
                txtSearch.Text = lbComputerItems.SelectedItem.ToString();
            }
            lbComputerItems.Visible = false;
        }

        private void lbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCustomer.SelectedItem != null)
            {
                txtCustomer.Text = lbCustomer.SelectedItem.ToString();
            }
            lbCustomer.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            resetOrder();
            cbEmployee.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Addkhachhang addkhachhang = new Addkhachhang();
            addkhachhang.Show();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            FocusChanged(false, true);
            lbComputerItems.Visible = true;
        }
        private void txtCustomer_Enter(object sender, EventArgs e)
        {
            FocusChanged(true,false);
            lbCustomer.Visible = true;
        }

        private void txtSoluong_Enter(object sender, EventArgs e)
        {
            FocusChanged(true,true);
        }

        private void cbEmployee_Click(object sender, EventArgs e)
        {
            FocusChanged(true,true);
        }

        private void txtCusPay_Enter(object sender, EventArgs e)
        {
            FocusChanged(true, true);
        }


    }
}
