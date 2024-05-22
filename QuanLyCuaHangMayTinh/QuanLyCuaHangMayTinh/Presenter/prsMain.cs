using QuanLyCuaHangMayTinh.Model;
using System.Linq;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
namespace QuanLyCuaHangMayTinh.Presenter
{

    public class prsMain
    {
       Entity db=new Entity();

        public Entity Db { get => db; set => db = value; }

        public String takeCode(string className)
        {
            switch (className)
            {
                case "BanPhim":
                    BanPhim bp = new BanPhim();
                    return bp.autoGenCode();

                case "Chip":
                    Chip c = new Chip();
                    return c.autoGenCode();

                // Thêm các trường hợp khác cần xử lý ở đây

                default:
                    return "Error Class Name";
            }
        }
        public void addBanPhim(string Name)
        {
            BanPhim b = new BanPhim();
            b.addData(Name);
        }
        public void removeBanPhim(string ID)
        {
            BanPhim banPhim = new BanPhim();
            banPhim.removeData(ID);
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
