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
    public partial class Frm_BaoHanh : Form
    {
        public Frm_BaoHanh()
        {
            InitializeComponent();
        }
        PhieuBaoHanh_BUS bus = new PhieuBaoHanh_BUS();
        PhieuBaoHanh pbh = new PhieuBaoHanh();
        CT_PhieuBaoHanh ctpbh = new CT_PhieuBaoHanh();
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            XuLyChucNang(false, true);
            PhatSinhMaHD();
        }

        private void Frm_BaoHanh_Load(object sender, EventArgs e)
        {
            HienThiDSPhieu();
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
            if (count <= 1)
            {
                txtMaPhieu.Text = "PBH00";
            }
            else
            {
                chuoi = Convert.ToString(dataGridViewPBH.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    txtMaPhieu.Text = "PBH0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtMaPhieu.Text = "PBH" + (chuoi2 + 1).ToString();
            }
        }
        string MaLK = "";

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            if(comboBoxlK.Text=="")
            {
                MessageBox.Show("? Tên Linh Kiện");
                return;
            }    
            if(txtSL.Text=="")
            {
                MessageBox.Show("? Số lượng");
                return;
            }    
            if(txtGhiChu.Text=="")
            {
                MessageBox.Show("? Ghi Chú");
                return;
            }    
            MaLK += comboBoxlK.SelectedValue.ToString() + ";";
            object[] t = { comboBoxlK.Text, txtSL.Text, txtGhiChu.Text };
            dataGridViewCTPBH.Rows.Add(t);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                pbh.MaPBH = txtMaPhieu.Text;
                pbh.MaHDBH = txtMaHD.Text;
                pbh.MaNV = comboBoxNV.SelectedValue.ToString();
                pbh.NgayLap = dateTimePickerNgaLap.Text;
                pbh.TrangThai = cboTrangThai.Text;
                bus.ThemPBH(pbh);
                string[] b = MaLK.Split(';');
                for (int i = 0; i < dataGridViewCTPBH.Rows.Count - 1; i++)
                {
                    string malk = b[i];
                    string soluong =dataGridViewCTPBH.Rows[i].Cells[1].Value.ToString();
                    string ghichu = dataGridViewCTPBH.Rows[i].Cells[2].Value.ToString();
                    ctpbh.MaPBH = txtMaPhieu.Text;
                    ctpbh.MaLK = malk;
                    ctpbh.SoLuong = soluong;
                    ctpbh.GhiChu = ghichu;
                    bus.ThemCTPhieuBH(ctpbh);
                }
                MessageBox.Show("Tạo phiếu thành công");
            }
            HienThiDSPhieu();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
