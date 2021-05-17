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
            this.labelDanhSachHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelDanhSachHoaDon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDanhSachHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDanhSachHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDanhSachHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelDanhSachHoaDon.Location = new System.Drawing.Point(0, 0);
            this.labelDanhSachHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.labelDanhSachHoaDon.Name = "labelDanhSachHoaDon";
            this.labelDanhSachHoaDon.Size = new System.Drawing.Size(984, 50);
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
            this.groupBoxLapPhieuNhap.Location = new System.Drawing.Point(0, 50);
            this.groupBoxLapPhieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxLapPhieuNhap.Name = "groupBoxLapPhieuNhap";
            this.groupBoxLapPhieuNhap.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxLapPhieuNhap.Size = new System.Drawing.Size(984, 48);
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
            this.btnLapHoaDon.Location = new System.Drawing.Point(768, 5);
            this.btnLapHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(207, 34);
            this.btnLapHoaDon.TabIndex = 2;
            this.btnLapHoaDon.Text = "Lập Phiếu Nhập Hàng";
            this.btnLapHoaDon.UseVisualStyleBackColor = false;
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(115, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 28);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm Kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 98);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(984, 563);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(979, 482);
            this.dataGridView1.TabIndex = 0;
            // 
            // Frm_DanhSachNhapPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxLapPhieuNhap);
            this.Controls.Add(this.labelDanhSachHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
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