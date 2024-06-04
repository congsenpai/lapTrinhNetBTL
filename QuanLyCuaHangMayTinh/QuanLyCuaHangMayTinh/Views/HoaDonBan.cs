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
    public partial class HoaDonBan : Form
    {
        PreSale present = new PreSale();
        preEmployee employees = new preEmployee();
        PreCustomer customers = new PreCustomer();
        preComputer computers = new preComputer();
        List<String> originalItemsEmploy = new List<string>();
        List<String> originalItemsCus = new List<string>();
        List<String> originalItemsCom = new List<string>();
        public HoaDonBan()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loadCBEmployee();
            loadCBCustomer();

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

        public void loadCBCustomer()
        {
            DataTable dt = customers.loadCustomer();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    cbKH.Items.Add(row["TenKH"].ToString());
                    originalItemsCus.Add(row["TenKH"].ToString());
                }
            }

        }


        private void Orders_Load(object sender, EventArgs e)
        {
            DTGV.DataSource = present.loadHoaDonBan();
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
            if (type == "KH")
            {
                DataTable KH = customers.loadCustomer();
                foreach (DataRow row in KH.Rows)
                {
                    if (row["TenKH"].ToString() == name)
                    {
                        return row["MaKH"].ToString();
                    }
                }
            }
            return null;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string manv=getCodeByNameChoice(cbNhanVien.Text,"NV");
            string makh = getCodeByNameChoice(cbNhanVien.Text, "KH");
            DateTime From= dateTimePicker1.Value;
            DateTime To = dateTimePicker2.Value;
            DTGV.DataSource = present.FindHoaDon(txtSearch.Text,From,To,manv,makh);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DTGV.DataSource = present.loadHoaDonBan();
        }
    }

}
