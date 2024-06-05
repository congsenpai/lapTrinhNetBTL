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
    public partial class FormNCC : Form
    {
        
        PreSupplier present=new PreSupplier();
        public FormNCC()
        {
            InitializeComponent();
            prsMain.AddMenuStripToForm(this);
        }
        private void NCC_Load(object sender, EventArgs e)
        {
            DTGV.DataSource = present.loadSupplier();
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
                if (rdAddress.Checked == true)
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
            DTGV.DataSource = present.loadSupplier();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNCC AddNCCForm = new AddNCC(this);
            this.Hide();
            AddNCCForm.Show();
        }
    }
}
