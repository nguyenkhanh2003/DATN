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
            pictureBox1.Controls.Clear();
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "Files|*.jpg;*.jpeg;*.png;....";
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                TenHinh = opFile.FileName;
                pictureBox1.Image = new Bitmap(opFile.FileName);
                pictureBox1.ImageLocation = opFile.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public void LuuAnh()
        {
            try
            {
                File.Copy(TenHinh, Application.StartupPath + @"\Image\" + Path.GetFileName(pictureBox1.ImageLocation));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ảnh đã tồn tại !");
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
            int vitri = dataGridViewNhanVien.CurrentCell.RowIndex;
            HienThiNhanVien_TXT(vitri, bus.ThongTinNhanVien("select MaNV,ChucVu.TenCV,TenNV,GioiTinh,Email,NgaySinh,DienThoai,CMND,DiaChi,HinhAnh,UserName,PassWord,NhanVien.TrangThai From NhanVien,ChucVu where NhanVien.MaCV=ChucVu.MaCV and UserName=N'" +Login.TenTaiKhoan+ "'"));
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboChucVu.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(cboChucVu, "Chưa chọn chức vụ");
                return;
            }
            if (txtTenNV.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtTenNV, "? Tên nhân viên");
                return;
            }
            if (txtSDT.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtSDT, "? SDT");
                return;
            }
            if (txtSDT.Text.Length < 10)
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtSDT, "Số điện thoại không đúng");
                return;
            }
            if (txtCMND.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtCMND, "? CMND");
                return;
            }
            if (txtDiaChi.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtDiaChi, "? Địa chỉ");
                return;
            }

            if (txtUserName.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtUserName, "? UserName");
                return;
            }
            else
            {
                int KiemTra = 0;
                for (int i = 0; i < dataGridViewNhanVien.Rows.Count - 0; i++)
                {
                    if (TenHinh == dataGridViewNhanVien.Rows[i].Cells["HinhAnh"].Value.ToString())
                    {
                        KiemTra = 1;
                        break;
                    }
                }
                nv.MaNV = txtMaNV.Text;
                nv.MaCV = cboChucVu.SelectedValue.ToString();
                nv.TenNV = txtTenNV.Text;
                if (radioButtonNam.Checked == true)
                {
                    nv.GioiTinh = radioButtonNam.Text;
                }
                else
                {
                    nv.GioiTinh = radioButtonNu.Text;
                }
                nv.Email = txtEmail.Text;
                nv.NgaySinh = dateTirmNgaySinh.Value.Date;
                nv.DienThoai = txtSDT.Text;
                nv.CMND = txtCMND.Text;
                nv.DiaChi = txtDiaChi.Text;
                if (KiemTra == 1)
                {
                    nv.HinhAnh = TenHinh;
                }
                else
                {
                    nv.HinhAnh = Path.GetFileName(pictureBox1.ImageLocation);
                    LuuAnh();
                }
                nv.UserName = txtUserName.Text;
                if (txtPassWord.Text == "")
                {
                    nv.PassWord = PassW;
                }
                else
                {
                    MaHoa();
                    nv.PassWord = txtPassWord.Text;
                }
                nv.TrangThai = "1";
                bus.EditData(nv);
                MessageBox.Show("Sửa Nhân Viên Thành Công");
            }
            Frm_ThongTinNhanVien_Load(e,e);
        }
    

        private void dataGridViewNhanVien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //using (SolidBrush b = new SolidBrush(dataGridViewNhanVien.RowHeadersDefaultCellStyle.ForeColor))
            //{
            //    e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            //}
        }
        string PassW = "";
        public void HienThiNhanVien_TXT(int vitri, DataTable d)
        {
            try
            {
                txtMaNV.Text = d.Rows[vitri]["MaNV"].ToString();
                cboChucVu.Text = d.Rows[vitri]["TenCV"].ToString();
                txtTenNV.Text = d.Rows[vitri]["TenNV"].ToString();
                txtEmail.Text = d.Rows[vitri]["Email"].ToString();
                dateTirmNgaySinh.Text = d.Rows[vitri]["NgaySinh"].ToString();
                txtSDT.Text = d.Rows[vitri]["DienThoai"].ToString();
                txtCMND.Text = d.Rows[vitri]["CMND"].ToString();
                txtDiaChi.Text = d.Rows[vitri]["DiaChi"].ToString();
                string[] b = d.Rows[vitri]["HinhAnh"].ToString().Split(';');
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
                        Size s = new Size(197, 158);
                        p.Size = s;
                        p.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Controls.Add(p);
                        Bitmap a = new Bitmap(DuongDanFolderHinh + "\\" + b[i]);
                        p.Image = a;
                        TenHinh = b[i];

                    }
                }
                catch
                {

                }
                txtUserName.Text = d.Rows[vitri]["UserName"].ToString();
                PassW = d.Rows[vitri]["PassWord"].ToString();
                string t = d.Rows[vitri]["GioiTinh"].ToString();
                if (t == "Nam")
                    radioButtonNam.Checked = true;
                else
                    radioButtonNu.Checked = true;
                        
            }
            catch
            {

            }
        }
    }
}
