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
    public partial class Frm_DSTaiKhoan : Form
    {
        public Frm_DSTaiKhoan()
        {
            InitializeComponent();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_TaoTaiKhoan hien = new Frm_TaoTaiKhoan();
            hien.Show();
            
        }
    }
}
