using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Frm_NhanVien : Form
    {
        public Frm_NhanVien()
        {
            InitializeComponent();
            Display();
            hienthichucvu();
            
        }
        MD5 md = MD5.Create();
        NhanVien_BUS bus = new NhanVien_BUS();
        ChucVu_BUS buss = new ChucVu_BUS();
        NhanVien nv = new NhanVien();
        int flag = 0;

        public void xulytextbox(Boolean b1, Boolean b2)
        {
            txtMaNV.Enabled = b1;
            cboChucVu.Enabled = b1;
            txtHinhNhanVien.Enabled = b1;
            txtUserName.Enabled = b1;
            txtPassWord.Enabled = b1;
            txtTenNV.Enabled = b1;
            cboGioiTinh.Enabled = b1;
            txtEmail.Enabled = b1;
            txtSDT.Enabled = b1;
            txtCMND.Enabled = b1;
            txtDiaChi.Enabled = b1;
            cboTrangThai.Enabled = b1;
        }
      
        public void xulychucnang(Boolean b1, Boolean b2, Boolean b3)
        {
            btnThem.Enabled = b1;
            btnXoa.Enabled = b3;
            btnLuu.Enabled = b2;
            btnHuy.Enabled = b2;
        }

        
       
        void Display()
        {
            dataGridViewNhanVien.DataSource = bus.GetData("");
            
        }

        public void hienthichucvu()
        {
            cboChucVu.DataSource = buss.GetChucVu("");
            cboChucVu.DisplayMember = "TenCV";
            cboChucVu.ValueMember = "MaCV";
        }

        public void MaHoa()
        {
            byte[] inputstr = System.Text.Encoding.ASCII.GetBytes(txtPassWord.Text);
            byte[] hask = md.ComputeHash(inputstr);
            StringBuilder sb = new StringBuilder();
            for(int i=0;i<hask.Length;i++)
            {
                sb.Append(hask[i].ToString("X2"));
            }
            txtPassWord.Text = sb.ToString();
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
            xulytextbox(false,true);
            xulychucnang(true, false, false);
            //hienthichucvu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
           
            xulytextbox(true, false);
            xulychucnang(false, true, true);
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
                MaHoa();
                nv.MaNV = txtMaNV.Text;
                // nv.MaCV = cboChucVu.SelectedValue.ToString();
                nv.MaCV = cboChucVu.SelectedValue.ToString();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void dataGridViewNhanVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewNhanVien.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells[0].Value.ToString();
            cboChucVu.Text = row.Cells[1].Value.ToString();
            txtTenNV.Text = row.Cells[2].Value.ToString();
            cboGioiTinh.Text = row.Cells[3].Value.ToString();
            txtEmail.Text = row.Cells[4].Value.ToString();
            txtSDT.Text = row.Cells[5].Value.ToString();
            txtCMND.Text = row.Cells[6].Value.ToString();
            txtDiaChi.Text = row.Cells[7].Value.ToString();
            txtHinhNhanVien.Text = row.Cells[8].Value.ToString();
            txtUserName.Text = row.Cells[9].Value.ToString();
            txtPassWord.Text = row.Cells[10].Value.ToString();
            cboTrangThai.Text = row.Cells[11].Value.ToString();        }
    }
}
