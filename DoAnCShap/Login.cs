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
        public static bool PhanQuyenn;
        public static bool ThongKe;
        public static bool HoaDon;
        public static bool Setting;
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
            string username = txtTenDN.Text;
            string password = txtMatKhau.Text;
           
            int count = bus.GetLogin(username, CreateMd5(password)).Rows.Count;
            if(txtTenDN.Text=="")
            {
                MessageBox.Show("Tên đăng nhập không được để trống ");
                return;
            }
            if(txtMatKhau.Text=="")
            {
                MessageBox.Show("Mật khẩu không được để trống");
                return;
            }    
            if (count==0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
            else
            {
                TenTaiKhoan = bus.GetLogin(username,CreateMd5(password)).Rows[0][10].ToString();
                MessageBox.Show("Đăng Nhập Thành Công");
                SetValueForText1 = username;
                QLNV = PhanQuyen(15);
                QLKH = PhanQuyen(16);
                QLLK = PhanQuyen(17);
                QLBH = PhanQuyen(18);
                QLNCC = PhanQuyen(19);
                QLLLK = PhanQuyen(20);
                QLNK = PhanQuyen(21);
                BaoHanh = PhanQuyen(22);
                PhanQuyenn = PhanQuyen(23);
                ThongKe = PhanQuyen(24);
                HoaDon = PhanQuyen(25);
                Setting = PhanQuyen(26);
                this.Close();
            }    
        }

        private void Login_Load(object sender, EventArgs e)
        {
            HienThiCV();
        }

       
    }
}
