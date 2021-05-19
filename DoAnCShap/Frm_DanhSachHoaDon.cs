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
    public partial class Frm_DanhSachHoaDon : Form
    {
        public Frm_DanhSachHoaDon()
        {
            InitializeComponent();
        }

        Form1 frm = new Form1();
        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            Frm_HoaDonBanHang HDB = new Frm_HoaDonBanHang();
            HDB.ShowDialog();
        }
    }
}
