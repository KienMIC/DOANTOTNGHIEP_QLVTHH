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
    public partial class frmThemLoaiHH : Form
    {
        public frmThemLoaiHH()
        {
            InitializeComponent();
        }

        public string sql = "";
        public string MaLoai = "";
        public string TenLoai = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MaLoai = txtMaLoai.Text;
            TenLoai = txtTenLoai.Text;
            sql = "sp_themLH '" + MaLoai + "',N'" + TenLoai + "'";
            cls.Them_sua_xoa(sql);
            (System.Windows.Forms.Application.OpenForms["FrmDMloaihanghoa"] as FrmDMloaihanghoa).taiDuLieu();
            this.Close();

        }
    }
}
