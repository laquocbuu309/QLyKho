USE [QuanLyKho]
GO
SET IDENTITY_INSERT [dbo].[Unit] ON 

INSERT [dbo].[Unit] ([Id], [DisplayName]) VALUES (1, N'Kg')
INSERT [dbo].[Unit] ([Id], [DisplayName]) VALUES (2, N'Thùng')
INSERT [dbo].[Unit] ([Id], [DisplayName]) VALUES (3, N'Bao')
INSERT [dbo].[Unit] ([Id], [DisplayName]) VALUES (4, N'Viên')
INSERT [dbo].[Unit] ([Id], [DisplayName]) VALUES (5, N'Cái')
SET IDENTITY_INSERT [dbo].[Unit] OFF
SET IDENTITY_INSERT [dbo].[Suplier] ON 

INSERT [dbo].[Suplier] ([Id], [DisplayName], [Address], [Phone], [Email], [MoreInfo], [ContractDate]) VALUES (1, N'DYBoiler', N'408 Đường 13 Amata', N'012345678', N'dyboiler@gmail.com', NULL, CAST(N'2019-12-19 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Suplier] OFF
INSERT [dbo].[Object] ([Id], [DisplayName], [IdUnit], [IdSuplier], [QRCode], [BarCode]) VALUES (N'1', N'Xi Măng', 1, 1, NULL, NULL)
INSERT [dbo].[Object] ([Id], [DisplayName], [IdUnit], [IdSuplier], [QRCode], [BarCode]) VALUES (N'2', N'Gạch', 4, 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Id], [DisplayName], [Address], [Phone], [Email], [MoreInfo], [ContractDate]) VALUES (1, N'K+', N'addr1', N'013245688', N'k+@gmail.com', NULL, NULL)
INSERT [dbo].[Customer] ([Id], [DisplayName], [Address], [Phone], [Email], [MoreInfo], [ContractDate]) VALUES (2, N'LG', N'add2', N'054546875', N'lg@gmail.com', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Customer] OFF
INSERT [dbo].[Input] ([Id], [DateInput]) VALUES (N'1', CAST(N'2020-01-20 00:00:00.000' AS DateTime))
INSERT [dbo].[Input] ([Id], [DateInput]) VALUES (N'2', CAST(N'2020-02-19 00:00:00.000' AS DateTime))
INSERT [dbo].[InputInfo] ([Id], [IdObject], [IdInput], [Count], [InputPrice], [OutputPrice], [Status]) VALUES (N'1', N'1', N'1', 50, 200000, 300000, NULL)
INSERT [dbo].[InputInfo] ([Id], [IdObject], [IdInput], [Count], [InputPrice], [OutputPrice], [Status]) VALUES (N'2', N'2', N'1', 1000, 2000, 4000, NULL)
INSERT [dbo].[Output] ([Id], [DateOutput]) VALUES (N'1', CAST(N'2020-03-30 00:00:00.000' AS DateTime))
INSERT [dbo].[Output] ([Id], [DateOutput]) VALUES (N'2', CAST(N'2020-03-30 00:00:00.000' AS DateTime))
INSERT [dbo].[OutputInfo] ([Id], [IdObject], [IdOutput], [IdInputInfo], [IdCustomer], [Count], [Status]) VALUES (N'1', N'1', N'1', N'1', 1, 10, NULL)
INSERT [dbo].[OutputInfo] ([Id], [IdObject], [IdOutput], [IdInputInfo], [IdCustomer], [Count], [Status]) VALUES (N'2', N'2', N'1', N'2', 1, 200, NULL)
SET IDENTITY_INSERT [dbo].[UserRole] ON 

INSERT [dbo].[UserRole] ([Id], [DisplayName]) VALUES (1, N'Admin')
INSERT [dbo].[UserRole] ([Id], [DisplayName]) VALUES (2, N'Nhân Viên')
SET IDENTITY_INSERT [dbo].[UserRole] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [DisplayName], [UserName], [PassWord], [IdRole]) VALUES (1, N'LaQuocBuu', N'admin', N'cdd96d3cc73d1dbdaffa03cc6cd7339b', 1)
INSERT [dbo].[Users] ([Id], [DisplayName], [UserName], [PassWord], [IdRole]) VALUES (2, N'Nhân viên 1', N'staff01', N'cdd96d3cc73d1dbdaffa03cc6cd7339b', 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
