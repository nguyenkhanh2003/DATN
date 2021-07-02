﻿using System;
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
    public partial class Frm_ChucVu : Form
    {
        public Frm_ChucVu()
        {
            InitializeComponent();
        }

        ChucVu_BUS bus = new ChucVu_BUS();
        ChucVu cv = new ChucVu();

        int flag = 0;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void XuLyChucNang(Boolean b1, Boolean b2)
        {
            btnThem.Enabled = b1;
            btnHuy.Enabled = b2;
            btnLuu.Enabled = b2;
            btnXoa.Enabled = b2;
        }
        public void XuLyTextBox(Boolean b1,Boolean b2)
        {
            txtMaCV.Enabled = b1;
            txtTenCV.Enabled = b1;
            cboTrangThai.Enabled = b1;
        }

        public void HienThiDSCV()
        {
            dataGridViewCV.DataSource = bus.GetChucVu("");
        }

        private void Frm_ChucVu_Load(object sender, EventArgs e)
        {
            HienThiDSCV();
            XuLyChucNang(true, false);
            XuLyTextBox(false,true);
        }

        public void PhatSinhMa()
        {
            int count = 0;
            count = dataGridViewCV.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtMaCV.Text = "CV00";
            }
            else
            {
                chuoi = Convert.ToString(dataGridViewCV.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    txtMaCV.Text = "CV0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtMaCV.Text = "CV" + (chuoi2 + 1).ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            XuLyChucNang(false,true);
            XuLyTextBox(true,false);
            PhatSinhMa();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTenCV.Text=="")
            {
                MessageBox.Show("Chưa Nhập Tên Chức Vụ");
                return;
            }    
            //if(cboTrangThai.Text=="")
            //{
            //    MessageBox.Show("Chưa chọn trạng thái !");
            //}    
            if(flag==1)
            { 
                cv.MaCV = txtMaCV.Text;
                cv.TenCV = txtTenCV.Text;
                cv.NhanVien = checkBoxNhanViem.Checked;
                cv.KhachHang = checkBoxkH.Checked;
                cv.LinhKien = checkBoxLinhKien.Checked;
                cv.BanHang = checkBoxBanHang.Checked;
                cv.NhaCungCap = checkBoxNCC.Checked;
                cv.LoaiLK = checkBoxLoaiLLK.Checked;
                cv.NhapKho = checkBoxNhapKho.Checked;
                cv.BaoHanh = checkBoxBaoHanh.Checked;
                cv.PhanQuyen = checkBoxPhanQuyen.Checked;
                cv.ThongKe = checkBoxThongKe.Checked;
                cv.HoaDon = checkBoxHoaDon.Checked;
                cv.Setting = checkBoxSetting.Checked;
                cv.TrangThai = cboTrangThai.Text;
                bus.AddChucVu(cv);
                MessageBox.Show("Thành Công");
            }

            if(flag==2)
            {
                cv.MaCV = txtMaCV.Text;
                cv.TenCV = txtTenCV.Text;
                cv.NhanVien = checkBoxNhanViem.Checked;
                cv.KhachHang = checkBoxkH.Checked;
                cv.LinhKien = checkBoxLinhKien.Checked;
                cv.BanHang = checkBoxBanHang.Checked;
                cv.NhaCungCap = checkBoxNCC.Checked;
                cv.LoaiLK = checkBoxLoaiLLK.Checked;
                cv.NhapKho = checkBoxNhapKho.Checked;
                cv.BaoHanh = checkBoxBaoHanh.Checked;
                cv.PhanQuyen = checkBoxPhanQuyen.Checked;
                cv.ThongKe = checkBoxThongKe.Checked;
                cv.HoaDon = checkBoxHoaDon.Checked;
                cv.Setting = checkBoxSetting.Checked;
                cv.TrangThai = cboTrangThai.Text;
                bus.EditCV(cv);
                MessageBox.Show("Thành Công");
            }    
            HienThiDSCV();
        }

        private void dataGridViewCV_DoubleClick(object sender, EventArgs e)
        {
            flag = 2;
            XuLyChucNang(false, true);
            XuLyTextBox(true,false);
        }

        private void dataGridViewCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewCV.Rows[e.RowIndex];
            txtMaCV.Text = row.Cells[0].Value.ToString();
            txtTenCV.Text = row.Cells[1].Value.ToString();
            checkBoxNhanViem.Checked =Convert.ToBoolean(row.Cells[2].Value.ToString());
            checkBoxkH.Checked= Convert.ToBoolean(row.Cells[3].Value.ToString());
            checkBoxLinhKien.Checked= Convert.ToBoolean(row.Cells[4].Value.ToString());
            checkBoxBanHang.Checked= Convert.ToBoolean(row.Cells[5].Value.ToString());
            checkBoxNCC.Checked= Convert.ToBoolean(row.Cells[6].Value.ToString());
            checkBoxLoaiLLK.Checked= Convert.ToBoolean(row.Cells[7].Value.ToString());
            checkBoxNhapKho.Checked= Convert.ToBoolean(row.Cells[8].Value.ToString());
            checkBoxBaoHanh.Checked= Convert.ToBoolean(row.Cells[9].Value.ToString());
            checkBoxPhanQuyen.Checked= Convert.ToBoolean(row.Cells[10].Value.ToString());
            checkBoxThongKe.Checked = Convert.ToBoolean(row.Cells[11].Value.ToString());
            checkBoxHoaDon.Checked = Convert.ToBoolean(row.Cells[12].Value.ToString());
            checkBoxSetting.Checked = Convert.ToBoolean(row.Cells[13].Value.ToString());
            cboTrangThai.Text = row.Cells[11].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaCV.Text = "CV01";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Thể Xóa !"+ex);
            }
            //cv.MaCV = txtMaCV.Text;
            //bus.DeleteChucVu(cv);
            //MessageBox.Show("Thành Công");
            //HienThiDSCV();
        }
    }
}