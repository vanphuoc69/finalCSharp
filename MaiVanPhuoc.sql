USE [MaiVanPhuoccDB]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 6/17/2021 10:31:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] NOT NULL,
	[Name] [nvarchar](250) NULL,
	[Description] [nvarchar](250) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 6/17/2021 10:31:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] NOT NULL,
	[CategoryID] [int] NULL,
	[Name] [nvarchar](250) NULL,
	[UnitCost] [decimal](18, 0) NULL,
	[Quantity] [int] NULL,
	[Image] [nvarchar](250) NULL,
	[Description] [nvarchar](500) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserAccount]    Script Date: 6/17/2021 10:31:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAccount](
	[ID] [int] NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](32) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_UserAccount] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (1, N'Laptop', NULL)
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (2, N'Loa', NULL)
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (3, N'CPU', NULL)
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (4, N'Bàn phím', NULL)
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (5, N'Chuột', NULL)
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (6, N'Màn hình', NULL)
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (7, N'VGA', NULL)
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (8, N'Mainboard', NULL)
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (9, N'RAM', NULL)
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (10, N'Ổ Cứng', NULL)
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (11, N'PSU', NULL)
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (12, N'Tản nhiệt', NULL)
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (13, N'Case', NULL)
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (14, N'Webcam', NULL)
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (15, N'Tai nghe', NULL)
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (16, N'Máy in', NULL)
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (17, N'Máy scan', NULL)
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (18, N'Lót chuột', NULL)
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (19, N'Máy chiếu', NULL)
INSERT [dbo].[Category] ([CategoryID], [Name], [Description]) VALUES (20, N'Máy chơi game', NULL)
INSERT [dbo].[Product] ([ID], [CategoryID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status]) VALUES (30, 1, N'Laptop ASUS ROG Strix Scar 15 G533QR', CAST(25000000 AS Decimal(18, 0)), 10, N'https://lh3.googleusercontent.com/LFgX6gRnHYEBcxikfBN-QlQF2vpQY7XZi623LEUyJO5IXTaeDtLHUitIVHAPwLmHbeski-Q9jVVwN7E8jUy1e1LexvdDocQ=w500-rw', NULL, 1)
INSERT [dbo].[Product] ([ID], [CategoryID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status]) VALUES (31, 2, N'Loa Harman', CAST(4250000 AS Decimal(18, 0)), 70, N'https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcQiKH27yRfNhPYfvOtt_bqRWdMrQfNTc80eh0IVJT3L3XnBUKmyskN8ZAebJPeRcAg3q9szt4Hd3FY&usqp=CAc', NULL, 1)
INSERT [dbo].[Product] ([ID], [CategoryID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status]) VALUES (32, 3, N'AMD Ryzen5', CAST(9600000 AS Decimal(18, 0)), 15, N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjKDr43e3_7sib9uu7rR2iDqnb1oe-kHm6uQ&usqp=CAU', NULL, 1)
INSERT [dbo].[Product] ([ID], [CategoryID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status]) VALUES (33, 4, N'Magic Keyboard', CAST(5600000 AS Decimal(18, 0)), 59, N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRu3-IY8V8qUJXPiH0Ujel2F72y9fFc-nQkhO8x3zgff1P6mXEitpaHp_VBeF4b2Y3GQqnuu5U&usqp=CAc', NULL, 1)
INSERT [dbo].[Product] ([ID], [CategoryID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status]) VALUES (34, 12, N'Quạt CPU Deepcool Gammaxx', CAST(850000 AS Decimal(18, 0)), 125, N'https://lh3.googleusercontent.com/dvC8oTCx8k5B0lNLHIqzGLp55xrKtVHbNocxkpUcm2JWgH-v5tRYdT9POAa_tJ1nhSBsZVJflGYdQ3xrjz9mXUJnh60P8ejI=w500-rw', NULL, 1)
INSERT [dbo].[Product] ([ID], [CategoryID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status]) VALUES (35, 9, N'RAM desktop G.SKILL Trident Z RGB', CAST(3490000 AS Decimal(18, 0)), 50, N'https://lh3.googleusercontent.com/z8lLdkP8e2JIM-uN-Pqa1MYFmZNZCh7QsMDVBg2JeebUMuOCGVqlpj64u5pUKv-7PsAo2zRmRhukX6BjyMnv7L1cxGslIoVz=w500-rw', NULL, 1)
INSERT [dbo].[Product] ([ID], [CategoryID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status]) VALUES (36, 7, N'Card màn hình ASUS ROG STRIX RTX3080Ti', CAST(53270000 AS Decimal(18, 0)), 18, N'https://lh3.googleusercontent.com/oK7iefYmKzNdTQ7nYqNtC86TkW77d9fm6sBwtrLt6Hl6vYY4ImLadbwemyT4ed31_5J-NKmSJi4Hb6xQVx5Rs3z0FqTSnRBgYQ=w500-rw', NULL, 1)
INSERT [dbo].[Product] ([ID], [CategoryID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status]) VALUES (37, 13, N'Case MIK DT03 Red Luffy', CAST(730000 AS Decimal(18, 0)), 1, N'https://lh3.googleusercontent.com/Z9ta7-nH8kEyHMqP73Mu5GCmKEiOxAnosxbueM5OV9mPq5lBg6putFfOcVbp7Fi289U6z9vmuK3KT4H_NhdbbKUmc6tF8Vk=w500-rw', NULL, 1)
INSERT [dbo].[Product] ([ID], [CategoryID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status]) VALUES (38, 5, N'Chuột gaming Logitech G502 HERO', CAST(975000 AS Decimal(18, 0)), 250, N'https://lh3.googleusercontent.com/Iz12vfXqgTg5pi9bet4qclbtbwTB3TFIValC8W2pvmlGHnCZ937GjdJVnfARkopEtmAfJBNvDzpIC-wNPaggiyrmcdpcogD3=w500-rw', NULL, 1)
INSERT [dbo].[Product] ([ID], [CategoryID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status]) VALUES (39, 19, N'Máy chiếu Epson EH-TW750', CAST(26790000 AS Decimal(18, 0)), 3, N'https://lh3.googleusercontent.com/rEJIBA0XvRrJ3-Vu_rwmSigYIrDsoNCztsP1VIQkC8kHRH5YCBmloMS_j0jD79m9PLcpPQ1yy930mt09olePP62Hevz5zN12=w500-rw', NULL, 1)
INSERT [dbo].[Product] ([ID], [CategoryID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status]) VALUES (40, 20, N'Máy chơi game Playstation PS4 Pro 1TB', CAST(12090000 AS Decimal(18, 0)), 20, N'https://lh3.googleusercontent.com/plQrAEm9vExkXRR2uARN0rqlPEBX3Um3a2hUASzdGOCM2u_bdIRdPZ_X_ew4EfOyGCvTJW224Vf6Pd-ZXg=w500-rw', NULL, 1)
INSERT [dbo].[Product] ([ID], [CategoryID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status]) VALUES (41, 10, N'SSD Samsung 980 Pro 2TB M2 PCIe 4.0', CAST(13000000 AS Decimal(18, 0)), 60, N'https://lh3.googleusercontent.com/PdLO602LT2XwNlHytxJz7OM48SYybcRYrMaC8OwQQD0Y7NRYdVOHxprcHY4fRsLzeea9iFTPoBKqnx_yVWUvCcAiwLuS3o0=w500-rw', NULL, 1)
INSERT [dbo].[Product] ([ID], [CategoryID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status]) VALUES (42, 8, N'Mainboard MSI Z590 GAMING CARBON WIFI', CAST(10500000 AS Decimal(18, 0)), 50, N'https://lh3.googleusercontent.com/A-jU96rUx6c-754p6at5Pr16HeHMk2pCxScRMrvKJWYXqAAPa2p3QP58uD_MHievCfvt3EBXmb57ZfpPiYGPL8x_RnVrwx-Fkw=w500-rw', NULL, 1)
INSERT [dbo].[Product] ([ID], [CategoryID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status]) VALUES (43, 11, N'Nguồn máy tính GIGABYTE GP-P1000GM - 1000W', CAST(4450000 AS Decimal(18, 0)), 36, N'https://lh3.googleusercontent.com/mo8Ay8Wvzvfa1k8uECYSIs3stufamykH_HShHHQzhD30dU9k3VWP0uBFldd0apAxwwpUWznVSL31Nb4UM-CWKUYUP62J0Cau=w500-rw', NULL, 1)
INSERT [dbo].[Product] ([ID], [CategoryID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status]) VALUES (44, 14, N'Webcam Rapoo C280', CAST(1140000 AS Decimal(18, 0)), 1, N'https://lh3.googleusercontent.com/ccZh717LICrZWpfEJxj72HPHfCOrLIv2odDwxm9IkSbZwBjOO-8kj--tGhQ7GoGRTw0Je7Ydy3hKB1cbXIpi9bZv1wNJHusigg=w500-rw', NULL, 1)
INSERT [dbo].[Product] ([ID], [CategoryID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status]) VALUES (45, 6, N'Màn hình LCD Samsung 34 inch LC34F', CAST(39780000 AS Decimal(18, 0)), 20, N'https://lh3.googleusercontent.com/Ljp2sV5qOHl0Tsf54poE38Z7dNwm8p4fVoVAHTz1jYsHg2OYbDjkZjqZODu1cjif-euH1O2mgFSFOdF0tg=w500-rw', NULL, 1)
INSERT [dbo].[UserAccount] ([ID], [UserName], [Password], [Status]) VALUES (1, N'admin', N'21232f297a57a5a743894a0e4a801fc3', NULL)
INSERT [dbo].[UserAccount] ([ID], [UserName], [Password], [Status]) VALUES (3, N'lan', N'81e4d4458001b277ad62213caea62144', NULL)
INSERT [dbo].[UserAccount] ([ID], [UserName], [Password], [Status]) VALUES (5, N'hoang', N'683a997e162ac54dac13aeb2cfcf2314', NULL)
