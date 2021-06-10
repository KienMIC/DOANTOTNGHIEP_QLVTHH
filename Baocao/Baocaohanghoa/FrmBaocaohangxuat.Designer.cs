
namespace DoAn1.Baocao.Baocaohanghoa
{
    partial class FrmBaocaohangxuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaocaohangxuat));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLapBC = new DevExpress.XtraEditors.SimpleButton();
            this.rbDateBC = new System.Windows.Forms.RadioButton();
            this.rbFullBC = new System.Windows.Forms.RadioButton();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLapBC);
            this.groupBox1.Controls.Add(this.rbDateBC);
            this.groupBox1.Controls.Add(this.rbFullBC);
            this.groupBox1.Controls.Add(this.dtpDenNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpTuNgay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 215);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập báo cáo hàng xuất";
            // 
            // btnLapBC
            // 
            this.btnLapBC.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnLapBC.Appearance.Options.UseFont = true;
            this.btnLapBC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLapBC.ImageOptions.Image")));
            this.btnLapBC.Location = new System.Drawing.Point(150, 153);
            this.btnLapBC.Name = "btnLapBC";
            this.btnLapBC.Size = new System.Drawing.Size(124, 40);
            this.btnLapBC.TabIndex = 6;
            this.btnLapBC.Text = "Lập báo cáo";
            this.btnLapBC.Click += new System.EventHandler(this.btnLapBC_Click);
            // 
            // rbDateBC
            // 
            this.rbDateBC.AutoSize = true;
            this.rbDateBC.Location = new System.Drawing.Point(19, 71);
            this.rbDateBC.Name = "rbDateBC";
            this.rbDateBC.Size = new System.Drawing.Size(106, 17);
            this.rbDateBC.TabIndex = 4;
            this.rbDateBC.TabStop = true;
            this.rbDateBC.Text = "Báo cáo trong kỳ";
            this.rbDateBC.UseVisualStyleBackColor = true;
            // 
            // rbFullBC
            // 
            this.rbFullBC.AutoSize = true;
            this.rbFullBC.Location = new System.Drawing.Point(19, 39);
            this.rbFullBC.Name = "rbFullBC";
            this.rbFullBC.Size = new System.Drawing.Size(132, 17);
            this.rbFullBC.TabIndex = 4;
            this.rbFullBC.TabStop = true;
            this.rbFullBC.Text = "Báo cáo toàn thời gian";
            this.rbFullBC.UseVisualStyleBackColor = true;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(268, 101);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(100, 20);
            this.dtpDenNgay.TabIndex = 1;
            this.dtpDenNgay.Value = new System.DateTime(2021, 5, 31, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(90, 101);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(100, 20);
            this.dtpTuNgay.TabIndex = 1;
            this.dtpTuNgay.Value = new System.DateTime(2021, 5, 31, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày";
            // 
            // FrmBaocaohangxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(444, 236);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBaocaohangxuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BÁO CÁO HÀNG XUẤT";
            this.Load += new System.EventHandler(this.FrmBaocaohangxuat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDateBC;
        private System.Windows.Forms.RadioButton rbFullBC;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnLapBC;
    }
}