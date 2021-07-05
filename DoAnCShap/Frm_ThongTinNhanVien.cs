﻿using System;
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
using System.IO;
using System.Security.Cryptography;

namespace DoAnCShap
{
    public partial class Frm_ThongTinNhanVien : Form
    {
        public Frm_ThongTinNhanVien()
        {
            InitializeComponent();
        }

        NhanVien_BUS bus = new NhanVien_BUS();
        ChucVu_BUS buss = new ChucVu_BUS();
        NhanVien nv = new NhanVien();

        String DuongDanFolderHinh = @"C:\Users\Nguyen Khanh\source\repos\DATN\DoAnCShap\bin\Debug\Image";
        public void HienThiNhanVien(string condition)
        {
            dataGridViewNhanVien.DataSource = bus.ThongTinNhanVien("select MaNV,ChucVu.TenCV,TenNV,GioiTinh,Email,NgaySinh,DienThoai,CMND,DiaChi,HinhAnh,UserName,PassWord,NhanVien.TrangThai From NhanVien,ChucVu where NhanVien.MaCV=ChucVu.MaCV and UserName=N'" + condition+"' ");
        }

        public void XuLyTexBox()
        {
            txtMaNV.Enabled = false;
            cboChucVu.Enabled = false;
            cboChucVu.Controls.Clear();
        }

        public void hienthichucvu()
        {
            cboChucVu.DataSource = buss.GetChucVu("");
            cboChucVu.DisplayMember = "TenCV";
            cboChucVu.ValueMember = "MaCV";
        }

        private void Frm_ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            string condition = Login.TenTaiKhoan;
            HienThiNhanVien(condition);
            hienthichucvu();
            XuLyTexBox();
        }


        String TenHinh = "";
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Image\"; // <---
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }                                                                                    // <---

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string iName = opFile.SafeFileName;   // <---
                    string filepath = opFile.FileName;    // <---
                    File.Copy(filepath, appPath + iName); // <---
                    pictureBox1.Image = new Bitmap(opFile.OpenFile());
                    TenHinh = iName;
                }
                catch (Exception exp)
                {
                    //MessageBox.Show("Ảnh đã tồn tại !" + exp.Message);
                    MessageBox.Show("Ảnh đã tồn tại !");
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        MD5 md = MD5.Create();
        public void MaHoa()
        {
            byte[] inputstr = System.Text.Encoding.ASCII.GetBytes(txtPassWord.Text);
            byte[] hask = md.ComputeHash(inputstr);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hask.Length; i++)
            {
                sb.Append(hask[i].ToString("X2"));
            }
            txtPassWord.Text = sb.ToString();

        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewNhanVien.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells[0].Value.ToString();
            cboChucVu.Text = row.Cells[1].Value.ToString();
            txtTenNV.Text = row.Cells[2].Value.ToString();
            /*cboGioiTinh.Text = row.Cells[3].Value.ToString()*/
            ;
            txtEmail.Text = row.Cells[4].Value.ToString();
            dateTirmNgaySinh.Text = row.Cells[5].Value.ToString();
            txtSDT.Text = row.Cells[6].Value.ToString();
            txtCMND.Text = row.Cells[7].Value.ToString();
            txtDiaChi.Text = row.Cells[8].Value.ToString();
            string[] b = row.Cells[9].Value.ToString().Split(';');
            pictureBox1.Controls.Clear();
            try
            {
                int n;
                if (b.Length == 1)
                    n = b.Length;
                else
                    n = b.Length - 1;
                for (int i = 0; i < n; i++)
                {
                    PictureBox p = new PictureBox();
                    Size s = new Size(180, 180);
                    p.Size = s;
                    pictureBox1.Controls.Add(p);
                    Bitmap a = new Bitmap(DuongDanFolderHinh + "\\" + b[i]);
                    p.Image = a;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch
            {
                //MessageBox.Show("Không có hình");
                //return;
            }
            //txtHinhNhanVien.Text = row.Cells[9].Value.ToString();
            txtUserName.Text = row.Cells[10].Value.ToString();
            //txtPassWord.Text = row.Cells[11].Value.ToString();
            cboTrangThai.Text = row.Cells[12].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MaHoa();
            nv.MaNV = txtMaNV.Text;
            nv.MaCV = cboChucVu.SelectedValue.ToString();
            nv.TenNV = txtTenNV.Text;
            nv.Email = txtEmail.Text;
            nv.NgaySinh = dateTirmNgaySinh.Value.Date;
            nv.DienThoai = txtSDT.Text;
            nv.CMND = txtCMND.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.HinhAnh = TenHinh;
            nv.UserName = txtUserName.Text;
            nv.PassWord = txtPassWord.Text;
            nv.TrangThai = cboTrangThai.Text;
            bus.EditData(nv);
            MessageBox.Show("Thành Công");
        }
    }
}