
namespace DoAnCShap
{
    partial class Frm_BaoHanh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BaoHanh));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPBH = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHDBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLayHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCTPBH = new System.Windows.Forms.DataGridView();
            this.MaLKK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxNV = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNgayLayHang = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgaLap = new System.Windows.Forms.DateTimePicker();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemPhieu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxlK = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorMes = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPBH)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTPBH)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMes)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1062, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 39);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Đóng";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(36, 86);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(77, 39);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(306, 6);
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
            this.btnXoa.Location = new System.Drawing.Point(557, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 39);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(26, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Tạo Phiếu";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 43);
            this.panel1.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(281, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Tìm Kiếm Linh Kiện";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(441, 9);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 27);
            this.txtSearch.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridViewPBH);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 311);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Phiếu Bảo Hành";
            // 
            // dataGridViewPBH
            // 
            this.dataGridViewPBH.AllowUserToAddRows = false;
            this.dataGridViewPBH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPBH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPBH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewPBH.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaPBH,
            this.MaHDBH,
            this.MaNV,
            this.NgayLap,
            this.NgayLayHang,
            this.TrangThai});
            this.dataGridViewPBH.Location = new System.Drawing.Point(14, 21);
            this.dataGridViewPBH.Name = "dataGridViewPBH";
            this.dataGridViewPBH.ReadOnly = true;
            this.dataGridViewPBH.RowHeadersVisible = false;
            this.dataGridViewPBH.Size = new System.Drawing.Size(608, 276);
            this.dataGridViewPBH.TabIndex = 0;
            this.dataGridViewPBH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPBH_CellClick);
            this.dataGridViewPBH.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewPBH_RowPostPaint);
            this.dataGridViewPBH.DoubleClick += new System.EventHandler(this.dataGridViewPBH_DoubleClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MaPBH
            // 
            this.MaPBH.DataPropertyName = "MaPBH";
            this.MaPBH.HeaderText = "Mã Phiếu";
            this.MaPBH.Name = "MaPBH";
            this.MaPBH.ReadOnly = true;
            // 
            // MaHDBH
            // 
            this.MaHDBH.DataPropertyName = "MaHDBH";
            this.MaHDBH.HeaderText = "Mã Hóa Đơn";
            this.MaHDBH.Name = "MaHDBH";
            this.MaHDBH.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "TenNV";
            this.MaNV.HeaderText = "Tên Nhân Viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLapPhieu";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // NgayLayHang
            // 
            this.NgayLayHang.DataPropertyName = "NgayLayHang";
            this.NgayLayHang.HeaderText = "Ngày Lấy Hàng";
            this.NgayLayHang.Name = "NgayLayHang";
            this.NgayLayHang.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridViewCTPBH);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(646, 388);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 311);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Chi Tiết Phiếu";
            // 
            // dataGridViewCTPBH
            // 
            this.dataGridViewCTPBH.AllowUserToAddRows = false;
            this.dataGridViewCTPBH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCTPBH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCTPBH.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCTPBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTPBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLKK,
            this.SoLuong,
            this.GhiChu});
            this.dataGridViewCTPBH.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewCTPBH.Name = "dataGridViewCTPBH";
            this.dataGridViewCTPBH.ReadOnly = true;
            this.dataGridViewCTPBH.RowHeadersVisible = false;
            this.dataGridViewCTPBH.Size = new System.Drawing.Size(514, 276);
            this.dataGridViewCTPBH.TabIndex = 0;
            this.dataGridViewCTPBH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCTPBH_CellClick);
            this.dataGridViewCTPBH.DoubleClick += new System.EventHandler(this.dataGridViewCTPBH_DoubleClick);
            // 
            // MaLKK
            // 
            this.MaLKK.DataPropertyName = "TenLK";
            this.MaLKK.HeaderText = "Tên Linh Kiện";
            this.MaLKK.Name = "MaLKK";
            this.MaLKK.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnIn);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Location = new System.Drawing.Point(12, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 54);
            this.panel2.TabIndex = 11;
            // 
            // btnIn
            // 
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.Location = new System.Drawing.Point(803, 6);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(91, 39);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "In";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnTim);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.comboBoxNV);
            this.panel3.Controls.Add(this.dateTimePickerNgayLayHang);
            this.panel3.Controls.Add(this.dateTimePickerNgaLap);
            this.panel3.Controls.Add(this.txtMaHD);
            this.panel3.Controls.Add(this.txtMaPhieu);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 242);
            this.panel3.TabIndex = 12;
            // 
            // btnTim
            // 
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(415, 80);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(40, 25);
            this.btnTim.TabIndex = 15;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Teal;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(497, 26);
            this.label10.TabIndex = 14;
            this.label10.Text = "Thông Tin Bảo Hành";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxNV
            // 
            this.comboBoxNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNV.FormattingEnabled = true;
            this.comboBoxNV.Location = new System.Drawing.Point(205, 122);
            this.comboBoxNV.Name = "comboBoxNV";
            this.comboBoxNV.Size = new System.Drawing.Size(192, 24);
            this.comboBoxNV.TabIndex = 13;
            // 
            // dateTimePickerNgayLayHang
            // 
            this.dateTimePickerNgayLayHang.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerNgayLayHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayLayHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayLayHang.Location = new System.Drawing.Point(205, 200);
            this.dateTimePickerNgayLayHang.Name = "dateTimePickerNgayLayHang";
            this.dateTimePickerNgayLayHang.Size = new System.Drawing.Size(192, 26);
            this.dateTimePickerNgayLayHang.TabIndex = 11;
            // 
            // dateTimePickerNgaLap
            // 
            this.dateTimePickerNgaLap.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerNgaLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgaLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgaLap.Location = new System.Drawing.Point(205, 160);
            this.dateTimePickerNgaLap.Name = "dateTimePickerNgaLap";
            this.dateTimePickerNgaLap.Size = new System.Drawing.Size(192, 26);
            this.dateTimePickerNgaLap.TabIndex = 12;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(205, 80);
            this.txtMaHD.Multiline = true;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(192, 25);
            this.txtMaHD.TabIndex = 9;
            this.txtMaHD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHD_KeyPress);
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Location = new System.Drawing.Point(205, 40);
            this.txtMaPhieu.Multiline = true;
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(192, 25);
            this.txtMaPhieu.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ngày Lấy Hàng";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày Lập";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã Hóa Đơn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên Nhân Viên";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Phiếu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThemPhieu
            // 
            this.btnThemPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhieu.Image")));
            this.btnThemPhieu.Location = new System.Drawing.Point(36, 15);
            this.btnThemPhieu.Name = "btnThemPhieu";
            this.btnThemPhieu.Size = new System.Drawing.Size(79, 38);
            this.btnThemPhieu.TabIndex = 4;
            this.btnThemPhieu.Text = "Thêm";
            this.btnThemPhieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemPhieu.UseVisualStyleBackColor = true;
            this.btnThemPhieu.Click += new System.EventHandler(this.btnThemPhieu_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.comboBoxlK);
            this.panel4.Controls.Add(this.txtGhiChu);
            this.panel4.Controls.Add(this.txtSL);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(516, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(656, 242);
            this.panel4.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Teal;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(654, 26);
            this.label11.TabIndex = 17;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxlK
            // 
            this.comboBoxlK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxlK.FormattingEnabled = true;
            this.comboBoxlK.Location = new System.Drawing.Point(168, 41);
            this.comboBoxlK.Name = "comboBoxlK";
            this.comboBoxlK.Size = new System.Drawing.Size(222, 24);
            this.comboBoxlK.TabIndex = 11;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(168, 135);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(222, 69);
            this.txtGhiChu.TabIndex = 15;
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(168, 82);
            this.txtSL.Multiline = true;
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(222, 25);
            this.txtSL.TabIndex = 16;
            this.txtSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ghi Chú";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số Lượng";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tên linh Kiện";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorMes
            // 
            this.errorMes.ContainerControl = this;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnThemPhieu);
            this.panel5.Controls.Add(this.btnHuy);
            this.panel5.Location = new System.Drawing.Point(449, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(187, 208);
            this.panel5.TabIndex = 18;
            // 
            // Frm_BaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_BaoHanh";
            this.Text = "Frm_BaoHanh";
            this.Load += new System.EventHandler(this.Frm_BaoHanh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPBH)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTPBH)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMes)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewPBH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewCTPBH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxNV;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLayHang;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaLap;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemPhieu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxlK;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLKK;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.ErrorProvider errorMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLayHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Panel panel5;
    }
}