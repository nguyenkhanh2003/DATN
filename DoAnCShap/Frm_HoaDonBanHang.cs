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
    public partial class Frm_HoaDonBanHang : Form
    {
        public Frm_HoaDonBanHang()
        {
            InitializeComponent();
            HienThiHoaDon();
        }
        HoaDon_BUS bus = new HoaDon_BUS();
        HoaDonBanHang hdbh = new HoaDonBanHang();
        CT_HoaDonBanHang cthd = new CT_HoaDonBanHang();
        public void HienThiHoaDon()
        {
            dataGridViewHD.DataSource = bus.GetHoaDon("");
        }
        //public void HienThiCTHD()
        //{
        //    dataGridViewCTHD.DataSource = bus.GetCtHoaDon("select CT_HoaDonBanHang.MaHDBH,LinhKien.TenLK,CT_HoaDonBanHang.SoLuong,CT_HoaDonBanHang.DonGia,KhuyenMai,ThanhTien from CT_HoaDonBanHang ,LinhKien Where LinhKien.MaLK=CT_HoaDonBanHang.MaLK and CT_HoaDonBanHang.MaHDBH");
        //}

        public void HienThiCTHD_TheoMa()
        {
            dataGridViewCTHD.DataSource = bus.GetCtHoaDon("select CT_HoaDonBanHang.MaHDBH,LinhKien.TenLK,CT_HoaDonBanHang.SoLuong,CT_HoaDonBanHang.DonGia,KhuyenMai,ThanhTien from CT_HoaDonBanHang ,LinhKien Where LinhKien.MaLK=CT_HoaDonBanHang.MaLK and CT_HoaDonBanHang.MaHDBH=N'" + comboBoxMaHD.Text + "'");
        }
        public void HienThiNhanVien()
        {
            comboBoxNhanVien.DataSource = bus.GetNhanVien("");
            comboBoxNhanVien.DisplayMember = "TenNV";
            comboBoxNhanVien.ValueMember = "MaNV";
        }

        public void HienThiKhachHang()
        {
            comboBoxKH.DataSource = bus.GetKhachHang("");
            comboBoxKH.DisplayMember = "TenKH";
            comboBoxKH.ValueMember = "MaKH";
        }

        public void HienThiLinhKien()
        {
            comboBoxLK.DataSource = bus.GetLinhKien("");
            comboBoxLK.DisplayMember = "TenLK";
            comboBoxLK.ValueMember = "MaLK";
        }

        public void HienThiTimKiemHD(string condition)
        {
            dataGridViewHD.DataSource = bus.GetSearch("Select * From HoaDonBanHang Where MaHDBH Like N'%" + condition + "%'");
        }
        public void XulyTextBoxCTHD(Boolean b1, Boolean b2)
        {
           
            labelTongThanhToan.Enabled = b2;
            comboBoxLK.Enabled = b2;
            txtSL.Enabled = b2;
            txtDonGia.Enabled = b2;
            txtKhuyenMai.Enabled = b2;
            //CboTrangThai.Enabled = b2;
        }
        public void XuLyTextBoxHD(Boolean b1,Boolean b2)
        {
            comboBoxMaHD.Enabled = b2;
            comboBoxKH.Enabled = b2;
            comboBoxNhanVien.Enabled = b2;
            dateTimePickerNgaylap.Enabled = b2;
            comboBoxTrangThai.Enabled = b2;
        }

        public void ClearTextBoxHD()
        {
            comboBoxMaHD.Controls.Clear();
            comboBoxLK.Controls.Clear();
            comboBoxKH.Controls.Clear();
            comboBoxNhanVien.Controls.Clear();
            labelTongThanhToan.Controls.Clear();
            dateTimePickerNgaylap.Controls.Clear();

        }
        public void ClearTextBoxCTHD()
        {
            txtKhuyenMai.Clear();
            labelThanhTien.Controls.Clear();
            txtSL.Clear();
            txtDonGia.Clear();
            txtKhuyenMai.Clear();
        }

        public void XuLyChucNang(Boolean b1,Boolean b2)
        {
            //btnLuu.Enabled = b2;
            //btnIn.Enabled = b2;
            //btnXoa.Enabled = b2;
            //btnCapNhat.Enabled = b2;

        }

        public void HienThiDS_CTHD(int vitri)
        {
            DataTable dt = new DataTable();
            string t = dt.Rows[vitri]["MaHDBH"].ToString();
            dataGridViewCTHD.DataSource = bus.GetCtHoaDon("select CT_HoaDonBanHang.MaHDBH,LinhKien.TenLK,CT_HoaDonBanHang.SoLuong,CT_HoaDonBanHang.DonGia,KhuyenMai,ThanhTien from CT_HoaDonBanHang ,LinhKien Where LinhKien.MaLK=CT_HoaDonBanHang.MaLK and CT_HoaDonBanHang.MaHDBH=N'" + t + "'");
        }
        int flag = 0;
        public void HienThiHoaDonTextBox(int vitri,DataTable d)
        {
            try
            {
                comboBoxMaHD.Text = d.Rows[vitri]["MaHDBH"].ToString();
                comboBoxKH.Text = d.Rows[vitri]["TenKH"].ToString();
                comboBoxNhanVien.Text = d.Rows[vitri]["TenNV"].ToString();
                dateTimePickerNgaylap.Text = d.Rows[vitri]["NgayLapHDBH"].ToString();
                labelTongThanhToan.Text = d.Rows[vitri]["TongTien"].ToString();
                comboBoxTrangThai.Text = d.Rows[vitri]["TrangThai"].ToString();
                //HienThiDS_CTHD(vitri);
                dataGridViewCTHD.DataSource = bus.GetCtHoaDon("select LinhKien.TenLK,CT_HoaDonBanHang.SoLuong,CT_HoaDonBanHang.DonGia,CT_HoaDonBanHang.KhuyenMai,ThanhTien from CT_HoaDonBanHang ,LinhKien Where LinhKien.MaLK=CT_HoaDonBanHang.MaLK and CT_HoaDonBanHang.MaHDBH=N'"+comboBoxMaHD.Text+"'");
            }
            catch
            {

            }
        }

        public void HienThiCTHoaDonTextBox(int vitri , DataTable d)
        {
            try
            {
                comboBoxLK.Text = d.Rows[vitri]["TenLK"].ToString();
                txtSL.Text = d.Rows[vitri]["SoLuong"].ToString();
                txtDonGia.Text = d.Rows[vitri]["DonGia"].ToString();
                txtKhuyenMai.Text = d.Rows[vitri]["KhuyenMai"].ToString();
                labelThanhTien.Text = d.Rows[vitri]["ThanhTien"].ToString();
                //CboTrangThai.Text = d.Rows[vitri]["TrangThai"].ToString();
            }
            catch
            {

            }
        }    

       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_HoaDonBanHang_Load(object sender, EventArgs e)
        {
            HienThiHoaDon();
            HienThiLinhKien();
            HienThiNhanVien();
            HienThiKhachHang();
            XuLyTextBoxHD(true, false);
            comboBoxLK.Text = null;
            XuLyChucNang(true, false);
        }

        private void dataGridViewHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                flag = 1;
                int vitri = dataGridViewHD.CurrentCell.RowIndex;
                HienThiHoaDonTextBox(vitri,bus.GetHoaDon(""));
        }

        private void dataGridViewCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int vitri = dataGridViewCTHD.CurrentCell.RowIndex;
            //HienThiCTHoaDonTextBox(vitri,bus.GetCtHoaDon("select CT_HoaDonBanHang.MaHDBH,LinhKien.TenLK,CT_HoaDonBanHang.SoLuong,CT_HoaDonBanHang.DonGia,KhuyenMai,ThanhTien from CT_HoaDonBanHang ,LinhKien Where LinhKien.MaLK=CT_HoaDonBanHang.MaLK"));
            try
            {
                DataGridViewRow row = dataGridViewCTHD.Rows[e.RowIndex];
                comboBoxLK.Text = row.Cells[2].Value.ToString();
                txtSL.Text = row.Cells[3].Value.ToString();
                txtDonGia.Text = row.Cells[4].Value.ToString();
                txtKhuyenMai.Text = row.Cells[5].Value.ToString();
                labelThanhTien.Text = row.Cells[6].Value.ToString();
                //CboTrangThai.Text = row.Cells[7].Value.ToString();
            }
            catch
            {

            }
        }

        private void dataGridViewHD_DoubleClick(object sender, EventArgs e)
        {
            //flag = 1;
            //XulyTextBox(false, true);
            //XuLyChucNang(false, true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
                hdbh.MaHDBH = comboBoxMaHD.Text;
                hdbh.MaKH = comboBoxKH.SelectedValue.ToString();
                hdbh.MaNV = comboBoxNhanVien.SelectedValue.ToString();
                hdbh.NgayLapHDBH = dateTimePickerNgaylap.Value.Date;
                hdbh.TongTien =int.Parse(labelTongThanhToan.Text);
                hdbh.TrangThai = comboBoxTrangThai.Text;
                bus.UpdateHoaDon(hdbh);
                MessageBox.Show("Lưu Hóa Đơn Thành Công !");
                ClearTextBoxHD();
                HienThiHoaDon();
                XuLyChucNang(true, false);
        }

        string MaLinhKien = "";
        int tongtien = 0;
        private void btnChonMua_Click(object sender, EventArgs e)
        {
            flag = 3;
            ClearTextBoxCTHD();
            XuLyChucNang(false, true);
            XulyTextBoxCTHD(false, true);
        }

        private void comboBoxLK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable DSSP = bus.GetLinhKienT("Select * From LinhKien Where TenLK=N'" + comboBoxLK.Text + "'");
                if (DSSP.Rows.Count > 0)
                {
                    //if(comboBoxSP.Text==DSSP.Rows[0]["MaLK"].ToString())
                    if (comboBoxLK.Text == DSSP.Rows[0]["TenLK"].ToString())
                    {
                        txtDonGia.Text = DSSP.Rows[0]["DonGia"].ToString();
                        txtSL.Text = DSSP.Rows[0]["SoLuong"].ToString();
                    }
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void TongThanhToan()
        {
            int TongThanhToan = 0;
            for (int i = 0; i < dataGridViewCTHD.Rows.Count - 1; i++)
            {
                int TT = Int32.Parse(dataGridViewCTHD.Rows[i].Cells["ThanhTien"].Value.ToString());
                TongThanhToan += TT;
                labelTongThanhToan.Text = TongThanhToan.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (flag ==5)
            {
                cthd.MaHDBH = comboBoxMaHD.Text;
                cthd.MaLK = comboBoxLK.SelectedValue.ToString();
                cthd.SoLuong =int.Parse(txtSL.Text);
                cthd.DonGia =double.Parse(txtDonGia.Text);
                cthd.KhuyenMai =double.Parse(txtKhuyenMai.Text);
                cthd.ThanhTien =double.Parse(labelThanhTien.Text);
                //cthd.TrangThai = CboTrangThai.Text;
                bus.UpdateCTHoaDon(cthd);
                MessageBox.Show("Cập Nhật Chi Tiết Hóa Đơn Thành Công !");
                HienThiCTHD_TheoMa();
                TongThanhToan();
               
            }
            if (flag == 3)
            {
                cthd.MaHDBH = comboBoxMaHD.Text;
                cthd.MaLK = comboBoxLK.SelectedValue.ToString();
                cthd.SoLuong =int.Parse( txtSL.Text);
                cthd.DonGia =double.Parse(txtDonGia.Text);
                cthd.KhuyenMai =double.Parse( txtKhuyenMai.Text);
                cthd.ThanhTien =double.Parse(labelThanhTien.Text);
                cthd.TrangThai = comboBoxTrangThai.Text;
                bus.ThemCTHD(cthd);
                MessageBox.Show("Thêm chi tiết hóa đơn thành công");
                HienThiCTHD_TheoMa();
                TongThanhToan();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int tt = 0;
            int KM = 0;
            if (txtKhuyenMai.Text != "")
                KM = int.Parse(txtKhuyenMai.Text);
            tt = Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSL.Text) - KM;
            tongtien += tt;
            labelThanhTien.Text = tt.ToString();
            labelTongThanhToan.Text = tongtien.ToString();
        }

        private void txtSL_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int tt = 0;
                int KM = 0;
                if (txtKhuyenMai.Text != "")
                    KM = int.Parse(txtKhuyenMai.Text);
                tt = Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSL.Text) - KM;
                tongtien = +tt;
                labelThanhTien.Text = tt.ToString();
                //labelTongThanhToan.Text = tongtien.ToString();  
            }
            catch
            {

            }
        }

        private void txtKhuyenMai_KeyDown(object sender, KeyEventArgs e)
        {
            int tt = 0;
            int KM = 0;
            if (txtKhuyenMai.Text != "")
                KM = int.Parse(txtKhuyenMai.Text);
            tt = Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSL.Text) - KM;
            tongtien += tt;
            labelThanhTien.Text = tt.ToString();
            //labelTongThanhToan.Text = tongtien.ToString();
        }

        private void dataGridViewCTHD_DoubleClick(object sender, EventArgs e)
        {
            XulyTextBoxCTHD(false, true);
            XuLyChucNang(false, true);
            flag = 5;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string condition = txtSearch.Text;
            HienThiTimKiemHD(condition);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn xóa sản phẩm hay không ?", "Thông Báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (KQ == DialogResult.Yes)
            {
                cthd.MaHDBH = comboBoxMaHD.Text;
                cthd.MaLK = comboBoxLK.SelectedValue.ToString();
                bus.DeleteCTHd(cthd);
                MessageBox.Show("Xóa SP Thành Công !");
                ClearTextBoxCTHD();
            }
            HienThiCTHD_TheoMa();
            TongThanhToan();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            XuLyChucNang(true, false);
            XulyTextBoxCTHD(true, false);
            ClearTextBoxCTHD();
            ClearTextBoxHD();

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //Frm_InHoaDon inhoadon = new Frm_InHoaDon();
            //inhoadon.ShowDialog();
        }

        public void RePortLoad(object seder,EventArgs e)
        {
            
        }
    }
}
