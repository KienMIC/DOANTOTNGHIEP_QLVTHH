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
    public partial class frmChiTietPhieuXuat : Form
    {
        public frmChiTietPhieuXuat()
        {
            InitializeComponent();
        }

        public static string MaCTPX = "";
        public static string MaHH = "";
        public static string SoXe = "";
        public static int SoKhoi;
        public static int SoLuong;
        public string sql = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        public void taiDuLieu()
        {
            sql = "sp_viewCTPX '" + frmPhieuXuat.MaPX + "'";
            dgvCTPX.DataSource = cls.getData(sql);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemCTPX f1 = new frmThemCTPX();
            f1.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaCTPX f1 = new frmSuaCTPX();
            f1.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sql = "sp_xoaCTPX '" + MaCTPX + "'";
                if (cls.Them_sua_xoa(sql)) {
                    taiDuLieu();
                }
                
            }
        }

        private void frmChiTietPhieuXuat_Load(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void dgvCTPX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MaCTPX = dgvCTPX.CurrentRow.Cells[0].Value.ToString();
                MaHH = dgvCTPX.CurrentRow.Cells[1].Value.ToString();
                SoXe = dgvCTPX.CurrentRow.Cells[2].Value.ToString();
                SoXe = dgvCTPX.CurrentRow.Cells[2].Value.ToString();
                SoKhoi = (int)dgvCTPX.CurrentRow.Cells[3].Value;
                SoLuong = (int)dgvCTPX.CurrentRow.Cells[4].Value;
            }
            catch (Exception ex) {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.ToString());
            }

        }
    }
}
