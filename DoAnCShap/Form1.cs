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
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_NhanVien());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_KH());
        }

        private void btnLinhKien_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_SanPham());
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_NCC());
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_NhapLinhKien());
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
        }
    }
}
