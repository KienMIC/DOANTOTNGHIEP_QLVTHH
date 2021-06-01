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
    public partial class frmThemDVT : Form
    {
        public frmThemDVT()
        {
            InitializeComponent();
        }

        public string sql = "";
        public string MaDVT = "";
        public string TenDVT = "";

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SQLClass.clsCRUD cls = new SQLClass.clsCRUD();
            MaDVT = txtMaDVT.Text;
            TenDVT = txtTenDVT.Text;
            sql = "sp_themDVT '" + MaDVT + "',N'" + TenDVT + "'";
            cls.Them_sua_xoa(sql);
            (System.Windows.Forms.Application.OpenForms["FrmDMdonvitinh"] as FrmDMdonvitinh).taiDuLieu();
            this.Close();
        }
    }
}
