
namespace DoAn1.Quanlyhangxuat
{
    partial class frmThemCTPX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemCTPX));
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtSoKhoi = new System.Windows.Forms.NumericUpDown();
            this.cbHangHoa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoXe = new System.Windows.Forms.TextBox();
            this.txtMaCTPN = new System.Windows.Forms.TextBox();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoKhoi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(200, 215);
            this.txtSoLuong.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(235, 20);
            this.txtSoLuong.TabIndex = 71;
            this.txtSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSoKhoi
            // 
            this.txtSoKhoi.Location = new System.Drawing.Point(200, 176);
            this.txtSoKhoi.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtSoKhoi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoKhoi.Name = "txtSoKhoi";
            this.txtSoKhoi.Size = new System.Drawing.Size(235, 20);
            this.txtSoKhoi.TabIndex = 72;
            this.txtSoKhoi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbHangHoa
            // 
            this.cbHangHoa.FormattingEnabled = true;
            this.cbHangHoa.Location = new System.Drawing.Point(200, 140);
            this.cbHangHoa.Name = "cbHangHoa";
            this.cbHangHoa.Size = new System.Drawing.Size(235, 21);
            this.cbHangHoa.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(60, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(361, 29);
            this.label7.TabIndex = 67;
            this.label7.Text = "THÊM CHI TIẾT PHIẾU XUẤT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Hàng hóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 63;
            this.label5.Text = "Số xe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Số khối";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Mã CT phiếu nhập";
            // 
            // txtSoXe
            // 
            this.txtSoXe.Location = new System.Drawing.Point(200, 254);
            this.txtSoXe.Name = "txtSoXe";
            this.txtSoXe.Size = new System.Drawing.Size(235, 20);
            this.txtSoXe.TabIndex = 60;
            // 
            // txtMaCTPN
            // 
            this.txtMaCTPN.Location = new System.Drawing.Point(200, 101);
            this.txtMaCTPN.Name = "txtMaCTPN";
            this.txtMaCTPN.Size = new System.Drawing.Size(235, 20);
            this.txtMaCTPN.TabIndex = 61;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(48, 332);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(98, 40);
            this.btnLuu.TabIndex = 75;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(324, 332);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(98, 40);
            this.btnDong.TabIndex = 76;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmThemCTPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(480, 405);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtSoKhoi);
            this.Controls.Add(this.cbHangHoa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoXe);
            this.Controls.Add(this.txtMaCTPN);
            this.Name = "frmThemCTPX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÊM CHI TIẾT PHIẾU XUẤT";
            this.Load += new System.EventHandler(this.frmThemCTPX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoKhoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtSoLuong;
        private System.Windows.Forms.NumericUpDown txtSoKhoi;
        private System.Windows.Forms.ComboBox cbHangHoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoXe;
        private System.Windows.Forms.TextBox txtMaCTPN;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnDong;
    }
}