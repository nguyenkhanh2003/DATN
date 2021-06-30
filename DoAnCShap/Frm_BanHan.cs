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
        Frm_HoaDonBanHang f = new Frm_HoaDonBanHang();
        BanHang_BUS bus = new BanHang_BUS();
        HoaDonBanHang hdbh = new HoaDonBanHang();
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
            //btnXoaSP.Enabled = b2;
            btnLuuKH.Enabled = b2;
            btnTimKH.Enabled = b2;
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
                        txtSL.Text = "1";

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
                        comboBoxKH.Text = DSKH.Rows[0]["MaKH"].ToString();
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
        }

        private void btnChonMua_Click(object sender, EventArgs e)
        {
            int KiemTra = 0;
            int vitri = 0;
            int KM = 0;
          
            int tt = 0;
            tongtien += tt;
            KM = int.Parse(txtKhuyenMai.Text);
            tt = Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSL.Text) - KM;
            tongtien += tt;
            labelThanhTien.Text = tt.ToString();
            String.Format("{0:#,##0.##}", (labelTongThanhToan.Text) = tongtien.ToString());

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
                int SL = int.Parse(txtSL.Text) + int.Parse(dataGridViewHDBH.Rows[vitri].Cells["SoLuong"].Value.ToString());
                dataGridViewHDBH.Rows[vitri].Cells["SoLuong"].Value = SL.ToString();
                int ThanhTienMoi = tt + int.Parse(dataGridViewHDBH.Rows[vitri].Cells["ThanhTien"].Value.ToString());
                dataGridViewHDBH.Rows[vitri].Cells["ThanhTien"].Value = ThanhTienMoi.ToString();
            }

            else
            {
                MaLK += comboBoxSP.SelectedValue.ToString() + ";";
                object[] t = { comboBoxSP.Text, txtSL.Text, txtDonGia.Text, KM.ToString(), labelThanhTien.Text };
                dataGridViewHDBH.Rows.Add(t);
            }
     
        }
        double tongtien = 0;
        private void txtSL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKhuyenMai_TextChanged(object sender, EventArgs e)
        {
            //if (txtSL.Text != "" || txtKhuyenMai.Text != "" || txtDonGia.Text != "")
            //{
            //    double tt = 0;//thanhtien
            //    double km = 0; //khuyen mai
            //    double sl = 0;
            //    tt = double.Parse(txtDonGia.Text) * int.Parse(txtSL.Text) - double.Parse(txtKhuyenMai.Text);
            //    tongtien = tt;
            //    labelThanhTien.Text = tongtien.ToString();
            //}
        }

        private void btnLuuHd_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                hdbh.MaHDBH = txtMaHD.Text;
                hdbh.MaKH = comboBoxKH.Text;
                hdbh.MaNV = comboBoxNV.SelectedValue.ToString();
                hdbh.NgayLapHDBH = dateTimePickerNgayLap.Value.Date;
                hdbh.TongTien =int.Parse(labelTongThanhToan.Text);
                hdbh.TrangThai = comboBoxTrangThai.SelectedIndex.ToString();
                //hdbh.TrangThai = txtTienKhachDua.Text;
                bus.AddHoaDon(hdbh);
                string[] b = MaLK.Split(';');
                for (int i = 0; i < dataGridViewHDBH.Rows.Count - 1; i++)
                {
                    string malk = b[i];
                    //string malk = dataGridViewHDBH.Rows[i].Cells[0].Value.ToString();
                    string soluong = dataGridViewHDBH.Rows[i].Cells[1].Value.ToString();
                    string dongia = dataGridViewHDBH.Rows[i].Cells[2].Value.ToString();
                    string khuyenmai = dataGridViewHDBH.Rows[i].Cells[3].Value.ToString();
                    string thanhtien = dataGridViewHDBH.Rows[i].Cells[4].Value.ToString();
                    cthdbh.MaHDBH = txtMaHD.Text;
                    cthdbh.MaLK = malk;
                    cthdbh.SoLuong = soluong;
                    cthdbh.DonGia = dongia;
                    cthdbh.KhuyenMai = khuyenmai;
                    cthdbh.ThanhTien = thanhtien;
                    cthdbh.TrangThai = comboBoxTrangThai.SelectedIndex.ToString();
                    bus.AddCTHD(cthdbh);
                }
                MessageBox.Show("Tạo Hóa Đơn Thành Công ");
                
            }
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại !");
            }
            else
            {
                DataTable DSKH = bus.GetDSkH("Select * From KhachHang Where DienThoai=N'" + txtSDT.Text + "'");
                if (DSKH.Rows.Count > 0)
                {
                    if (txtSDT.Text == DSKH.Rows[0]["DienThoai"].ToString())
                    {
                        txtTenkH.Text = DSKH.Rows[0]["TenKH"].ToString();
                        txtDiaChi.Text = DSKH.Rows[0]["DiaChi"].ToString();
                        comboBoxKH.Text = DSKH.Rows[0]["MaKH"].ToString();
                    }

                }
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
                comboBoxKH.Text = "KH00";
            }
            else
            {
                chuoi = Convert.ToString(kh.dataGridViewKH.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                   comboBoxKH.Text = "KH0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    comboBoxKH.Text = "KH" + (chuoi2 + 1).ToString();

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
            //labelHienThiTenDangNhap.Text = Login.SetValueForText1;
            string condition = Login.SetValueForText1;
            HienThiNhanVien(condition);
            XuLyChucNang(true, false);
            btnXoaSP.Enabled = false;
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
                AddKH.MaKH = comboBoxKH.Text;
                AddKH.TenKH = txtTenkH.Text;
                if (checkBoxNam.Checked == true)
                {
                    AddKH.GioiTinh = checkBoxNam.Text;
                }
                else
                {
                    AddKH.GioiTinh = checkBoxNu.Text;
                }
                //AddKH.GioiTinh = "Nam";
                AddKH.Email = "12345@gmail.com";
                AddKH.DienThoai = txtSDT.Text;
                AddKH.DiaChi = txtDiaChi.Text;
                AddKH.TrangThai = "Mới";
                bus.AddKH(AddKH);
                MessageBox.Show("Thêm Khách Hàng Thành Công !");
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewHDBH.CurrentCell.RowIndex;
            dataGridViewHDBH.Rows.RemoveAt(rowIndex);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string condition = txtSearch.Text;
            HienThiTimKiem(condition);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtTienKhachDua.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));

        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            SetValueForText3 = txtMaHD.Text;
            Frm_PrintHD InHoaDon = new Frm_PrintHD();
            InHoaDon.ShowDialog();

        }

        private void dataGridViewHDBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaSP.Enabled = true;
        }

        private void txtMaHD_KeyDown(object sender, KeyEventArgs e)
        {
            string condition = txtMaHD.Text;
            HienThiDSSTheoMaSP(condition);
        }
    }
}
