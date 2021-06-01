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
    public partial class frmSuaCTPN : Form
    {
        public frmSuaCTPN()
        {
            InitializeComponent();
        }
        public string sql = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();
        public void cb_HangHoa()
        {
            sql = "SELECT MaHH,TenHH FROM HANG_HOA";
            cbHangHoa.DataSource = cls.getData(sql);
            cbHangHoa.DisplayMember = "TenHH";
            cbHangHoa.ValueMember = "MaHH";
        }
        private void frmSuaCTPN_Load(object sender, EventArgs e)
        {
            cb_HangHoa();
            txtMaCTPN.Text = frmChiTietPhieuNhap.MaCTPN;
            txtSoKhoi.Value = frmChiTietPhieuNhap.SoKhoi;
            txtSoLuong.Value = frmChiTietPhieuNhap.SoLuong;
            txtSoXe.Text = frmChiTietPhieuNhap.SoXe;
            cbHangHoa.Text = frmChiTietPhieuNhap.MaHH;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            sql = "sp_suaCTPN '" + txtMaCTPN.Text + "','" + frmPhieuNhap.MaPN + "','" + cbHangHoa.SelectedValue.ToString() + "','" + txtSoXe.Text + "','" + txtSoKhoi.Value + "','" + txtSoLuong.Value + "'";
            cls.Them_sua_xoa(sql);
            (System.Windows.Forms.Application.OpenForms["frmChiTietPhieuNhap"] as frmChiTietPhieuNhap).taiDuLieu();
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
