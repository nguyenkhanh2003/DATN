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
    public partial class Frm_NCC : Form
    {
        public Frm_NCC()
        {
            InitializeComponent();
        }
        NhaCungCap_BUS bus = new NhaCungCap_BUS();
        NhaCungCap ncc = new NhaCungCap();
        
        void Display()
        {
            dataGridViewNhaCungCap.DataSource = bus.GetData("");
        }
        void AllTextBoxNull()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtTrangThai.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {

        }
        
        private void dataGridViewNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Frm_NCC_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ncc.MaNCC = txtMaNCC.Text;
            ncc.TenNCC = txtTenNCC.Text;
            ncc.Email = txtEmail.Text;
            ncc.DienThoai = txtDienThoai.Text;
            ncc.DiaChi = txtDiaChi.Text;
            ncc.TrangThai = txtTrangThai.Text;
            bus.AddData(ncc);
            AllTextBoxNull();
            Display();
        }

        private void dataGridViewNhaCungCap_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Enabled = false;
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dataGridViewNhaCungCap.Rows[e.RowIndex];

            txtMaNCC.Text = row.Cells[0].Value.ToString();
            txtTenNCC.Text = row.Cells[1].Value.ToString();
            txtDiaChi.Text = row.Cells[2].Value.ToString();
            txtDienThoai.Text = row.Cells[3].Value.ToString();
            txtEmail.Text = row.Cells[4].Value.ToString();
            txtTrangThai.Text = row.Cells[5].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
            ncc.MaNCC = txtMaNCC.Text;
            ncc.TenNCC = txtTenNCC.Text;
            ncc.Email = txtEmail.Text;
            ncc.DienThoai = txtDienThoai.Text;
            ncc.DiaChi = txtDiaChi.Text;
            ncc.TrangThai = txtTrangThai.Text;
            bus.EditData(ncc);
            AllTextBoxNull();
            Display();
            MessageBox.Show("Sửa Thành Công");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNCC.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn Nhà Cung Cấp cần xóa", "Thông báo !");
                    return;
                }

                ncc.MaNCC = txtMaNCC.Text;
                bus.DeleteData(ncc);
                AllTextBoxNull();
                Display();
                MessageBox.Show("Xóa Thành Công");

            }
            catch
            {
                MessageBox.Show("Không thể xóa !");
            }
        }

    }
}
