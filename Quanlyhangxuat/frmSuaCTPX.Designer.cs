﻿
namespace DoAn1.Quanlyhangxuat
{
    partial class frmSuaCTPX
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
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtSoKhoi = new System.Windows.Forms.NumericUpDown();
            this.cbHangHoa = new System.Windows.Forms.ComboBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoXe = new System.Windows.Forms.TextBox();
            this.txtMaCTPX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoKhoi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(208, 235);
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
            this.txtSoLuong.TabIndex = 84;
            this.txtSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSoKhoi
            // 
            this.txtSoKhoi.Location = new System.Drawing.Point(208, 196);
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
            this.txtSoKhoi.TabIndex = 85;
            this.txtSoKhoi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbHangHoa
            // 
            this.cbHangHoa.FormattingEnabled = true;
            this.cbHangHoa.Location = new System.Drawing.Point(208, 160);
            this.cbHangHoa.Name = "cbHangHoa";
            this.cbHangHoa.Size = new System.Drawing.Size(235, 21);
            this.cbHangHoa.TabIndex = 83;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(354, 345);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(89, 54);
            this.btnDong.TabIndex = 81;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(56, 345);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 54);
            this.btnLuu.TabIndex = 82;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(80, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(339, 29);
            this.label7.TabIndex = 80;
            this.label7.Text = "SỬA CHI TIẾT PHIẾU XUAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 75;
            this.label2.Text = "Hàng hóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 76;
            this.label5.Text = "Số xe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 77;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 78;
            this.label3.Text = "Số khối";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 79;
            this.label1.Text = "Mã CT phiếu xuất";
            // 
            // txtSoXe
            // 
            this.txtSoXe.Location = new System.Drawing.Point(208, 274);
            this.txtSoXe.Name = "txtSoXe";
            this.txtSoXe.Size = new System.Drawing.Size(235, 20);
            this.txtSoXe.TabIndex = 73;
            // 
            // txtMaCTPX
            // 
            this.txtMaCTPX.Location = new System.Drawing.Point(208, 121);
            this.txtMaCTPX.Name = "txtMaCTPX";
            this.txtMaCTPX.Size = new System.Drawing.Size(235, 20);
            this.txtMaCTPX.TabIndex = 74;
            // 
            // frmSuaCTPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtSoKhoi);
            this.Controls.Add(this.cbHangHoa);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoXe);
            this.Controls.Add(this.txtMaCTPX);
            this.Name = "frmSuaCTPX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSuaCTPX";
            this.Load += new System.EventHandler(this.frmSuaCTPX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoKhoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtSoLuong;
        private System.Windows.Forms.NumericUpDown txtSoKhoi;
        private System.Windows.Forms.ComboBox cbHangHoa;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoXe;
        private System.Windows.Forms.TextBox txtMaCTPX;
    }
}