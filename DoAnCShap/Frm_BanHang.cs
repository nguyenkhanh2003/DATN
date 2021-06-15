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
      

       public void DisPlay()
        {
            
        }

        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
            DisPlay();
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
    }
}
