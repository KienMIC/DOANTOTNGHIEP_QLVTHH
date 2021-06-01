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
    public partial class frmSuaCTPX : Form
    {
        public frmSuaCTPX()
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

        private void btnLuu_Click(object sender, EventArgs e)
        {

            sql = "sp_suaCTPX '" + txtMaCTPX.Text + "','" + frmPhieuXuat.MaPX + "','" + cbHangHoa.SelectedValue.ToString() + "','" + txtSoXe.Text + "','" + txtSoKhoi.Value + "','" + txtSoLuong.Value + "'";
            cls.Them_sua_xoa(sql);
            (System.Windows.Forms.Application.OpenForms["frmChiTietPhieuXuat"] as frmChiTietPhieuXuat).taiDuLieu();
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSuaCTPX_Load(object sender, EventArgs e)
        {
            cb_HangHoa();
            txtMaCTPX.Text = frmChiTietPhieuXuat.MaCTPX;
            txtSoKhoi.Value = frmChiTietPhieuXuat.SoKhoi;
            txtSoLuong.Value = frmChiTietPhieuXuat.SoLuong;
            txtSoXe.Text = frmChiTietPhieuXuat.SoXe;
            cbHangHoa.Text = frmChiTietPhieuXuat.MaHH;
        }
    }
}
