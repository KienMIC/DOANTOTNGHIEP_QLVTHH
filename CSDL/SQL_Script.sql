CREATE DATABASE QLVTHH
USE QLVTHH

CREATE TABLE NHAN_VIEN(
	MaNV varchar(10) Primary Key not null,
	TenNV nvarchar(100),
	NgaySinh datetime,
	SDT varchar(50),
	GioiTinh nvarchar(5),
	DiaChi nvarchar(100),
)

CREATE TABLE NHOM_TAIKHOAN(
	MaNhom varchar(10) Primary Key not null,
	TenNhom varchar(100),
)

CREATE TABLE TAI_KHOANNV(
	MaTK int Primary Key identity(1,1) not null,
	MaNV varchar(10) Foreign Key(MaNV) References NHAN_VIEN(MaNV),
	NgayLap datetime,
	MaNhom varchar(10) Foreign Key(MaNhom) References NHOM_TAIKHOAN(MaNhom),
	TenTK varchar(100),
	MatKhau varchar(100),
)

CREATE TABLE KHACH_HANG(
	MaKH varchar(10) Primary Key not null,
	TenKH nvarchar(100),
	SDT varchar(50),
	DiaChi nvarchar(100),
)

CREATE TABLE LOAI_HANGHOA(
	MaLoai varchar(10) Primary Key not null,
	TenLoai nvarchar(100),
)

CREATE TABLE DON_VITINH(
	MaDVT varchar(10) Primary Key not null,
	TenDVT nvarchar(100),
)

CREATE TABLE HANG_HOA(
	MaHH varchar(10) Primary Key not null,
	TenHH nvarchar(100),
	SoLuong int,
	MaLoai varchar(10) Foreign Key(MaLoai) References LOAI_HANGHOA(MaLoai),
	MaDVT varchar(10) Foreign Key(MaDVT) References DON_VITINH(MaDVT),
	BatDauLuuTru Datetime,
	KetThucLuuTru Datetime,
	TrangThai nvarchar(100),
	MaKH varchar(10) Foreign Key(MaKH) References KHACH_HANG(MaKH),
)

CREATE TABLE PHIEU_NHAP(
	MaPN varchar(10) Primary Key not null,
	NgayLap datetime,
	MaNV varchar(10) Foreign Key(MaNV) References NHAN_VIEN(MaNV),
)

CREATE TABLE PHIEU_XUAT(
	MaPX varchar(10) Primary Key not null,
	NgayLap datetime,
	MaNV varchar(10) Foreign Key(MaNV) References NHAN_VIEN(MaNV),
)

CREATE TABLE CT_PHIEUNHAP(
	MaCTPN varchar(10) Primary Key not null,
	MaPN varchar(10) Foreign Key(MaPN) References PHIEU_NHAP(MaPN),
	MaHH varchar(10) Foreign Key(MaHH) References HANG_HOA(MaHH),
	SoXe varchar(20),
	SoKhoi int,
	SoLuong int,
)

CREATE TABLE CT_PHIEUXUAT(
	MaCTPX varchar(10) Primary Key not null,
	MaPX varchar(10) Foreign Key(MaPX) References PHIEU_XUAT(MaPX),
	MaHH varchar(10) Foreign Key(MaHH) References HANG_HOA(MaHH),
	SoXe varchar(20),
	SoKhoi int,
	SoLuong int,
)

CREATE TABLE VITRI_HANGHOA(
	MaVT int identity (1,1) Primary Key,
	MaHH varchar(10) Foreign Key(MaHH) References HANG_HOA(MaHH),
	ToaDo varchar(100) UNIQUE,
	TrangThai nvarchar(100),
)

CREATE TABLE COLOR_HANGHOA(
	ID int Primary Key identity(1,1),
	Color varchar(100) UNIQUE,
	MaHH varchar(10) Foreign Key(MaHH) References HANG_HOA(MaHH) UNIQUE,
)
CREATE TABLE BAO_CAO(
	MaBC varchar(10) Primary Key not null,
	TenBC nvarchar(100),
	NgayLap datetime,
	MaNV varchar(10) Foreign Key(MaNV) References NHAN_VIEN(MaNV),
)

CREATE TABLE LICHSU_VITRI(
	ID int identity(1,1) primary key,
	MaHH varchar(10) Foreign Key(MaHH) References HANG_HOA(MaHH),
	MaNV varchar(10) Foreign Key(MaNV) References NHAN_VIEN(MaNV),
	HanhDong nvarchar(100),
	ToaDoBanDau varchar(100),
	ToaDoSauCung varchar(100),
	NgayGio datetime)
----------------------------------------------------------------------

//PROCEDURE_NHAN_VIEN

CREATE PROC sp_themNV(@MaNV varchar(10),@TenNV nvarchar(100),@NgaySinh datetime,@SDT varchar(50),@GioiTinh nvarchar(5),@DiaChi nvarchar(100))
AS 
INSERT INTO NHAN_VIEN(MaNV,TenNV,NgaySinh,SDT,GioiTinh,DiaChi)
VALUES(@MaNV,@TenNV,@NgaySinh,@SDT,@GioiTinh,@DiaChi)

CREATE PROC sp_suaNV(@MaNV varchar(10),@TenNV nvarchar(100),@NgaySinh datetime,@SDT varchar(50),@GioiTinh nvarchar(5),@DiaChi nvarchar(100))
AS 
UPDATE NHAN_VIEN SET TenNV=@TenNV,NgaySinh=@NgaySinh,SDT=@SDT,GioiTinh=@GioiTinh,DiaChi=@DiaChi
WHERE MaNV = @MaNV

CREATE PROC sp_xoaNV(@MaNV varchar(10))
AS 
DELETE FROM NHAN_VIEN
WHERE MaNV = @MaNV

CREATE PROC sp_tkNV(@TK nvarchar(100))
AS 
SELECT * FROM NHAN_VIEN
WHERE MaNV like '%' + @TK + '%' OR TenNV like '%' + @TK + '%' OR DiaChi like '%' + @TK + '%' OR SDT like '%' +@TK + '%' OR GioiTinh like '%' +@TK + '%'

//PROCEDURE_KHACH_HANG
CREATE PROC sp_themKH(@MaKH varchar(10),@TenKH nvarchar(100),@SDT varchar(50),@DiaChi nvarchar(100))
AS 
INSERT INTO KHACH_HANG(MaKH,TenKH,SDT,DiaChi)
VALUES(@MaKH,@TenKH,@SDT,@DiaChi)

CREATE PROC sp_suaKH(@MaKH varchar(10),@TenKH nvarchar(100),@SDT varchar(50),@DiaChi nvarchar(100))
AS 
UPDATE KHACH_HANG SET TenKH=@TenKH,SDT=@SDT,DiaChi=@DiaChi
WHERE MaKH = @MaKH

CREATE PROC sp_xoaKH(@MaKH varchar(10))
AS 
DELETE FROM KHACH_HANG
WHERE MaKH = @MaKH

CREATE PROC sp_tkKH(@TK nvarchar(100))
AS 
SELECT * FROM KHACH_HANG
WHERE MaKH like '%' + @TK + '%' OR TenKH like '%' + @TK + '%' OR DiaChi like '%' + @TK + '%' OR SDT like '%' +@TK + '%' 

//PROCEDURE_DVT

CREATE PROC sp_themDVT(@MaDVT varchar(10),@TenDVT nvarchar(100))
AS 
INSERT INTO DON_VITINH(MaDVT,TenDVT)
VALUES(@MaDVT,@TenDVT)

CREATE PROC sp_suaDVT(@MaDVT varchar(10),@TenDVT nvarchar(100))
AS 
UPDATE DON_VITINH SET TenDVT=@TenDVT
WHERE MaDVT = @MaDVT

CREATE PROC sp_xoaDVT(@MaDVT varchar(10))
AS 
DELETE FROM DON_VITINH
WHERE MaDVT = @MaDVT

CREATE PROC sp_tkDVT(@TK nvarchar(100))
AS 
SELECT * FROM DON_VITINH
WHERE MaDVT like '%' + @TK + '%' OR TenDVT like '%' + @TK + '%'  

//PROCEDURE_LOAIHANG

CREATE PROC sp_themLH(@MaLoai varchar(10),@TenLoai nvarchar(100))
AS 
INSERT INTO LOAI_HANGHOA(MaLoai,TenLoai)
VALUES(@MaLoai,@TenLoai)

CREATE PROC sp_suaLH(@MaLoai varchar(10),@TenLoai nvarchar(100))
AS 
UPDATE LOAI_HANGHOA SET TenLoai=@TenLoai
WHERE MaLoai = @MaLoai

CREATE PROC sp_xoaLH(@MaLoai varchar(10))
AS 
DELETE FROM LOAI_HANGHOA
WHERE MaLoai = @MaLoai

CREATE PROC sp_tkLH(@TK nvarchar(100))
AS 
SELECT * FROM LOAI_HANGHOA
WHERE MaLoai like '%' + @TK + '%' OR TenLoai like '%' + @TK + '%' 

//PROCEDURE_VITRIHANGHOA
CREATE PROC sp_themVT(@MaHH varchar(10),@ToaDo varchar(100),@TrangThai varchar(100))
AS 
INSERT INTO VITRI_HANGHOA(MaHH,ToaDo,TrangThai)
VALUES(@MaHH,@ToaDo,@TrangThai)

CREATE PROC sp_suaVT(@MaVT varchar(10),@MaHH varchar(10),@ToaDo varchar(100),@TrangThai varchar(100))
AS 
UPDATE VITRI_HANGHOA SET MaHH=@MaHH,ToaDo=@ToaDo,TrangThai = @TrangThai
WHERE MaVT = @MaVT

CREATE PROC sp_xoaVT(@ToaDo varchar(10))
AS 
DELETE FROM VITRI_HANGHOA
WHERE ToaDo = @ToaDo


//PROCEDURE_COLOR_HANGHOA
CREATE PROC sp_themCL(@Color varchar(100),@MaHH varchar(10))
AS 
INSERT INTO COLOR_HANGHOA(Color,MaHH)
VALUES(@Color,@MaHH)

CREATE PROC sp_suaCL(@ID varchar(10),@Color varchar(100))
AS 
UPDATE COLOR_HANGHOA SET @Color=Color
WHERE ID = @ID

CREATE PROC sp_xoaCL(@ID varchar(10))
AS 
DELETE FROM COLOR_HANGHOA
WHERE ID = @ID
// -- VIEW
//VIEW_HANGHOA
CREATE VIEW HH AS
SELECT HANG_HOA.MaHH,TenHH,TonKho,TenLoai,TenDVT,BatDauLuuTru,KetThucLuuTru,TrangThai,TenKH
FROM HANG_HOA,KHACH_HANG,LOAI_HANGHOA,DON_VITINH
WHERE HANG_HOA.MaLoai = LOAI_HANGHOA.MaLoai AND KHACH_HANG.MaKH = HANG_HOA.MaKH AND DON_VITINH.MaDVT = HANG_HOA.MaDVT

CREATE VIEW HH_MS AS
SELECT        dbo.HANG_HOA.MaHH, dbo.HANG_HOA.TenHH, dbo.HANG_HOA.TonKho, dbo.LOAI_HANGHOA.TenLoai, dbo.DON_VITINH.TenDVT, dbo.HANG_HOA.BatDauLuuTru, dbo.HANG_HOA.KetThucLuuTru, dbo.HANG_HOA.TrangThai, 
                         dbo.KHACH_HANG.TenKH, dbo.COLOR_HANGHOA.Color
FROM            dbo.DON_VITINH INNER JOIN
                         dbo.HANG_HOA ON dbo.DON_VITINH.MaDVT = dbo.HANG_HOA.MaDVT INNER JOIN
                         dbo.KHACH_HANG ON dbo.HANG_HOA.MaKH = dbo.KHACH_HANG.MaKH INNER JOIN
                         dbo.LOAI_HANGHOA ON dbo.HANG_HOA.MaLoai = dbo.LOAI_HANGHOA.MaLoai LEFT OUTER JOIN
                         dbo.COLOR_HANGHOA ON dbo.HANG_HOA.MaHH = dbo.COLOR_HANGHOA.MaHH



SELECT * FROM HH_MS




//VIEW_PHIEUNHAP_PHIEUXUAT
CREATE VIEW PN AS
SELECT MaPN,NgayLap,TenNV
FROM PHIEU_NHAP,NHAN_VIEN
WHERE NHAN_VIEN.MaNV = PHIEU_NHAP.MaNV

CREATE VIEW PX AS
SELECT MaPX,NgayLap,TenNV
FROM PHIEU_XUAT,NHAN_VIEN
WHERE NHAN_VIEN.MaNV = PHIEU_XUAT.MaNV

//PROC_VIEW_CTPN
CREATE PROC sp_viewCTPN (@MaPN varchar(10)) 
AS
SELECT MaCTPN,TenHH,SoXe,SoKhoi,SoLuong
FROM CT_PHIEUNHAP,HANG_HOA
WHERE HANG_HOA.MaHH = CT_PHIEUNHAP.MaHH AND MaPN = @MaPN

//PROC_VIEW_CTPX
CREATE PROC sp_viewCTPX (@MaPX varchar(10)) 
AS
SELECT MaCTPX,TenHH,SoXe,SoKhoi,SoLuong
FROM CT_PHIEUXUAT,HANG_HOA
WHERE HANG_HOA.MaHH = CT_PHIEUXUAT.MaHH AND MaPX = @MaPX

//PROC_VIEW_BAOCAO
//HANGNHAP
CREATE PROC sp_viewBCHN(@TuNgay datetime,@DenNgay datetime) AS
SELECT * FROM BC_HANGNHAP
WHERE NgayLap BETWEEN @TuNgay+'00:00:00' AND @DenNgay+'23:59:59';
//HANGXUAT
CREATE PROC sp_viewBCHX(@TuNgay datetime,@DenNgay datetime) AS
SELECT * FROM BC_HANGXUAT
WHERE NgayLap BETWEEN @TuNgay+'00:00:00' AND @DenNgay+'23:59:59';
//HANGHOATHEOLOAI
CREATE PROC sp_viewHHTHEOLOAI(@MaLoai varchar(10)) AS
SELECT * FROM BC_HANGHOA
WHERE MaLoai = @MaLoai
//HANGHOATHEOKHACHHANG
CREATE PROC sp_viewHHTHEOKH(@MaKH varchar(10)) AS
SELECT * FROM BC_HANGHOA
WHERE MaKH = @MaKH

CREATE PROC sp_viewVTHHTHEOLOAI(@MaLoai varchar(10)) AS
SELECT * FROM BC_VITRIHANGHOA
WHERE MaLoai = @MaLoai

//VIEW_TAIKHOAN 
CREATE VIEW TAI_KHOAN 
AS
SELECT MaTK,TenTK,TenNV,TenNhom,NgayLap 
FROM TAI_KHOANNV,NHOM_TAIKHOAN,NHAN_VIEN
WHERE NHAN_VIEN.MaNV = TAI_KHOANNV.MaNV AND NHOM_TAIKHOAN.MaNhom = TAI_KHOANNV.MaNhom

//VIEW_HH_VT_KHIEM

//VIEW_HH_VT_CL_KHIEM
create view [dbo].[VT_HH_Cl] as 
SELECT        dbo.HANG_HOA.MaHH, dbo.HANG_HOA.TenHH, dbo.HANG_HOA.TonKho, dbo.LOAI_HANGHOA.TenLoai, dbo.DON_VITINH.TenDVT, dbo.HANG_HOA.BatDauLuuTru, dbo.HANG_HOA.KetThucLuuTru, dbo.HANG_HOA.TrangThai, 
                         dbo.KHACH_HANG.TenKH, dbo.VITRI_HANGHOA.ToaDo , dbo.COLOR_HANGHOA.Color,VITRI_HANGHOA.MaVT,COLOR_HANGHOA.ID
FROM            dbo.HANG_HOA INNER JOIN
                         dbo.LOAI_HANGHOA ON dbo.HANG_HOA.MaLoai = dbo.LOAI_HANGHOA.MaLoai INNER JOIN
                         dbo.KHACH_HANG ON dbo.HANG_HOA.MaKH = dbo.KHACH_HANG.MaKH INNER JOIN
                         dbo.DON_VITINH ON dbo.HANG_HOA.MaDVT = dbo.DON_VITINH.MaDVT  LEFT OUTER join
						 dbo.COLOR_HANGHOA on dbo.HANG_HOA.MaHH = dbo.COLOR_HANGHOA.MaHH
						 Right OUTER JOIN
                         dbo.VITRI_HANGHOA ON dbo.HANG_HOA.MaHH = dbo.VITRI_HANGHOA.MaHH



//VIEW_BAOCAOHANGNHAP
CREATE VIEW BC_HANGNHAP AS
SELECT NgayLap,PHIEU_NHAP.MaPN,HANG_HOA.TenHH,TenDVT,CT_PHIEUNHAP.MaHH,CT_PHIEUNHAP.SoLuong
FROM HANG_HOA,PHIEU_NHAP,CT_PHIEUNHAP,DON_VITINH
WHERE HANG_HOA.MaHH = CT_PHIEUNHAP.MaHH AND PHIEU_NHAP.MaPN = CT_PHIEUNHAP.MaPN AND HANG_HOA.MaDVT = DON_VITINH.MaDVT


//VIEW_BAOCAOHANGXUAT
CREATE VIEW BC_HANGXUAT AS
SELECT NgayLap,PHIEU_XUAT.MaPX,HANG_HOA.TenHH,TenDVT,CT_PHIEUXUAT.MaHH,CT_PHIEUXUAT.SoLuong
FROM HANG_HOA,PHIEU_XUAT,CT_PHIEUXUAT,DON_VITINH
WHERE HANG_HOA.MaHH = CT_PHIEUXUAT.MaHH AND PHIEU_XUAT.MaPX = CT_PHIEUXUAT.MaPX AND HANG_HOA.MaDVT = DON_VITINH.MaDVT

SELECT * FROM HANG_HOA
CREATE VIEW GET_ID_VITRI_COLOR AS
SELECT HANG_HOA.MaHH,MaVT,ToaDo,ID,Color
FROM VITRI_HANGHOA,COLOR_HANGHOA,HANG_HOA
WHERE VITRI_HANGHOA.MaHH = HANG_HOA.MaHH AND HANG_HOA.MaHH = COLOR_HANGHOA.MaHH

//VIEW_BC_HANGHOA
CREATE VIEW BC_HANGHOA AS
SELECT MaHH,TenHH,TonKho,TenLoai,TenDVT,BatDauLuuTru,KetThucLuuTru,TenKH
FROM HANG_HOA,KHACH_HANG,DON_VITINH,LOAI_HANGHOA
WHERE HANG_HOA.MaKH = KHACH_HANG.MaKH AND DON_VITINH.MaDVT = HANG_HOA.MaDVT AND LOAI_HANGHOA.MaLoai = HANG_HOA.MaLoai



SELECT * FROM BC_HANGHOA
--- THU TUC PROCEDURE
//PROCEDURE_HANGHOA

CREATE PROC sp_themHH(@MaHH varchar(10),@TenHH nvarchar(100),@MaLoai varchar(10),@MaDVT varchar(10),@MaKH varchar(10),@BatDauLuuTru datetime,@KetThucLuuTru datetime,@TonKho int,@TrangThai nvarchar(100))
AS 
INSERT INTO HANG_HOA(MaHH,TenHH,MaLoai,MaDVT,MaKH,BatDauLuuTru,KetThucLuuTru,TonKho,TrangThai)
VALUES(@MaHH,@TenHH,@MaLoai,@MaDVT,@MaKH,@BatDauLuuTru,@KetThucLuuTru,@TonKho,@TrangThai)

CREATE PROC sp_suaHH(@MaHH varchar(10),@TenHH nvarchar(100),@MaLoai varchar(10),@MaDVT varchar(10),@MaKH varchar(10),@BatDauLuuTru datetime,@KetThucLuuTru datetime)
AS 
UPDATE HANG_HOA SET TenHH=@TenHH,MaLoai=@MaLoai,MaDVT=@MaDVT,MaKH=@MaKH,BatDauLuuTru=@BatDauLuuTru,KetThucLuuTru=@KetThucLuuTru
WHERE MaHH = @MaHH

CREATE PROC sp_xoaHH(@MaHH varchar(10))
AS 
DELETE FROM HANG_HOA
WHERE MaHH = @MaHH

CREATE PROC sp_tkHH(@TK nvarchar(100))
AS 
SELECT * FROM HH
WHERE MaHH like '%' + @TK + '%' OR TenHH like '%' + @TK + '%'  OR TenLoai like '%'+@TK+'%' OR TenKH like '%'+@TK+'%'

//PROCEDURE_PHIEUNHAP

CREATE PROC sp_themPN(@MaPN varchar(10),@NgayLap datetime,@MaNV varchar(10))
AS 
INSERT INTO PHIEU_NHAP(MaPN,NgayLap,MaNV)
VALUES(@MaPN,@NgayLap,@MaNV)

CREATE PROC sp_suaPN(@MaPN varchar(10),@NgayLap datetime,@MaNV varchar(10))
AS 
UPDATE PHIEU_NHAP SET NgayLap = @NgayLap,MaNV = @MaNV
WHERE MaPN = @MaPN

CREATE PROC sp_xoaPN(@MaPN varchar(10))
AS 
DELETE FROM PHIEU_NHAP
WHERE MaPN = @MaPN

CREATE PROC sp_xoaAll_CTPN(@MaPN varchar(10))
AS 
DELETE FROM CT_PHIEUNHAP
WHERE MaPN = @MaPN


CREATE PROC sp_tkPN(@TK nvarchar(100))
AS 
SELECT * FROM PN
WHERE MaPN like '%' + @TK + '%' OR TenNV like '%' + @TK + '%' 

//PROCEDURE_PHIEUXUAT

CREATE PROC sp_themPX(@MaPX varchar(10),@NgayLap datetime,@MaNV varchar(10))
AS 
INSERT INTO PHIEU_XUAT(MaPX,NgayLap,MaNV)
VALUES(@MaPX,@NgayLap,@MaNV)

CREATE PROC sp_suaPX(@MaPX varchar(10),@NgayLap datetime,@MaNV varchar(10))
AS 
UPDATE PHIEU_XUAT SET NgayLap = @NgayLap,MaNV = @MaNV
WHERE MaPX = @MaPX

CREATE PROC sp_xoaPX(@MaPX varchar(10))
AS 
DELETE FROM PHIEU_XUAT
WHERE MaPX = @MaPX

CREATE PROC sp_xoaAll_CTPX(@MaPX varchar(10))
AS 
DELETE FROM CT_PHIEUXUAT
WHERE MaPX = @MaPX

CREATE PROC sp_tkPX(@TK nvarchar(100))
AS 
SELECT * FROM PX
WHERE MaPX like '%' + @TK + '%' OR TenNV like '%' + @TK + '%' 

//PROCEDURE_CT_PHIEUNHAP

CREATE PROC sp_themCTPN(@MaCTPN varchar(10),@MaPN varchar(10),@MaHH varchar(10),@SoXe varchar(100),@SoKhoi int,@SoLuong int)
AS 
INSERT INTO CT_PHIEUNHAP(MaCTPN,MaPN,MaHH,SoXe,SoKhoi,SoLuong)
VALUES(@MaCTPN,@MaPN,@MaHH,@SoXe,@SoKhoi,@SoLuong)

CREATE PROC sp_suaCTPN(@MaCTPN varchar(10),@MaPN varchar(10),@MaHH varchar(10),@SoXe varchar(100),@SoKhoi int,@SoLuong int)
AS 
UPDATE CT_PHIEUNHAP SET MaPN = @MaPN,MaHH = @MaHH,SoXe = @SoXe,SoLuong = @SoLuong,SoKhoi=@SoKhoi
WHERE MaCTPN = @MaCTPN

CREATE PROC sp_xoaCTPN(@MaCTPN varchar(10))
AS 
DELETE FROM CT_PHIEUNHAP
WHERE MaCTPN = @MaCTPN

CREATE PROC sp_tkCTPN(@TK nvarchar(100),@MaPN varchar(10))
AS 
SELECT MaCTPN,TenHH,SoXe,SoKhoi,SoLuong
FROM CT_PHIEUNHAP,HANG_HOA
WHERE HANG_HOA.MaHH = CT_PHIEUNHAP.MaHH AND MaPN = @MaPN AND MaCTPN like '%'+@TK+'%' OR TenHH like '%'+@TK+'%' OR SoXe like '%'+@TK+'%'

//PROCEDURE_CT_PHIEUXUAT

CREATE PROC sp_themCTPX(@MaCTPX varchar(10),@MaPX varchar(10),@MaHH varchar(10),@SoXe varchar(100),@SoKhoi int,@SoLuong int)
AS 
INSERT INTO CT_PHIEUXUAT(MaCTPX,MaPX,MaHH,SoXe,SoKhoi,SoLuong)
VALUES(@MaCTPX,@MaPX,@MaHH,@SoXe,@SoKhoi,@SoLuong)

CREATE PROC sp_suaCTPX(@MaCTPX varchar(10),@MaPX varchar(10),@MaHH varchar(10),@SoXe varchar(100),@SoKhoi int,@SoLuong int)
AS 
UPDATE CT_PHIEUXUAT SET MaPX = @MaPX,MaHH = @MaHH,SoXe = @SoXe,SoLuong = @SoLuong,SoKhoi=@SoKhoi
WHERE MaCTPX = @MaCTPX

CREATE PROC sp_xoaCTPX(@MaCTPX varchar(10))
AS 
DELETE FROM CT_PHIEUXUAT
WHERE MaCTPX = @MaCTPX

CREATE PROC sp_tkCTPX(@TK nvarchar(100),@MaPX varchar(10))
AS 
SELECT MaCTPX,TenHH,SoXe,SoKhoi,SoLuong
FROM CT_PHIEUXUAT,HANG_HOA
WHERE HANG_HOA.MaHH = CT_PHIEUXUAT.MaHH AND MaPX = @MaPX AND MaCTPX like '%'+@TK+'%' OR TenHH like '%'+@TK+'%' OR SoXe like '%'+@TK+'%'

//PROC_QLTAIKHOAN

CREATE PROC sp_themTK(@MaNV varchar(10),@NgayLap datetime,@MaNhom varchar(10),@TenTK varchar(100),@MatKhau varchar(100))
AS
INSERT INTO TAI_KHOANNV(MaNV,NgayLap,MaNhom,TenTK,MatKhau)
VALUES(@MaNV,@NgayLap,@MaNhom,@TenTK,@MatKhau)

CREATE PROC sp_suaTK(@MaTK varchar(10),@MaNV varchar(10),@MaNhom varchar(10),@MatKhau varchar(100))
AS
UPDATE TAI_KHOANNV SET MaNV = @MaNV,MaNhom=@MaNhom,MatKhau=@MatKhau
WHERE MaTK = @MaTK

CREATE PROC sp_xoaTK(@MaTK varchar(10))
AS
DELETE FROM TAI_KHOANNV 
WHERE MaTK = @MaTK

//TRIGGER_SOLUONGHANGTON

//THEM_PHIEUNHAP
CREATE TRIGGER trg_ThemPN ON CT_PHIEUNHAP AFTER INSERT AS
BEGIN
	UPDATE HANG_HOA
	SET TonKho = TonKho + (
	SELECT SoLuong FROM inserted
	WHERE MaHH = HANG_HOA.MaHH)
	FROM HANG_HOA
	JOIN inserted ON HANG_HOA.MaHH = inserted.MaHH
END


//THEM_PHIEUXUAT
CREATE TRIGGER trg_ThemPX ON CT_PHIEUXUAT AFTER INSERT AS
BEGIN
	UPDATE HANG_HOA
	SET TonKho = TonKho - (
	SELECT SoLuong FROM inserted
	WHERE MaHH = HANG_HOA.MaHH)
	FROM HANG_HOA
	JOIN inserted ON HANG_HOA.MaHH = inserted.MaHH
END

//XOA_PHIEUNHAP
CREATE TRIGGER trg_XoaPN ON CT_PHIEUNHAP FOR DELETE AS
BEGIN
	UPDATE HANG_HOA
	SET TonKho = TonKho - (
	SELECT SoLuong FROM deleted
	WHERE MaHH = HANG_HOA.MaHH)
	FROM HANG_HOA
	JOIN deleted ON HANG_HOA.MaHH = deleted.MaHH
END

//XOA_PHIEUXUAT
CREATE TRIGGER trg_XoaPX ON CT_PHIEUXUAT FOR DELETE AS
BEGIN
	UPDATE HANG_HOA
	SET TonKho = TonKho + (
	SELECT SoLuong FROM deleted
	WHERE MaHH = HANG_HOA.MaHH)
	FROM HANG_HOA
	JOIN deleted ON HANG_HOA.MaHH = deleted.MaHH
END

//CAPNHAT_PHIEUNHAP

CREATE TRIGGER trg_CapNhatPhieuNhap on CT_PHIEUNHAP after update AS
BEGIN
   UPDATE HANG_HOA SET TonKho = TonKho +
	   (SELECT SoLuong FROM inserted WHERE MaHH = HANG_HOA.MaHH) -
	   (SELECT SoLuong FROM deleted WHERE MaHH = HANG_HOA.MaHH)
   FROM HANG_HOA
   JOIN deleted ON HANG_HOA.MaHH = deleted.MaHH
END

//CAPNHAT_PHIEUXUAT
CREATE TRIGGER trg_CapNhatPhieuXuat on CT_PHIEUXUAT after update AS
BEGIN
   UPDATE HANG_HOA SET TonKho = TonKho -
	   (SELECT SoLuong FROM inserted WHERE MaHH = HANG_HOA.MaHH) +
	   (SELECT SoLuong FROM deleted WHERE MaHH = HANG_HOA.MaHH)
   FROM HANG_HOA
   JOIN deleted ON HANG_HOA.MaHH = deleted.MaHH
END

//BATLOI_THEMPX
CREATE TRIGGER trg_BLThemPX ON CT_PHIEUXUAT AFTER INSERT,UPDATE AS
	IF (SELECT TonKho FROM HANG_HOA INNER JOIN inserted ON HANG_HOA.MaHH = inserted.MaHH) <0  
	BEGIN
	PRINT N'Tồn kho đã bị âm do hết hàng hoặc số lượng hàng xuất vượt quá tồn kho. Số lượng tồn kho còn lại là:' (SELECT TonKho FROM HANG_HOA INNER JOIN inserted ON HANG_HOA.MaHH = inserted.MaHH)
	ROLLBACK TRAN
END




