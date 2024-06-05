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
    public partial class AddNV : Form
    {
        private FormNhanVien NVForm;
        preEmployee present = new preEmployee();
        public AddNV(FormNhanVien NVForm)
        {
            InitializeComponent();
            this.NVForm = NVForm;
        }
        private void AddNV_Load(object sender, EventArgs e)
        {
            txt_MaNV.Text = "Mã nhân viên được tạo tự động";
            txt_MaNV.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Boqua.Enabled = true;
        }
        private void CheckKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Boqua_Click(object sender, EventArgs e)
        {
            this.Dispose();
            NVForm.Show();

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_TenNV.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TenNV.Focus();
                return;
            }

            if (txt_SDT.Text.Length == 0)
            {

                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SDT.Focus();
                return;
            }
            DateTime a = dateTimePicker1.Value;
            if (a.Date == DateTime.Now.Date)
            {
                MessageBox.Show("Bạn chưa chọn ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string gioitinh = "";
            if (rdMale.Checked==false&&rdFemale.Checked==false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (rdMale.Checked == true)
                {
                    gioitinh = "Nam";
                }
                else
                {
                    gioitinh = "Nữ";
                }
            }
            present.AddEmployee(txt_TenNV.Text, a, gioitinh,txt_SDT.Text);
            MessageBox.Show("Tạo nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            NVForm.Show();
        }

    }
}
