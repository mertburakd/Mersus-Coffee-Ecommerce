USE [ecommerce]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [CategoryName], [Description]) VALUES (1, N'Hot-Coffee', N'<p>Hot Coffee Content1</p>
')
INSERT [dbo].[Category] ([Id], [CategoryName], [Description]) VALUES (2, N'Coffee & Tea Buddies', N'<p>Coffee and Tea</p>
')
INSERT [dbo].[Category] ([Id], [CategoryName], [Description]) VALUES (3, N'Filter Coffee', N'<p>Filter Coffee</p>
')
INSERT [dbo].[Category] ([Id], [CategoryName], [Description]) VALUES (4, N'Gift Bundles', N'<p>Gift Bundles</p>
')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductId], [ProductName], [Weight], [Status], [Image1], [Image2], [Image3], [Image4], [Image5], [Price], [Category], [Description], [MiniDescription], [MiniImage], [ListArea], [CategoryId]) VALUES (0, N'Americano Rosted Coffee', 100, 1, N'pp-1.png', N'pp-2.png', N'pp-3.png', N't-p-1.png', N't-p-3.png', 12, 1, NULL, NULL, N'menu-2-1.png', 1, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [Weight], [Status], [Image1], [Image2], [Image3], [Image4], [Image5], [Price], [Category], [Description], [MiniDescription], [MiniImage], [ListArea], [CategoryId]) VALUES (1, N'CAFÈ AU LAIT Coffee', 100, 1, N'pp-1.png', N'pp-2.png', N'pp-3.png', N't-p-1.png', N't-p-3.png', 12, 2, NULL, NULL, N'menu-2-3.png', 1, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [Weight], [Status], [Image1], [Image2], [Image3], [Image4], [Image5], [Price], [Category], [Description], [MiniDescription], [MiniImage], [ListArea], [CategoryId]) VALUES (2, N'VIRGIN COFFEE GRED', 100, 1, N'pp-1.png', N'pp-2.png', N'pp-3.png', N't-p-1.png', N't-p-3.png', 12, 3, NULL, NULL, N'menu-2-3.png', 1, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [Weight], [Status], [Image1], [Image2], [Image3], [Image4], [Image5], [Price], [Category], [Description], [MiniDescription], [MiniImage], [ListArea], [CategoryId]) VALUES (3, N'BRAZIL COFFEE GRED', 100, 1, N'pp-1.png', N'pp-2.png', N'pp-3.png', N't-p-1.png', N't-p-3.png', 13, 4, NULL, NULL, N'menu-2-1.png', 1, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [Weight], [Status], [Image1], [Image2], [Image3], [Image4], [Image5], [Price], [Category], [Description], [MiniDescription], [MiniImage], [ListArea], [CategoryId]) VALUES (4, N'CAFFÈ LATTE BEANS', 100, 1, N'pp-1.png', N'pp-2.png', N'pp-3.png', N't-p-1.png', N't-p-3.png', 12, 4, NULL, NULL, N'menu-2-3.png', 1, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [Weight], [Status], [Image1], [Image2], [Image3], [Image4], [Image5], [Price], [Category], [Description], [MiniDescription], [MiniImage], [ListArea], [CategoryId]) VALUES (5, N'Bangladeshi Rosted Coffee', 100, 1, N'pp-1.png', N'pp-2.png', N'pp-3.png', N't-p-1.png', N't-p-3.png', 12, 4, NULL, NULL, N'menu-2-5.png', 1, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [Weight], [Status], [Image1], [Image2], [Image3], [Image4], [Image5], [Price], [Category], [Description], [MiniDescription], [MiniImage], [ListArea], [CategoryId]) VALUES (6, N'JAPANIS COFFEE GRED', 100, 1, N'pp-1.png', N'pp-2.png', N'pp-3.png', N't-p-1.png', N't-p-3.png', 12, 3, NULL, NULL, N'menu-2-2.png', 1, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [Weight], [Status], [Image1], [Image2], [Image3], [Image4], [Image5], [Price], [Category], [Description], [MiniDescription], [MiniImage], [ListArea], [CategoryId]) VALUES (7, N'ESPRESSO RISTRETTO Coffee', 100, 1, N'pp-1.png', N'pp-2.png', N'pp-3.png', N't-p-1.png', N't-p-3.png', 13, 2, NULL, NULL, N'menu-2-4.png', 1, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [Weight], [Status], [Image1], [Image2], [Image3], [Image4], [Image5], [Price], [Category], [Description], [MiniDescription], [MiniImage], [ListArea], [CategoryId]) VALUES (8, N'ESPRESSO RISTRETTO Coffee', 100, 1, N'pp-1.png', N'pp-2.png', N'pp-3.png', N't-p-1.png', N't-p-3.png', 12, 2, NULL, NULL, N'menu-2-6.png', 1, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [Weight], [Status], [Image1], [Image2], [Image3], [Image4], [Image5], [Price], [Category], [Description], [MiniDescription], [MiniImage], [ListArea], [CategoryId]) VALUES (9, N'ESPRESSO RISTRETTO BEANS', 100, 1, N'pp-1.png', N'pp-2.png', N'pp-3.png', N't-p-1.png', N't-p-3.png', 12, 3, NULL, NULL, N'menu-2-2.png', 1, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [Weight], [Status], [Image1], [Image2], [Image3], [Image4], [Image5], [Price], [Category], [Description], [MiniDescription], [MiniImage], [ListArea], [CategoryId]) VALUES (10, N'Turkish Rosted Coffee', 100, 1, N'pp-1.png', N'pp-2.png', N'pp-3.png', N't-p-1.png', N't-p-3.png', 12, 1, NULL, NULL, N'menu-2-4.png', 1, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [Weight], [Status], [Image1], [Image2], [Image3], [Image4], [Image5], [Price], [Category], [Description], [MiniDescription], [MiniImage], [ListArea], [CategoryId]) VALUES (11, N'indian Rosted Coffee', 100, 1, N'pp-1.png', N'pp-2.png', N'pp-3.png', N't-p-1.png', N't-p-3.png', 13, 1, NULL, NULL, N'menu-2-6.png', 1, NULL)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Card] ON 

INSERT [dbo].[Card] ([Id], [UsersId], [ProductId], [Status], [Piece], [GroupBy]) VALUES (1, 3, 2, 0, 4, 1)
INSERT [dbo].[Card] ([Id], [UsersId], [ProductId], [Status], [Piece], [GroupBy]) VALUES (2, 3, 3, 0, 5, 1)
INSERT [dbo].[Card] ([Id], [UsersId], [ProductId], [Status], [Piece], [GroupBy]) VALUES (3, 3, 5, 0, 6, 1)
INSERT [dbo].[Card] ([Id], [UsersId], [ProductId], [Status], [Piece], [GroupBy]) VALUES (4, 3, 10, 0, 4, 1)
INSERT [dbo].[Card] ([Id], [UsersId], [ProductId], [Status], [Piece], [GroupBy]) VALUES (6, 3, 5, 0, 6, 1)
INSERT [dbo].[Card] ([Id], [UsersId], [ProductId], [Status], [Piece], [GroupBy]) VALUES (7, 3, 0, 0, 2, 1)
INSERT [dbo].[Card] ([Id], [UsersId], [ProductId], [Status], [Piece], [GroupBy]) VALUES (8, 3, 0, 0, 1, 2)
INSERT [dbo].[Card] ([Id], [UsersId], [ProductId], [Status], [Piece], [GroupBy]) VALUES (9, 3, 1, 0, 2, 2)
INSERT [dbo].[Card] ([Id], [UsersId], [ProductId], [Status], [Piece], [GroupBy]) VALUES (1009, 3, 0, 0, 2, 3)
INSERT [dbo].[Card] ([Id], [UsersId], [ProductId], [Status], [Piece], [GroupBy]) VALUES (2008, 3, 6, 0, 1, 3)
INSERT [dbo].[Card] ([Id], [UsersId], [ProductId], [Status], [Piece], [GroupBy]) VALUES (3008, 3, 0, NULL, 1, 4)
SET IDENTITY_INSERT [dbo].[Card] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [UsersId], [CardId], [OrderTime], [EndTime], [AdressId]) VALUES (9, 3, 1, CAST(N'2022-09-05T00:30:18.9146423' AS DateTime2), NULL, 5)
INSERT [dbo].[Orders] ([Id], [UsersId], [CardId], [OrderTime], [EndTime], [AdressId]) VALUES (10, 3, 2, CAST(N'2022-09-05T00:30:18.9147029' AS DateTime2), NULL, 5)
INSERT [dbo].[Orders] ([Id], [UsersId], [CardId], [OrderTime], [EndTime], [AdressId]) VALUES (11, 3, 3, CAST(N'2022-09-05T00:30:18.9147041' AS DateTime2), NULL, 5)
INSERT [dbo].[Orders] ([Id], [UsersId], [CardId], [OrderTime], [EndTime], [AdressId]) VALUES (12, 3, 4, CAST(N'2022-09-05T00:30:18.9147042' AS DateTime2), NULL, 5)
INSERT [dbo].[Orders] ([Id], [UsersId], [CardId], [OrderTime], [EndTime], [AdressId]) VALUES (13, 3, 6, CAST(N'2022-09-05T00:30:18.9147044' AS DateTime2), NULL, 5)
INSERT [dbo].[Orders] ([Id], [UsersId], [CardId], [OrderTime], [EndTime], [AdressId]) VALUES (14, 3, 7, CAST(N'2022-09-05T00:30:18.9147047' AS DateTime2), NULL, 5)
INSERT [dbo].[Orders] ([Id], [UsersId], [CardId], [OrderTime], [EndTime], [AdressId]) VALUES (1009, 3, 8, CAST(N'2022-09-05T13:21:23.5976235' AS DateTime2), NULL, 6)
INSERT [dbo].[Orders] ([Id], [UsersId], [CardId], [OrderTime], [EndTime], [AdressId]) VALUES (1010, 3, 9, CAST(N'2022-09-05T13:21:23.5977110' AS DateTime2), NULL, 6)
INSERT [dbo].[Orders] ([Id], [UsersId], [CardId], [OrderTime], [EndTime], [AdressId]) VALUES (2009, 3, 1009, CAST(N'2022-09-08T16:59:20.1165746' AS DateTime2), NULL, 1006)
INSERT [dbo].[Orders] ([Id], [UsersId], [CardId], [OrderTime], [EndTime], [AdressId]) VALUES (2010, 3, 2008, CAST(N'2022-09-08T16:59:20.1166317' AS DateTime2), NULL, 1006)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[AspNetRoles] ON 

INSERT [dbo].[AspNetRoles] ([Id], [OlusturulmaTarihi], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (1, CAST(N'2022-09-03T20:55:28.5857911' AS DateTime2), N'Admin', N'ADMIN', N'3fd14f42-8432-4e1b-bdf6-68fd2a50e970')
SET IDENTITY_INSERT [dbo].[AspNetRoles] OFF
GO
SET IDENTITY_INSERT [dbo].[AspNetUsers] ON 

INSERT [dbo].[AspNetUsers] ([Id], [IpAdress], [Address], [Country], [City], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (3, N'127.0.0.1', N'asdfasd', N'awdwad', N'adwddw', N'admin', N'ADMIN', N'mertburakdervisoglu@gmail.com', N'MERTBURAKDERVISOGLU@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEGs9ceP8nMdwseb1Zw26lopbg8c0Tn1sr0nHuoj/z75DOdRnGEAzX6VB/7r8RZK5PA==', N'RY63OIW4KNMQZYHPNRVTOYEUWLZWGARU', N'849644f3-c152-4ff6-87d7-7a74a8f9ac8e', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [IpAdress], [Address], [Country], [City], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (1005, N'127.0.0.1', N'asdasasd', N'asddasasd', N'asddas', N'burak', N'BURAK', N'lionpoweraslan@gmail.com', N'LIONPOWERASLAN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEEpW2aJWH0a4FUWa5QsUKq+vfuLp5fjPhyuRGYYGLvjrE3VrgcuY3sb9UHv6/fvtlg==', N'QSWPADIYNQA2X7CULPTBUIUDWVOOUEVX', N'f946c96b-9b71-4d3c-9b2d-c298b2326621', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [IpAdress], [Address], [Country], [City], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (2003, N'127.0.0.1', N'boş', N'boş', N'boş', N'admin1', N'ADMIN1', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEGBNG9jQc5g6PdbCGoliegMO6aogn/fFlkqdv8rX9bAE3tyWnH2jhTqQjpBEX401Fw==', N'2DL4UV2VUYIIKZ2WARAKU6VOJN7JBNZD', N'353b9a82-40cd-4f4e-b178-bacb7bf24be0', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[AspNetUsers] OFF
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (3, 1)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (2003, 1)
GO
SET IDENTITY_INSERT [dbo].[Adress] ON 

INSERT [dbo].[Adress] ([Id], [FirstName], [LastName], [CompanyName], [Country], [Street], [Town], [PostCode], [Phone], [Email], [AdditionalInfo], [UserId]) VALUES (5, N'mert burak', N'dervisoglu', N'co', N'co', N'co', N'co', 123, N'123', N'mertburakdervisoglu@gmail.com', N'asdas sad asd asd', 3)
INSERT [dbo].[Adress] ([Id], [FirstName], [LastName], [CompanyName], [Country], [Street], [Town], [PostCode], [Phone], [Email], [AdditionalInfo], [UserId]) VALUES (6, N'mert burak', N'dervisoglu', N'aaa', N'aaa', N'aaa', N'aaa', 9999, N'999', N'mertburakdervisoglu@gmail.com', N'aasd', 3)
INSERT [dbo].[Adress] ([Id], [FirstName], [LastName], [CompanyName], [Country], [Street], [Town], [PostCode], [Phone], [Email], [AdditionalInfo], [UserId]) VALUES (1006, N'mert burak', N'dervisoglu', N'45', N'45', N'45', N'45', 45, N'45', N'mertburakdervisoglu@gmail.com', N'5632asdasd', 3)
SET IDENTITY_INSERT [dbo].[Adress] OFF
GO
