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
    public partial class Frm_ThongKe : Form
    {
        public Frm_ThongKe()
        {
            InitializeComponent();
        }

        DoanhThu_BUS bus = new DoanhThu_BUS();
        
        public void HienThiDoanhThu()
        {
            dataGridView1.DataSource = bus.DoanhThuTatCa("");
        }
        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXemDoanhThu_Click(object sender, EventArgs e)
        {
            if(radioButtonTatCa.Checked==true)
            {
                HienThiDoanhThu();
            }    
        }
    }
}
