
namespace DoAnCShap
{
    partial class Frm_PrintHD
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PM_BanLinhKienPCDataSet = new DoAnCShap.PM_BanLinhKienPCDataSet();
            this.CT_HoaDonBanHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CT_HoaDonBanHangTableAdapter = new DoAnCShap.PM_BanLinhKienPCDataSetTableAdapters.CT_HoaDonBanHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PM_BanLinhKienPCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_HoaDonBanHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCTHD";
            reportDataSource1.Value = this.CT_HoaDonBanHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnCShap.ReportHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // PM_BanLinhKienPCDataSet
            // 
            this.PM_BanLinhKienPCDataSet.DataSetName = "PM_BanLinhKienPCDataSet";
            this.PM_BanLinhKienPCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CT_HoaDonBanHangBindingSource
            // 
            this.CT_HoaDonBanHangBindingSource.DataMember = "CT_HoaDonBanHang";
            this.CT_HoaDonBanHangBindingSource.DataSource = this.PM_BanLinhKienPCDataSet;
            // 
            // CT_HoaDonBanHangTableAdapter
            // 
            this.CT_HoaDonBanHangTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_PrintHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_PrintHD";
            this.Text = "Frm_PrintHD";
            this.Load += new System.EventHandler(this.Frm_PrintHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PM_BanLinhKienPCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_HoaDonBanHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CT_HoaDonBanHangBindingSource;
        private PM_BanLinhKienPCDataSet PM_BanLinhKienPCDataSet;
        private PM_BanLinhKienPCDataSetTableAdapters.CT_HoaDonBanHangTableAdapter CT_HoaDonBanHangTableAdapter;
    }
}