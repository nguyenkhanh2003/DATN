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
       

        public void HienThiCTHD_TheoMa()
        {
            dataGridViewCTHD.DataSource = bus.GetCtHoaDon("select LinhKien.TenLK,CT_HoaDonBanHang.SoLuong,CT_HoaDonBanHang.DonGia,KhuyenMai,ThanhTien from CT_HoaDonBanHang ,LinhKien Where LinhKien.MaLK=CT_HoaDonBanHang.MaLK and CT_HoaDonBanHang.MaHDBH=N'" + txtMaHD.Text + "'");
        }

        public void HienThiCTHD_TheoMaHD(string condition)
        {
            dataGridViewCTHD.DataSource = bus.HienThiCTHDTheoMa("select lk.TenLK,ct.SoLuong,ct.DonGia,ct.KhuyenMai,ct.ThanhTien From CT_HoaDonBanHang ct,LinhKien lk where lk.MaLK=ct.MaLK and ct.MaHDBH=N'"+condition+"'");
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
            txtDonGia.ReadOnly = b1;
            txtKhuyenMai.ReadOnly = b1;
        }
        public void XuLyTextBoxHD(Boolean b1,Boolean b2)
        {
            txtMaHD.Enabled = b2;
            comboBoxKH.Enabled = b2;
            comboBoxNhanVien.Enabled = b2;
            dateTimePickerNgaylap.Enabled = b2;
            comboBoxTrangThai.Enabled = b2;
        }

        public void ClearTextBoxHD()
        {
            txtMaHD.Controls.Clear();
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
            textBoxSL.Clear();
            txtDonGia.Clear();
            txtKhuyenMai.Clear();
        }

       
        public void XuLyChucNang(Boolean b1,Boolean b2)
        {
            btnEdit.Enabled = b1;
            btnInHD.Enabled = b1;
            btnXoa.Enabled = b1;
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
                txtMaHD.Text = d.Rows[vitri]["MaHDBH"].ToString();
                comboBoxKH.Text = d.Rows[vitri]["TenKH"].ToString();
                comboBoxNhanVien.Text = d.Rows[vitri]["TenNV"].ToString();
                dateTimePickerNgaylap.Text = d.Rows[vitri]["NgayLapHDBH"].ToString();
                labelTongThanhToan.Text = d.Rows[vitri]["TongTien"].ToString();
                labelTongThanhToan.Text = string.Format("{0:#,##0}", double.Parse(labelTongThanhToan.Text));
                comboBoxTrangThai.Text = d.Rows[vitri]["TrangThai"].ToString();
                //HienThiDS_CTHD(vitri);
                dataGridViewCTHD.DataSource = bus.GetCtHoaDon("select LinhKien.TenLK,CT_HoaDonBanHang.SoLuong,CT_HoaDonBanHang.DonGia,CT_HoaDonBanHang.KhuyenMai,ThanhTien from CT_HoaDonBanHang ,LinhKien Where LinhKien.MaLK=CT_HoaDonBanHang.MaLK and CT_HoaDonBanHang.MaHDBH=N'"+txtMaHD.Text+"'");
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
                textBoxSL.Text = d.Rows[vitri]["SoLuong"].ToString();
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
            comboBoxLK.Text = null;
            XuLyChucNang(false,true);
        }

        private void dataGridViewHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                flag = 1;
                int vitri = dataGridViewHD.CurrentCell.RowIndex;
                HienThiHoaDonTextBox(vitri,bus.GetHoaDon(""));
        }

        private void dataGridViewCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            XuLyChucNang(true, false);
            try
            {
                DataGridViewRow row = dataGridViewCTHD.Rows[e.RowIndex];
                comboBoxLK.Text = row.Cells[0].Value.ToString();
                textBoxSL.Text = row.Cells[1].Value.ToString();
                txtDonGia.Text = row.Cells[2].Value.ToString();
                txtDonGia.Text = string.Format("{0:#,##0}", double.Parse(txtDonGia.Text));
                txtKhuyenMai.Text = row.Cells[3].Value.ToString();
                labelThanhTien.Text = row.Cells[4].Value.ToString();
                labelThanhTien.Text = string.Format("{0:#,##0}", double.Parse(labelThanhTien.Text));
                //CboTrangThai.Text = row.Cells[7].Value.ToString();
            }
            catch
            {

            }
        }

        private void dataGridViewHD_DoubleClick(object sender, EventArgs e)
        {
            XuLyChucNang(true,false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
                hdbh.MaHDBH = txtMaHD.Text;
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
        decimal tongtien = 0;
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
                        textBoxSL.Text = "1";
                        txtKhuyenMai.Text = DSSP.Rows[0]["KhuyenMai"].ToString();
                    }
                }
            }
            e.SuppressKeyPress = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void TongThanhToan()
        {
            decimal TongThanhToan = 0;
            for (int i = 0; i < dataGridViewCTHD.Rows.Count - 0; i++)
            {
                decimal TT = decimal.Parse(dataGridViewCTHD.Rows[i].Cells["ThanhTien"].Value.ToString());
                TongThanhToan += TT;
                labelTongThanhToan.Text = TongThanhToan.ToString();
                labelTongThanhToan.Text= string.Format("{0:#,##0}", decimal.Parse(labelTongThanhToan.Text));
            }
        }

        private void textBoxSL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal tt = 0;
                decimal KM = 0;
                KM = int.Parse(txtKhuyenMai.Text);
                tt = decimal.Parse(txtDonGia.Text) * decimal.Parse(textBoxSL.Text) - KM;
                tongtien += tt;
                labelThanhTien.Text = tt.ToString();
                labelThanhTien.Text = string.Format("{0:#,##0}", decimal.Parse(labelThanhTien.Text));
            }
            catch
            {

            }
        }

        private void dataGridViewCTHD_DoubleClick(object sender, EventArgs e)
        {
            XulyTextBoxCTHD(false, true);
            //XuLyChucNang(false, true);
            flag = 5;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string condition = txtSearch.Text;
            HienThiTimKiemHD(condition);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông Báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (KQ == DialogResult.Yes)
            {
                cthd.MaHDBH = txtMaHD.Text;
                //cthd.MaLK = comboBoxLK.SelectedValue.ToString();
                bus.DeleteCTHd(cthd);
                hdbh.MaHDBH = txtMaHD.Text;
                bus.DeleteHoaDon(hdbh);
                MessageBox.Show("Success !");
                ClearTextBoxCTHD();
            }
            HienThiHoaDon();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            XuLyChucNang(true, false);
            XulyTextBoxCTHD(true, false);
            ClearTextBoxCTHD();
            ClearTextBoxHD();

        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            string condition = txtMaHD.Text;
           
            MessageBox.Show("Seccess !");
            HienThiCTHD_TheoMaHD(condition);
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cthd.MaHDBH = txtMaHD.Text;
            cthd.MaLK = comboBoxLK.SelectedValue.ToString();
            cthd.SoLuong = int.Parse(textBoxSL.Text);
            cthd.DonGia = decimal.Parse(txtDonGia.Text);
            cthd.KhuyenMai = decimal.Parse(txtKhuyenMai.Text);
            cthd.ThanhTien = decimal.Parse(labelThanhTien.Text);
            cthd.TrangThai = comboBoxTrangThai.Text;
            bus.UpdateCTHoaDon(cthd);
            dataGridViewCTHD.DataSource = bus.GetCtHoaDon("select LinhKien.TenLK,CT_HoaDonBanHang.SoLuong,CT_HoaDonBanHang.DonGia,CT_HoaDonBanHang.KhuyenMai,ThanhTien from CT_HoaDonBanHang ,LinhKien Where LinhKien.MaLK=CT_HoaDonBanHang.MaLK and CT_HoaDonBanHang.MaHDBH=N'" + txtMaHD.Text + "'");
            TongThanhToan();
            hdbh.MaHDBH = txtMaHD.Text;
            hdbh.MaKH = comboBoxKH.SelectedValue.ToString();
            hdbh.MaNV = comboBoxNhanVien.SelectedValue.ToString();
            hdbh.NgayLapHDBH = dateTimePickerNgaylap.Value.Date;
            hdbh.TongTien = decimal.Parse(labelTongThanhToan.Text);
            hdbh.TrangThai = comboBoxTrangThai.Text;
            bus.UpdateHoaDon(hdbh);
            MessageBox.Show("Success");
            HienThiHoaDon();
            XuLyChucNang(false,true);
        }

        private void textBoxSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void comboBoxKH_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBoxNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        public static string SetValueForText1 = "";

        private void btnInHD_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewHD_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridViewHD.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
