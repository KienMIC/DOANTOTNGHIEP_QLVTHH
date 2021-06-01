
namespace DoAn1.Baocao.Baocaohanghoa
{
    partial class frmBCTTHH_KH
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
            this.rvBCHH_KHACHHANG = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bCHH_THEOKH_PARA = new DoAn1.BCHH_THEOKH_PARA();
            this.spviewHHTHEOKHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_viewHHTHEOKHTableAdapter = new DoAn1.BCHH_THEOKH_PARATableAdapters.sp_viewHHTHEOKHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bCHH_THEOKH_PARA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spviewHHTHEOKHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvBCHH_KHACHHANG
            // 
            this.rvBCHH_KHACHHANG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DS_HANGHOA";
            reportDataSource1.Value = this.spviewHHTHEOKHBindingSource;
            this.rvBCHH_KHACHHANG.LocalReport.DataSources.Add(reportDataSource1);
            this.rvBCHH_KHACHHANG.LocalReport.ReportEmbeddedResource = "DoAn1.Baocao.Baocaohanghoa.rpBaoCaoTTHH.rdlc";
            this.rvBCHH_KHACHHANG.Location = new System.Drawing.Point(13, 13);
            this.rvBCHH_KHACHHANG.Name = "rvBCHH_KHACHHANG";
            this.rvBCHH_KHACHHANG.ServerReport.BearerToken = null;
            this.rvBCHH_KHACHHANG.Size = new System.Drawing.Size(775, 425);
            this.rvBCHH_KHACHHANG.TabIndex = 0;
            // 
            // bCHH_THEOKH_PARA
            // 
            this.bCHH_THEOKH_PARA.DataSetName = "BCHH_THEOKH_PARA";
            this.bCHH_THEOKH_PARA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spviewHHTHEOKHBindingSource
            // 
            this.spviewHHTHEOKHBindingSource.DataMember = "sp_viewHHTHEOKH";
            this.spviewHHTHEOKHBindingSource.DataSource = this.bCHH_THEOKH_PARA;
            // 
            // sp_viewHHTHEOKHTableAdapter
            // 
            this.sp_viewHHTHEOKHTableAdapter.ClearBeforeFill = true;
            // 
            // frmBCTTHH_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvBCHH_KHACHHANG);
            this.Name = "frmBCTTHH_KH";
            this.Text = "Xem báo cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBCTTHH_KH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bCHH_THEOKH_PARA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spviewHHTHEOKHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvBCHH_KHACHHANG;
        private System.Windows.Forms.BindingSource spviewHHTHEOKHBindingSource;
        private BCHH_THEOKH_PARA bCHH_THEOKH_PARA;
        private BCHH_THEOKH_PARATableAdapters.sp_viewHHTHEOKHTableAdapter sp_viewHHTHEOKHTableAdapter;
    }
}