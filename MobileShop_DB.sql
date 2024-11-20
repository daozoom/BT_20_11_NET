create database MobileShop
go

use MobileShop
go

-- Sản phẩm (id, tenSP, gia, hangSX)
create table SanPham
(
	id int identity primary key,
	tenSP nvarchar(100) not null,
	gia float not null,
	hangSX nvarchar(100) not null
)
go

-- Khách hàng (id, tenKH, diachi, sdt)
create table KhachHang
(
	id int identity primary key,
	tenKH nvarchar(100) not null,
	diachi nvarchar(100) not null,
	sdt nvarchar(10) not null
)
go

-- Đơn hàng (id, khachhangid, sanphamid, soluong, ngaymua)
create table DonHang
(
	id int identity primary key,
	soluong int not null,
	ngaymua date not null,

	foreign key (khachhangid) references dbo.KhachHang(id),
	foreign key (sanphamid) references dbo.SanPham(id)
)
go

-- Người dùng(id,tendangnhap,matkhau)
create table NguoiDung
(
	id int identity primary key,
	tendangnhap nvarchar(100) not null,
	matkhau nvarchar(100) not null
)
go