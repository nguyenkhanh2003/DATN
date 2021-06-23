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
    public partial class Frm_BaoHanh : Form
    {
        public Frm_BaoHanh()
        {
            InitializeComponent();
        }
        PhieuBaoHanh_BUS bus = new PhieuBaoHanh_BUS();
        PhieuBaoHanh pbh = new PhieuBaoHanh();
        int flag = 0;

        public void HienThiHhDBH()
        {
            cboMaHd.DataSource = bus.HienThiHhDBH("");
            cboMaHd.ValueMember = "MaHDBH";
        }
        public void XuLyChucNang(Boolean  b1,Boolean b2)
        {
            btnThem.Enabled = b1;
            btnHuy.Enabled = b2;
            btnLuu.Enabled = b2;
            btnXoa.Enabled = b2;
        }
        public void HienThiDSPhieu()
        {
            dataGridViewPBH.DataSource = bus.GetPBH("");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            XuLyChucNang(false, true);
            PhatSinhMaHD();
        }

        private void Frm_BaoHanh_Load(object sender, EventArgs e)
        {
            HienThiHhDBH();
            HienThiDSPhieu();
            XuLyChucNang(true, false);
        }

        public void PhatSinhMaHD()
        { 
            int count = 0;
            count = dataGridViewPBH.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtMaPhieu.Text = "PBH00";
            }
            else
            {
                chuoi = Convert.ToString(dataGridViewPBH.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    txtMaPhieu.Text = "PBH0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtMaPhieu.Text = "PBH" + (chuoi2 + 1).ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                pbh.MaPBH = txtMaPhieu.Text;
                pbh.MaHDBH = cboMaHd.SelectedValue.ToString();
                pbh.NgayLap = dateTimePickerNgaLap.Text;
                pbh.TrangThai = cboTrangThai.Text;
                bus.ThemPBH(pbh);
                MessageBox.Show("Thêm phiếu thành công !");
                XuLyChucNang(true, false);
            }
            HienThiDSPhieu();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            object[] t = { txtMaPhieu.Text,comboBoxlK.Text,txtSL.Text,txtGhiChu.Text };
            dataGridViewCTPBH.Rows.Add(t);
        }
    }
}
