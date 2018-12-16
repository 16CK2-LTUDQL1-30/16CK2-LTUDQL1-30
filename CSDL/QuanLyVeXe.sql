create database QL_VeXeKhach
go
use QL_VeXeKhach
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
alter table Xe add constraint FK_Xe_LoaiXe foreign key (LoaiXe_ID_LoaiXe) references LoaiXe(ID_LoaiXe)
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
insert into Tuyen(ID_Tuyen, KhoangCach, ThoiGianChay, Tram_ID_Tram, Tram_ID_Tram1) values('Tuyen001', 173, '4am-7am', 'CD001', 'CM001')
insert into Tuyen(ID_Tuyen, KhoangCach, ThoiGianChay, Tram_ID_Tram, Tram_ID_Tram1) values('Tuyen002', 173, '4am-7am', 'CT001', 'HCM001'), ('Tuyen003', 180, '5am-8am', 'CT001', 'HCM002'), ('Tuyen004', 174, '6am-10am', 'CT001', 'HCM003'),
('Tuyen005', 184, '7am-11am', 'CT001', 'HCM004'),('Tuyen006', 250, '9am-2pm', 'CD002', 'CM001'), ('Tuyen007', 180, '4am-8am', 'VL001', 'CM001'), ('Tuyen008', 150, '2pm-6pm', 'VL002', 'CM001')
--Thêm dữ liệu vào trạm trung gian
insert into Tram_trung_gian(Tuyen_ID_Tuyen, Tram_ID_Tram, Thu_tu) values('Tuyen001', 'CD001', 1), ('Tuyen002', 'CT001', 2), ('Tuyen006', 'CD002', 3), ('Tuyen007', 'VL001', 4), ('Tuyen008', 'VL002', 5)
--thêm dữ liệu vào bảng loại xe
insert into LoaiXe(ID_LoaiXe, TenLoai) values('L001', N'Huyndai Universe'), ('L002', N'Huyndai Aero Space'), ('L003', N'Huyndai Aero Hi Class')
--Thêm dữ liệu vào bảng Xe
insert into Xe(XeID, TenXe, So_dang_ky, LoaiXe_ID_LoaiXe) values('X001', N'30 chỗ', N'59H8-326598', 'L001'), ('X002', N'30 chỗ', N'59H6-895645', 'L001'), ('X003', N'30 chỗ', N'59H9-451289', 'L001'),
('X004', N'45 chỗ', N'59E3-13467989', 'L002'), ('X005', N'45 chỗ', N'59H6-31469785', 'L002'), ('X006', N'50 chỗ', N'59H7-246987', 'L003'), ('X007', N'50 chỗ', N'59H2-357965', 'L003')
--thêm dữ liệu vào bảng Tài Xế
insert into Tai_xe(ID_TaiXe, TenTaiXe, BangLai) values('TX001', N'Trần Văn Nguyên', N'Hạng C'), ('TX002', N'Nguyễn Văn Tí', N'Hạng D'), ('TX003', N'Nguyễn Văn Bé', N'Hạng E'), ('TX004', N'Trần Đình Hoàng', N'Hạng B2'), ('TX005', N'Nguyễn Trần B', N'Hạng B') 
--thêm dữ liệu vào bảng chuyến
insert into Chuyen(ID_Chuyen, Tuyen_ID_Tuyen, Gio_khoi_hanh, Ghi_chu, Xe_XeID, Tai_xe_ID_TaiXe) values('Chuyen001', 'Tuyen001', GETDATE(), null, 'X001', 'TX001')
insert into Chuyen(ID_Chuyen, Tuyen_ID_Tuyen, Gio_khoi_hanh, Ghi_chu, Xe_XeID, Tai_xe_ID_TaiXe) values('Chuyen002', 'Tuyen002', GETDATE(), null, 'X002', 'TX002'), ('Chuyen003', 'Tuyen003', GETDATE(), null, 'X003', 'TX003'), ('Chuyen004', 'Tuyen004', GETDATE(), null, 'X004', 'TX004'), ('Chuyen005', 'Tuyen005', GETDATE(), null, 'X005', 'TX005')
--thêm dữ liệu vào bảng ghế
insert into Ghe(ID_Ghe, Dong, Cot_colum, Tang, So_ghe, Xe_XeID) values('G001', 1, 1, 1, 30, 'X001'), ('G002', 1, 1, 1, 30, 'X002'), ('G003', 1, 1, 1, 30, 'X003'), ('G004', 1, 1, 1, 30, 'X004'), ('G005', 1, 1, 1, 30, 'X005')
--thêm dữ liệu vào bảng khách hàng
insert into KhachHang(ID_KhachHang, HoTen, DienThoai, Email, Loai) values('KH001', N'Trần Thị Kiều Trinh', '01254698795', 'tranthikieutrinh@gamil.com', N'thường'), ('KH002', N'Đoàn Kim Thủy', '0854698745', 'dkthuy@gamil.com', N'VIP'), ('KH003', N'Phạm Phú Quý', '03256874578', 'phuquypham@yahoo.com', N'thường'), ('KH004', N'Nguyễn Thị Nữ', '23568977464', 'ntnu@gamil.com', N'VIP'), ('KH005', N'Trần Văn An', '124548546648', 'tranvanan@gamil.com', N'VIP')
--thêm vào bảng vé
insert into Ve(ID_Ve, Ghe_ID_Ghe, Chuyen_ID_Chuyen, TinhTrang, GiaTien, KhachHang_ID_KhachHang, NgayXuatVe, GhiChu) values('V0002', 'G001', 'Chuyen001', N'thanh toan', 120, 'KH002', GETDATE() + 1, N'đặt vé trực tiếp'), ('V0003', 'G002', 'Chuyen002', N'thanh toan', 130, 'KH003', GETDATE() + 1, N'đặt vé online'), ('V0004', 'G003', 'Chuyen003', N'thanh toan', 150, 'KH003', GETDATE() + 1, N'đặt vé trực tiếp')
insert into Ve(ID_Ve, Ghe_ID_Ghe, Chuyen_ID_Chuyen, TinhTrang, GiaTien, KhachHang_ID_KhachHang, NgayXuatVe, GhiChu) values('V0001', 'G001', 'Chuyen001', N'thanh toan', '120', 'KH001', GETDATE(), N'đặt vé trực tiếp')
