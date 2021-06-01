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
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        public string sql = "", sql1 ="";
        public static string MaPN = "";
        public static string NgayLap;
        public static string MaNV = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        public void taiDuLieu()
        {
            sql = "SELECT * FROM PN";
            dgvPhieuNhap.DataSource = cls.getData(sql);
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            taiDuLieu();
            dgvPhieuNhap.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemPN f1 = new frmThemPN();
            f1.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaPN f1 = new frmSuaPN();
            f1.ShowDialog();
        }

        private void dgvPhieuNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmChiTietPhieuNhap f1 = new frmChiTietPhieuNhap();
            f1.ShowDialog();
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MaPN = dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString();
                NgayLap = dgvPhieuNhap.CurrentRow.Cells[1].Value.ToString();
                MaNV = dgvPhieuNhap.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex) { 
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sql1 = "sp_xoaPN '" + MaPN + "'";
                sql = "sp_xoaAll_CTPN '" + MaPN + "'";
                cls.Them_sua_xoa(sql);
                cls.Them_sua_xoa(sql1);
                taiDuLieu();
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            sql = "sp_tkPN '" + txtTimKiem.Text + "'";
            dgvPhieuNhap.DataSource = cls.getData(sql);
        }
    }
}
