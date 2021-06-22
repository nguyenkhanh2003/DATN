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
        }

        private void Frm_BaoHanh_Load(object sender, EventArgs e)
        {
            HienThiHhDBH();
            HienThiDSPhieu();
            XuLyChucNang(true, false);
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
    }
}
