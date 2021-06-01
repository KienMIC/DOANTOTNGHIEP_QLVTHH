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
    public partial class frmSuaLoaiHH : Form
    {
        public frmSuaLoaiHH()
        {
            InitializeComponent();
        }
        public string sql = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        private void btnLuu_Click(object sender, EventArgs e)
        {
            sql = "sp_suaLH '" + txtMaLoai.Text + "',N'" + txtTenLoai.Text + "'";
            cls.Them_sua_xoa(sql);
            (System.Windows.Forms.Application.OpenForms["FrmDMloaihanghoa"] as FrmDMloaihanghoa).taiDuLieu();
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSuaLoaiHH_Load(object sender, EventArgs e)
        {
            txtMaLoai.Text = FrmDMloaihanghoa.maLoai;
            txtTenLoai.Text = FrmDMloaihanghoa.tenLoai;
        }
    }
}
