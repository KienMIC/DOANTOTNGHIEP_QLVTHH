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
    public partial class frmThemCTPN : Form
    {
        public frmThemCTPN()
        {
            InitializeComponent();
        }
        public string sql = "";
        public string MaCTPN = "";
        public string MaHH = "";
        public int SoKhoi;
        public int SoLuong;
        public string SoXe = "";
        public string MaPN = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        public void cb_HangHoa()
        {
            sql = "SELECT MaHH,TenHH FROM HANG_HOA";
            cbHangHoa.DataSource = cls.getData(sql);
            cbHangHoa.DisplayMember = "TenHH";
            cbHangHoa.ValueMember = "MaHH";
        }

        private void frmThemCTPN_Load(object sender, EventArgs e)
        {
            cb_HangHoa();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MaCTPN = txtMaCTPN.Text;
            MaPN = frmPhieuNhap.MaPN;
            MaHH = cbHangHoa.SelectedValue.ToString();
            SoKhoi = (int)txtSoKhoi.Value;
            SoLuong = (int)txtSoLuong.Value;
            SoXe = txtSoXe.Text;
            sql = "sp_themCTPN '" + MaCTPN + "','" + MaPN + "','" + MaHH + "','" + SoXe + "','" + SoKhoi + "','" + SoLuong + "'";
            cls.Them_sua_xoa(sql);
            (System.Windows.Forms.Application.OpenForms["frmChiTietPhieuNhap"] as frmChiTietPhieuNhap).taiDuLieu();
            this.Close();
        }
    }
}
