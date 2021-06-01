using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.Quanlyhangnhap
{
    public partial class frmSuaPN : Form
    {
        public frmSuaPN()
        {
            InitializeComponent();
        }
        public string sql = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        public void cb_NhanVien()
        {
            sql = "SELECT MaNV,TenNV FROM NHAN_VIEN";
            cbNhanVien.DataSource = cls.getData(sql);
            cbNhanVien.DisplayMember = "TenNV";
            cbNhanVien.ValueMember = "MaNV";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSuaPN_Load(object sender, EventArgs e)
        {
            cb_NhanVien();
            txtMaPN.Text = frmPhieuNhap.MaPN;
            dtpNgayLap.Text = frmPhieuNhap.NgayLap;
            cbNhanVien.Text = frmPhieuNhap.MaNV; 
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            sql = "sp_suaPN '" + txtMaPN.Text + "','" + dtpNgayLap.Text + "','" + cbNhanVien.SelectedValue.ToString() + "'";
            cls.Them_sua_xoa(sql);
            (System.Windows.Forms.Application.OpenForms["frmPhieuNhap"] as frmPhieuNhap).taiDuLieu();
            this.Close();
        }
    }
}
