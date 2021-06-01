using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.RibbonHelpers;

namespace DoAn1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public string MaNhom = FrmDangnhap.MaNhom;
        public Form f1;

        private void Trangchu_Load(object sender, EventArgs e)
        {
            if(MaNhom == "nv")
            {
                rbtnQuanLyTaiKhoan.Visible = false;
                rbBaoCao.Visible = false;
            }
            else if(MaNhom == "ql")
            {
                rbtnQuanLyTaiKhoan.Visible = false;
                rbHangNhap.Visible = false;
                rbHangXuat.Visible = false;
            }
        }

        private void rbtnDMNhanVien_Click(object sender, EventArgs e)
        { 
            f1 = (Quanlydanhmuc.FrmDMnhanvien)Application.OpenForms["FrmDMnhanvien"];
            if (f1 == null)
            {
                f1 = new Quanlydanhmuc.FrmDMnhanvien();
                tcMain.TabPages.Add(f1);
            }
            else
            {
                tcMain.TabPages[f1].Select();
            }
        }

        private void rbtnDMKhachHang_Click(object sender, EventArgs e)
        {
            f1 = (FrmDMkhachhang)Application.OpenForms["FrmDMkhachhang"];
            if (f1 == null)
            {
                f1 = new FrmDMkhachhang();
                tcMain.TabPages.Add(f1);
            }
            else
            {
                tcMain.TabPages[f1].Select();
            }
        }

        private void rbtnDMHangHoa_Click(object sender, EventArgs e)
        {
            f1 = (FrmDMhanghoa)Application.OpenForms["FrmDMhanghoa"];
            if (f1 == null)
            {
                f1 = new FrmDMhanghoa();
                tcMain.TabPages.Add(f1);
            }
            else
            {
                tcMain.TabPages[f1].Select();
            }
        }

        private void rbtnDMDonViTinh_Click(object sender, EventArgs e)
        {
            f1 = (FrmDMdonvitinh)Application.OpenForms["FrmDMdonvitinh"];
            if (f1 == null)
            {
                f1 = new FrmDMdonvitinh();
                tcMain.TabPages.Add(f1);
            }
            else
            {
                tcMain.TabPages[f1].Select();
            }
        }

        private void rbtnDMLoaiHangHoa_Click(object sender, EventArgs e)
        {
            f1 = (FrmDMloaihanghoa)Application.OpenForms["FrmDMloaihanghoa"];
            if (f1 == null)
            {
                f1 = new FrmDMloaihanghoa();
                tcMain.TabPages.Add(f1);
            }
            else
            {
                tcMain.TabPages[f1].Select();
            }
        }

        private void rbtnPhieuNhap_Click(object sender, EventArgs e)
        {
            f1 = (Quanlyhangnhap.frmPhieuNhap)Application.OpenForms["frmPhieuNhap"];
            if (f1 == null)
            {
                f1 = new Quanlyhangnhap.frmPhieuNhap();
                tcMain.TabPages.Add(f1);
            }
            else
            {
                tcMain.TabPages[f1].Select();
            }
        }


        private void rbtnDangNhap_Click(object sender, EventArgs e)
        {
            f1 = (FrmDangnhap)Application.OpenForms["FrmDangnhap"];
            if (f1 == null)
            {
                f1 = new FrmDangnhap();
                tcMain.TabPages.Add(f1);
            }
            else
            {
                tcMain.TabPages[f1].Select();
            }
        }

        private void rbtnQuanlytaikhoan_Click(object sender, EventArgs e)
        {
            f1 = (FrmQuanlytaikhoan)Application.OpenForms["FrmQuanlytaikhoan"];
            if (f1 == null)
            {
                f1 = new FrmQuanlytaikhoan();
                tcMain.TabPages.Add(f1);
            }
            else
            {
                tcMain.TabPages[f1].Select();
            }
        }

        private void rbtnPhieuXuat_Click(object sender, EventArgs e)
        {
            f1 = (Quanlyhangxuat.frmPhieuXuat)Application.OpenForms["frmPhieuXuat"];
            if (f1 == null)
            {
                f1 = new Quanlyhangxuat.frmPhieuXuat();
                tcMain.TabPages.Add(f1);
            }
            else
            {
                tcMain.TabPages[f1].Select();
            }
        }

        private void rbtnSaoLuuDuLieu_Click(object sender, EventArgs e)
        {
            f1 = (FrmSaoluudulieu)Application.OpenForms["FrmSaoluudulieu"];
            if (f1 == null)
            {
                f1 = new FrmSaoluudulieu();
                tcMain.TabPages.Add(f1);
            }
            else
            {
                tcMain.TabPages[f1].Select();
            }
        }

        private void rbtnViTri_Click(object sender, EventArgs e)
        {

            f1 = (Quanlyvitrihanghoa.frmVitri)Application.OpenForms["frmVitri"];
            if (f1 == null)
            {
                f1 = new Quanlyvitrihanghoa.frmVitri();
                tcMain.TabPages.Add(f1);
            }
            else
            {
                tcMain.TabPages[f1].Select();
            }
        }

        private void rbtnBCTTHangHoa_Click(object sender, EventArgs e)
        {
            f1 = (Baocao.Baocaohanghoa.frmBaoCaoThongTinHH)Application.OpenForms["frmBaoCaoThongTinHH"];
            if (f1 == null)
            {
                f1 = new Baocao.Baocaohanghoa.frmBaoCaoThongTinHH();
                tcMain.TabPages.Add(f1);
            }
            else
            {
                tcMain.TabPages[f1].Select();
            }
        }

        private void rbtnBaoCaoHangNhap_Click(object sender, EventArgs e)
        {
            f1 = (Baocao.Baocaohanghoa.FrmBaocaohangnhap)Application.OpenForms["FrmBaocaohangnhap"];
            if (f1 == null)
            {
                f1 = new Baocao.Baocaohanghoa.FrmBaocaohangnhap();
                tcMain.TabPages.Add(f1);
            }
            else
            {
                tcMain.TabPages[f1].Select();
            }
        }

        private void rbtnBaoCaoHangXuat_Click(object sender, EventArgs e)
        {
            f1 = (Baocao.Baocaohanghoa.FrmBaocaohangxuat)Application.OpenForms["FrmBaocaohangxuat"];
            if (f1 == null)
            {
                f1 = new Baocao.Baocaohanghoa.FrmBaocaohangxuat();
                tcMain.TabPages.Add(f1);
            }
            else
            {
                tcMain.TabPages[f1].Select();
            }
        }


        private void rbtnHH_VT_Click(object sender, EventArgs e)
        {
            f1 = (Baocao.Baocaothongkevitri.FrmThongkehanghoataicacvitri)Application.OpenForms["FrmThongkehanghoataicacvitri"];
            if (f1 == null)
            {
                f1 = new Baocao.Baocaothongkevitri.FrmThongkehanghoataicacvitri();
                tcMain.TabPages.Add(f1);
            }
            else
            {
                tcMain.TabPages[f1].Select();
            }
        }
        
        private void rbtnDangXuat_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "FrmDangnhap")
                    Application.OpenForms[i].Close();
            }
            this.Hide();
            f1 = new FrmDangnhap();
            f1.ShowDialog();
            
        }

        private void rbLichSuViTri_Click(object sender, EventArgs e)
        {

            f1 = (Quanlyvitrihanghoa.frmLichSuViTri)Application.OpenForms["frmLichSuViTri"];
            if (f1 == null)
            {
                f1 = new Quanlyvitrihanghoa.frmLichSuViTri();
                tcMain.TabPages.Add(f1);
            }
            else
            {
                tcMain.TabPages[f1].Select();
            }
        }

        private void rbAbout_ActiveChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnVeChungToi_Click(object sender, EventArgs e)
        {
            f1 = (frmAbout)Application.OpenForms["frmAbout"];
            if (f1 == null)
            {
                f1 = new frmAbout();
                tcMain.TabPages.Add(f1);
            }
            else
            {
                tcMain.TabPages[f1].Select();
            }
        }
    }
}
