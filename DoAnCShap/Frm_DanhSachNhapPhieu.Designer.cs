namespace DoAnCShap
{
    partial class Frm_DanhSachNhapPhieu
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
            this.labelDanhSachHoaDon = new DevComponents.DotNetBar.LabelX();
            this.groupBoxLapPhieuNhap = new System.Windows.Forms.GroupBox();
            this.btnLapHoaDon = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxLapPhieuNhap.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDanhSachHoaDon
            // 
            // 
            // 
            // 
            this.labelDanhSachHoaDon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDanhSachHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDanhSachHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDanhSachHoaDon.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelDanhSachHoaDon.Location = new System.Drawing.Point(0, 0);
            this.labelDanhSachHoaDon.Name = "labelDanhSachHoaDon";
            this.labelDanhSachHoaDon.Size = new System.Drawing.Size(1041, 70);
            this.labelDanhSachHoaDon.TabIndex = 2;
            this.labelDanhSachHoaDon.Text = "DANH SÁCH NHẬP PHIẾU";
            this.labelDanhSachHoaDon.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // groupBoxLapPhieuNhap
            // 
            this.groupBoxLapPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.groupBoxLapPhieuNhap.Controls.Add(this.btnLapHoaDon);
            this.groupBoxLapPhieuNhap.Controls.Add(this.textBox1);
            this.groupBoxLapPhieuNhap.Controls.Add(this.label2);
            this.groupBoxLapPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxLapPhieuNhap.Location = new System.Drawing.Point(0, 70);
            this.groupBoxLapPhieuNhap.Name = "groupBoxLapPhieuNhap";
            this.groupBoxLapPhieuNhap.Size = new System.Drawing.Size(1041, 59);
            this.groupBoxLapPhieuNhap.TabIndex = 3;
            this.groupBoxLapPhieuNhap.TabStop = false;
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLapHoaDon.AutoSize = true;
            this.btnLapHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.btnLapHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHoaDon.Location = new System.Drawing.Point(771, 6);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(258, 41);
            this.btnLapHoaDon.TabIndex = 2;
            this.btnLapHoaDon.Text = "Lập Phiếu Nhập Hàng";
            this.btnLapHoaDon.UseVisualStyleBackColor = false;
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(153, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 34);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm Kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1041, 647);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 556);
            this.dataGridView1.TabIndex = 0;
            // 
            // Frm_DanhSachNhapPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1041, 776);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxLapPhieuNhap);
            this.Controls.Add(this.labelDanhSachHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_DanhSachNhapPhieu";
            this.Text = "Frm_DanhSachNhapPhieu";
            this.groupBoxLapPhieuNhap.ResumeLayout(false);
            this.groupBoxLapPhieuNhap.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelDanhSachHoaDon;
        private System.Windows.Forms.GroupBox groupBoxLapPhieuNhap;
        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}