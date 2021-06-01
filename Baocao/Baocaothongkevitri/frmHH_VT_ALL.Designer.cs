
namespace DoAn1.Baocao.Baocaothongkevitri
{
    partial class frmHH_VT_ALL
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
            this.rvHH_VT_ALL = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_VITRI_HANGHOA = new DoAn1.DS_VITRI_HANGHOA();
            this.bCVITRIHANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bC_VITRIHANGHOATableAdapter = new DoAn1.DS_VITRI_HANGHOATableAdapters.BC_VITRIHANGHOATableAdapter();
            this.bCVITRIHANGHOABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dS_VITRI_HANGHOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCVITRIHANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCVITRIHANGHOABindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rvHH_VT_ALL
            // 
            this.rvHH_VT_ALL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DS_VITRI_HANGHOA";
            reportDataSource1.Value = this.bCVITRIHANGHOABindingSource1;
            this.rvHH_VT_ALL.LocalReport.DataSources.Add(reportDataSource1);
            this.rvHH_VT_ALL.LocalReport.ReportEmbeddedResource = "DoAn1.Baocao.Baocaothongkevitri.rpThongKeHH_VT.rdlc";
            this.rvHH_VT_ALL.Location = new System.Drawing.Point(13, 13);
            this.rvHH_VT_ALL.Name = "rvHH_VT_ALL";
            this.rvHH_VT_ALL.ServerReport.BearerToken = null;
            this.rvHH_VT_ALL.Size = new System.Drawing.Size(775, 425);
            this.rvHH_VT_ALL.TabIndex = 0;
            // 
            // dS_VITRI_HANGHOA
            // 
            this.dS_VITRI_HANGHOA.DataSetName = "DS_VITRI_HANGHOA";
            this.dS_VITRI_HANGHOA.EnforceConstraints = false;
            this.dS_VITRI_HANGHOA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bCVITRIHANGHOABindingSource
            // 
            this.bCVITRIHANGHOABindingSource.DataMember = "BC_VITRIHANGHOA";
            this.bCVITRIHANGHOABindingSource.DataSource = this.dS_VITRI_HANGHOA;
            // 
            // bC_VITRIHANGHOATableAdapter
            // 
            this.bC_VITRIHANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // bCVITRIHANGHOABindingSource1
            // 
            this.bCVITRIHANGHOABindingSource1.DataMember = "BC_VITRIHANGHOA";
            this.bCVITRIHANGHOABindingSource1.DataSource = this.dS_VITRI_HANGHOA;
            // 
            // frmHH_VT_ALL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvHH_VT_ALL);
            this.Name = "frmHH_VT_ALL";
            this.Text = "Xem báo cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHH_VT_ALL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_VITRI_HANGHOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCVITRIHANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCVITRIHANGHOABindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvHH_VT_ALL;
        private DS_VITRI_HANGHOA dS_VITRI_HANGHOA;
        private System.Windows.Forms.BindingSource bCVITRIHANGHOABindingSource;
        private DS_VITRI_HANGHOATableAdapters.BC_VITRIHANGHOATableAdapter bC_VITRIHANGHOATableAdapter;
        private System.Windows.Forms.BindingSource bCVITRIHANGHOABindingSource1;
    }
}