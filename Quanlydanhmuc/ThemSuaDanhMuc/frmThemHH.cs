using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.Quanlydanhmuc.ThemSuaDanhMuc
{
    public partial class frmThemHH : Form
    {
        public frmThemHH()
        {
            InitializeComponent();
        }
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();
        public string sql = "";
        public string MaHH = "";
        public string TenHH = "";
        public string MaLoai = "";
        public string MaDVT = "";
        public string MaKH = "";
        public string BatDauLuuTru = "";
        public string KetThucLuuTru = "";
        public string TonKho = "0";
        public string TrangThai = "Chưa lưu kho";

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



        private void btnLuu_Click(object sender, EventArgs e)
        {
            MaHH = txtMaHH.Text;
            TenHH = txtTenHH.Text;
            MaLoai = cbLoaiHang.SelectedValue.ToString();
            MaDVT = cbDVT.SelectedValue.ToString();
            MaKH = cbKhachHang.SelectedValue.ToString();
            BatDauLuuTru = dtpBatDau.Value.ToString("yyyy/MM/dd");
            KetThucLuuTru = dtpKetThuc.Value.ToString("yyyy/MM/dd");
            sql = "sp_themHH '" + MaHH + "',N'" + TenHH + "','" + MaLoai + "','" + MaDVT + "','" + MaKH + "','" + BatDauLuuTru + "','" + KetThucLuuTru + "','" + TonKho + "',N'" + TrangThai + "'";
            cls.Them_sua_xoa(sql);
            (System.Windows.Forms.Application.OpenForms["FrmDMhanghoa"] as FrmDMhanghoa).taiDuLieu();
            this.Close();
        }

        private void frmThemHH_Load(object sender, EventArgs e)
        {
            cb_LoaiHang();
            cb_KhachHang();
            cb_DVT();
        }
    }
}
