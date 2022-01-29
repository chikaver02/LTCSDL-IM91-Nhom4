use master
go

Create database QuayThuoc
go

use QuayThuoc
go


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUBAN](
	[IDDongBan] [nchar](10) NOT NULL,
	[MaNCC] [nchar](10) NOT NULL,
	[LoaiThuocBan] [nvarchar](30) NOT NULL,
	[TongBan] [int] NOT NULL,
	[DonGiaBan] [money] NOT NULL,
	[TongTien] [money] NOT NULL,
 CONSTRAINT [PK_DONGPHIEUBAN] PRIMARY KEY CLUSTERED 
(
	[IDDongBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETPHIEUMUA]    Script Date: 12/26/2021 6:03:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUMUA](
	[IDDongMua] [nchar](10) NOT NULL,
	[MaKH] [nchar](10) NOT NULL,
	[LoaiThuocMua] [nchar](30) NOT NULL,
	[TongMua] [int] NOT NULL,
	[DonGiaMua] [money] NOT NULL,
	[ThanhTien] [money] NOT NULL,
 CONSTRAINT [PK_DONGPHIEUMUA] PRIMARY KEY CLUSTERED 
(
	[IDDongMua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 12/26/2021 6:03:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANGNHAP](
	[IDName] [nchar](10) NOT NULL,
	[Ten] [nchar](30) NOT NULL,
	[MatKhau] [nchar](30) NOT NULL,
 CONSTRAINT [PK_DANGNHAP] PRIMARY KEY CLUSTERED 
(
	[IDName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/26/2021 6:03:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[SoDT] [char](10) NOT NULL,
	[BenhAn] [nvarchar](20) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 12/26/2021 6:03:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNCC] [nchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[SoDienThoai] [char](10) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUBAN]    Script Date: 12/26/2021 6:03:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUBAN](
	[MaPhieuBan] [nchar](10) NOT NULL,
	[MaThuoc] [nchar](10) NOT NULL,
	[MaNCC] [nchar](10) NOT NULL,
	[SoLuongBan] [int] NOT NULL,
	[GiaTien] [money] NOT NULL,
 CONSTRAINT [PK_PHIEUBAN] PRIMARY KEY CLUSTERED 
(
	[MaPhieuBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUMUA]    Script Date: 12/26/2021 6:03:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMUA](
	[MaPhieuMua] [nchar](10) NOT NULL,
	[MaThuoc] [nchar](10) NOT NULL,
	[MaKH] [nchar](10) NOT NULL,
	[SoLuongMua] [int] NOT NULL,
	[DonGia] [money] NOT NULL,
 CONSTRAINT [PK_PHIEUMUA] PRIMARY KEY CLUSTERED 
(
	[MaPhieuMua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THUOC]    Script Date: 12/26/2021 6:03:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUOC](
	[MaThuoc] [nchar](10) NOT NULL,
	[MaNCC] [nchar](10) NOT NULL,
	[TenThuoc] [nvarchar](50) NOT NULL,
	[NamSanXuat] [datetime] NOT NULL,
	[HanSuDung] [datetime] NOT NULL,
 CONSTRAINT [PK_THUOC] PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB01     ', N'NCC01     ', N'Đau bụng', 20, 1000.0000, 20000.0000)
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB02     ', N'NCC10     ', N'Viêm họng', 50, 2500.0000, 125000.0000)
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB03     ', N'NCC09     ', N'Đau đầu', 10, 1000.0000, 10000.0000)
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB04     ', N'NCC02     ', N'Sốt rét', 10, 40000.0000, 400000.0000)
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB05     ', N'NCC03     ', N'Bệnh tả', 5, 2000.0000, 10000.0000)
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB06     ', N'NCC06     ', N'Bạch hầu', 6, 2700.0000, 16200.0000)
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB07     ', N'NCC07     ', N'Ho gà', 14, 6300.0000, 88200.0000)
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB08     ', N'NCC04     ', N'Lao', 9, 3600.0000, 32400.0000)
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB09     ', N'NCC05     ', N'Viêm dạ dày', 70, 2000.0000, 140000.0000)
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB10     ', N'NCC08     ', N'Sán lá gan', 7, 24000.0000, 168000.0000)
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB11     ', N'NCC03     ', N'Bệnh lậu', 12, 1500.0000, 18000.0000)
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB12     ', N'NCC09     ', N'Thủy đậu', 8, 21000.0000, 168000.0000)
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB13     ', N'NCC07     ', N'Ho', 90, 1200.0000, 108000.0000)
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB14     ', N'NCC10     ', N'Bệnh phong', 4, 30000.0000, 120000.0000)
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB15     ', N'NCC07     ', N'Sổ mũi', 20, 1100.0000, 22000.0000)
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB16     ', N'NCC01     ', N'Mắt hột', 7, 2900.0000, 20300.0000)
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB17     ', N'NCC05     ', N'Sán dây', 14, 9000.0000, 126000.0000)
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB18     ', N'NCC08     ', N'Uốn ván', 8, 3000.0000, 24000.0000)
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB19     ', N'NCC09     ', N'Bệnh cúm', 20, 2600.0000, 52000.0000)
INSERT [dbo].[CHITIETPHIEUBAN] ([IDDongBan], [MaNCC], [LoaiThuocBan], [TongBan], [DonGiaBan], [TongTien]) VALUES (N'DPB20     ', N'NCC04     ', N'Bệnh dại', 5, 7000.0000, 35000.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM01     ', N'KH10      ', N'Sán lá gan                    ', 10, 40000.0000, 400000.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM02     ', N'KH07      ', N'Bạch hầu                      ', 8, 4000.0000, 32000.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM03     ', N'KH19      ', N'Uốn ván                       ', 10, 7000.0000, 70000.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM04     ', N'KH11      ', N'Bệnh lậu                      ', 15, 4000.0000, 60000.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM05     ', N'KH01      ', N'Đau đầu                       ', 12, 3500.0000, 42000.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM06     ', N'KH05      ', N'Ho gà                         ', 18, 9000.0000, 162000.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM07     ', N'KH09      ', N'Viêm dạ dày                   ', 72, 4000.0000, 288000.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM08     ', N'KH02      ', N'Đau bụng                      ', 22, 2000.0000, 44000.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM09     ', N'KH12      ', N'Thủy đậu                      ', 10, 30000.0000, 300000.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM10     ', N'KH20      ', N'Bệnh dại                      ', 7, 10000.0000, 70000.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM11     ', N'KH08      ', N'Lao                           ', 10, 5000.0000, 50000.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM12     ', N'KH14      ', N'Bệnh phong                    ', 7, 38000.0000, 266000.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM13     ', N'KH06      ', N'Bệnh tả                       ', 8, 5000.0000, 40000.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM14     ', N'KH18      ', N'Bệnh cúm                      ', 22, 5100.0000, 112200.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM15     ', N'KH15      ', N'Sổ mũi                        ', 25, 3000.0000, 75000.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM16     ', N'KH03      ', N'Viêm họng                     ', 52, 5000.0000, 260000.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM17     ', N'KH17      ', N'Sán dây                       ', 16, 12000.0000, 192000.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM18     ', N'KH16      ', N'Mắt hột                       ', 10, 5500.0000, 55000.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM19     ', N'KH13      ', N'Ho                            ', 95, 3000.0000, 285000.0000)
INSERT [dbo].[CHITIETPHIEUMUA] ([IDDongMua], [MaKH], [LoaiThuocMua], [TongMua], [DonGiaMua], [ThanhTien]) VALUES (N'DPM20     ', N'KH04      ', N'Sốt rét                       ', 12, 49000.0000, 588000.0000)
INSERT [dbo].[DANGNHAP] ([IDName], [Ten], [MatKhau]) VALUES (N'1         ', N'ngan                          ', N'123456                        ')
INSERT [dbo].[DANGNHAP] ([IDName], [Ten], [MatKhau]) VALUES (N'2         ', N'tuyen                         ', N'123456                        ')
INSERT [dbo].[DANGNHAP] ([IDName], [Ten], [MatKhau]) VALUES (N'3         ', N'thy                           ', N'123456                        ')
INSERT [dbo].[DANGNHAP] ([IDName], [Ten], [MatKhau]) VALUES (N'4         ', N'my                            ', N'123456                        ')
INSERT [dbo].[DANGNHAP] ([IDName], [Ten], [MatKhau]) VALUES (N'5         ', N'chika                         ', N'123456                        ')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH01      ', N'Đinh Thu Thảo', CAST(N'2001-11-20 00:00:00.000' AS DateTime), N'100 Phạm Văn Đồng', N'0372145   ', N'Đau đầu')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH02      ', N'Nguyễn Thị Mai', CAST(N'2001-10-06 00:00:00.000' AS DateTime), N'27 Trương Đăng Quế', N'0367851   ', N'Đau bụng')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH03      ', N'Lê Minh Hy', CAST(N'1984-02-24 00:00:00.000' AS DateTime), N'96 Hoa Sứ', N'0178926   ', N'Rát họng')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH04      ', N'Hồ Quang Minh', CAST(N'1998-01-11 00:00:00.000' AS DateTime), N'77 Nguyễn Huệ', N'0213586   ', N'Sốt nặng')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH05      ', N'Trần Nhã Thiên', CAST(N'2000-07-06 00:00:00.000' AS DateTime), N'21 Quang Trung', N'0785123   ', N'Ho gà')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH06      ', N'Lê Ánh', CAST(N'1999-10-25 00:00:00.000' AS DateTime), N'11 Nguyễn Kiệm', N'0425612   ', N'Bệnh tả')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH07      ', N'Mai Bảo Nhân', CAST(N'1984-08-08 00:00:00.000' AS DateTime), N'236 Điện Biên Phủ', N'0569817   ', N'Bạch hầu')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH08      ', N'Nguyễn Văn Hóa', CAST(N'1977-02-09 00:00:00.000' AS DateTime), N'67 Lê Văn Chí', N'0985123   ', N'Bệnh lao')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH09      ', N'Đinh Hoài Thuận', CAST(N'1994-07-13 00:00:00.000' AS DateTime), N'58 Đoàn Văn Bơ', N'0326581   ', N'Viêm loét dạ dày')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH10      ', N'Lý Hay', CAST(N'1978-12-30 00:00:00.000' AS DateTime), N'112 Phạm Văn Hai', N'0589127   ', N'Sán lá gan')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH11      ', N'Hà Đinh Vỹ', CAST(N'1983-06-18 00:00:00.000' AS DateTime), N'218 Nguyễn Oanh', N'0834561   ', N'Bệnh lậu')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH12      ', N'Mai Thị Hồng', CAST(N'2000-05-27 00:00:00.000' AS DateTime), N'43 Trường Chinh', N'0359871   ', N'Thủy đậu')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH13      ', N'Lê Thủy Tiên', CAST(N'1997-07-07 00:00:00.000' AS DateTime), N'197 Đinh Tiên Hoàng', N'0315987   ', N'Ho thường')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH14      ', N'Hồ Vĩnh Thạnh', CAST(N'1974-05-17 00:00:00.000' AS DateTime), N'185 Phạm Văn Đồng', N'0228741   ', N'Bệnh phong')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH15      ', N'Mai Văn Mười', CAST(N'2004-05-07 00:00:00.000' AS DateTime), N'216 Nguyễn Đình Chiểu', N'0278195   ', N'Sổ mũi')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH16      ', N'Đặng Lê Hiền', CAST(N'2003-12-08 00:00:00.000' AS DateTime), N'84 Lê Lợi', N'0476504   ', N'Bị hột ở mắt')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH17      ', N'Trần Quang Pháp', CAST(N'2000-04-10 00:00:00.000' AS DateTime), N'470 Đoàn Văn Bơ', N'072309    ', N'Sán dây')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH18      ', N'Nguyễn Phúc An', CAST(N'1989-07-03 00:00:00.000' AS DateTime), N'99 Võ Văn Tần', N'0932071   ', N'Bệnh cúm')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH19      ', N'Lương Kiều Ny', CAST(N'2003-03-04 00:00:00.000' AS DateTime), N'49 Hồ Hảo Hớn', N'0942574   ', N'Uốn ván')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [SoDT], [BenhAn]) VALUES (N'KH20      ', N'Hà Uyên Thảo', CAST(N'1968-06-01 00:00:00.000' AS DateTime), N'07 Mai Thị Lựu', N'0552103   ', N'Bệnh dại')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [SoDienThoai], [DiaChi]) VALUES (N'NCC01     ', N'Mediphar', N'022815    ', N'Hồ Chí Minh')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [SoDienThoai], [DiaChi]) VALUES (N'NCC02     ', N'Traphaco', N'032547    ', N'Hưng Yên')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [SoDienThoai], [DiaChi]) VALUES (N'NCC03     ', N'Dược phẩm Hà Tây', N'025879    ', N'Hà Nội')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [SoDienThoai], [DiaChi]) VALUES (N'NCC04     ', N'Dược Hậu Giang', N'021514    ', N'Hậu Giang')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [SoDienThoai], [DiaChi]) VALUES (N'NCC05     ', N'Domesco', N'045871    ', N'Đồng Tháp')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [SoDienThoai], [DiaChi]) VALUES (N'NCC06     ', N'Sao Thái Dương', N'098517    ', N'Hà Nội')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [SoDienThoai], [DiaChi]) VALUES (N'NCC07     ', N'Pymepharco', N'041249    ', N'Hồ Chí Minh')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [SoDienThoai], [DiaChi]) VALUES (N'NCC08     ', N'ImexPharm', N'054894    ', N'Đồng Tháp')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [SoDienThoai], [DiaChi]) VALUES (N'NCC09     ', N'Codupha', N'097201    ', N'Hồ Chí Minh')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [SoDienThoai], [DiaChi]) VALUES (N'NCC10     ', N'Vimedimex', N'012657    ', N'Hà Nội')
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB01     ', N'MT01      ', N'NCC10     ', 50, 375000.0000)
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB02     ', N'MT02      ', N'NCC10     ', 70, 52500.0000)
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB03     ', N'MT03      ', N'NCC04     ', 200, 800000.0000)
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB04     ', N'MT04      ', N'NCC04     ', 100, 40000.0000)
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB05     ', N'MT05      ', N'NCC09     ', 400, 1050000.0000)
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB06     ', N'MT06      ', N'NCC09     ', 500, 650000.0000)
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB07     ', N'MT07      ', N'NCC08     ', 50, 175000.0000)
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB08     ', N'MT08      ', N'NCC08     ', 30, 120000.0000)
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB09     ', N'MT09      ', N'NCC05     ', 1000, 2000000.0000)
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB10     ', N'MT10      ', N'NCC05     ', 100, 1500000.0000)
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB11     ', N'MT11      ', N'NCC01     ', 300, 700000.0000)
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB12     ', N'MT12      ', N'NCC01     ', 80, 240000.0000)
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB13     ', N'MT13      ', N'NCC07     ', 100, 650000.0000)
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB14     ', N'MT14      ', N'NCC07     ', 700, 770000.0000)
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB15     ', N'MT15      ', N'NCC03     ', 20, 42000.0000)
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB16     ', N'MT16      ', N'NCC06     ', 10, 30000.0000)
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB17     ', N'MT17      ', N'NCC03     ', 50, 75000.0000)
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB18     ', N'MT18      ', N'NCC02     ', 500, 20000000.0000)
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB19     ', N'MT19      ', N'NCC10     ', 400, 1000000.0000)
INSERT [dbo].[PHIEUBAN] ([MaPhieuBan], [MaThuoc], [MaNCC], [SoLuongBan], [GiaTien]) VALUES (N'SPB20     ', N'MT20      ', N'NCC10     ', 10, 300000.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM01     ', N'MT01      ', N'KH03      ', 10, 50000.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM02     ', N'MT02      ', N'KH04      ', 5, 190000.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM03     ', N'MT03      ', N'KH20      ', 5, 50000.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM04     ', N'MT04      ', N'KH08      ', 7, 35000.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM05     ', N'MT05      ', N'KH01      ', 10, 35000.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM06     ', N'MT06      ', N'KH12      ', 5, 150000.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM07     ', N'MT07      ', N'KH10      ', 6, 240000.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM08     ', N'MT08      ', N'KH19      ', 7, 49000.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM09     ', N'MT09      ', N'KH09      ', 50, 200000.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM10     ', N'MT10      ', N'KH17      ', 10, 120000.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM11     ', N'MT11      ', N'KH02      ', 12, 24000.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM12     ', N'MT12      ', N'KH16      ', 7, 38500.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM13     ', N'MT13      ', N'KH05      ', 10, 90000.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM14     ', N'MT14      ', N'KH15      ', 20, 60000.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM15     ', N'MT15      ', N'KH11      ', 12, 48000.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM16     ', N'MT16      ', N'KH07      ', 4, 16000.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM17     ', N'MT17      ', N'KH06      ', 6, 30000.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM18     ', N'MT18      ', N'KH04      ', 8, 392000.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM19     ', N'MT19      ', N'KH18      ', 19, 96900.0000)
INSERT [dbo].[PHIEUMUA] ([MaPhieuMua], [MaThuoc], [MaKH], [SoLuongMua], [DonGia]) VALUES (N'SPM20     ', N'MT20      ', N'KH13      ', 81, 243000.0000)
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT01      ', N'NCC10     ', N'Eurosca', CAST(N'2019-12-01 00:00:00.000' AS DateTime), CAST(N'2022-12-01 00:00:00.000' AS DateTime))
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT02      ', N'NCC10     ', N'Rifampin Capsule', CAST(N'2020-01-01 00:00:00.000' AS DateTime), CAST(N'2022-12-01 00:00:00.000' AS DateTime))
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT03      ', N'NCC04     ', N'Speeda', CAST(N'2018-01-01 00:00:00.000' AS DateTime), CAST(N'2020-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT04      ', N'NCC04     ', N'Isoniazid', CAST(N'2020-07-01 00:00:00.000' AS DateTime), CAST(N'2023-07-01 00:00:00.000' AS DateTime))
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT05      ', N'NCC09     ', N'Tamiflu', CAST(N'2020-03-01 00:00:00.000' AS DateTime), CAST(N'2023-03-01 00:00:00.000' AS DateTime))
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT06      ', N'NCC09     ', N'Acyclovir', CAST(N'2017-05-01 00:00:00.000' AS DateTime), CAST(N'2020-05-01 00:00:00.000' AS DateTime))
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT07      ', N'NCC08     ', N'Diazepam', CAST(N'2015-07-01 00:00:00.000' AS DateTime), CAST(N'2018-07-01 00:00:00.000' AS DateTime))
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT08      ', N'NCC08     ', N'Praziquantel', CAST(N'2020-08-30 00:00:00.000' AS DateTime), CAST(N'2023-08-30 00:00:00.000' AS DateTime))
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT09      ', N'NCC05     ', N'Albendazole', CAST(N'2019-11-01 00:00:00.000' AS DateTime), CAST(N'2022-11-01 00:00:00.000' AS DateTime))
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT10      ', N'NCC05     ', N'Phosphalugel', CAST(N'2019-12-01 00:00:00.000' AS DateTime), CAST(N'2022-12-01 00:00:00.000' AS DateTime))
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT11      ', N'NCC01     ', N'Erythromycin', CAST(N'2017-10-01 00:00:00.000' AS DateTime), CAST(N'2020-10-01 00:00:00.000' AS DateTime))
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT12      ', N'NCC01     ', N'Bifina', CAST(N'2016-09-01 00:00:00.000' AS DateTime), CAST(N'2019-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT13      ', N'NCC07     ', N'Clorpheniramin', CAST(N'2017-08-07 00:00:00.000' AS DateTime), CAST(N'2020-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT14      ', N'NCC07     ', N'Histamin ', CAST(N'2015-05-21 00:00:00.000' AS DateTime), CAST(N'2018-05-21 00:00:00.000' AS DateTime))
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT15      ', N'NCC03     ', N'Ciprofloxacin', CAST(N'2015-08-30 00:00:00.000' AS DateTime), CAST(N'2018-08-30 00:00:00.000' AS DateTime))
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT16      ', N'NCC06     ', N'Penicilline', CAST(N'2019-06-25 00:00:00.000' AS DateTime), CAST(N'2022-06-25 00:00:00.000' AS DateTime))
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT17      ', N'NCC03     ', N'Doxycycline', CAST(N'2018-07-01 00:00:00.000' AS DateTime), CAST(N'2021-07-01 00:00:00.000' AS DateTime))
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT18      ', N'NCC02     ', N'Paracetamol ', CAST(N'2018-09-14 00:00:00.000' AS DateTime), CAST(N'2021-09-14 00:00:00.000' AS DateTime))
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT19      ', N'NCC09     ', N'Quercetin', CAST(N'2015-07-03 00:00:00.000' AS DateTime), CAST(N'2018-07-03 00:00:00.000' AS DateTime))
INSERT [dbo].[THUOC] ([MaThuoc], [MaNCC], [TenThuoc], [NamSanXuat], [HanSuDung]) VALUES (N'MT20      ', N'NCC07     ', N'Amoxicillin', CAST(N'2016-04-01 00:00:00.000' AS DateTime), CAST(N'2019-04-01 00:00:00.000' AS DateTime))
ALTER TABLE [dbo].[CHITIETPHIEUBAN]  WITH CHECK ADD  CONSTRAINT [FK_DONGPHIEUBAN_NHACUNGCAP] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([MaNCC])
GO
ALTER TABLE [dbo].[CHITIETPHIEUBAN] CHECK CONSTRAINT [FK_DONGPHIEUBAN_NHACUNGCAP]
GO
ALTER TABLE [dbo].[CHITIETPHIEUMUA]  WITH CHECK ADD  CONSTRAINT [FK_DONGPHIEUMUA_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[CHITIETPHIEUMUA] CHECK CONSTRAINT [FK_DONGPHIEUMUA_KHACHHANG]
GO
ALTER TABLE [dbo].[PHIEUBAN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUBAN_NHACUNGCAP] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([MaNCC])
GO
ALTER TABLE [dbo].[PHIEUBAN] CHECK CONSTRAINT [FK_PHIEUBAN_NHACUNGCAP]
GO
ALTER TABLE [dbo].[PHIEUBAN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUBAN_THUOC] FOREIGN KEY([MaThuoc])
REFERENCES [dbo].[THUOC] ([MaThuoc])
GO
ALTER TABLE [dbo].[PHIEUBAN] CHECK CONSTRAINT [FK_PHIEUBAN_THUOC]
GO
ALTER TABLE [dbo].[PHIEUMUA]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUA_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[PHIEUMUA] CHECK CONSTRAINT [FK_PHIEUMUA_KHACHHANG]
GO
ALTER TABLE [dbo].[PHIEUMUA]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUA_THUOC] FOREIGN KEY([MaThuoc])
REFERENCES [dbo].[THUOC] ([MaThuoc])
GO
ALTER TABLE [dbo].[PHIEUMUA] CHECK CONSTRAINT [FK_PHIEUMUA_THUOC]
GO
ALTER TABLE [dbo].[THUOC]  WITH CHECK ADD  CONSTRAINT [FK_THUOC_NHACUNGCAP] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([MaNCC])
GO
ALTER TABLE [dbo].[THUOC] CHECK CONSTRAINT [FK_THUOC_NHACUNGCAP]
GO
USE [master]
GO
ALTER DATABASE [QuayThuoc] SET  READ_WRITE 
GO
