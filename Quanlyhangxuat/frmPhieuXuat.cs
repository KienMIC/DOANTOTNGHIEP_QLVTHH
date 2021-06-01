using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.Quanlyhangxuat
{
    public partial class frmPhieuXuat : Form
    {
        public frmPhieuXuat()
        {
            InitializeComponent();
        }
        public string sql = "",sql1="";
        public static string MaPX = "";
        public static string NgayLap = "";
        public static string MaNV = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        public void taiDuLieu()
        {
            sql = "SELECT * FROM PX";
            dgvPhieuXuat.DataSource = cls.getData(sql);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemPX f1 = new frmThemPX();
            f1.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaPX f1 = new frmSuaPX();
            f1.ShowDialog();
        }

        private void dgvPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaPX = dgvPhieuXuat.CurrentRow.Cells[0].Value.ToString();
            NgayLap = dgvPhieuXuat.CurrentRow.Cells[1].Value.ToString();
            MaNV = dgvPhieuXuat.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvPhieuXuat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmChiTietPhieuXuat f1 = new frmChiTietPhieuXuat();
            f1.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sql = "sp_xoaAll_CTPX '" + MaPX + "'";
                sql1 = "sp_xoaPX '" + MaPX + "'";
                cls.Them_sua_xoa(sql);
                cls.Them_sua_xoa(sql1);
                taiDuLieu();
            }
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            taiDuLieu();
            dgvPhieuXuat.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            sql = "sp_tkPN '" + txtTimKiem.Text + "'";
            dgvPhieuXuat.DataSource = cls.getData(sql);
        }
    }
}
