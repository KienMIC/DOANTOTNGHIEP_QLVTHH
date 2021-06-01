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

        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            Quanlydanhmuc.FrmDMnhanvien f1 = (Quanlydanhmuc.FrmDMnhanvien)Application.OpenForms["FrmDMnhanvien"];
            if (f1 == null)
            {
                f1 = new Quanlydanhmuc.FrmDMnhanvien();
                tabControl1.TabPages.Add(f1);
            }
            else
            {
                tabControl1.TabPages[f1].Select();
            }
        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            FrmDMkhachhang f1 = (FrmDMkhachhang)Application.OpenForms["FrmDMkhachhang"];
            if (f1 == null)
            {
                f1 = new FrmDMkhachhang();
                tabControl1.TabPages.Add(f1);
            }
            else
            {
                tabControl1.TabPages[f1].Select();
            }
        }

        private void ribbonButton7_Click(object sender, EventArgs e)
        {
            FrmDMhanghoa f1 = (FrmDMhanghoa)Application.OpenForms["FrmDMhanghoa"];
            if (f1 == null)
            {
                f1 = new FrmDMhanghoa();
                tabControl1.TabPages.Add(f1);
            }
            else
            {
                tabControl1.TabPages[f1].Select();
            }
        }

        private void ribbonButton9_Click(object sender, EventArgs e)
        {
            FrmDMdonvitinh f1 = (FrmDMdonvitinh)Application.OpenForms["FrmDMdonvitinh"];
            if (f1 == null)
            {
                f1 = new FrmDMdonvitinh();
                tabControl1.TabPages.Add(f1);
            }
            else
            {
                tabControl1.TabPages[f1].Select();
            }
        }

        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            FrmDMloaihanghoa f1 = (FrmDMloaihanghoa)Application.OpenForms["FrmDMloaihanghoa"];
            if (f1 == null)
            {
                f1 = new FrmDMloaihanghoa();
                tabControl1.TabPages.Add(f1);
            }
            else
            {
                tabControl1.TabPages[f1].Select();
            }
        }

        private void ribbonButton13_Click(object sender, EventArgs e)
        {
            Quanlyhangnhap.frmPhieuNhap f1 = (Quanlyhangnhap.frmPhieuNhap)Application.OpenForms["frmPhieuNhap"];
            if (f1 == null)
            {
                f1 = new Quanlyhangnhap.frmPhieuNhap();
                tabControl1.TabPages.Add(f1);
            }
            else
            {
                tabControl1.TabPages[f1].Select();
            }
        }


        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            FrmDangnhap f1 = (FrmDangnhap)Application.OpenForms["FrmDangnhap"];
            if (f1 == null)
            {
                f1 = new FrmDangnhap();
                tabControl1.TabPages.Add(f1);
            }
            else
            {
                tabControl1.TabPages[f1].Select();
            }
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            FrmQuanlytaikhoan f1 = (FrmQuanlytaikhoan)Application.OpenForms["FrmQuanlytaikhoan"];
            if (f1 == null)
            {
                f1 = new FrmQuanlytaikhoan();
                tabControl1.TabPages.Add(f1);
            }
            else
            {
                tabControl1.TabPages[f1].Select();
            }
        }

        private void ribbonButton21_Click(object sender, EventArgs e)
        {
            Quanlyhangxuat.frmPhieuXuat f1 = (Quanlyhangxuat.frmPhieuXuat)Application.OpenForms["frmPhieuXuat"];
            if (f1 == null)
            {
                f1 = new Quanlyhangxuat.frmPhieuXuat();
                tabControl1.TabPages.Add(f1);
            }
            else
            {
                tabControl1.TabPages[f1].Select();
            }
        }

        private void ribbonButton3_Click(object sender, EventArgs e)
        {
            FrmSaoluudulieu f1 = (FrmSaoluudulieu)Application.OpenForms["FrmSaoluudulieu"];
            if (f1 == null)
            {
                f1 = new FrmSaoluudulieu();
                tabControl1.TabPages.Add(f1);
            }
            else
            {
                tabControl1.TabPages[f1].Select();
            }
        }

        private void ribbonButton10_Click(object sender, EventArgs e)
        {

            Quanlyvitrihanghoa.frmVitri f1 = (Quanlyvitrihanghoa.frmVitri)Application.OpenForms["frmVitri"];
            if (f1 == null)
            {
                f1 = new Quanlyvitrihanghoa.frmVitri();
                tabControl1.TabPages.Add(f1);
            }
            else
            {
                tabControl1.TabPages[f1].Select();
            }
        }

        private void ribbonButton15_Click(object sender, EventArgs e)
        {
            Baocao.Baocaohanghoa.frmBaoCaoThongTinHH f1 = (Baocao.Baocaohanghoa.frmBaoCaoThongTinHH)Application.OpenForms["frmBaoCaoThongTinHH"];
            if (f1 == null)
            {
                f1 = new Baocao.Baocaohanghoa.frmBaoCaoThongTinHH();
                tabControl1.TabPages.Add(f1);
            }
            else
            {
                tabControl1.TabPages[f1].Select();
            }
        }

        private void ribbonButton16_Click(object sender, EventArgs e)
        {
            Baocao.Baocaohanghoa.FrmBaocaohangnhap f1 = (Baocao.Baocaohanghoa.FrmBaocaohangnhap)Application.OpenForms["FrmBaocaohangnhap"];
            if (f1 == null)
            {
                f1 = new Baocao.Baocaohanghoa.FrmBaocaohangnhap();
                tabControl1.TabPages.Add(f1);
            }
            else
            {
                tabControl1.TabPages[f1].Select();
            }
        }

        private void ribbonButton17_Click(object sender, EventArgs e)
        {
            Baocao.Baocaohanghoa.FrmBaocaohangxuat f1 = (Baocao.Baocaohanghoa.FrmBaocaohangxuat)Application.OpenForms["FrmBaocaohangxuat"];
            if (f1 == null)
            {
                f1 = new Baocao.Baocaohanghoa.FrmBaocaohangxuat();
                tabControl1.TabPages.Add(f1);
            }
            else
            {
                tabControl1.TabPages[f1].Select();
            }
        }

        private void ribbonButton19_Click(object sender, EventArgs e)
        {
            Baocao.Baocaothongkevitri.FrmThongketrangthaivitri f1 = (Baocao.Baocaothongkevitri.FrmThongketrangthaivitri)Application.OpenForms["FrmThongketrangthaivitri"];
            if (f1 == null)
            {
                f1 = new Baocao.Baocaothongkevitri.FrmThongketrangthaivitri();
                tabControl1.TabPages.Add(f1);
            }
            else
            {
                tabControl1.TabPages[f1].Select();
            }
        }

        private void ribbonButton20_Click(object sender, EventArgs e)
        {
            Baocao.Baocaothongkevitri.FrmThongkehanghoataicacvitri f1 = (Baocao.Baocaothongkevitri.FrmThongkehanghoataicacvitri)Application.OpenForms["FrmThongkehanghoataicacvitri"];
            if (f1 == null)
            {
                f1 = new Baocao.Baocaothongkevitri.FrmThongkehanghoataicacvitri();
                tabControl1.TabPages.Add(f1);
            }
            else
            {
                tabControl1.TabPages[f1].Select();
            }
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangnhap f1 = new FrmDangnhap();
            f1.ShowDialog();
            this.Close();
        }

        private void rbLichSuViTri_Click(object sender, EventArgs e)
        {

            Quanlyvitrihanghoa.frmLichSuViTri f1 = (Quanlyvitrihanghoa.frmLichSuViTri)Application.OpenForms["frmLichSuViTri"];
            if (f1 == null)
            {
                f1 = new Quanlyvitrihanghoa.frmLichSuViTri();
                tabControl1.TabPages.Add(f1);
            }
            else
            {
                tabControl1.TabPages[f1].Select();
            }
        }
    }
}
