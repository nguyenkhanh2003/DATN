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
        public void HienThiHoaDon()
        {
            dataGridViewHD.DataSource = bus.GetHoaDon("");
        }
        //public void HienThiCTHD()
        //{
        //    dataGridViewCTHD.DataSource = bus.GetCtHoaDon("select CT_HoaDonBanHang.MaHDBH,LinhKien.TenLK,CT_HoaDonBanHang.SoLuong,CT_HoaDonBanHang.DonGia,KhuyenMai,ThanhTien from CT_HoaDonBanHang ,LinhKien Where LinhKien.MaLK=CT_HoaDonBanHang.MaLK and CT_HoaDonBanHang.MaHDBH");
        //}
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

        public void XulyTextBox(Boolean b1, Boolean b2)
        {
            txtMaHD.Enabled = b2;
            comboBoxKH.Enabled = b2;
            comboBoxNhanVien.Enabled = b2;
            dateTimePickerNgaylap.Enabled = b2;
            comboBoxTrangThai.Enabled = b2;
            labelTongThanhToan.Enabled = b2;
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
                comboBoxTrangThai.Text = d.Rows[vitri]["TrangThai"].ToString();
                dataGridViewCTHD.DataSource = bus.GetCtHoaDon("select CT_HoaDonBanHang.MaHDBH,LinhKien.TenLK,CT_HoaDonBanHang.SoLuong,CT_HoaDonBanHang.DonGia,KhuyenMai,ThanhTien from CT_HoaDonBanHang ,LinhKien Where LinhKien.MaLK=CT_HoaDonBanHang.MaLK and CT_HoaDonBanHang.MaHDBH=N'"+txtMaHD.Text+"'");
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
                CboTrangThai.Text = d.Rows[vitri]["TrangThai"].ToString();
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
            XulyTextBox(true, false);
        }

        private void dataGridViewHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                int vitri = dataGridViewHD.CurrentCell.RowIndex;
                HienThiHoaDonTextBox(vitri,bus.GetHoaDon(""));
            }
        }

        private void dataGridViewCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           try
            {
                int vitri = dataGridViewCTHD.CurrentCell.RowIndex;
                HienThiCTHoaDonTextBox(vitri, bus.GetCtHoaDon("select CT_HoaDonBanHang.MaHDBH,LinhKien.TenLK,CT_HoaDonBanHang.SoLuong,CT_HoaDonBanHang.DonGia,KhuyenMai,ThanhTien from CT_HoaDonBanHang ,LinhKien Where LinhKien.MaLK=CT_HoaDonBanHang.MaLK"));
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu !");
            }
        }

        private void dataGridViewHD_DoubleClick(object sender, EventArgs e)
        {
            flag = 1;
            XulyTextBox(false, true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(flag==1)
            {
                hdbh.MaHDBH = txtMaHD.Text;
                hdbh.MaKH = comboBoxKH.SelectedValue.ToString();
                hdbh.MaNV = comboBoxNhanVien.SelectedValue.ToString();
                hdbh.NgayLapHDBH = dateTimePickerNgaylap.Text;
                hdbh.TongTien = labelTongThanhToan.Text;
                hdbh.TrangThai = comboBoxTrangThai.Text;
                bus.UpdateHoaDon(hdbh);
                MessageBox.Show("Thành Công !");
            }
            HienThiHoaDon();
        }

        string MaLinhKien = "";
        int tongtien = 0;
        private void btnChonMua_Click(object sender, EventArgs e)
        {
            try
            {
                MaLinhKien += comboBoxLK.SelectedValue.ToString() + ";";
                int tt = 0;
                int KM = 0;
                if (txtKhuyenMai.Text != "")
                    KM = int.Parse(txtKhuyenMai.Text);
                tt = Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSL.Text) - KM;
                tongtien += tt;
                labelThanhTien.Text = tt.ToString();
                labelTongThanhToan.Text = tongtien.ToString();
                object[] t = { comboBoxLK.Text, txtSL.Text, txtDonGia.Text, KM.ToString(), labelThanhTien.Text };
                dataGridViewCTHD.Rows.Add(t);
            }
            catch
            {
                MessageBox.Show("Fail !");
            }
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

        private void btnCapNhat_Click(object sender, EventArgs e)
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
    }
}
