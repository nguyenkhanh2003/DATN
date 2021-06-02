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
    public partial class Frm_NhanVien : Form
    {
        public Frm_NhanVien()
        {
            InitializeComponent();
            Display();
            
        }
        NhanVien_BUS bus = new NhanVien_BUS();
        NhanVien nv = new NhanVien();
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int flag = 0;
        void Display()
        {
            dataGridViewNhanVien.DataSource = bus.GetData("");
        }

      
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();

            o.Filter = "bitmap (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|All Files(*.*)|*.*";

            if (o.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Bạn Chưa Chọn Ảnh");

            }

            else
            {
                foreach (string ten in o.FileNames)
                {
                    string[] tenhinh = ten.Split('\\');
                    txtHinhNhanVien.Text = tenhinh[tenhinh.Length - 1];

                    PictureBox p = new PictureBox();

                    Size s = new Size(200, 250);
                    p.Size = s;

                    pictureBox1.Controls.Add(p);
                    Bitmap a = new Bitmap(ten);
                    p.Image = a;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;

                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      


        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void btnChonAnh_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();

            o.Filter = "bitmap (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|All Files(*.*)|*.*";

            if (o.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Bạn Chưa Chọn Ảnh");

            }

            else
            {
                foreach (string ten in o.FileNames)
                {
                    string[] tenhinh = ten.Split('\\');
                    txtHinhNhanVien.Text = tenhinh[tenhinh.Length - 1];

                    PictureBox p = new PictureBox();

                    Size s = new Size(200, 250);
                    p.Size = s;

                    pictureBox1.Controls.Add(p);
                    Bitmap a = new Bitmap(ten);
                    p.Image = a;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;

                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(flag==1)
            {
                nv.MaNV = txtMaNV.Text;
                // nv.MaCV = cboChucVu.SelectedValue.ToString();
                nv.MaCV = cboChucVu.Text;
                nv.TenNV = txtTenNV.Text;
                nv.GioiTinh = cboGioiTinh.Text;
                nv.Email = txtEmail.Text;
                nv.DienThoai = txtSDT.Text;
                nv.CMND = txtCMND.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.HinhAnh = txtHinhNhanVien.Text;
                nv.UserName = txtUserName.Text;
                nv.PassWord = txtPassWord.Text;
                nv.TrangThai = cboTrangThai.Text;
                bus.AddData(nv); ;
                MessageBox.Show("Thêm Nhân Viên Thành Công");
            }
            Display();
        }
    }
}
