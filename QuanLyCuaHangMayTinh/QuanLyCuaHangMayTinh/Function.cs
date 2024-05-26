using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login
{
    internal class Function
    {
        public static SqlConnection conn;
        public static string connString;

        public static void Connect()
        {
            connString = "Data Source=LAPTOP-CKVQRQEO;Initial Catalog=btl;Integrated Security=True";
            conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                MessageBox.Show("Kết nối thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu: " + ex.Message);
            }
        }

        public static void Disconnect()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }
        public static DataTable Getdatatotable(string sql)
        {
            SqlDataAdapter mydata = new SqlDataAdapter();
            try
            {
                mydata.SelectCommand = new SqlCommand(sql, conn);
                DataTable dtable = new DataTable();
                mydata.Fill(dtable);
                return dtable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
                return null;
            }
        }


       // Viết hàm checkkey để kiểm tra trùng mã
        public static bool checkkey(string sql)
        {
            try
            {
                SqlDataAdapter mydata = new SqlDataAdapter(sql, conn);
                DataTable table = new DataTable();
                mydata.Fill(table);
                return table.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra khóa: " + ex.Message);
                return false;
            }
        }

       // Viết thủ tục runsql để thực thi câu lệnh
        public static void runsql(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi lệnh SQL: " + ex.Message);
            }
            finally
            {
                cmd.Dispose();
            }
        }
    }
}
