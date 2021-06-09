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
using System.Diagnostics;

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
        String TenHinh = "";
        String DuongDan = "";
        String DuongDanFolderHinh = @"C:\Users\Nguyen Khanh\source\repos\DATN\DoAnCShap\Image";
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


        public void PhatSinhMa()
        {
            int count = 0;
            count = dataGridViewNhanVien.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if(count<=1)
            {
                txtMaNV.Text="1";
            }
            else
            {
                chuoi = Convert.ToString(dataGridViewNhanVien.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                if (chuoi2 + 1 < 10)
                    txtMaNV.Text = 1 + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtMaNV.Text = 1 + (chuoi2 + 1).ToString();
            }
        }
        void Display()
        {
            dataGridViewNhanVien.DataSource = bus.GetData("");
            
        }

        public void HienThiSearch(string Condition)
        {
            dataGridViewNhanVien.DataSource = bus.GetTimKiem("Select * From NhanVien Where TenNV Like N'%" + Condition + "%'");
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
            PhatSinhMa();
        }

        private void btnChonAnh_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                if (txtMaNV.Text !="" && cboChucVu.SelectedValue != "" && txtTenNV.Text != "" &&
                   txtEmail.Text != "" && txtSDT.Text != "" && txtCMND.Text != "" && txtDiaChi.Text != "" && txtUserName.Text != "" && txtPassWord.Text != "")
                {
                    MaHoa();
                    nv.MaNV = txtMaNV.Text;
                    // nv.MaCV = cboChucVu.SelectedValue.ToString();
                    nv.MaCV = cboChucVu.ToString();
                    nv.TenNV = txtTenNV.Text;
                    nv.GioiTinh = cboGioiTinh.Text;
                    nv.Email = txtEmail.Text;
                    nv.NgaySinh = dateTirmNgaySinh.Text;
                    nv.DienThoai = txtSDT.Text;
                    nv.CMND = txtCMND.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.HinhAnh = TenHinh;
                    nv.UserName = txtUserName.Text;
                    nv.PassWord = txtPassWord.Text;
                    nv.TrangThai = cboTrangThai.Text;
                    bus.AddData(nv);
                    MessageBox.Show("Thêm Nhân Viên Thành Công");
                    xulychucnang(true, false, false);
                }
                else
                {
                    MessageBox.Show("Chưa Nhập Đủ Thông Tin Cần Thiết");
                }    
            }
            if(flag==2)
            {
                MaHoa();
                nv.MaNV = txtMaNV.Text;
                // nv.MaCV = cboChucVu.SelectedValue.ToString();
                nv.MaCV = cboChucVu.SelectedValue.ToString();
                nv.TenNV = txtTenNV.Text;
                nv.GioiTinh = cboGioiTinh.Text;
                nv.Email = txtEmail.Text;
                nv.NgaySinh = dateTirmNgaySinh.Text;
                nv.DienThoai = txtSDT.Text;
                nv.CMND = txtCMND.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.HinhAnh = txtHinhNhanVien.Text;
                nv.UserName = txtUserName.Text;
                nv.PassWord = txtPassWord.Text;
                nv.TrangThai = cboTrangThai.Text;
                bus.EditData(nv);
                MessageBox.Show("Sửa Nhân Viên Thành Công");
                xulychucnang(true, false, false);
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
            dateTirmNgaySinh.Text = row.Cells[5].Value.ToString();
            txtSDT.Text = row.Cells[6].Value.ToString();
            txtCMND.Text = row.Cells[7].Value.ToString();
            txtDiaChi.Text = row.Cells[8].Value.ToString();
            string[] b = row.Cells[9].Value.ToString().Split(';');
            pictureBox1.Controls.Clear();
            int n;
            if (b.Length == 1)
                n = b.Length;
            else
                n = b.Length - 1;
            for (int i = 0; i < n; i++)
            {
                PictureBox p = new PictureBox();
                Size s = new Size(150, 150);
                p.Size = s;
                pictureBox1.Controls.Add(p);
                Bitmap a = new Bitmap(DuongDanFolderHinh + "\\" + b[i]);
                p.Image = a;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            //txtHinhNhanVien.Text = row.Cells[9].Value.ToString();
            txtUserName.Text = row.Cells[10].Value.ToString();
            txtPassWord.Text = row.Cells[11].Value.ToString();
            cboTrangThai.Text = row.Cells[12].Value.ToString();        }

        private void btnChonAnh_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "bitmap (*.jpg)|*.jpg|(*.jpeg)|*.jepg|(*.png)|*.png";
            if (o.ShowDialog() == DialogResult.Cancel)
            {
                do
                {
                    MessageBox.Show("Bạn phải chọn ảnh");
                    o.ShowDialog();
                } while (o.ShowDialog() == DialogResult.Cancel);
            }
            else
            {
                foreach (string ten in o.FileNames)
                {
                    string[] b;
                    b = o.FileName.Split('\\');
                    PictureBox p = new PictureBox();
                    Size s = new Size(50, 50);
                    p.Size = s;
                    pictureBox1.Controls.Add(p);
                    Bitmap a = new Bitmap(ten);
                    p.Image = a;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    String x = "";
                    for (int i = 0; i < b.Length - 1; i++)
                    {
                        x += b[i] + "\\";
                    }
                    DuongDan = x.ToString();
                    TenHinh += b[b.Length - 1] + ";";
                }
            }
        }

        private void dataGridViewNhanVien_DoubleClick(object sender, EventArgs e)
        {
            xulychucnang(false, true, true);
            xulytextbox(true,false);
            flag = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nv.MaNV = txtMaNV.Text;
            bus.DeleteData(nv);
            MessageBox.Show("Xóa Nhân Viên Thành Công");
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string Condition = txtSearch.Text;
            HienThiSearch(Condition);
        }
    }
}
