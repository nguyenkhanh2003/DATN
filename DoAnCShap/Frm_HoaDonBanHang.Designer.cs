﻿namespace DoAnCShap
{
    partial class Frm_HoaDonBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HoaDonBanHang));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHD = new System.Windows.Forms.DataGridView();
            this.MaHDBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCTHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerNgaylap = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTrangThai = new System.Windows.Forms.ComboBox();
            this.comboBoxKH = new System.Windows.Forms.ComboBox();
            this.comboBoxNhanVien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTongThanhToan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxLK = new System.Windows.Forms.ComboBox();
            this.CboTrangThai = new System.Windows.Forms.ComboBox();
            this.txtKhuyenMai = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelThanhTien = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnDong);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(0, 641);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1184, 70);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(517, 20);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 44);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(1014, 19);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(95, 44);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(780, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 44);
            this.button3.TabIndex = 0;
            this.button3.Text = "Reset";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(274, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 44);
            this.button2.TabIndex = 0;
            this.button2.Text = "In Hóa Đơn";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(37, 20);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(103, 44);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu Hóa Đơn";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dataGridViewHD);
            this.groupBox1.Location = new System.Drawing.Point(7, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 340);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hóa Đơn";
            // 
            // dataGridViewHD
            // 
            this.dataGridViewHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHD.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDBH,
            this.MaKH,
            this.MaNV,
            this.NgayLap,
            this.TongTien,
            this.TrangThai});
            this.dataGridViewHD.Location = new System.Drawing.Point(5, 19);
            this.dataGridViewHD.Name = "dataGridViewHD";
            this.dataGridViewHD.Size = new System.Drawing.Size(639, 302);
            this.dataGridViewHD.TabIndex = 0;
            this.dataGridViewHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHD_CellClick);
            this.dataGridViewHD.DoubleClick += new System.EventHandler(this.dataGridViewHD_DoubleClick);
            // 
            // MaHDBH
            // 
            this.MaHDBH.DataPropertyName = "MaHDBH";
            this.MaHDBH.HeaderText = "Mã Hóa Đơn";
            this.MaHDBH.Name = "MaHDBH";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "TenKH";
            this.MaKH.HeaderText = "Khách Hàng";
            this.MaKH.Name = "MaKH";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "TenNV";
            this.MaNV.HeaderText = "Nhân Viên";
            this.MaNV.Name = "MaNV";
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLapHDBH";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.Name = "NgayLap";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridViewCTHD);
            this.groupBox2.Location = new System.Drawing.Point(663, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 340);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Chi Tiết Hóa Đơn";
            // 
            // dataGridViewCTHD
            // 
            this.dataGridViewCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCTHD.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaLK,
            this.SoLuong,
            this.DonGia,
            this.KhuyenMai,
            this.ThanhTien,
            this.TrangThaii});
            this.dataGridViewCTHD.Location = new System.Drawing.Point(6, 20);
            this.dataGridViewCTHD.Name = "dataGridViewCTHD";
            this.dataGridViewCTHD.Size = new System.Drawing.Size(497, 301);
            this.dataGridViewCTHD.TabIndex = 0;
            this.dataGridViewCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCTHD_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHDBH";
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.Name = "MaHD";
            // 
            // MaLK
            // 
            this.MaLK.DataPropertyName = "TenLK";
            this.MaLK.HeaderText = "Tên Linh Kiện";
            this.MaLK.Name = "MaLK";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            // 
            // KhuyenMai
            // 
            this.KhuyenMai.DataPropertyName = "KhuyenMai";
            this.KhuyenMai.HeaderText = "Khuyến Mãi";
            this.KhuyenMai.Name = "KhuyenMai";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // TrangThaii
            // 
            this.TrangThaii.DataPropertyName = "TrangThai";
            this.TrangThaii.HeaderText = "Trạng Thái";
            this.TrangThaii.Name = "TrangThaii";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePickerNgaylap);
            this.groupBox4.Controls.Add(this.comboBoxTrangThai);
            this.groupBox4.Controls.Add(this.comboBoxKH);
            this.groupBox4.Controls.Add(this.comboBoxNhanVien);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.labelTongThanhToan);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtMaHD);
            this.groupBox4.Location = new System.Drawing.Point(89, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(446, 277);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Hóa Đơn";
            // 
            // dateTimePickerNgaylap
            // 
            this.dateTimePickerNgaylap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgaylap.Location = new System.Drawing.Point(167, 145);
            this.dateTimePickerNgaylap.Name = "dateTimePickerNgaylap";
            this.dateTimePickerNgaylap.Size = new System.Drawing.Size(232, 29);
            this.dateTimePickerNgaylap.TabIndex = 34;
            // 
            // comboBoxTrangThai
            // 
            this.comboBoxTrangThai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTrangThai.FormattingEnabled = true;
            this.comboBoxTrangThai.Location = new System.Drawing.Point(166, 231);
            this.comboBoxTrangThai.Name = "comboBoxTrangThai";
            this.comboBoxTrangThai.Size = new System.Drawing.Size(233, 29);
            this.comboBoxTrangThai.TabIndex = 33;
            // 
            // comboBoxKH
            // 
            this.comboBoxKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKH.FormattingEnabled = true;
            this.comboBoxKH.Location = new System.Drawing.Point(166, 64);
            this.comboBoxKH.Name = "comboBoxKH";
            this.comboBoxKH.Size = new System.Drawing.Size(233, 29);
            this.comboBoxKH.TabIndex = 33;
            // 
            // comboBoxNhanVien
            // 
            this.comboBoxNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNhanVien.FormattingEnabled = true;
            this.comboBoxNhanVien.Location = new System.Drawing.Point(167, 104);
            this.comboBoxNhanVien.Name = "comboBoxNhanVien";
            this.comboBoxNhanVien.Size = new System.Drawing.Size(232, 29);
            this.comboBoxNhanVien.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 28);
            this.label6.TabIndex = 32;
            this.label6.Text = "Trạng Thái";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelTongThanhToan
            // 
            this.labelTongThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelTongThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongThanhToan.Location = new System.Drawing.Point(167, 191);
            this.labelTongThanhToan.Name = "labelTongThanhToan";
            this.labelTongThanhToan.Size = new System.Drawing.Size(232, 28);
            this.labelTongThanhToan.TabIndex = 32;
            this.labelTongThanhToan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 28);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tổng Thanh Toán";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 28);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ngày Lập";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 28);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nhân Viên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tên Khách Hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 28);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mã Hóa Đơn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(167, 24);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(232, 28);
            this.txtMaHD.TabIndex = 31;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.comboBoxLK);
            this.groupBox5.Controls.Add(this.CboTrangThai);
            this.groupBox5.Controls.Add(this.txtKhuyenMai);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.labelThanhTien);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtDonGia);
            this.groupBox5.Controls.Add(this.txtSL);
            this.groupBox5.Location = new System.Drawing.Point(573, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(497, 276);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi Tiết Hóa Đơn";
            // 
            // comboBoxLK
            // 
            this.comboBoxLK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLK.FormattingEnabled = true;
            this.comboBoxLK.Location = new System.Drawing.Point(179, 24);
            this.comboBoxLK.Name = "comboBoxLK";
            this.comboBoxLK.Size = new System.Drawing.Size(296, 28);
            this.comboBoxLK.TabIndex = 33;
            // 
            // CboTrangThai
            // 
            this.CboTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTrangThai.FormattingEnabled = true;
            this.CboTrangThai.Location = new System.Drawing.Point(180, 231);
            this.CboTrangThai.Name = "CboTrangThai";
            this.CboTrangThai.Size = new System.Drawing.Size(297, 28);
            this.CboTrangThai.TabIndex = 33;
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhuyenMai.Location = new System.Drawing.Point(180, 144);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.Size = new System.Drawing.Size(297, 28);
            this.txtKhuyenMai.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 28);
            this.label12.TabIndex = 32;
            this.label12.Text = "Trạng Thái";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelThanhTien
            // 
            this.labelThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelThanhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThanhTien.Location = new System.Drawing.Point(176, 187);
            this.labelThanhTien.Name = "labelThanhTien";
            this.labelThanhTien.Size = new System.Drawing.Size(299, 28);
            this.labelThanhTien.TabIndex = 32;
            this.labelThanhTien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 28);
            this.label11.TabIndex = 32;
            this.label11.Text = "Thành Tiền";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 28);
            this.label10.TabIndex = 32;
            this.label10.Text = "Chiết Khấu";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 28);
            this.label9.TabIndex = 32;
            this.label9.Text = "Đơn Giá";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 28);
            this.label8.TabIndex = 32;
            this.label8.Text = "Số Lượng";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 28);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tên Linh Kiện";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(180, 103);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(297, 28);
            this.txtDonGia.TabIndex = 31;
            // 
            // txtSL
            // 
            this.txtSL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(180, 63);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(297, 28);
            this.txtSL.TabIndex = 31;
            // 
            // Frm_HoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_HoaDonBanHang";
            this.Text = "Frm_HoaDonBanHang";
            this.Load += new System.EventHandler(this.Frm_HoaDonBanHang_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewCTHD;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaylap;
        private System.Windows.Forms.ComboBox comboBoxNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.ComboBox comboBoxTrangThai;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.ComboBox CboTrangThai;
        private System.Windows.Forms.TextBox txtKhuyenMai;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox comboBoxKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.ComboBox comboBoxLK;
        public System.Windows.Forms.DataGridView dataGridViewHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTongThanhToan;
        private System.Windows.Forms.Label labelThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLK;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaii;
    }
}