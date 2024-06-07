using QuanLyCuaHangMayTinh.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangMayTinh.Views
{
    public partial class Addkhachhang : Form
    {
        PreCustomer present = new PreCustomer();
        public Addkhachhang()
        {
            InitializeComponent();
        }
        private void CheckKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void Addkhachhang_Load(object sender, EventArgs e)
        {
            txt_MaKH.Text = "Mã khách hàng được tạo tự động";
            txt_MaKH.Enabled = false;

            btn_Boqua.Enabled = true;
        }

        private void btn_Boqua_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            

            if(txt_TenKH.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TenKH.Focus();
                return;
            }

            if (txt_SDT.Text.Length == 0)
            {
                
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SDT.Focus();
                return;
                
            }

            if (txt_Diachi.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Diachi.Focus();
                return;
            }
            present.AddCustomer(txt_TenKH.Text, txt_Diachi.Text, txt_SDT.Text);
            MessageBox.Show("Tạo Khách hàng thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

    }


}
