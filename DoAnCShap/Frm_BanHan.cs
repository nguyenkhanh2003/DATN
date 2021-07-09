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
        public void HienThiSanPham()
        {
            comboBoxSP.DataSource = bus.GetData("");
            comboBoxSP.DisplayMember = "TenLK";
            comboBoxSP.ValueMember = "MaLK";
        }

        public void HienThiNhanVien(string labelHienTenDN)
        {
            comboBoxNV.DataSource = bus.GetNhanVien("Select MaNV,TenNV From NhanVien Where UserName=N'"+labelHienTenDN+"'");
            comboBoxNV.DisplayMember = "TenNV";
            comboBoxNV.ValueMember = "MaNV";
        }

        public void HienThiTimKiem(string condition)
        {
            comboBoxSP.DataSource=bus.GetTimKiem("select TenLK From LinhKien Where TenLK Like N'%"+condition+"%'");
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
            btnInHD.Enabled = b2;
            btnLuuKH.Enabled = b2;
            btnTimKH.Enabled = b2;
        }

        public void XuLyTextBox(Boolean b1,Boolean b2)
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
            comboBoxTrangThai.Enabled = b2;
        }
        public void ClearTextBox()
        {
            txtMaHD.ResetText();
            comboBoxNV.ResetText();
            comboBoxSP.ResetText();
            comboBoxTrangThai.ResetText();
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
            dataGridViewHDBH.DataSource = null;
        }    
        public void PhatSinhMaHD()
        {
            int count = 0;
            count = f.dataGridViewHD.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtMaHD.Text = "HD00";
            }
            else
            {
                chuoi = Convert.ToString(f.dataGridViewHD.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
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

        private void comboBoxSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable DSSP = bus.GetDSSP("Select * From LinhKien Where TenLK=N'" + comboBoxSP.Text + "'");
                if (DSSP.Rows.Count > 0)
                {
                    //if(comboBoxSP.Text==DSSP.Rows[0]["MaLK"].ToString())
                    if (comboBoxSP.Text == DSSP.Rows[0]["TenLK"].ToString())
                    {
                       
                        txtDonGia.Text = DSSP.Rows[0]["DonGia"].ToString();
                        txtDonGia.Text = string.Format("{0:#,##0}", double.Parse(txtDonGia.Text));
                        txtKhuyenMai.Text = DSSP.Rows[0]["KhuyenMai"].ToString();
                        txtKhuyenMai.Text = string.Format("{0:#,##0}", double.Parse(txtKhuyenMai.Text));
                        //txtSL.Text = "1";
                        NumreicSL.Value = 1;

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
            PhatSinhMaHD();
            flag = 1;
            XuLyChucNang(false, true);
            XuLyTextBox(false, true);
        }

       
      
        private void btnChonMua_Click(object sender, EventArgs e)
        {
            if(txtDonGia.Text=="")
            {
                MessageBox.Show("? Đơn Giá");
                return;
            }

            if (txtKhuyenMai.Text=="")
            {
                MessageBox.Show("? Khuyến Mãi");
                return;
            }    
            int KiemTra = 0;
            int vitri = 0;
            decimal KM = 0;
            decimal tt = 0;
            tongtien += tt;
            KM = int.Parse(txtKhuyenMai.Text);
            tt = decimal.Parse(txtDonGia.Text) * (((int)NumreicSL.Value)) - KM;
            tongtien += tt;
            labelThanhTien.Text = tt.ToString();
            labelThanhTien.Text = string.Format("{0:#,##0}", decimal.Parse(labelThanhTien.Text));
            labelTongThanhToan.Text = tongtien.ToString();
            labelTongThanhToan.Text = string.Format("{0:#,##0}", decimal.Parse(labelTongThanhToan.Text));
            for (int i=0;i<dataGridViewHDBH.Rows.Count-1;i++)
            {
               if(comboBoxSP.Text==dataGridViewHDBH.Rows[i].Cells["TenLK"].Value.ToString())
                {
                    KiemTra = 1;
                    vitri = i;
                    break;
                }
            }   
            if(KiemTra==1)
            {
                int SL = ((int)NumreicSL.Value) + int.Parse(dataGridViewHDBH.Rows[vitri].Cells["SoLuong"].Value.ToString());
                dataGridViewHDBH.Rows[vitri].Cells["SoLuong"].Value = SL.ToString();
                decimal ThanhTienMoi = tt + decimal.Parse(dataGridViewHDBH.Rows[vitri].Cells["ThanhTien"].Value.ToString());
                dataGridViewHDBH.Rows[vitri].Cells["ThanhTien"].Value = ThanhTienMoi.ToString();
                dataGridViewHDBH.Rows[vitri].Cells["ThanhTien"].Value = string.Format("{0:#,##0}", decimal.Parse(ThanhTienMoi.ToString()));
            }

            else
            {
                MaLK += comboBoxSP.SelectedValue.ToString() + ";";
                object[] t = { comboBoxSP.Text, NumreicSL.Value, txtDonGia.Text, KM.ToString(), labelThanhTien.Text };
                dataGridViewHDBH.Rows.Add(t);
            }
     
        }

        decimal tongtien = 0;
      
        public void UpdateSL()
        {
            for(int i=0;i<sp.dataGridViewLK.Rows.Count-1;i++)
            {
                string SLSP = sp.dataGridViewLK.Rows[i].Cells[9].Value.ToString();
            }    
        }
        private void btnLuuHd_Click(object sender, EventArgs e)
        {
            if(txtMaHD.Text=="")
            {
                MessageBox.Show("? Mã Khách Hàng");
                return;
            }
            if(txtMaKH.Text=="")
            {
                MessageBox.Show("? Mã Khách Hàng");
                return;
            }
            if(labelTongThanhToan.Text=="")
            {
                MessageBox.Show("? Tổng Thanh Toán");
                return;
            }    
            if (flag == 1)
            {
                hdbh.MaHDBH = txtMaHD.Text;
                hdbh.MaKH = txtMaKH.Text;
                hdbh.MaNV = comboBoxNV.SelectedValue.ToString();
                hdbh.NgayLapHDBH = dateTimePickerNgayLap.Value.Date;
                hdbh.TongTien =decimal.Parse(labelTongThanhToan.Text);
                hdbh.TrangThai = comboBoxTrangThai.Text;
                bus.AddHoaDon(hdbh);
                string[] b = MaLK.Split(';');
                int vitri = 0;
                int SLConLai = 0;
                for (int i = 0; i < dataGridViewHDBH.Rows.Count - 1; i++)
                {
                    string malk = b[i];
                    int soluong =int.Parse(dataGridViewHDBH.Rows[i].Cells[1].Value.ToString());
                    decimal dongia =decimal.Parse(dataGridViewHDBH.Rows[i].Cells[2].Value.ToString());
                    decimal khuyenmai =decimal.Parse(dataGridViewHDBH.Rows[i].Cells[3].Value.ToString());
                    decimal thanhtien =decimal.Parse(dataGridViewHDBH.Rows[i].Cells[4].Value.ToString());
                    cthdbh.MaHDBH = txtMaHD.Text;
                    cthdbh.MaLK = malk;
                    cthdbh.SoLuong = soluong;
                    cthdbh.DonGia = dongia;
                    cthdbh.KhuyenMai = khuyenmai;
                    cthdbh.ThanhTien = thanhtien;
                    cthdbh.TrangThai = comboBoxTrangThai.Text;
                    //SLConLai =int.Parse(sp.dataGridViewLK.Rows[0].Cells["SoLuong"].Value.ToString())-soluong;
                    //textBox1SL.Text = SLConLai.ToString();
                    //lk.MaLK = malk;
                    //lk.SoLuong = SLConLai;
                    //bus.UpdateSL(lk);
                    bus.AddCTHD(cthdbh);
                }
                MessageBox.Show("Tạo Hóa Đơn Thành Công ");
                XuLyTextBox(true,false);
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
            if (count <= 1)
            {
                txtMaKH.Text = "KH00";
            }
            else
            {
                chuoi = Convert.ToString(kh.dataGridViewKH.Rows[count - 2].Cells[0].Value);
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
            PhatSinhMa();
            add = true;
        }

        private void Frm_BanHan_Load(object sender, EventArgs e)
        {
            HienThiSanPham();
            string condition = Login.SetValueForText1;
            HienThiNhanVien(condition);
            XuLyChucNang(true, false);
            XuLyTextBox(true, false);
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            double TienThua = 0;
            double TongThanhToan = 0; //khuyen mai
            double TienKhachDua = 0;
            TienThua = double.Parse(txtTienKhachDua.Text) - int.Parse(labelTongThanhToan.Text);
            labelThoiLaiKhach.Text = TienThua.ToString();
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            if (add == true)
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
                AddKH.DienThoai = txtSDT.Text;
                AddKH.DiaChi = txtDiaChi.Text;
                AddKH.TrangThai = "Mới";
                bus.AddKH(AddKH);
                MessageBox.Show("Thêm Khách Hàng Thành Công !");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string condition = txtSearch.Text;
            HienThiTimKiem(condition);
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            SetValueForText3 = txtMaHD.Text;
            Frm_PrintHD InHoaDon = new Frm_PrintHD();
            InHoaDon.ShowDialog();
            XuLyChucNang(true, false);
            ClearTextBox();
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
    }
}
