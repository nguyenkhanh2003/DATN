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

        BanHang_BUS bh = new BanHang_BUS();
        QLBLK c = new QLBLK();
      

        public void HienThiSanPham()
        {
            comboBoxSP.DataSource = bh.GetData("");
            comboBoxSP.DisplayMember = "TenLK";
            comboBoxSP.ValueMember = "MaLK";
        }

     
        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
            HienThiSanPham();
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
                DataTable DSSP = bh.GetDSSP("Select * From LinhKien Where TenLK=N'" + comboBoxSP.Text + "'");
                if (DSSP.Rows.Count > 0)
                {
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
                DataTable DSKH = bh.GetDSkH("Select * From KhachHang Where DienThoai=N'" + txtSDT.Text + "'");
                if (DSKH.Rows.Count > 0)
                {
                    if (txtSDT.Text == DSKH.Rows[0]["DienThoai"].ToString())
                    {
                        txtTenkH.Text = DSKH.Rows[0]["TenKH"].ToString();
                        txtDiaChi.Text = DSKH.Rows[0]["DiaChi"].ToString();
                    }

                }
            }
        }
    }
}
