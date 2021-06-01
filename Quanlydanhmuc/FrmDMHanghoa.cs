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
    public partial class FrmDMhanghoa : Form
    {
        public FrmDMhanghoa()
        {
            InitializeComponent();
        }
        public string sql = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();
        public static string MaHH = "";
        public static string TenHH = "";
        public static string MaLoai = "";
        public static string MaDVT = "";
        public static string MaKH = "";
        public static string BatDauLuuTru = "";
        public static string KetThucLuuTru = "";

        public void taiDuLieu()
        {
            sql = "SELECT * FROM HH";
            dgvHangHoa.DataSource = cls.getData(sql);
        }

        private void FrmDMhanghoa_Load(object sender, EventArgs e)
        {
            taiDuLieu();
            dgvHangHoa.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvHangHoa.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Quanlydanhmuc.ThemSuaDanhMuc.frmThemHH f1 = new Quanlydanhmuc.ThemSuaDanhMuc.frmThemHH();
            f1.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Quanlydanhmuc.frmSuaHH f1 = new Quanlydanhmuc.frmSuaHH();
            f1.ShowDialog();
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            sql = "sp_tkHH N'" + txtTimKiem.Text + "'";
            dgvHangHoa.DataSource = cls.getData(sql);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sql = "sp_xoaHH '" + MaHH + "'";
                cls.Them_sua_xoa(sql);
                taiDuLieu();
            }
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaHH = dgvHangHoa.CurrentRow.Cells[0].Value.ToString();
            TenHH = dgvHangHoa.CurrentRow.Cells[1].Value.ToString();
            MaLoai = dgvHangHoa.CurrentRow.Cells[3].Value.ToString();
            MaDVT = dgvHangHoa.CurrentRow.Cells[4].Value.ToString();
            MaKH = dgvHangHoa.CurrentRow.Cells[8].Value.ToString();
            BatDauLuuTru = dgvHangHoa.CurrentRow.Cells[5].Value.ToString();
            KetThucLuuTru = dgvHangHoa.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            taiDuLieu();
        }
    }
}
