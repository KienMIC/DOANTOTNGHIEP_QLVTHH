using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DoAn1.Quanlyhethong
{
    public partial class frmThemTaiKhoan : Form
    {
        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }

        public string sql = "";
        public string user = "";
        public string password = "";
        public string MaNV = "";
        public string MaNhom = "";
        public string NgayLap = "";
        private void btnDong_Click(object sender, EventArgs e)
        {
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

        public static string toMD5(string pass)
        {
            MD5CryptoServiceProvider myMD5 = new MD5CryptoServiceProvider();
            byte[] myPass = System.Text.Encoding.UTF8.GetBytes(pass);
            myPass = myMD5.ComputeHash(myPass);

            StringBuilder s = new StringBuilder();
            foreach (byte p in myPass)
            {
                s.Append(p.ToString("x").ToLower());
            }
            return s.ToString();
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            SQLClass.clsCRUD cls = new SQLClass.clsCRUD();
            user = txtUser.Text;
            password = toMD5(txtPassword.Text);
            MaNhom = cbNhomTaiKhoan.SelectedValue.ToString();
            NgayLap = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            MaNV = cbNhanVien.SelectedValue.ToString();
            sql = "sp_themTK '"+ MaNV + "','" + NgayLap + "','" + MaNhom + "','" + user + "','" + password + "'";
            cls.Them_sua_xoa(sql);
            (System.Windows.Forms.Application.OpenForms["FrmQuanlytaikhoan"] as FrmQuanlytaikhoan).taiDuLieu();
            this.Close();
        }

        private void frmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            cb_NhanVien();
            cb_NhomTK();
        }
    }
}
