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

namespace DoAnCShap
{
    public partial class Frm_SanPham : Form
    {
        public Frm_SanPham()
        {
            InitializeComponent();
        }

        LinhKien_BUS bus = new LinhKien_BUS();
        LinhKien lk = new LinhKien();
        NhaSanXuat_BUS nsx = new NhaSanXuat_BUS();
        NhaCungCap_BUS ncc = new NhaCungCap_BUS();
        LoaiLinhKien_BUS llk = new LoaiLinhKien_BUS();
        int flag = 0;
        string TenHinh = "";
        public String DuongDanFolderHinh= @"C:\Users\Nguyen Khanh\source\repos\DATN\DoAnCShap\bin\Debug\ImageLK";
        public void DisPlay()
        {
            dataGridViewLK.DataSource = bus.GetData("");
        }

        public void HienThiTimKiem(string condition)
        {
            dataGridViewLK.DataSource = bus.GetSearch("select * from LinhKien Where TenLK Like N'%"+condition+"%'");
        }
        public void HienThiNSX()
        {
            comboBoxNCC.DataSource = nsx.GetData("");
            comboBoxNCC.DisplayMember = "TenNSX";
            comboBoxNCC.ValueMember = "MaNSX";
        }

        public void HienThiNhaCungCap()
        {
            comboBoxNCC.DataSource = ncc.GetData("");
            comboBoxNCC.DisplayMember = "TenNCC";
            comboBoxNCC.ValueMember = "MaNCC";
        }
        public void HienThiLoaiLK()
        {
            cboMaLoai.DataSource = llk.GetData("");
            cboMaLoai.DisplayMember = "TenLLK";
            cboMaLoai.ValueMember = "MaLLK";
        }
        public void xulychucnang(Boolean b1, Boolean b2, Boolean b3)
        {
            btnThem.Enabled = b1;
            btnXoa.Enabled = b3;
            btnLuu.Enabled = b2;
            btnHuy.Enabled = b2;
        }

        public void XuLyTextBox(Boolean b1,Boolean b2)
        {
            txtMaLinhKien.Enabled = b1;
            txtTenLinhKien.Enabled = b1;
            cboMaLoai.Enabled = b1;
            comboBoxNCC.Enabled = b1;
            txtDonViTinh.Enabled = b1;
            txtSoLuong.Enabled = b1;
            txtDonGia.Enabled = b1;
            txtKhuyenMai.Enabled = b1;
            txtTinhTrang.Enabled = b1;
            cboTrangThai.Enabled = b1;
            txtMaLinhKien.ReadOnly = b1;
            comboBoxBaoHanh.Enabled = b1;
            txtXuatXu.Enabled = b1;
        }

        public void Clear()
        {
            pictureBox1.Controls.Clear();
            txtMaLinhKien.Clear();
            txtTenLinhKien.Clear();
            cboMaLoai.ResetText();
            comboBoxNCC.ResetText();
            txtDonViTinh.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtKhuyenMai.Clear();
            txtTinhTrang.Clear();
            cboTrangThai.ResetText();
            txtMaLinhKien.Clear();
            //comboBoxBaoHanh.Controls.Clear();
            txtXuatXu.Clear();
            errorMes.Clear();
        }
        public void PhatSinhMa()
        {
            int count = 0;
            count =dataGridViewLK.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 0)
            {
                txtMaLinhKien.Text = "LK00";
            }
            else
            {
                chuoi = Convert.ToString(dataGridViewLK.Rows[count - 1].Cells[1].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                if (chuoi2 + 1 < 10)
                    txtMaLinhKien.Text = "LK0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtMaLinhKien.Text = "LK" + (chuoi2 + 1).ToString();
            }

        }

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
                File.Copy(TenHinh, Application.StartupPath + @"\ImageLK\" + Path.GetFileName(pictureBox1.ImageLocation));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ảnh đã tồn tại !");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulychucnang(false, true, true);
            XuLyTextBox(true, false);
            Clear();
            PhatSinhMa();
            flag = 1;
        }

        private void Frm_SanPham_Load(object sender, EventArgs e)
        {
            xulychucnang(true, false, false);
            XuLyTextBox(false, true);
            HienThiNhaCungCap();
            HienThiLoaiLK();
            DisPlay();
            Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           

            if (flag==1)
            {
                try
                {
                    if (cboMaLoai.Text=="")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(cboMaLoai, "? Chưa chọn mã loại");
                        return;
                    }

                    if (comboBoxNCC.Text== "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(comboBoxNCC, "Chưa chọn nhà cung cấp");
                        return;
                    }
                    if (txtTenLinhKien.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtTenLinhKien, "Tên linh kiện không được để trống");
                        return;
                    }
                    if (comboBoxBaoHanh.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(comboBoxBaoHanh, "Chưa chọn bảo hành");
                        return;
                    }
                    if (txtXuatXu.Text == "")
                    {
                        errorMes.BlinkRate = 10; ;
                        errorMes.SetError(txtXuatXu, "? Xuất Xứ");
                        return;
                    }
                    if (txtTinhTrang.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtTinhTrang, "? Tình Trạng");
                        return;
                    }
                    if (txtDonViTinh.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtDonViTinh, "? Đơn Vị tính");
                        return;
                    }
                    if (txtDonGia.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtDonGia, "? Đơn Giá");
                        return;
                    }
                    if (txtSoLuong.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtSoLuong, "? Số Lượng");
                        return;
                    }

                    if (cboTrangThai.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(cboTrangThai, "? Chưa chọn trạng thái");
                        return;
                    }
                    else
                    {
                        lk.MaLK = txtMaLinhKien.Text;
                        lk.MaLLK = cboMaLoai.SelectedValue.ToString();
                        lk.MaNCC = comboBoxNCC.SelectedValue.ToString();
                        lk.TenLK = txtTenLinhKien.Text;
                        lk.BaoHanh = comboBoxBaoHanh.Text;
                        lk.XuatXu = txtXuatXu.Text;
                        lk.TinhTrang = txtTinhTrang.Text;
                        lk.DonViTinh = txtDonViTinh.Text;
                        lk.DonGia = int.Parse(txtDonGia.Text);
                        lk.SoLuong = int.Parse(txtSoLuong.Text);
                        if(txtKhuyenMai.Text=="")
                        {
                            lk.KhuyenMai = 0;
                        }
                        else
                        {
                            lk.KhuyenMai = int.Parse(txtKhuyenMai.Text);
                        }    
                        lk.HinhAnh = Path.GetFileName(pictureBox1.ImageLocation);
                        LuuAnh();
                        lk.TrangThai = cboTrangThai.Text;
                        bus.AddData(lk);
                        MessageBox.Show("Thành Công");
                        xulychucnang(true, false, false);
                        XuLyTextBox(false, true);
                        Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể thêm được");
                }
               
            }
            if(flag==2)
            {
                if (cboMaLoai.SelectedValue.ToString() == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(cboMaLoai, "? Chưa chọn mã loại");
                    return;
                }

                if (comboBoxNCC.SelectedValue.ToString() == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(comboBoxNCC, "Chưa chọn nhà cung cấp");
                    return;
                }
                if (txtTenLinhKien.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtTenLinhKien, "Tên linh kiện không được để trống");
                    return;
                }
                if(comboBoxBaoHanh.Text=="")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(comboBoxBaoHanh, "Chưa chọn bảo hành");
                    return;
                }
                if(txtXuatXu.Text=="")
                {
                    errorMes.BlinkRate = 10; ;
                    errorMes.SetError(txtXuatXu, "? Xuất Xứ");
                    return;
                }    
                if (txtTinhTrang.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtTinhTrang, "? Tình Trạng");
                    return;
                }
                if (txtDonViTinh.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtDonViTinh, "? Đơn Vị tính");
                    return;
                }
                if (txtDonGia.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtDonGia, "? Đơn Giá");
                    return;
                }
                if (txtSoLuong.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtSoLuong, "? Số Lượng");
                    return;
                }

                if (cboTrangThai.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(cboTrangThai, "? Chưa chọn trạng thái");
                    return;
                }
                else
                {
                    int KiemTra = 0;
                    for (int i = 0; i < dataGridViewLK.Rows.Count - 0; i++)
                    {
                        if (TenHinh == dataGridViewLK.Rows[i].Cells["HinhAnh"].Value.ToString())
                        {
                            KiemTra = 1;
                            break;
                        }
                    }
                    lk.MaLK = txtMaLinhKien.Text;
                    lk.MaLLK = cboMaLoai.SelectedValue.ToString();
                    lk.MaNCC = comboBoxNCC.SelectedValue.ToString();
                    lk.TenLK = txtTenLinhKien.Text;
                    lk.BaoHanh = comboBoxBaoHanh.Text;
                    lk.XuatXu = txtXuatXu.Text;
                    lk.TinhTrang = txtTinhTrang.Text;
                    lk.DonViTinh = txtDonViTinh.Text;
                    lk.DonGia = int.Parse(txtDonGia.Text);
                    lk.SoLuong = int.Parse(txtSoLuong.Text);
                    lk.KhuyenMai = int.Parse(txtKhuyenMai.Text);
                    if(KiemTra==1)
                    {
                        lk.HinhAnh = TenHinh;
                    }
                    else
                    {
                        lk.HinhAnh = Path.GetFileName(pictureBox1.ImageLocation);
                        LuuAnh();
                    }    
                    lk.TrangThai = cboTrangThai.Text;
                    bus.EditData(lk);
                    MessageBox.Show("Thành Công");
                    xulychucnang(true, false, false);
                    XuLyTextBox(false, true);
                    Clear();
                }
            }    
            DisPlay();
        }
        public void HienThiLK_TXT(int vitri, DataTable d)
        {
            try
            {
                txtMaLinhKien.Text = d.Rows[vitri]["MaLK"].ToString();
                cboMaLoai.Text = d.Rows[vitri]["TenLLK"].ToString();
                comboBoxNCC.Text = d.Rows[vitri]["TenNCC"].ToString();
                txtTenLinhKien.Text = d.Rows[vitri]["TenLK"].ToString();
                comboBoxBaoHanh.Text = d.Rows[vitri]["BaoHanh"].ToString();
                txtXuatXu.Text = d.Rows[vitri]["XuatXu"].ToString();
                txtTinhTrang.Text = d.Rows[vitri]["TinhTrang"].ToString();
                txtDonViTinh.Text = d.Rows[vitri]["DonViTinh"].ToString();
                txtDonGia.Text = d.Rows[vitri]["DonGia"].ToString();
                txtSoLuong.Text = d.Rows[vitri]["SoLuong"].ToString();
                txtKhuyenMai.Text = d.Rows[vitri]["KhuyenMai"].ToString();
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
                        Size s = new Size(197,158);
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
                cboTrangThai.Text = d.Rows[vitri]["TrangThai"].ToString();
            }
            catch
            {

            }
        }

        private void dataGridViewLK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dataGridViewLK.CurrentCell.RowIndex;
            HienThiLK_TXT(vitri, bus.GetData(""));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                lk.MaLK = txtMaLinhKien.Text;
                bus.DeleteData(lk);
                MessageBox.Show("Xóa Linh Kiện Thành Công");
                xulychucnang(true, false, false);
                XuLyTextBox(false, true);
                Clear();
                DisPlay();
            }
            catch
            {

            }
        }

        private void dataGridViewLK_DoubleClick(object sender, EventArgs e)
        {
            flag = 2;
            xulychucnang(false, true, true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string condition = txtSearch.Text;
            HienThiTimKiem(condition);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn hủy hay không ?", "Thông Báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (KQ == DialogResult.Yes)
            {
                xulychucnang(true, false, false);
                XuLyTextBox(false, true);
                Clear();
            }
            else
            {
                MessageBox.Show("Dừng hủy !");
            }
        }

        private void dataGridViewLK_DoubleClick_1(object sender, EventArgs e)
        {
            xulychucnang(false, true, true);
            XuLyTextBox(true,false);
            flag = 2;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void dataGridViewLK_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridViewLK.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
