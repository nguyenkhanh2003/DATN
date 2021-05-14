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
            AnButton();
        }
        bool addnew;
        NhaCungCap_BUS bus = new NhaCungCap_BUS();
        NhaCungCap ncc = new NhaCungCap();

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
        void CheckButtonNull()
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Mã nhà cung cấp không được trống", "Thông báo !");
                return;
            }
            if (txtTenNCC.Text == "")
            {
                MessageBox.Show("Tên nhà cung cấp không được trống", "Thông báo !");
                return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ nhà cung cấp không được trống", "Thông báo !");
                return;
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Số điện thoại nhà cung cấp không được trống", "Thông báo !");
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Email nhà cung cấp không được trống", "Thông báo !");
                return;
            }
            if (txtTrangThai.Text == "")
            {
                MessageBox.Show("Trạng thái nhà cung cấp không được trống", "Thông báo !");
                return;
            }


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
            HienButton();
            AllTextBoxNull();
            addnew = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;


        }

        private void dataGridViewNhaCungCap_Click(object sender, EventArgs e)
        {

        }

        //hien du lieu tu datagrid len button
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
                if (txtMaNCC.Text == "" )
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

            private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
            {

                {
                    if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    {
                        MessageBox.Show("Input number only!");
                        e.Handled = true;
                    }
                }

            }

            private void btnThemNhaCungCap_Click(object sender, EventArgs e)
            {


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
        }
    }
