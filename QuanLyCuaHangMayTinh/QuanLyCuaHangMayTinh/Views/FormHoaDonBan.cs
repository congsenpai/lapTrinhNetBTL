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
    public partial class FormHoaDonBan : Form
    {
        PreSale present = new PreSale();
        PreEmployee employees = new PreEmployee();
        PreCustomer customers = new PreCustomer();
        PreMain prsMain = new PreMain();

        public FormHoaDonBan()
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
            DataTable dt1 = customers.loadCustomer();
            if (dt != null && dt1.Rows.Count > 0)
            {
                foreach (DataRow row in dt1.Rows)
                {
                    cbKH.Items.Add(row["TenKH"].ToString());
                }
            }

        }
        private void Orders_Load(object sender, EventArgs e)
        {
            DTGV.DataSource = present.loadHoaDonBan();
        } 
        private void btnFind_Click(object sender, EventArgs e)
        {
            string manv=prsMain.getCodeByNameChoice(cbNhanVien.Text,"NV");
            string makh =prsMain.getCodeByNameChoice(cbKH.Text, "KH");
            DateTime From= dateTimePicker1.Value;
            DateTime To = dateTimePicker2.Value;
            DTGV.DataSource = present.FindHoaDon(txtSearch.Text,From,To,manv,makh);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DTGV.DataSource = present.loadHoaDonBan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BanHang banhang=new BanHang();
            banhang.ShowDialog();
            this.Dispose();
        }
    }

}
