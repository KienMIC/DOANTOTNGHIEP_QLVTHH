
namespace DoAn1.Baocao.Baocaohanghoa
{
    partial class frmBCHNAll
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
            this.bCHANGNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTHHDataSet = new DoAn1.QLVTHHDataSet();
            this.rvBCHNAll = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bC_HANGNHAPTableAdapter = new DoAn1.QLVTHHDataSetTableAdapters.BC_HANGNHAPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bCHANGNHAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTHHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bCHANGNHAPBindingSource
            // 
            this.bCHANGNHAPBindingSource.DataMember = "BC_HANGNHAP";
            this.bCHANGNHAPBindingSource.DataSource = this.qLVTHHDataSet;
            // 
            // qLVTHHDataSet
            // 
            this.qLVTHHDataSet.DataSetName = "QLVTHHDataSet";
            this.qLVTHHDataSet.EnforceConstraints = false;
            this.qLVTHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvBCHNAll
            // 
            this.rvBCHNAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "BC_HANGNHAP";
            reportDataSource2.Value = this.bCHANGNHAPBindingSource;
            this.rvBCHNAll.LocalReport.DataSources.Add(reportDataSource2);
            this.rvBCHNAll.LocalReport.ReportEmbeddedResource = "DoAn1.Baocao.Baocaohanghoa.rpBaoCaoHangNhap.rdlc";
            this.rvBCHNAll.Location = new System.Drawing.Point(13, 13);
            this.rvBCHNAll.Name = "rvBCHNAll";
            this.rvBCHNAll.ServerReport.BearerToken = null;
            this.rvBCHNAll.Size = new System.Drawing.Size(775, 396);
            this.rvBCHNAll.TabIndex = 0;
            // 
            // bC_HANGNHAPTableAdapter
            // 
            this.bC_HANGNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // frmBCHNAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvBCHNAll);
            this.Name = "frmBCHNAll";
            this.Text = "XEM BÁO CÁO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBCHNAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bCHANGNHAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTHHDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvBCHNAll;
        private QLVTHHDataSet qLVTHHDataSet;
        private System.Windows.Forms.BindingSource bCHANGNHAPBindingSource;
        private QLVTHHDataSetTableAdapters.BC_HANGNHAPTableAdapter bC_HANGNHAPTableAdapter;
    }
}