
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spviewHHTHEOLOAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bCHH_THEOLOAI_PARA = new DoAn1.BCHH_THEOLOAI_PARA();
            this.rvBCHH_THEOLOAI = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_viewHHTHEOLOAITableAdapter = new DoAn1.BCHH_THEOLOAI_PARATableAdapters.sp_viewHHTHEOLOAITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spviewHHTHEOLOAIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCHH_THEOLOAI_PARA)).BeginInit();
            this.SuspendLayout();
            // 
            // spviewHHTHEOLOAIBindingSource
            // 
            this.spviewHHTHEOLOAIBindingSource.DataMember = "sp_viewHHTHEOLOAI";
            this.spviewHHTHEOLOAIBindingSource.DataSource = this.bCHH_THEOLOAI_PARA;
            // 
            // bCHH_THEOLOAI_PARA
            // 
            this.bCHH_THEOLOAI_PARA.DataSetName = "BCHH_THEOLOAI_PARA";
            this.bCHH_THEOLOAI_PARA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvBCHH_THEOLOAI
            // 
            this.rvBCHH_THEOLOAI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DS_HANGHOA";
            reportDataSource2.Value = this.spviewHHTHEOLOAIBindingSource;
            this.rvBCHH_THEOLOAI.LocalReport.DataSources.Add(reportDataSource2);
            this.rvBCHH_THEOLOAI.LocalReport.ReportEmbeddedResource = "DoAn1.Baocao.Baocaohanghoa.rpBaoCaoTTHH.rdlc";
            this.rvBCHH_THEOLOAI.Location = new System.Drawing.Point(13, 13);
            this.rvBCHH_THEOLOAI.Name = "rvBCHH_THEOLOAI";
            this.rvBCHH_THEOLOAI.ServerReport.BearerToken = null;
            this.rvBCHH_THEOLOAI.Size = new System.Drawing.Size(777, 394);
            this.rvBCHH_THEOLOAI.TabIndex = 0;
            // 
            // sp_viewHHTHEOLOAITableAdapter
            // 
            this.sp_viewHHTHEOLOAITableAdapter.ClearBeforeFill = true;
            // 
            // frmBCTTHH_Loai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.rvBCHH_THEOLOAI);
            this.Name = "frmBCTTHH_Loai";
            this.Text = "XEM BÁO CÁO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBCTTHH_Loai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spviewHHTHEOLOAIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCHH_THEOLOAI_PARA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvBCHH_THEOLOAI;
        private System.Windows.Forms.BindingSource spviewHHTHEOLOAIBindingSource;
        private BCHH_THEOLOAI_PARA bCHH_THEOLOAI_PARA;
        private BCHH_THEOLOAI_PARATableAdapters.sp_viewHHTHEOLOAITableAdapter sp_viewHHTHEOLOAITableAdapter;
    }
}