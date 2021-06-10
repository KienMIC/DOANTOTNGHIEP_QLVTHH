
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spviewBCHNBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bCHN_PARA = new DoAn1.BCHN_PARA();
            this.rvBCHNDate = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spviewBCHNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_viewBCHNTableAdapter = new DoAn1.BCHN_PARATableAdapters.sp_viewBCHNTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spviewBCHNBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCHN_PARA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spviewBCHNBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spviewBCHNBindingSource1
            // 
            this.spviewBCHNBindingSource1.DataMember = "sp_viewBCHN";
            this.spviewBCHNBindingSource1.DataSource = this.bCHN_PARA;
            // 
            // bCHN_PARA
            // 
            this.bCHN_PARA.DataSetName = "BCHN_PARA";
            this.bCHN_PARA.EnforceConstraints = false;
            this.bCHN_PARA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvBCHNDate
            // 
            this.rvBCHNDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "BC_HANGNHAP";
            reportDataSource2.Value = this.spviewBCHNBindingSource1;
            this.rvBCHNDate.LocalReport.DataSources.Add(reportDataSource2);
            this.rvBCHNDate.LocalReport.ReportEmbeddedResource = "DoAn1.Baocao.Baocaohanghoa.rpBaoCaoHangNhap.rdlc";
            this.rvBCHNDate.Location = new System.Drawing.Point(13, 13);
            this.rvBCHNDate.Name = "rvBCHNDate";
            this.rvBCHNDate.ServerReport.BearerToken = null;
            this.rvBCHNDate.Size = new System.Drawing.Size(775, 393);
            this.rvBCHNDate.TabIndex = 0;
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
            // frmBCHNDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvBCHNDate);
            this.Name = "frmBCHNDate";
            this.Text = "XEM BÁO CÁO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBCHNDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spviewBCHNBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCHN_PARA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spviewBCHNBindingSource)).EndInit();
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