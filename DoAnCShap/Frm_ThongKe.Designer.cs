
namespace DoAnCShap
{
    partial class Frm_ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ThongKe));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButTop3HDMua = new System.Windows.Forms.RadioButton();
            this.radioDoanhThuYea = new System.Windows.Forms.RadioButton();
            this.radioTheoThang = new System.Windows.Forms.RadioButton();
            this.radioBanNhieuMonth = new System.Windows.Forms.RadioButton();
            this.radioButMuaYear = new System.Windows.Forms.RadioButton();
            this.radioBanNhieuYear = new System.Windows.Forms.RadioButton();
            this.radioButMuaMonth = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXemDoanhThu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNam = new System.Windows.Forms.ComboBox();
            this.comboBoxThang = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorMes = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDoanhThu = new System.Windows.Forms.ComboBox();
            this.radioButKhachMuaNhieeu = new System.Windows.Forms.RadioButton();
            this.radioBKhachmuanhieutrongnam = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMes)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnXemDoanhThu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxNam);
            this.panel1.Controls.Add(this.comboBoxThang);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 321);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioBKhachmuanhieutrongnam);
            this.panel2.Controls.Add(this.radioButKhachMuaNhieeu);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.radioButTop3HDMua);
            this.panel2.Controls.Add(this.radioDoanhThuYea);
            this.panel2.Controls.Add(this.radioTheoThang);
            this.panel2.Controls.Add(this.radioBanNhieuMonth);
            this.panel2.Controls.Add(this.radioButMuaYear);
            this.panel2.Controls.Add(this.radioBanNhieuYear);
            this.panel2.Controls.Add(this.radioButMuaMonth);
            this.panel2.Location = new System.Drawing.Point(7, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 266);
            this.panel2.TabIndex = 11;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(402, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(173, 24);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tổng Tiền Chi Tháng";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(369, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(6, 274);
            this.label1.TabIndex = 11;
            // 
            // radioButTop3HDMua
            // 
            this.radioButTop3HDMua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButTop3HDMua.AutoSize = true;
            this.radioButTop3HDMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButTop3HDMua.Location = new System.Drawing.Point(402, 10);
            this.radioButTop3HDMua.Name = "radioButTop3HDMua";
            this.radioButTop3HDMua.Size = new System.Drawing.Size(309, 24);
            this.radioButTop3HDMua.TabIndex = 9;
            this.radioButTop3HDMua.TabStop = true;
            this.radioButTop3HDMua.Text = "Top 3 Hóa Đơn Mua Nhiều Trong Tháng";
            this.radioButTop3HDMua.UseVisualStyleBackColor = true;
            // 
            // radioDoanhThuYea
            // 
            this.radioDoanhThuYea.AutoSize = true;
            this.radioDoanhThuYea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDoanhThuYea.Location = new System.Drawing.Point(3, 52);
            this.radioDoanhThuYea.Name = "radioDoanhThuYea";
            this.radioDoanhThuYea.Size = new System.Drawing.Size(188, 24);
            this.radioDoanhThuYea.TabIndex = 10;
            this.radioDoanhThuYea.TabStop = true;
            this.radioDoanhThuYea.Text = "Doanh Thu Trong Năm";
            this.radioDoanhThuYea.UseVisualStyleBackColor = true;
            // 
            // radioTheoThang
            // 
            this.radioTheoThang.AutoSize = true;
            this.radioTheoThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTheoThang.Location = new System.Drawing.Point(3, 10);
            this.radioTheoThang.Name = "radioTheoThang";
            this.radioTheoThang.Size = new System.Drawing.Size(195, 24);
            this.radioTheoThang.TabIndex = 1;
            this.radioTheoThang.TabStop = true;
            this.radioTheoThang.Text = "Doanh Thu Theo Tháng";
            this.radioTheoThang.UseVisualStyleBackColor = true;
            // 
            // radioBanNhieuMonth
            // 
            this.radioBanNhieuMonth.AutoSize = true;
            this.radioBanNhieuMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBanNhieuMonth.Location = new System.Drawing.Point(3, 96);
            this.radioBanNhieuMonth.Name = "radioBanNhieuMonth";
            this.radioBanNhieuMonth.Size = new System.Drawing.Size(312, 24);
            this.radioBanNhieuMonth.TabIndex = 9;
            this.radioBanNhieuMonth.TabStop = true;
            this.radioBanNhieuMonth.Text = "Top 3 Sản Phẩm Bán Nhiều Theo Tháng";
            this.radioBanNhieuMonth.UseVisualStyleBackColor = true;
            // 
            // radioButMuaYear
            // 
            this.radioButMuaYear.AutoSize = true;
            this.radioButMuaYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButMuaYear.Location = new System.Drawing.Point(3, 234);
            this.radioButMuaYear.Name = "radioButMuaYear";
            this.radioButMuaYear.Size = new System.Drawing.Size(314, 24);
            this.radioButMuaYear.TabIndex = 9;
            this.radioButMuaYear.TabStop = true;
            this.radioButMuaYear.Text = "Top 3 Sản Phẩm Nhập Nhiều Trong Năm\r\n";
            this.radioButMuaYear.UseVisualStyleBackColor = true;
            // 
            // radioBanNhieuYear
            // 
            this.radioBanNhieuYear.AutoSize = true;
            this.radioBanNhieuYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBanNhieuYear.Location = new System.Drawing.Point(3, 142);
            this.radioBanNhieuYear.Name = "radioBanNhieuYear";
            this.radioBanNhieuYear.Size = new System.Drawing.Size(305, 24);
            this.radioBanNhieuYear.TabIndex = 9;
            this.radioBanNhieuYear.TabStop = true;
            this.radioBanNhieuYear.Text = "Top 3 Sản Phẩm Bán Nhiều Trong Năm";
            this.radioBanNhieuYear.UseVisualStyleBackColor = true;
            // 
            // radioButMuaMonth
            // 
            this.radioButMuaMonth.AutoSize = true;
            this.radioButMuaMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButMuaMonth.Location = new System.Drawing.Point(3, 188);
            this.radioButMuaMonth.Name = "radioButMuaMonth";
            this.radioButMuaMonth.Size = new System.Drawing.Size(326, 24);
            this.radioButMuaMonth.TabIndex = 9;
            this.radioButMuaMonth.TabStop = true;
            this.radioButMuaMonth.Text = "Top 3 Sản Phẩm Nhập Nhiều Trong Tháng";
            this.radioButMuaMonth.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tháng";
            // 
            // btnXemDoanhThu
            // 
            this.btnXemDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDoanhThu.Image = ((System.Drawing.Image)(resources.GetObject("btnXemDoanhThu.Image")));
            this.btnXemDoanhThu.Location = new System.Drawing.Point(607, 275);
            this.btnXemDoanhThu.Name = "btnXemDoanhThu";
            this.btnXemDoanhThu.Size = new System.Drawing.Size(91, 41);
            this.btnXemDoanhThu.TabIndex = 6;
            this.btnXemDoanhThu.Text = "Xem";
            this.btnXemDoanhThu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemDoanhThu.UseVisualStyleBackColor = true;
            this.btnXemDoanhThu.Click += new System.EventHandler(this.btnXemDoanhThu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Năm";
            // 
            // comboBoxNam
            // 
            this.comboBoxNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNam.FormattingEnabled = true;
            this.comboBoxNam.Location = new System.Drawing.Point(377, 280);
            this.comboBoxNam.Name = "comboBoxNam";
            this.comboBoxNam.Size = new System.Drawing.Size(89, 28);
            this.comboBoxNam.TabIndex = 2;
            // 
            // comboBoxThang
            // 
            this.comboBoxThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxThang.FormattingEnabled = true;
            this.comboBoxThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxThang.Location = new System.Drawing.Point(194, 281);
            this.comboBoxThang.Name = "comboBoxThang";
            this.comboBoxThang.Size = new System.Drawing.Size(90, 28);
            this.comboBoxThang.TabIndex = 2;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 339);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Doanh Thu";
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1160, 360);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(796, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(376, 263);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // errorMes
            // 
            this.errorMes.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cboDoanhThu);
            this.panel3.Location = new System.Drawing.Point(796, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 52);
            this.panel3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 24);
            this.label5.TabIndex = 47;
            this.label5.Text = "Đ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Doanh Thu";
            // 
            // cboDoanhThu
            // 
            this.cboDoanhThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.cboDoanhThu.FormattingEnabled = true;
            this.cboDoanhThu.Location = new System.Drawing.Point(117, 12);
            this.cboDoanhThu.Name = "cboDoanhThu";
            this.cboDoanhThu.Size = new System.Drawing.Size(175, 28);
            this.cboDoanhThu.TabIndex = 45;
            // 
            // radioButKhachMuaNhieeu
            // 
            this.radioButKhachMuaNhieeu.AutoSize = true;
            this.radioButKhachMuaNhieeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButKhachMuaNhieeu.Location = new System.Drawing.Point(402, 96);
            this.radioButKhachMuaNhieeu.Name = "radioButKhachMuaNhieeu";
            this.radioButKhachMuaNhieeu.Size = new System.Drawing.Size(289, 24);
            this.radioButKhachMuaNhieeu.TabIndex = 12;
            this.radioButKhachMuaNhieeu.TabStop = true;
            this.radioButKhachMuaNhieeu.Text = "Khách Hàng Mua Nhiều Trong Tháng";
            this.radioButKhachMuaNhieeu.UseVisualStyleBackColor = true;
            // 
            // radioBKhachmuanhieutrongnam
            // 
            this.radioBKhachmuanhieutrongnam.AutoSize = true;
            this.radioBKhachmuanhieutrongnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBKhachmuanhieutrongnam.Location = new System.Drawing.Point(402, 142);
            this.radioBKhachmuanhieutrongnam.Name = "radioBKhachmuanhieutrongnam";
            this.radioBKhachmuanhieutrongnam.Size = new System.Drawing.Size(277, 24);
            this.radioBKhachmuanhieutrongnam.TabIndex = 12;
            this.radioBKhachmuanhieutrongnam.TabStop = true;
            this.radioBKhachmuanhieutrongnam.Text = "Khách Hàng Mua Nhiều Trong Năm\r\n";
            this.radioBKhachmuanhieutrongnam.UseVisualStyleBackColor = true;
            // 
            // Frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_ThongKe";
            this.Text = "Frm_ThongKe";
            this.Load += new System.EventHandler(this.Frm_ThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxThang;
        private System.Windows.Forms.RadioButton radioTheoThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNam;
        private System.Windows.Forms.Button btnXemDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.RadioButton radioBanNhieuMonth;
        private System.Windows.Forms.RadioButton radioDoanhThuYea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioBanNhieuYear;
        private System.Windows.Forms.RadioButton radioButTop3HDMua;
        private System.Windows.Forms.RadioButton radioButMuaMonth;
        private System.Windows.Forms.RadioButton radioButMuaYear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorMes;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboDoanhThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButKhachMuaNhieeu;
        private System.Windows.Forms.RadioButton radioBKhachmuanhieutrongnam;
    }
}