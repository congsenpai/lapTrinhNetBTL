using QuanLyCuaHangMayTinh.Model;
using System.Linq;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using QuanLyCuaHangMayTinh.Views;
namespace QuanLyCuaHangMayTinh.Presenter
{

    public class prsMain
    {
       Entity db=new Entity();

        public Entity Db { get => db; set => db = value; }

        public static void AddMenuStripToForm(Form form)
        {
            MenuStrip menuStrip = new MenuStrip();

            // Tạo các mục menu chính
            ToolStripMenuItem tongQuanMenu = new ToolStripMenuItem("Tổng quan");
            ToolStripMenuItem hangHoaMenu = new ToolStripMenuItem("Hàng hóa");

            ToolStripMenuItem giaoDichMenu = new ToolStripMenuItem("Giao dịch");
            ToolStripMenuItem hoaDonBanMenu = new ToolStripMenuItem("Hóa đơn bán");
            ToolStripMenuItem hoaDonNhapMenu = new ToolStripMenuItem("Hóa đơn nhập");
            giaoDichMenu.DropDownItems.Add(hoaDonBanMenu);
            giaoDichMenu.DropDownItems.Add(hoaDonNhapMenu);

            ToolStripMenuItem doiTacMenu = new ToolStripMenuItem("Đối tác");
            ToolStripMenuItem khachHangMenu = new ToolStripMenuItem("Khách hàng");
            ToolStripMenuItem nhanVienMenu = new ToolStripMenuItem("Nhân viên");
            ToolStripMenuItem nhaCungCapMenu = new ToolStripMenuItem("Nhà cung cấp");
            doiTacMenu.DropDownItems.Add(khachHangMenu);
            doiTacMenu.DropDownItems.Add(nhanVienMenu);
            doiTacMenu.DropDownItems.Add(nhaCungCapMenu);

            ToolStripMenuItem banHangMenu = new ToolStripMenuItem("Bán hàng");
            ToolStripMenuItem nhapHangMenu = new ToolStripMenuItem("Nhập hàng");
            ToolStripMenuItem thoatMenu = new ToolStripMenuItem("Thoát");

            // Thêm sự kiện thoát ứng dụng cho mục "Thoát"
            thoatMenu.Click += (sender, e) => { form.Close(); };
            tongQuanMenu.Click += (sender, e) => OpenForm(form, new Tongquan());
            hangHoaMenu.Click += (sender, e) => OpenForm(form, new FormHangHoa());
            hoaDonBanMenu.Click += (sender, e) => OpenForm(form, new FormHoaDonBan());
            hoaDonNhapMenu.Click += (sender, e) => OpenForm(form, new FormHoaDonNhap());
            khachHangMenu.Click += (sender, e) => OpenForm(form, new FormKhachHang());
            nhanVienMenu.Click += (sender, e) => OpenForm(form, new FormNhanVien());
            nhaCungCapMenu.Click += (sender, e) => OpenForm(form, new FormNCC());
            banHangMenu.Click += (sender, e) => OpenForm(form, new BanHang());
            nhapHangMenu.Click += (sender, e) => OpenForm(form, new NhapHang());

            // Thêm các mục menu chính vào MenuStrip
            menuStrip.Items.Add(tongQuanMenu);
            menuStrip.Items.Add(hangHoaMenu);
            menuStrip.Items.Add(giaoDichMenu);
            menuStrip.Items.Add(doiTacMenu);
            menuStrip.Items.Add(banHangMenu);
            menuStrip.Items.Add(nhapHangMenu);
            menuStrip.Items.Add(thoatMenu);

            // Gắn MenuStrip vào Form
            form.MainMenuStrip = menuStrip;
            form.Controls.Add(menuStrip);
        }
        public static void OpenForm(Form currentForm, Form newForm)
        {
            currentForm.Hide(); // Ẩn form hiện tại
            newForm.ShowDialog(); // Hiển thị form mới
            currentForm.Close(); // Đóng form hiện tại và giải phóng bộ nhớ
        }
        public DataTable ConvertToDataTable<T>(List<T> items)
        {
            if (items == null || items.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            DataTable dataTable = new DataTable(typeof(T).Name);

            // Lấy tất cả các thuộc tính của lớp T, bỏ qua các thuộc tính quan hệ
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                           .Where(p => !IsNavigationProperty(p))
                                           .ToArray();
            

            foreach (PropertyInfo prop in Props)
            {
                // Đặt tên cột là tên của thuộc tính
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    // Lấy giá trị của thuộc tính và gán vào cột tương ứng
                    values[i] = Props[i].GetValue(item, null) ?? DBNull.Value;
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        private static bool IsNavigationProperty(PropertyInfo prop)
        {
            // Kiểm tra nếu thuộc tính là kiểu collection hoặc kiểu class (trừ string)
            return (typeof(IEnumerable<object>).IsAssignableFrom(prop.PropertyType) && prop.PropertyType != typeof(string))
                   || (!prop.PropertyType.IsValueType && prop.PropertyType != typeof(string));
        }
    }
}
