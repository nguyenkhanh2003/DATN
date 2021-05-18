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

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Hay Không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
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

        private Form activeForm = null;
        private void openChildForm(Form childForm)
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
            openChildForm(new Frm_NCC());
            lbl_HienThiForm.Text = "Quản Lý Nhà Cung Cấp";
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_DanhSachNhapPhieu());
            lbl_HienThiForm.Text = "Quản Lý Phiếu Nhập";
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
            openChildForm(new Frm_DanhSachHoaDon());
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
            lbl_HienThiForm.Text = "Tra Cưu Tổng Hợp";
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_BanHang());
            lbl_HienThiForm.Text = "Bán Hàng";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_HienThiForm.Text = "Home";
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

       
    }
}
