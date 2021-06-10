
namespace DoAn1
{
    partial class Frmmainn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmmainn));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.rbtnQuanLyTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.rbtnSaoLuu = new DevExpress.XtraBars.BarButtonItem();
            this.rbtnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.rbtnDMNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.rbtnDMKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.rbtnDMHangHoa = new DevExpress.XtraBars.BarButtonItem();
            this.rbtnDMLoaiHangHoa = new DevExpress.XtraBars.BarButtonItem();
            this.rbtnDMDonViTinh = new DevExpress.XtraBars.BarButtonItem();
            this.rbtnToaDo = new DevExpress.XtraBars.BarButtonItem();
            this.rbLichSuViTri = new DevExpress.XtraBars.BarButtonItem();
            this.rbtnLapPN = new DevExpress.XtraBars.BarButtonItem();
            this.rbtnLapPX = new DevExpress.XtraBars.BarButtonItem();
            this.rbtnBCHangTon = new DevExpress.XtraBars.BarButtonItem();
            this.rbtnBCHangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.rbtnBCHangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.rbtnTKHH = new DevExpress.XtraBars.BarButtonItem();
            this.rbtnVeChungToi = new DevExpress.XtraBars.BarButtonItem();
            this.bH_TaiKhoan = new DevExpress.XtraBars.BarHeaderItem();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpHangNhapXuat = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup13 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.tcMain = new MdiTabControl.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.rbtnQuanLyTaiKhoan,
            this.rbtnSaoLuu,
            this.rbtnDangXuat,
            this.rbtnDMNhanVien,
            this.rbtnDMKhachHang,
            this.rbtnDMHangHoa,
            this.rbtnDMLoaiHangHoa,
            this.rbtnDMDonViTinh,
            this.rbtnToaDo,
            this.rbLichSuViTri,
            this.rbtnLapPN,
            this.rbtnLapPX,
            this.rbtnBCHangTon,
            this.rbtnBCHangNhap,
            this.rbtnBCHangXuat,
            this.rbtnTKHH,
            this.rbtnVeChungToi,
            this.bH_TaiKhoan});
            this.ribbon.ItemsVertAlign = DevExpress.Utils.VertAlignment.Bottom;
            this.ribbon.LargeImages = this.imageCollection1;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 19;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 0;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.rpHangNhapXuat,
            this.rpBaoCao,
            this.ribbonPage6});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(967, 135);
            this.ribbon.StatusBar = this.ribbonStatusBar1;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // rbtnQuanLyTaiKhoan
            // 
            this.rbtnQuanLyTaiKhoan.Caption = "Quản lý tài khoản";
            this.rbtnQuanLyTaiKhoan.Id = 1;
            this.rbtnQuanLyTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnQuanLyTaiKhoan.ImageOptions.Image")));
            this.rbtnQuanLyTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnQuanLyTaiKhoan.ImageOptions.LargeImage")));
            this.rbtnQuanLyTaiKhoan.LargeWidth = 100;
            this.rbtnQuanLyTaiKhoan.Name = "rbtnQuanLyTaiKhoan";
            this.rbtnQuanLyTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnQuanLyTaiKhoan_ItemClick);
            // 
            // rbtnSaoLuu
            // 
            this.rbtnSaoLuu.Caption = "Sao Lưu/Khôi phục CSDL";
            this.rbtnSaoLuu.Id = 2;
            this.rbtnSaoLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnSaoLuu.ImageOptions.Image")));
            this.rbtnSaoLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnSaoLuu.ImageOptions.LargeImage")));
            this.rbtnSaoLuu.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.rbtnSaoLuu.ImageOptions.SvgImageSize = new System.Drawing.Size(128, 128);
            this.rbtnSaoLuu.LargeWidth = 100;
            this.rbtnSaoLuu.Name = "rbtnSaoLuu";
            this.rbtnSaoLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnSaoLuu_ItemClick);
            // 
            // rbtnDangXuat
            // 
            this.rbtnDangXuat.Caption = "Đăng xuất";
            this.rbtnDangXuat.Id = 3;
            this.rbtnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnDangXuat.ImageOptions.Image")));
            this.rbtnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnDangXuat.ImageOptions.LargeImage")));
            this.rbtnDangXuat.LargeWidth = 100;
            this.rbtnDangXuat.Name = "rbtnDangXuat";
            this.rbtnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnDangXuat_ItemClick);
            // 
            // rbtnDMNhanVien
            // 
            this.rbtnDMNhanVien.Caption = "DM Nhân viên";
            this.rbtnDMNhanVien.Id = 4;
            this.rbtnDMNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnDMNhanVien.ImageOptions.Image")));
            this.rbtnDMNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnDMNhanVien.ImageOptions.LargeImage")));
            this.rbtnDMNhanVien.LargeWidth = 100;
            this.rbtnDMNhanVien.Name = "rbtnDMNhanVien";
            this.rbtnDMNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnDMNhanVien_ItemClick);
            // 
            // rbtnDMKhachHang
            // 
            this.rbtnDMKhachHang.Caption = "DM Khách hàng";
            this.rbtnDMKhachHang.Id = 5;
            this.rbtnDMKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnDMKhachHang.ImageOptions.Image")));
            this.rbtnDMKhachHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnDMKhachHang.ImageOptions.LargeImage")));
            this.rbtnDMKhachHang.LargeWidth = 100;
            this.rbtnDMKhachHang.Name = "rbtnDMKhachHang";
            this.rbtnDMKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnDMKhachHang_ItemClick);
            // 
            // rbtnDMHangHoa
            // 
            this.rbtnDMHangHoa.Caption = "DM Hàng hóa";
            this.rbtnDMHangHoa.Id = 6;
            this.rbtnDMHangHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnDMHangHoa.ImageOptions.Image")));
            this.rbtnDMHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnDMHangHoa.ImageOptions.LargeImage")));
            this.rbtnDMHangHoa.LargeWidth = 100;
            this.rbtnDMHangHoa.Name = "rbtnDMHangHoa";
            this.rbtnDMHangHoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnDMHangHoa_ItemClick);
            // 
            // rbtnDMLoaiHangHoa
            // 
            this.rbtnDMLoaiHangHoa.Caption = "DM Loại hàng hóa";
            this.rbtnDMLoaiHangHoa.Id = 7;
            this.rbtnDMLoaiHangHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnDMLoaiHangHoa.ImageOptions.Image")));
            this.rbtnDMLoaiHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnDMLoaiHangHoa.ImageOptions.LargeImage")));
            this.rbtnDMLoaiHangHoa.LargeWidth = 100;
            this.rbtnDMLoaiHangHoa.Name = "rbtnDMLoaiHangHoa";
            this.rbtnDMLoaiHangHoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnDMLoaiHangHoa_ItemClick);
            // 
            // rbtnDMDonViTinh
            // 
            this.rbtnDMDonViTinh.Caption = "DM Đơn vị tính";
            this.rbtnDMDonViTinh.Id = 8;
            this.rbtnDMDonViTinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnDMDonViTinh.ImageOptions.Image")));
            this.rbtnDMDonViTinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnDMDonViTinh.ImageOptions.LargeImage")));
            this.rbtnDMDonViTinh.LargeWidth = 100;
            this.rbtnDMDonViTinh.Name = "rbtnDMDonViTinh";
            this.rbtnDMDonViTinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnDMDonViTinh_ItemClick);
            // 
            // rbtnToaDo
            // 
            this.rbtnToaDo.Caption = "Tọa độ vị trí hàng hóa";
            this.rbtnToaDo.Id = 9;
            this.rbtnToaDo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnToaDo.ImageOptions.Image")));
            this.rbtnToaDo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnToaDo.ImageOptions.LargeImage")));
            this.rbtnToaDo.LargeWidth = 100;
            this.rbtnToaDo.Name = "rbtnToaDo";
            this.rbtnToaDo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnToaDo_ItemClick);
            // 
            // rbLichSuViTri
            // 
            this.rbLichSuViTri.Caption = "Tra cứu hành động";
            this.rbLichSuViTri.Id = 10;
            this.rbLichSuViTri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbLichSuViTri.ImageOptions.Image")));
            this.rbLichSuViTri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbLichSuViTri.ImageOptions.LargeImage")));
            this.rbLichSuViTri.LargeWidth = 100;
            this.rbLichSuViTri.Name = "rbLichSuViTri";
            this.rbLichSuViTri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbLichSuViTri_ItemClick);
            // 
            // rbtnLapPN
            // 
            this.rbtnLapPN.Caption = "Lập phiếu nhập";
            this.rbtnLapPN.Id = 11;
            this.rbtnLapPN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnLapPN.ImageOptions.Image")));
            this.rbtnLapPN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnLapPN.ImageOptions.LargeImage")));
            this.rbtnLapPN.LargeWidth = 100;
            this.rbtnLapPN.Name = "rbtnLapPN";
            this.rbtnLapPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnLapPN_ItemClick);
            // 
            // rbtnLapPX
            // 
            this.rbtnLapPX.Caption = "Lập phiếu xuất";
            this.rbtnLapPX.Id = 12;
            this.rbtnLapPX.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnLapPX.ImageOptions.Image")));
            this.rbtnLapPX.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnLapPX.ImageOptions.LargeImage")));
            this.rbtnLapPX.LargeWidth = 100;
            this.rbtnLapPX.Name = "rbtnLapPX";
            this.rbtnLapPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnLapPX_ItemClick);
            // 
            // rbtnBCHangTon
            // 
            this.rbtnBCHangTon.Caption = "Thông tin hàng hóa trong kho";
            this.rbtnBCHangTon.Id = 13;
            this.rbtnBCHangTon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnBCHangTon.ImageOptions.Image")));
            this.rbtnBCHangTon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnBCHangTon.ImageOptions.LargeImage")));
            this.rbtnBCHangTon.LargeWidth = 100;
            this.rbtnBCHangTon.Name = "rbtnBCHangTon";
            this.rbtnBCHangTon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnBCHangTon_ItemClick);
            // 
            // rbtnBCHangNhap
            // 
            this.rbtnBCHangNhap.Caption = "Hàng nhập";
            this.rbtnBCHangNhap.Id = 14;
            this.rbtnBCHangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnBCHangNhap.ImageOptions.Image")));
            this.rbtnBCHangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnBCHangNhap.ImageOptions.LargeImage")));
            this.rbtnBCHangNhap.LargeWidth = 100;
            this.rbtnBCHangNhap.Name = "rbtnBCHangNhap";
            this.rbtnBCHangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnBCHangNhap_ItemClick);
            // 
            // rbtnBCHangXuat
            // 
            this.rbtnBCHangXuat.Caption = "Hàng xuất";
            this.rbtnBCHangXuat.Id = 15;
            this.rbtnBCHangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnBCHangXuat.ImageOptions.Image")));
            this.rbtnBCHangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnBCHangXuat.ImageOptions.LargeImage")));
            this.rbtnBCHangXuat.LargeWidth = 100;
            this.rbtnBCHangXuat.Name = "rbtnBCHangXuat";
            this.rbtnBCHangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnBCHangXuat_ItemClick);
            // 
            // rbtnTKHH
            // 
            this.rbtnTKHH.Caption = "Thống kê hàng hóa tại các vị trí";
            this.rbtnTKHH.Id = 16;
            this.rbtnTKHH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnTKHH.ImageOptions.Image")));
            this.rbtnTKHH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnTKHH.ImageOptions.LargeImage")));
            this.rbtnTKHH.LargeWidth = 100;
            this.rbtnTKHH.Name = "rbtnTKHH";
            this.rbtnTKHH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnTKHH_ItemClick);
            // 
            // rbtnVeChungToi
            // 
            this.rbtnVeChungToi.Caption = "Về chúng tôi";
            this.rbtnVeChungToi.Id = 17;
            this.rbtnVeChungToi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnVeChungToi.ImageOptions.Image")));
            this.rbtnVeChungToi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnVeChungToi.ImageOptions.LargeImage")));
            this.rbtnVeChungToi.LargeWidth = 100;
            this.rbtnVeChungToi.Name = "rbtnVeChungToi";
            this.rbtnVeChungToi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnVeChungToi_ItemClick);
            // 
            // bH_TaiKhoan
            // 
            this.bH_TaiKhoan.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.bH_TaiKhoan.Appearance.Options.UseFont = true;
            this.bH_TaiKhoan.Caption = "Tài khoản: ";
            this.bH_TaiKhoan.Id = 18;
            this.bH_TaiKhoan.Name = "bH_TaiKhoan";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "backup-restore.png");
            this.imageCollection1.Images.SetKeyName(1, "dmhanghoa.png");
            this.imageCollection1.Images.SetKeyName(2, "dmloaihanghoa.png");
            this.imageCollection1.Images.SetKeyName(3, "dmnhanvienvakhachhang.png");
            this.imageCollection1.Images.SetKeyName(4, "donvitinh.png");
            this.imageCollection1.Images.SetKeyName(5, "lapphieunhap.png");
            this.imageCollection1.Images.SetKeyName(6, "lapphieuxuat.png");
            this.imageCollection1.Images.SetKeyName(7, "login.png");
            this.imageCollection1.Images.SetKeyName(8, "logout.png");
            this.imageCollection1.Images.SetKeyName(9, "nhap.png");
            this.imageCollection1.Images.SetKeyName(10, "quanlytaikhoan.png");
            this.imageCollection1.Images.SetKeyName(11, "thongkehanghoataicacvitri.png");
            this.imageCollection1.Images.SetKeyName(12, "thongtinhanghoatrongkho.png");
            this.imageCollection1.Images.SetKeyName(13, "toadovitrihanghoa.png");
            this.imageCollection1.Images.SetKeyName(14, "tracuulichsuvitri.png");
            this.imageCollection1.Images.SetKeyName(15, "vechungtoi.png");
            this.imageCollection1.Images.SetKeyName(16, "xuat.png");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.rbtnQuanLyTaiKhoan);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.rbtnSaoLuu);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.rbtnDangXuat);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Danh mục";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.rbtnDMNhanVien);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.rbtnDMKhachHang);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.rbtnDMHangHoa);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.rbtnDMLoaiHangHoa);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.rbtnDMDonViTinh);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Vị trí";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.rbtnToaDo, true);
            this.ribbonPageGroup9.ItemLinks.Add(this.rbLichSuViTri, true);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // rpHangNhapXuat
            // 
            this.rpHangNhapXuat.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup10});
            this.rpHangNhapXuat.Name = "rpHangNhapXuat";
            this.rpHangNhapXuat.Text = "Hàng nhập/xuất";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.rbtnLapPN, true);
            this.ribbonPageGroup10.ItemLinks.Add(this.rbtnLapPX, true);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // rpBaoCao
            // 
            this.rpBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup11,
            this.ribbonPageGroup12});
            this.rpBaoCao.Name = "rpBaoCao";
            this.rpBaoCao.Text = "Báo cáo";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.rbtnBCHangTon, true);
            this.ribbonPageGroup11.ItemLinks.Add(this.rbtnBCHangNhap, true);
            this.ribbonPageGroup11.ItemLinks.Add(this.rbtnBCHangXuat, true);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.Text = "Báo cáo hàng hóa";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.rbtnTKHH);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            this.ribbonPageGroup12.Text = "Báo cáo thống kê vị trí";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup13});
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "About";
            // 
            // ribbonPageGroup13
            // 
            this.ribbonPageGroup13.ItemLinks.Add(this.rbtnVeChungToi);
            this.ribbonPageGroup13.Name = "ribbonPageGroup13";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.bH_TaiKhoan);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 692);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbon;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(967, 23);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue";
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.tcMain.BackgroundImage = global::DoAn1.Properties.Resources.Warehouse_Background1;
            this.tcMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tcMain.BackHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.tcMain.BackLowColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.tcMain.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.tcMain.BorderColorDisabled = System.Drawing.SystemColors.ActiveCaption;
            this.tcMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tcMain.Location = new System.Drawing.Point(2, 135);
            this.tcMain.MenuRenderer = null;
            this.tcMain.Name = "tcMain";
            this.tcMain.Size = new System.Drawing.Size(963, 579);
            this.tcMain.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.tcMain.TabBackLowColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(194)))), ((int)(((byte)(250)))));
            this.tcMain.TabBackLowColorDisabled = System.Drawing.Color.LightBlue;
            this.tcMain.TabCloseButtonImage = null;
            this.tcMain.TabCloseButtonImageDisabled = null;
            this.tcMain.TabCloseButtonImageHot = null;
            this.tcMain.TabIndex = 3;
            this.tcMain.FocusedChanged += new System.EventHandler(this.tcMain_FocusedChanged);
            this.tcMain.Load += new System.EventHandler(this.tcMain_Load);
            this.tcMain.Enter += new System.EventHandler(this.tcMain_Enter);
            // 
            // Frmmainn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 715);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = global::DoAn1.Properties.Resources.iconfinder_warehouse_3992927_112594;
            this.KeyPreview = true;
            this.Name = "Frmmainn";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "DEMO | QUẢN LÝ VỊ TRÍ HÀNG HÓA | ĐỒ ÁN TỐT NGHIỆP | © 2021 KKH TEAM";
            this.Load += new System.EventHandler(this.Frmmainn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem rbtnQuanLyTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem rbtnSaoLuu;
        private DevExpress.XtraBars.BarButtonItem rbtnDangXuat;
        private DevExpress.XtraBars.BarButtonItem rbtnDMNhanVien;
        private DevExpress.XtraBars.BarButtonItem rbtnDMKhachHang;
        private DevExpress.XtraBars.BarButtonItem rbtnDMHangHoa;
        private DevExpress.XtraBars.BarButtonItem rbtnDMLoaiHangHoa;
        private DevExpress.XtraBars.BarButtonItem rbtnDMDonViTinh;
        private DevExpress.XtraBars.BarButtonItem rbtnToaDo;
        private DevExpress.XtraBars.BarButtonItem rbLichSuViTri;
        private DevExpress.XtraBars.BarButtonItem rbtnLapPN;
        private DevExpress.XtraBars.BarButtonItem rbtnLapPX;
        private DevExpress.XtraBars.BarButtonItem rbtnBCHangTon;
        private DevExpress.XtraBars.BarButtonItem rbtnBCHangNhap;
        private DevExpress.XtraBars.BarButtonItem rbtnBCHangXuat;
        private DevExpress.XtraBars.BarButtonItem rbtnTKHH;
        private DevExpress.XtraBars.BarButtonItem rbtnVeChungToi;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpHangNhapXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup13;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private MdiTabControl.TabControl tcMain;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarHeaderItem bH_TaiKhoan;
    }
}