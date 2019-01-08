USE [master]
GO
/****** Object:  Database [QL_VeXeKhach]    Script Date: 1/8/2019 12:42:35 PM ******/
CREATE DATABASE [QL_VeXeKhach]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_VeXeKhach', FILENAME = N'D:\SqlServer\MSSQL14.SQLEXPRESS\MSSQL\DATA\QL_VeXeKhach.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QL_VeXeKhach_log', FILENAME = N'D:\SqlServer\MSSQL14.SQLEXPRESS\MSSQL\DATA\QL_VeXeKhach_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QL_VeXeKhach] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_VeXeKhach].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_VeXeKhach] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_VeXeKhach] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_VeXeKhach] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_VeXeKhach] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_VeXeKhach] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_VeXeKhach] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QL_VeXeKhach] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_VeXeKhach] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_VeXeKhach] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_VeXeKhach] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_VeXeKhach] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_VeXeKhach] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_VeXeKhach] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_VeXeKhach] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_VeXeKhach] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QL_VeXeKhach] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_VeXeKhach] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_VeXeKhach] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_VeXeKhach] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_VeXeKhach] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_VeXeKhach] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_VeXeKhach] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_VeXeKhach] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_VeXeKhach] SET  MULTI_USER 
GO
ALTER DATABASE [QL_VeXeKhach] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_VeXeKhach] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_VeXeKhach] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_VeXeKhach] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QL_VeXeKhach] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QL_VeXeKhach] SET QUERY_STORE = OFF
GO
USE [QL_VeXeKhach]
GO
/****** Object:  Table [dbo].[Chuyen]    Script Date: 1/8/2019 12:42:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chuyen](
	[ID_Chuyen] [nchar](10) NOT NULL,
	[Tuyen_ID_Tuyen] [nchar](10) NULL,
	[Gio_khoi_hanh] [datetime] NULL,
	[Ghi_chu] [nvarchar](4000) NULL,
	[Xe_XeID] [nchar](10) NULL,
	[Tai_xe_ID_TaiXe] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Chuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ghe]    Script Date: 1/8/2019 12:42:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ghe](
	[ID_Ghe] [nchar](10) NOT NULL,
	[Dong] [int] NOT NULL,
	[Cot] [int] NOT NULL,
	[Tang] [int] NOT NULL,
	[So_Ghe] [nchar](10) NOT NULL,
	[Xe_XeID] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Ghe_Xe] PRIMARY KEY CLUSTERED 
(
	[ID_Ghe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 1/8/2019 12:42:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID_KhachHang] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](4000) NULL,
	[DienThoai] [nvarchar](4000) NULL,
	[Email] [nvarchar](4000) NULL,
	[Loai] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_KhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 1/8/2019 12:42:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiXe](
	[ID_LoaiXe] [nchar](10) NOT NULL,
	[TenLoai] [nvarchar](4000) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_LoaiXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tai_xe]    Script Date: 1/8/2019 12:42:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tai_xe](
	[ID_TaiXe] [nchar](10) NOT NULL,
	[TenTaiXe] [nvarchar](4000) NULL,
	[BangLai] [nvarchar](4000) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_TaiXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tram]    Script Date: 1/8/2019 12:42:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tram](
	[ID_Tram] [nchar](10) NOT NULL,
	[TenTram] [nvarchar](4000) NULL,
	[Dia_Diem] [nvarchar](4000) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Tram] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tram_trung_gian]    Script Date: 1/8/2019 12:42:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tram_trung_gian](
	[Tuyen_ID_Tuyen] [nchar](10) NOT NULL,
	[Tram_ID_Tram] [nchar](10) NOT NULL,
	[Thu_tu] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Tuyen_ID_Tuyen] ASC,
	[Tram_ID_Tram] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tuyen]    Script Date: 1/8/2019 12:42:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tuyen](
	[ID_Tuyen] [nchar](10) NOT NULL,
	[KhoangCach] [int] NULL,
	[ThoiGianChay] [nchar](10) NULL,
	[Tram_ID_Tram1] [nchar](10) NULL,
	[Tram_ID_Tram] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Tuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ve]    Script Date: 1/8/2019 12:42:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ve](
	[ID_Ve] [int] IDENTITY(1,1) NOT NULL,
	[Ghe_ID_Ghe] [nchar](10) NULL,
	[Chuyen_ID_Chuyen] [nchar](10) NULL,
	[TinhTrang] [nchar](10) NULL,
	[GiaTien] [float] NULL,
	[KhachHang_ID_KhachHang] [nchar](10) NULL,
	[NgayXuatVe] [datetime] NULL,
	[GhiChu] [nvarchar](4000) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 1/8/2019 12:42:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[XeID] [nchar](10) NOT NULL,
	[TenXe] [nvarchar](4000) NULL,
	[So_dang_ky] [varchar](4000) NULL,
	[LoaiXe_ID_LoaiXe] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[XeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Chuyen] ([ID_Chuyen], [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES (N'Chuyen001 ', N'Tuyen001  ', CAST(N'2018-12-16T12:44:54.840' AS DateTime), N'Đã khởi hành', N'X001      ', N'TX001     ')
INSERT [dbo].[Chuyen] ([ID_Chuyen], [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES (N'Chuyen002 ', N'Tuyen002  ', CAST(N'2018-12-16T12:44:54.840' AS DateTime), N'Chuẩn bị khởi hành', N'X002      ', N'TX002     ')
INSERT [dbo].[Chuyen] ([ID_Chuyen], [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES (N'Chuyen003 ', N'Tuyen003  ', CAST(N'2018-12-16T12:44:54.840' AS DateTime), N'Đang khởi hành', N'X003      ', N'TX003     ')
INSERT [dbo].[Chuyen] ([ID_Chuyen], [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES (N'Chuyen004 ', N'Tuyen004  ', CAST(N'2018-12-16T12:44:54.840' AS DateTime), N'Chuẩn bị khởi hành', N'X004      ', N'TX004     ')
INSERT [dbo].[Chuyen] ([ID_Chuyen], [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES (N'Chuyen005 ', N'Tuyen005  ', CAST(N'2018-12-16T12:44:54.840' AS DateTime), N'Đã khởi hành', N'X005      ', N'TX005     ')
INSERT [dbo].[Chuyen] ([ID_Chuyen], [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES (N'Chuyen006 ', N'Tuyen001  ', CAST(N'2018-12-16T12:44:54.840' AS DateTime), N'Đã khởi hành', N'X003      ', N'TX002     ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G01   ', 1, 1, 1, N'1         ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G02   ', 1, 2, 1, N'2         ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G03   ', 1, 3, 1, N'3         ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G04   ', 1, 4, 1, N'4         ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G05   ', 2, 1, 1, N'5         ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G06   ', 2, 2, 1, N'6         ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G07   ', 2, 3, 1, N'7         ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G08   ', 2, 4, 1, N'8         ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G09   ', 3, 1, 1, N'9         ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G10   ', 3, 2, 1, N'10        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G11   ', 3, 3, 1, N'11        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G12   ', 3, 4, 1, N'12        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G13   ', 4, 1, 1, N'13        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G14   ', 4, 2, 1, N'14        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G15   ', 4, 3, 1, N'15        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G16   ', 4, 4, 1, N'16        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G17   ', 5, 1, 1, N'17        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G18   ', 5, 2, 1, N'18        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G19   ', 5, 3, 1, N'19        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G20   ', 5, 4, 1, N'20        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G21   ', 6, 1, 1, N'21        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G22   ', 6, 2, 1, N'22        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G23   ', 6, 3, 1, N'23        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G24   ', 6, 4, 1, N'24        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G25   ', 7, 1, 1, N'25        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G26   ', 7, 2, 1, N'26        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G27   ', 7, 3, 1, N'27        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G28   ', 7, 4, 1, N'28        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G29   ', 8, 1, 1, N'29        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X001G30   ', 8, 2, 1, N'30        ', N'X001      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X002G01   ', 1, 1, 1, N'1         ', N'X002      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X002G02   ', 1, 2, 1, N'2         ', N'X002      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X002G03   ', 1, 3, 1, N'3         ', N'X002      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X002G04   ', 1, 4, 1, N'4         ', N'X002      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X002G05   ', 2, 1, 1, N'5         ', N'X002      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X002G06   ', 2, 2, 1, N'6         ', N'X002      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X002G07   ', 2, 3, 1, N'7         ', N'X002      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X002G08   ', 2, 4, 1, N'8         ', N'X002      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X002G09   ', 3, 1, 1, N'9         ', N'X002      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X002G10   ', 3, 2, 1, N'10        ', N'X002      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X002G11   ', 3, 3, 1, N'11        ', N'X002      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X002G12   ', 3, 4, 1, N'12        ', N'X002      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X002G13   ', 4, 1, 1, N'13        ', N'X002      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X002G14   ', 4, 2, 1, N'14        ', N'X002      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X002G15   ', 4, 3, 1, N'15        ', N'X002      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X002G16   ', 4, 4, 1, N'16        ', N'X002      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X003G01   ', 1, 1, 1, N'1         ', N'X003      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X003G02   ', 1, 2, 1, N'2         ', N'X003      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X003G03   ', 1, 3, 1, N'3         ', N'X003      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X003G04   ', 1, 4, 1, N'4         ', N'X003      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X003G05   ', 2, 1, 5, N'1         ', N'X003      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X003G06   ', 2, 2, 1, N'6         ', N'X003      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X003G07   ', 2, 3, 1, N'7         ', N'X003      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X003G08   ', 2, 4, 1, N'8         ', N'X003      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X003G09   ', 3, 1, 1, N'9         ', N'X003      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X003G10   ', 3, 2, 1, N'10        ', N'X003      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X003G11   ', 3, 3, 1, N'11        ', N'X003      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X003G12   ', 3, 4, 1, N'12        ', N'X003      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X003G13   ', 4, 1, 1, N'13        ', N'X003      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X003G14   ', 4, 2, 1, N'14        ', N'X003      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X003G15   ', 4, 3, 1, N'15        ', N'X003      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X003G16   ', 4, 4, 1, N'16        ', N'X003      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X004G01   ', 1, 1, 1, N'1         ', N'X004      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X004G02   ', 1, 2, 1, N'2         ', N'X004      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X004G03   ', 1, 3, 1, N'3         ', N'X004      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X004G04   ', 1, 4, 1, N'4         ', N'X004      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X004G05   ', 2, 1, 5, N'1         ', N'X004      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X004G06   ', 2, 2, 1, N'6         ', N'X004      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X004G07   ', 2, 3, 1, N'7         ', N'X004      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X004G08   ', 2, 4, 1, N'8         ', N'X004      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X004G09   ', 3, 1, 1, N'9         ', N'X004      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X004G10   ', 3, 2, 1, N'10        ', N'X004      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X004G11   ', 3, 3, 1, N'11        ', N'X004      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X004G12   ', 3, 4, 1, N'12        ', N'X004      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X004G13   ', 4, 1, 1, N'13        ', N'X004      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X004G14   ', 4, 2, 1, N'14        ', N'X004      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X004G15   ', 4, 3, 1, N'15        ', N'X004      ')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID]) VALUES (N'X004G16   ', 4, 4, 1, N'16        ', N'X004      ')
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([ID_KhachHang], [HoTen], [DienThoai], [Email], [Loai]) VALUES (1, N'Triều Minh', N'0909684072', N'onmylove1999@gmail.com', N'Loai      ')
INSERT [dbo].[KhachHang] ([ID_KhachHang], [HoTen], [DienThoai], [Email], [Loai]) VALUES (3, N'Trương Bích Trâm', N'0909684073', N'erty@gmail.com', N'thường    ')
INSERT [dbo].[KhachHang] ([ID_KhachHang], [HoTen], [DienThoai], [Email], [Loai]) VALUES (4, N'Diệp Ngọc Nhi', N'0909684071', N'aDGAG@gmail.com', N'thường    ')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
INSERT [dbo].[LoaiXe] ([ID_LoaiXe], [TenLoai]) VALUES (N'L001      ', N'Huyndai Universe')
INSERT [dbo].[LoaiXe] ([ID_LoaiXe], [TenLoai]) VALUES (N'L002      ', N'Huyndai Aero Space')
INSERT [dbo].[LoaiXe] ([ID_LoaiXe], [TenLoai]) VALUES (N'L003      ', N'Huyndai Aero Hi Class')
INSERT [dbo].[LoaiXe] ([ID_LoaiXe], [TenLoai]) VALUES (N'L004      ', N'Huyndai County')
INSERT [dbo].[LoaiXe] ([ID_LoaiXe], [TenLoai]) VALUES (N'L005      ', N'MobiHome 120L')
INSERT [dbo].[Tai_xe] ([ID_TaiXe], [TenTaiXe], [BangLai]) VALUES (N'TX001     ', N'Trần Văn Nguyên', N'Hạng C')
INSERT [dbo].[Tai_xe] ([ID_TaiXe], [TenTaiXe], [BangLai]) VALUES (N'TX002     ', N'Nguyễn Văn Tí', N'Hạng D')
INSERT [dbo].[Tai_xe] ([ID_TaiXe], [TenTaiXe], [BangLai]) VALUES (N'TX003     ', N'Nguyễn Văn Bé', N'Hạng E')
INSERT [dbo].[Tai_xe] ([ID_TaiXe], [TenTaiXe], [BangLai]) VALUES (N'TX004     ', N'Trần Đình Hoàng', N'Hạng B2')
INSERT [dbo].[Tai_xe] ([ID_TaiXe], [TenTaiXe], [BangLai]) VALUES (N'TX005     ', N'Nguyễn Trần B', N'Hạng B')
INSERT [dbo].[Tram] ([ID_Tram], [TenTram], [Dia_Diem]) VALUES (N'CD001     ', N'An Giang', N'Châu Đốc')
INSERT [dbo].[Tram] ([ID_Tram], [TenTram], [Dia_Diem]) VALUES (N'CD002     ', N'An Giang', N'Tp.Long Xuyên')
INSERT [dbo].[Tram] ([ID_Tram], [TenTram], [Dia_Diem]) VALUES (N'CM001     ', N'Tp.Cà Mau', N'Tp.Cà Mau')
INSERT [dbo].[Tram] ([ID_Tram], [TenTram], [Dia_Diem]) VALUES (N'CT001     ', N'Cần Thơ', N'Tp.Cần Thơ')
INSERT [dbo].[Tram] ([ID_Tram], [TenTram], [Dia_Diem]) VALUES (N'HCM001    ', N'Tp.Hồ Chí Minh', N'208, Lê Hồng Phong, Quận 5')
INSERT [dbo].[Tram] ([ID_Tram], [TenTram], [Dia_Diem]) VALUES (N'HCM002    ', N'Tp.Hồ Chí Minh', N'210, Lý Thường Kiệt, Quận 10')
INSERT [dbo].[Tram] ([ID_Tram], [TenTram], [Dia_Diem]) VALUES (N'HCM003    ', N'Tp.Hồ Chí Minh', N'số 1, Bến Xe Miền Tây, Quận 6')
INSERT [dbo].[Tram] ([ID_Tram], [TenTram], [Dia_Diem]) VALUES (N'HCM004    ', N'Tp.Hồ Chí Minh', N'số 1, Trần Hưng Đạo, Quận 1')
INSERT [dbo].[Tram] ([ID_Tram], [TenTram], [Dia_Diem]) VALUES (N'VL001     ', N'Tp.Vĩnh Long', N'Công viên Trường An, Vĩnh Long')
INSERT [dbo].[Tram] ([ID_Tram], [TenTram], [Dia_Diem]) VALUES (N'VL002     ', N'Tp.Vĩnh Long', N'Bắc Mỹ Thuận, Vĩnh Long')
INSERT [dbo].[Tram_trung_gian] ([Tuyen_ID_Tuyen], [Tram_ID_Tram], [Thu_tu]) VALUES (N'Tuyen001  ', N'CD001     ', 1)
INSERT [dbo].[Tram_trung_gian] ([Tuyen_ID_Tuyen], [Tram_ID_Tram], [Thu_tu]) VALUES (N'Tuyen002  ', N'CT001     ', 2)
INSERT [dbo].[Tram_trung_gian] ([Tuyen_ID_Tuyen], [Tram_ID_Tram], [Thu_tu]) VALUES (N'Tuyen006  ', N'CD002     ', 3)
INSERT [dbo].[Tram_trung_gian] ([Tuyen_ID_Tuyen], [Tram_ID_Tram], [Thu_tu]) VALUES (N'Tuyen007  ', N'VL001     ', 4)
INSERT [dbo].[Tram_trung_gian] ([Tuyen_ID_Tuyen], [Tram_ID_Tram], [Thu_tu]) VALUES (N'Tuyen008  ', N'VL002     ', 5)
INSERT [dbo].[Tuyen] ([ID_Tuyen], [KhoangCach], [ThoiGianChay], [Tram_ID_Tram1], [Tram_ID_Tram]) VALUES (N'Tuyen001  ', 173, N'4am-7am   ', N'CM001     ', N'CD001     ')
INSERT [dbo].[Tuyen] ([ID_Tuyen], [KhoangCach], [ThoiGianChay], [Tram_ID_Tram1], [Tram_ID_Tram]) VALUES (N'Tuyen002  ', 173, N'4am-7am   ', N'HCM001    ', N'CT001     ')
INSERT [dbo].[Tuyen] ([ID_Tuyen], [KhoangCach], [ThoiGianChay], [Tram_ID_Tram1], [Tram_ID_Tram]) VALUES (N'Tuyen003  ', 180, N'5am-8am   ', N'HCM002    ', N'CT001     ')
INSERT [dbo].[Tuyen] ([ID_Tuyen], [KhoangCach], [ThoiGianChay], [Tram_ID_Tram1], [Tram_ID_Tram]) VALUES (N'Tuyen004  ', 174, N'6am-10am  ', N'HCM003    ', N'CT001     ')
INSERT [dbo].[Tuyen] ([ID_Tuyen], [KhoangCach], [ThoiGianChay], [Tram_ID_Tram1], [Tram_ID_Tram]) VALUES (N'Tuyen005  ', 184, N'7am-11am  ', N'HCM004    ', N'CT001     ')
INSERT [dbo].[Tuyen] ([ID_Tuyen], [KhoangCach], [ThoiGianChay], [Tram_ID_Tram1], [Tram_ID_Tram]) VALUES (N'Tuyen006  ', 250, N'9am-2pm   ', N'CM001     ', N'CD002     ')
INSERT [dbo].[Tuyen] ([ID_Tuyen], [KhoangCach], [ThoiGianChay], [Tram_ID_Tram1], [Tram_ID_Tram]) VALUES (N'Tuyen007  ', 180, N'4am-8am   ', N'CM001     ', N'VL001     ')
INSERT [dbo].[Tuyen] ([ID_Tuyen], [KhoangCach], [ThoiGianChay], [Tram_ID_Tram1], [Tram_ID_Tram]) VALUES (N'Tuyen008  ', 150, N'2pm-6pm   ', N'CM001     ', N'VL002     ')
SET IDENTITY_INSERT [dbo].[Ve] ON 

INSERT [dbo].[Ve] ([ID_Ve], [Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (1, N'X001G01   ', N'Chuyen001 ', N'dat truoc ', 123, N'1         ', CAST(N'2019-01-07T16:55:04.103' AS DateTime), N'123')
INSERT [dbo].[Ve] ([ID_Ve], [Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (2, N'X001G14   ', N'Chuyen001 ', N'dat truoc ', 123, N'1         ', CAST(N'2019-01-08T12:26:23.817' AS DateTime), N'123')
INSERT [dbo].[Ve] ([ID_Ve], [Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (3, N'X001G15   ', N'Chuyen001 ', N'dat truoc ', 123, N'1         ', CAST(N'2019-01-08T12:33:42.740' AS DateTime), N'123')
INSERT [dbo].[Ve] ([ID_Ve], [Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (4, N'X001G13   ', N'Chuyen001 ', N'dat truoc ', 123, N'3         ', CAST(N'2019-01-08T12:36:46.303' AS DateTime), N'123')
INSERT [dbo].[Ve] ([ID_Ve], [Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (5, N'X001G28   ', N'Chuyen001 ', N'thanh toan', 123, N'1         ', CAST(N'2019-01-08T12:36:46.303' AS DateTime), N'123')
INSERT [dbo].[Ve] ([ID_Ve], [Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (6, N'X001G23   ', N'Chuyen001 ', N'dat truoc ', 123, N'4         ', CAST(N'2019-01-08T12:36:46.303' AS DateTime), N'123')
SET IDENTITY_INSERT [dbo].[Ve] OFF
INSERT [dbo].[Xe] ([XeID], [TenXe], [So_dang_ky], [LoaiXe_ID_LoaiXe]) VALUES (N'X001      ', N'Tha Phương', N'59H8-326598', N'L001      ')
INSERT [dbo].[Xe] ([XeID], [TenXe], [So_dang_ky], [LoaiXe_ID_LoaiXe]) VALUES (N'X002      ', N'Thanh Thủy', N'59H6-895645', N'L001      ')
INSERT [dbo].[Xe] ([XeID], [TenXe], [So_dang_ky], [LoaiXe_ID_LoaiXe]) VALUES (N'X003      ', N'Kim Hoàng', N'59H9-451289', N'L001      ')
INSERT [dbo].[Xe] ([XeID], [TenXe], [So_dang_ky], [LoaiXe_ID_LoaiXe]) VALUES (N'X004      ', N'Tha Phương', N'59E3-13467989', N'L002      ')
INSERT [dbo].[Xe] ([XeID], [TenXe], [So_dang_ky], [LoaiXe_ID_LoaiXe]) VALUES (N'X005      ', N'Phương Trang', N'59H6-31469785', N'L002      ')
INSERT [dbo].[Xe] ([XeID], [TenXe], [So_dang_ky], [LoaiXe_ID_LoaiXe]) VALUES (N'X006      ', N'Phương Trang', N'59H7-246987', N'L004      ')
INSERT [dbo].[Xe] ([XeID], [TenXe], [So_dang_ky], [LoaiXe_ID_LoaiXe]) VALUES (N'X007      ', N'Tha Phương', N'59H2-357965', N'L005      ')
ALTER TABLE [dbo].[Chuyen]  WITH CHECK ADD  CONSTRAINT [FK_Chuyen_TaiXe] FOREIGN KEY([Tai_xe_ID_TaiXe])
REFERENCES [dbo].[Tai_xe] ([ID_TaiXe])
GO
ALTER TABLE [dbo].[Chuyen] CHECK CONSTRAINT [FK_Chuyen_TaiXe]
GO
ALTER TABLE [dbo].[Chuyen]  WITH CHECK ADD  CONSTRAINT [FK_Chuyen_Tuyen] FOREIGN KEY([Tuyen_ID_Tuyen])
REFERENCES [dbo].[Tuyen] ([ID_Tuyen])
GO
ALTER TABLE [dbo].[Chuyen] CHECK CONSTRAINT [FK_Chuyen_Tuyen]
GO
ALTER TABLE [dbo].[Chuyen]  WITH CHECK ADD  CONSTRAINT [FK_Chuyen_Xe] FOREIGN KEY([Xe_XeID])
REFERENCES [dbo].[Xe] ([XeID])
GO
ALTER TABLE [dbo].[Chuyen] CHECK CONSTRAINT [FK_Chuyen_Xe]
GO
ALTER TABLE [dbo].[Ghe]  WITH CHECK ADD  CONSTRAINT [FK_Ghe_Xe] FOREIGN KEY([Xe_XeID])
REFERENCES [dbo].[Xe] ([XeID])
GO
ALTER TABLE [dbo].[Ghe] CHECK CONSTRAINT [FK_Ghe_Xe]
GO
ALTER TABLE [dbo].[Tram_trung_gian]  WITH CHECK ADD  CONSTRAINT [FK_Tram_trung_gian_Tram] FOREIGN KEY([Tram_ID_Tram])
REFERENCES [dbo].[Tram] ([ID_Tram])
GO
ALTER TABLE [dbo].[Tram_trung_gian] CHECK CONSTRAINT [FK_Tram_trung_gian_Tram]
GO
ALTER TABLE [dbo].[Tram_trung_gian]  WITH CHECK ADD  CONSTRAINT [FK_Tram_trung_gian_Tuyen] FOREIGN KEY([Tuyen_ID_Tuyen])
REFERENCES [dbo].[Tuyen] ([ID_Tuyen])
GO
ALTER TABLE [dbo].[Tram_trung_gian] CHECK CONSTRAINT [FK_Tram_trung_gian_Tuyen]
GO
ALTER TABLE [dbo].[Tuyen]  WITH CHECK ADD  CONSTRAINT [FK_Tuyen_Tram] FOREIGN KEY([Tram_ID_Tram])
REFERENCES [dbo].[Tram] ([ID_Tram])
GO
ALTER TABLE [dbo].[Tuyen] CHECK CONSTRAINT [FK_Tuyen_Tram]
GO
ALTER TABLE [dbo].[Tuyen]  WITH CHECK ADD  CONSTRAINT [FK1_Tuyen_Tram] FOREIGN KEY([Tram_ID_Tram1])
REFERENCES [dbo].[Tram] ([ID_Tram])
GO
ALTER TABLE [dbo].[Tuyen] CHECK CONSTRAINT [FK1_Tuyen_Tram]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_Chuyen] FOREIGN KEY([Chuyen_ID_Chuyen])
REFERENCES [dbo].[Chuyen] ([ID_Chuyen])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_Chuyen]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [PK_Ve_Ghe] FOREIGN KEY([Ghe_ID_Ghe])
REFERENCES [dbo].[Ghe] ([ID_Ghe])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [PK_Ve_Ghe]
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD  CONSTRAINT [FK_Xe_LoaiXe] FOREIGN KEY([LoaiXe_ID_LoaiXe])
REFERENCES [dbo].[LoaiXe] ([ID_LoaiXe])
GO
ALTER TABLE [dbo].[Xe] CHECK CONSTRAINT [FK_Xe_LoaiXe]
GO
USE [master]
GO
ALTER DATABASE [QL_VeXeKhach] SET  READ_WRITE 
GO
