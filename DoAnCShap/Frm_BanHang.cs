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
    public partial class Frm_BanHang : Form
    {
        public Frm_BanHang()
        {
            InitializeComponent();
        }

        List<PictureBox> pictureBoxes = new List<PictureBox>();

        public void loadImage()
        {
           
        }

        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
            loadImage();
        }
    }
}
