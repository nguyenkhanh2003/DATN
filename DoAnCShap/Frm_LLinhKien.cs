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
    public partial class Frm_LLinhKien : Form
    {
        public Frm_LLinhKien()
        {
            InitializeComponent();

        }

        LoaiLinhKien_BUS bus = new LoaiLinhKien_BUS();
        LoaiLinhKien llk = new LoaiLinhKien();

         public void Display()
        {

            dataGridViewKH.DataSource = bus.GetData("");
        }
        public void xulytextbox(Boolean b1, Boolean b2)
        {
            txtMaLoai.Enabled = b1;
            txtTenLoai.Enabled = b1;
            cboTrangThai.Enabled = b1;
            
        }

        public void xulychucnang(Boolean b1, Boolean b2)
        {
            btnThem.Enabled = b1;
            btnXoa.Enabled = b2;
            btnLuu.Enabled = b2;
            btnHuy.Enabled = b2;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
