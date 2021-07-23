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
using Microsoft.Reporting.WinForms;

namespace DoAnCShap
{
    public partial class Frm_BaoHanh : Form
    {
        public Frm_BaoHanh()
        {
            InitializeComponent();
        }
        PhieuBaoHanh_BUS bus = new PhieuBaoHanh_BUS();
        PhieuBaoHanh pbh = new PhieuBaoHanh();
        CT_PhieuBaoHanh ctpbh = new CT_PhieuBaoHanh();
        ReportDataSource rs = new ReportDataSource();
        int flag = 0;

        public void XuLyChucNang(Boolean  b1,Boolean b2)
        {
            btnThem.Enabled = b1;
            btnHuy.Enabled = b2;
            btnLuu.Enabled = b2;
            btnXoa.Enabled = b2;
        }

        public void HienThiNhanVien(string labelHienTenDN)
        {
            comboBoxNV.DataSource = bus.GetNhanVien("Select MaNV,TenNV From NhanVien Where UserName=N'" + labelHienTenDN + "'");
            comboBoxNV.DisplayMember = "TenNV";
            comboBoxNV.ValueMember = "MaNV";
        }

        public void HienThiDSPhieu()
        {
            dataGridViewPBH.DataSource = bus.GetPBH("");
        }

        public void HienThiLK()
        {
            comboBoxlK.DataSource = bus.GetDSLK("");
            comboBoxlK.DisplayMember = "TenLK";
            comboBoxlK.ValueMember = "MaLK";
        }

        public void HienThiCTPhieuBaoHanh()
        {
            dataGridViewCTPBH.DataSource = bus.HienThiCTPhieu("");
        }
        public void HienThiCTPhieu()
        {
            dataGridViewCTPBH.DataSource = bus.LoadCT_PhieuTheoMa("select LK.TenLK,CT.SoLuong,CT.GhiChu From CT_PhieuBaoHanh CT , LinhKien LK Where LK.MaLK=CT.MaLK and MaPBH=N'" + txtMaPhieu.Text + "'");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ClearTextBoxPBH()
        {
            txtMaHD.ResetText();
            txtMaPhieu.ResetText();
            dateTimePickerNgaLap.ResetText();
            dateTimePickerNgayLayHang.ResetText();
            comboBoxNV.ResetText();
            
        }
        public void ClearTextBoxCTPBH()
        {
            comboBoxlK.ResetText();
            txtSL.ResetText();
            txtGhiChu.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            XuLyChucNang(false, true);
            if (dataGridViewPBH.Rows.Count <= 0)
            {
                txtMaPhieu.Text = "PBH00";
            }
            else
            {
                if (int.Parse(PhatSinhMaPBH(bus.PhatSinhMa(""))) < 10)
                    txtMaPhieu.Text = "PBH0" + bus.PhatSinhMa("");
                else
                    txtMaPhieu.Text = "PBH" + bus.PhatSinhMa("");
            }
        }

        private void Frm_BaoHanh_Load(object sender, EventArgs e)
        {
            HienThiDSPhieu();
            ClearTextBoxPBH();
            ClearTextBoxCTPBH();
            HienThiLK();
            XuLyChucNang(true, false);
            string condition = Login.SetValueForText1;
            HienThiNhanVien(condition);
        }

        public void PhatSinhMaHD()
        { 
            int count = 0;
            count = dataGridViewPBH.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 0)
            {
                txtMaPhieu.Text = "PBH00";
            }
            else
            {
                chuoi = Convert.ToString(dataGridViewPBH.Rows[count - 1].Cells[1].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    txtMaPhieu.Text = "PBH0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtMaPhieu.Text = "PBH" + (chuoi2 + 1).ToString();
            }
        }
        string MaLK = "";

        public string PhatSinhMaPBH(DataTable d)
        {
            int sodong = d.Rows.Count;
            string macuoi;
            if (sodong > 9)
                macuoi = d.Rows[sodong - 1]["MaPBH"].ToString().Substring(3, 2);
            else
                macuoi = d.Rows[sodong - 1]["MaPBH"].ToString().Substring(4, 1);
            return (int.Parse(macuoi) + 1).ToString();
        }
        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            int KiemTra = 0;
            if(comboBoxlK.Text=="")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(comboBoxlK, "? Chưa chọn tên linh kiện");
                return;
            }    
            if(txtSL.Text=="")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtSL, "Số lượng không được để trống");
                return;
            }    
            if(txtGhiChu.Text=="")
            {
                MessageBox.Show("? Ghi Chú");
                return;
            }    
            MaLK += comboBoxlK.SelectedValue.ToString() + ";";
            for (int i = 0; i < dataGridViewCTPBH.Rows.Count - 0; i++)
            {
                if (comboBoxlK.Text == dataGridViewCTPBH.Rows[i].Cells["MaLKK"].Value.ToString())
                {
                    KiemTra = 1;
                    break;
                }
            }
            if (KiemTra == 1)
            {

            }
            else
            {
                object[] t = { comboBoxlK.Text, txtSL.Text, txtGhiChu.Text };
                dataGridViewCTPBH.Rows.Add(t);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                pbh.MaPBH = txtMaPhieu.Text;
                pbh.MaHDBH = txtMaHD.Text;
                pbh.MaNV = comboBoxNV.SelectedValue.ToString();
                pbh.NgayLap = dateTimePickerNgaLap.Value.Date;
                pbh.NgayLayHang = dateTimePickerNgayLayHang.Value.Date;
                pbh.TrangThai = "1";
                bus.ThemPBH(pbh);
                string[] b = MaLK.Split(';');
                for (int i = 0; i < dataGridViewCTPBH.Rows.Count - 0; i++)
                {
                    string malk = b[i];
                    int soluong =int.Parse(dataGridViewCTPBH.Rows[i].Cells[1].Value.ToString());
                    string ghichu = dataGridViewCTPBH.Rows[i].Cells[2].Value.ToString();
                    ctpbh.MaPBH = txtMaPhieu.Text;
                    ctpbh.MaLK = malk;
                    ctpbh.SoLuong = soluong;
                    ctpbh.GhiChu = ghichu;
                    bus.ThemCTPhieuBH(ctpbh);
                }
                MessageBox.Show("Tạo phiếu thành công");
                ClearTextBoxPBH();
                ClearTextBoxCTPBH();
                XuLyChucNang(true, false);
            }
            if(flag==2)
            {
                ctpbh.MaPBH = txtMaPhieu.Text;
                ctpbh.MaLK = comboBoxlK.SelectedValue.ToString();
                ctpbh.SoLuong =int.Parse(txtSL.Text);
                ctpbh.GhiChu = txtGhiChu.Text;
                bus.Update_CTPBH(ctpbh);
                pbh.MaPBH = txtMaPhieu.Text;
                bus.Update_PBH(pbh);
                MessageBox.Show("Success");
            }
            HienThiDSPhieu();
            ClearTextBoxPBH();
            ClearTextBoxCTPBH();
            XuLyChucNang(true, false);
        }

        public void HienThiPhieuBHTextBox(int vitri,DataTable d)
        {
            try
            {
                txtMaPhieu.Text = d.Rows[vitri]["MaPBH"].ToString();
                txtMaHD.Text = d.Rows[vitri]["MaHDBH"].ToString();
                comboBoxNV.Text = d.Rows[vitri]["TenNV"].ToString();
                dateTimePickerNgaLap.Text = d.Rows[vitri]["NgayLapPhieu"].ToString();
                dateTimePickerNgayLayHang.Text = d.Rows[vitri]["NgayLayHang"].ToString();
                dataGridViewCTPBH.DataSource = bus.LoadCT_PhieuTheoMa("select LK.TenLK,CT.SoLuong,CT.GhiChu From CT_PhieuBaoHanh CT , LinhKien LK Where LK.MaLK=CT.MaLK and MaPBH=N'" + txtMaPhieu.Text + "'");
            }
            catch
            {

            }
        }
        private void dataGridViewPBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dataGridViewPBH.CurrentCell.RowIndex;
            HienThiPhieuBHTextBox(vitri,bus.GetPBH(""));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        { 
            DialogResult KQ = MessageBox.Show("Bạn Có Muốn Xóa Hau Không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(KQ==DialogResult.OK)
            {
                if(flag==1)
                {

                }
                if(flag==2)
                {
                    ctpbh.MaPBH = txtMaPhieu.Text;
                    ctpbh.MaLK = comboBoxlK.SelectedValue.ToString();
                    bus.XoaCTPhieuBaoHanh(ctpbh);
                    MessageBox.Show("Thành Công");
                    HienThiDSPhieu();
                }
            }
            else
            {

            }    
        }

        private void dataGridViewCTPBH_DoubleClick(object sender, EventArgs e)
        {
            flag = 2;
            XuLyChucNang(false, true);
        }

        private void dataGridViewCTPBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewCTPBH.Rows[e.RowIndex];
            comboBoxlK.Text = row.Cells[0].Value.ToString();
            txtSL.Text = row.Cells[1].Value.ToString();
            txtGhiChu.Text = row.Cells[2].Value.ToString();
            flag = 2;
        }

        private void dataGridViewPBH_DoubleClick(object sender, EventArgs e)
        {
            XuLyChucNang(false, true);
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(KQ==DialogResult.OK)
            {
                ctpbh.MaPBH = txtMaPhieu.Text;
                ctpbh.MaLK = comboBoxlK.SelectedValue.ToString();
                bus.XoaCTPhieuBaoHanh(ctpbh);
                MessageBox.Show("Success");
                dataGridViewCTPBH.DataSource= bus.LoadCT_PhieuTheoMa("select LK.TenLK,CT.SoLuong,CT.GhiChu From CT_PhieuBaoHanh CT , LinhKien LK Where LK.MaLK=CT.MaLK and MaPBH=N'" + txtMaPhieu.Text + "'");
                ClearTextBoxCTPBH();
                XuLyChucNang(true, false);
            }    
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable DSHD = bus.TimHD("select * From HoaDonBanHang Where MaHDBH=N'" + txtMaHD.Text + "'");
                if(DSHD.Rows.Count>0)
                {
                    if(txtMaHD.Text==DSHD.Rows[0]["MaHDBH"].ToString())
                    {
                        MessageBox.Show("Tồn tại");
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại");
                    }    
                }    
            }
            catch
            {

            }
        }

        private void dataGridViewPBH_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridViewPBH.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            List<PbaoHanh> lst = new List<PbaoHanh>();
            lst.Clear();
            for(int i=0;i<dataGridViewCTPBH.Rows.Count-0;i++)
            {
                PbaoHanh pbaoHanh = new PbaoHanh
                {
                    MaPhieuBH = txtMaPhieu.Text,
                    MaHD = txtMaHD.Text,
                    TenNV = comboBoxNV.Text,
                    NgayLap = dateTimePickerNgaLap.Text,
                    NgayLay = dateTimePickerNgayLayHang.Text,
                    TenLK = dataGridViewCTPBH.Rows[i].Cells[0].Value.ToString(),
                    SoLuong = int.Parse(dataGridViewCTPBH.Rows[i].Cells[1].Value.ToString()),
                    GhiChu = dataGridViewCTPBH.Rows[i].Cells[2].Value.ToString(),
                };
                lst.Add(pbaoHanh);
            }
            rs.Name = "DataSet3";
            rs.Value = lst;
            Frm_PrintHD frm_in = new Frm_PrintHD();
            frm_in.reportViewer1.LocalReport.DataSources.Clear();
            frm_in.reportViewer1.LocalReport.DataSources.Add(rs);
            frm_in.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnCShap.ReportPhieuBaoHanh.rdlc";
            frm_in.ShowDialog();
        }

        public class PbaoHanh
        {
            public string MaPhieuBH { get; set; }
            public string MaHD { get; set; }
            public string TenNV { get; set; }
            public string NgayLap { get; set; }
            public string NgayLay { get; set; }
            public string TenLK { get; set; }
            public int SoLuong { get; set; }
            public string GhiChu { get; set; }
        }

        private void txtMaHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
                e.KeyChar -= (char)32;
        }
    }
}
