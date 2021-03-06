USE [master]
GO
/****** Object:  Database [BanHangSieuThi]    Script Date: 18/06/2017 4:49:18 CH ******/
CREATE DATABASE [BanHangSieuThi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BanHangSieuThi', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.THANHHUONG\MSSQL\DATA\BanHangSieuThi.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BanHangSieuThi_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.THANHHUONG\MSSQL\DATA\BanHangSieuThi_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BanHangSieuThi] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BanHangSieuThi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BanHangSieuThi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BanHangSieuThi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BanHangSieuThi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BanHangSieuThi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BanHangSieuThi] SET ARITHABORT OFF 
GO
ALTER DATABASE [BanHangSieuThi] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BanHangSieuThi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BanHangSieuThi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BanHangSieuThi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BanHangSieuThi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BanHangSieuThi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BanHangSieuThi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BanHangSieuThi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BanHangSieuThi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BanHangSieuThi] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BanHangSieuThi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BanHangSieuThi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BanHangSieuThi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BanHangSieuThi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BanHangSieuThi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BanHangSieuThi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BanHangSieuThi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BanHangSieuThi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BanHangSieuThi] SET  MULTI_USER 
GO
ALTER DATABASE [BanHangSieuThi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BanHangSieuThi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BanHangSieuThi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BanHangSieuThi] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BanHangSieuThi] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BanHangSieuThi]
GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_ChiTietHoaDon]    Script Date: 18/06/2017 4:49:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[auto_ma_ChiTietHoaDon]() returns varchar(8)
as
begin
	declare @ma varchar(8)
	if(select count(ma) from ChiTietHoaDon)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,4)) from ChiTietHoaDon
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'CTHD000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'CTHD00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'CTHD0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_ChiTietPhieuNhap]    Script Date: 18/06/2017 4:49:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[auto_ma_ChiTietPhieuNhap]() returns varchar(8)
as
begin
	declare @ma varchar(8)
	if(select count(ma) from ChiTietPhieuNhap)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,4)) from ChiTietPhieuNhap
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'CTPN000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'CTPN00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'CTPN0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_ChiTietPhieuXuat]    Script Date: 18/06/2017 4:49:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[auto_ma_ChiTietPhieuXuat]() returns varchar(8)
as
begin
	declare @ma varchar(8)
	if(select count(ma) from ChiTietPhieuXuat)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,4)) from ChiTietPhieuXuat
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'CTPX000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'CTPX00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'CTPX0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end

GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_ChucVu]    Script Date: 18/06/2017 4:49:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create function [dbo].[auto_ma_ChucVu]() returns varchar(6)
as
begin
	declare @ma varchar(6)
	if(select count(ma) from ChucVu)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,4)) from ChucVu
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'CV000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'CV00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'CV0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_DonViQuyDoi]    Script Date: 18/06/2017 4:49:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create function [dbo].[auto_ma_DonViQuyDoi]() returns varchar(8)
as
begin
	declare @ma varchar(8)
	if(select count(ma) from DonViQuyDoi)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,4)) from DonViQuyDoi
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'DVQD000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'DVQD00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'DVQD0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_HangHoa]    Script Date: 18/06/2017 4:49:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[auto_ma_HangHoa]() returns varchar(6)
as
begin
	declare @ma varchar(50)
	if(select count(ma) from HangHoa)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,3)) from HangHoa
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'HH000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'HH00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'HH0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_HoaDon]    Script Date: 18/06/2017 4:49:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[auto_ma_HoaDon]() returns varchar(6)
as
begin
	declare @ma varchar(6)
	if(select count(ma) from HoaDon)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,4)) from HoaDon
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'HD000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'HD00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'HD0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end

GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_KhachHang]    Script Date: 18/06/2017 4:49:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[auto_ma_KhachHang]() returns varchar(6)
as
begin
	declare @ma varchar(50)
	if(select count(ma) from KhachHang)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,3)) from KhachHang
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'KH000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'KH00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'KH0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end

GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_Kho]    Script Date: 18/06/2017 4:49:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create function [dbo].[auto_ma_Kho]() returns varchar(5)
as
begin
	declare @ma varchar(5)
	if(select count(ma) from Kho)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,4)) from Kho
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'K000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'K00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'K0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_KhuyenMai]    Script Date: 18/06/2017 4:49:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[auto_ma_KhuyenMai]() returns varchar(6)
as
begin
	declare @ma varchar(5)
	if(select count(ma) from KhuyenMai)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,4)) from KhuyenMai
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'KM000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'KM00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'KM0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_nv]    Script Date: 18/06/2017 4:49:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[auto_ma_nv]() returns varchar(6)
as
begin
	declare @ma varchar(50)
	if(select count(ma) from NhanVien)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,3)) from NhanVien
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'NV000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'NV00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'NV0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end

GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_NhaCungCap]    Script Date: 18/06/2017 4:49:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[auto_ma_NhaCungCap]() returns varchar(7)
as
begin
	declare @ma varchar(7)
	if(select count(ma) from NhaCungCap)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,4)) from NhaCungCap
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'NCC000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'NCC00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'NCC0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_NhomHang]    Script Date: 18/06/2017 4:49:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[auto_ma_NhomHang]() returns varchar(6)
as
begin
	declare @ma varchar(6)
	if(select count(ma) from NhomHang)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,4)) from NhomHang
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'NH000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'NH00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'NH0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_PhieuNhap]    Script Date: 18/06/2017 4:49:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[auto_ma_PhieuNhap]() returns varchar(6)
as
begin
	declare @ma varchar(6)
	if(select count(ma) from PhieuNhap)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,4)) from PhieuNhap
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'PN000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'PN00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'PN0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_PhieuXuat]    Script Date: 18/06/2017 4:49:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[auto_ma_PhieuXuat]() returns varchar(6)
as
begin
	declare @ma varchar(6)
	if(select count(ma) from PhieuXuat)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,4)) from PhieuXuat
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'PX000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'PX00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'PX0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_PhongBan]    Script Date: 18/06/2017 4:49:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create function [dbo].[auto_ma_PhongBan]() returns varchar(6)
as
begin
	declare @ma varchar(6)
	if(select count(ma) from PhongBan)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,4)) from PhongBan
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'PB000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'PB00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'PB0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_TheKhachHang]    Script Date: 18/06/2017 4:49:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create function [dbo].[auto_ma_TheKhachHang]() returns varchar(7)
as
begin
	declare @ma varchar(7)
	if(select count(ma) from TheKhachHang)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,4)) from TheKhachHang
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'TKH000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'TKH00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'TKH0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 18/06/2017 4:49:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[ma] [varchar](20) NOT NULL,
	[hoadonma] [varchar](20) NULL,
	[hanghoama] [varchar](20) NULL,
	[soluong] [int] NULL,
	[donvi] [nvarchar](20) NULL,
	[donviquydoima] [varchar](20) NULL,
	[dongia] [float] NULL,
	[thanhtien] [money] NULL,
 CONSTRAINT [PK__ChiTietP__3213C8B7653487D4] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[ma] [varchar](20) NOT NULL,
	[phieunhapma] [varchar](20) NULL,
	[hanghoama] [varchar](20) NULL,
	[khoma] [varchar](20) NULL,
	[soluong] [int] NULL,
	[donvi] [nvarchar](20) NULL,
	[donviquydoima] [varchar](20) NULL,
	[dongia] [float] NULL,
	[thanhtien] [money] NULL,
 CONSTRAINT [PK__ChiTietP__3213C8B711867C35] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietPhieuXuat]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuXuat](
	[ma] [varchar](20) NOT NULL,
	[phieuxuatma] [varchar](20) NULL,
	[khoma] [varchar](20) NULL,
	[hanghoama] [varchar](20) NULL,
	[soluong] [int] NULL,
	[donvi] [nvarchar](20) NULL,
	[donviquydoima] [varchar](20) NULL,
 CONSTRAINT [PK_ChiTietPhieuXuat] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DonViQuyDoi]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DonViQuyDoi](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](20) NULL,
	[donvidoi] [nvarchar](20) NOT NULL,
	[donvicoso] [nvarchar](20) NULL,
	[hesoquydoi] [int] NULL,
 CONSTRAINT [PK__DonViTin__3213C8B7D6950650] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HangHoa](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[soluong] [int] NULL,
	[ngaysanxuat] [date] NULL,
	[hansudung] [date] NULL,
	[noisanxuat] [nvarchar](50) NULL,
	[dongia] [money] NULL,
	[khuyenmaima] [varchar](20) NULL,
 CONSTRAINT [PK__HangHoa__3214CC9FF9A4CF09] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[ma] [varchar](20) NOT NULL,
	[ngay] [date] NULL,
	[khachhangma] [varchar](20) NULL,
	[nhanvienma] [varchar](20) NULL,
	[tongtien] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[gioitinh] [int] NULL,
	[diachi] [nvarchar](50) NULL,
	[sodienthoai] [varchar](20) NULL,
	[sochungminh] [int] NULL,
	[email] [varchar](50) NULL,
	[diemtichluy] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Kho](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[diachi] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[noidungkhuyenmai] [nvarchar](100) NULL,
	[phantramkhuyenmai] [float] NULL,
	[ngaybatdau] [date] NULL,
	[ngayketthuc] [date] NULL,
	[tinhtrang] [nvarchar](20) NULL,
 CONSTRAINT [PK_KhuyenMai] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[sodienthoai] [varchar](12) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[gioitinh] [int] NULL,
	[ngaysinh] [date] NULL,
	[sodienthoai] [int] NULL,
	[diachi] [text] NULL,
	[matkhau] [varchar](20) NULL,
 CONSTRAINT [PK__NhanVien__3214CC9F5627A157] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[ma] [varchar](20) NOT NULL,
	[ngay] [date] NULL,
	[tongtien] [money] NULL,
	[nhacungcapma] [varchar](20) NULL,
 CONSTRAINT [PK__PhieuNha__3213C8B7B5170A36] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[ma] [varchar](20) NOT NULL,
	[ngay] [date] NULL,
 CONSTRAINT [PK_PhieuXuat] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietHoaDon] ([ma], [hoadonma], [hanghoama], [soluong], [donvi], [donviquydoima], [dongia], [thanhtien]) VALUES (N'CTHD0001', N'HD0001', N'HH0001', 1, N'túi', N'DVQD0001', 100000, 100000.0000)
INSERT [dbo].[ChiTietHoaDon] ([ma], [hoadonma], [hanghoama], [soluong], [donvi], [donviquydoima], [dongia], [thanhtien]) VALUES (N'CTHD0002', N'HD0001', N'HH0001', 1, N'1 thùng 30 chai', N'DVQD0001', 10000, 300000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([ma], [phieunhapma], [hanghoama], [khoma], [soluong], [donvi], [donviquydoima], [dongia], [thanhtien]) VALUES (N'CTPN0001', N'PN0001', N'HH0001', N'K0005', 1, N'1 thùng 30 chai', N'DVQD0001', 10000, 10000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([ma], [phieunhapma], [hanghoama], [khoma], [soluong], [donvi], [donviquydoima], [dongia], [thanhtien]) VALUES (N'CTPN0002', N'PN0002', N'HH0001', N'K0001', 1, N'1 thùng 30 chai', N'DVQD0001', 10000, 10000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([ma], [phieunhapma], [hanghoama], [khoma], [soluong], [donvi], [donviquydoima], [dongia], [thanhtien]) VALUES (N'CTPN0003', N'PN0002', N'HH0001', N'K0002', 1, N'1 thùng 30 chai', N'DVQD0001', 10000, 10000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([ma], [phieunhapma], [hanghoama], [khoma], [soluong], [donvi], [donviquydoima], [dongia], [thanhtien]) VALUES (N'CTPN0004', N'PN0002', N'HH0002', N'K0002', 1, N'1 thùng 30 chai', N'DVQD0001', 20000, 20000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([ma], [phieunhapma], [hanghoama], [khoma], [soluong], [donvi], [donviquydoima], [dongia], [thanhtien]) VALUES (N'CTPN0005', N'PN0002', N'HH0003', N'K0003', 1, N'1 thùng 30 chai', N'DVQD0001', 12999, 12999.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([ma], [phieunhapma], [hanghoama], [khoma], [soluong], [donvi], [donviquydoima], [dongia], [thanhtien]) VALUES (N'CTPN0006', N'PN0002', N'HH0004', N'K0004', 1, N'1 thùng 30 chai', N'DVQD0001', 22222, 22222.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([ma], [phieunhapma], [hanghoama], [khoma], [soluong], [donvi], [donviquydoima], [dongia], [thanhtien]) VALUES (N'CTPN0007', N'PN0002', N'HH0005', N'K0005', 1, N'1 thùng 30 chai', N'DVQD0001', 11111, 11111.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([ma], [phieunhapma], [hanghoama], [khoma], [soluong], [donvi], [donviquydoima], [dongia], [thanhtien]) VALUES (N'CTPN0008', N'PN0003', N'HH0001', N'K0001', 1, N'1 thùng 30 chai', N'DVQD0001', 10000, 10000.0000)
INSERT [dbo].[ChiTietPhieuXuat] ([ma], [phieuxuatma], [khoma], [hanghoama], [soluong], [donvi], [donviquydoima]) VALUES (N'CTPX0001', N'PX0001', N'K0002', N'HH0002', 1, N'1 thùng 30 chai', NULL)
INSERT [dbo].[DonViQuyDoi] ([ma], [ten], [donvidoi], [donvicoso], [hesoquydoi]) VALUES (N'DVQD0001', N'1 thùng 30 chai', N'thùng', N'chai', 30)
INSERT [dbo].[DonViQuyDoi] ([ma], [ten], [donvidoi], [donvicoso], [hesoquydoi]) VALUES (N'DVQD0002', N'1 két 30 lon', N'két', N'lon', 30)
INSERT [dbo].[DonViQuyDoi] ([ma], [ten], [donvidoi], [donvicoso], [hesoquydoi]) VALUES (N'DVQD0003', N'1 tá 12 chiếc', N'tá', N'chiếc', 12)
INSERT [dbo].[DonViQuyDoi] ([ma], [ten], [donvidoi], [donvicoso], [hesoquydoi]) VALUES (N'DVQD0004', N'1 chiếc', N'chiếc', N'chiếc', 1)
INSERT [dbo].[DonViQuyDoi] ([ma], [ten], [donvidoi], [donvicoso], [hesoquydoi]) VALUES (N'DVQD0005', N'1kg', N'kg', N'kg', 1)
INSERT [dbo].[DonViQuyDoi] ([ma], [ten], [donvidoi], [donvicoso], [hesoquydoi]) VALUES (N'DVQD0006', N'1kg 1000g', N'kg', N'g', 1000)
INSERT [dbo].[DonViQuyDoi] ([ma], [ten], [donvidoi], [donvicoso], [hesoquydoi]) VALUES (N'DVQD0007', N'1 lít', N'lít', N'lít', 1)
INSERT [dbo].[DonViQuyDoi] ([ma], [ten], [donvidoi], [donvicoso], [hesoquydoi]) VALUES (N'DVQD0008', N'ml', N'lít', N'ml', 1000)
INSERT [dbo].[DonViQuyDoi] ([ma], [ten], [donvidoi], [donvicoso], [hesoquydoi]) VALUES (N'DVQD0009', N'1 hộp', N'hộp', N'hộp', 1)
INSERT [dbo].[HangHoa] ([ma], [ten], [soluong], [ngaysanxuat], [hansudung], [noisanxuat], [dongia], [khuyenmaima]) VALUES (N'HH0001', N'Quần thun', 68, CAST(N'2017-02-04' AS Date), CAST(N'2019-07-07' AS Date), N'Công ty quần áo Việt An', 10000.0000, N'KM0001')
INSERT [dbo].[HangHoa] ([ma], [ten], [soluong], [ngaysanxuat], [hansudung], [noisanxuat], [dongia], [khuyenmaima]) VALUES (N'HH0002', N'Chăn Sông Hồng', 1, CAST(N'2017-03-04' AS Date), CAST(N'2019-07-07' AS Date), N'Công ty Sông Hồng', 20000.0000, N'KM0002')
INSERT [dbo].[HangHoa] ([ma], [ten], [soluong], [ngaysanxuat], [hansudung], [noisanxuat], [dongia], [khuyenmaima]) VALUES (N'HH0003', N'rau cải', 0, CAST(N'2017-05-04' AS Date), CAST(N'2017-05-05' AS Date), N'Khu nông sản sạch Hà Nội', 12999.0000, N'KM0003')
INSERT [dbo].[HangHoa] ([ma], [ten], [soluong], [ngaysanxuat], [hansudung], [noisanxuat], [dongia], [khuyenmaima]) VALUES (N'HH0004', N'nước rửa bát sunline', 350, CAST(N'2016-08-04' AS Date), CAST(N'2017-08-05' AS Date), N'Công ty Unilever', 22222.0000, N'KM0004')
INSERT [dbo].[HangHoa] ([ma], [ten], [soluong], [ngaysanxuat], [hansudung], [noisanxuat], [dongia], [khuyenmaima]) VALUES (N'HH0005', N'Son ', 2, CAST(N'2016-09-04' AS Date), CAST(N'2018-09-04' AS Date), N'Công ty mỹ phẩm Hà Nội', 11111.0000, N'KM0005')
INSERT [dbo].[HoaDon] ([ma], [ngay], [khachhangma], [nhanvienma], [tongtien]) VALUES (N'HD0001', CAST(N'2017-06-18' AS Date), N'KH0001', N'NV0001', 100000.0000)
INSERT [dbo].[HoaDon] ([ma], [ngay], [khachhangma], [nhanvienma], [tongtien]) VALUES (N'PX0001', CAST(N'2017-06-18' AS Date), N'KH0001', N'NV0001', 300000.0000)
INSERT [dbo].[KhachHang] ([ma], [ten], [gioitinh], [diachi], [sodienthoai], [sochungminh], [email], [diemtichluy]) VALUES (N'KH0001', N'Khách bán lẻ', NULL, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[KhachHang] ([ma], [ten], [gioitinh], [diachi], [sodienthoai], [sochungminh], [email], [diemtichluy]) VALUES (N'KH0002', N'hoàng văn nam', 0, N'hà nội', N'1234234564', 173876534, N'hoangnam@gmail.com', 147853)
INSERT [dbo].[KhachHang] ([ma], [ten], [gioitinh], [diachi], [sodienthoai], [sochungminh], [email], [diemtichluy]) VALUES (N'KH0003', N'hoàng văn hải', 0, N'hà nội', N'1234234564', 173876534, N'hoanghai@gmail.com', 147853)
INSERT [dbo].[KhachHang] ([ma], [ten], [gioitinh], [diachi], [sodienthoai], [sochungminh], [email], [diemtichluy]) VALUES (N'KH0004', N'hoàng văn bình', 0, N'hà nội', N'1234234564', 173876534, N'hoangbinh@gmail.com', 147853)
INSERT [dbo].[KhachHang] ([ma], [ten], [gioitinh], [diachi], [sodienthoai], [sochungminh], [email], [diemtichluy]) VALUES (N'KH0005', N'hoàng văn tiến', 0, N'hà nội', N'1234234564', 173876534, N'hoangtien@gmail.com', 147853)
INSERT [dbo].[KhachHang] ([ma], [ten], [gioitinh], [diachi], [sodienthoai], [sochungminh], [email], [diemtichluy]) VALUES (N'KH0006', N'hoàng văn tùng', 0, N'hà nội', N'1234234564', 173876534, N'hoangtung@gmail.com', 147853)
INSERT [dbo].[KhachHang] ([ma], [ten], [gioitinh], [diachi], [sodienthoai], [sochungminh], [email], [diemtichluy]) VALUES (N'KH0007', N'hoàng văn nam', 0, N'hà nội', N'1234234564', 173876534, N'hoangnam@gmail.com', 147853)
INSERT [dbo].[KhachHang] ([ma], [ten], [gioitinh], [diachi], [sodienthoai], [sochungminh], [email], [diemtichluy]) VALUES (N'KH0008', N'hoàng văn hải', 0, N'hà nội', N'1234234564', 173876534, N'hoanghai@gmail.com', 147853)
INSERT [dbo].[KhachHang] ([ma], [ten], [gioitinh], [diachi], [sodienthoai], [sochungminh], [email], [diemtichluy]) VALUES (N'KH0009', N'hoàng văn bình', 0, N'hà nội', N'1234234564', 173876534, N'hoangbinh@gmail.com', 147853)
INSERT [dbo].[KhachHang] ([ma], [ten], [gioitinh], [diachi], [sodienthoai], [sochungminh], [email], [diemtichluy]) VALUES (N'KH0010', N'hoàng văn tiến', 0, N'hà nội', N'1234234564', 173876534, N'hoangtien@gmail.com', 147853)
INSERT [dbo].[KhachHang] ([ma], [ten], [gioitinh], [diachi], [sodienthoai], [sochungminh], [email], [diemtichluy]) VALUES (N'KH0011', N'Cửa hàng thực phẩm hoàng hà', NULL, N'hà nội', N'0122222222', NULL, N'hoangha@gmail.com', 147853)
INSERT [dbo].[Kho] ([ma], [ten], [diachi]) VALUES (N'K0001', N'Kho chứa hàng thực phẩm', N'lô 3,tổ 6,khu công nghiệp Sài Đồng B,Long Biên,Hà Nội')
INSERT [dbo].[Kho] ([ma], [ten], [diachi]) VALUES (N'K0002', N'Kho chứa hàng xuất khẩu', N'lô 3,tổ 6,khu công nghiệp Sài Đồng B,Long Biên,Hà Nội')
INSERT [dbo].[Kho] ([ma], [ten], [diachi]) VALUES (N'K0003', N'Kho chứa hàng tồn đọng', N'lô 3,tổ 6,khu công nghiệp Sài Đồng B,Long Biên,Hà Nội')
INSERT [dbo].[Kho] ([ma], [ten], [diachi]) VALUES (N'K0004', N'Kho chứa hàng gia dụng', N'lô 3,tổ 6,khu công nghiệp Sài Đồng B,Long Biên,Hà Nội')
INSERT [dbo].[Kho] ([ma], [ten], [diachi]) VALUES (N'K0005', N'Kho chứa hàng may mặc', N'lô 3,tổ 6,khu công nghiệp Sài Đồng B,Long Biên,Hà Nội')
INSERT [dbo].[KhuyenMai] ([ma], [ten], [noidungkhuyenmai], [phantramkhuyenmai], [ngaybatdau], [ngayketthuc], [tinhtrang]) VALUES (N'KM0001', N'Khuyến mại', N'giảm giá', 20, CAST(N'2017-01-01' AS Date), CAST(N'2017-01-02' AS Date), N'kết thúc')
INSERT [dbo].[KhuyenMai] ([ma], [ten], [noidungkhuyenmai], [phantramkhuyenmai], [ngaybatdau], [ngayketthuc], [tinhtrang]) VALUES (N'KM0002', N'Khuyến mại giảm giá', N'giảm giá', 20, CAST(N'2017-05-07' AS Date), CAST(N'2017-06-10' AS Date), N'đang diễn ra')
INSERT [dbo].[KhuyenMai] ([ma], [ten], [noidungkhuyenmai], [phantramkhuyenmai], [ngaybatdau], [ngayketthuc], [tinhtrang]) VALUES (N'KM0003', N'Khuyến mại', N'giảm giá', 30, CAST(N'2017-05-09' AS Date), CAST(N'2017-06-29' AS Date), N'đang diễn ra')
INSERT [dbo].[KhuyenMai] ([ma], [ten], [noidungkhuyenmai], [phantramkhuyenmai], [ngaybatdau], [ngayketthuc], [tinhtrang]) VALUES (N'KM0004', N'Khuyến mại', N'giảm giá', 20, CAST(N'2017-05-09' AS Date), CAST(N'2017-07-01' AS Date), N'đang diễn ra')
INSERT [dbo].[KhuyenMai] ([ma], [ten], [noidungkhuyenmai], [phantramkhuyenmai], [ngaybatdau], [ngayketthuc], [tinhtrang]) VALUES (N'KM0005', N'Khuyến mại', N'giảm giá', 16, CAST(N'2017-05-08' AS Date), CAST(N'2017-08-07' AS Date), N'đang diễn ra')
INSERT [dbo].[NhaCungCap] ([ma], [ten], [diachi], [sodienthoai]) VALUES (N'NCC0001', N'Công ty bánh kẹo Hải Hà', N'Hà Nội', N'012345678')
INSERT [dbo].[NhaCungCap] ([ma], [ten], [diachi], [sodienthoai]) VALUES (N'NCC0002', N'Công ty mỹ phẩm Hàn Quốc', N'Hà Nam', N'012344444')
INSERT [dbo].[NhaCungCap] ([ma], [ten], [diachi], [sodienthoai]) VALUES (N'NCC0003', N'Công ty chăn ga gối đệm Sông Hồng', N'Nam Định', N'012345666')
INSERT [dbo].[NhaCungCap] ([ma], [ten], [diachi], [sodienthoai]) VALUES (N'NCC0004', N'Công ty nước giải khát Gia Lâm', N'Hà Nội', N'012345555')
INSERT [dbo].[NhaCungCap] ([ma], [ten], [diachi], [sodienthoai]) VALUES (N'NCC0005', N'Trang trại thực phẩm sạch', N'Thái Bình', N'012347777')
INSERT [dbo].[NhanVien] ([ma], [ten], [gioitinh], [ngaysinh], [sodienthoai], [diachi], [matkhau]) VALUES (N'NV0001', N'LÊ VĂN AN', 0, CAST(N'1990-03-04' AS Date), 123456789, N'HN', N'1234')
INSERT [dbo].[NhanVien] ([ma], [ten], [gioitinh], [ngaysinh], [sodienthoai], [diachi], [matkhau]) VALUES (N'NV0002', N'NGUYỄN VĂN AN', 0, CAST(N'1999-03-04' AS Date), 123456789, N'HN', N'1234')
INSERT [dbo].[NhanVien] ([ma], [ten], [gioitinh], [ngaysinh], [sodienthoai], [diachi], [matkhau]) VALUES (N'NV0003', N'NGUYỄN VĂN BÌNH', 0, CAST(N'1890-03-04' AS Date), 123456789, N'HN', N'1234')
INSERT [dbo].[NhanVien] ([ma], [ten], [gioitinh], [ngaysinh], [sodienthoai], [diachi], [matkhau]) VALUES (N'NV0004', N'LÊ VĂN HẢI', 0, CAST(N'1970-03-04' AS Date), 123456789, N'HN', N'1234')
INSERT [dbo].[NhanVien] ([ma], [ten], [gioitinh], [ngaysinh], [sodienthoai], [diachi], [matkhau]) VALUES (N'NV0005', N'LÊ VĂN ANH', 0, CAST(N'1990-03-04' AS Date), 123456789, N'HN', N'1234')
INSERT [dbo].[NhanVien] ([ma], [ten], [gioitinh], [ngaysinh], [sodienthoai], [diachi], [matkhau]) VALUES (N'NV001', N'LÊ VĂN AN', 0, CAST(N'1990-03-04' AS Date), 123456789, N'HN', N'1234')
INSERT [dbo].[NhanVien] ([ma], [ten], [gioitinh], [ngaysinh], [sodienthoai], [diachi], [matkhau]) VALUES (N'NV002', N'NGUYỄN VĂN AN', 0, CAST(N'1999-03-04' AS Date), 123456789, N'HN', N'1234')
INSERT [dbo].[NhanVien] ([ma], [ten], [gioitinh], [ngaysinh], [sodienthoai], [diachi], [matkhau]) VALUES (N'NV003', N'NGUYỄN VĂN BÌNH', 0, CAST(N'1890-03-04' AS Date), 123456789, N'HN', N'1234')
INSERT [dbo].[NhanVien] ([ma], [ten], [gioitinh], [ngaysinh], [sodienthoai], [diachi], [matkhau]) VALUES (N'NV004', N'LÊ VĂN HẢI', 0, CAST(N'1970-03-04' AS Date), 123456789, N'HN', N'1234')
INSERT [dbo].[NhanVien] ([ma], [ten], [gioitinh], [ngaysinh], [sodienthoai], [diachi], [matkhau]) VALUES (N'NV005', N'LÊ VĂN ANH', 0, CAST(N'1990-03-04' AS Date), 123456789, N'HN', N'1234')
INSERT [dbo].[PhieuNhap] ([ma], [ngay], [tongtien], [nhacungcapma]) VALUES (N'PN0001', CAST(N'2017-05-11' AS Date), 300000.0000, NULL)
INSERT [dbo].[PhieuNhap] ([ma], [ngay], [tongtien], [nhacungcapma]) VALUES (N'PN0002', CAST(N'2017-06-05' AS Date), 2589960.0000, NULL)
INSERT [dbo].[PhieuNhap] ([ma], [ngay], [tongtien], [nhacungcapma]) VALUES (N'PN0003', CAST(N'2017-06-18' AS Date), 300000.0000, N'NCC0001')
INSERT [dbo].[PhieuXuat] ([ma], [ngay]) VALUES (N'PX0001', CAST(N'2017-06-18' AS Date))
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietPh__phieu__2B3F6F97] FOREIGN KEY([hoadonma])
REFERENCES [dbo].[HoaDon] ([ma])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK__ChiTietPh__phieu__2B3F6F97]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_DonViQuyDoi] FOREIGN KEY([donviquydoima])
REFERENCES [dbo].[DonViQuyDoi] ([ma])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_DonViQuyDoi]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_HangHoa] FOREIGN KEY([hanghoama])
REFERENCES [dbo].[HangHoa] ([ma])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_HangHoa]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietPh__khoma__38996AB5] FOREIGN KEY([khoma])
REFERENCES [dbo].[Kho] ([ma])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK__ChiTietPh__khoma__38996AB5]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietPh__phieu__36B12243] FOREIGN KEY([phieunhapma])
REFERENCES [dbo].[PhieuNhap] ([ma])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK__ChiTietPh__phieu__36B12243]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_DonViQuyDoi] FOREIGN KEY([donviquydoima])
REFERENCES [dbo].[DonViQuyDoi] ([ma])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_DonViQuyDoi]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_HangHoa] FOREIGN KEY([hanghoama])
REFERENCES [dbo].[HangHoa] ([ma])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_HangHoa]
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_DonViQuyDoi1] FOREIGN KEY([donviquydoima])
REFERENCES [dbo].[DonViQuyDoi] ([ma])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_DonViQuyDoi1]
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_HangHoa1] FOREIGN KEY([hanghoama])
REFERENCES [dbo].[HangHoa] ([ma])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_HangHoa1]
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_Kho] FOREIGN KEY([khoma])
REFERENCES [dbo].[Kho] ([ma])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_Kho]
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_PhieuXuat] FOREIGN KEY([phieuxuatma])
REFERENCES [dbo].[PhieuXuat] ([ma])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_PhieuXuat]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK__HangHoa__khuyenm__2FCF1A8A] FOREIGN KEY([khuyenmaima])
REFERENCES [dbo].[KhuyenMai] ([ma])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK__HangHoa__khuyenm__2FCF1A8A]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([khachhangma])
REFERENCES [dbo].[KhachHang] ([ma])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK__PhieuXuat__nhanv__286302EC] FOREIGN KEY([nhanvienma])
REFERENCES [dbo].[NhanVien] ([ma])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK__PhieuXuat__nhanv__286302EC]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaCungCap] FOREIGN KEY([nhacungcapma])
REFERENCES [dbo].[NhaCungCap] ([ma])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaCungCap]
GO
/****** Object:  StoredProcedure [dbo].[proc_deleteKhachHang]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[proc_deleteKhachHang](@ma varchar(10))
as
begin 
	if not exists (select ma from hoadon where KHma = @ma)
		 delete KhachHang where ma = @ma
end

GO
/****** Object:  StoredProcedure [dbo].[proc_deleteNV]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_deleteNV](@ma varchar(10))
as
begin 
	if not exists (select nvma from hoadon where nvma = @ma)
	 delete nhanvien where ma = @ma
end

GO
/****** Object:  StoredProcedure [dbo].[proc_insertKhachHang]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[proc_insertKhachHang] (@ten nvarchar(50), @gioitinh int, @sodienthoai varchar(20), 
@email varchar(50), @socmnd varchar(20), @diachi nvarchar(50) )
as 
begin
	insert into KhachHang (ma, ten, gioitinh, SDT, Email, socmnd, diachi)
	values (dbo.auto_ma_KhachHang(), @ten, @gioitinh, @sodienthoai, @email, @socmnd, @diachi)

end

GO
/****** Object:  StoredProcedure [dbo].[proc_insertNV]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[proc_insertNV](@ten nvarchar(50),@gioitinh int, @ngaysinh date, @sodienthoai varchar(20),
	@luong money,@phongban nvarchar(50), @diachi nvarchar(200), @matkhau varchar(20))
as
begin
	insert into NhanVien(ma, ten, gioitinh, Ngaysinh, SDT, Luong, PhongBan, DiaChi, MatKhau)
	values (dbo.auto_ma_nv(), @ten, @gioitinh,@ngaysinh,  @sodienthoai,@luong, @phongban, @diachi, @matkhau)
end

GO
/****** Object:  StoredProcedure [dbo].[proc_updateKhachHang]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_updateKhachHang](@ma varchar(20), @ten nvarchar(50), @gioitinh int,@sodienthoai varchar(20),
  @diachi nvarchar(50), @email varchar(20), @socmnd varchar(20))
 as
 begin
	
	update KhachHang set  Ten = @ten, Gioitinh = @gioitinh, 
	SDT = @sodienthoai, socmnd = @socmnd, Email = @email, diachi = @diachi
	
	 where  Ma = @ma
 end

GO
/****** Object:  StoredProcedure [dbo].[proc_updateNV]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE proc [dbo].[proc_updateNV](@ma varchar(20), @ten nvarchar(50), @gioitinh int, @ngaysinh date,@sodienthoai varchar(20),
 @luong money, @phongban nvarchar(50), @diachi nvarchar(50), @matkhau varchar(20) )
 as
 begin
	
	update NhanVien set  Ten = @ten, Gioitinh = @gioitinh, Ngaysinh = @ngaysinh, Diachi= @diachi,
	SDT = @sodienthoai, Luong = @luong, PhongBan = @phongban, MatKhau = @matkhau
	
	 where  Ma = @ma
 end

GO
/****** Object:  StoredProcedure [dbo].[procedure_insertChiTietHoaDon]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[procedure_insertChiTietHoaDon](@phieuxuatma varchar(20),@hanghoama varchar(20),@soluong int,@donvi nvarchar(20),@donviquydoima varchar(20),@dongia float)
as
begin
declare @thanhtien money,@khoma varchar(20),@hesoquydoi int,@phantramkhuyenmai float
set @hesoquydoi=(select hesoquydoi from DonViQuyDoi where ma=@donviquydoima)
set @phantramkhuyenmai=(select KhuyenMai.PhanTramKhuyenMai from KhuyenMai inner join HangHoa on HangHoa.KhuyenMaiMa=KhuyenMai.ma where KhuyenMai.ngaybatdau<GETDATE() and KhuyenMai.ngayketthuc>GETDATE() and HangHoa.ma=@hanghoama)
if(@phantramkhuyenmai!=null)
set @thanhtien=@soluong*@hesoquydoi*@dongia*0.01*(100-@phantramkhuyenmai)
else set @thanhtien=@soluong*@hesoquydoi*@dongia
begin
insert into ChiTietHoaDon(ma,hoadonma,hanghoama,soluong,donvi,donviquydoima,dongia,thanhtien)
values(dbo.auto_ma_ChiTietHoaDon(),@phieuxuatma,@hanghoama,@soluong,@donvi,@donviquydoima,@dongia,@thanhtien)
update HangHoa set soluong=soluong-@soluong where ma=@hanghoama
end
end
GO
/****** Object:  StoredProcedure [dbo].[procedure_insertChiTietPhieuNhap]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[procedure_insertChiTietPhieuNhap](@phieunhapma varchar(20),@hanghoama varchar(20),@khoma varchar(20),@soluong int,@donvi nvarchar(20),@donviquydoima varchar(20),@dongia float)
as
begin
declare @thanhtien money
set @thanhtien=@soluong*@dongia
insert into ChiTietPhieuNhap(ma,phieunhapma,hanghoama,khoma,soluong,donvi,donviquydoima,dongia,thanhtien)
values(dbo.auto_ma_ChiTietPhieuNhap(),@phieunhapma,@hanghoama,@khoma,@soluong,@donvi,@donviquydoima,@dongia,@thanhtien)
update HangHoa set soluong=soluong+@soluong where ma=@hanghoama
end

GO
/****** Object:  StoredProcedure [dbo].[procedure_insertChiTietPhieuXuat]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[procedure_insertChiTietPhieuXuat](@phieuxuatma varchar(20),@hanghoama varchar(20),@soluong int,@donvi nvarchar(20))
as
begin
declare @khoma varchar(20)
set @khoma=(select top(1) khoma from ChiTietPhieuNhap where hanghoama=@hanghoama)
insert into ChiTietPhieuXuat(ma,phieuxuatma,hanghoama,khoma,soluong,donvi)
values(dbo.auto_ma_ChiTietPhieuXuat(),@phieuxuatma,@hanghoama,@khoma,@soluong,@donvi)
end

GO
/****** Object:  StoredProcedure [dbo].[procedure_insertHoaDon]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[procedure_insertHoaDon](@khachhangma varchar(20),@nhanvienma varchar(20),@tongtien money)
as
begin
declare @diemtichluy int,@tongdiemtichluy int
set @diemtichluy=@tongtien/100
set @tongdiemtichluy=@diemtichluy+(select diemtichluy from KhachHang where ma=@khachhangma)
begin
insert into HoaDon(ma,ngay,khachhangma,nhanvienma,tongtien)
values(dbo.auto_ma_PhieuXuat(),GETDATE(),@khachhangma,@nhanvienma,@tongtien)
end
end
GO
/****** Object:  StoredProcedure [dbo].[procedure_insertPhieuNhap]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[procedure_insertPhieuNhap](@nhacungcapma varchar(20),@tongtien money)
as
begin
insert into PhieuNhap(ma,ngay,nhacungcapma,tongtien)
values(dbo.auto_ma_PhieuNhap(),GETDATE(),@nhacungcapma,@tongtien)
end
GO
/****** Object:  StoredProcedure [dbo].[procedure_insertPhieuXuat]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[procedure_insertPhieuXuat](@ma varchar(20))
as
begin
insert into PhieuXuat(ma,ngay)
values(dbo.auto_ma_PhieuXuat(),GETDATE())
end


GO
/****** Object:  StoredProcedure [dbo].[ProcTimKiemTheoDongia]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcTimKiemTheoDongia]
@dongia money
as
begin
if exists (select *from HangHoa where dongia > @dongia)
select hh.ma as [Mã hàng hóa],hh.ten as [Tên hàng hóa], hh.soluong as [Số lượng], hh.ngaysanxuat as [Ngày sản xuất],
hh.hansudung as [Hạn sử dụng], hh.noisanxuat as [Nơi sản xuất], hh.dongia as [Đơn giá],A.khoma as [Mã kho] from HangHoa hh
inner join(select hanghoama, ct.khoma from ChiTietPhieuNhap ct inner join Kho k on ct.khoma = k.ma group by ct.hanghoama,ct.khoma )as A
on A.hanghoama =hh.ma where dongia > @dongia
else
select null as [Mã hàng hóa], null as [Tên hàng hóa], null as [Số lượng], null as [Ngày sản xuất], null as [Hạn sử dụng]
,null as [Nói sản xuất],null as [Đơn giá],null as [Mã kho]
end
GO
/****** Object:  StoredProcedure [dbo].[ProcTimKiemTheoHanSuDung]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcTimKiemTheoHanSuDung]
@hansudung date
as
begin
if exists (select *from HangHoa where hansudung like @hansudung)
select hh.ma as [Mã hàng hóa],hh.ten as [Tên hàng hóa], hh.soluong as [Số lượng], hh.ngaysanxuat as [Ngày sản xuất],
hh.hansudung as [Hạn sử dụng], hh.noisanxuat as [Nơi sản xuất], hh.dongia as [Đơn giá],A.khoma as [Mã kho] from HangHoa hh
inner join(select hanghoama, ct.khoma from ChiTietPhieuNhap ct inner join Kho k on ct.khoma = k.ma group by ct.hanghoama,ct.khoma )as A
on A.hanghoama =hh.ma where hansudung like @hansudung
else
select null as [Mã hàng hóa], null as [Tên hàng hóa], null as [Số lượng], null as [Ngày sản xuất], null as [Hạn sử dụng]
,null as [Nói sản xuất],null as [Đơn giá],null as [Mã kho]
end
--6.
GO
/****** Object:  StoredProcedure [dbo].[ProcTimKiemTheoKhoMa]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[ProcTimKiemTheoKhoMa]
@khoma varchar(20)
as
begin
select hh.ma as [Mã hàng hóa],hh.ten as [Tên hàng hóa], hh.soluong as [Số lượng], hh.ngaysanxuat as [Ngày sản xuất],
hh.hansudung as [Hạn sử dụng], hh.noisanxuat as [Nơi sản xuất], hh.dongia as [Đơn giá],A.khoma as [Mã kho] from HangHoa hh
inner join(select hanghoama, ct.khoma from ChiTietPhieuNhap ct inner join Kho k on ct.khoma = k.ma group by ct.hanghoama,ct.khoma )as A
on A.hanghoama =hh.ma where A.khoma like @khoma
end
GO
/****** Object:  StoredProcedure [dbo].[ProcTimKiemTheoNoiSanXuat]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--3.
--4.

--5.

--7.
--8.
create proc [dbo].[ProcTimKiemTheoNoiSanXuat]
@noisanxuat nvarchar(30)
as
begin
if exists (select *from HangHoa where noisanxuat like '%'+@noisanxuat+'%')
select hh.ma as [Mã hàng hóa],hh.ten as [Tên hàng hóa], hh.soluong as [Số lượng], hh.ngaysanxuat as [Ngày sản xuất],
hh.hansudung as [Hạn sử dụng], hh.noisanxuat as [Nơi sản xuất], hh.dongia as [Đơn giá], A.khoma as [Mã kho] from HangHoa hh
inner join(select hanghoama, ct.khoma from ChiTietPhieuNhap ct inner join Kho k on ct.khoma = k.ma group by ct.hanghoama,ct.khoma )as A
on A.hanghoama =hh.ma where noisanxuat like '%'+@noisanxuat+'%'
else
select null as [Mã hàng hóa], null as [Tên hàng hóa], null as [Số lượng], null as [Ngày sản xuất], null as [Hạn sử dụng]
,null as [Nói sản xuất],null as [Đơn giá],null as [Mã kho]
end
GO
/****** Object:  StoredProcedure [dbo].[ProcTimKiemTheoNgaySanXuat]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[ProcTimKiemTheoNgaySanXuat]
@ngaysanxuat date
as
begin
if exists (select *from HangHoa where ngaysanxuat like @ngaysanxuat)
select hh.ma as [Mã hàng hóa],hh.ten as [Tên hàng hóa], hh.soluong as [Số lượng], hh.ngaysanxuat as [Ngày sản xuất],
hh.hansudung as [Hạn sử dụng], hh.noisanxuat as [Nơi sản xuất], hh.dongia as [Đơn giá],A.khoma as [Mã kho] from HangHoa hh
inner join(select hanghoama, ct.khoma from ChiTietPhieuNhap ct inner join Kho k on ct.khoma = k.ma group by ct.hanghoama,ct.khoma )as A
on A.hanghoama =hh.ma where ngaysanxuat like @ngaysanxuat
else
select null as [Mã hàng hóa], null as [Tên hàng hóa], null as [Số lượng], null as [Ngày sản xuất], null as [Hạn sử dụng]
,null as [Nói sản xuất],null as [Đơn giá],null as [Mã kho]
end
GO
/****** Object:  StoredProcedure [dbo].[ProcTimKiemTheoSoLuong]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[ProcTimKiemTheoSoLuong]
@soluong int
as
begin
if exists (select *from HangHoa where soluong >= @soluong)
select hh.ma as [Mã hàng hóa],hh.ten as [Tên hàng hóa], hh.soluong as [Số lượng], hh.ngaysanxuat as [Ngày sản xuất],
hh.hansudung as [Hạn sử dụng], hh.noisanxuat as [Nơi sản xuất], hh.dongia as [Đơn giá], A.khoma as [Mã kho] from HangHoa hh
inner join(select hanghoama, ct.khoma from ChiTietPhieuNhap ct inner join Kho k on ct.khoma = k.ma group by ct.hanghoama,ct.khoma )as A
on A.hanghoama =hh.ma
where soluong >= @soluong
else
select null as [Mã hàng hóa], null as [Tên hàng hóa], null as [Số lượng], null as [Ngày sản xuất], null as [Hạn sử dụng]
,null as [Nói sản xuất],null as [Đơn giá],null as [Mã kho]
end
GO
/****** Object:  StoredProcedure [dbo].[ProcTimKiemTheoTen]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[ProcTimKiemTheoTen]
@ten nvarchar(30)
as
begin
if exists (select *from HangHoa where ten like '%'+@ten+'%')
select hh.ma as [Mã hàng hóa],hh.ten as [Tên hàng hóa], hh.soluong as [Số lượng], hh.ngaysanxuat as [Ngày sản xuất],
hh.hansudung as [Hạn sử dụng], hh.noisanxuat as [Nơi sản xuất], hh.dongia as [Đơn giá], A.khoma as [Mã kho] from HangHoa hh
inner join
(select hanghoama, ct.khoma from ChiTietPhieuNhap ct inner join Kho k on ct.khoma = k.ma group by ct.hanghoama, ct.khoma )as A
on A.hanghoama =hh.ma
where ten like '%'+@ten+'%'
else
select null as [Mã hàng hóa], null as [Tên hàng hóa], null as [Số lượng], null as [Ngày sản xuất], null as [Hạn sử dụng]
,null as [Nói sản xuất],null as [Đơn giá],null as [Mã kho]
end
GO
/****** Object:  StoredProcedure [dbo].[ThemVaoChiTietPhieuNhap]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[ThemVaoChiTietPhieuNhap]
@hanghoama varchar(20),
@soluong int,
@dongia float
as 
begin 
declare @phieunhapma varchar(20)
select @phieunhapma = (select Max(ma) from PhieuNhap)
insert into ChiTietPhieuNhap(ma,phieunhapma,hanghoama,soluong,dongia,thanhtien) values(dbo.auto_maChiTietPhieuNhap(),@phieunhapma,@hanghoama,@soluong,@dongia,@soluong*@dongia)
end
GO
/****** Object:  StoredProcedure [dbo].[ThongKeHangHoaBanRa]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThongKeHangHoaBanRa]
@khoma varchar(20)
as
begin
select ct.hanghoama as [Mã hàng hóa], ct.dongia as [Đơn giá], ct.soluong as [Số lượng], ct.phieuxuatma as [Mã phiếu xuất],ct.thanhtien as [Thành tiền] from ChiTietPhieuXuat ct inner join
Kho k on ct.khoma = k.ma

where ct.khoma = @khoma
end
GO
/****** Object:  StoredProcedure [dbo].[ThongKeHangHoaNhapVao]    Script Date: 18/06/2017 4:49:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[ThongKeHangHoaNhapVao]
@khoma varchar(20)
as
begin
select ct.hanghoama as [Mã hàng hóa], ct.dongia as [Đơn giá], ct.soluong as [Số lượng],ct.phieunhapma as [Mã phiếu nhập], ct.thanhtien as [Thành tiền] from ChiTietPhieuNhap ct inner join
Kho k on ct.khoma = k.ma

where ct.khoma = @khoma
end
GO
USE [master]
GO
ALTER DATABASE [BanHangSieuThi] SET  READ_WRITE 
GO
