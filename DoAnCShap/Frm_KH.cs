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
    public partial class Frm_KH : Form
    {
        public Frm_KH()
        {
            InitializeComponent();
            Display();
        }

        KhachHang_BUS bus = new KhachHang_BUS();
        KhachHang kh = new KhachHang();
        DataTable dt;
        int flag = 0;
        bool addnew;

        public void HienThiSearch(String Condition)
        {
            dataGridViewKH.DataSource = bus.GetSearch("Select * From KhachHang Where TenKH Like N'%" + Condition + "%' or DienThoai Like N'%" + Condition + "%' ");
        }
        void Display()
        {
            dataGridViewKH.DataSource = bus.GetData("");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void xulytextbox(Boolean b1, Boolean b2)
        {
            txtMaKh.Enabled = b1;
            txtTenkh.Enabled = b1;
            radioButtonNam.Enabled = b1;
            radioButtonNu.Enabled = b1;
            txtSdt.Enabled = b1;
            txtDiaCh.Enabled = b1;
        }
        public void xulychucnang(Boolean b1, Boolean b2, Boolean b3)
        {
            btnThem.Enabled = b1;
            btnXoa.Enabled = b3;
            btnLuu.Enabled = b2;
            btnHuy.Enabled = b2;
        }


        public void Clear()
        {
            txtMaKh.Clear();
            txtTenkh.Clear();
            txtDiaCh.Clear();
            txtDiaCh.Clear();
            txtSdt.Clear();
            errorMes.Clear();
        }

        public String PhatSinhMa(DataTable d)
        {
            int sodong = d.Rows.Count;
            string macuoi;
            if (sodong > 9)
                macuoi = d.Rows[sodong - 1]["MaKH"].ToString().Substring(2, 2);
            else
                macuoi = d.Rows[sodong - 1]["MaKH"].ToString().Substring(3, 1);
            return (int.Parse(macuoi) + 1).ToString();
        }

        public void hienthibutton()
        {

        }
        private void Frm_KH_Load(object sender, EventArgs e)
        {
            xulytextbox(false, true);
            xulychucnang(true, false, false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulychucnang(false, true, false);
            xulytextbox(true, false);
            Clear();
            flag = 1;
            if (bus.PhatSinhMa("").Rows.Count == 0)
            {
                txtMaKh.Text = "KH00";
            }
            else
            {
                if (int.Parse(PhatSinhMa(bus.PhatSinhMa(""))) < 10)
                    txtMaKh.Text = "KH0" + PhatSinhMa(bus.PhatSinhMa(""));
                else
                    txtMaKh.Text = "KH" + PhatSinhMa(bus.PhatSinhMa(""));
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (flag == 1)
            {
                try
                {
                    if (txtTenkh.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtTenkh, "? Tên Khách hàng");
                        return;
                    }
                    if (txtSdt.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtSdt, "? Số điện thoại");
                        return;
                    }
                    if (txtSdt.Text.Length < 10)
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtSdt, "Số điện thoại không đúng");
                        return;
                    }
                    if (txtDiaCh.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtDiaCh, "? Địa chỉ");
                        return;
                    }
                    else
                    {

                        for (int i = 0; i < dataGridViewKH.Rows.Count - 0; i++)
                        {
                            if (txtSdt.Text == dataGridViewKH.Rows[i].Cells["DienThoai"].Value.ToString())
                            {
                                errorMes.BlinkRate = 100;
                                errorMes.SetError(txtSdt, "Đã tồn tại");
                                return;
                            }
                        }
                        kh.MaKH = txtMaKh.Text;
                        kh.TenKH = txtTenkh.Text;
                        if (radioButtonNam.Checked == true)
                        {
                            kh.GioiTinh = radioButtonNam.Text;
                        }
                        else
                        {
                            kh.GioiTinh = radioButtonNu.Text;
                        }
                        kh.DienThoai = txtSdt.Text;
                        kh.DiaChi = txtDiaCh.Text;
                        kh.TrangThai = "1";
                        bus.AddData(kh);
                        MessageBox.Show("Thêm Khách Hàng Thành Công");
                        xulychucnang(true, false, false);
                        Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể thêm được");
                }

            }
            if (flag == 2)
            {
                if (txtTenkh.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtTenkh, "? Tên Khách hàng");
                    return;
                }
                if (txtSdt.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtSdt, "? Số điện thoại");
                    return;
                }
                if (txtSdt.Text.Length < 10)
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtSdt, "Số điện thoại không đúng");
                    return;
                }
                if (txtDiaCh.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtDiaCh, "? Địa chỉ");
                    return;
                }
                else
                {
                    //for (int i = 0; i < dataGridViewKH.Rows.Count - 0; i++)
                    //{
                    //    if (txtSdt.Text == dataGridViewKH.Rows[i].Cells["DienThoai"].Value.ToString())
                    //    {
                    //        errorMes.BlinkRate = 100;
                    //        errorMes.SetError(txtSdt, "Đã tồn tại");
                    //        return;
                    //    }
                    //}
                    kh.MaKH = txtMaKh.Text;
                    kh.TenKH = txtTenkh.Text;
                    if (radioButtonNam.Checked == true)
                    {
                        kh.GioiTinh = radioButtonNam.Text;
                    }
                    else
                    {
                        kh.GioiTinh = radioButtonNu.Text;
                    }

                    kh.DienThoai = txtSdt.Text;
                    kh.DiaChi = txtDiaCh.Text;
                    kh.TrangThai = "1";
                    bus.EditData(kh); ;
                    //MessageBox.Show("Sửa Dữ Liệu Thành Công");
                    xulychucnang(true, false, false);
                    Clear();
                }
            }

            Display();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dataGridViewKH.Rows[e.RowIndex];
            txtMaKh.Text = row.Cells[1].Value.ToString();
            txtTenkh.Text = row.Cells[2].Value.ToString();
            string t = row.Cells[3].Value.ToString();
            if (t == "Nam")
                radioButtonNam.Checked = true;
            else
                radioButtonNu.Checked = true;
            txtSdt.Text = row.Cells[4].Value.ToString();
            txtDiaCh.Text = row.Cells[5].Value.ToString();
            xulytextbox(true, false);
            xulychucnang(true, true, true);
            flag = 2;
        }

        private void dataGridViewKH_DoubleClick(object sender, EventArgs e)
        {
            //xulytextbox(true, false);
            //xulychucnang(false, true, true);
            flag = 2;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông Báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (KQ == DialogResult.Yes)
            {
                kh.MaKH = txtMaKh.Text;
                bus.DeleteData(kh);
                MessageBox.Show("Xóa Dữ Liệu Thành Công");
                xulychucnang(true, false, false);
                xulytextbox(true, false);
                Clear();
            }
            Display();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dataGridViewKH.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excelAp = new Microsoft.Office.Interop.Excel.Application();
                excelAp.Application.Workbooks.Add(Type.Missing);
                // Lưu trữ phần header
                for (int i = 1; i < dataGridViewKH.Rows.Count - 1; i++)
                {
                    excelAp.Cells[1, i] = dataGridViewKH.Columns[i - 1].HeaderText;

                }
                // Lưu trữ hàng và cột vào excel
                for (int i = 0; i < dataGridViewKH.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewKH.Rows.Count - 1; j++)
                    {
                        excelAp.Cells[i + 2, j + 1] = dataGridViewKH.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excelAp.Columns.AutoFit();
                excelAp.Visible = true;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string Condition = txtSearch.Text;
            HienThiSearch(Condition);
        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtTenkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn hủy hay không ?", "Thông Báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (KQ == DialogResult.Yes)
            {
                xulychucnang(true, false, false);
                Clear();
                xulytextbox(false, true);
            }
            else
            {

            }
        }

        private void dataGridViewKH_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewKH.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void txtMaKh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
