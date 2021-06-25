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
            txtHinhSP.Enabled = b1;
            txtTinhTrang.Enabled = b1;
            cboTrangThai.Enabled = b1;
            txtMaLinhKien.ReadOnly = b1;
            txtBaoHanh.Enabled = b1;
            txtXuatXu.Enabled = b1;
        }

        public void Clear()
        {
            pictureBox1.Controls.Clear();
            txtMaLinhKien.Clear();
            txtTenLinhKien.Clear();
            cboMaLoai.Text = "";
            comboBoxNCC.Text = "";
            txtDonViTinh.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtHinhSP.Clear();
            txtTinhTrang.Clear();
            cboTrangThai.Text = "";
            txtMaLinhKien.Clear();
            txtBaoHanh.Clear();
            txtXuatXu.Clear();
        }
        public void PhatSinhMa()
        {
            int count = 0;
            count =dataGridViewLK.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtMaLinhKien.Text = "LK00";
            }
            else
            {
                chuoi = Convert.ToString(dataGridViewLK.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                if (chuoi2 + 1 < 10)
                    txtMaLinhKien.Text = "LK0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtMaLinhKien.Text = "LK" + (chuoi2 + 1).ToString();
            }

        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\ImageLK\"; // <---
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
                    txtHinhSP.Text = iName;
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
            //HienThiNSX();
            XuLyTextBox(false, true);
            HienThiNhaCungCap();
            HienThiLoaiLK();
            DisPlay();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(cboMaLoai.SelectedValue.ToString()=="")
            {
                MessageBox.Show("Chưa chọn loại sản phẩm");
                return;
            }

            if (comboBoxNCC.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Chưa chọn nhà cung cấp");
                return;
            }
            if (txtTenLinhKien.Text == "")
            {
                MessageBox.Show("Chưa nhập tên linh kiện");
                return;
            }
            if (txtBaoHanh.Text == "")
            {
                MessageBox.Show("Chưa nhập bảo hành");
                return;
            }
            if (txtXuatXu.Text == "")
            {
                MessageBox.Show("Chưa nhập xuất xứ");
                return;
            }
            if (txtTinhTrang.Text == "")
            {
                MessageBox.Show("CTinfhh trạng không được để trống");
                return;
            }
            if (txtDonViTinh.Text == "")
            {
                MessageBox.Show("Đơn vị tính không được để trống");
                return;
            }
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Đơn giá không được để trống");
                return;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng không được để trống");
                return;
            }
            if (txtHinhSP.Text== "")
            {
                MessageBox.Show("Chưa chọn hình");
                return;
            }
            if (cboTrangThai.Text == "")
            {
                MessageBox.Show("Chưa chọn trạng thái");
                return;
            }

            if (flag==1)
            {
                lk.MaLK = txtMaLinhKien.Text;
                lk.MaLLK = cboMaLoai.SelectedValue.ToString();
                lk.MaNCC = comboBoxNCC.SelectedValue.ToString();
                lk.TenLK = txtTenLinhKien.Text;
                lk.BaoHanh = txtBaoHanh.Text;
                lk.XuatXu = txtXuatXu.Text;
                lk.TinhTrang = txtTinhTrang.Text;
                lk.DonViTinh = txtDonViTinh.Text;
                lk.DonGia = int.Parse(txtDonGia.Text);
                lk.SoLuong = int.Parse(txtSoLuong.Text);
                lk.HinhAnh = txtHinhSP.Text;
                lk.TrangThai = cboTrangThai.Text;
                bus.AddData(lk);
                MessageBox.Show("Thành Công");
                xulychucnang(true, false, false);
                XuLyTextBox(false, true);
                Clear();
            }
            if(flag==2)
            {
                lk.MaLK = txtMaLinhKien.Text;
                lk.MaLLK = cboMaLoai.SelectedValue.ToString();
                lk.MaNCC = comboBoxNCC.SelectedValue.ToString();
                lk.TenLK = txtTenLinhKien.Text;
                lk.BaoHanh = txtBaoHanh.Text;
                lk.XuatXu = txtXuatXu.Text;
                lk.TinhTrang = txtTinhTrang.Text;
                lk.DonViTinh = txtDonViTinh.Text;
                lk.DonGia =int.Parse(txtDonGia.Text);
                lk.SoLuong =int.Parse(txtSoLuong.Text);
                lk.HinhAnh = txtHinhSP.Text;
                lk.TrangThai = cboTrangThai.Text;
                bus.EditData(lk);
                MessageBox.Show("Thành Công");
                xulychucnang(true, false, false);
                XuLyTextBox(false, true);
                Clear();
            }    
            DisPlay();
        }

        private void dataGridViewLK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dataGridViewLK.Rows[e.RowIndex];
                txtMaLinhKien.Text = row.Cells[0].Value.ToString();
                cboMaLoai.Text = row.Cells[1].Value.ToString();
                comboBoxNCC.Text = row.Cells[2].Value.ToString();
                txtTenLinhKien.Text = row.Cells[3].Value.ToString();
                txtBaoHanh.Text = row.Cells[4].Value.ToString();
                txtXuatXu.Text = row.Cells[5].Value.ToString();
                txtTinhTrang.Text = row.Cells[6].Value.ToString();
                txtDonViTinh.Text = row.Cells[7].Value.ToString();
                txtDonGia.Text = row.Cells[8].Value.ToString();
                txtSoLuong.Text = row.Cells[9].Value.ToString();
                txtHinhSP.Text = row.Cells[10].Value.ToString();
                string[] b = row.Cells[10].Value.ToString().Split(';');
                pictureBox1.Controls.Clear();
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
                cboTrangThai.Text = row.Cells[11].Value.ToString();
            }
           else
            {
               
            }    
            
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
    }
}
