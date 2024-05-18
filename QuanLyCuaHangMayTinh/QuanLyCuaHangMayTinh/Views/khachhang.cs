using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangMayTinh.Presenter;
namespace QuanLyCuaHangMayTinh.Views
{
    public partial class khachhang : Form
    {
        PreCustomer present=new PreCustomer();
        public khachhang()
        {
            InitializeComponent();
        }
        private void khachhang_Load(object sender, EventArgs e)
        {
            DTGV.DataSource = present.loadDTGV();
            DataTable dt = present.loadCreateManBox();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    cbCreateMan.Items.Add(row["TenNV"].ToString());
                }
            }

            rdBtnCreateDateFullTime.AutoCheck = true;
            rdBtnLastTranFullTime.AutoCheck = true;
            cbCreateDateMonth.Visible = false;
            cbLastTranMonth.Visible = false;
        }

        private void rdBtnCreateDateOther_CheckedChanged(object sender, EventArgs e)
        {
            cbCreateDateMonth.Visible = true;

        }

        private void rdBtnLastTranOther_CheckedChanged(object sender, EventArgs e)
        {
            cbLastTranMonth.Visible=true;
        }

        private void rdBtnCreateDateFullTime_CheckedChanged(object sender, EventArgs e)
        {
            cbCreateDateMonth.Visible = false;
        }

        private void rdBtnLastTranFullTime_CheckedChanged(object sender, EventArgs e)
        {
            cbLastTranMonth.Visible = false;
        }
    }
}
