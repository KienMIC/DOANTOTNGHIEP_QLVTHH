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
    public partial class FrmQuanlytaikhoan : Form
    {
        public FrmQuanlytaikhoan()
        {
            InitializeComponent();
        }

        public string sql = "";
        public static string user = "";
        public static string tenNV = "";
        public static string tenNhom = "";
        public static string maTK = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        public void taiDuLieu()
        {
            sql = "SELECT * FROM TAI_KHOAN";
            dgvTaiKhoan.DataSource = cls.getData(sql);
            dgvTaiKhoan.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Quanlyhethong.frmSuaTaiKhoan frm = new Quanlyhethong.frmSuaTaiKhoan();
            frm.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Quanlyhethong.frmThemTaiKhoan frm = new Quanlyhethong.frmThemTaiKhoan();
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sql = "sp_xoaTK '" + maTK + "'";
                cls.Them_sua_xoa(sql);
                taiDuLieu();
            }
        }

        private void FrmQuanlytaikhoan_Load(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dgvTaiKhoan.CurrentCell != null && dgvTaiKhoan.CurrentCell.Value != null)
                {
                    maTK = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString();
                    user = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString();
                    tenNV = dgvTaiKhoan.CurrentRow.Cells[2].Value.ToString();
                    tenNhom = dgvTaiKhoan.CurrentRow.Cells[3].Value.ToString();


                }
            }
        }
    }
}
