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
        public void HienThiSP()
        {
            listBoxDSSP.DataSource = bh.GetData("");
            listBoxDSSP.DisplayMember = "TenLK";
        }



        public void HienThiTimKiem(String Condition)
        {
            listBoxDSSP.DataSource = bh.GetTimKiem("Select TenLK from LinhKien Where TenLK Like N'%"+Condition+"%'");
        }

       

        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
            HienThiSP();
        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String Condition = txtSearch.Text;
            HienThiTimKiem(Condition);
        }

        private void listBoxDSSP_DoubleClick(object sender, EventArgs e)
        {
            DataTable dssp = bh.GetDSSP("Select * from LinhKien where TenSp = '" + listBoxDSSP.Text + "'");
            txtDonGia.Text = dssp.Rows[0]["DonGia"].ToString();
        }

        private void comboBoxTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
             
               
            }
        }
    }
}
