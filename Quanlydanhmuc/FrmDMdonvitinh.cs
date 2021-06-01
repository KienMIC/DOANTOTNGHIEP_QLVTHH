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
    public partial class FrmDMdonvitinh : Form
    {
        public FrmDMdonvitinh()
        {
            InitializeComponent();
        }
        public string sql = "";
        public static string maDVT = "";
        public static string tenDVT = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        public void taiDuLieu()
        {
            sql = "SELECT * FROM DON_VITINH";
            dgvDVT.DataSource = cls.getData(sql);
        }

        private void FrmDMdonvitinh_Load(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Quanlydanhmuc.ThemSuaDanhMuc.frmThemDVT f1 = new Quanlydanhmuc.ThemSuaDanhMuc.frmThemDVT();
            f1.ShowDialog();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Quanlydanhmuc.ThemSuaDanhMuc.frmSuaDVT f1 = new Quanlydanhmuc.ThemSuaDanhMuc.frmSuaDVT();
            f1.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sql = "sp_xoaDVT '" + maDVT + "'";
                cls.Them_sua_xoa(sql);
                taiDuLieu();
            }
        }

        private void dgvDVT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dgvDVT.CurrentCell != null && dgvDVT.CurrentCell.Value != null)
                {
                    maDVT = dgvDVT.CurrentRow.Cells[0].Value.ToString();
                    tenDVT = dgvDVT.CurrentRow.Cells[1].Value.ToString();
                }
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            sql = "sp_tkDVT N'" + txtTimKiem.Text + "'";
            dgvDVT.DataSource = cls.getData(sql);
        }

        private void dgvDVT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Quanlydanhmuc.ThemSuaDanhMuc.frmSuaDVT frm = new Quanlydanhmuc.ThemSuaDanhMuc.frmSuaDVT();
            frm.ShowDialog();
        }
    }
}
