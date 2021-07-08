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
            AnButton();
            Display();
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
            txtDiaChi.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            //btnUpdate.Enabled = false;
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
            txtDiaChi.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            //btnUpdate.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        
        void Display()
        {
            dataGridViewNhaCungCap.DataSource = bus.GetData("");
        }

        public void PhatSinhMa()
        {
            int count = 0;
            count = dataGridViewNhaCungCap.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtMaNCC.Text = "NCC00";
            }
            else
            {
                chuoi = Convert.ToString(dataGridViewNhaCungCap.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    txtMaNCC.Text = "NCC0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtMaNCC.Text = "NCC" + (chuoi2 + 1).ToString();
            }
        }

        public void HienThiSearch(string condition)
        {
            dataGridViewNhaCungCap.DataSource = bus.GetSearch("Select * from NhaCungCap Where TenNCC Like N'%" + condition + "%'");
        }
        void AllTextBoxNull()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
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
            PhatSinhMa();
            addnew = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;

        }
        //hien du lieu tu datatable len button
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
            txtDiaChi.Text = row.Cells[5].Value.ToString();
            HienButton();
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;


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
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Lỗi mã nhà cung cấp !");
                return;
            }
            if (txtTenNCC.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại tên nhà cung cấp !");
                return;
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại số điện thoại của nhà cung cấp !");
                return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại trạng thái của nhà cung cấp !");
                return;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Chưa nhập email");
                return;
            }
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
                            ncc.TrangThai = cbotrangthai.Text;
                            bus.AddData(ncc);
                            MessageBox.Show("Thành Công");
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
                            ncc.TrangThai = cbotrangthai.Text;
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
          //  Display();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string condition = txtSearch.Text;
            HienThiSearch(condition);
        }
      
        private void btnTHoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Thông Báo", "Bạn có muốn hủy hay không ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(KQ==DialogResult.OK)
            {
                
            }    
        }
    }
}
