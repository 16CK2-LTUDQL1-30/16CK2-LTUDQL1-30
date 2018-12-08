create database QuanLyVeXe_LTUD1
go
use QuanLyVeXe_LTUD1
go
---Tiến hành tạo bảng Trạm trung gian
create table Tram_trung_gian
(
	Tuyen_ID_Tuyen nchar(10) not null,
	Tram_ID_Tram nchar(10) not null,
	Thu_tu nchar(10),
	primary key(Tuyen_ID_Tuyen, Tram_ID_Tram)
)
---Tạo bảng Trạm
create table Tram
(
	ID_Tram nchar(10) primary key,
	TenTram nvarchar(4000),
	Dia_Diem nvarchar(4000),

)
--Tạo bảng Tuyến
create table Tuyen
(
	ID_Tuyen nchar(10) primary key,
	KhoangCach int,
	ThoiGianChay nchar(10),
	Tram_ID_Tram1 nchar(10),
	Tram_ID_Tram nchar(10),
)
--Tạo bảng tài xế
create table Tai_xe
(
	ID_TaiXe nchar(10) primary key,
	TenTaiXe nvarchar(4000),
	BangLai nvarchar(4000),
)
--Tạo bảng chuyến
create table Chuyen
(
	ID_Chuyen nchar(10) primary key,
	Tuyen_ID_Tuyen int,
	Gio_khoi_hanh date,
	Ghi_chu nvarchar(4000),
	Xe_XeID nchar(10),
	Tai_xe_ID_TaiXe nchar(10),
)
--Tạo bảng xe
create table Xe
(
	XeID nchar(10) primary key,
	TenXe nvarchar(4000),
	So_dang_ky varchar(4000),
	LoaiXe_ID_LoaiXe nchar(10),
)
--Tạo bảng loại xe
create table LoaiXe
(
	ID_LoaiXe nchar(10) primary key,
	TenLoai nvarchar(4000),
)
--Tạo bảng ghế
create table Ghe
(
	ID_Ghe int primary key,
	Dong int,
	Cot_colum int,
	Tang int,
	So_ghe int,
	Xe_XeID nchar(10),
)
--Tạo bảng Vé
create table Ve
(
	ID_Ve nchar(10),
	Ghe_ID_Ghe int,
	Chuyen_ID_Chuyen nchar(10),
	TinhTrang nchar(10),
	GiaTien float,
	KhachHang_ID_KhachHang nchar(10),
	NgayXuatVe date,
	GhiChu nvarchar(4000),
)
--Tạo bảng khách hàng
create table KhachHang
(
	ID_KhachHang nchar(10) primary key,
	HoTen nvarchar(4000),
	DienThoai nvarchar(4000),
	Email nvarchar(4000),
	Loai nchar(10),
)
--Tạo khóa ngoại giữa Tram Trung Gian và Tram
alter table Tram_trung_gian add constraint FK_Tram_trung_gian_Tram foreign key (Tram_ID_Tram) references Tram (ID_Tram)
--Tạo khóa ngoại giữa Tram trung gian và tuyến 
alter table Tram_trung_gian add constraint FK_Tram_trung_gian_Tuyen foreign key (Tuyen_ID_Tuyen) references Tuyen(ID_Tuyen)
--Tạo khóa ngoại giữa tuyến và trạm
alter table Tuyen add constraint FK_Tuyen_Tram foreign key (Tram_ID_Tram) references Tram(ID_Tram)
alter table Tuyen add constraint FK1_Tuyen_Tram foreign key (Tram_ID_Tram1) references Tram(ID_Tram)
--Tạo khóa ngoại chuyến với tài xế
alter table Chuyen add constraint FK_Chuyen_TaiXe foreign key (Tai_xe_ID_TaiXe) references Tai_Xe(ID_TaiXe)
--Tạo khóa ngoại Chuyến với tuyến
alter table Chuyen add constraint FK_Chuyen_Tuyen foreign key (Tuyen_ID_Tuyen) references Tuyen (ID_Tuyen)
--Tạo khóa ngoại Chuyến với xe
alter table Chuyen add constraint FK_Chuyen_Xe foreign key(Xe_XeID) references Xe(XeID)
--Tạo khóa ngoại Xe với LoaiXe
alter table Xe add constraint FK_Xe_LoaiXe foreign key (XeID) references LoaiXe(ID_LoaiXe)
--Tạo khóa ngoại Ghế với xe
alter table Ghe add constraint FK_Ghe_Xe foreign key (Xe_XeID) references Xe(XeID)
--Tạo khóa ngoại Vé với Ghế
alter table Ve add constraint FK_Ve_Ghe foreign key(Ghe_ID_Ghe) references Ghe(ID_Ghe)
--Tạo khóa ngoại vé với chuyến
alter table Ve add constraint FK_Ve_Chuyen foreign key(Chuyen_ID_Chuyen) references Chuyen(ID_Chuyen)
--Tạo khóa ngoại vé với khách hàng
alter table Ve add constraint FK_Ve_KhachHang foreign key (KhachHang_ID_KhachHang) references KhachHang(ID_KhachHang)
