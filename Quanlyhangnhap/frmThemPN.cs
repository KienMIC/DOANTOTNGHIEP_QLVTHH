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
    public partial class frmThemPN : Form
    {
        public frmThemPN()
        {
            InitializeComponent();
        }
        public string MaPN = "";
        public string NgayLap = "";
        public string MaNV = "";
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MaPN = txtMaPN.Text;
            NgayLap = dtpNgayLap.Value.ToString("yyyy/MM/dd");
            MaNV = cbNhanVien.SelectedValue.ToString();
            sql = "sp_themPN '" + MaPN + "','" + NgayLap + "','" + MaNV + "'";
            cls.Them_sua_xoa(sql);
            (System.Windows.Forms.Application.OpenForms["frmPhieuNhap"] as frmPhieuNhap).taiDuLieu();
            this.Close();
        }

        private void frmThemPN_Load(object sender, EventArgs e)
        {
            cb_NhanVien();
        }
    }
}
