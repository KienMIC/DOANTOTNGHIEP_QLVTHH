
namespace DoAn1.Baocao.Baocaohanghoa
{
    partial class frmBaoCaoThongTinHH
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
            this.btnLapBC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.cbLoaiHang = new System.Windows.Forms.ComboBox();
            this.rbKHBC = new System.Windows.Forms.RadioButton();
            this.rbCatBC = new System.Windows.Forms.RadioButton();
            this.rbFullBC = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLapBC
            // 
            this.btnLapBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapBC.Location = new System.Drawing.Point(150, 153);
            this.btnLapBC.Name = "btnLapBC";
            this.btnLapBC.Size = new System.Drawing.Size(111, 40);
            this.btnLapBC.TabIndex = 2;
            this.btnLapBC.Text = "Lập báo cáo";
            this.btnLapBC.UseVisualStyleBackColor = true;
            this.btnLapBC.Click += new System.EventHandler(this.btnLapBC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbKhachHang);
            this.groupBox1.Controls.Add(this.cbLoaiHang);
            this.groupBox1.Controls.Add(this.rbKHBC);
            this.groupBox1.Controls.Add(this.rbCatBC);
            this.groupBox1.Controls.Add(this.btnLapBC);
            this.groupBox1.Controls.Add(this.rbFullBC);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 215);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập báo cáo hàng hóa";
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(207, 84);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(147, 21);
            this.cbKhachHang.TabIndex = 5;
            // 
            // cbLoaiHang
            // 
            this.cbLoaiHang.FormattingEnabled = true;
            this.cbLoaiHang.Location = new System.Drawing.Point(207, 52);
            this.cbLoaiHang.Name = "cbLoaiHang";
            this.cbLoaiHang.Size = new System.Drawing.Size(147, 21);
            this.cbLoaiHang.TabIndex = 5;
            // 
            // rbKHBC
            // 
            this.rbKHBC.AutoSize = true;
            this.rbKHBC.Location = new System.Drawing.Point(19, 88);
            this.rbKHBC.Name = "rbKHBC";
            this.rbKHBC.Size = new System.Drawing.Size(167, 17);
            this.rbKHBC.TabIndex = 4;
            this.rbKHBC.TabStop = true;
            this.rbKHBC.Text = "Báo cáo theo tên khách hàng";
            this.rbKHBC.UseVisualStyleBackColor = true;
            // 
            // rbCatBC
            // 
            this.rbCatBC.AutoSize = true;
            this.rbCatBC.Location = new System.Drawing.Point(19, 52);
            this.rbCatBC.Name = "rbCatBC";
            this.rbCatBC.Size = new System.Drawing.Size(156, 17);
            this.rbCatBC.TabIndex = 4;
            this.rbCatBC.TabStop = true;
            this.rbCatBC.Text = "Báo cáo theo loại hàng hóa";
            this.rbCatBC.UseVisualStyleBackColor = true;
            // 
            // rbFullBC
            // 
            this.rbFullBC.AutoSize = true;
            this.rbFullBC.Location = new System.Drawing.Point(19, 19);
            this.rbFullBC.Name = "rbFullBC";
            this.rbFullBC.Size = new System.Drawing.Size(152, 17);
            this.rbFullBC.TabIndex = 4;
            this.rbFullBC.TabStop = true;
            this.rbFullBC.Text = "Báo cáo toàn bộ hàng hóa";
            this.rbFullBC.UseVisualStyleBackColor = true;
            // 
            // frmBaoCaoThongTinHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 236);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBaoCaoThongTinHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo cáo thông tin hàng hóa";
            this.Load += new System.EventHandler(this.frmBaoCaoThongTinHH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLapBC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCatBC;
        private System.Windows.Forms.RadioButton rbFullBC;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.ComboBox cbLoaiHang;
        private System.Windows.Forms.RadioButton rbKHBC;
    }
}