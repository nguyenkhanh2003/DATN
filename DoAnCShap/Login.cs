using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        MD5 md = MD5.Create();

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

        public string encryption(String password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            //encrypt the given password string into Encrypted data  
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            //Create a new string by using the encrypted data  
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }

        public void MaHoa()
        {
            byte[] inputstr = System.Text.Encoding.ASCII.GetBytes(txtMatKhau.Text);
            byte[] hask = md.ComputeHash(inputstr);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hask.Length; i++)
            {
                sb.Append(hask[i].ToString("X2"));
            }
            txtMatKhau.Text = sb.ToString();
        }

        public static string CreateMd5(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hasBytes = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for(int i=0;i<hasBytes.Length;i++)
            {
                sb.Append(hasBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static string SetValueForText1 = "";

        public static string BtnPhanQuyen;
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtTenDangNhap.Text;
            String password =CreateMd5(txtMatKhau.Text);
            //MaHoa();
            SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-L3VUEAK; Initial Catalog =PM_BanLinhKienPC;Integrated Security = True");
            string query = "Select * From NhanVien Where UserName =N'" + username + "' and PassWord=N'" +password+ "' and TrangThai=N'Mới'";
            SqlDataAdapter sda = new SqlDataAdapter(query,sql);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count==1)
            {
                MessageBox.Show("Đăng Nhập Thành Công");
                {
                    
                    Form1 f = new Form1();
                    SetValueForText1 = username;
                    f.ShowDialog();
                    f.btnNhaSanXuat.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Fail Username and PassWord !");
            }    

        }
    }
}
