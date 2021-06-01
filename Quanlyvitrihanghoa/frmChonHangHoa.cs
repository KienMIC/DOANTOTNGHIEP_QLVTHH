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

        public void taiDuLieu()
        {
            sql = "SELECT * FROM HH WHERE TonKho >0";
            dgvHangHoa.DataSource = cls.getData(sql);
        }

        private void frmChonHangHoa_Load(object sender, EventArgs e)
        {
            taiDuLieu();
            dgvHangHoa.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvHangHoa.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
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
            (System.Windows.Forms.Application.OpenForms["frmVitri"] as frmVitri).loadLabel();
            this.Close();
        }
    }

}
