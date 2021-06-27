using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace DoAnCShap
{
    public partial class Frm_ThongKe : Form
    {
        public Frm_ThongKe()
        {
            InitializeComponent();
        }

        DoanhThu_BUS bus = new DoanhThu_BUS();
        
        public void HienThiDoanhThu()
        {
            dataGridView1.DataSource = bus.DoanhThuTatCa("");
        }

        public void HienThiDoanhThuTheoNam(string condition)
        {
            dataGridView1.DataSource = bus.DoanThuTheoNam("Select Year(NgayLapHDBH) as 'Nam', Sum(TongTien) as 'Doanh thu' From HoaDonBanHang Where YEAR(NgayLapHDBH) ="+condition+" Group by Year(NgayLapHDBH)");
        }

        //public void HienThiDoanhThuTheoNgay(int condition,int condition1,int condition3,int condition4)
        //{
        //    dataGridView1.DataSource = bus.DoanhThuTheoNgay("Select SUM(TongTien) AS 'Doanh Thu' From HoaDonBanHang Where  DAY(NgayLapHDBH) BETWEEN "+condition+" and "+condition1+" and MONTH(NgaLapHDBH) BETWEEN "+condition3+" and "+condition4+" ");
        //}

        public void HienThiDoanhThuTheoNgay(string condition, string condition1)
        {
            dataGridView1.DataSource = bus.DoanhThuTheoNgay("Select SUM(TongTien) AS 'Doanh Thu' From HoaDonBanHang Where(NgayLapHDBH) BETWEEN '"+condition+"' and '"+condition1+"' ");
        }
        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {
            fillChart();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXemDoanhThu_Click(object sender, EventArgs e)
        {
            if (radioButtonTatCa.Checked == true)
            {
                HienThiDoanhThu();
            }
            if (radioButtonTheoNgay.Checked==true)
            {
                string condition = dateTimePicker1.Text;
                //int condition3 = dateTimePicker1.Value.Month;
                string condition1 = dateTimePicker2.Text;
                //int condition4 = dateTimePicker1.Value.Month;
                HienThiDoanhThuTheoNgay(condition, condition1);
            }    
            else
            {
                string condition = comboBoxNam.Text;
                HienThiDoanhThuTheoNam(condition);
            }    
        }

        private void fillChart()
        {
            //AddXY value in chart1 in series named as Salary  
            chart1.Series["Salary"].Points.AddXY("Hổm Nay", "100");
            chart1.Series["Salary"].Points.AddXY("Tháng Này", "800");
            chart1.Series["Salary"].Points.AddXY("Năm Nay", "8000");
            //chart1.Series["Salary"].Points.AddXY("Khách Hàng", "10000");
            //chart1.Series["Salary"].Points.AddXY("Suresh", "8500");
            //chart title  
            chart1.Titles.Add("Doanh Thu Hóa Đơn Bán");
        }
    }
}
