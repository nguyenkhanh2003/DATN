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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private static bool _exiting;

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            if (!_exiting && MessageBox.Show("Are you sure want to exit?",
                          "My First Application",
                           MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Information) == DialogResult.OK)
            {
                _exiting = true;
                // this.Close(); // you don't need that, it's already closing
                Environment.Exit(1);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }
    }
}
