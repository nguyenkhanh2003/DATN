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
        LoaiLinhKien_BUS llk = new LoaiLinhKien_BUS();
        int flag = 0;

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
            comboBoxNSX.DataSource = nsx.GetData("");
            comboBoxNSX.DisplayMember = "TenNSX";
            comboBoxNSX.ValueMember = "MaNSX";
        }
        public void HienThiLoaiLK()
        {
            cboMaLoai.DataSource = llk.GetData("");
            cboMaLoai.DisplayMember = "TenLK";
            cboMaLoai.ValueMember = "MaLLK";
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
                    txtHinhSP.Text = tenhinh[tenhinh.Length - 1];

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulychucnang(false, true, true);
            PhatSinhMa();
            flag = 1;
        }

        private void Frm_SanPham_Load(object sender, EventArgs e)
        {
            xulychucnang(true, false, false);
            HienThiNSX();
            HienThiLoaiLK();
            DisPlay();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(flag==1)
            {
                lk.MaLK = txtMaLinhKien.Text;
                lk.MaLLK = cboMaLoai.SelectedValue.ToString();
                lk.MaNSX = comboBoxNSX.SelectedValue.ToString();
                lk.TenLK = txtTenLinhKien.Text;
                lk.BaoHanh = txtBaoHanh.Text;
                lk.NgaySanXuat = dateNSX.Value;
                lk.TinhTrang = txtTinhTrang.Text;
                lk.DonViTinh = txtDonViTinh.Text;
                lk.DonGia = txtDonGia.Text;
                lk.SoLuong = txtSoLuong.Text;
                lk.HinhAnh = txtHinhSP.Text;
                lk.TrangThai = cboTrangThai.Text;
                bus.AddData(lk);
                MessageBox.Show("Thành Công");
                xulychucnang(true, false, false);
                
            }
            DisPlay();
        }

        private void dataGridViewLK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaLinhKien.Enabled = false;
                if (e.RowIndex == -1) return;
                DataGridViewRow row = dataGridViewLK.Rows[e.RowIndex];
                txtMaLinhKien.Text = row.Cells[0].Value.ToString();
                cboMaLoai.Text = row.Cells[1].Value.ToString();
                comboBoxNSX.Text = row.Cells[2].Value.ToString();
                txtTenLinhKien.Text = row.Cells[3].Value.ToString();
                txtBaoHanh.Text = row.Cells[4].Value.ToString();
                dateNSX.Text = row.Cells[5].Value.ToString();
                txtTinhTrang.Text = row.Cells[6].Value.ToString();
                txtDonViTinh.Text = row.Cells[7].Value.ToString();
                txtDonGia.Text = row.Cells[8].Value.ToString();
                txtSoLuong.Text = row.Cells[9].Value.ToString();
                txtHinhSP.Text = row.Cells[10].Value.ToString();
                cboTrangThai.Text = row.Cells[11].Value.ToString();
            }
            catch
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
                DisPlay();
            }
            catch
            {

            }
        }

        private void dataGridViewLK_DoubleClick(object sender, EventArgs e)
        {
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
    }
}
