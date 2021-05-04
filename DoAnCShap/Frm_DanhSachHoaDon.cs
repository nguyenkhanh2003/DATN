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
       
        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            Frm_HoaDonBanHang hoaDonBanHang = new Frm_HoaDonBanHang();
          
            hoaDonBanHang.ShowDialog();
            
        }
    }
}
