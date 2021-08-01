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
using System.Security.Cryptography;

namespace DoAnCShap
{
    public partial class Frm_LaylaiPass : Form
    {
        public Frm_LaylaiPass()
        {
            InitializeComponent();
        }

        Login_BUS bus = new Login_BUS();
        NhanVien nv = new NhanVien();

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_TaoTaiKhoan hien = new Frm_TaoTaiKhoan();
            hien.Show();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }

        MD5 md = MD5.Create();

        public static string CreateMd5(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hasBytes = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hasBytes.Length; i++)
            {
                sb.Append(hasBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public void KiemTraTaiKhoan()
        {


        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtTenDangNhap, "? Tên đăng nhập không được để trống");
                return;
            }
            if (txtMatKhau.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtMatKhau, "Mật Khẩu Không Được Để Trống");
                return;
            }
            if (txtNhapLaiMatKhau.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtNhapLaiMatKhau, "Chỗ Này Không Được Để Trống");
                return;
            }
            else
            {
                DataTable layusername = bus.LayUserName("select * from NhanVien");
                if (layusername.Rows.Count > 0)
                {
                    if (txtTenDangNhap.Text == layusername.Rows[0]["UserName"].ToString())
                    {
                        if (CreateMd5(txtMatKhau.Text) == CreateMd5(txtNhapLaiMatKhau.Text))
                        {
                            CreateMd5(txtMatKhau.Text);
                            nv.UserName = txtTenDangNhap.Text;
                            nv.PassWord = txtMatKhau.Text;
                            bus.UpdateTaiKhoan(nv);
                            labelMesage.Text = "Thành Công";
                        }

                    }
                    else
                    {
                        MessageBox.Show("Tên Đăng Nhập Không Đúng");
                    }
                }
            }
        }
    }
}
