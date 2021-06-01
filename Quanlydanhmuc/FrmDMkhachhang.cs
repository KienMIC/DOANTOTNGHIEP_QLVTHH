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
    public partial class FrmDMkhachhang : Form
    {
        public FrmDMkhachhang()
        {
            InitializeComponent();
        }
        public string sql = "";
        public static string maKH = "";
        public static string tenKH = "";
        public static string sDT = "";
        public static string diaChi = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        public void taiDuLieu()
        {
            sql = "SELECT * FROM KHACH_HANG";
            dgvKhachHang.DataSource = cls.getData(sql);
        }

        private void FrmDMkhachhang_Load(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Quanlydanhmuc.ThemSuaDanhMuc.frmThemKH f1 = new Quanlydanhmuc.ThemSuaDanhMuc.frmThemKH();
            f1.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Quanlydanhmuc.ThemSuaDanhMuc.frmSuaKH f1 = new Quanlydanhmuc.ThemSuaDanhMuc.frmSuaKH();
            f1.ShowDialog();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dgvKhachHang.CurrentCell != null && dgvKhachHang.CurrentCell.Value != null)
                {
                    maKH = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
                    tenKH = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
                    sDT = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
                    diaChi = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
                }
            }
        }

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Quanlydanhmuc.ThemSuaDanhMuc.frmSuaKH frm = new Quanlydanhmuc.ThemSuaDanhMuc.frmSuaKH();
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sql = "sp_xoaKH '" + maKH + "'";
                cls.Them_sua_xoa(sql);
                taiDuLieu();
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            sql = "sp_tkKH N'" + txtTimKiem.Text + "'";
            dgvKhachHang.DataSource = cls.getData(sql);
        }
    }
}
