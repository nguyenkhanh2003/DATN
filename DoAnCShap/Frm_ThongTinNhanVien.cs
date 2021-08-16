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
using System.IO;
using System.Security.Cryptography;

namespace DoAnCShap
{
    public partial class Frm_ThongTinNhanVien : Form
    {
        public Frm_ThongTinNhanVien()
        {
            InitializeComponent();
            string condition = Login.SetValueForText1;
            LoadThongnTin(condition);
        }

        NhanVien_BUS bus = new NhanVien_BUS();
        NhanVien nv = new NhanVien();
        String DuongDanFolderHinh = @"C:\Users\Nguyen Khanh\source\repos\DATN\DoAnCShap\bin\Debug\Image";

        public void LoadThongnTin(string username)
        {
            dataGridViewNhanVien.DataSource = bus.LoadThongTin("select * From NhanVien Where UserName=N'" + username + "' ");
        }

        string MatKhau = "";

        private void dataGridViewNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewNhanVien.SelectedRows)
            {
                txtMaNV.Text = row.Cells[1].Value.ToString();
                txtTenNV.Text = row.Cells[3].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtCMND.Text = row.Cells["CMND"].Value.ToString();
                txtSDT.Text = row.Cells["DienThoai"].Value.ToString();
                string t = row.Cells["GioiTinh"].Value.ToString();
                if (t == "Nam")
                {
                    radioButNam.Checked = true;
                }
                else
                {
                    radioButNu.Checked = true;
                }
                txtUserName.Text = row.Cells["UserName"].Value.ToString();
                string[] b = row.Cells["HinhAnh"].Value.ToString().Split(';');
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
                        p.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Controls.Add(p);
                        Bitmap a = new Bitmap(DuongDanFolderHinh + "\\" + b[i]);
                        p.Image = a;
                        //TenHinh = b[i];
                    }
                }
                catch
                {

                }

                MatKhau = row.Cells["PassWord"].Value.ToString();
                //...
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            nv.MaCV = txtMaNV.Text;

        }
    }
}
