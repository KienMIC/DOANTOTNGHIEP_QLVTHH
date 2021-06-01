using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class FrmDMloaihanghoa : Form
    {
        public FrmDMloaihanghoa()
        {
            InitializeComponent();
        }

        public string sql = "";
        public static string maLoai = "";
        public static string tenLoai = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        public void taiDuLieu()
        {
            sql = "SELECT * FROM LOAI_HANGHOA";
            dgvLoaiHang.DataSource = cls.getData(sql);
        }

        private void FrmDMloaihanghoa_Load(object sender, EventArgs e)
        {
            taiDuLieu();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            Quanlydanhmuc.ThemSuaDanhMuc.frmThemLoaiHH f1 = new Quanlydanhmuc.ThemSuaDanhMuc.frmThemLoaiHH();
            f1.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Quanlydanhmuc.ThemSuaDanhMuc.frmSuaLoaiHH f1 = new Quanlydanhmuc.ThemSuaDanhMuc.frmSuaLoaiHH();
            f1.ShowDialog();
        }

        private void dgvLoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maLoai = dgvLoaiHang.CurrentRow.Cells[0].Value.ToString();
            tenLoai = dgvLoaiHang.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sql = "sp_xoaLH '" + maLoai + "'";
                cls.Them_sua_xoa(sql);
                taiDuLieu();
            }
        }

        private void dgvLoaiHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Quanlydanhmuc.ThemSuaDanhMuc.frmSuaLoaiHH frm = new Quanlydanhmuc.ThemSuaDanhMuc.frmSuaLoaiHH();
            frm.ShowDialog();
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            sql = "sp_tkLH N'" + txtTimKiem.Text + "'";
            dgvLoaiHang.DataSource = cls.getData(sql);
        }
    }
}
