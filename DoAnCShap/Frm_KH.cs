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
        DataSet ds = new DataSet();
        int flag = 0;
        bool addnew;
        void Display()
        {
            dataGridViewKH.DataSource = bus.GetData("");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string PhatSinh_Ma(DataSet ds)
        {
            int sodong = ds.Tables[0].Rows.Count;
            string macuoi;
            if (sodong > 9)
                macuoi = ds.Tables[0].Rows[sodong - 1]["MaKH"].ToString().Substring(2, 2);
            else
                macuoi = ds.Tables[0].Rows[sodong - 1]["MaKH"].ToString().Substring(3, 1);
            return (int.Parse(macuoi) + 1).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void xulytextbox(Boolean b1,Boolean b2)
        {
            txtMaKh.Enabled =b1;
            txtTenkh.Enabled =b1;
            cboGioiTinh.Enabled =b1;
            txtEmail.Enabled = b1;
            txtSdt.Enabled =b1;
            txtCMND.Enabled = b1;
            txtDiaChi.Enabled =b1;
            cboTrangThai.Enabled =b1;
        }
        public void xulychucnang(Boolean b1,Boolean b2)
        {
            btnThem.Enabled =b1;
            btnXoa.Enabled = b2;
            btnLuu.Enabled = b2;
            btnHuy.Enabled = b2;
        }

        public void hienthibutton()
        {

        }
        private void Frm_KH_Load(object sender, EventArgs e)
        {
            xulytextbox(false,true);
            xulychucnang(true,false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulychucnang(false, true);
            xulytextbox(true, false);
            flag = 1;
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(flag==1)
            {
                kh.MaKH =txtMaKh.Text;
                kh.TenKH = txtTenkh.Text;
                kh.GioiTinh = cboGioiTinh.Text;
                kh.Email = txtEmail.Text;
                kh.DienThoai = txtSdt.Text;
                kh.CMND = txtCMND.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.TrangThai = cboTrangThai.Text;
                bus.AddData(kh); ;
                MessageBox.Show("Thêm Khách Hàng Thành Công");
            }
            if(flag==2)
            {
                kh.TenKH = txtTenkh.Text;
                kh.GioiTinh = cboGioiTinh.Text;
                kh.Email = txtEmail.Text;
                kh.DienThoai = txtSdt.Text;
                kh.CMND = txtCMND.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.TrangThai = cboTrangThai.Text;
                bus.EditData(kh); ;
                MessageBox.Show("Sửa Dữ Liệu Thành Công");
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
            txtEmail.Text = row.Cells[3].Value.ToString();
            txtSdt.Text = row.Cells[4].Value.ToString();
            txtCMND.Text = row.Cells[5].Value.ToString();
            txtDiaChi.Text = row.Cells[6].Value.ToString();
            cboTrangThai.Text = row.Cells[7].Value.ToString();
            xulytextbox(false,true);
        }

        private void dataGridViewKH_DoubleClick(object sender, EventArgs e)
        {
            xulytextbox(true, false);
            xulychucnang(false,true);
            flag = 2;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông Báo !!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (KQ == DialogResult.Yes)
            {
                kh.MaKH = txtMaKh.Text;
                bus.DeleteData(kh);
                MessageBox.Show("Xóa Dữ Liệu Thành Công");
            }
            Display();
        }
    }
}
