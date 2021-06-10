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
    public partial class frmChonHangHoa : Form
    {
        public frmChonHangHoa()
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
        public static DateTime BatDauLuuTru;
        public static DateTime KetThucLuuTru;
        public static string SoLuong = "";
        public static string SoKhoi = "";
        public static string TrangThai = "";
        public static string Color_str = "";
        public static int R, G, B;

        public void taiDuLieu()
        {
            sql = "SELECT * FROM HH_MS WHERE TonKho >0";
            dgvHangHoa.DataSource = cls.getData(sql);
        }

        private void frmChonHangHoa_Load(object sender, EventArgs e)
        {
            taiDuLieu();
            dgvHangHoa.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvHangHoa.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            foreach (DataGridViewRow row in dgvHangHoa.Rows)
            {
                try
                {
                    Color_str = row.Cells[9].Value.ToString();
                    //Row đầu tiên là header, row này trả về null nên try catch để chương trình không bị break
                }
                catch { continue; }
                if(Color_str != "")
                {
                    String[] argb = Color_str.Split(',');
                    int[] rgb = new int[3];
                    Int32.TryParse(argb[0], out rgb[0]);
                    Int32.TryParse(argb[1], out rgb[1]);
                    Int32.TryParse(argb[2], out rgb[2]);

                    R = rgb[0];
                    G = rgb[1];
                    B = rgb[2];

                    row.Cells[9].Style.BackColor = Color.FromArgb(R, G, B);
                    row.Cells[9].Style.ForeColor = Color.FromArgb(R, G, B);
                }
            }
        }


        private void dgvHangHoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MaHH = dgvHangHoa.CurrentRow.Cells[0].Value.ToString();
            TenHH = dgvHangHoa.CurrentRow.Cells[1].Value.ToString();
            MaLoai = dgvHangHoa.CurrentRow.Cells[3].Value.ToString();
            MaDVT = dgvHangHoa.CurrentRow.Cells[4].Value.ToString();
            MaKH = dgvHangHoa.CurrentRow.Cells[8].Value.ToString();
            BatDauLuuTru = (DateTime)dgvHangHoa.CurrentRow.Cells[5].Value;
            KetThucLuuTru = (DateTime)dgvHangHoa.CurrentRow.Cells[6].Value;
            TrangThai = dgvHangHoa.CurrentRow.Cells[7].Value.ToString();
            Color_str = dgvHangHoa.CurrentRow.Cells[9].Value.ToString();
            if(Color_str == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn màu cho hàng hóa trước khi tương tác vị trí");
                frmThemMauSac_ChonHangHoa frm = new frmThemMauSac_ChonHangHoa();
                frm.ShowDialog();
            }
            (System.Windows.Forms.Application.OpenForms["frmVitri"] as frmVitri).loadLabel();
            this.Close();
        }
    }

}
