using System;
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
using Dapper;
using Microsoft.Reporting.WinForms;
using System.Globalization;

namespace DoAnCShap
{
    public partial class Frm_BanHan : Form
    {
        public Frm_BanHan()
        {
            InitializeComponent();

        }

        Frm_KH kh = new Frm_KH();
        Frm_SanPham sp = new Frm_SanPham();
        Frm_HoaDonBanHang f = new Frm_HoaDonBanHang();
        BanHang_BUS bus = new BanHang_BUS();
        HoaDonBanHang hdbh = new HoaDonBanHang();
        LinhKien lk = new LinhKien();
        CT_HoaDonBanHang cthdbh = new CT_HoaDonBanHang();
        KhachHang AddKH = new KhachHang();

        Form1 f1 = new Form1();
        string MaLK = "";
        ReportDataSource rs = new ReportDataSource();
        public void HienThiSanPham()
        {
            comboBoxSP.DataSource = bus.GetData("");
            comboBoxSP.DisplayMember = "TenLK";
            comboBoxSP.ValueMember = "MaLK";
        }

        public void HienThiNhanVien(string labelHienTenDN)
        {
            comboBoxNV.DataSource = bus.GetNhanVien("Select MaNV,TenNV From NhanVien Where UserName=N'" + labelHienTenDN + "'");
            comboBoxNV.DisplayMember = "TenNV";
            comboBoxNV.ValueMember = "MaNV";
        }

        public void HienThiTimKiem(string condition)
        {
            comboBoxSP.DataSource = bus.GetTimKiem("select TenLK From LinhKien Where TenLK Like N'%" + condition + "%'");
        }

        public void HienThiDSSTheoMaSP(string condition)
        {
            dataGridViewHDBH.DataSource = bus.GetHienThiDSSpTheoMa("select LK.TenLK,CT.SoLuong,CT.DonGia,KhuyenMai,ThanhTien From CT_HoaDonBanHang CT, LinhKien LK Where LK.MaLK=CT.MaLK and MaHDBH=N'" + condition + "'");
        }
        public void XuLyChucNang(Boolean b1, Boolean b2)
        {
            btnThemHD.Enabled = b1;
            btnThenKH.Enabled = b2;
            btnChonMua.Enabled = b2;
            btnLuuHd.Enabled = b2;
            btnHuy.Enabled = b2;
            btnTimKH.Enabled = b2;
        }

        public void XuLyTextBox(Boolean b1, Boolean b2)
        {
            txtMaHD.Enabled = b2;
            comboBoxNV.Enabled = b2;
            txtMaKH.Enabled = b2;
            NumreicSL.Enabled = b2;
            txtKhuyenMai.Enabled = b2;
            txtDonGia.Enabled = b2;
            comboBoxSP.Enabled = b2;
            txtTenkH.Enabled = b2;
            txtDiaChi.Enabled = b2;
            txtSDT.Enabled = b2;
            dateTimePickerNgayLap.Enabled = b2;
            comboTrangThai.Enabled = b2;
        }
        public void ClearTextBox()
        {
            txtMaHD.ResetText();
            comboBoxNV.ResetText();
            comboBoxSP.ResetText();
            comboTrangThai.ResetText();
            txtSDT.ResetText();
            txtMaKH.ResetText();
            txtTenkH.ResetText();
            txtDiaChi.ResetText();
            txtDonGia.ResetText();
            txtKhuyenMai.ResetText();
            labelThanhTien.ResetText();
            labelTongThanhToan.ResetText();
            txtTienKhachDua.ResetText();
            labelThoiLaiKhach.ResetText();
            dataGridViewHDBH.Rows.Clear();
            dataGridViewHDBH.Refresh();
            errorMes.Clear();
        }

        public void PhatSinhMaHD()
        {
            int count = 0;
            count = f.dataGridViewHD.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 0)
            {
                txtMaHD.Text = "HD00";
            }
            else
            {
                chuoi = Convert.ToString(f.dataGridViewHD.Rows[count - 1].Cells[1].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0,2)));
                if (chuoi2 + 1 < 10)
                    txtMaHD.Text = "HD0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtMaHD.Text = "HD" + (chuoi2 + 1).ToString();
            }
        }

        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
            HienThiSanPham();

        }

        public static string SetValueForText3 = "";

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int SoLuongTon;
        int SoluongConLai=0;
        private void comboBoxSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable DSSP = bus.GetDSSP("Select * From LinhKien Where TenLK=N'" + comboBoxSP.Text + "'");
                if (DSSP.Rows.Count > 0)
                {
                    if (comboBoxSP.Text == DSSP.Rows[0]["TenLK"].ToString())
                    {
                        if (int.Parse(DSSP.Rows[0]["SoLuong"].ToString()) == 0)
                        {
                            MessageBox.Show("Sản Phẩm Này Đã Hết Hàng");
                        }
                        else
                        {
                            txtDonGia.Text = DSSP.Rows[0]["DonGia"].ToString();
                            txtDonGia.Text = string.Format("{0:#,##0}", double.Parse(txtDonGia.Text));
                            txtKhuyenMai.Text = DSSP.Rows[0]["KhuyenMai"].ToString();
                            txtKhuyenMai.Text = string.Format("{0:#,##0}", double.Parse(txtKhuyenMai.Text));
                            NumreicSL.Value = 1;
                            SoLuongTon = int.Parse(DSSP.Rows[0]["SoLuong"].ToString());
                        }
                    }
                }
            }
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable DSKH = bus.GetDSkH("Select * From KhachHang Where DienThoai=N'" + txtSDT.Text + "'");
                if (DSKH.Rows.Count > 0)
                {
                    if (txtSDT.Text == DSKH.Rows[0]["DienThoai"].ToString())
                    {
                        txtTenkH.Text = DSKH.Rows[0]["TenKH"].ToString();
                        txtDiaChi.Text = DSKH.Rows[0]["DiaChi"].ToString();
                        txtMaKH.Text = DSKH.Rows[0]["MaKH"].ToString();
                    }

                }
            }
        }

        int flag = 0;

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            PhatSinhMaHD();
            flag = 1;
            XuLyChucNang(false, true);
            XuLyTextBox(false, true);
        }

        public void TongTienSP()
        {
            decimal sum = 0;
            for (int i = 0; i < dataGridViewHDBH.Rows.Count; ++i)
            {
                sum += decimal.Parse(dataGridViewHDBH.Rows[i].Cells["ThanhTien"].Value.ToString());
            }
            labelTongThanhToan.Text = sum.ToString();
            labelTongThanhToan.Text = string.Format("{0:#,##0}", decimal.Parse(labelTongThanhToan.Text));
        }


        private void btnChonMua_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtDonGia, "Đơn Giá Không được để trống");
                return;
            }

            if (txtKhuyenMai.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtKhuyenMai, "Khuyến Mãi Không được để trống");
                return;
            }
            int KiemTra = 0;
            int vitri = 0;
            decimal KM = 0;
            decimal tt = 0;
            tongtien += tt;
            KM = int.Parse(txtKhuyenMai.Text);
            tt = decimal.Parse(txtDonGia.Text) * (((int)NumreicSL.Value)) - KM;
            SoluongConLai = SoLuongTon - (((int)NumreicSL.Value));
            tongtien += tt;
            labelThanhTien.Text = tt.ToString();
            labelThanhTien.Text = string.Format("{0:#,##0}", decimal.Parse(labelThanhTien.Text));
            //labelTongThanhToan.Text = tongtien.ToString();
            //labelTongThanhToan.Text = string.Format("{0:#,##0}", decimal.Parse(labelTongThanhToan.Text));
            for (int i = 0; i < dataGridViewHDBH.Rows.Count - 0; i++)
            {
                if (comboBoxSP.Text == dataGridViewHDBH.Rows[i].Cells["TenLK"].Value.ToString())
                {
                    KiemTra = 1;
                    vitri = i;
                    break;
                }
            }
            if (KiemTra == 1)
            {
                int SL = ((int)NumreicSL.Value) + int.Parse(dataGridViewHDBH.Rows[vitri].Cells["SoLuong"].Value.ToString());
                dataGridViewHDBH.Rows[vitri].Cells["SoLuong"].Value = SL.ToString();
                int SLConLaiMoi=int.Parse(dataGridViewHDBH.Rows[vitri].Cells["SLConLai"].Value.ToString())- ((int)NumreicSL.Value);
                dataGridViewHDBH.Rows[vitri].Cells["SLConLai"].Value = SLConLaiMoi.ToString();
                decimal ThanhTienMoi = tt + decimal.Parse(dataGridViewHDBH.Rows[vitri].Cells["ThanhTien"].Value.ToString());
                dataGridViewHDBH.Rows[vitri].Cells["ThanhTien"].Value = ThanhTienMoi.ToString();
                dataGridViewHDBH.Rows[vitri].Cells["ThanhTien"].Value = string.Format("{0:#,##0}", decimal.Parse(ThanhTienMoi.ToString()));
            }

            else
            {
                MaLK += comboBoxSP.SelectedValue.ToString() + ";";
                object[] t = { comboBoxSP.Text, NumreicSL.Value, txtDonGia.Text, KM.ToString(), labelThanhTien.Text,SoluongConLai };
                dataGridViewHDBH.Rows.Add(t);
            }
            TongTienSP();

        }

        decimal tongtien = 0;

        private void btnLuuHd_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtMaHD, "? Mã Hóa Đơn");
                return;
            }
            if (comboBoxNV.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(comboBoxNV, "? Nhân Viên");
                return;
            }
            if (labelTongThanhToan.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(labelTongThanhToan, "? Tổng Thanh Toán");
                return;
            }
            if (flag == 1)
            {
                hdbh.MaHDBH = txtMaHD.Text;
                hdbh.MaKH = txtMaKH.Text;
                hdbh.MaNV = comboBoxNV.SelectedValue.ToString();
                hdbh.NgayLapHDBH = dateTimePickerNgayLap.Value.Date;
                hdbh.TongTien = decimal.Parse(labelTongThanhToan.Text);
                hdbh.TrangThai = comboTrangThai.Text;
                bus.AddHoaDon(hdbh);
                string[] b = MaLK.Split(';');
                for (int i = 0; i < dataGridViewHDBH.Rows.Count - 0; i++)
                {
                    string malk = b[i];
                    int soluong = int.Parse(dataGridViewHDBH.Rows[i].Cells[1].Value.ToString());
                    decimal dongia = decimal.Parse(dataGridViewHDBH.Rows[i].Cells[2].Value.ToString());
                    decimal khuyenmai = decimal.Parse(dataGridViewHDBH.Rows[i].Cells[3].Value.ToString());
                    decimal thanhtien = decimal.Parse(dataGridViewHDBH.Rows[i].Cells[4].Value.ToString());
                    int slconlai = int.Parse(dataGridViewHDBH.Rows[i].Cells[5].Value.ToString());
                    cthdbh.MaHDBH = txtMaHD.Text;
                    cthdbh.MaLK = malk;
                    cthdbh.SoLuong = soluong;
                    cthdbh.DonGia = dongia;
                    cthdbh.KhuyenMai = khuyenmai;
                    cthdbh.ThanhTien = thanhtien;
                    cthdbh.TrangThai = comboTrangThai.Text;
                    lk.MaLK = malk;
                    lk.SoLuong = slconlai;
                    bus.CapNhatSLTon(lk);
                    bus.AddCTHD(cthdbh);
                }
                MessageBox.Show("Tạo Hóa Đơn Thành Công ");
                btnInHD.Enabled = true;
                //XuLyTextBox(true, false);
                XuLyChucNang(true, false);
            }
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại !");
            }
            try
            {
                DataTable DSKH = bus.GetDSkH("Select * From KhachHang Where DienThoai=N'" + txtSDT.Text + "'");
                if (DSKH.Rows.Count > 0)
                {
                    if (txtSDT.Text == DSKH.Rows[0]["DienThoai"].ToString())
                    {
                        txtTenkH.Text = DSKH.Rows[0]["TenKH"].ToString();
                        txtDiaChi.Text = DSKH.Rows[0]["DiaChi"].ToString();
                        txtMaKH.Text = DSKH.Rows[0]["MaKH"].ToString();
                    }

                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng");
                    PhatSinhMa();
                }
            }
            catch
            {

            }
        }

        public void PhatSinhMa()
        {
            int count = 0;
            count = kh.dataGridViewKH.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 0)
            {
                txtMaKH.Text = "KH00";
            }
            else
            {
                chuoi = Convert.ToString(kh.dataGridViewKH.Rows[count - 1].Cells[1].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    txtMaKH.Text = "KH0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtMaKH.Text = "KH" + (chuoi2 + 1).ToString();

            }
        }
        bool add;
        private void btnThenKH_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtSDT, "Số điện thoại không được để trống");
                return;
            }
            if (txtMaKH.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtMaKH, "Mã Khách Hàng Không được để trống");
                return;
            }
            if(txtTenkH.Text=="")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtTenkH, "Tên Khách Hàng Không Được Để Trống");
                return;
            }    
            if (txtDiaChi.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtDiaChi, "Địa Chỉ Không được để trống");
                return;
            }
            else
            {
                AddKH.MaKH = txtMaKH.Text;
                AddKH.TenKH = txtTenkH.Text;
                if (radioButtonNam.Checked == true)
                {
                    AddKH.GioiTinh = radioButtonNam.Text;
                }
                else
                {
                    AddKH.GioiTinh = radioButtonNu.Text;
                }
                if (txtSDT.Text == "")
                {
                    AddKH.DienThoai = "Không";
                }
                else
                {
                    AddKH.DienThoai = txtSDT.Text;
                }
                AddKH.DiaChi = txtDiaChi.Text;
                AddKH.TrangThai = "Mới";
                bus.AddKH(AddKH);
                MessageBox.Show("Thêm Khách Hàng Thành Công !");
            }
        }

        private void Frm_BanHan_Load(object sender, EventArgs e)
        {
            btnInHD.Enabled = false;
            HienThiSanPham();
            string condition = Login.SetValueForText1;
            HienThiNhanVien(condition);
            XuLyChucNang(true, false);
            XuLyTextBox(true, false);
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal TienThua = 0;
                TienThua = decimal.Parse(txtTienKhachDua.Text) - decimal.Parse(labelTongThanhToan.Text);
                labelThoiLaiKhach.Text = TienThua.ToString();
            }
            catch
            {

            }
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            if (add == true)
            {
                if(txtSDT.Text=="")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtSDT, "Số điện thoại không được để trống");
                    return;
                }
                if(txtMaKH.Text=="")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtMaKH, "Mã Khách Hàng Không được để trống");
                    return;
                }
                if (txtDiaChi.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtDiaChi, "Địa Chỉ Không được để trống");
                    return;
                }
                else
                {
                    AddKH.MaKH = txtMaKH.Text;
                    AddKH.TenKH = txtTenkH.Text;
                    if (radioButtonNam.Checked == true)
                    {
                        AddKH.GioiTinh = radioButtonNam.Text;
                    }
                    else
                    {
                        AddKH.GioiTinh = radioButtonNu.Text;
                    }
                    if (txtSDT.Text == "")
                    {
                        AddKH.DienThoai = "Không";
                    }
                    else
                    {
                        AddKH.DienThoai = txtSDT.Text;
                    }
                    AddKH.DiaChi = txtDiaChi.Text;
                    AddKH.TrangThai = "Mới";
                    bus.AddKH(AddKH);
                    MessageBox.Show("Thêm Khách Hàng Thành Công !");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string condition = txtSearch.Text;
            HienThiTimKiem(condition);
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            List<CT_HoaDon> lst = new List<CT_HoaDon>();
            lst.Clear();
            for (int i = 0; i < dataGridViewHDBH.Rows.Count - 0; i++)
            {
                CT_HoaDon cT_HoaDon = new CT_HoaDon
                {
                    TenSP = dataGridViewHDBH.Rows[i].Cells["TenLK"].Value.ToString(),
                    SoLuong=int.Parse(dataGridViewHDBH.Rows[i].Cells["SoLuong"].Value.ToString()),
                    DonGia=decimal.Parse(dataGridViewHDBH.Rows[i].Cells["DonGia"].Value.ToString()),
                    KhuyenMai=decimal.Parse(dataGridViewHDBH.Rows[i].Cells["KhuyenMai"].Value.ToString()),
                    ThanhTien=decimal.Parse(dataGridViewHDBH.Rows[i].Cells["ThanhTien"].Value.ToString()),
                    TongThanhToan=decimal.Parse(labelTongThanhToan.Text),
                    TenKH = txtTenkH.Text,
                    DienThoai = txtSDT.Text,
                    DiaChi = txtDiaChi.Text,
                    TenNV = comboBoxNV.Text,
                    NgayLap = dateTimePickerNgayLap.Text,
                    TienKhachDua=decimal.Parse(txtTienKhachDua.Text),
                    TienThua=decimal.Parse(labelThoiLaiKhach.Text),
                    MaHD=txtMaHD.Text
                };
                lst.Add(cT_HoaDon);
            }
                rs.Name = "DataSet1";
                rs.Value = lst;
                Frm_PrintHD frm_in = new Frm_PrintHD();
                frm_in.reportViewer1.LocalReport.DataSources.Clear();
                frm_in.reportViewer1.LocalReport.DataSources.Add(rs);
                frm_in.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnCShap.reportbc.rdlc";
                frm_in.ShowDialog();
               
            XuLyChucNang(true, false);
            //ClearTextBox();
        }

        private void txtMaHD_KeyDown(object sender, KeyEventArgs e)
        {
            string condition = txtMaHD.Text;
            HienThiDSSTheoMaSP(condition);
        }
        private void dataGridViewHDBH_DoubleClick(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn xóa sản phẩm này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (KQ == DialogResult.Yes)
            {
                int rowIndex = dataGridViewHDBH.CurrentCell.RowIndex;
                dataGridViewHDBH.Rows.RemoveAt(rowIndex);
                TongTienSP();
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtKhuyenMai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn Có Muốn Hủy Hay Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(KQ==DialogResult.Yes)
            {
                ClearTextBox();
                XuLyChucNang(true, false);
                btnInHD.Enabled = false;
            }    
        }
    }

    public class CT_HoaDon
    {
        //public int STT { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal KhuyenMai { get; set; }
        public decimal ThanhTien { get; set; }
        public decimal TongThanhToan { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string TenNV { get; set; }
        public string NgayLap { get; set; }
        public string MaHD { get; set; }
        public decimal TienKhachDua { get; set; }
        public decimal TienThua { get; set; }
    }
}
