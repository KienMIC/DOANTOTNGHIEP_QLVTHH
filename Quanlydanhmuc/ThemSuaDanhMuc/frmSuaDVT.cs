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
    public partial class frmSuaDVT : Form
    {
        public frmSuaDVT()
        {
            InitializeComponent();
        }
        public string sql = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        private void frmSuaDVT_Load(object sender, EventArgs e)
        {
            txtMaDVT.Text = FrmDMdonvitinh.maDVT;
            txtTenDVT.Text = FrmDMdonvitinh.tenDVT;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            sql = "sp_suaDVT '" + txtMaDVT.Text + "',N'" + txtTenDVT.Text + "'";
            cls.Them_sua_xoa(sql);
            (System.Windows.Forms.Application.OpenForms["FrmDMdonvitinh"] as FrmDMdonvitinh).taiDuLieu();
            this.Close();
        }
    }
}
