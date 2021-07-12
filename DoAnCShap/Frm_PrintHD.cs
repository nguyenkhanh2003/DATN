using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCShap
{
    public partial class Frm_PrintHD : Form
    {
        public Frm_PrintHD()
        {
            InitializeComponent();
        }

        Frm_HoaDonBanHang hd = new Frm_HoaDonBanHang();
        private void Frm_PrintHD_Load(object sender, EventArgs e)
        {
            //InHoaDon();
        }

        public void InHoaDon()
        {
            //Khai báo câu lệnh SQL
            String sql = "select lk.TenLK,ct.SoLuong,ct.DonGia,ct.KhuyenMai,ct.ThanhTien From CT_HoaDonBanHang ct,LinhKien lk where lk.MaLK=ct.MaLK and MaHDBH=N'"+textBox1.Text+"' ";
            SqlConnection con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            con.ConnectionString = "Data Source=DESKTOP-L3VUEAK; Initial Catalog =PM_BanLinhKienPC;Integrated Security = True";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
            reportViewer1.LocalReport.ReportPath = "reportbc.rdlc";
            //Nếu có dữ liệu
            if (ds.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "CT_HoaDonBanHang";
                rds.Value = ds.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                reportViewer1.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                reportViewer1.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                reportViewer1.RefreshReport();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InHoaDon();
        }
    }
}
