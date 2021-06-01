using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAn1
{
    public partial class FrmDangnhap : Form
    {
        public FrmDangnhap()
        {
            InitializeComponent();
        }
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();
        public string sql = "";
        public static string MaNhom = "", MaNV = "";

        private void btnDangnhap_Click(object sender, EventArgs e)
        { 
            string password = Quanlyhethong.frmThemTaiKhoan.toMD5(txtPassword.Text);
            sql = "SELECT * FROM TAI_KHOANNV WHERE TenTK = '" + txtUser.Text + "' AND MatKhau = '" + password + "'";
            if(cls.getData(sql) != null)
            {
                //Lấy tên nhóm tài khoản để phân quyền trên frmMain
                DataTable tbl = new DataTable();
                tbl = cls.getData(sql);
                MaNhom = (String)tbl.Rows[0][3];
                MaNV = (String)tbl.Rows[0][1];
                this.Hide();
                frmMain f1 = new frmMain();
                f1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, vui lòng nhập lại!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnDangnhap.PerformClick();
            }
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
