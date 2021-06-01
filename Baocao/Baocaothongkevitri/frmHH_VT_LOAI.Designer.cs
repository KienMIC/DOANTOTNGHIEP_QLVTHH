
namespace DoAn1.Baocao.Baocaothongkevitri
{
    partial class frmHH_VT_LOAI
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
            this.rvHH_VT_LOAI = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_VITRI_HANGHOA_LOAI_PARA = new DoAn1.DS_VITRI_HANGHOA_LOAI_PARA();
            this.spviewVTHHTHEOLOAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_viewVTHHTHEOLOAITableAdapter = new DoAn1.DS_VITRI_HANGHOA_LOAI_PARATableAdapters.sp_viewVTHHTHEOLOAITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dS_VITRI_HANGHOA_LOAI_PARA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spviewVTHHTHEOLOAIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvHH_VT_LOAI
            // 
            this.rvHH_VT_LOAI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DS_VITRI_HANGHOA";
            reportDataSource1.Value = this.spviewVTHHTHEOLOAIBindingSource;
            this.rvHH_VT_LOAI.LocalReport.DataSources.Add(reportDataSource1);
            this.rvHH_VT_LOAI.LocalReport.ReportEmbeddedResource = "DoAn1.Baocao.Baocaothongkevitri.rpThongKeHH_VT.rdlc";
            this.rvHH_VT_LOAI.Location = new System.Drawing.Point(13, -1);
            this.rvHH_VT_LOAI.Name = "rvHH_VT_LOAI";
            this.rvHH_VT_LOAI.ServerReport.BearerToken = null;
            this.rvHH_VT_LOAI.Size = new System.Drawing.Size(775, 439);
            this.rvHH_VT_LOAI.TabIndex = 0;
            // 
            // dS_VITRI_HANGHOA_LOAI_PARA
            // 
            this.dS_VITRI_HANGHOA_LOAI_PARA.DataSetName = "DS_VITRI_HANGHOA_LOAI_PARA";
            this.dS_VITRI_HANGHOA_LOAI_PARA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spviewVTHHTHEOLOAIBindingSource
            // 
            this.spviewVTHHTHEOLOAIBindingSource.DataMember = "sp_viewVTHHTHEOLOAI";
            this.spviewVTHHTHEOLOAIBindingSource.DataSource = this.dS_VITRI_HANGHOA_LOAI_PARA;
            // 
            // sp_viewVTHHTHEOLOAITableAdapter
            // 
            this.sp_viewVTHHTHEOLOAITableAdapter.ClearBeforeFill = true;
            // 
            // frmHH_VT_LOAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvHH_VT_LOAI);
            this.Name = "frmHH_VT_LOAI";
            this.Text = "Xem báo cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHH_VT_LOAI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_VITRI_HANGHOA_LOAI_PARA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spviewVTHHTHEOLOAIBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvHH_VT_LOAI;
        private System.Windows.Forms.BindingSource spviewVTHHTHEOLOAIBindingSource;
        private DS_VITRI_HANGHOA_LOAI_PARA dS_VITRI_HANGHOA_LOAI_PARA;
        private DS_VITRI_HANGHOA_LOAI_PARATableAdapters.sp_viewVTHHTHEOLOAITableAdapter sp_viewVTHHTHEOLOAITableAdapter;
    }
}