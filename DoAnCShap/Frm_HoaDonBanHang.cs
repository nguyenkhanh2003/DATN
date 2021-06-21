﻿using System;
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
            comboBoxLK.Enabled = b2;
            txtSL.Enabled = b2;
            txtDonGia.Enabled = b2;
            txtKhuyenMai.Enabled = b2;
            CboTrangThai.Enabled = b2;
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
                comboBoxTrangThai.Text = d.Rows[vitri]["TrangThai"].ToString();
                //HienThiDS_CTHD(vitri);
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
            comboBoxLK.Text = null;
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
                CboTrangThai.Text = row.Cells[7].Value.ToString();
            }
            catch
            {

            }
        
        }

        private void dataGridViewHD_DoubleClick(object sender, EventArgs e)
        {
            //flag = 1;
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
                {
                    cthd.MaHDBH = txtMaHD.Text;
                    cthd.MaLK = comboBoxLK.SelectedValue.ToString();
                    cthd.SoLuong = txtSL.Text;
                    cthd.DonGia = txtDonGia.Text;
                    cthd.KhuyenMai = txtKhuyenMai.Text;
                    cthd.ThanhTien = labelThanhTien.Text;
                    cthd.TrangThai = comboBoxTrangThai.Text;
                    bus.UpdateCTHoaDon(cthd);
                }
                MessageBox.Show("Lưu Hóa Đơn Thành Công !");
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

        int TongThanhToan = 0;
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
                cthd.MaHDBH = txtMaHD.Text;
                cthd.MaLK = comboBoxLK.SelectedValue.ToString();
                cthd.SoLuong = txtSL.Text;
                cthd.DonGia = txtDonGia.Text;
                cthd.KhuyenMai = txtKhuyenMai.Text;
                cthd.ThanhTien = labelThanhTien.Text;
                cthd.TrangThai = comboBoxTrangThai.Text;
                bus.UpdateCTHoaDon(cthd);
                MessageBox.Show("Cập Nhật Chi Tiết Hóa Đơn Thành Công !");
                dataGridViewCTHD.DataSource = bus.GetCtHoaDon("select CT_HoaDonBanHang.MaHDBH,LinhKien.TenLK,CT_HoaDonBanHang.SoLuong,CT_HoaDonBanHang.DonGia,KhuyenMai,ThanhTien from CT_HoaDonBanHang ,LinhKien Where LinhKien.MaLK=CT_HoaDonBanHang.MaLK and CT_HoaDonBanHang.MaHDBH=N'" + txtMaHD.Text + "'");
                for(int i=0;i<dataGridViewCTHD.Rows.Count-1;i++)
                {
                int SL = Int32.Parse(dataGridViewCTHD.Rows[i].Cells[3].Value.ToString());
                int DonGia = Int32.Parse(dataGridViewCTHD.Rows[i].Cells[6].Value.ToString());
                TongThanhToan += SL * DonGia;
                labelTongThanhToan.Text = TongThanhToan.ToString();
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
                labelTongThanhToan.Text = tongtien.ToString();  
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
            labelTongThanhToan.Text = tongtien.ToString();
        }

        private void dataGridViewCTHD_DoubleClick(object sender, EventArgs e)
        {
            XulyTextBox(false, true);
        }

        private void txtSL_ImeModeChanged(object sender, EventArgs e)
        {

        }
    }
}
