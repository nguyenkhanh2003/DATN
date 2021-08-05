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
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

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
            // = bus.DoanhThuTatCa("");
        }

        public void HienThiDoanhThuTheoNam(string condition)
        {
            //dataGridView1.DataSource = bus.DoanThuTheoNam("Select Year(NgayLapHDBH) as 'Năm',  format(sum([TongTien]),'N0') as 'Doanh thu'" +
            //    " From HoaDonBanHang Where YEAR(NgayLapHDBH) =" + condition + " Group by Year(NgayLapHDBH)");

            cboDoanhThu.DataSource = bus.DoanThuTheoNam("Select format(sum([TongTien]),'N0') as TT" +
                " From HoaDonBanHang Where YEAR(NgayLapHDBH) =" + condition + " ");
            cboDoanhThu.DisplayMember = "TT";
        }

        public void HienThiDoanhThuTheoNgay(string condition, string condition1)
        {
            chart1.DataSource = bus.DoanhThuTheoNgay("Select  format(sum([TongTien]),'N0') AS 'Doanh Thu'" +
                " From HoaDonBanHang Where(NgayLapHDBH) BETWEEN '" + condition + "' and '" + condition1 + "' ");

        }

        public void DoanhThuTheoThang(string condition)
        {
            //dataGridView1.DataSource = bus.DoanhThuTheoThang("SELECT   format(sum([TongTien]),'N0') AS'Donh Thu'" +
            //    " FROM HoaDonBanHang hd WHERE Month(hd.NgayLapHDBH)=" + condition + " ");

            cboDoanhThu.DataSource = bus.DoanhThuTheoThang("SELECT   format(sum([TongTien]),'N0') AS TT" +
              " FROM HoaDonBanHang hd WHERE Month(hd.NgayLapHDBH)=" + condition + " ");
            cboDoanhThu.DisplayMember = "TT";
        }

        public void SPBanChayTheoThang(string condition)
        {
            dataGridView1.DataSource = bus.SPBanChayTheoThang("SELECT TOP(3) lk.TenLK As'Tên Sản Phẩm', SUM(ct.SoLuong) AS 'Số Lượng'  " +
                "FROM CT_HoaDonBanHang ct, HoaDonBanHang hd, LinhKien lk " +
                "where ct.MaHDBH = hd.MaHDBH and lk.MaLK = ct.MaLK  and MONTH(hd.NgayLapHDBH) =" + condition + "" +
                " GROUP BY lk.TenLK ORDER BY SUM(ct.SoLuong) DESC ");
        }

        public void Top3SanPhamBanTrongNam(string condition)
        {
            dataGridView1.DataSource = bus.Top3SanPhamBanTrongNam("SELECT TOP(3) lk.TenLK As'Tên Sản Phẩm', SUM(ct.SoLuong) AS 'Số Lượng'" +
                " FROM CT_HoaDonBanHang ct, HoaDonBanHang hd, LinhKien lk" +
                " where ct.MaHDBH = hd.MaHDBH and lk.MaLK = ct.MaLK  and Year(hd.NgayLapHDBH) =" + condition + " " +
                "GROUP BY lk.TenLK ORDER BY SUM(ct.SoLuong) DESC ");
        }
        public void Top3SPMuaNhieuTrongThang(string condition)
        {
            dataGridView1.DataSource = bus.Top3MuaMonth("SELECT TOP(3) lk.TenLK As'Tên Sản Phẩm', SUM(ct.SoLuong) AS 'Số Lượng'" +
                " FROM CT_HoaDonNhapHang ct, HoaDonNhapHang hd, LinhKien lk " +
                "where ct.MaHDNH = hd.MaHDNH and lk.MaLK = ct.MaLK  and Month(hd.NgayLapHDNH) =" + condition + " " +
                "GROUP BY lk.TenLK ORDER BY SUM(ct.SoLuong) DESC");
        }

        public void Top3SPMuaNhieuTrongNam(string condition)
        {
            dataGridView1.DataSource = bus.Top3SPMuaYear("SELECT TOP(3) lk.TenLK As'Tên Sản Phẩm', SUM(ct.SoLuong) AS 'Số Lượng' " +
                "FROM CT_HoaDonNhapHang ct, HoaDonNhapHang hd, LinhKien lk " +
                "where ct.MaHDNH = hd.MaHDNH and lk.MaLK = ct.MaLK  and Year(hd.NgayLapHDNH) =" + condition + " " +
                "GROUP BY lk.TenLK ORDER BY SUM(ct.SoLuong) DESC ");
        }

        public void Top3HDMuaNhieuTrongThang(string condition)
        {
            dataGridView1.DataSource = bus.Top3HDMuaNhieu("SELECT TOP(3) hd.MaHDBH As'Mã Hóa Đơn', count(ct.MaHDBH) AS 'Số Lượng'" +
                " FROM CT_HoaDonBanHang ct, HoaDonBanHang hd" +
                " where ct.MaHDBH = hd.MaHDBH  and Month(hd.NgayLapHDBH) =" + condition + " " +
                " GROUP BY hd.MaHDBH ORDER BY count(hd.MaHDBH) DESC ");
        }

        public void DoanhthuThang1(string condition)
        {
            chart1.DataSource = bus.DoanhThuThang1("SELECT   format(sum([TongTien]),'N0') AS'Donh Thu'" +
                " FROM HoaDonBanHang hd WHERE Month(hd.NgayLapHDBH)=1 and Year(hd.NgayLapHDBH)=" + comboBoxNam.Text + "");
        }

        public void Khachhangmuanhieutrongthang(string condition)
        {
            dataGridView1.DataSource = bus.KhachhangMuaNhieu("SELECT TOP(1) kh.TenKH As'Tên Khách Hàng', count(hd.MaHDBH) AS 'Số Lần' FROM  HoaDonBanHang hd,KhachHang kh where kh.MaKH=hd.MaKH and month(hd.NgayLapHDBH) =" + condition + " GROUP BY kh.TenKH ORDER BY count(hd.MaHDBH) DESC");
        }

        public void KHMuaNhieuTrongNam(string condition)
        {
            dataGridView1.DataSource = bus.KhachHangMuaNhieuTrongNam("SELECT TOP(1) kh.TenKH As'Tên Khách Hàng', count(hd.MaHDBH) AS 'Số Lần' FROM  HoaDonBanHang hd,KhachHang kh where kh.MaKH=hd.MaKH and year(hd.NgayLapHDBH) =" + condition + " GROUP BY kh.TenKH ORDER BY count(hd.MaHDBH) DESC");
        }
        public void LoadBieuDo()
        {
            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "{#,###} Đ";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 12;
            chart.AxisY.Minimum = 0;

            //chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0,}K";
            chart1.DataSource = bus.DoanhThuThang3("SELECT Month(hd.NgayLapHDBH) as Thang, sum(hd.TongTien) as TongTien " +
            " FROM HoaDonBanHang hd WHERE Month(hd.NgayLapHDBH)>0 and MONTH(hd.NgayLapHDBH)<13  and Year(hd.NgayLapHDBH)=" + comboBoxNam.Text + " Group By Month(hd.NgayLapHDBH) ");
            chart1.Series["Doanh Thu"].XValueMember = "Thang";
            chart1.Series["Doanh Thu"].YValueMembers = "TongTien";
            chart1.Titles.Add("Doanh Thu Các Tháng Năm 2021");
        }


        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {
            Fill_CmbYear();
            LoadBieuDo();
        }


        private void btnXemDoanhThu_Click(object sender, EventArgs e)
        {

            if (radioTheoThang.Checked == true)
            {
                if (comboBoxThang.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(comboBoxThang, "Chưa chọn tháng");
                    return;
                }
                else
                {
                    string condition = comboBoxThang.Text;
                    DoanhThuTheoThang(condition);
                }
            }
            if (radioBanNhieuMonth.Checked == true)
            {
                string condition1 = comboBoxThang.Text;
                SPBanChayTheoThang(condition1);
            }
            if (radioDoanhThuYea.Checked == true)
            {
                string condition2 = comboBoxNam.Text;
                HienThiDoanhThuTheoNam(condition2);
            }
            if (radioBanNhieuYear.Checked == true)
            {
                string condition2 = comboBoxNam.Text;
                Top3SanPhamBanTrongNam(condition2);
            }
            if (radioButMuaYear.Checked == true)
            {
                string condition = comboBoxNam.Text;
                Top3SPMuaNhieuTrongNam(condition);
            }
            if (radioButMuaMonth.Checked == true)
            {
                string condition = comboBoxThang.Text;
                Top3SPMuaNhieuTrongThang(condition);
            }

            if (radioButTop3HDMua.Checked == true)
            {
                string condition = comboBoxThang.Text;
                Top3HDMuaNhieuTrongThang(condition);
            }
            if (radioButKhachMuaNhieeu.Checked == true)
            {
                string condition = comboBoxThang.Text;
                Khachhangmuanhieutrongthang(condition);
            }
            if (radioBKhachmuanhieutrongnam.Checked == true)
            {
                string condition = comboBoxNam.Text;
                KHMuaNhieuTrongNam(condition);
            }
        }

        private void fillChart()
        {
            float x1 = 34;
            float x2 = 24;
            float x3 = 31;
            float x4 = 20;
            float x5 = 14;
            float x6 = 10;
            float x7 = 36;
            float x8 = 9;
            float x9 = 18;
            float x10 = 28;
            float x11 = 44;
            float x12 = 48;

            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 12;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 50;
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 5;

            chart1.Series.Add("Doanh Thu");
            chart1.Series["Doanh Thu"].ChartType = SeriesChartType.Line;
            chart1.Series[0].IsVisibleInLegend = false;

            chart1.Series["Doanh Thu"].Points.AddXY(1, x1);
            chart1.Series["Doanh Thu"].Points.AddXY(2, x2);
            chart1.Series["Doanh Thu"].Points.AddXY(3, x3);
            chart1.Series["Doanh Thu"].Points.AddXY(4, x4);
            chart1.Series["Doanh Thu"].Points.AddXY(5, x5);
            chart1.Series["Doanh Thu"].Points.AddXY(6, x6);
            chart1.Series["Doanh Thu"].Points.AddXY(7, x7);
            chart1.Series["Doanh Thu"].Points.AddXY(8, x8);
            chart1.Series["Doanh Thu"].Points.AddXY(9, x9);
            chart1.Series["Doanh Thu"].Points.AddXY(10, x10);
            chart1.Series["Doanh Thu"].Points.AddXY(11, x11);
            chart1.Series["Doanh Thu"].Points.AddXY(12, x12);
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void Fill_CmbYear()
        {
            try
            {
                //clear all data from combobox
                comboBoxNam.Items.Clear();
                //add default item
                comboBoxNam.Items.Add("Select");
                //loop array for add items
                for (int i = DateTime.Now.Year; i < DateTime.Now.Year + 100; i++)
                {
                    comboBoxNam.Items.Add(i);
                }
                //set selected item for display on startup
                comboBoxNam.Text = DateTime.Now.Year.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
