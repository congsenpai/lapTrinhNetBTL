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

namespace QuanLyCuaHangMayTinh.Views
{
    public partial class frmMain : Form
    {
        Entity connect= new Entity();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }
        private void LoadDataToDataGridView()
        {
            // Lấy dữ liệu từ cơ sở dữ liệu sử dụng Entity Framework
            var data = connect.BanPhims.ToList(); // Thay "BanPhims" bằng tên của bảng trong cơ sở dữ liệu của bạn

            // Gán dữ liệu cho DataSource của DataGridView
            dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BanPhim banPhim = new BanPhim();

            textBox1.Text = banPhim.autoGenCode().ToString();
        }
    }
}
