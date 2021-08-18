
namespace DoAnCShap
{
    partial class Frm_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Setting));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChonFontChu = new System.Windows.Forms.Button();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.errorMes = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHotLine = new System.Windows.Forms.TextBox();
            this.txtWebSite = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.btnDong);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Location = new System.Drawing.Point(32, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1111, 604);
            this.panel4.TabIndex = 4;
            // 
            // btnDong
            // 
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(484, 516);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 46);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(344, 516);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 46);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu Thay Đổi";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChonFontChu
            // 
            this.btnChonFontChu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChonFontChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonFontChu.Image = ((System.Drawing.Image)(resources.GetObject("btnChonFontChu.Image")));
            this.btnChonFontChu.Location = new System.Drawing.Point(192, 28);
            this.btnChonFontChu.Name = "btnChonFontChu";
            this.btnChonFontChu.Size = new System.Drawing.Size(133, 45);
            this.btnChonFontChu.TabIndex = 5;
            this.btnChonFontChu.Text = "Chọn Font";
            this.btnChonFontChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChonFontChu.UseVisualStyleBackColor = true;
            this.btnChonFontChu.Click += new System.EventHandler(this.btnChonFontChu_Click);
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThayDoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThayDoi.Image")));
            this.btnThayDoi.Location = new System.Drawing.Point(121, 28);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(128, 45);
            this.btnThayDoi.TabIndex = 2;
            this.btnThayDoi.Text = "Chọn Màu";
            this.btnThayDoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThayDoi.UseVisualStyleBackColor = true;
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // errorMes
            // 
            this.errorMes.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThayDoi);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(111, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 87);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thay Đổi Màu Giao Diện";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnChonFontChu);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(496, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 87);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thay Đổi Font Chữ Menu";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtSDT);
            this.groupBox3.Controls.Add(this.txtHotLine);
            this.groupBox3.Controls.Add(this.txtWebSite);
            this.groupBox3.Controls.Add(this.txtDiaChi);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(111, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(876, 314);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Cửa Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tin Học Ngôi Sao";
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DoAnCShap.Properties.Settings.Default, "ChangeThongTIn", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(121, 123);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(237, 29);
            this.txtSDT.TabIndex = 6;
            this.txtSDT.Text = global::DoAnCShap.Properties.Settings.Default.ChangeThongTIn;
            this.txtSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHotLine
            // 
            this.txtHotLine.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DoAnCShap.Properties.Settings.Default, "ChangeHotLine", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtHotLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotLine.Location = new System.Drawing.Point(121, 195);
            this.txtHotLine.Multiline = true;
            this.txtHotLine.Name = "txtHotLine";
            this.txtHotLine.Size = new System.Drawing.Size(237, 29);
            this.txtHotLine.TabIndex = 7;
            this.txtHotLine.Text = global::DoAnCShap.Properties.Settings.Default.ChangeHotLine;
            this.txtHotLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWebSite
            // 
            this.txtWebSite.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DoAnCShap.Properties.Settings.Default, "ChangeWebsite", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtWebSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWebSite.Location = new System.Drawing.Point(121, 263);
            this.txtWebSite.Multiline = true;
            this.txtWebSite.Name = "txtWebSite";
            this.txtWebSite.Size = new System.Drawing.Size(237, 25);
            this.txtWebSite.TabIndex = 8;
            this.txtWebSite.Text = global::DoAnCShap.Properties.Settings.Default.ChangeWebsite;
            this.txtWebSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DoAnCShap.Properties.Settings.Default, "ChangeDiaChi", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(442, 123);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(310, 113);
            this.txtDiaChi.TabIndex = 14;
            this.txtDiaChi.Text = global::DoAnCShap.Properties.Settings.Default.ChangeDiaChi;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Điện Thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(438, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Địa Chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(117, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "HotLine";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(117, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "WebSite";
            // 
            // Frm_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.panel4);
            this.Name = "Frm_Setting";
            this.Text = "Frm_Setting";
            this.Load += new System.EventHandler(this.Frm_Setting_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorMes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.Button btnChonFontChu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorMes;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtSDT;
        public System.Windows.Forms.TextBox txtHotLine;
        public System.Windows.Forms.TextBox txtWebSite;
        public System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}