using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class Frmmainn : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Frmmainn()
        {
            InitializeComponent();
        }
        public string MaNhom = Quanlyhethong.XtraFormDangNhap.MaNhom;
        public string username = Quanlyhethong.XtraFormDangNhap.username;
        public string TenNhom = "";
        public Form f1;
        private void rbtnQuanLyTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
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

        private void Frmmainn_Load(object sender, EventArgs e)
        {
            if (MaNhom == "nv")
            {
                rbtnQuanLyTaiKhoan.Enabled = false;
                rpBaoCao.Visible = false;
                TenNhom = "Nhân viên";
            }
            else if (MaNhom == "ql")
            {
                rbtnQuanLyTaiKhoan.Enabled = false;
                rpHangNhapXuat.Visible = false;
                TenNhom = "Quản lý";
            }
            else if (MaNhom == "qtv")
            {
                TenNhom = "Quản trị viên";
            }
            bH_TaiKhoan.Caption = "Tài khoản: " + username + " -  Nhóm tài khoản: " + TenNhom;
        }

        private void rbtnSaoLuu_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "XtraFormDangNhap")
                    Application.OpenForms[i].Close();
            }
            this.Hide();
            f1 = new Quanlyhethong.XtraFormDangNhap();
            f1.ShowDialog();
        }

        private void rbtnDMNhanVien_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnDMKhachHang_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnDMHangHoa_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnDMLoaiHangHoa_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnDMDonViTinh_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnToaDo_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbLichSuViTri_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnLapPN_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnLapPX_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnBCHangTon_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnBCHangNhap_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnBCHangXuat_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnTKHH_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnVeChungToi_ItemClick(object sender, ItemClickEventArgs e)
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

        private void tcMain_Load(object sender, EventArgs e)
        {
            /*f1 = new frmAbout();
            tcMain.TabPages.Add(f1);
            if (f1 == null)
            {
                f1 = new frmAbout();
                tcMain.TabPages.Add(f1);
            }
            else
            {
                tcMain.TabPages[f1].Select();
            }
            f1 = (frmAbout)Application.OpenForms["frmAbout"];
            if (f1 == null)
            {
                f1 = new frmAbout();
                tcMain.TabPages.Add(f1);
            }*/
            
        }

        private void tcMain_FocusedChanged(object sender, EventArgs e)
        {
            if (tcMain.TabPages.Count == 0)
            {
                f1 = (frmAbout)Application.OpenForms["frmAbout"];
                if (f1 == null)
                {
                    f1 = new frmAbout();
                    tcMain.TabPages.Add(f1);
                }
                
            }
        }

        private void tcMain_Enter(object sender, EventArgs e)
        {
            f1 = (frmAbout)Application.OpenForms["frmAbout"];
            if (f1 == null)
            {
                f1 = new frmAbout();
                tcMain.TabPages.Add(f1);
            }
        }
    }
}