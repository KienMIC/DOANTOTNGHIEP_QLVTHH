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
    public partial class frmThemPX : Form
    {
        public frmThemPX()
        {
            InitializeComponent();
        }
        public string MaPX = "";
        public string NgayLap = "";
        public string MaNV = "";
        public string sql = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        public void cb_NhanVien()
        {
            sql = "SELECT MaNV,TenNV FROM NHAN_VIEN";
            cbNhanVien.DataSource = cls.getData(sql);
            cbNhanVien.DisplayMember = "TenNV";
            cbNhanVien.ValueMember = "MaNV";
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }


        private void frmThemPX_Load(object sender, EventArgs e)
        {
            cb_NhanVien();
        }

    }
}
