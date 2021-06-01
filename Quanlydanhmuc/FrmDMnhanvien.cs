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
    public partial class FrmDMnhanvien : Form
    {
        public FrmDMnhanvien()
        {
            InitializeComponent();
        }
        public string sql = "";
        public static string maNV = "";
        public static string tenNV = "";
        public static string ngaySinh = "";
        public static string sDT = "";
        public static string diaChi = "";
        public static string gioiTinh = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        public void taiDuLieu()
        {
            sql = "SELECT * FROM NHAN_VIEN";
            dgvNhanVien.DataSource = cls.getData(sql);
            dgvNhanVien.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private void FrmDMnhanvien_Load(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNV f1 = new frmThemNV();
            f1.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ThemSuaDanhMuc.frmSuaNV f1 = new ThemSuaDanhMuc.frmSuaNV();
            f1.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            taiDuLieu();
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                if(dgvNhanVien.CurrentCell != null && dgvNhanVien.CurrentCell.Value != null)
                {
                    maNV = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                    tenNV = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                    ngaySinh = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                    sDT = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
                    gioiTinh = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
                    diaChi = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
                    
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sql = "sp_xoaNV '" + maNV + "'";
                cls.Them_sua_xoa(sql);
                taiDuLieu();
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            sql = "sp_tkNV N'" + txtTimKiem.Text + "'";
            dgvNhanVien.DataSource = cls.getData(sql);
        }

        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ThemSuaDanhMuc.frmSuaNV frm = new ThemSuaDanhMuc.frmSuaNV();
            frm.ShowDialog();
        }
    }
}
