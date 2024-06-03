using QuanLyCuaHangMayTinh.Presenter;
using QuanLyCuaHangMayTinh.Views;
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

namespace QuanLyCuaHangMayTinh.Views
{
    public partial class Login : Form
    {
        PreLogin prelogin = new PreLogin();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        DataTable dtable;
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string MaNV, password;
            MaNV = txtusername.Text;
            password = txtpassword.Text;

            try
            {

<<<<<<< Updated upstream
                if (prelogin.findByID(MaNV, password))// Kiểm tra xem dtable có dữ liệu hay không
=======
                if (prelogin.findByID(MaNV, password))
>>>>>>> Stashed changes
                {
                    Sale sale = new Sale();
                    sale.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Clear();
                    txtpassword.Clear();
<<<<<<< Updated upstream

                    //to focus username
=======
>>>>>>> Stashed changes
                    txtusername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();


            txtusername.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Bạn có chắc muốn thoát", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

      
    }
}