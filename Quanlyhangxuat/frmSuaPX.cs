using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.Quanlyhangxuat
{
    public partial class frmSuaPX : Form
    {
        public frmSuaPX()
        {
            InitializeComponent();
        }
        public string sql = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void cb_NhanVien()
        {
            sql = "SELECT MaNV,TenNV FROM NHAN_VIEN";
            cbNhanVien.DataSource = cls.getData(sql);
            cbNhanVien.DisplayMember = "TenNV";
            cbNhanVien.ValueMember = "MaNV";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            sql = "sp_suaPX '" + txtMaPX.Text + "','" + dtpNgayLap.Text + "','" + cbNhanVien.SelectedValue.ToString() + "'";
            cls.Them_sua_xoa(sql);
            (System.Windows.Forms.Application.OpenForms["frmPhieuXuat"] as frmPhieuXuat).taiDuLieu();
            this.Close();
        }

        private void frmSuaPX_Load(object sender, EventArgs e)
        {
            cb_NhanVien();
            txtMaPX.Text = frmPhieuXuat.MaPX;
            dtpNgayLap.Text = frmPhieuXuat.NgayLap;
            cbNhanVien.Text = frmPhieuXuat.MaNV;
        }
    }
}
