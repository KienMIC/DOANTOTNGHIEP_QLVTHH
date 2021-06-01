
namespace DoAn1.Baocao.Baocaohanghoa
{
    partial class frmBCHNDate
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
            this.rvBCHNDate = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bCHN_PARA = new DoAn1.BCHN_PARA();
            this.spviewBCHNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_viewBCHNTableAdapter = new DoAn1.BCHN_PARATableAdapters.sp_viewBCHNTableAdapter();
            this.spviewBCHNBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bCHN_PARA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spviewBCHNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spviewBCHNBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rvBCHNDate
            // 
            this.rvBCHNDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "BC_HANGNHAP";
            reportDataSource1.Value = this.spviewBCHNBindingSource1;
            this.rvBCHNDate.LocalReport.DataSources.Add(reportDataSource1);
            this.rvBCHNDate.LocalReport.ReportEmbeddedResource = "DoAn1.Baocao.Baocaohanghoa.rpBaoCaoHangNhap.rdlc";
            this.rvBCHNDate.Location = new System.Drawing.Point(13, 13);
            this.rvBCHNDate.Name = "rvBCHNDate";
            this.rvBCHNDate.ServerReport.BearerToken = null;
            this.rvBCHNDate.Size = new System.Drawing.Size(775, 425);
            this.rvBCHNDate.TabIndex = 0;
            // 
            // bCHN_PARA
            // 
            this.bCHN_PARA.DataSetName = "BCHN_PARA";
            this.bCHN_PARA.EnforceConstraints = false;
            this.bCHN_PARA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spviewBCHNBindingSource
            // 
            this.spviewBCHNBindingSource.DataMember = "sp_viewBCHN";
            this.spviewBCHNBindingSource.DataSource = this.bCHN_PARA;
            // 
            // sp_viewBCHNTableAdapter
            // 
            this.sp_viewBCHNTableAdapter.ClearBeforeFill = true;
            // 
            // spviewBCHNBindingSource1
            // 
            this.spviewBCHNBindingSource1.DataMember = "sp_viewBCHN";
            this.spviewBCHNBindingSource1.DataSource = this.bCHN_PARA;
            // 
            // frmBCHNDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvBCHNDate);
            this.Name = "frmBCHNDate";
            this.Text = "Xem báo cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBCHNDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bCHN_PARA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spviewBCHNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spviewBCHNBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvBCHNDate;
        private System.Windows.Forms.BindingSource spviewBCHNBindingSource;
        private BCHN_PARA bCHN_PARA;
        private BCHN_PARATableAdapters.sp_viewBCHNTableAdapter sp_viewBCHNTableAdapter;
        private System.Windows.Forms.BindingSource spviewBCHNBindingSource1;
    }
}