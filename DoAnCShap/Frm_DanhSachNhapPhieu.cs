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
    public partial class Frm_DanhSachNhapPhieu : Form
    {
        public Frm_DanhSachNhapPhieu()
        {
            InitializeComponent();
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            Frm_NhapLinhKien nhapLinhKien = new Frm_NhapLinhKien();
            nhapLinhKien.ShowDialog();
        }
    }
}
