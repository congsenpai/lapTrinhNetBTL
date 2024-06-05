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
    public partial class AddNCC : Form
    {
        private FormNCC NCCForm;
        PreSupplier present = new PreSupplier();
        public AddNCC(FormNCC nccForm)
        {
            InitializeComponent();
            this.NCCForm = nccForm;
        }
        private void CheckKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddNCC_Load(object sender, EventArgs e)
        {
            txt_MaNCC.Text = "Mã nhà cung cấp được tạo tự động";
            txt_MaNCC.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Boqua.Enabled = true;
        }
        DataTable btl; // khai báo ngoài 

        private void btn_Boqua_Click(object sender, EventArgs e)
        {
            this.Dispose();
            NCCForm.Show();
            
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_TenNCC.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TenNCC.Focus();
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
            present.AddSupplier(txt_TenNCC.Text, txt_Diachi.Text, txt_SDT.Text);
            MessageBox.Show("Tạo nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddNCC_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            NCCForm.Show();
        }
    }
}
