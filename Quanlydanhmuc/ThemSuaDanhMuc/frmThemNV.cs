using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.Quanlydanhmuc
{
    public partial class frmThemNV : Form
    {
        public frmThemNV()
        {
            InitializeComponent();
        }

        public string sql = "";
        public string MaNV = "";
        public string TenNV = "";
        public string NgaySinh = "";
        public string GioiTinh = "";
        public string SDT = "";
        public string DiaChi = "";

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SQLClass.clsCRUD cls = new SQLClass.clsCRUD();
            MaNV = txtMaNV.Text;
            TenNV = txtTenNV.Text;
            SDT = txtSDT.Text;
            NgaySinh = dtpNgaySinh.Value.ToString("yyyy/MM/dd");
            if (rbNam.Checked == true)
                GioiTinh = "Nam";
            else
                GioiTinh = "Nữ";
            DiaChi = txtDiaChi.Text;
            sql = "sp_themNV '" + MaNV + "',N'" + TenNV + "','" + NgaySinh + "','" + SDT + "',N'" +GioiTinh+ "',N'" + DiaChi + "'";
            cls.Them_sua_xoa(sql);
            (System.Windows.Forms.Application.OpenForms["FrmDMnhanvien"] as FrmDMnhanvien).taiDuLieu();
            this.Close();
        }

        private void frmThemNV_Load(object sender, EventArgs e)
        {

        }
    }
}
