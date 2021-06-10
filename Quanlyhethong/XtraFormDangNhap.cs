using DevExpress.XtraEditors;
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
    public partial class XtraFormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormDangNhap()
        {
            InitializeComponent();
        }

        private void XtraFormDangNhap_Load(object sender, EventArgs e)
        {

        }
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();
        public string sql = "";
        public static string MaNhom = "", MaNV = "", username = "";

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string password = Quanlyhethong.frmThemTaiKhoan.toMD5(txtPassword.Text);
            sql = "SELECT * FROM TAI_KHOANNV WHERE TenTK = '" + txtUser.Text + "' AND MatKhau = '" + password + "'";
            if (cls.getData(sql) != null)
            {
                //Lấy tên nhóm tài khoản để phân quyền trên frmMain
                DataTable tbl = new DataTable();
                tbl = cls.getData(sql);

                MaNhom = (String)tbl.Rows[0][3];
                MaNV = (String)tbl.Rows[0][1];
                username = txtUser.Text;
                this.Hide();
                Frmmainn f1 = new Frmmainn();
                f1.ShowDialog();
                this.Close();
            }
            else
            {
                //MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DevExpress.XtraEditors.XtraMessageBox.Show("Tài khoản hoặc mật khẩu không đúng, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangnhap.PerformClick();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangnhap.PerformClick();
            }
        }
    }
}