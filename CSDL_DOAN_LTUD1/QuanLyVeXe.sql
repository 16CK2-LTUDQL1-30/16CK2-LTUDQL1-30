create database QL_VeXe
go
use QL_VeXe
go
create table Tram_trung_gian
(
	Tuyen_ID_Tuyen nchar(10) not null,
	Tram_ID_Tram nchar(10) not null,
	Thu_tu int,
	primary key(Tuyen_ID_Tuyen, Tram_ID_Tram)
)
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
	Tuyen_ID_Tuyen nchar(10),
	Gio_khoi_hanh datetime,
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
	ID_Ghe nchar(10) primary key,
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
	Ghe_ID_Ghe nchar(10),
	Chuyen_ID_Chuyen nchar(10),
	TinhTrang nchar(10),
	GiaTien float,
	KhachHang_ID_KhachHang nchar(10),
	NgayXuatVe datetime,
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
--Thêm dữ liệu vào bảng trạm
insert into Tram(ID_Tram, TenTram, Dia_Diem) values('CD001', N'An Giang', N'Châu Đốc'), ('CD002', N'An Giang', N'Tp.Long Xuyên'), ('CM001', N'Tp.Cà Mau', N'Tp.Cà Mau'),
('CT001', N'Cần Thơ', N'Tp.Cần Thơ'), ('HCM001', N'Tp.Hồ Chí Minh', N'208, Lê Hồng Phong, Quận 5'), ('HCM002', N'Tp.Hồ Chí Minh', N'210, Lý Thường Kiệt, Quận 10'),
('HCM003', N'Tp.Hồ Chí Minh', N'số 1, Bến Xe Miền Tây, Quận 6'), ('HCM004', N'Tp.Hồ Chí Minh', N'số 1, Trần Hưng Đạo, Quận 1'),
('VL001', N'Tp.Vĩnh Long', N'Công viên Trường An, Vĩnh Long'), ('VL002', N'Tp.Vĩnh Long', N'Bắc Mỹ Thuận, Vĩnh Long') 
--Thêm dữ liệu vào bảng Tuyến
insert into Tuyen(ID_Tuyen, KhoangCach, ThoiGianChay, Tram_ID_Tram, Tram_ID_Tram1) values('Tuyen001', 173, '4am-7am', 'CT001', 'HCM001'), ('Tuyen002', 180, '5am-8am', 'CT001', 'HCM002'), ('Tuyen003', 174, '6am-10am', 'CT001', 'HCM003'),
('Tuyen004', 184, '7am-11am', 'CT001', 'HCM004'), ('Tuyen005', 228, '3am-8am', 'CD001', 'CM001'), ('Tuyen006', 230, '5am-10am', 'CD001', 'CM002'), ('Tuyen007', 250, '9am-2pm', 'CD002', 'CM001'), ('Tuyen008', 252, '10am-4pm', 'CD002', 'CM002'),
('Tuyen009', 180, '4am-8am', 'VL001', 'CM001'), ('Tuyen010', 190, '8am-11am', 'VL001', 'CM002'), ('Tuyen011', 150, '2pm-6pm', 'VL002', 'CM001'), ('Tuyen012', 190, '4am-7am', 'VL002', 'CM002')
--Thêm dữ liệu vào trạm trung gian
insert into Tram_trung_gian(Tuyen_ID_Tuyen, Tram_ID_Tram, Thu_tu) values('Tuyen001', 'CT001', 1), ('Tuyen005', 'CD001', 2), ('Tuyen007', 'CD002', 3), ('Tuyen009', 'VL001', 4), ('Tuyen011', 'VL002', 5)
