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
        public void PhatSinhMa()
        {
            int count = 0;
            count = dataGridViewHDNH.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtMaHDN.Text = "PN00";
            }
            else
            {
                chuoi = Convert.ToString(dataGridViewHDNH.Rows[count - 2].Cells[0].Value);
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
        }

        double tongtien = 0;
        public string MaLK = "";
        private void btnChonNhap_Click(object sender, EventArgs e)
        {
            int KiemTra = 0;
            int vitri = 0;
            int KM = 0;
            int tt = 0;
            tongtien += tt;
            KM = int.Parse(textBoxChietKhau.Text);
            tt = Convert.ToInt32(textBoxDonGia.Text) * Convert.ToInt32(textBoxSoLuong.Text) - KM;
            tongtien += tt;
            labelThanhTien.Text = tt.ToString();
            String.Format("{0:#,##0.##}", (labelTongThanhToan.Text) = tongtien.ToString());

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
                int ThanhTienMoi = tt + int.Parse(dataGridViewHDNH.Rows[vitri].Cells["ThanhTien"].Value.ToString());
                dataGridViewHDNH.Rows[vitri].Cells["ThanhTien"].Value = ThanhTienMoi.ToString();
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
                hdn.TongTien = int.Parse(labelTongThanhToan.Text);
                hdn.TrangThai = comboBoxTrangThai.Text;
                bus.AddHoaDon(hdn);
                string[] b = MaLK.Split(';');
                for (int i = 0; i < dataGridViewHDNH.Rows.Count - 1; i++)
                {
                    string malk = b[i];
                    //malk = dataGridViewHDNH.Rows[i].Cells[0].Value.ToString();
                    int soluong =int.Parse(dataGridViewHDNH.Rows[i].Cells[1].Value.ToString());
                    int dongia =int.Parse(dataGridViewHDNH.Rows[i].Cells[2].Value.ToString());
                    int khuyenmai =int.Parse(dataGridViewHDNH.Rows[i].Cells[3].Value.ToString());
                    int thanhtien =int.Parse(dataGridViewHDNH.Rows[i].Cells[4].Value.ToString());
                    cthdn.MaHDNH = txtMaHDN.Text;
                    cthdn.MaLK = malk;
                    cthdn.SoLuong = soluong;
                    cthdn.DonGia = dongia;
                    cthdn.KhuyenMai = khuyenmai;
                    cthdn.ThanhTien = thanhtien;
                    cthdn.TrangThai = comboBoxTrangThai.Text;
                    bus.AddCTHD(cthdn);
                }

                MessageBox.Show("Tạo Hóa Đơn Thành Công ");
            }
        }
    }
}
