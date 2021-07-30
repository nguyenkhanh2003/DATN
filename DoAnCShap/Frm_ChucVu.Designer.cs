
namespace DoAnCShap
{
    partial class Frm_ChucVu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ChucVu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewCV = new System.Windows.Forms.DataGridView();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLNV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QLKH = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QLLK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QLBH = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QLNCC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QLLLK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QLNK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QLBaoHanh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ToanQ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ThongKe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HoaDon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Setting = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxSetting = new System.Windows.Forms.CheckBox();
            this.checkBoxHoaDon = new System.Windows.Forms.CheckBox();
            this.checkBoxThongKe = new System.Windows.Forms.CheckBox();
            this.checkBoxBaoHanh = new System.Windows.Forms.CheckBox();
            this.checkBoxNhapKho = new System.Windows.Forms.CheckBox();
            this.checkBoxLoaiLLK = new System.Windows.Forms.CheckBox();
            this.checkBoxPhanQuyen = new System.Windows.Forms.CheckBox();
            this.checkBoxLinhKien = new System.Windows.Forms.CheckBox();
            this.checkBoxNCC = new System.Windows.Forms.CheckBox();
            this.checkBoxNhanViem = new System.Windows.Forms.CheckBox();
            this.checkBoxkH = new System.Windows.Forms.CheckBox();
            this.checkBoxBanHang = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCV)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 43);
            this.panel1.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(199, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tìm Kiếm Nhanh";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(344, 11);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(306, 25);
            this.txtSearch.TabIndex = 0;
            // 
            // dataGridViewCV
            // 
            this.dataGridViewCV.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewCV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCV,
            this.TenCV,
            this.QLNV,
            this.QLKH,
            this.QLLK,
            this.QLBH,
            this.QLNCC,
            this.QLLLK,
            this.QLNK,
            this.QLBaoHanh,
            this.ToanQ,
            this.ThongKe,
            this.HoaDon,
            this.Setting,
            this.TrangThai});
            this.dataGridViewCV.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCV.Location = new System.Drawing.Point(32, 356);
            this.dataGridViewCV.Name = "dataGridViewCV";
            this.dataGridViewCV.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCV.RowHeadersVisible = false;
            this.dataGridViewCV.RowHeadersWidth = 51;
            this.dataGridViewCV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCV.Size = new System.Drawing.Size(1139, 182);
            this.dataGridViewCV.TabIndex = 25;
            this.dataGridViewCV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCV_CellClick);
            this.dataGridViewCV.DoubleClick += new System.EventHandler(this.dataGridViewCV_DoubleClick);
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Mã Chức Vụ";
            this.MaCV.MinimumWidth = 6;
            this.MaCV.Name = "MaCV";
            this.MaCV.ReadOnly = true;
            // 
            // TenCV
            // 
            this.TenCV.DataPropertyName = "TenCV";
            this.TenCV.HeaderText = "Tên Chức Vụ";
            this.TenCV.MinimumWidth = 6;
            this.TenCV.Name = "TenCV";
            this.TenCV.ReadOnly = true;
            // 
            // QLNV
            // 
            this.QLNV.DataPropertyName = "NhanVien";
            this.QLNV.HeaderText = "Nhân Viên";
            this.QLNV.Name = "QLNV";
            this.QLNV.ReadOnly = true;
            this.QLNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QLNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // QLKH
            // 
            this.QLKH.DataPropertyName = "KhachHang";
            this.QLKH.HeaderText = "Khách Hàng";
            this.QLKH.Name = "QLKH";
            this.QLKH.ReadOnly = true;
            this.QLKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QLKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // QLLK
            // 
            this.QLLK.DataPropertyName = "LinhKien";
            this.QLLK.HeaderText = "Linh Kiện";
            this.QLLK.Name = "QLLK";
            this.QLLK.ReadOnly = true;
            this.QLLK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QLLK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // QLBH
            // 
            this.QLBH.DataPropertyName = "BanHang";
            this.QLBH.HeaderText = "Bán Hàng";
            this.QLBH.Name = "QLBH";
            this.QLBH.ReadOnly = true;
            // 
            // QLNCC
            // 
            this.QLNCC.DataPropertyName = "NhaCungCap";
            this.QLNCC.HeaderText = "Nhà Cung Cấp";
            this.QLNCC.Name = "QLNCC";
            this.QLNCC.ReadOnly = true;
            this.QLNCC.Visible = false;
            // 
            // QLLLK
            // 
            this.QLLLK.DataPropertyName = "LoaiLK";
            this.QLLLK.HeaderText = "Loại Linh Kiện";
            this.QLLLK.Name = "QLLLK";
            this.QLLLK.ReadOnly = true;
            this.QLLLK.Visible = false;
            // 
            // QLNK
            // 
            this.QLNK.DataPropertyName = "NhapKho";
            this.QLNK.HeaderText = "Hóa Đơn Nhập";
            this.QLNK.Name = "QLNK";
            this.QLNK.ReadOnly = true;
            this.QLNK.Visible = false;
            // 
            // QLBaoHanh
            // 
            this.QLBaoHanh.DataPropertyName = "BaoHanh";
            this.QLBaoHanh.HeaderText = "Bảo Hành";
            this.QLBaoHanh.Name = "QLBaoHanh";
            this.QLBaoHanh.ReadOnly = true;
            this.QLBaoHanh.Visible = false;
            // 
            // ToanQ
            // 
            this.ToanQ.DataPropertyName = "PhanQuyen";
            this.ToanQ.HeaderText = "Phân Quyền";
            this.ToanQ.Name = "ToanQ";
            this.ToanQ.ReadOnly = true;
            this.ToanQ.Visible = false;
            // 
            // ThongKe
            // 
            this.ThongKe.DataPropertyName = "ThongKe";
            this.ThongKe.HeaderText = "Thống Kê";
            this.ThongKe.Name = "ThongKe";
            this.ThongKe.ReadOnly = true;
            this.ThongKe.Visible = false;
            // 
            // HoaDon
            // 
            this.HoaDon.DataPropertyName = "HoaDon";
            this.HoaDon.HeaderText = "Hóa Đơn";
            this.HoaDon.Name = "HoaDon";
            this.HoaDon.ReadOnly = true;
            this.HoaDon.Visible = false;
            // 
            // Setting
            // 
            this.Setting.DataPropertyName = "Setting";
            this.Setting.HeaderText = "Setting";
            this.Setting.Name = "Setting";
            this.Setting.ReadOnly = true;
            this.Setting.Visible = false;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TrangThai.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Location = new System.Drawing.Point(32, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1139, 59);
            this.panel3.TabIndex = 31;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(988, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 39);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Đóng";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(749, 9);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(91, 39);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(11, 9);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(523, 9);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 39);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(272, 9);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 39);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Chức Vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Chức Vụ";
            // 
            // txtMaCV
            // 
            this.txtMaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCV.Location = new System.Drawing.Point(177, 32);
            this.txtMaCV.Multiline = true;
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(207, 25);
            this.txtMaCV.TabIndex = 1;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCV.Location = new System.Drawing.Point(177, 77);
            this.txtTenCV.Multiline = true;
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(207, 25);
            this.txtTenCV.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtTenCV);
            this.panel2.Controls.Add(this.txtMaCV);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(32, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 182);
            this.panel2.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.checkBoxSetting);
            this.panel4.Controls.Add(this.checkBoxHoaDon);
            this.panel4.Controls.Add(this.checkBoxThongKe);
            this.panel4.Controls.Add(this.checkBoxBaoHanh);
            this.panel4.Controls.Add(this.checkBoxNhapKho);
            this.panel4.Controls.Add(this.checkBoxLoaiLLK);
            this.panel4.Controls.Add(this.checkBoxPhanQuyen);
            this.panel4.Controls.Add(this.checkBoxLinhKien);
            this.panel4.Controls.Add(this.checkBoxNCC);
            this.panel4.Controls.Add(this.checkBoxNhanViem);
            this.panel4.Controls.Add(this.checkBoxkH);
            this.panel4.Controls.Add(this.checkBoxBanHang);
            this.panel4.Location = new System.Drawing.Point(457, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(715, 182);
            this.panel4.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(713, 35);
            this.label4.TabIndex = 20;
            this.label4.Text = "Phân Quyền";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxSetting
            // 
            this.checkBoxSetting.AutoSize = true;
            this.checkBoxSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSetting.Location = new System.Drawing.Point(519, 139);
            this.checkBoxSetting.Name = "checkBoxSetting";
            this.checkBoxSetting.Size = new System.Drawing.Size(68, 20);
            this.checkBoxSetting.TabIndex = 12;
            this.checkBoxSetting.Text = "Setting";
            this.checkBoxSetting.UseVisualStyleBackColor = true;
            // 
            // checkBoxHoaDon
            // 
            this.checkBoxHoaDon.AutoSize = true;
            this.checkBoxHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHoaDon.Location = new System.Drawing.Point(337, 139);
            this.checkBoxHoaDon.Name = "checkBoxHoaDon";
            this.checkBoxHoaDon.Size = new System.Drawing.Size(80, 20);
            this.checkBoxHoaDon.TabIndex = 12;
            this.checkBoxHoaDon.Text = "Hóa Đơn";
            this.checkBoxHoaDon.UseVisualStyleBackColor = true;
            // 
            // checkBoxThongKe
            // 
            this.checkBoxThongKe.AutoSize = true;
            this.checkBoxThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxThongKe.Location = new System.Drawing.Point(156, 139);
            this.checkBoxThongKe.Name = "checkBoxThongKe";
            this.checkBoxThongKe.Size = new System.Drawing.Size(85, 20);
            this.checkBoxThongKe.TabIndex = 12;
            this.checkBoxThongKe.Text = "Thống Kê";
            this.checkBoxThongKe.UseVisualStyleBackColor = true;
            // 
            // checkBoxBaoHanh
            // 
            this.checkBoxBaoHanh.AutoSize = true;
            this.checkBoxBaoHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBaoHanh.Location = new System.Drawing.Point(9, 139);
            this.checkBoxBaoHanh.Name = "checkBoxBaoHanh";
            this.checkBoxBaoHanh.Size = new System.Drawing.Size(87, 20);
            this.checkBoxBaoHanh.TabIndex = 12;
            this.checkBoxBaoHanh.Text = "Bảo Hành";
            this.checkBoxBaoHanh.UseVisualStyleBackColor = true;
            // 
            // checkBoxNhapKho
            // 
            this.checkBoxNhapKho.AutoSize = true;
            this.checkBoxNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNhapKho.Location = new System.Drawing.Point(519, 86);
            this.checkBoxNhapKho.Name = "checkBoxNhapKho";
            this.checkBoxNhapKho.Size = new System.Drawing.Size(86, 20);
            this.checkBoxNhapKho.TabIndex = 14;
            this.checkBoxNhapKho.Text = "Nhập Kho";
            this.checkBoxNhapKho.UseVisualStyleBackColor = true;
            // 
            // checkBoxLoaiLLK
            // 
            this.checkBoxLoaiLLK.AutoSize = true;
            this.checkBoxLoaiLLK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLoaiLLK.Location = new System.Drawing.Point(337, 85);
            this.checkBoxLoaiLLK.Name = "checkBoxLoaiLLK";
            this.checkBoxLoaiLLK.Size = new System.Drawing.Size(164, 20);
            this.checkBoxLoaiLLK.TabIndex = 14;
            this.checkBoxLoaiLLK.Text = "Quản Lý Loại Linh Kiiện";
            this.checkBoxLoaiLLK.UseVisualStyleBackColor = true;
            // 
            // checkBoxPhanQuyen
            // 
            this.checkBoxPhanQuyen.AutoSize = true;
            this.checkBoxPhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPhanQuyen.Location = new System.Drawing.Point(519, 41);
            this.checkBoxPhanQuyen.Name = "checkBoxPhanQuyen";
            this.checkBoxPhanQuyen.Size = new System.Drawing.Size(100, 20);
            this.checkBoxPhanQuyen.TabIndex = 15;
            this.checkBoxPhanQuyen.Text = "Phân Quyền";
            this.checkBoxPhanQuyen.UseVisualStyleBackColor = true;
            // 
            // checkBoxLinhKien
            // 
            this.checkBoxLinhKien.AutoSize = true;
            this.checkBoxLinhKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLinhKien.Location = new System.Drawing.Point(337, 41);
            this.checkBoxLinhKien.Name = "checkBoxLinhKien";
            this.checkBoxLinhKien.Size = new System.Drawing.Size(132, 20);
            this.checkBoxLinhKien.TabIndex = 15;
            this.checkBoxLinhKien.Text = "Quản Lý Linh Kiện";
            this.checkBoxLinhKien.UseVisualStyleBackColor = true;
            // 
            // checkBoxNCC
            // 
            this.checkBoxNCC.AutoSize = true;
            this.checkBoxNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNCC.Location = new System.Drawing.Point(156, 85);
            this.checkBoxNCC.Name = "checkBoxNCC";
            this.checkBoxNCC.Size = new System.Drawing.Size(169, 20);
            this.checkBoxNCC.TabIndex = 16;
            this.checkBoxNCC.Text = "Quản Lý Nhà Cung  Cấp";
            this.checkBoxNCC.UseVisualStyleBackColor = true;
            // 
            // checkBoxNhanViem
            // 
            this.checkBoxNhanViem.AutoSize = true;
            this.checkBoxNhanViem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNhanViem.Location = new System.Drawing.Point(9, 41);
            this.checkBoxNhanViem.Name = "checkBoxNhanViem";
            this.checkBoxNhanViem.Size = new System.Drawing.Size(141, 20);
            this.checkBoxNhanViem.TabIndex = 17;
            this.checkBoxNhanViem.Text = "Quản Lý Nhân Viên";
            this.checkBoxNhanViem.UseVisualStyleBackColor = true;
            // 
            // checkBoxkH
            // 
            this.checkBoxkH.AutoSize = true;
            this.checkBoxkH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxkH.Location = new System.Drawing.Point(156, 41);
            this.checkBoxkH.Name = "checkBoxkH";
            this.checkBoxkH.Size = new System.Drawing.Size(152, 20);
            this.checkBoxkH.TabIndex = 18;
            this.checkBoxkH.Text = "Quản Lý Khách Hàng";
            this.checkBoxkH.UseVisualStyleBackColor = true;
            // 
            // checkBoxBanHang
            // 
            this.checkBoxBanHang.AutoSize = true;
            this.checkBoxBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBanHang.Location = new System.Drawing.Point(9, 86);
            this.checkBoxBanHang.Name = "checkBoxBanHang";
            this.checkBoxBanHang.Size = new System.Drawing.Size(87, 20);
            this.checkBoxBanHang.TabIndex = 19;
            this.checkBoxBanHang.Text = "Bán Hàng";
            this.checkBoxBanHang.UseVisualStyleBackColor = true;
            // 
            // Frm_ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewCV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_ChucVu";
            this.Text = "Frm_PhanQuyen";
            this.Load += new System.EventHandler(this.Frm_ChucVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridViewCV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxBaoHanh;
        private System.Windows.Forms.CheckBox checkBoxLoaiLLK;
        private System.Windows.Forms.CheckBox checkBoxLinhKien;
        private System.Windows.Forms.CheckBox checkBoxNCC;
        private System.Windows.Forms.CheckBox checkBoxNhanViem;
        private System.Windows.Forms.CheckBox checkBoxkH;
        private System.Windows.Forms.CheckBox checkBoxBanHang;
        private System.Windows.Forms.CheckBox checkBoxNhapKho;
        private System.Windows.Forms.CheckBox checkBoxPhanQuyen;
        private System.Windows.Forms.CheckBox checkBoxSetting;
        private System.Windows.Forms.CheckBox checkBoxHoaDon;
        private System.Windows.Forms.CheckBox checkBoxThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QLNV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QLKH;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QLLK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QLBH;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QLNCC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QLLLK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QLNK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QLBaoHanh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ToanQ;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ThongKe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HoaDon;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Setting;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}