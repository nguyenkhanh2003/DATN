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
    public partial class Frm_NhanVien : Form
    {
        public Frm_NhanVien()
        {
            InitializeComponent();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();

            o.Filter = "bitmap (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|All Files(*.*)|*.*";

            if (o.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Bạn Chưa Chọn Ảnh");

            }

            else
            {
                foreach (string ten in o.FileNames)
                {
                    string[] tenhinh = ten.Split('\\');
                    txtHinhNhanVien.Text = tenhinh[tenhinh.Length - 1];

                    PictureBox p = new PictureBox();

                    Size s = new Size(200, 250);
                    p.Size = s;

                    pictureBox1.Controls.Add(p);
                    Bitmap a = new Bitmap(ten);
                    p.Image = a;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;

                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
