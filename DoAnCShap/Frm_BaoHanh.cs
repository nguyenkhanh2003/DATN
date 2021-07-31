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

        public void XuLyChucNang(Boolean b1, Boolean b2, Boolean b3, Boolean b4)
        {
            btnThem.Enabled = b1;
            btnHuy.Enabled = b2;
            btnThemSP.Enabled = b4;
            btnLuu.Enabled = b2;
            btnXoa.Enabled = b2;
            btnIn.Enabled = b3;
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

        public void HienThiDSKH()
        {
            cboKhachHang.DataSource = bus.DanhSachKH("");
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
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
        private void Frm_BaoHanh_Load(object sender, EventArgs e)
        {
            HienThiDSPhieu();
            ClearTextBoxPBH();
            ClearTextBoxCTPBH();
            HienThiLK();
            HienThiDSKH();
            XuLyChucNang(true, false, false, false);
            string condition = Login.SetValueForText1;
            HienThiNhanVien(condition);
        }

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            XuLyChucNang(false, true, false, true);
            if ((bus.PhatSinhMa("").Rows.Count == 0))
            {
                txtMaPhieu.Text = "PBH00";
            }
            else
            {
                if (int.Parse(PhatSinhMaPBH(bus.PhatSinhMa(""))) < 10)
                { txtMaPhieu.Text = "PBH0" + PhatSinhMaPBH(bus.PhatSinhMa("")); }

                else
                { txtMaPhieu.Text = "PBH" + PhatSinhMaPBH(bus.PhatSinhMa("")); }
            }

        }

        string MaLK = "";

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            int KiemTra = 0;
            if (comboBoxlK.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(comboBoxlK, "? Chưa chọn tên linh kiện");
                return;
            }
            if (txtSL.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtSL, "Số lượng không được để trống");
                return;
            }
            if (txtGhiChu.Text == "")
            {
                MessageBox.Show("? Ghi Chú");
                return;
            }
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

                if (txtMaPhieu.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtMaPhieu, "? Mã Phiếu");
                    return;
                }
                if (comboBoxNV.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(comboBoxNV, "? Tên Nhân Viên");
                    return;
                }
                else
                {
                    pbh.MaPBH = txtMaPhieu.Text;
                    pbh.MaKH = cboKhachHang.SelectedValue.ToString();
                    pbh.MaNV = comboBoxNV.SelectedValue.ToString();
                    pbh.NgayLap = dateTimePickerNgaLap.Value.Date;
                    pbh.NgayLayHang = dateTimePickerNgayLayHang.Value.Date;
                    pbh.TrangThai = "1";
                    bus.ThemPBH(pbh);
                    string[] b = MaLK.Split(';');
                    for (int i = 0; i < dataGridViewCTPBH.Rows.Count - 0; i++)
                    {
                        string tenlk = dataGridViewCTPBH.Rows[i].Cells[0].Value.ToString();
                        int soluong = int.Parse(dataGridViewCTPBH.Rows[i].Cells[1].Value.ToString());
                        string ghichu = dataGridViewCTPBH.Rows[i].Cells[2].Value.ToString();
                        ctpbh.MaPBH = txtMaPhieu.Text;
                        ctpbh.TenLK = tenlk;
                        ctpbh.SoLuong = soluong;
                        ctpbh.GhiChu = ghichu;
                        bus.ThemCTPhieuBH(ctpbh);
                    }
                    MessageBox.Show("Thành Công", "Thông Báo");
                    ClearTextBoxPBH();
                    ClearTextBoxCTPBH();
                    XuLyChucNang(true, false, false, false);
                }
            }
            if (flag == 2)
            {
                ctpbh.MaPBH = txtMaPhieu.Text;
                ctpbh.TenLK = comboBoxlK.Text;
                ctpbh.SoLuong = int.Parse(txtSL.Text);
                ctpbh.GhiChu = txtGhiChu.Text;
                bus.Update_CTPBH(ctpbh);
                pbh.MaPBH = txtMaPhieu.Text;
                bus.Update_PBH(pbh);
                MessageBox.Show("Success");
            }
            HienThiDSPhieu();
            ClearTextBoxPBH();
            ClearTextBoxCTPBH();
            XuLyChucNang(true, false, false, false);
        }

        public void HienThiPhieuBHTextBox(int vitri, DataTable d)
        {
            try
            {
                txtMaPhieu.Text = d.Rows[vitri]["MaPBH"].ToString();
                comboBoxNV.Text = d.Rows[vitri]["TenNV"].ToString();
                dateTimePickerNgaLap.Text = d.Rows[vitri]["NgayLapPhieu"].ToString();
                dateTimePickerNgayLayHang.Text = d.Rows[vitri]["NgayLayHang"].ToString();
                dataGridViewCTPBH.DataSource = bus.LoadCT_PhieuTheoMa("select TenLK,SoLuong,GhiChu From CT_PhieuBaoHanh Where MaPBH=N'" + txtMaPhieu.Text + "'");
            }
            catch
            {

            }
        }
        private void dataGridViewPBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dataGridViewPBH.CurrentCell.RowIndex;
            HienThiPhieuBHTextBox(vitri, bus.GetPBH(""));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn Có Muốn Xóa Hau Không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (KQ == DialogResult.OK)
            {
                if (flag == 1)
                {
                    pbh.MaPBH = txtMaPhieu.Text;
                    bus.XoaPhieuBaoHanh(pbh);
                    MessageBox.Show("Thành Công");
                    HienThiDSPhieu();
                }
                if (flag == 2)
                {
                    ctpbh.MaPBH = txtMaPhieu.Text;
                    ctpbh.TenLK = comboBoxlK.Text;
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
            XuLyChucNang(false, true, false, false);
        }

        private void dataGridViewCTPBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewCTPBH.Rows[e.RowIndex];
            comboBoxlK.Text = row.Cells[0].Value.ToString();
            txtSL.Text = row.Cells[1].Value.ToString();
            txtGhiChu.Text = row.Cells[2].Value.ToString();
            flag = 2;
            btnThemSP.Enabled = false;
        }

        private void dataGridViewPBH_DoubleClick(object sender, EventArgs e)
        {
            XuLyChucNang(false, true, true, false);

            flag = 1;
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (KQ == DialogResult.OK)
            {
                ctpbh.MaPBH = txtMaPhieu.Text;
                ctpbh.TenLK = comboBoxlK.Text;
                bus.XoaCTPhieuBaoHanh(ctpbh);
                MessageBox.Show("Success");
                dataGridViewCTPBH.DataSource = bus.LoadCT_PhieuTheoMa("select LK.TenLK,CT.SoLuong,CT.GhiChu From CT_PhieuBaoHanh CT , LinhKien LK Where LK.MaLK=CT.MaLK and MaPBH=N'" + txtMaPhieu.Text + "'");
                ClearTextBoxCTPBH();
                XuLyChucNang(true, false, false, false);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewPBH_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewPBH.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        string SoDienThoai = "";
        private void btnIn_Click(object sender, EventArgs e)
        {

            DataTable TTKH = bus.LayTTKH("Select * From KhachHang Where MaKH=N'" + cboKhachHang.SelectedValue.ToString() + "'");
            if (TTKH.Rows.Count > 0)
            {
                if (cboKhachHang.SelectedValue.ToString() == TTKH.Rows[0]["MaKH"].ToString())
                {
                    SoDienThoai = TTKH.Rows[0]["DienThoai"].ToString();
                }
            }

            List<PbaoHanh> lst = new List<PbaoHanh>();
            lst.Clear();
            for (int i = 0; i < dataGridViewCTPBH.Rows.Count - 0; i++)
            {
                PbaoHanh pbaoHanh = new PbaoHanh
                {
                    MaPhieuBH = txtMaPhieu.Text,
                    TenNV = comboBoxNV.Text,
                    NgayLap = dateTimePickerNgaLap.Text,
                    NgayLay = dateTimePickerNgayLayHang.Text,
                    TenLK = dataGridViewCTPBH.Rows[i].Cells[0].Value.ToString(),
                    SoLuong = int.Parse(dataGridViewCTPBH.Rows[i].Cells[1].Value.ToString()),
                    GhiChu = dataGridViewCTPBH.Rows[i].Cells[2].Value.ToString(),
                    TenKH = cboKhachHang.Text,
                    SDT = SoDienThoai,
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
            public string TenKH { get; set; }
            public string SDT { get; set; }
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn hủy hay không", "Thông Bán", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (KQ == DialogResult.OK)
            {
                XuLyChucNang(true, false, false, false);
                ClearTextBoxCTPBH();
                ClearTextBoxPBH();
            }
            else
            {

            }

        }
    }
}
