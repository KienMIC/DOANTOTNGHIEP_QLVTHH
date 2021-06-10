using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.Quanlydanhmuc.ThemSuaDanhMuc
{
    public partial class frmThemKH : Form
    {
        public frmThemKH()
        {
            InitializeComponent();
        }
        public string MaKH = "";
        public string TenKH = "";
        public string SDT = "";
        public string DiaChi = "";
        public string sql = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MaKH = txtMaKH.Text;
            TenKH = txtTenKH.Text;
            SDT = txtSDT.Text;
            DiaChi = txtDiaChi.Text;
            sql = "sp_themKH '" + MaKH + "',N'" + TenKH + "','" + SDT + "',N'" + DiaChi + "'";
            cls.Them_sua_xoa(sql);
            (System.Windows.Forms.Application.OpenForms["FrmDMkhachhang"] as FrmDMkhachhang).taiDuLieu();
            this.Close();
        }

        private void frmThemKH_Load(object sender, EventArgs e)
        {

        }
    }
}
