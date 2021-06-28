using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCShap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
        }

        //public void funData(TextBox txtTenHienThi)
        //{
        //    labelHienThiTenDangNhap.Text = txtTenHienThi.Text;
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Hay Không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //Do something here if OK was clicked.
                Application.Exit();
            }
        }
        private void hideSubMenu()
        {
            //panelMediaSubMenu.Visible = false;
            //panelPlaylistSubMenu.Visible = false;
            //panelToolsSubMenu.Visible = false;
            //panelQuanLy.Visible = false;
            ///panelKhoHang.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        public Form activeForm = null;

        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_DSTaiKhoan());
            lbl_HienThiForm.Text = "Danh Sách Tài Khoản";
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_NhanVien());
            lbl_HienThiForm.Text = "Quản Lý Nhân Viên";
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_KH());
            lbl_HienThiForm.Text = "Quản Lý Khách Hàng";
        }

        private void btnLinhKien_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_SanPham());
            lbl_HienThiForm.Text = "Quản Lý Linh Kiện";
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_NhaCungCap());
            lbl_HienThiForm.Text = "Quản Lý Nhà Cung Cấp";
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            //openChildForm(new Frm_DanhSachNhapPhieu());
            openChildForm(new Frm_HoaDonNhap());
            lbl_HienThiForm.Text = "Nhập Kho";
        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
           // login.TopLevel = false;
           // panelChildForm.Controls.Add(login);
           // login.Dock = DockStyle.None;
            login.BringToFront();
            login.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            //openChildForm(new Frm_DanhSachHoaDon());
            openChildForm(new Frm_HoaDonBanHang());
            lbl_HienThiForm.Text = "Quản Lý Hóa Đơn";
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBaoHanh_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
            lbl_HienThiForm.Text = "Trang Chủ";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_TraCuu());
            lbl_HienThiForm.Text = "Tra Cứu Tổng Hợp";
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_BanHang());
            lbl_HienThiForm.Text = "Bán Hàng";
        }

        public static string UserName = "";


        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_HienThiForm.Text = "Home";
            fillChart();
            Login frmDN = new Login();
            frmDN.ShowDialog();
            if (Login.IsClose) this.Close();
            if (Login.QLNV) btnNhanVien.Enabled = true; else btnNhanVien.Enabled = false;
            if (Login.QLKH) btnKhachHang.Enabled = true; else btnKhachHang.Enabled = false;
            if (Login.QLLK) btnLinhKien.Enabled = true; else btnLinhKien.Enabled = false;
            if (Login.QLBH) btnBanHang.Enabled = true; else btnBanHang.Enabled = false;
            if (Login.QLNCC) btnNhaCungCap.Enabled = true; else btnNhaCungCap.Enabled = false;
            if (Login.QLLLK) btnLoaiLK.Enabled = true; else btnLoaiLK.Enabled = false;
            if (Login.QLNK) btnPhieuNhap.Enabled = true; else btnPhieuNhap.Enabled = false;
            if (Login.BaoHanh) btnBaohanh.Enabled = true; else btnBaohanh.Enabled = false;
            if (Login.PhanQuyenn) btnPhanQuyen.Enabled = true; else btnPhanQuyen.Enabled = false;
            if (Login.ThongKe) btnThongKe.Enabled = true; else btnThongKe.Enabled = false;
            if (Login.HoaDon) btnHoaDon.Enabled = true; else btnHoaDon.Enabled = false;
            if (Login.Setting) btnSetting.Enabled = true; else btnSetting.Enabled = false;
            labelHienThiTenDangNhap.Text = Login.TenTaiKhoan;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_HoaDonBan_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_HoaDonBanHang());
            lbl_HienThiForm.Text = "Hóa Đơn Bán Hàng";
        }

        private void iconBtn_TaiKhoan_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_DSTaiKhoan());
            lbl_HienThiForm.Text = "Danh Sách Tài Khoản";
        }

        private void iconBtn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Hay Không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                //Do something here if OK was clicked.
                Application.Exit();
            }
        }

        private void iconBtnThuNho_Click(object sender, EventArgs e)
        {
           if(panelSideMenu.Visible)
            {
                panelSideMenu.Hide();
            }
           else
            {
                panelSideMenu.Show();
            }    
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            Login DN = new Login();
            DN.ShowDialog();
            this.Visible = false;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            lbl_HienThiForm.Text = "Nhà Cung Cấp";
            openChildForm(new Frm_NhaCungCap());
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            lbl_HienThiForm.Text = "Bán Hàng";
            //openChildForm(new Frm_BanHang());
            openChildForm(new Frm_BanHan());
        }

        private void btnBaohanh_Click_1(object sender, EventArgs e)
        {
            lbl_HienThiForm.Text = "Bảo Hành";
            openChildForm(new Frm_BaoHanh());
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            lbl_HienThiForm.Text = "Thống Kê";
            openChildForm(new Frm_ThongKe());
        }

        private void btnPhanQuyen_Click_1(object sender, EventArgs e)
        {
            lbl_HienThiForm.Text = "Phân Quyền Tài Khoản";
            openChildForm(new Frm_ChucVu());
        }

        private void btnLoaiLK_Click(object sender, EventArgs e)
        {
            lbl_HienThiForm.Text = "Loại Linh Kiện";
            openChildForm(new Frm_LLinhKien());
        }

        private void btnNhaSanXuat_Click(object sender, EventArgs e)
        {
            lbl_HienThiForm.Text = "Nhà Sản Xuất";
            openChildForm(new Frm_NSX());
        }

        private void fillChart()
        {
            //AddXY value in chart1 in series named as Salary  
            chart1.Series["Salary"].Points.AddXY("Tổng Sản Phẩm", "10000");
            chart1.Series["Salary"].Points.AddXY("Nhân Viên", "8000");
            chart1.Series["Salary"].Points.AddXY("Hoă Đơn", "7000");
            chart1.Series["Salary"].Points.AddXY("Khách Hàng", "10000");
            chart1.Series["Salary"].Points.AddXY("Suresh", "8500");
            //chart title  
            chart1.Titles.Add("Salary Chart");
        }

        private void labelHienThiTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        public static string SetValueForText1 = "";

    }
}
