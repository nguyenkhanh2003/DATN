using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace DoAnCShap
{
    public partial class Frm_KH : Form
    {
        public Frm_KH()
        {
            InitializeComponent();
            Display();
        }

        KhachHang_BUS bus = new KhachHang_BUS();
        KhachHang kh = new KhachHang();
        DataTable dt;
        int flag = 0;
        bool addnew;

        public void HienThiSearch(String Condition)
        {
            dataGridViewKH.DataSource = bus.GetSearch("Select * From KhachHang Where TenKH Like N'%" + Condition + "%'");
        }
        void Display()
        {
            dataGridViewKH.DataSource = bus.GetData("");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void xulytextbox(Boolean b1, Boolean b2)
        {
            txtMaKh.ReadOnly = b1;
            txtMaKh.Enabled = b1;
            txtTenkh.Enabled = b1;
            cboGioiTinh.Enabled = b1;
            txtSdt.Enabled = b1;
            //txtCMND.Enabled = b1;
            txtDiaCh.Enabled = b1;
            cboTrangThai.Enabled = b1;
        }
        public void xulychucnang(Boolean b1, Boolean b2, Boolean b3)
        {
            btnThem.Enabled = b1;
            btnXoa.Enabled = b3;
            btnLuu.Enabled = b2;
            btnHuy.Enabled = b2;
        }

        public void Clear()
        {
            txtMaKh.Clear();
            txtTenkh.Clear();
            txtDiaCh.Clear();
            txtDiaCh.Clear();
            txtSdt.Clear();
            cboGioiTinh.Text = "";
            cboTrangThai.Text = "";
        }
        public void PhatSinhMa()
        {
            int count = 0;
            count = dataGridViewKH.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtMaKh.Text = "KH00";
            }
            else
            {
                chuoi = Convert.ToString(dataGridViewKH.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    txtMaKh.Text = "KH0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtMaKh.Text = "KH" + (chuoi2 + 1).ToString();
            }
        }
        public String PhatSinhMa(DataTable dt)
        {
            int sodong = dataGridViewKH.Rows.Count;
            string macuoi;
            if (sodong > 9)
                macuoi = dt.Rows[0].ToString().Substring(2, 2);
            else
                macuoi = dt.Rows[sodong - 1][0].ToString().Substring(3, 1);
            return (int.Parse(macuoi) + 1).ToString();
        }

        public void hienthibutton()
        {

        }
        private void Frm_KH_Load(object sender, EventArgs e)
        {
            xulytextbox(false, true);
            xulychucnang(true, false, false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulychucnang(false, true, false);
            xulytextbox(true, false);
            Clear();
            flag = 1;
            PhatSinhMa();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenkh.Text == "")
            {
                MessageBox.Show("Chưa nhập tên khách hàng");
                return;
            }
            if (cboGioiTinh.Text == "")
            {
                MessageBox.Show("Chưa chọn giới tính");
                return;
            }

            if (txtSdt.Text == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại");
                return;
            }
            if (txtDiaCh.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                return;
            }
            if (cboGioiTinh.Text == "")
            {
                MessageBox.Show("Chưa chọn trạng thái");
                return;
            }
            if (flag == 1)
            {
                try
                {
                    if (txtSdt.Text.Length < 10)
                    {
                        MessageBox.Show("Số điện thoại không đúng");
                    }
                    else
                    {
                        kh.MaKH = txtMaKh.Text;
                        kh.TenKH = txtTenkh.Text;
                        kh.GioiTinh = cboGioiTinh.Text;

                        kh.DienThoai = txtSdt.Text;
                        kh.DiaChi = txtDiaCh.Text;
                        kh.TrangThai = cboTrangThai.Text;
                        bus.AddData(kh); ;
                        MessageBox.Show("Thêm Khách Hàng Thành Công");
                        xulychucnang(true, false, false);
                        Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể thêm được");
                }

            }
            if (flag == 2)
            {
                if (txtSdt.Text.Length < 10)
                {
                    MessageBox.Show("Số điện thoại không đúng");
                }
                else
                {
                    kh.MaKH = txtMaKh.Text;
                    kh.TenKH = txtTenkh.Text;
                    kh.GioiTinh = cboGioiTinh.Text;

                    kh.DienThoai = txtSdt.Text;
                    kh.DiaChi = txtDiaCh.Text;
                    kh.TrangThai = cboTrangThai.Text;
                    bus.EditData(kh); ;
                    MessageBox.Show("Sửa Dữ Liệu Thành Công");
                    xulychucnang(true, false, false);
                    Clear();
                }
            }

            Display();
        }

        private void dataGridViewKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKh.Enabled = false;
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dataGridViewKH.Rows[e.RowIndex];
            txtMaKh.Text = row.Cells[0].Value.ToString();
            txtTenkh.Text = row.Cells[1].Value.ToString();
            cboGioiTinh.Text = row.Cells[2].Value.ToString();
            txtSdt.Text = row.Cells[3].Value.ToString();
            txtDiaCh.Text = row.Cells[4].Value.ToString();
            cboTrangThai.Text = row.Cells[5].Value.ToString();
            xulytextbox(false, true);
        }

        private void dataGridViewKH_DoubleClick(object sender, EventArgs e)
        {
            xulytextbox(true, false);
            xulychucnang(false, true, true);
            flag = 2;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông Báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (KQ == DialogResult.Yes)
            {
                kh.MaKH = txtMaKh.Text;
                bus.DeleteData(kh);
                MessageBox.Show("Xóa Dữ Liệu Thành Công");
                xulychucnang(true, false, false);
                xulytextbox(true, false);
                Clear();
            }
            Display();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string Condition = txtSearch.Text;
            HienThiSearch(Condition);
        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtTenkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn hủy tác vụ ?", "Thông Báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (KQ == DialogResult.Yes)
            {
                xulychucnang(true, false, false);
                Clear();
                xulytextbox(false, true);
            }
            else
            {

            }
        }
    }
}
