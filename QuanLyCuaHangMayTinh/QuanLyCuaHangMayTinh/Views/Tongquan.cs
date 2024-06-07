using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangMayTinh.Presenter;
namespace QuanLyCuaHangMayTinh.Views
{
    public partial class Tongquan : Form
    {
        PreSale order = new PreSale();
        PreMain prsMain = new PreMain();
        public Tongquan()
        {
            InitializeComponent();
            PreMain.AddMenuStripToForm(this);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            showChartByMonth();
            LoadDayTotalSale();
            LoadComparePrevDay();
            LoadComparePrevMonth();
        }
        private void InitializeChart(string xTitle, string yTitle)
        {
            chartSales.Series.Clear();
            chartSales.ChartAreas.Clear();
            chartSales.Series.Add("Tổng tiền hàng bán được");
            chartSales.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea());
            chartSales.ChartAreas[0].AxisX.Title = xTitle;
            chartSales.ChartAreas[0].AxisY.Title = yTitle;
            chartSales.Series["Tổng tiền hàng bán được"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }
        private void showChartByMonth()
        {
            InitializeChart("Ngày", "Tổng tiền");
            DateTime now = DateTime.Now;
            DataTable dt = order.getOrderByMonth(now);

            foreach (DataRow row in dt.Rows)
            {
                DateTime date = (DateTime)row["Date"];
                decimal totalAmount = (decimal)row["TotalAmount"];
                chartSales.Series["Tổng tiền hàng bán được"].Points.AddXY(date.Day, totalAmount);
            }
        }

        private void showChartByDayOfWeek()
        {
            InitializeChart("Thứ", "Tổng tiền");
            DataTable dt = order.getOrderByCurrentWeek();

            foreach (DataRow row in dt.Rows)
            {
                DateTime date = (DateTime)row["Date"];
                decimal totalAmount = (decimal)row["TotalAmount"];
                string dayOfWeek = date.DayOfWeek.ToString();
                chartSales.Series["Tổng tiền hàng bán được"].Points.AddXY(dayOfWeek, totalAmount);
            }
        }


        private void btn_Theongay_Click(object sender, EventArgs e)
        {
            showChartByMonth();
        }

        private void btn_Theothu_Click(object sender, EventArgs e)
        {
            showChartByDayOfWeek();
        }
        private void LoadDayTotalSale()
        {
            DateTime now= DateTime.Now;
            DataTable a = order.getOrderByDay(now);
            decimal totalAmount = a.AsEnumerable()
            .Sum(row => row.Field<decimal>("TotalAmount"));
            lbDailySale1.Text=totalAmount.ToString();
            lbDailySale2.Text=totalAmount.ToString();
            lbDailyOrderCount.Text = order.SumOfOrder(order.getOrderByDay(now)).ToString();

        }
        private void LoadComparePrevDay()
        {
            DateTime now = DateTime.Now;
            DataTable a = order.getOrderByDay(now);
            decimal totalCurrentDay = a.AsEnumerable()
            .Sum(row => row.Field<decimal>("TotalAmount")); 
            DataTable b = order.getOrderByDay(now.AddDays(-1));
            decimal totalPrevDay = b.AsEnumerable()
            .Sum(row => row.Field<decimal>("TotalAmount"));
            decimal growth = (totalCurrentDay - totalPrevDay) / totalPrevDay * 100;
            growth=Math.Round(growth, 2);
            lbComparePrevDay.Text=growth.ToString() + "%";
            if (growth > 0)
            {
                lbComparePrevDay.ForeColor = Color.Green;
            }
            else
            {
                lbComparePrevDay.ForeColor = Color.Red;
            }
        }
        private void LoadComparePrevMonth() {
            DateTime now = DateTime.Now;
            DataTable a = order.getOrderByMonth(now);
            decimal totalCurrentMonth = a.AsEnumerable()
            .Sum(row => row.Field<decimal>("TotalAmount"));
            DataTable b = order.getOrderByMonth(now.AddMonths(-1));
            decimal totalPrevMonth = b.AsEnumerable()
            .Sum(row => row.Field<decimal>("TotalAmount"));
            decimal growth = (totalCurrentMonth - totalPrevMonth) / totalPrevMonth * 100;
            growth= Math.Round(growth, 2);
            lbComparePrevMonth.Text = growth.ToString() + "%";
            if (growth > 0)
            {
                lbComparePrevMonth.ForeColor = Color.Green;
            }
            else
            {
                lbComparePrevMonth.ForeColor = Color.Red;
            }
        }
    }
}
