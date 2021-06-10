
namespace DoAn1.Baocao.Baocaohanghoa
{
    partial class frmBCHXDate
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
            this.spviewBCHXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bCHX_PARA = new DoAn1.BCHX_PARA();
            this.rvBCHNDate = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_viewBCHXTableAdapter = new DoAn1.BCHX_PARATableAdapters.sp_viewBCHXTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spviewBCHXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCHX_PARA)).BeginInit();
            this.SuspendLayout();
            // 
            // spviewBCHXBindingSource
            // 
            this.spviewBCHXBindingSource.DataMember = "sp_viewBCHX";
            this.spviewBCHXBindingSource.DataSource = this.bCHX_PARA;
            // 
            // bCHX_PARA
            // 
            this.bCHX_PARA.DataSetName = "BCHX_PARA";
            this.bCHX_PARA.EnforceConstraints = false;
            this.bCHX_PARA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvBCHNDate
            // 
            this.rvBCHNDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.spviewBCHXBindingSource;
            this.rvBCHNDate.LocalReport.DataSources.Add(reportDataSource2);
            this.rvBCHNDate.LocalReport.ReportEmbeddedResource = "DoAn1.Baocao.Baocaohanghoa.rpBaoCaoHangXuat.rdlc";
            this.rvBCHNDate.Location = new System.Drawing.Point(13, 13);
            this.rvBCHNDate.Name = "rvBCHNDate";
            this.rvBCHNDate.ServerReport.BearerToken = null;
            this.rvBCHNDate.Size = new System.Drawing.Size(775, 386);
            this.rvBCHNDate.TabIndex = 1;
            // 
            // sp_viewBCHXTableAdapter
            // 
            this.sp_viewBCHXTableAdapter.ClearBeforeFill = true;
            // 
            // frmBCHXDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvBCHNDate);
            this.Name = "frmBCHXDate";
            this.Text = "XEM BÁO CÁO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBCHXDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spviewBCHXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCHX_PARA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvBCHNDate;
        private System.Windows.Forms.BindingSource spviewBCHXBindingSource;
        private BCHX_PARA bCHX_PARA;
        private BCHX_PARATableAdapters.sp_viewBCHXTableAdapter sp_viewBCHXTableAdapter;
    }
}