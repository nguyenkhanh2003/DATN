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

        public void HienThiNhanVien()
        {
            comboBoxMaNV.DataSource = bus.GetNhanVien("Select MaNV,TenNV From NhanVien");
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
        public void XuLyChucNang(Boolean b1, Boolean b2)
        {
            btnTaoPhieu.Enabled = b1;
            btnHuy.Enabled = b2;
            btnLuu.Enabled = b2;
            btnChon.Enabled = b2;
            btnInHoaDon.Enabled = b2;
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
            PhatSinhMa();
            flag = 1;
            XuLyChucNang(false, true);
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

            for (int i = 0; i < dataGridViewHDNH.Rows.Count - 1; i++)
            {
                if (comboBoxTenLK.Text == dataGridViewHDNH.Rows[i].Cells["TenLK"].Value.ToString())
                {
                    KiemTra = 1;
                    vitri = i;
                    break;
                }

            }

            if (KiemTra == 1)
            {
                int SL = int.Parse(textBoxSoLuong.Text) + int.Parse(dataGridViewHDNH.Rows[vitri].Cells["SoLuong"].Value.ToString());
                dataGridViewHDNH.Rows[vitri].Cells["SoLuong"].Value = SL.ToString();
                decimal ThanhTienMoi = tt + decimal.Parse(dataGridViewHDNH.Rows[vitri].Cells["ThanhTien"].Value.ToString());
                dataGridViewHDNH.Rows[vitri].Cells["ThanhTien"].Value = ThanhTienMoi.ToString();
                dataGridViewHDNH.Rows[vitri].Cells["ThanhTien"].Value = string.Format("{0:#,##0}", double.Parse(ThanhTienMoi.ToString()));
            }

            else
            {
                MaLK += comboBoxTenLK.SelectedValue.ToString() + ";";
                object[] t = { comboBoxTenLK.Text, textBoxSoLuong.Text, textBoxDonGia.Text, KM.ToString(), labelThanhTien.Text };
                dataGridViewHDNH.Rows.Add(t);
            }

        }

        private void Frm_HoaDonNhap_Load(object sender, EventArgs e)
        {
            HienThiNhanVien();
            HienThiSanPham();
            HienThiNCC();
            HienThiHoaDonN();
            XuLyChucNang(true, false);
        }

        private void dataGridViewHDNH_DoubleClick(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn xóa sản phẩm này không ?", "Thông Báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (KQ == DialogResult.Yes)
            {
                int rowIndex = dataGridViewHDNH.CurrentCell.RowIndex;
                dataGridViewHDNH.Rows.RemoveAt(rowIndex);
            }
            else
            {

            }    
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
                for (int i = 0; i < dataGridViewHDNH.Rows.Count - 1; i++)
                {
                    string malk = b[i];
                    //malk = dataGridViewHDNH.Rows[i].Cells[0].Value.ToString();
                    int soluong =int.Parse(dataGridViewHDNH.Rows[i].Cells[1].Value.ToString());
                    decimal dongia =decimal.Parse(dataGridViewHDNH.Rows[i].Cells[2].Value.ToString());
                    decimal khuyenmai =decimal.Parse(dataGridViewHDNH.Rows[i].Cells[3].Value.ToString());
                    decimal thanhtien =decimal.Parse(dataGridViewHDNH.Rows[i].Cells[4].Value.ToString());
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
        }

        private void dataGridViewHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewHDN.Rows[e.RowIndex];
            txtMaHDN.Text = row.Cells[0].Value.ToString();
            comboBoxNCC.Text = row.Cells[1].Value.ToString();
            comboBoxMaNV.Text = row.Cells[2].Value.ToString();
            dateTimePickerNgayLapHDN.Text = row.Cells[3].Value.ToString();
            labelTongThanhToan.Text = row.Cells[4].Value.ToString();
            labelTongThanhToan.Text= string.Format("{0:#,##0}", decimal.Parse(labelTongThanhToan.Text));
            comboBoxTrangThai.Text = row.Cells[5].Value.ToString();
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
    }
}
