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
            Display();
        }
        NhaCungCap_BUS bus = new NhaCungCap_BUS();
        NhaCungCap ncc = new NhaCungCap();
        bool addnew;
        public void XuLyChucNang(Boolean b1, Boolean b2, Boolean b3)
        {
            btnAdd.Enabled = b1;
            btnDelete.Enabled = b3;
            btnCancel.Enabled = b2;
            btnSave.Enabled = b2;
        }
        public void XuLyTexBox(Boolean b1, Boolean b2)
        {
            txtMaNCC.ReadOnly = b2;
            txtMaNCC.Enabled = b2;
            txtEmail.Enabled = b2;
            txtDiaChi.Enabled = b2;
            txtDienThoai.Enabled = b2;
            txtTenNCC.Enabled = b2;
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
            if (count <= 0)
            {
                txtMaNCC.Text = "NCC00";
            }
            else
            {
                chuoi = Convert.ToString(dataGridViewNhaCungCap.Rows[count - 1].Cells[1].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    txtMaNCC.Text = "NCC0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtMaNCC.Text = "NCC" + (chuoi2 + 1).ToString();
            }
        }

        public string PhatSinhMaNCC(DataTable d)
        {
            int sodong = d.Rows.Count;
            string macuoi;
            if (sodong > 9)
                macuoi = d.Rows[sodong - 1]["MaNCC"].ToString().Substring(3, 2);
            else
                macuoi = d.Rows[sodong - 1]["MaNCC"].ToString().Substring(4, 1);
            return (int.Parse(macuoi) + 1).ToString();
        }

        public void HienThiSearch(string condition)
        {
            dataGridViewNhaCungCap.DataSource = bus.GetSearch("Select * from NhaCungCap Where TenNCC Like N'%" + condition + "%'");
        }
        public void ClearTextBox()
        {
            txtTenNCC.Clear();
            txtMaNCC.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            errorMes.Clear();
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
                ClearTextBox();
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
            XuLyChucNang(false, true, false);
            ClearTextBox();
            if ((bus.PhatSinhMa("")).Rows.Count == 0)
            {
                txtMaNCC.Text = "NCC00";
            }
            else
            {
                if (int.Parse(PhatSinhMaNCC(bus.PhatSinhMa(""))) < 10)
                    txtMaNCC.Text = "NCC0" + PhatSinhMaNCC(bus.PhatSinhMa(""));
                else
                    txtMaNCC.Text = "NCC" + PhatSinhMaNCC(bus.PhatSinhMa(""));
            }
            addnew = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;

        }

        public void HienThiNCC_TXT(int vitri, DataTable d)
        {
            try
            {
                txtMaNCC.Text = d.Rows[vitri]["MaNCC"].ToString();
                txtTenNCC.Text = d.Rows[vitri]["TenNCC"].ToString();
                txtDiaChi.Text = d.Rows[vitri]["DiaChi"].ToString();
                txtDienThoai.Text = d.Rows[vitri]["DienThoai"].ToString();
                txtEmail.Text = d.Rows[vitri]["Email"].ToString();
            }
            catch
            {

            }
        }
        //hien du lieu tu datatable len button
        private void dataGridViewNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dataGridViewNhaCungCap.CurrentCell.RowIndex;
            HienThiNCC_TXT(vitri, bus.GetData(""));
            XuLyChucNang(true, true, true);
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
                    if (txtMaNCC.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtMaNCC, "? MaNCC");
                        return;
                    }
                    if (txtTenNCC.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtTenNCC, "? TenNCC");
                        return;
                    }
                    if (txtDienThoai.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtDienThoai, "? Điện Thoại");
                        return;
                    }
                    if (txtDienThoai.Text.Length < 10)
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtDienThoai, "Số điện thoại không đúng");
                        return;
                    }
                    if (txtDiaChi.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtDiaChi, "? Địa chỉ");
                        return;
                    }

                    if (txtEmail.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtEmail, "? Email");
                        return;
                    }
                    else
                    {
                        ncc.MaNCC = txtMaNCC.Text;
                        ncc.TenNCC = txtTenNCC.Text;
                        ncc.Email = txtEmail.Text;
                        ncc.DienThoai = txtDienThoai.Text;
                        ncc.DiaChi = txtDiaChi.Text;
                        ncc.TrangThai = "1";
                        bus.AddData(ncc);
                        MessageBox.Show("Thành Công");
                        ClearTextBox();
                        XuLyChucNang(true, false, false);
                        XuLyTexBox(true, false);
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
                    if (txtMaNCC.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtMaNCC, "? MaNCC");
                        return;
                    }
                    if (txtTenNCC.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtTenNCC, "? TenNCC");
                        return;
                    }
                    if (txtDienThoai.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtDienThoai, "? Điện Thoại");
                        return;
                    }
                    if (txtDienThoai.Text.Length < 10)
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtDienThoai, "Số điện thoại không đúng");
                        return;
                    }
                    if (txtDiaChi.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtDiaChi, "? Địa chỉ");
                        return;
                    }

                    if (txtEmail.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtEmail, "? Email");
                        return;
                    }
                    else
                    {
                        ncc.MaNCC = txtMaNCC.Text;
                        ncc.TenNCC = txtTenNCC.Text;
                        ncc.Email = txtEmail.Text;
                        ncc.DienThoai = txtDienThoai.Text;
                        ncc.DiaChi = txtDiaChi.Text;
                        ncc.TrangThai = "1";
                        bus.EditData(ncc);
                        MessageBox.Show("Sửa Thành Công");
                        ClearTextBox();
                        XuLyChucNang(true, false, false);
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể sửa được !");
                    return;
                }

            }
            Display();

        }

        private void Frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            XuLyChucNang(true, false, false);
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
            DialogResult KQ = MessageBox.Show("Bạn có muốn hủy hay không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (KQ == DialogResult.OK)
            {
                XuLyChucNang(true, false, false);
            }
        }

        private void dataGridViewNhaCungCap_DoubleClick(object sender, EventArgs e)
        {
            XuLyChucNang(false, true, true);
            XuLyTexBox(false, true);
        }


        private void dataGridViewNhaCungCap_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewNhaCungCap.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
