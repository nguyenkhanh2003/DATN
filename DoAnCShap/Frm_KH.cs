using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCShap
{
    public partial class Frm_KH : Form
    {
        public Frm_KH()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void xulytextbox(Boolean b1,Boolean b2)
        {
            txtMaKh.Enabled =b1;
            txtTenkh.Enabled =b1;
            cboGioiTinh.Enabled =b1;
            dateNS.Enabled = b1;
            txtEmail.Enabled = b1;
            txtSdt.Enabled =b1;
            txtCMND.Enabled = b1;
            txtDiaChi.Enabled =b1;
            cboTrangThai.Enabled =b1;
        }
        public void xulychucnang(Boolean b1,Boolean b2)
        {
            btnThem.Enabled =b1;
            btnXoa.Enabled = b2;
            btnLuu.Enabled = b2;
            btnHuy.Enabled = b2;
        }

        private void Frm_KH_Load(object sender, EventArgs e)
        {
            xulytextbox(false,true);
            xulychucnang(true,false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulychucnang(false, true);
            xulytextbox(true, false);
        }
    }
}
