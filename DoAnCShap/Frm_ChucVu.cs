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
    public partial class Frm_ChucVu : Form
    {
        public Frm_ChucVu()
        {
            InitializeComponent();
        }

        ChucVu_BUS bus = new ChucVu_BUS();
        ChucVu cv = new ChucVu();

        int flag = 0;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void XuLyChucNang(Boolean b1, Boolean b2)
        {
            btnThem.Enabled = b1;
            btnHuy.Enabled = b2;
            btnLuu.Enabled = b2;
            btnXoa.Enabled = b2;
        }
        public void XuLyTextBox(Boolean b1,Boolean b2)
        {
            txtMaCV.Enabled = b1;
            txtTenCV.Enabled = b1;
            cboTrangThai.Enabled = b1;
        }

        public void HienThiDSCV()
        {
            dataGridViewCV.DataSource = bus.GetChucVu("");
        }

        private void Frm_ChucVu_Load(object sender, EventArgs e)
        {
            HienThiDSCV();
            XuLyChucNang(true, false);
            XuLyTextBox(false,true);
        }

        public void PhatSinhMa()
        {
            int count = 0;
            count = dataGridViewCV.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtMaCV.Text = "CV00";
            }
            else
            {
                chuoi = Convert.ToString(dataGridViewCV.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    txtMaCV.Text = "CV0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtMaCV.Text = "CV" + (chuoi2 + 1).ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            XuLyChucNang(false,true);
            XuLyTextBox(true,false);
            PhatSinhMa();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTenCV.Text=="")
            {
                MessageBox.Show("Chưa Nhập Tên Chức Vụ");
                return;
            }    
            if(cboTrangThai.Text=="")
            {
                MessageBox.Show("Chưa chọn trạng thái !");
            }    
            if(flag==1)
            {
                cv.MaCV = txtMaCV.Text;
                cv.TenCV = txtTenCV.Text;
                cv.TrangThai = cboTrangThai.Text;
                bus.AddChucVu(cv);
                MessageBox.Show("Thành Công");
               
            }
            HienThiDSCV();
        }
    }
}
