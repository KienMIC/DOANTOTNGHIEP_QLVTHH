
namespace DoAn1.Baocao.Baocaohanghoa
{
    partial class frmBCTTHH_Loai
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
            this.rvBCHH_THEOLOAI = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bCHH_THEOLOAI_PARA = new DoAn1.BCHH_THEOLOAI_PARA();
            this.spviewHHTHEOLOAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_viewHHTHEOLOAITableAdapter = new DoAn1.BCHH_THEOLOAI_PARATableAdapters.sp_viewHHTHEOLOAITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bCHH_THEOLOAI_PARA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spviewHHTHEOLOAIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvBCHH_THEOLOAI
            // 
            this.rvBCHH_THEOLOAI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DS_HANGHOA";
            reportDataSource1.Value = this.spviewHHTHEOLOAIBindingSource;
            this.rvBCHH_THEOLOAI.LocalReport.DataSources.Add(reportDataSource1);
            this.rvBCHH_THEOLOAI.LocalReport.ReportEmbeddedResource = "DoAn1.Baocao.Baocaohanghoa.rpBaoCaoTTHH.rdlc";
            this.rvBCHH_THEOLOAI.Location = new System.Drawing.Point(13, 13);
            this.rvBCHH_THEOLOAI.Name = "rvBCHH_THEOLOAI";
            this.rvBCHH_THEOLOAI.ServerReport.BearerToken = null;
            this.rvBCHH_THEOLOAI.Size = new System.Drawing.Size(783, 435);
            this.rvBCHH_THEOLOAI.TabIndex = 0;
            // 
            // bCHH_THEOLOAI_PARA
            // 
            this.bCHH_THEOLOAI_PARA.DataSetName = "BCHH_THEOLOAI_PARA";
            this.bCHH_THEOLOAI_PARA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spviewHHTHEOLOAIBindingSource
            // 
            this.spviewHHTHEOLOAIBindingSource.DataMember = "sp_viewHHTHEOLOAI";
            this.spviewHHTHEOLOAIBindingSource.DataSource = this.bCHH_THEOLOAI_PARA;
            // 
            // sp_viewHHTHEOLOAITableAdapter
            // 
            this.sp_viewHHTHEOLOAITableAdapter.ClearBeforeFill = true;
            // 
            // frmBCTTHH_Loai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvBCHH_THEOLOAI);
            this.Name = "frmBCTTHH_Loai";
            this.Text = "Xem báo cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBCTTHH_Loai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bCHH_THEOLOAI_PARA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spviewHHTHEOLOAIBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvBCHH_THEOLOAI;
        private System.Windows.Forms.BindingSource spviewHHTHEOLOAIBindingSource;
        private BCHH_THEOLOAI_PARA bCHH_THEOLOAI_PARA;
        private BCHH_THEOLOAI_PARATableAdapters.sp_viewHHTHEOLOAITableAdapter sp_viewHHTHEOLOAITableAdapter;
    }
}