using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangMayTinh.Model;
using QuanLyCuaHangMayTinh.Presenter;

namespace QuanLyCuaHangMayTinh.Views
{
    public partial class frmMain : Form
    {
        prsMain present = new prsMain();

        Entity db = new Entity();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Light Speed Pink";
            var data = db.BanPhims.ToList();
            dataGridView1.DataSource = data;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var data = db.BanPhims.ToList();
            dataGridView1.DataSource = data;    

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            present.addBanPhim(textBox1.Text);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            present.removeBanPhim(textBox1.Text);
        }
    }
}
