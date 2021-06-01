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
    public partial class frmSuaKH : Form
    {
        public frmSuaKH()
        {
            InitializeComponent();
        }
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();
        public string sql = "";
        private void frmSuaKH_Load(object sender, EventArgs e)
        {
            txtMaKH.Text = FrmDMkhachhang.maKH;
            txtTenKH.Text = FrmDMkhachhang.tenKH;
            txtSDT.Text = FrmDMkhachhang.sDT;
            txtDiaChi.Text = FrmDMkhachhang.diaChi;      
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            sql = "sp_suaKH '" + txtMaKH.Text + "',N'" + txtTenKH.Text + "','" + txtSDT.Text + "',N'" + txtDiaChi.Text + "'";
            cls.Them_sua_xoa(sql);
            (System.Windows.Forms.Application.OpenForms["FrmDMkhachhang"] as FrmDMkhachhang).taiDuLieu();
            this.Close();
        }
    }
}
