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
    public partial class Frm_NSX : Form
    {
        public Frm_NSX()
        {
            InitializeComponent();
        }
        NhaSanXuat_BUS bus = new NhaSanXuat_BUS();
        NhaSanXuat nsx = new NhaSanXuat();
        int flag = 0;
        public void DisPlay()
        {
            dataGridViewNSX.DataSource = bus.GetData("");
        }

        public void xulytextbox(Boolean b1, Boolean b2)
        {
            txtMansx.Enabled = b1;
            txtTenNSX.Enabled = b1;
            txtDiaChi.Enabled = b1;
            cboTrangThai.Enabled = b1;
        }

        public void xulychucnang(Boolean b1, Boolean b2, Boolean b3)
        {
            btnThem.Enabled = b1;
            btnXoa.Enabled = b3;
            btnLuu.Enabled = b2;
            btnHuy.Enabled = b2;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            xulychucnang(false,true,true);
        }

        private void Frm_NSX_Load(object sender, EventArgs e)
        {
            DisPlay();
            xulychucnang(true, false, false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
               if(flag==1)
                {
                if (txtMansx.Text != "" && txtTenNSX.Text != "" && txtDiaChi.Text != "")
                {
                    nsx.MaNSX = txtMansx.Text;
                    nsx.TenNSX = txtTenNSX.Text;
                    nsx.DiaChi = txtDiaChi.Text;
                    nsx.TrangThai = cboTrangThai.Text;
                    bus.AddData(nsx);
                    MessageBox.Show("Thêm Nhà Sản Xuất Thành Công");
            
                }
                else
                {
                    MessageBox.Show("Fail!");
                }
                }
                if(flag==2)
            {
                nsx.MaNSX = txtMansx.Text;
                nsx.TenNSX = txtTenNSX.Text;
                nsx.DiaChi = txtDiaChi.Text;
                nsx.TrangThai = cboTrangThai.Text;
                bus.EditData(nsx);
                MessageBox.Show("Thành Công");
            }
            DisPlay();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewNSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewNSX.Rows[e.RowIndex];
            txtMansx.Text = row.Cells[0].Value.ToString();
            txtTenNSX.Text = row.Cells[1].Value.ToString();
            txtDiaChi.Text = row.Cells[2].Value.ToString();
            cboTrangThai.Text = row.Cells[3].Value.ToString();
        }

        private void dataGridViewNSX_DoubleClick(object sender, EventArgs e)
        {
            flag = 2;
            xulychucnang(false, true, true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nsx.MaNSX = txtMansx.Text;
            bus.DeleteData(nsx);
            MessageBox.Show("Thanh Cong");
            DisPlay();
        }
    }
}
