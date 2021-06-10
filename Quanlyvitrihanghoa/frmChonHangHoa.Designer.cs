
namespace DoAn1.Quanlyvitrihanghoa
{
    partial class frmChonHangHoa
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Mahanghoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenhanghoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maloaihanghoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Madonvitinhhanghoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthaihanghoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(760, 15);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(173, 20);
            this.txtTimKiem.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvHangHoa);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 441);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HÀNG HÓA";
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AllowUserToAddRows = false;
            this.dgvHangHoa.AllowUserToDeleteRows = false;
            this.dgvHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHangHoa.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahanghoa,
            this.Tenhanghoa,
            this.Maloaihanghoa,
            this.Madonvitinhhanghoa,
            this.Trangthaihanghoa,
            this.Tenkhachhang,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvHangHoa.Location = new System.Drawing.Point(6, 19);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.ReadOnly = true;
            this.dgvHangHoa.Size = new System.Drawing.Size(945, 416);
            this.dgvHangHoa.TabIndex = 0;
            this.dgvHangHoa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(668, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "TÌM KIẾM";
            // 
            // Mahanghoa
            // 
            this.Mahanghoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mahanghoa.DataPropertyName = "MaHH";
            this.Mahanghoa.HeaderText = "Mã hàng hóa";
            this.Mahanghoa.Name = "Mahanghoa";
            this.Mahanghoa.ReadOnly = true;
            // 
            // Tenhanghoa
            // 
            this.Tenhanghoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenhanghoa.DataPropertyName = "TenHH";
            this.Tenhanghoa.HeaderText = "Tên hàng hóa";
            this.Tenhanghoa.Name = "Tenhanghoa";
            this.Tenhanghoa.ReadOnly = true;
            // 
            // Maloaihanghoa
            // 
            this.Maloaihanghoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Maloaihanghoa.DataPropertyName = "TenLoai";
            this.Maloaihanghoa.HeaderText = "Loại hàng hóa";
            this.Maloaihanghoa.Name = "Maloaihanghoa";
            this.Maloaihanghoa.ReadOnly = true;
            // 
            // Madonvitinhhanghoa
            // 
            this.Madonvitinhhanghoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Madonvitinhhanghoa.DataPropertyName = "TenDVT";
            this.Madonvitinhhanghoa.HeaderText = "Đơn vị tính";
            this.Madonvitinhhanghoa.Name = "Madonvitinhhanghoa";
            this.Madonvitinhhanghoa.ReadOnly = true;
            // 
            // Trangthaihanghoa
            // 
            this.Trangthaihanghoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Trangthaihanghoa.DataPropertyName = "TrangThai";
            this.Trangthaihanghoa.HeaderText = "Trạng thái hàng hóa";
            this.Trangthaihanghoa.Name = "Trangthaihanghoa";
            this.Trangthaihanghoa.ReadOnly = true;
            // 
            // Tenkhachhang
            // 
            this.Tenkhachhang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenkhachhang.DataPropertyName = "TenKH";
            this.Tenkhachhang.HeaderText = "Tên KH";
            this.Tenkhachhang.Name = "Tenkhachhang";
            this.Tenkhachhang.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BatDauLuuTru";
            this.Column1.HeaderText = "Bắt đầu lưu trữ ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "KetthucLuuTru";
            this.Column2.HeaderText = "Kết thúc lưu trữ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TonKho";
            this.Column3.HeaderText = "Tồn kho";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Color";
            this.Column4.HeaderText = "Màu sắc";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmChonHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(981, 510);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmChonHangHoa";
            this.Text = "CHỌN HÀNG HÓA";
            this.Load += new System.EventHandler(this.frmChonHangHoa_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahanghoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenhanghoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maloaihanghoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Madonvitinhhanghoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthaihanghoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}