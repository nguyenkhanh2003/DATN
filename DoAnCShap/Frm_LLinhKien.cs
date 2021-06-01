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
    public partial class Frm_LLinhKien : Form
    {
        public Frm_LLinhKien()
        {
            InitializeComponent();
            Display();
        }

        LoaiLinhKien_BUS bus = new LoaiLinhKien_BUS();
        LoaiLinhKien llk = new LoaiLinhKien();
        int flag = 0;
         public void Display()
        {

            dataGridViewKH.DataSource = bus.GetData("");
        }
        public void xulytextbox(Boolean b1, Boolean b2)
        {
            txtMaLoai.Enabled = b1;
            txtTenLoai.Enabled = b1;
            cboTrangThai.Enabled = b1;
            
        }

        public void xulychucnang(Boolean b1, Boolean b2)
        {
            btnThem.Enabled = b1;
            btnXoa.Enabled = b2;
            btnLuu.Enabled = b2;
            btnHuy.Enabled = b2;
        }

        public void clear()
        {
            txtMaLoai.Clear();
            txtTenLoai.Clear();
            cboTrangThai.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulychucnang(false, true);
            xulytextbox(true, false);
            flag = 1;
        }

        private void Frm_LLinhKien_Load(object sender, EventArgs e)
        {
            xulytextbox(false, true);
            xulychucnang(true, false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
         
            if (txtMaLoai.Text != "" && txtTenLoai.Text != "" &&cboTrangThai.Text !="")
              {
                if (flag == 1)
                {
                    llk.MaLLK = txtMaLoai.Text;
                    llk.TenLLK = txtTenLoai.Text;
                    llk.TrangThai = cboTrangThai.Text;
                    bus.AddData(llk); ;
                    MessageBox.Show("Thêm Loại Linh Kiện Thành Công");
                }
                clear();
                        }
            else
            {
                MessageBox.Show("Dữ liệu không được để trống");
            }
             
           
            if(flag==2)
            {
                llk.MaLLK = txtMaLoai.Text;
                llk.TenLLK = txtTenLoai.Text;
                llk.TrangThai = cboTrangThai.Text;
                bus.EditData(llk);
                MessageBox.Show("Sửa Loại linh Kiện Thành Công");
            }    
            Display();
        }

        private void dataGridViewKH_DoubleClick(object sender, EventArgs e)
        {
            xulytextbox(true, false);
            xulychucnang(false, true);
            flag = 2;
        }

        private void dataGridViewKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dataGridViewKH.Rows[e.RowIndex];
            txtMaLoai.Text = row.Cells[0].Value.ToString();
            txtTenLoai.Text = row.Cells[1].Value.ToString();
            cboTrangThai.Text = row.Cells[2].Value.ToString();
            xulytextbox(false, true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông Báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (KQ == DialogResult.Yes)
            {
                llk.MaLLK = txtMaLoai.Text;
                bus.DeleteData(llk);
                MessageBox.Show("Xóa Dữ Liệu Thành Công");
                clear();
            }
            Display();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
