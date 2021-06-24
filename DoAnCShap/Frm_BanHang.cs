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
namespace DoAnCShap
{
    public partial class Frm_BanHang : Form
    {
        public Frm_BanHang()
        {
            InitializeComponent();
        }

        BanHang_BUS bus = new BanHang_BUS();
       
        HoaDonBanHang hdbh = new HoaDonBanHang();
        CT_HoaDonBanHang cthdbh = new CT_HoaDonBanHang();

        string MaLK = "";
        public void HienThiSanPham()
        {
            comboBoxSP.DataSource = bus.GetData("");
            comboBoxSP.DisplayMember = "TenLK";
            comboBoxSP.ValueMember = "MaLK";
        }

        public void HienThiNhanVien()
        {
            comboBoxNV.DataSource = bus.GetNhanVien("Select MaNV,TenNV From NhanVien");
            comboBoxNV.DisplayMember = "TenNV";
            comboBoxNV.ValueMember = "MaNV";
        }

        public void XuLyChucNang(Boolean b1,Boolean b2)
        {

        }
        public void PhatSinhMaHD()
        {

            int count = 0;
            count = dataGridViewHD.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtMaHD.Text = "HD00";
            }
            else
            {
                chuoi = Convert.ToString(dataGridViewHD.Rows[count - 2].Cells[0].Value);
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
            HienThiNhanVien();
        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBoxDSSP_DoubleClick(object sender, EventArgs e)
        {
        }

        private void comboBoxTest_KeyDown(object sender, KeyEventArgs e)
        {

        }

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
                        txtSL.Text = DSSP.Rows[0]["SoLuong"].ToString();
                       
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
        }

        private void btnChonMua_Click(object sender, EventArgs e)
        {
            MaLK = comboBoxSP.SelectedValue.ToString();
            int tt;
            int KM = 0;
            if (txtKhuyenMai.Text != "")
                KM = int.Parse(txtKhuyenMai.Text);
            tt = Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSL.Text) - KM;
            tongtien += tt;
            labelThanhTien.Text = tt.ToString();
            txtTongThanhToan.Text = tongtien.ToString();
            object[] t = {MaLK,txtSL.Text, txtDonGia.Text, KM.ToString(), labelThanhTien.Text };
            dataGridViewHD.Rows.Add(t);
        }
        double tongtien = 0;
        private void txtSL_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtKhuyenMai_TextChanged(object sender, EventArgs e)
        {
            if (txtSL.Text != "" || txtKhuyenMai.Text != "" || txtDonGia.Text != "")
            {
                double tt = 0;//thanhtien
                double km = 0; //khuyen mai
                double sl = 0;
                tt = double.Parse(txtDonGia.Text) * int.Parse(txtSL.Text) - double.Parse(txtKhuyenMai.Text);
                tongtien = tt;
                labelThanhTien.Text = tongtien.ToString();
            }
        }

        private void btnLuuHd_Click(object sender, EventArgs e)
        {
            if(flag==1)
            {
                hdbh.MaHDBH = txtMaHD.Text;
                hdbh.MaKH = comboBoxKH.Text;
                hdbh.MaNV = comboBoxNV.SelectedValue.ToString();
                //hdbh.NgayLapHDBH = dateTimePickerNgayLap.Text;
                hdbh.TongTien = txtTongThanhToan.Text;
                //hdbh.TrangThai = txtTienKhachDua.Text;
                bus.AddHoaDon(hdbh);
                string[] b = MaLK.Split(';');
                for (int i = 0; i < dataGridViewHD.Rows.Count - 1; i++)
                {
                    string malk = dataGridViewHD.Rows[i].Cells[0].Value.ToString();
                    string soluong = dataGridViewHD.Rows[i].Cells[1].Value.ToString();
                    string dongia = dataGridViewHD.Rows[i].Cells[2].Value.ToString();
                    string khuyenmai = dataGridViewHD.Rows[i].Cells[3].Value.ToString();
                    string thanhtien = dataGridViewHD.Rows[i].Cells[4].Value.ToString();
                    cthdbh.MaHDBH = txtMaHD.Text;
                    cthdbh.MaLK = malk;
                    cthdbh.SoLuong = soluong;
                    cthdbh.DonGia = dongia;
                    cthdbh.KhuyenMai = khuyenmai;
                    cthdbh.ThanhTien = thanhtien;
                    cthdbh.TrangThai = "1";
                    bus.AddCTHD(cthdbh);
                }

                MessageBox.Show("Tạo Hóa Đơn Thành Công ");
            }    
        }
    }
}
