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
    public partial class Frm_Setting : Form
    {
        public Frm_Setting()
        {
            InitializeComponent();
        }

        private void Frm_Setting_Load(object sender, EventArgs e)
        {

        }



        private void btnThayDoi_Click(object sender, EventArgs e)
        {

            ColorDialog colDig = new ColorDialog();
            //Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (colDig.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.BackGroundColoPanelTop = colDig.Color;
                Properties.Settings.Default.FormsBackgroundColor = colDig.Color;
                Properties.Settings.Default.Save();
                this.BackColor = colDig.Color;
            }

            //Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            //form1.panelTop.BackColor = Color.FromArgb(255, 128, 128);
            //form1.panelBot.BackColor = Color.FromArgb(255, 128, 128);
            //form1.btnNhanVien.BackColor = Color.FromArgb(255, 128, 128);
            //form1.btnKhachHang.BackColor = Color.FromArgb(255, 128, 128);
            //form1.btnBanHang.BackColor = Color.FromArgb(255, 128, 128);
            //form1.btnBaohanh.BackColor = Color.FromArgb(255, 128, 128);
            //form1.btnLoaiLK.BackColor = Color.FromArgb(255, 128, 128);
            //form1.btnLinhKien.BackColor = Color.FromArgb(255, 128, 128);
            //form1.btnNhaCungCap.BackColor = Color.FromArgb(255, 128, 128);
            //form1.btnPhanQuyen.BackColor = Color.FromArgb(255, 128, 128);
            //form1.btnPhieuNhap.BackColor = Color.FromArgb(255, 128, 128);
            //form1.btnSetting.BackColor = Color.FromArgb(255, 128, 128);
            //form1.btnHoaDon.BackColor = Color.FromArgb(255, 128, 128);
            //form1.btnThongKe.BackColor = Color.FromArgb(255, 128, 128);
            //form1.panelSideMenu.BackColor = Color.FromArgb(255, 128, 128);
            //form1.labeldateTime.BackColor = Color.FromArgb(255, 128, 128);
            //form1.labelHienThiTenDangNhap.BackColor = Color.FromArgb(255, 128, 128);
            //Application.DoEvents();

        }
    }
}
