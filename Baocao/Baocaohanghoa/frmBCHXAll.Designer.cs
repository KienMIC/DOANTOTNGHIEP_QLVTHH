
namespace DoAn1.Baocao.Baocaohanghoa
{
    partial class frmBCHXAll
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
            this.rvBCHXAll = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_BAOCAOPHIEUXUAT = new DoAn1.DS_BAOCAOPHIEUXUAT();
            this.bCHANGXUATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bC_HANGXUATTableAdapter = new DoAn1.DS_BAOCAOPHIEUXUATTableAdapters.BC_HANGXUATTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dS_BAOCAOPHIEUXUAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCHANGXUATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvBCHXAll
            // 
            this.rvBCHXAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.bCHANGXUATBindingSource;
            this.rvBCHXAll.LocalReport.DataSources.Add(reportDataSource2);
            this.rvBCHXAll.LocalReport.ReportEmbeddedResource = "DoAn1.Baocao.Baocaohanghoa.rpBaoCaoHangXuat.rdlc";
            this.rvBCHXAll.Location = new System.Drawing.Point(13, 13);
            this.rvBCHXAll.Name = "rvBCHXAll";
            this.rvBCHXAll.ServerReport.BearerToken = null;
            this.rvBCHXAll.Size = new System.Drawing.Size(775, 425);
            this.rvBCHXAll.TabIndex = 1;
            // 
            // dS_BAOCAOPHIEUXUAT
            // 
            this.dS_BAOCAOPHIEUXUAT.DataSetName = "DS_BAOCAOPHIEUXUAT";
            this.dS_BAOCAOPHIEUXUAT.EnforceConstraints = false;
            this.dS_BAOCAOPHIEUXUAT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bCHANGXUATBindingSource
            // 
            this.bCHANGXUATBindingSource.DataMember = "BC_HANGXUAT";
            this.bCHANGXUATBindingSource.DataSource = this.dS_BAOCAOPHIEUXUAT;
            // 
            // bC_HANGXUATTableAdapter
            // 
            this.bC_HANGXUATTableAdapter.ClearBeforeFill = true;
            // 
            // frmBCHXAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvBCHXAll);
            this.Name = "frmBCHXAll";
            this.Text = "Xem báo cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBCHXAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_BAOCAOPHIEUXUAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCHANGXUATBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvBCHXAll;
        private DS_BAOCAOPHIEUXUAT dS_BAOCAOPHIEUXUAT;
        private System.Windows.Forms.BindingSource bCHANGXUATBindingSource;
        private DS_BAOCAOPHIEUXUATTableAdapters.BC_HANGXUATTableAdapter bC_HANGXUATTableAdapter;
    }
}