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
using Microsoft.Reporting.WinForms;

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
        LinhKien_BUS lk = new LinhKien_BUS();
        LinhKien LK = new LinhKien();
        ReportDataSource rss = new ReportDataSource();
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

        public void HienThiCTHD()
        {
            dataGridViewCTHDNH.DataSource = bus.HienThiCTHDNH("select LK.TenLK,CT.SoLuong,CT.DonGia,CT.KhuyenMai,CT.ThanhTien From CT_HoaDonNhapHang CT,LinhKien LK where LK.MaLK=CT.MaLK and CT.MaHDNH=N'" + txtMaHDN.Text + "' ");
        }
        public void HienThiLK(string condition)
        {
            comboBoxTenLK.DataSource = lk.GetSearch("Select MaLK,TenLK From LinhKien Where TenLK Like N'%" + condition + "%'");
            comboBoxTenLK.DisplayMember = "TenLK";
            comboBoxTenLK.ValueMember = "MaLK";
        }
        public void XuLyChucNang(Boolean b1, Boolean b2, Boolean b3,Boolean b4)
        {
            btnTaoPhieu.Enabled = b1;
            btnChon.Enabled = b4;
            btnCane.Enabled = b2;
            btnLuu.Enabled = b2;
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
            comboBoxTrangThai.ResetText();
            errorMes.Clear();
        }
        public void PhatSinhMa()
        {
            int count = 0;
            count = dataGridViewHDN.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 0)
            {
                txtMaHDN.Text = "PN00";
            }
            else
            {
                chuoi = Convert.ToString(dataGridViewHDN.Rows[count - 1].Cells[1].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0,3)));
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
            XuLyChucNang(false, true, false,true);
        }

        decimal tongtien = 0;
        public string MaLK = "";
        int SoLuongTon;
        int SoLuongConLai= 0;
        private void btnChonNhap_Click(object sender, EventArgs e)
        {
            int KiemTra = 0;
            int vitri = 0;
            decimal KM = 0;
            decimal tt = 0;
            DataTable DSSP = bus.LayDSSP("select * From LinhKien Where TenLK=N'" + comboBoxTenLK.Text + "'");
            if(DSSP.Rows.Count>0)
            {
                if(comboBoxTenLK.Text==DSSP.Rows[0]["TenLK"].ToString())
                {
                    SoLuongTon = int.Parse(DSSP.Rows[0]["SoLuong"].ToString());
                }    
            }    
            if (textBoxSoLuong.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(textBoxSoLuong, "Chưa nhập số lượng");
                return;
            }
            if (textBoxDonGia.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(textBoxDonGia, "Chưa nhập đơn giá");
                return;
            }
            if(textBoxChietKhau.Text=="")
            {
                textBoxChietKhau.Text = "0";
            }
            tongtien += tt;
            KM = decimal.Parse(textBoxChietKhau.Text);
            tt = decimal.Parse(textBoxDonGia.Text) * int.Parse(textBoxSoLuong.Text) - KM;
            tongtien += tt;
            labelThanhTien.Text = tt.ToString();
            labelThanhTien.Text = string.Format("{0:#,##0}", double.Parse(labelThanhTien.Text));
            labelTongThanhToan.Text = tongtien.ToString();
            labelTongThanhToan.Text = string.Format("{0:#,##0}", double.Parse(labelTongThanhToan.Text));
            SoLuongConLai = SoLuongTon + int.Parse(textBoxSoLuong.Text);
            for (int i = 0; i < dataGridViewCTHDNH.Rows.Count - 0; i++)
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
                int SLTonMoi = int.Parse(dataGridViewCTHDNH.Rows[vitri].Cells["SLConLai"].Value.ToString()) + int.Parse(textBoxSoLuong.Text);
                dataGridViewCTHDNH.Rows[vitri].Cells["SLConLai"].Value = SLTonMoi.ToString();
                decimal ThanhTienMoi = tt + decimal.Parse(dataGridViewCTHDNH.Rows[vitri].Cells["ThanhTien"].Value.ToString());
                dataGridViewCTHDNH.Rows[vitri].Cells["ThanhTien"].Value = ThanhTienMoi.ToString();
                dataGridViewCTHDNH.Rows[vitri].Cells["ThanhTien"].Value = string.Format("{0:#,##0}", double.Parse(ThanhTienMoi.ToString()));
            }

            else
            {
                MaLK += comboBoxTenLK.SelectedValue.ToString() + ";";
                object[] t = { comboBoxTenLK.Text, textBoxSoLuong.Text, textBoxDonGia.Text, KM.ToString(), labelThanhTien.Text,SoLuongConLai};
                dataGridViewCTHDNH.Rows.Add(t);
            }

        }

        public void TongThanhToanMoi()
        {
            decimal TongThanhToan = 0;
            for (int i = 0; i < dataGridViewCTHDNH.Rows.Count - 0; i++)
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
            XuLyChucNang(true, false, false,false);
            comboBoxNCC.Text = "";
        }

        private void dataGridViewHDNH_DoubleClick(object sender, EventArgs e)
        {
            XuLyChucNang(false, true, true,false);
            DialogResult KQ = MessageBox.Show("Xóa SP Này ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (KQ == DialogResult.OK)
            {
                cthdn.MaHDNH = txtMaHDN.Text;
                cthdn.MaLK = comboBoxTenLK.SelectedValue.ToString();
                bus.XoaCTHoaDonNhap(cthdn);
                HienThiCTHD();
                TongThanhToanMoi();
            }
            else
            {

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                if(comboBoxNCC.Text=="")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(comboBoxNCC, "Chưa chọn nhà cung cấp");
                    return;
                }
                if (comboBoxMaNV.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(comboBoxMaNV, "Tên Nhân Viên Không được để trống");
                    return;
                }
                else
                {
                    hdn.MaHDNH = txtMaHDN.Text;
                    hdn.MaNCC = comboBoxNCC.SelectedValue.ToString();
                    hdn.MaNV = comboBoxMaNV.SelectedValue.ToString();
                    hdn.NgayLapHDNH = dateTimePickerNgayLapHDN.Value.Date;
                    hdn.TongTien = decimal.Parse(labelTongThanhToan.Text);
                    hdn.TrangThai = comboBoxTrangThai.Text;
                    bus.AddHoaDon(hdn);
                    string[] b = MaLK.Split(';');
                    for (int i = 0; i < dataGridViewCTHDNH.Rows.Count - 0; i++)
                    {
                        string malk = b[i];
                        //malk = dataGridViewHDNH.Rows[i].Cells[0].Value.ToString();
                        int soluong = int.Parse(dataGridViewCTHDNH.Rows[i].Cells[1].Value.ToString());
                        decimal dongia = decimal.Parse(dataGridViewCTHDNH.Rows[i].Cells[2].Value.ToString());
                        decimal khuyenmai = decimal.Parse(dataGridViewCTHDNH.Rows[i].Cells[3].Value.ToString());
                        decimal thanhtien = decimal.Parse(dataGridViewCTHDNH.Rows[i].Cells[4].Value.ToString());
                        int SoLuongKho = int.Parse(dataGridViewCTHDNH.Rows[i].Cells[5].Value.ToString());
                        cthdn.MaHDNH = txtMaHDN.Text;
                        cthdn.MaLK = malk;
                        cthdn.SoLuong = soluong;
                        cthdn.DonGia = dongia;
                        cthdn.KhuyenMai = khuyenmai;
                        cthdn.ThanhTien = thanhtien;
                        cthdn.TrangThai = comboBoxTrangThai.Text;
                        LK.MaLK = malk;
                        LK.SoLuong = SoLuongKho;
                        bus.CapNhatSLKho(LK);
                        bus.AddCTHD(cthdn);
                    }
                    MessageBox.Show("Tạo Hóa Đơn Thành Công ");
                    XuLyChucNang(true, false, false, false);
                    ClearTexBox();
                }
            }
            if (flag == 2)
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
                hdn.TongTien = decimal.Parse(labelTongThanhToan.Text);
                bus.UpdateHDN(hdn);
                MessageBox.Show("Success");
                XuLyChucNang(true, false, false,false);
                ClearTexBox();
            }
            HienThiHoaDonN();
        }

        public void HieThiHoaDonNhapTextBox(int vitri, DataTable d)
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
                dataGridViewCTHDNH.DataSource = bus.HienThiCTHDNH("select LK.TenLK,CT.SoLuong,CT.DonGia,CT.KhuyenMai,CT.ThanhTien From CT_HoaDonNhapHang CT,LinhKien LK where LK.MaLK=CT.MaLK and CT.MaHDNH=N'" + txtMaHDN.Text + "' ");
            }
            catch
            {

            }
        }

        private void dataGridViewHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dataGridViewHDN.CurrentCell.RowIndex;
            HieThiHoaDonNhapTextBox(vitri, bus.HienThiHDN(""));
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
            if (KQ == DialogResult.OK)
            {
                cthdn.MaHDNH = txtMaHDN.Text;
                bus.DeleteCT_HoaDonNhap(cthdn);
                hdn.MaHDNH = txtMaHDN.Text;
                bus.DeleteHoaDonNhap(hdn);
                MessageBox.Show("Success");
                HienThiHoaDonN();
                ClearTexBox();
                dataGridViewCTHDNH.DataSource = null;
                XuLyChucNang(true, false, false,false);
            }
            else
            {

            }
        }

        private void dataGridViewCTHDNH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 2;
            DataGridViewRow row = dataGridViewCTHDNH.Rows[e.RowIndex];
            comboBoxTenLK.Text = row.Cells[1].Value.ToString();
            textBoxSoLuong.Text = row.Cells[2].Value.ToString();
            textBoxDonGia.Text = row.Cells[3].Value.ToString();
            textBoxDonGia.Text = string.Format("{0:#,##0}", decimal.Parse(textBoxDonGia.Text));
            textBoxChietKhau.Text = row.Cells[4].Value.ToString();
            labelThanhTien.Text = row.Cells[5].Value.ToString();
            labelThanhTien.Text = string.Format("{0:#,##0}", decimal.Parse(labelThanhTien.Text));
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            cthdn.MaHDNH = txtMaHDN.Text;
            cthdn.MaLK = comboBoxTenLK.SelectedValue.ToString();
            cthdn.SoLuong = int.Parse(textBoxSoLuong.Text);
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
            if (KQ == DialogResult.OK)
            {
                XuLyChucNang(true, false, false,false);
                ClearTexBox();
            }
            else
            {

            }
        }

        private void dataGridViewHDN_DoubleClick(object sender, EventArgs e)
        {
            XuLyChucNang(false, true, true,false);
        }

        private void dataGridViewHDN_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridViewHDN.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string condition = txtSearch.Text;
            HienThiLK(condition);
        }

        public class HoaDonNhap
        {
            public string TenSP { get; set; }
            public int SoLuong { get; set; }
            public decimal DonGia { get; set; }
            public decimal KhuyenMai { get; set; }
            public decimal ThanhTien { get; set; }
            public decimal TongThanhToan { get; set; }
            public string TenNCC { get; set; }
            public string DiaChi { get; set; }
            public string DienThoai { get; set; }
            public string TenNV { get; set; }
            public string NgayLap { get; set; }
            public string MaHD { get; set; }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            List<HoaDonNhap> lst = new List<HoaDonNhap>();
            lst.Clear();
            for(int i=0;i<dataGridViewCTHDNH.Rows.Count-0;i++)
            {
                HoaDonNhap hoaDonNhap = new HoaDonNhap
                {
                    TenSP = dataGridViewCTHDNH.Rows[i].Cells[1].Value.ToString(),
                    SoLuong = int.Parse(dataGridViewCTHDNH.Rows[i].Cells[2].Value.ToString()),
                    DonGia = decimal.Parse(dataGridViewCTHDNH.Rows[i].Cells[3].Value.ToString()),
                    KhuyenMai = decimal.Parse(dataGridViewCTHDNH.Rows[i].Cells[4].Value.ToString()),
                    ThanhTien = decimal.Parse(dataGridViewCTHDNH.Rows[i].Cells[5].Value.ToString()),
                    TongThanhToan = decimal.Parse(labelTongThanhToan.Text),
                    TenNCC = comboBoxNCC.Text,
                    TenNV = comboBoxMaNV.Text,
                    NgayLap = dateTimePickerNgayLapHDN.Text,
                    MaHD = txtMaHDN.Text
                };
                lst.Add(hoaDonNhap);
            }
            rss.Name = "DataSet2";
            rss.Value = lst;
            Frm_PrintHD frm_in = new Frm_PrintHD();
            frm_in.reportViewer1.LocalReport.DataSources.Clear();
            frm_in.reportViewer1.LocalReport.DataSources.Add(rss);
            frm_in.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnCShap.ReportHDN.rdlc";
            frm_in.ShowDialog();
        }

        private void textBoxDonGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxDonGia.Text = string.Format("{##0,0:#}", decimal.Parse(textBoxDonGia.Text));
            }
            catch
            {

            }
        }
    }
}
