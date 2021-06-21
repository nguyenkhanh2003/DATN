using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace DoAnCShap
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Login_BUS bus = new Login_BUS();
        NhanVien nv = new NhanVien();
            private static bool _exiting;

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            if (!_exiting && MessageBox.Show("Are you sure want to exit?",
                          "My First Application",
                           MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Information) == DialogResult.OK)
            {
                _exiting = true;
                // this.Close(); // you don't need that, it's already closing
                Environment.Exit(1);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        public void DangNhap(string username,string password)
        {
           
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;
            //bus.GetLoGin("Select * From NhanVien Where UserName = N'" + username+"' and PassWord = N'"+password+"'");
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
