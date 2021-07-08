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
    public partial class Frm_HoaDonNhap : Form
    {
        public Frm_HoaDonNhap()
        {
            InitializeComponent();
        }

        NhapKho_BUS bus = new NhapKho_BUS();
        HoaDonNhapHang hdn = new HoaDonNhapHang();
        CT_HoaDonNhapHang cthdn = new CT_HoaDonNhapHang();
        int flag = 0;
        public void HienThiSanPham()
        {
            comboBoxTenLK.DataSource = bus.GetData("");
            comboBoxTenLK.DisplayMember = "TenLK";
            comboBoxTenLK.ValueMember = "MaLK";
        }

        public void HienThiNhanVien(string labelHienTenDN)
        {
            comboBoxMaNV.DataSource = bus.GetNhanVien("Select MaNV,TenNV From NhanVien Where UserName=N'" + labelHienTenDN + "'");
            comboBoxMaNV.DisplayMember = "TenNV";
            comboBoxMaNV.ValueMember = "MaNV";
        }

        public void HienThiNCC()
        {
            comboBoxNCC.DataSource = bus.GetNCC("");
            comboBoxNCC.DisplayMember = "TenNCC";
            comboBoxNCC.ValueMember = "MaNCC";
        }

        public void HienThiHoaDonN()
        {
            dataGridViewHDN.DataSource = bus.HienThiHDN("");
        }
        public void XuLyChucNang(Boolean b1, Boolean b2,Boolean b3)
        {
            btnTaoPhieu.Enabled = b1;
            //btnHuy.Enabled = b2;
            btnCane.Enabled = b2;
            btnLuu.Enabled = b2;
            btnChon.Enabled = b2;
            btnInHoaDon.Enabled = b2;
            btnXoa.Enabled = b3;
        }

        public void ClearTexBox()
        {
            txtMaHDN.Clear();
            textBoxDonGia.Clear();
            textBoxSoLuong.Clear();
            textBoxChietKhau.Clear();
            labelThanhTien.ResetText();
            labelTongThanhToan.ResetText();
            comboBoxMaNV.ResetText();
            comboBoxNCC.ResetText();
            comboBoxTenLK.ResetText();
        }
        public void PhatSinhMa()
        {
            int count = 0;
            count = dataGridViewHDN.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtMaHDN.Text = "PN00";
            }
            else
            {
                chuoi = Convert.ToString(dataGridViewHDN.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    txtMaHDN.Text = "PN0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtMaHDN.Text = "PN" + (chuoi2 + 1).ToString();
            }
        }
        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            ClearTexBox();
            PhatSinhMa();
            flag = 1;
            XuLyChucNang(false,true,false);
        }

        decimal tongtien = 0;
        public string MaLK = "";
        private void btnChonNhap_Click(object sender, EventArgs e)
        {
            int KiemTra = 0;
            int vitri = 0;
            decimal KM = 0;
            decimal tt = 0;
            if(textBoxSoLuong.Text=="")
            {
                MessageBox.Show("? Số lượng");
                return;
            }
            if(textBoxDonGia.Text=="")
            {
                MessageBox.Show("? Đơn giá");
                return;
            }
            if(textBoxChietKhau.Text=="")
            {
                MessageBox.Show("? Chiết khấu");
                return;
            }    
            tongtien += tt;
            KM = decimal.Parse(textBoxChietKhau.Text);
            tt = decimal.Parse(textBoxDonGia.Text) * int.Parse(textBoxSoLuong.Text) - KM;
            tongtien += tt;
            labelThanhTien.Text = tt.ToString();
            labelThanhTien.Text = string.Format("{0:#,##0}", double.Parse(labelThanhTien.Text));
            labelTongThanhToan.Text = tongtien.ToString();
            labelTongThanhToan.Text = string.Format("{0:#,##0}", double.Parse(labelTongThanhToan.Text));

            for (int i = 0; i < dataGridViewCTHDNH.Rows.Count - 1; i++)
            {
                if (comboBoxTenLK.Text == dataGridViewCTHDNH.Rows[i].Cells["TenLK"].Value.ToString())
                {
                    KiemTra = 1;
                    vitri = i;
                    break;
                }

            }

            if (KiemTra == 1)
            {
                int SL = int.Parse(textBoxSoLuong.Text) + int.Parse(dataGridViewCTHDNH.Rows[vitri].Cells["SoLuong"].Value.ToString());
                dataGridViewCTHDNH.Rows[vitri].Cells["SoLuong"].Value = SL.ToString();
                decimal ThanhTienMoi = tt + decimal.Parse(dataGridViewCTHDNH.Rows[vitri].Cells["ThanhTien"].Value.ToString());
                dataGridViewCTHDNH.Rows[vitri].Cells["ThanhTien"].Value = ThanhTienMoi.ToString();
                dataGridViewCTHDNH.Rows[vitri].Cells["ThanhTien"].Value = string.Format("{0:#,##0}", double.Parse(ThanhTienMoi.ToString()));
            }

            else
            {
                MaLK += comboBoxTenLK.SelectedValue.ToString() + ";";
                object[] t = { comboBoxTenLK.Text, textBoxSoLuong.Text, textBoxDonGia.Text, KM.ToString(), labelThanhTien.Text };
                dataGridViewCTHDNH.Rows.Add(t);
            }

        }

        public void TongThanhToanMoi()
        {
            decimal TongThanhToan = 0;
            for (int i = 0; i < dataGridViewCTHDNH.Rows.Count - 1; i++)
            {
                decimal TT = decimal.Parse(dataGridViewCTHDNH.Rows[i].Cells["ThanhTien"].Value.ToString());
                TongThanhToan += TT;
                labelTongThanhToan.Text = TongThanhToan.ToString();
                labelTongThanhToan.Text = string.Format("{0:#,##0}", decimal.Parse(labelTongThanhToan.Text));
            }
        }

        private void Frm_HoaDonNhap_Load(object sender, EventArgs e)
        {
            string condition = Login.SetValueForText1;
            HienThiNhanVien(condition);
            HienThiSanPham();
            HienThiNCC();
            HienThiHoaDonN();
            XuLyChucNang(true, false, false);
            comboBoxNCC.Text = "";
        }

        private void dataGridViewHDNH_DoubleClick(object sender, EventArgs e)
        {
            XuLyChucNang(false, true, true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                hdn.MaHDNH = txtMaHDN.Text;
                hdn.MaNCC = comboBoxNCC.SelectedValue.ToString();
                hdn.MaNV = comboBoxMaNV.SelectedValue.ToString();
                hdn.NgayLapHDNH = dateTimePickerNgayLapHDN.Value.Date;
                hdn.TongTien = decimal.Parse(labelTongThanhToan.Text);
                hdn.TrangThai = comboBoxTrangThai.Text;
                bus.AddHoaDon(hdn);
                string[] b = MaLK.Split(';');
                for (int i = 0; i < dataGridViewCTHDNH.Rows.Count - 1; i++)
                {
                    string malk = b[i];
                    //malk = dataGridViewHDNH.Rows[i].Cells[0].Value.ToString();
                    int soluong =int.Parse(dataGridViewCTHDNH.Rows[i].Cells[1].Value.ToString());
                    decimal dongia =decimal.Parse(dataGridViewCTHDNH.Rows[i].Cells[2].Value.ToString());
                    decimal khuyenmai =decimal.Parse(dataGridViewCTHDNH.Rows[i].Cells[3].Value.ToString());
                    decimal thanhtien =decimal.Parse(dataGridViewCTHDNH.Rows[i].Cells[4].Value.ToString());
                    cthdn.MaHDNH = txtMaHDN.Text;
                    cthdn.MaLK = malk;
                    cthdn.SoLuong = soluong;
                    cthdn.DonGia = dongia;
                    cthdn.KhuyenMai = khuyenmai;
                    cthdn.ThanhTien =thanhtien;
                    cthdn.TrangThai = comboBoxTrangThai.Text;
                    bus.AddCTHD(cthdn);
                }

                MessageBox.Show("Tạo Hóa Đơn Thành Công ");
            }
            if(flag==2)
            {
                cthdn.MaHDNH = txtMaHDN.Text;
                cthdn.MaLK = comboBoxTenLK.SelectedValue.ToString();
                cthdn.SoLuong = int.Parse(textBoxSoLuong.Text);
                cthdn.DonGia = decimal.Parse(textBoxDonGia.Text);
                cthdn.KhuyenMai = decimal.Parse(textBoxChietKhau.Text);
                cthdn.ThanhTien = decimal.Parse(labelThanhTien.Text);
                bus.UpdateCTHDN(cthdn);
                dataGridViewCTHDNH.DataSource = bus.HienThiCTHDNH("select LK.TenLK,CT.SoLuong,CT.DonGia,CT.KhuyenMai,CT.ThanhTien From CT_HoaDonNhapHang CT,LinhKien LK where LK.MaLK=CT.MaLK and CT.MaHDNH=N'" + txtMaHDN.Text + "' ");
                TongThanhToanMoi();
                hdn.MaHDNH = txtMaHDN.Text;
                hdn.NgayLapHDNH = dateTimePickerNgayLapHDN.Value.Date;
                hdn.TongTien =decimal.Parse(labelTongThanhToan.Text);
                bus.UpdateHDN(hdn);
                MessageBox.Show("Success");
                XuLyChucNang(true, false, false);
            }    
            HienThiHoaDonN();
        }

        public void HieThiHoaDonNhapTextBox(int vitri,DataTable d)
        { 
            try
            {
                txtMaHDN.Text = d.Rows[vitri]["MaHDNH"].ToString();
                comboBoxNCC.Text = d.Rows[vitri]["TenNCC"].ToString();
                comboBoxMaNV.Text = d.Rows[vitri]["TenNV"].ToString();
                dateTimePickerNgayLapHDN.Text = d.Rows[vitri]["NgayLapHDNH"].ToString();
                labelTongThanhToan.Text = d.Rows[vitri]["TongTien"].ToString();
                labelTongThanhToan.Text = string.Format("{0:#,##0}", decimal.Parse(labelTongThanhToan.Text));
                comboBoxTrangThai.Text = d.Rows[vitri]["TrangThai"].ToString();
                dataGridViewCTHDNH.DataSource = bus.HienThiCTHDNH("select LK.TenLK,CT.SoLuong,CT.DonGia,CT.KhuyenMai,CT.ThanhTien From CT_HoaDonNhapHang CT,LinhKien LK where LK.MaLK=CT.MaLK and CT.MaHDNH=N'"+txtMaHDN.Text+"' ");
            }
            catch
            {

            }
        }

        private void dataGridViewHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dataGridViewHDN.CurrentCell.RowIndex;
            HieThiHoaDonNhapTextBox(vitri,bus.HienThiHDN(""));
        }

        private void textBoxSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void textBoxDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void textBoxChietKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(KQ==DialogResult.OK)
            {
                cthdn.MaHDNH = txtMaHDN.Text;
                bus.DeleteCT_HoaDonNhap(cthdn);
                hdn.MaHDNH = txtMaHDN.Text;
                bus.DeleteHoaDonNhap(hdn);
                MessageBox.Show("Success");
                HienThiHoaDonN();
            }
            else
            {

            }    
        }

        private void dataGridViewCTHDNH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flag =2;
            DataGridViewRow row = dataGridViewCTHDNH.Rows[e.RowIndex];
            comboBoxTenLK.Text = row.Cells[0].Value.ToString();
            textBoxSoLuong.Text = row.Cells[1].Value.ToString();
            textBoxDonGia.Text = row.Cells[2].Value.ToString();
            textBoxDonGia.Text = string.Format("{0:#,##0}", decimal.Parse(textBoxDonGia.Text));
            textBoxChietKhau.Text = row.Cells[3].Value.ToString();
            labelThanhTien.Text = row.Cells[4].Value.ToString();
            labelThanhTien.Text = string.Format("{0:#,##0}", decimal.Parse(labelThanhTien.Text));
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            cthdn.MaHDNH = txtMaHDN.Text;
            cthdn.MaLK = comboBoxTenLK.SelectedValue.ToString();
            cthdn.SoLuong =int.Parse(textBoxSoLuong.Text);
            cthdn.DonGia = decimal.Parse(textBoxDonGia.Text);
            cthdn.KhuyenMai = decimal.Parse(textBoxChietKhau.Text);
            cthdn.ThanhTien = decimal.Parse(labelThanhTien.Text);
            bus.UpdateCTHDN(cthdn);
            MessageBox.Show("Success");
            dataGridViewCTHDNH.DataSource = bus.HienThiCTHDNH("select LK.TenLK,CT.SoLuong,CT.DonGia,CT.KhuyenMai,CT.ThanhTien From CT_HoaDonNhapHang CT,LinhKien LK where LK.MaLK=CT.MaLK and CT.MaHDNH=N'" + txtMaHDN.Text + "' ");
        }

        private void textBoxSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal KM = 0;
                decimal tt = 0;
                tongtien += tt;
                KM = decimal.Parse(textBoxChietKhau.Text);
                tt = decimal.Parse(textBoxDonGia.Text) * int.Parse(textBoxSoLuong.Text) - KM;
                tongtien += tt;
                labelThanhTien.Text = tt.ToString();
                labelThanhTien.Text = string.Format("{0:#,##0}", decimal.Parse(labelThanhTien.Text));
                //labelTongThanhToan.Text = tongtien.ToString();
                //labelTongThanhToan.Text = string.Format("{0:#,##0}", double.Parse(labelTongThanhToan.Text));
            }
            catch
            {

            }
        }

        private void btnCane_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn hủy hay không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(KQ==DialogResult.OK)
            {
                XuLyChucNang(true, false, false);
                ClearTexBox();
            }
            else
            {

            }    
        }
    }
}
