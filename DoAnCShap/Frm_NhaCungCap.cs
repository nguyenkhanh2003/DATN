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
    public partial class Frm_NhaCungCap : Form
    {
        public Frm_NhaCungCap()
        {
            InitializeComponent();
        }
        NhaCungCap_BUS bus = new NhaCungCap_BUS();
        NhaCungCap ncc = new NhaCungCap();
        bool addnew;
        void AnButton()
        {
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;
            txtEmail.Enabled = false;
            txtTrangThai.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        void HienButton()
        {
            txtMaNCC.Enabled = true;
            txtTenNCC.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            txtEmail.Enabled = true;
            txtTrangThai.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HienButton();
            AllTextBoxNull();
            addnew = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;

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
            try
            {
                if (txtMaNCC.Text == "")
                {
                    MessageBox.Show("Vui lòng nhấp chọn bên dưới !", "Thông báo !");
                    return;
                }
                HienButton();
                addnew = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                Display();
            }
            catch { }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (addnew == true)
            {
                try
                {
                    if (txtDienThoai.Text.Length < 10)
                    {
                        MessageBox.Show("Số điện thoại không đúng !");
                        return;
                    }
                    else
                    {
                        if (txtDienThoai.Text.Length == 10 || txtDienThoai.Text.Length == 11)
                        {
                            ncc.MaNCC = txtMaNCC.Text;
                            ncc.TenNCC = txtTenNCC.Text;
                            ncc.Email = txtEmail.Text;
                            ncc.DienThoai = txtDienThoai.Text;
                            ncc.DiaChi = txtDiaChi.Text;
                            ncc.TrangThai = txtTrangThai.Text;
                            bus.AddData(ncc);
                            AllTextBoxNull();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể thêm mới được !");
                    return;
                }
            }
            else
            {
                try
                {
                    if (txtDienThoai.Text.Length < 10)
                    {
                        MessageBox.Show("Số điện thoại không đúng !");
                        return;
                    }
                    else
                    {
                        if (txtDienThoai.Text.Length == 10 || txtDienThoai.Text.Length == 11)
                        {
                            ncc.MaNCC = txtMaNCC.Text;
                            ncc.TenNCC = txtTenNCC.Text;
                            ncc.Email = txtEmail.Text;
                            ncc.DienThoai = txtDienThoai.Text;
                            ncc.DiaChi = txtDiaChi.Text;
                            ncc.TrangThai = txtTrangThai.Text;
                            bus.EditData(ncc);
                            AllTextBoxNull();
                            MessageBox.Show("Sửa Thành Công");

                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể sửa được !");
                    return;
                }

            }
            AnButton();
            Display();

        }

        private void Frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            Display();
        }
    }
}
