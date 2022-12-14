USE [ecommerce]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8.09.2022 15:56:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Adress]    Script Date: 8.09.2022 15:56:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adress](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[CompanyName] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NOT NULL,
	[Street] [nvarchar](max) NOT NULL,
	[Town] [nvarchar](max) NOT NULL,
	[PostCode] [int] NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[AdditionalInfo] [nvarchar](max) NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_Adress] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 8.09.2022 15:56:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 8.09.2022 15:56:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OlusturulmaTarihi] [datetime2](7) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 8.09.2022 15:56:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 8.09.2022 15:56:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 8.09.2022 15:56:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 8.09.2022 15:56:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IpAdress] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Country] [nvarchar](max) NOT NULL,
	[City] [nvarchar](max) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 8.09.2022 15:56:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [int] NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Card]    Script Date: 8.09.2022 15:56:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Card](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UsersId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Status] [bit] NULL,
	[Piece] [int] NOT NULL,
	[GroupBy] [int] NULL,
 CONSTRAINT [PK_Card] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 8.09.2022 15:56:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 8.09.2022 15:56:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UsersId] [int] NOT NULL,
	[CardId] [int] NOT NULL,
	[OrderTime] [datetime2](7) NULL,
	[EndTime] [datetime2](7) NULL,
	[AdressId] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 8.09.2022 15:56:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](max) NOT NULL,
	[Weight] [int] NULL,
	[Status] [bit] NULL,
	[Image1] [nvarchar](max) NULL,
	[Image2] [nvarchar](max) NULL,
	[Image3] [nvarchar](max) NULL,
	[Image4] [nvarchar](max) NULL,
	[Image5] [nvarchar](max) NULL,
	[Price] [int] NOT NULL,
	[Category] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[MiniDescription] [nvarchar](max) NULL,
	[MiniImage] [nvarchar](max) NULL,
	[ListArea] [int] NOT NULL,
	[CategoryId] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220904205516_first', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220904205552_first', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220904210544_first', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220904211519_first', N'6.0.5')
GO
SET IDENTITY_INSERT [dbo].[Adress] ON 

INSERT [dbo].[Adress] ([Id], [FirstName], [LastName], [CompanyName], [Country], [Street], [Town], [PostCode], [Phone], [Email], [AdditionalInfo], [UserId]) VALUES (5, N'mert burak', N'dervisoglu', N'co', N'co', N'co', N'co', 123, N'123', N'mertburakdervisoglu@gmail.com', N'asdas sad asd asd', 3)
INSERT [dbo].[Adress] ([Id], [FirstName], [LastName], [CompanyName], [Country], [Street], [Town], [PostCode], [Phone], [Email], [AdditionalInfo], [UserId]) VALUES (6, N'mert burak', N'dervisoglu', N'aaa', N'aaa', N'aaa', N'aaa', 9999, N'999', N'mertburakdervisoglu@gmail.com', N'aasd', 3)
SET IDENTITY_INSERT [dbo].[Adress] OFF
GO
SET IDENTITY_INSERT [dbo].[AspNetRoles] ON 

INSERT [dbo].[AspNetRoles] ([Id], [OlusturulmaTarihi], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (1, CAST(N'2022-09-03T20:55:28.5857911' AS DateTime2), N'Admin', N'ADMIN', N'3fd14f42-8432-4e1b-bdf6-68fd2a50e970')
SET IDENTITY_INSERT [dbo].[AspNetRoles] OFF
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (3, 1)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (2003, 1)
GO
SET IDENTITY_INSERT [dbo].[AspNetUsers] ON 

INSERT [dbo].[AspNetUsers] ([Id], [IpAdress], [Address], [Country], [City], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (3, N'127.0.0.1', N'asdfasd', N'awdwad', N'adwddw', N'admin', N'ADMIN', N'mertburakdervisoglu@gmail.com', N'MERTBURAKDERVISOGLU@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEGs9ceP8nMdwseb1Zw26lopbg8c0Tn1sr0nHuoj/z75DOdRnGEAzX6VB/7r8RZK5PA==', N'RY63OIW4KNMQZYHPNRVTOYEUWLZWGARU', N'849644f3-c152-4ff6-87d7-7a74a8f9ac8e', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [IpAdress], [Address], [Country], [City], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (1005, N'127.0.0.1', N'asdasasd', N'asddasasd', N'asddas', N'burak', N'BURAK', N'lionpoweraslan@gmail.com', N'LIONPOWERASLAN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEEpW2aJWH0a4FUWa5QsUKq+vfuLp5fjPhyuRGYYGLvjrE3VrgcuY3sb9UHv6/fvtlg==', N'QSWPADIYNQA2X7CULPTBUIUDWVOOUEVX', N'f946c96b-9b71-4d3c-9b2d-c298b2326621', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [IpAdress], [Address], [Country], [City], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (2003, N'127.0.0.1', N'boş', N'boş', N'boş', N'admin1', N'ADMIN1', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEGBNG9jQc5g6PdbCGoliegMO6aogn/fFlkqdv8rX9bAE3tyWnH2jhTqQjpBEX401Fw==', N'2DL4UV2VUYIIKZ2WARAKU6VOJN7JBNZD', N'353b9a82-40cd-4f4e-b178-bacb7bf24be0', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[AspNetUsers] OFF
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
INSERT [dbo].[Card] ([Id], [UsersId], [ProductId], [Status], [Piece], [GroupBy]) VALUES (1009, 3, 0, NULL, 2, 3)
INSERT [dbo].[Card] ([Id], [UsersId], [ProductId], [Status], [Piece], [GroupBy]) VALUES (2008, 3, 6, NULL, 1, 3)
SET IDENTITY_INSERT [dbo].[Card] OFF
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
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [UsersId], [CardId], [OrderTime], [EndTime], [AdressId]) VALUES (9, 3, 1, CAST(N'2022-09-05T00:30:18.9146423' AS DateTime2), NULL, 5)
INSERT [dbo].[Orders] ([Id], [UsersId], [CardId], [OrderTime], [EndTime], [AdressId]) VALUES (10, 3, 2, CAST(N'2022-09-05T00:30:18.9147029' AS DateTime2), NULL, 5)
INSERT [dbo].[Orders] ([Id], [UsersId], [CardId], [OrderTime], [EndTime], [AdressId]) VALUES (11, 3, 3, CAST(N'2022-09-05T00:30:18.9147041' AS DateTime2), NULL, 5)
INSERT [dbo].[Orders] ([Id], [UsersId], [CardId], [OrderTime], [EndTime], [AdressId]) VALUES (12, 3, 4, CAST(N'2022-09-05T00:30:18.9147042' AS DateTime2), NULL, 5)
INSERT [dbo].[Orders] ([Id], [UsersId], [CardId], [OrderTime], [EndTime], [AdressId]) VALUES (13, 3, 6, CAST(N'2022-09-05T00:30:18.9147044' AS DateTime2), NULL, 5)
INSERT [dbo].[Orders] ([Id], [UsersId], [CardId], [OrderTime], [EndTime], [AdressId]) VALUES (14, 3, 7, CAST(N'2022-09-05T00:30:18.9147047' AS DateTime2), NULL, 5)
INSERT [dbo].[Orders] ([Id], [UsersId], [CardId], [OrderTime], [EndTime], [AdressId]) VALUES (1009, 3, 8, CAST(N'2022-09-05T13:21:23.5976235' AS DateTime2), NULL, 6)
INSERT [dbo].[Orders] ([Id], [UsersId], [CardId], [OrderTime], [EndTime], [AdressId]) VALUES (1010, 3, 9, CAST(N'2022-09-05T13:21:23.5977110' AS DateTime2), NULL, 6)
SET IDENTITY_INSERT [dbo].[Orders] OFF
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
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Card]  WITH CHECK ADD  CONSTRAINT [FK_Card_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Card] CHECK CONSTRAINT [FK_Card_Product_ProductId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Card] FOREIGN KEY([CardId])
REFERENCES [dbo].[Card] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Card]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category_CategoryId]
GO
