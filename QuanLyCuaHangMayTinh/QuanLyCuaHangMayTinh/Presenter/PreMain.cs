using QuanLyCuaHangMayTinh.Model;
using System.Linq;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using QuanLyCuaHangMayTinh.Views;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
namespace QuanLyCuaHangMayTinh.Presenter
{

    public class PreMain
    {
        static PreEmployee employee = new PreEmployee();
        static PreCustomer customer = new PreCustomer();
        static PreComputer computer = new PreComputer();
        static PreSupplier supplier = new PreSupplier();

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
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public string getCodeByNameChoice(String name, string type)
        {
            if (type == "NV")
            {
                DataTable NV = employee.loadEmployee();
                foreach (DataRow row in NV.Rows)
                {
                    if (row["TenNV"].ToString() == name)
                    {
                        return row["MaNV"].ToString();
                    }
                }
            }
            if (type == "NCC")
            {
                DataTable NCC = supplier.loadSupplier();
                foreach (DataRow row in NCC.Rows)
                {
                    if (row["TenNCC"].ToString() == name)
                    {
                        return row["MaNCC"].ToString();
                    }
                }
            }
            if (type == "KH")
            {
                DataTable KH = customer.loadCustomer();
                foreach (DataRow row in KH.Rows)
                {
                    if (row["TenKH"].ToString() == name)
                    {
                        return row["MaKH"].ToString();
                    }
                }
            }
            if(type == "COM")
            {
                    DataTable COM = computer.loadComputer();
                    foreach (DataRow row in COM.Rows)
                    {
                        if (row["TenMVT"].ToString() == name)
                        {
                            return row["MaMVT"].ToString();
                        }
                    }
            }
            if (type == "LM")
            {
                DataTable LM = computer.loadComputerType();
                foreach (DataRow row in LM.Rows)
                {
                    if (row["TenLm"].ToString() == name)
                    {
                        return row["MaLm"].ToString();
                    }
                }
            }
            if (type == "Chip")
            {
                DataTable Chip = computer.loadChip();
                foreach (DataRow row in Chip.Rows)
                {
                    if (row["TenChip"].ToString() == name)
                    {
                        return row["MaChip"].ToString();
                    }
                }
            }
            if (type == "OC")
            {
                DataTable OC = computer.loadOCung();
                foreach (DataRow row in OC.Rows)
                {
                    if (row["TenOC"].ToString() == name)
                    {
                        return row["MaOC"].ToString();
                    }
                }
            }
            if (type == "DL")
            {
                DataTable DL = computer.loadDungLuong();
                foreach (DataRow row in DL.Rows)
                {
                    if (row["TenDL"].ToString() == name)
                    {
                        return row["MaDL"].ToString();
                    }
                }
            }
            if (type == "TD")
            {
                DataTable TD = computer.loadTocDo();
                foreach (DataRow row in TD.Rows)
                {
                    if (row["TenTD"].ToString() == name)
                    {
                        return row["MaTD"].ToString();
                    }
                }
            }
            if (type == "OCD")
            {
                DataTable OCD = computer.loadOCD();
                foreach (DataRow row in OCD.Rows)
                {
                    if (row["TenO"].ToString() == name)
                    {
                        return row["MaO"].ToString();
                    }
                }
            }
            if (type == "MH")
            {
                DataTable MH = computer.loadScreen();
                foreach (DataRow row in MH.Rows)
                {
                    if (row["TenMH"].ToString() == name)
                    {
                        return row["MaMH"].ToString();
                    }
                }
            }
            if (type == "COMH")
            {
                DataTable COMH = computer.loadCoManHinh();
                foreach (DataRow row in COMH.Rows)
                {
                    if (row["TenCo"].ToString() == name)
                    {
                        return row["MaCo"].ToString();
                    }
                }
            }
            if (type == "C")
            {
                DataTable C = computer.loadChuot();
                foreach (DataRow row in C.Rows)
                {
                    if (row["TenChuot"].ToString() == name)
                    {
                        return row["MaChuot"].ToString();
                    }
                }
            }
            if (type == "BP")
            {
                DataTable BP = computer.loadKeyBoard();
                foreach (DataRow row in BP.Rows)
                {
                    if (row["TenBP"].ToString() == name)
                    {
                        return row["MaBP"].ToString();
                    }
                }
            }
            if (type == "USB")
            {
                DataTable USB = computer.loadUSB();
                foreach (DataRow row in USB.Rows)
                {
                    if (row["TenOUSB"].ToString() == name)
                    {
                        return row["MaOUSB"].ToString();
                    }
                }
            }
            if (type == "RAM")
            {
                DataTable RAM = computer.loadRam();
                foreach (DataRow row in RAM.Rows)
                {
                    if (row["TenR"].ToString() == name)
                    {
                        return row["MaR"].ToString();
                    }
                }
            }
            if (type == "LOA")
            {
                DataTable LOA = computer.loadSpeaker();
                foreach (DataRow row in LOA.Rows)
                {
                    if (row["TenLoa"].ToString() == name)
                    {
                        return row["MaLoa"].ToString();
                    }
                }
            }
            if (type == "HSX")
            {
                DataTable HSX = computer.loadHSX();
                foreach (DataRow row in HSX.Rows)
                {
                    if (row["TenHSX"].ToString() == name)
                    {
                        return row["MaHSX"].ToString();
                    }
                }
            }
            return null;
        }
        public bool CheckExits(String ID, String type)
        {
            if (type == "NV")
            {
                System.Data.DataTable nv = employee.loadEmployee();
                foreach (DataRow row in nv.Rows)
                {
                    if (row["MaNV"].ToString() == ID)
                    {
                        return true;
                    }
                }
            }
            if (type == "KH")
            {
                System.Data.DataTable nv = customer.loadCustomer();
                foreach (DataRow row in nv.Rows)
                {
                    if (row["MaKH"].ToString() == ID)
                    {
                        return true;
                    }
                }
            }
            if (type == "NCC")
            {
                DataTable nv = supplier.loadSupplier();
                foreach (DataRow row in nv.Rows)
                {
                    if (row["MaNCC"].ToString() == ID)
                    {
                        return true;
                    }
                }
            }
            return false;

        }

    }
}
