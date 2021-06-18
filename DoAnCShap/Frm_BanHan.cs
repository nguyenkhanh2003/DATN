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

        public void HienThiTimKiem(string condition)
        {
            comboBoxSP.DataSource=bus.GetTimKiem("select TenLK From LinhKien Where TenLK Like N'%"+condition+"%'");
        }
        public void XuLyChucNang(Boolean b1, Boolean b2)
        {
            btnThemHD.Enabled = b1;
            btnThenKH.Enabled = b2;
            btnChonMua.Enabled = b2;
            btnLuuHd.Enabled = b2;
            btnInHD.Enabled = b2;
            btnXoaSP.Enabled = b2;
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
            HienThiNhanVien();
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
            XuLyChucNang(false, true);
        }

        private void btnChonMua_Click(object sender, EventArgs e)
        {
            MaLK += comboBoxSP.SelectedValue.ToString() + ";";
            int tt=0;
            int KM = 0;
            if (txtKhuyenMai.Text != "")
                KM = int.Parse(txtKhuyenMai.Text);
            tt = Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSL.Text) - KM;
            tongtien += tt;
            labelThanhTien.Text = tt.ToString();
            labelTongThanhToan.Text = tongtien.ToString();
            object[] t = { comboBoxSP.Text, txtSL.Text, txtDonGia.Text, KM.ToString(), labelThanhTien.Text };
            dataGridViewHDBH.Rows.Add(t);
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
                hdbh.NgayLapHDBH = dateTimePickerNgayLap.Text;
                hdbh.TongTien = labelTongThanhToan.Text;
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
            HienThiNhanVien();
            XuLyChucNang(true, false);
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
                AddKH.GioiTinh = "Nam";
                AddKH.Email = "12345@gmail.com";
                AddKH.DienThoai = txtSDT.Text;
                AddKH.CMND = "272721655";
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


        private String changeToWords(String numb, bool isCurrency)
        {
            String val = "", wholeNo = numb, points = "", andStr = "", pointStr = "";
            String endStr = (isCurrency) ? ("Only") : ("Only"); //-- Only-- 
            try
            {
                int decimalPlace = numb.IndexOf(".");
                if (decimalPlace > 0)
                {
                    wholeNo = numb.Substring(0, decimalPlace);
                    points = numb.Substring(decimalPlace + 1);
                    if (Convert.ToInt32(points) > 0)
                    {
                        andStr = (isCurrency) ? ("and") : ("Point");// just to separate whole numbers from points/cents 
                        endStr = (isCurrency) ? ("Cents " + endStr) : ("Only"); //--Paisa Only-- 
                        pointStr = translateCents(points);
                    }
                }
                val = String.Format("{0} {1}{2} {3}", translateWholeNumber(wholeNo).Trim(), andStr, pointStr, endStr);
            }
            catch {; }
            return val;
        }
        private String translateWholeNumber(String number)
        {
            string word = " "; //--Taka-- 
            try
            {
                bool beginsZero = false;//tests for 0XX 
                bool isDone = false;//test if already translated 
                double dblAmt = (Convert.ToDouble(number));
                //if ((dblAmt > 0) && number.StartsWith("0")) 
                if (dblAmt > 0)
                {//test for zero or digit zero in a nuemric 
                    beginsZero = number.StartsWith("0");
                    int numDigits = number.Length;
                    int pos = 0;//store digit grouping 
                    String place = " ";//digit grouping name:hundres,thousand,etc... 
                    switch (numDigits)
                    {
                        case 1://ones' range 
                            word = ones(number);
                            isDone = true;
                            break;
                        case 2://tens' range 
                            word = tens(number);
                            isDone = true;
                            break;
                        case 3://hundreds' range 
                            pos = (numDigits % 3) + 1;
                            place = " Hundred ";
                            break;
                        case 4://thousands' range 
                        case 5:
                        case 6:
                            pos = (numDigits % 4) + 1;//
                            place = " Thousand ";
                            break;
                        case 7://millions' range 
                        case 8:
                        case 9:
                            pos = (numDigits % 7) + 1;
                            place = " Million ";
                            break;
                        case 10://Billions's range 
                        case 11:
                        case 12:
                            pos = (numDigits % 10) + 1;
                            place = " Billion ";
                            break;
                        //add extra case options for anything above Billion... 
                        default:
                            isDone = true;
                            break;
                    }
                    if (!isDone)
                    {//if transalation is not done, continue...(Recursion comes in now!!) 
                        word = translateWholeNumber(number.Substring(0, pos)) + place + translateWholeNumber(number.Substring(pos));
                        //check for trailing zeros 
                        if (beginsZero) word = "  " + word.Trim();//-----"and"---
                    }
                    //ignore digit grouping names 
                    if (word.Trim().Equals(place.Trim())) word = "";
                }
            }
            catch {; }
            return word.Trim();
        }
        private String tens(String digit)
        {
            int digt = Convert.ToInt32(digit);
            String name = null;
            switch (digt)
            {
                case 10:
                    name = "Ten";
                    break;
                case 11:
                    name = "Eleven";
                    break;
                case 12:
                    name = "Twelve";
                    break;
                case 13:
                    name = "Thirteen";
                    break;
                case 14:
                    name = "Fourteen";
                    break;
                case 15:
                    name = "Fifteen";
                    break;
                case 16:
                    name = "Sixteen";
                    break;
                case 17:
                    name = "Seventeen";
                    break;
                case 18:
                    name = "Eighteen";
                    break;
                case 19:
                    name = "Nineteen";
                    break;
                case 20:
                    name = "Twenty";
                    break;
                case 30:
                    name = "Thirty";
                    break;
                case 40:
                    name = "Fourty";
                    break;
                case 50:
                    name = "Fifty";
                    break;
                case 60:
                    name = "Sixty";
                    break;
                case 70:
                    name = "Seventy";
                    break;
                case 80:
                    name = "Eighty";
                    break;
                case 90:
                    name = "Ninety";
                    break;
                default:
                    if (digt > 0)
                    {
                        name = tens(digit.Substring(0, 1) + "0") + " " + ones(digit.Substring(1));
                    }
                    break;
            }
            return name;
        }
        private String ones(String digit)
        {
            int digt = Convert.ToInt32(digit);
            String name = "";
            switch (digt)
            {
                case 1:
                    name = "One";
                    break;
                case 2:
                    name = "Two";
                    break;
                case 3:
                    name = "Three";
                    break;
                case 4:
                    name = "Four";
                    break;
                case 5:
                    name = "Five";
                    break;
                case 6:
                    name = "Six";
                    break;
                case 7:
                    name = "Seven";
                    break;
                case 8:
                    name = "Eight";
                    break;
                case 9:
                    name = "Nine";
                    break;
            }
            return name;
        }
        private String translateCents(String cents)
        {
            String cts = "", digit = "", engOne = "";
            for (int i = 0; i < cents.Length; i++)
            {
                digit = cents[i].ToString();
                if (digit.Equals("0"))
                {
                    engOne = "Zero";
                }
                //check for trailing zeros
                //if (beginsZero)
                //{
                //    word = "  " + word.Trim();//-----"and"---
                //    place = ""; // Remove the current text as it is not required now
                //}

                        else
                {
                    engOne = ones(digit);
                }
                cts += " " + engOne;
            }
            return cts;
        }

       
    }
}
