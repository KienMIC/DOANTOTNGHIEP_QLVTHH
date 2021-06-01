
namespace DoAn1.Baocao.Baocaothongkevitri
{
    partial class FrmThongkehanghoataicacvitri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCatBC = new System.Windows.Forms.RadioButton();
            this.btnLapBC = new System.Windows.Forms.Button();
            this.rbFullBC = new System.Windows.Forms.RadioButton();
            this.cbLoaiHang = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLoaiHang);
            this.groupBox1.Controls.Add(this.rbCatBC);
            this.groupBox1.Controls.Add(this.btnLapBC);
            this.groupBox1.Controls.Add(this.rbFullBC);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 215);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập báo cáo thống kê hàng hóa tại các vị trí";
            // 
            // rbCatBC
            // 
            this.rbCatBC.AutoSize = true;
            this.rbCatBC.Location = new System.Drawing.Point(19, 71);
            this.rbCatBC.Name = "rbCatBC";
            this.rbCatBC.Size = new System.Drawing.Size(156, 17);
            this.rbCatBC.TabIndex = 4;
            this.rbCatBC.TabStop = true;
            this.rbCatBC.Text = "Báo cáo theo loại hàng hóa";
            this.rbCatBC.UseVisualStyleBackColor = true;
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
            // rbFullBC
            // 
            this.rbFullBC.AutoSize = true;
            this.rbFullBC.Location = new System.Drawing.Point(19, 39);
            this.rbFullBC.Name = "rbFullBC";
            this.rbFullBC.Size = new System.Drawing.Size(152, 17);
            this.rbFullBC.TabIndex = 4;
            this.rbFullBC.TabStop = true;
            this.rbFullBC.Text = "Báo cáo toàn bộ hàng hóa";
            this.rbFullBC.UseVisualStyleBackColor = true;
            // 
            // cbLoaiHang
            // 
            this.cbLoaiHang.FormattingEnabled = true;
            this.cbLoaiHang.Location = new System.Drawing.Point(195, 71);
            this.cbLoaiHang.Name = "cbLoaiHang";
            this.cbLoaiHang.Size = new System.Drawing.Size(121, 21);
            this.cbLoaiHang.TabIndex = 5;
            // 
            // FrmThongkehanghoataicacvitri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmThongkehanghoataicacvitri";
            this.Text = "Thống kê hàng hóa tại các vị trí";
            this.Load += new System.EventHandler(this.FrmThongkehanghoataicacvitri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbLoaiHang;
        private System.Windows.Forms.RadioButton rbCatBC;
        private System.Windows.Forms.Button btnLapBC;
        private System.Windows.Forms.RadioButton rbFullBC;
    }
}