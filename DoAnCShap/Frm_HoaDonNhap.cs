using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        Frm_Setting frm_Setting = new Frm_Setting();
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

        public void HienThicTHDN()
        {
            dataGridViewCTHDN2.DataSource = bus.HienThiCTHDNH("select LK.TenLK,CT.SoLuong,CT.DonGia,CT.KhuyenMai,CT.ThanhTien From CT_HoaDonNhapHang CT,LinhKien LK where LK.MaLK=CT.MaLK and CT.MaHDNH=N'" + txtMaHDN.Text + "' ");
        }
        public void XuLyChucNang(Boolean b1, Boolean b2, Boolean b3, Boolean b4, Boolean b5)
        {
            btnTaoPhieu.Enabled = b1;
            btnCane.Enabled = b2;
            btnLuu.Enabled = b2;
            btnXoa.Enabled = b3;
            btnChon.Enabled = b4;
            btnInHoaDon.Enabled = b5;
        }

        public void XuLyTextBox(Boolean b1)
        {
            textBoxChietKhau.Enabled = b1;
            textBoxDonGia.Enabled = b1;
            textBoxSoLuong.Enabled = b1;
            labelThanhTien.Enabled = b1;
            labelTongThanhToan.Enabled = b1;
            txtMaHDN.Enabled = b1;
            comboBoxMaNV.Enabled = b1;
            comboBoxTenLK.Enabled = b1;
            comboBoxNCC.Enabled = b1;
            dateTimePickerNgayLapHDN.Enabled = b1;

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
            errorMes.Clear();
            dataGridViewCTHDNH.Rows.Clear();
            dataGridViewCTHDNH.Refresh();
        }

        public void HideDataGriview(Boolean b1, Boolean b2)
        {
            dataGridViewCTHDNH.Visible = b1;
            dataGridViewCTHDN2.Visible = b2;
        }

        public string PhatSinhMaHDN(DataTable d)
        {
            int sodong = d.Rows.Count;
            string macuoi;
            if (sodong > 9)
                macuoi = d.Rows[sodong - 1]["MaHDNH"].ToString().Substring(3, 2);
            else
                macuoi = d.Rows[sodong - 1]["MaHDNH"].ToString().Substring(4, 1);
            return (int.Parse(macuoi) + 1).ToString();
        }
        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            ClearTexBox();
            XuLyTextBox(true);
            HideDataGriview(true, false);
            if (dataGridViewHDN.Rows.Count <= 0)
            {
                txtMaHDN.Text = "HDN00";
            }
            else
            {
                if (int.Parse(PhatSinhMaHDN(bus.PhatSinhMa(""))) < 10)
                    txtMaHDN.Text = "HDN0" + PhatSinhMaHDN(bus.PhatSinhMa(""));
                else
                    txtMaHDN.Text = "HDN" + PhatSinhMaHDN(bus.PhatSinhMa(""));
            }
            flag = 1;
            XuLyChucNang(false, true, false, true, false);
        }

        public string MaLK = "";
        int SoLuongTon;
        int SoLuongConLai;

        public void TongTienSP()
        {
            decimal sum = 0;
            for (int i = 0; i < dataGridViewCTHDNH.Rows.Count; ++i)
            {
                sum += decimal.Parse(dataGridViewCTHDNH.Rows[i].Cells["ThanhTien"].Value.ToString());
            }
            labelTongThanhToan.Text = sum.ToString();
            labelTongThanhToan.Text = string.Format("{0:#,##0}", decimal.Parse(labelTongThanhToan.Text));
        }

        private void Add_Datagrid(string tenlk, int soluong, decimal dongia, decimal khuyenmai, decimal thanhtien, int soluongcuakho)
        {
            try
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridViewCTHDNH);
                newRow.Cells[1].Value = tenlk;
                newRow.Cells[2].Value = soluong;
                newRow.Cells[3].Value = dongia;
                newRow.Cells[4].Value = khuyenmai;
                newRow.Cells[5].Value = thanhtien;
                newRow.Cells[6].Value = soluongcuakho;
                dataGridViewCTHDNH.Rows.Add(newRow);
            }
            catch
            {

            }
        }
        private void btnChonNhap_Click(object sender, EventArgs e)
        {
            int KiemTra = 0;
            int vitri = 0;
            decimal KM = 0;
            decimal tt = 0;
            DataTable DSSP = bus.LayDSSP("select * From LinhKien Where TenLK=N'" + comboBoxTenLK.Text + "'");
            if (DSSP.Rows.Count > 0)
            {
                if (comboBoxTenLK.Text == DSSP.Rows[0]["TenLK"].ToString())
                {
                    SoLuongTon = int.Parse(DSSP.Rows[0]["SoLuongTon"].ToString());
                }
                SoLuongConLai = SoLuongTon + int.Parse(textBoxSoLuong.Text);
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
            if (textBoxChietKhau.Text == "")
            {
                textBoxChietKhau.Text = "0";
            }
            KM = decimal.Parse(textBoxChietKhau.Text);
            tt = decimal.Parse(textBoxDonGia.Text) * int.Parse(textBoxSoLuong.Text) - KM;
            labelThanhTien.Text = tt.ToString();
            labelThanhTien.Text = string.Format("{0:#,##0}", double.Parse(labelThanhTien.Text));


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
            }
            else
            {
                MaLK += comboBoxTenLK.SelectedValue.ToString() + ";";
                //object[] t = { comboBoxTenLK.Text, textBoxSoLuong.Text, textBoxDonGia.Text, KM.ToString(), labelThanhTien.Text, SoLuongConLai };
                //dataGridViewCTHDNH.Rows.Add(t);
                Add_Datagrid(comboBoxTenLK.Text, int.Parse(textBoxSoLuong.Text), decimal.Parse(textBoxDonGia.Text), decimal.Parse(KM.ToString()), decimal.Parse(labelThanhTien.Text), SoLuongConLai);
            }
            TongTienSP();
        }

        public void TongThanhToanMoi()
        {
            decimal TongThanhToan = 0;
            for (int i = 0; i < dataGridViewCTHDNH.Rows.Count - 0; i++)
            {
                TongThanhToan += decimal.Parse(dataGridViewCTHDNH.Rows[i].Cells["ThanhTien"].Value.ToString());
            }
            labelTongThanhToan.Text = TongThanhToan.ToString();
            labelTongThanhToan.Text = string.Format("{0:#,##0}", decimal.Parse(labelTongThanhToan.Text));
        }

        public void TongThanhToanCTHDN2()
        {
            decimal TongThanhToan = 0;
            for (int i = 0; i < dataGridViewCTHDN2.Rows.Count - 0; i++)
            {
                TongThanhToan += decimal.Parse(dataGridViewCTHDN2.Rows[i].Cells["ThanhTien1"].Value.ToString());
            }
            labelTongThanhToan.Text = TongThanhToan.ToString();
            labelTongThanhToan.Text = string.Format("{0:#,##0}", decimal.Parse(labelTongThanhToan.Text));
        }

        public void UpateThanhTienSP()
        {
            decimal ThanhTienSP;
            ThanhTienSP = decimal.Parse(textBoxDonGia.Text) * int.Parse(textBoxSoLuong.Text) - decimal.Parse(textBoxChietKhau.Text);
            labelThanhTien.Text = ThanhTienSP.ToString();
        }
        private void Frm_HoaDonNhap_Load(object sender, EventArgs e)
        {
            string condition = Login.SetValueForText1;
            HienThiNhanVien(condition);
            HienThiSanPham();
            HienThiNCC();
            HienThiHoaDonN();
            XuLyChucNang(true, false, false, false, false);
            comboBoxNCC.Text = "";
            XuLyTextBox(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                if (comboBoxNCC.Text == "")
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
                if (labelTongThanhToan.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(labelTongThanhToan, "? TT");
                    return;
                }
                else
                {
                    hdn.MaHDNH = txtMaHDN.Text;
                    hdn.MaNCC = comboBoxNCC.SelectedValue.ToString();
                    hdn.MaNV = comboBoxMaNV.SelectedValue.ToString();
                    hdn.NgayLapHDNH = dateTimePickerNgayLapHDN.Value.Date;
                    hdn.TongTien = decimal.Parse(labelTongThanhToan.Text);
                    hdn.TrangThai = "1";
                    bus.AddHoaDon(hdn);
                    string[] b = MaLK.Split(';');
                    for (int i = 0; i < dataGridViewCTHDNH.Rows.Count - 0; i++)
                    {
                        string malk = b[i];
                        int soluong = int.Parse(dataGridViewCTHDNH.Rows[i].Cells["SoLuong"].Value.ToString());
                        decimal dongia = decimal.Parse(dataGridViewCTHDNH.Rows[i].Cells["DonGia"].Value.ToString());
                        decimal khuyenmai = decimal.Parse(dataGridViewCTHDNH.Rows[i].Cells["KhuyenMai"].Value.ToString());
                        decimal thanhtien = decimal.Parse(dataGridViewCTHDNH.Rows[i].Cells["ThanhTien"].Value.ToString());
                        int SoLuongKho = int.Parse(dataGridViewCTHDNH.Rows[i].Cells["SLConLai"].Value.ToString());
                        cthdn.MaHDNH = txtMaHDN.Text;
                        cthdn.MaLK = malk;
                        cthdn.SoLuong = soluong;
                        cthdn.DonGia = dongia;
                        cthdn.KhuyenMai = khuyenmai;
                        cthdn.ThanhTien = thanhtien;
                        cthdn.TrangThai = "1";
                        LK.MaLK = malk;
                        LK.SoLuongTon = SoLuongKho;
                        bus.CapNhatSLKho(LK);
                        bus.AddCTHD(cthdn);
                    }
                    MessageBox.Show("Tạo Hóa Đơn Thành Công ");
                    XuLyChucNang(true, false, false, false, false);
                    ClearTexBox();
                }
            }
            if (flag == 2)
            {
                UpateThanhTienSP();
                cthdn.MaHDNH = txtMaHDN.Text;
                cthdn.MaLK = comboBoxTenLK.SelectedValue.ToString();
                cthdn.SoLuong = int.Parse(textBoxSoLuong.Text);
                cthdn.DonGia = decimal.Parse(textBoxDonGia.Text);
                cthdn.KhuyenMai = decimal.Parse(textBoxChietKhau.Text);
                cthdn.ThanhTien = decimal.Parse(labelThanhTien.Text);
                bus.UpdateCTHDN(cthdn);
                HienThicTHDN();
                TongThanhToanCTHDN2();
                hdn.MaHDNH = txtMaHDN.Text;
                hdn.NgayLapHDNH = dateTimePickerNgayLapHDN.Value.Date;
                hdn.TongTien = decimal.Parse(labelTongThanhToan.Text);
                bus.UpdateHDN(hdn);
                MessageBox.Show("Success");
                XuLyChucNang(true, false, false, false, false);
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
                HienThicTHDN();
            }
            catch
            {

            }
        }

        private void dataGridViewHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HideDataGriview(false, true);
            int vitri = dataGridViewHDN.CurrentCell.RowIndex;
            HieThiHoaDonNhapTextBox(vitri, bus.HienThiHDN(""));
            flag = 1;
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
                if (flag == 1)
                {
                    hdn.MaHDNH = txtMaHDN.Text;
                    bus.DeleteHoaDonNhap(hdn);
                    MessageBox.Show("Thành Công");
                    HienThiHoaDonN();
                    XuLyChucNang(true, false, false, false, false);
                    ClearTexBox();
                    HideDataGriview(true, false);
                }
                if (flag == 2)
                {
                    cthdn.MaHDNH = txtMaHDN.Text;
                    cthdn.MaLK = comboBoxTenLK.SelectedValue.ToString();
                    bus.DeleteCT_HoaDonNhap(cthdn);
                    MessageBox.Show("Thành Công");
                    TongTienSP();
                }
            }
            else
            {

            }
        }

        private void dataGridViewCTHDNH_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void btnCane_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn hủy hay không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (KQ == DialogResult.OK)
            {
                XuLyChucNang(true, false, false, false, false);
                ClearTexBox();
            }
            else
            {

            }
        }

        private void dataGridViewHDN_DoubleClick(object sender, EventArgs e)
        {
            XuLyChucNang(false, true, true, false, true);
            XuLyTextBox(true);
        }

        private void dataGridViewHDN_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewHDN.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string condition = txtSearch.Text;
            HienThiLK(condition);
        }

        public class HoaDonNhap
        {
            public int STT { get; set; }
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
            public DateTime NgayLap { get; set; }
            public string MaHD { get; set; }
        }

        Frm_PrintHD frm_in = new Frm_PrintHD();
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            List<HoaDonNhap> lst = new List<HoaDonNhap>();
            lst.Clear();
            for (int i = 0; i < dataGridViewCTHDN2.Rows.Count - 0; i++)
            {
                HoaDonNhap hoaDonNhap = new HoaDonNhap
                {
                    TenSP = dataGridViewCTHDN2.Rows[i].Cells["TenLK1"].Value.ToString(),
                    SoLuong = int.Parse(dataGridViewCTHDN2.Rows[i].Cells["SoLuong1"].Value.ToString()),
                    DonGia = decimal.Parse(dataGridViewCTHDN2.Rows[i].Cells["DonGia1"].Value.ToString()),
                    KhuyenMai = decimal.Parse(dataGridViewCTHDN2.Rows[i].Cells["KhuyenMai1"].Value.ToString()),
                    ThanhTien = decimal.Parse(dataGridViewCTHDN2.Rows[i].Cells["ThanhTien1"].Value.ToString()),
                    TongThanhToan = decimal.Parse(labelTongThanhToan.Text),
                    TenNCC = comboBoxNCC.Text,
                    TenNV = comboBoxMaNV.Text,
                    NgayLap = dateTimePickerNgayLapHDN.Value,
                    MaHD = txtMaHDN.Text,
                };
                lst.Add(hoaDonNhap);
            }
            rss.Name = "DataSet2";
            rss.Value = lst;
            frm_in.reportViewer1.LocalReport.DataSources.Clear();
            frm_in.reportViewer1.LocalReport.DataSources.Add(rss);
            frm_in.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnCShap.ReportHDN.rdlc";
            //ReportParameter[] parms = new ReportParameter[1];
            //parms[0] = new ReportParameter("Parameter1", frm_Setting.txtSDT.Text, true);
            //this.frm_in.reportViewer1.LocalReport.SetParameters(parms);
            Microsoft.Reporting.WinForms.ReportParameter[] reportParameters = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("Parameter1",frm_Setting.txtSDT.Text,true),
                new Microsoft.Reporting.WinForms.ReportParameter("ParameterWebSite",frm_Setting.txtWebSite.Text,true),
                 new Microsoft.Reporting.WinForms.ReportParameter("ParameterHotline",frm_Setting.txtHotLine.Text,true),
                  new Microsoft.Reporting.WinForms.ReportParameter("ParameterDiaChi",frm_Setting.txtDiaChi.Text,true),
            };
            frm_in.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.frm_in.reportViewer1.RefreshReport();
            frm_in.ShowDialog();
        }

        private void dataGridViewCTHDNH_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewCTHDNH.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridViewCTHDNH2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewCTHDN2.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridViewCTHDNH_DoubleClick(object sender, EventArgs e)
        {
            XuLyChucNang(false, true, true, false, true);
        }

        private void dataGridViewCTHDN2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 2;
            try
            {
                DataGridViewRow row = dataGridViewCTHDN2.Rows[e.RowIndex];
                comboBoxTenLK.Text = row.Cells["TenLK1"].Value.ToString();
                textBoxSoLuong.Text = row.Cells["SoLuong1"].Value.ToString();
                textBoxDonGia.Text = row.Cells["DonGia1"].Value.ToString();
                textBoxDonGia.Text = string.Format("{0:#,##0}", decimal.Parse(textBoxDonGia.Text));
                textBoxChietKhau.Text = row.Cells["KhuyenMai1"].Value.ToString();
                labelThanhTien.Text = row.Cells["ThanhTien1"].Value.ToString();
                labelThanhTien.Text = string.Format("{0:#,##0}", decimal.Parse(labelThanhTien.Text));
            }
            catch
            {

            }
        }

        private void dataGridViewCTHDN2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxTenLK_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBoxChietKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
