
namespace DoAn1.Baocao.Baocaohanghoa
{
    partial class FrmBaocaoTTHHAll
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
            this.bCHANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_HANGHOA = new DoAn1.DS_HANGHOA();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bC_HANGHOATableAdapter = new DoAn1.DS_HANGHOATableAdapters.BC_HANGHOATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bCHANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_HANGHOA)).BeginInit();
            this.SuspendLayout();
            // 
            // bCHANGHOABindingSource
            // 
            this.bCHANGHOABindingSource.DataMember = "BC_HANGHOA";
            this.bCHANGHOABindingSource.DataSource = this.dS_HANGHOA;
            // 
            // dS_HANGHOA
            // 
            this.dS_HANGHOA.DataSetName = "DS_HANGHOA";
            this.dS_HANGHOA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DS_HANGHOA";
            reportDataSource2.Value = this.bCHANGHOABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn1.Baocao.Baocaohanghoa.rpBaoCaoTTHH.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(775, 425);
            this.reportViewer1.TabIndex = 0;
            // 
            // bC_HANGHOATableAdapter
            // 
            this.bC_HANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // FrmBaocaoTTHHAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmBaocaoTTHHAll";
            this.Text = "Xem báo cáo ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBaocaohangton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bCHANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_HANGHOA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_HANGHOA dS_HANGHOA;
        private System.Windows.Forms.BindingSource bCHANGHOABindingSource;
        private DS_HANGHOATableAdapters.BC_HANGHOATableAdapter bC_HANGHOATableAdapter;
    }
}