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
    public partial class frmSuaHH : Form
    {
        public frmSuaHH()
        {
            InitializeComponent();
        }
        public string sql = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void cb_LoaiHang()
        {
            sql = "SELECT MaLoai,TenLoai FROM LOAI_HANGHOA";
            cbLoaiHang.DataSource = cls.getData(sql);
            cbLoaiHang.DisplayMember = "TenLoai";
            cbLoaiHang.ValueMember = "MaLoai";
        }

        public void cb_KhachHang()
        {
            sql = "SELECT MaKH,TenKH FROM KHACH_HANG";
            cbKhachHang.DataSource = cls.getData(sql);
            cbKhachHang.DisplayMember = "TenKH";
            cbKhachHang.ValueMember = "MaKH";
        }

        public void cb_DVT()
        {
            sql = "SELECT MaDVT,TenDVT FROM DON_VITINH";
            cbDVT.DataSource = cls.getData(sql);
            cbDVT.DisplayMember = "TenDVT";
            cbDVT.ValueMember = "MaDVT";
        }

        private void frmSuaHH_Load(object sender, EventArgs e)
        {
            cb_DVT();
            cb_LoaiHang();
            cb_KhachHang();
            txtMaHH.Text = FrmDMhanghoa.MaHH;
            txtTenHH.Text = FrmDMhanghoa.TenHH;
            cbLoaiHang.Text = FrmDMhanghoa.MaLoai;
            cbDVT.Text = FrmDMhanghoa.MaDVT;
            cbKhachHang.Text = FrmDMhanghoa.MaKH;
            dtpBatDau.Text = FrmDMhanghoa.BatDauLuuTru;
            dtpKetThuc.Text = FrmDMhanghoa.KetThucLuuTru;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            sql = "sp_suaHH '" + txtMaHH.Text + "',N'" + txtTenHH.Text + "','" + cbLoaiHang.SelectedValue.ToString() + "','" + cbDVT.SelectedValue.ToString() + "','" + cbKhachHang.SelectedValue.ToString() + "','" + dtpBatDau.Value.ToString("yyyy/MM/dd") + "','" + dtpKetThuc.Value.ToString("yyyy/MM/dd") + "'";
            cls.Them_sua_xoa(sql);
            (System.Windows.Forms.Application.OpenForms["FrmDMhanghoa"] as FrmDMhanghoa).taiDuLieu();
            this.Close();
        }
    }
}
