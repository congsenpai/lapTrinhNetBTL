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
    public partial class ThemHangHoa : Form
    {
        public ThemHangHoa()
        {
            InitializeComponent();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có muốn hủy bỏ việc thêm không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
