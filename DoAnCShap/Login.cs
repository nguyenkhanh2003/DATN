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

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L3VUEAK; Initial Catalog =PM_BanLinhKienPC;Integrated Security = True");
        public static string ID_USER = "";
        public static bool IsClose = false;
        public static bool QLNV;//4
        public static bool QLKH;
        public static bool QLLK;
        public static bool QLLLK;
        public static bool QLBH;
        public static bool BaoHanh;
        public static bool QLNCC;
        public static bool QLNK;
        
        public static string TenTaiKhoan = "";//lấy thêm têm tài khoản nhé, 
        public bool PhanQuyen(int col)
        {
            bool KiemTra = false;
            for(int i=0;i<bus.GetLogin(txtTenDN.Text,CreateMd5(txtMatKhau.Text)).Rows.Count;i++)
            {
                if (bus.GetLogin(txtTenDN.Text,CreateMd5(txtMatKhau.Text)).Rows[i][col].ToString() =="True")
                    return KiemTra = true;
            }
            return KiemTra;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string username = txtTenDN.Text;
            //string password = txtMatKhau.Text;
            //string chucvu = comboBoxCV.SelectedValue.ToString();
            //string query = "SELECT NhanVien.MaCV,ChucVu.ToanQ from NhanVien,ChucVu WHERE ChucVu.MacV=NhanVien.MaCV and Username = @username and password=@password";
            //string returnValue = "";
            ////int returnValue1 = 0;
            //using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-L3VUEAK; Initial Catalog =PM_BanLinhKienPC;Integrated Security = True"))
            //{
            //    using (SqlCommand sqlcmd = new SqlCommand(query, con))
            //    {
            //        //sqlcmd.Parameters.Add("@tencv", SqlDbType.VarChar).Value = chucvu;
            //        sqlcmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            //        sqlcmd.Parameters.Add("@password", SqlDbType.VarChar).Value = CreateMd5(password);
            //        con.Open();
            //        returnValue = (string)sqlcmd.ExecuteScalar();
            //    }
            //}
            ////EDIT to avoid NRE 
            //if (String.IsNullOrEmpty(returnValue))
            //{
            //    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            //    return;
            //}
            //else if (String.IsNullOrEmpty(returnValue))
            //{
            //    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            //    return;
            //}
            //returnValue = returnValue.Trim();
            //if (returnValue == "CV01")
            //{
            //    MessageBox.Show("Đăng nhập thành công với quyền Admin");
            //    Form1 fr1 = new Form1();
            //    SetValueForText1 = username;
            //    SetValueForText2 = username;
            //    fr1.Show();
            //    this.Hide();
            //}
            //else if (returnValue == "CV02")
            //{
            //    MessageBox.Show("Đăng nhập thành công với quyền User");
            //    Form1 fr1 = new Form1();
            //    SetValueForText1 = txtTenDN.Text;
            //    SetValueForText2 = username;
            //    fr1.btnNhanVien.Enabled = false;
            //    fr1.btnKhachHang.Enabled = false;
            //    fr1.btnLinhKien.Enabled = false;
            //    fr1.btnLoaiLK.Enabled = false;
            //    fr1.btnThongKe.Enabled = false;
            //    fr1.btnSetting.Enabled = false;
            //    fr1.btnNhaCungCap.Enabled = false;
            //    fr1.btnPhieuNhap.Enabled = false;
            //    fr1.btnHoaDon.Enabled = false;
            //    fr1.btnPhanQuyen.Enabled = false;
            //    fr1.Show();
            //    this.Hide();
            //}
            //else if (returnValue == "CV03")
            //{
            //    MessageBox.Show("Đăng nhập thành công với quyền nhân viên kho");
            //    Form1 fr1 = new Form1();
            //    SetValueForText1 = txtTenDN.Text;
            //    SetValueForText2 = username;
            //    fr1.btnNhanVien.Enabled = false;
            //    fr1.btnKhachHang.Enabled = false;
            //    fr1.btnLinhKien.Enabled = false;
            //    fr1.btnLoaiLK.Enabled = false;
            //    fr1.btnThongKe.Enabled = false;
            //    fr1.btnSetting.Enabled = false;
            //    fr1.btnNhaCungCap.Enabled = false;
            //    fr1.btnBanHang.Enabled = false;
            //    fr1.btnBaohanh.Enabled = false;

            //    fr1.btnHoaDon.Enabled = false;
            //    fr1.btnPhanQuyen.Enabled = false;
            //    fr1.Show();
            //    this.Hide();
            //}
            int count = bus.GetLogin(txtTenDN.Text, CreateMd5(txtMatKhau.Text)).Rows.Count;
            //int count = bus.GetLogin(txtTenDN.Text,txtMatKhau.Text).Rows.Count;
            if (count==0)
            {
                MessageBox.Show("Thất Bại");
            }
            else
            {
                //TenTaiKhoan = bus.GetLogin(txtTenDN.Text, txtMatKhau.Text).Rows[0][3].ToString();
                MessageBox.Show("Đăng Nhập Thành Công");
                QLNV = PhanQuyen(15);
                QLKH = PhanQuyen(16);
                QLLK = PhanQuyen(17);
                QLBH = PhanQuyen(18);
                QLNCC = PhanQuyen(19);
                QLLLK = PhanQuyen(20);
                QLNK = PhanQuyen(21);
                BaoHanh = PhanQuyen(22);
                this.Close();
            }    
        }

        private void Login_Load(object sender, EventArgs e)
        {
            HienThiCV();
        }

       
    }
}
