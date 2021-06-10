using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.Quanlyhangnhap
{
    public partial class frmChiTietPhieuNhap : Form
    {
        public frmChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        public static string MaCTPN = "";
        public static string MaHH = "";
        public static string SoXe = "";
        public static int SoKhoi;
        public static int SoLuong;
        public string sql = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        public void taiDuLieu()
        {
            sql = "sp_viewCTPN '" + frmPhieuNhap.MaPN + "'";
            dgvCTPN.DataSource = cls.getData(sql);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemCTPN f1 = new frmThemCTPN();
            f1.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaCTPN f1 = new frmSuaCTPN();
            f1.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sql = "sp_xoaCTPN '" + MaCTPN + "'";
                if (cls.Them_sua_xoa(sql))
                {
                    taiDuLieu();
                }
            }
        }

        private void frmChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void dgvCTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaCTPN = dgvCTPN.CurrentRow.Cells[0].Value.ToString();
            MaHH = dgvCTPN.CurrentRow.Cells[1].Value.ToString();
            SoXe = dgvCTPN.CurrentRow.Cells[2].Value.ToString();
            try
            {
                SoKhoi = (int)dgvCTPN.CurrentRow.Cells[3].Value;
                SoLuong = (int)dgvCTPN.CurrentRow.Cells[4].Value;
            }
            catch (Exception ex) { }
        }
    }
}
