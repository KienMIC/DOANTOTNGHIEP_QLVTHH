using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.Quanlyvitrihanghoa
{
    public partial class frmQuanLyMauSac : Form
    {
        public frmQuanLyMauSac()
        {
            InitializeComponent();
        }
        public string sql = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();
        public static String Color_str = "";
        public static int R, G, B;
        public static string ID, MaHH,TenHH = "";

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemMauSac frm = new frmThemMauSac();
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaMauSac frm = new frmSuaMauSac();
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sql = "sp_xoaCL '" + ID + "'";
                cls.Them_sua_xoa(sql);
                taiDuLieu();
            }
        }

        private void dgvMauSac_SelectionChanged(object sender, EventArgs e)
        {
                if (dgvMauSac.CurrentCell != null && dgvMauSac.CurrentCell.Value != null)
                {
                    ID = dgvMauSac.CurrentRow.Cells[0].Value.ToString();
                    MaHH = dgvMauSac.CurrentRow.Cells[1].Value.ToString();
                    TenHH = dgvMauSac.CurrentRow.Cells[2].Value.ToString();
                    Color_str = dgvMauSac.CurrentRow.Cells[3].Value.ToString();
                }
        }

        public void taiDuLieu()
        {
            sql = "SELECT * FROM COLOR";
            dgvMauSac.DataSource = cls.getData(sql);
            foreach(DataGridViewRow row in dgvMauSac.Rows)
            {
                try
                {
                    Color_str = row.Cells[3].Value.ToString();
                    //Row đầu tiên là header, row này trả về null nên try catch để chương trình không bị break
                }
                catch { continue; }
                
                String[] argb = Color_str.Split(',');
                int[] rgb = new int[3];
                Int32.TryParse(argb[0], out rgb[0]);
                Int32.TryParse(argb[1], out rgb[1]);
                Int32.TryParse(argb[2], out rgb[2]);

                R = rgb[0];
                G = rgb[1];
                B = rgb[2];

                row.Cells[3].Style.BackColor = Color.FromArgb(R, G, B);
                row.Cells[3].Style.ForeColor = Color.FromArgb(R, G, B);
            }
            
        }

        private void frmQuanLyMauSac_Load(object sender, EventArgs e)
        {
            taiDuLieu();
        }
    }
}
