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

        public void HienThiCV()
        {
            comboBoxCV.DataSource = bus.HienThiDScV("Select * From ChucVu");
            comboBoxCV.DisplayMember = "TenCV";
            comboBoxCV.ValueMember = "MaCV";
        }
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
        public static string SetValueForText2 = "";

        public static string BtnPhanQuyen;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //String username = txtTenDangNhap.Text;
            //String password =CreateMd5(txtMatKhau.Text);
            ////MaHoa();
            //SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-L3VUEAK; Initial Catalog =PM_BanLinhKienPC;Integrated Security = True");
            //string query = "Select * From NhanVien Where UserName =N'" + username + "' and PassWord=N'" +password+ "' and TrangThai=N'Mới'";
            //SqlDataAdapter sda = new SqlDataAdapter(query,sql);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //if(dt.Rows.Count==1)
            //{
            //    MessageBox.Show("Đăng Nhập Thành Công");
            //    {

            //        Form1 f = new Form1();
            //        SetValueForText1 = username;
            //        f.ShowDialog();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Fail Username and PassWord !");
            //}    
            string username = txtTenDN.Text;
            string password = txtMatKhau.Text;
            string chucvu = comboBoxCV.SelectedValue.ToString();
            string query = "SELECT MaCV from NhanVien WHERE Username = @username and password=@password";
            string returnValue = "";
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-L3VUEAK; Initial Catalog =PM_BanLinhKienPC;Integrated Security = True"))
            {
                using (SqlCommand sqlcmd = new SqlCommand(query, con))
                {
                    //sqlcmd.Parameters.Add("@tencv", SqlDbType.VarChar).Value = chucvu;
                    sqlcmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                    sqlcmd.Parameters.Add("@password", SqlDbType.VarChar).Value =CreateMd5(password);
                    con.Open();
                    returnValue = (string)sqlcmd.ExecuteScalar();
                }
            }
            //EDIT to avoid NRE 
            if (String.IsNullOrEmpty(returnValue))
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                return;
            }
            returnValue = returnValue.Trim();
            try
            {
                if (returnValue ==chucvu)
                {
                    MessageBox.Show("Login AS Admin");
                    Form1 fr1 = new Form1();
                    SetValueForText1 = username;
                    SetValueForText2 = username;
                    fr1.Show();
                    this.Hide();
                }
                else if (returnValue == "CV02")
                {
                    MessageBox.Show("Login AS User");
                    Form1 fr1 = new Form1();
                    SetValueForText1 = txtTenDN.Text;
                    SetValueForText2 = username;
                    fr1.btnNhanVien.Enabled = false;
                    fr1.btnKhachHang.Enabled = false;
                    fr1.btnLinhKien.Enabled = false;
                    fr1.btnLoaiLK.Enabled = false;
                    fr1.btnThongKe.Enabled = false;
                    fr1.btnSetting.Enabled = false;
                    fr1.btnNhaCungCap.Enabled = false;
                    fr1.btnPhieuNhap.Enabled = false;
                    fr1.btnHoaDon.Enabled = false;
                    fr1.btnPhanQuyen.Enabled = false;
                    fr1.Show();
                    this.Hide();
                }
                else if(returnValue=="CV03")
                {
                    MessageBox.Show("Login AS User");
                    Form1 fr1 = new Form1();
                    SetValueForText1 = txtTenDN.Text;
                    SetValueForText2 = username;
                    fr1.btnNhanVien.Enabled = false;
                    fr1.btnKhachHang.Enabled = false;
                    fr1.btnLinhKien.Enabled = false;
                    fr1.btnLoaiLK.Enabled = false;
                    fr1.btnThongKe.Enabled = false;
                    fr1.btnSetting.Enabled = false;
                    fr1.btnNhaCungCap.Enabled = false;
                    fr1.btnBanHang.Enabled = false;
                    fr1.btnBaohanh.Enabled = false;
                    //fr1.btnPhieuNhap.Enabled = false;
                    fr1.btnHoaDon.Enabled = false;
                    fr1.btnPhanQuyen.Enabled = false;
                    fr1.Show();
                    this.Hide();
                }    

            }
            catch (Exception ex)
            {

            }
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            HienThiCV();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
