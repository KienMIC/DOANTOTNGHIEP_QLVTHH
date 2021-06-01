using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.Quanlyhethong
{
    public partial class frmSuaTaiKhoan : Form
    {
        public frmSuaTaiKhoan()
        {
            InitializeComponent();
        }

        public string sql = "";
        public string id = "";
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SQLClass.clsCRUD cls = new SQLClass.clsCRUD();
            string password = Quanlyhethong.frmThemTaiKhoan.toMD5(txtPassword.Text);
            sql = "sp_suaTK '" + id + "','" + cbNhanVien.SelectedValue.ToString() + "','" + cbNhomTaiKhoan.SelectedValue.ToString() + "','" + password + "'";
            cls.Them_sua_xoa(sql);
            (System.Windows.Forms.Application.OpenForms["FrmQuanlytaikhoan"] as FrmQuanlytaikhoan).taiDuLieu();
            this.Close();
        }

        public void cb_NhanVien()
        {
            SQLClass.clsCRUD cls = new SQLClass.clsCRUD();
            sql = "SELECT MaNV,TenNV FROM NHAN_VIEN";
            cbNhanVien.DataSource = cls.getData(sql);
            cbNhanVien.DisplayMember = "TenNV";
            cbNhanVien.ValueMember = "MaNV";
        }

        public void cb_NhomTK()
        {
            SQLClass.clsCRUD cls = new SQLClass.clsCRUD();
            sql = "SELECT MaNhom,TenNhom FROM NHOM_TAIKHOAN";
            cbNhomTaiKhoan.DataSource = cls.getData(sql);
            cbNhomTaiKhoan.DisplayMember = "TenNhom";
            cbNhomTaiKhoan.ValueMember = "MaNhom";
        }

        private void frmSuaTaiKhoan_Load(object sender, EventArgs e)
        {
            cb_NhanVien();
            cb_NhomTK();
            txtUser.Text = FrmQuanlytaikhoan.user;
            cbNhanVien.Text = FrmQuanlytaikhoan.tenNV;
            cbNhomTaiKhoan.Text = FrmQuanlytaikhoan.tenNhom;
            id = FrmQuanlytaikhoan.maTK;
        }
    }
}
