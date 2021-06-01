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
    public partial class frmSuaNV : Form
    {
        public frmSuaNV()
        {
            InitializeComponent();
        }

        public string GioiTinh = "";
        public string sql = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();
        private void frmSuaNV_Load(object sender, EventArgs e)
        {

            txtMaNV.Text = FrmDMnhanvien.maNV;
            txtTenNV.Text = FrmDMnhanvien.tenNV;
            dtpNgaySinh.Text = FrmDMnhanvien.ngaySinh;
            txtSDT.Text = FrmDMnhanvien.sDT;
            txtDiaChi.Text = FrmDMnhanvien.diaChi;
            if (FrmDMnhanvien.gioiTinh == "Nam")
                rbNam.Checked = true;
            else
                rbNu.Checked = true;
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (rbNam.Checked == true)
                GioiTinh = "Nam";
            else
                GioiTinh = "Nữ";
            sql = "sp_suaNV '" + txtMaNV.Text + "',N'" + txtTenNV.Text + "','" + dtpNgaySinh.Value.ToString("yyyy/MM/dd") + "','" + txtSDT.Text + "',N'" + GioiTinh + "',N'" + txtDiaChi.Text + "'";
            cls.Them_sua_xoa(sql);
            (System.Windows.Forms.Application.OpenForms["FrmDMnhanvien"] as FrmDMnhanvien).taiDuLieu();
            this.Close();
        }
    }
}
