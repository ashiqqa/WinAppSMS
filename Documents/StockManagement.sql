USE [master]
GO
/****** Object:  Database [StockManagement]    Script Date: 07-May-18 11:41:45 PM ******/
CREATE DATABASE [StockManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StockManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\StockManagement.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'StockManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\StockManagement_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [StockManagement] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StockManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StockManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StockManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StockManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StockManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StockManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [StockManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StockManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StockManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StockManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StockManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StockManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StockManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StockManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StockManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StockManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [StockManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StockManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StockManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StockManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StockManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StockManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StockManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StockManagement] SET RECOVERY FULL 
GO
ALTER DATABASE [StockManagement] SET  MULTI_USER 
GO
ALTER DATABASE [StockManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StockManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StockManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StockManagement] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [StockManagement] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'StockManagement', N'ON'
GO
USE [StockManagement]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 07-May-18 11:41:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Companies]    Script Date: 07-May-18 11:41:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Companies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inventories]    Script Date: 07-May-18 11:41:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_Inventories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Items]    Script Date: 07-May-18 11:41:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Items](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NULL,
	[CompanyId] [int] NULL,
	[Name] [varchar](50) NULL,
	[ReorderLevel] [int] NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockIn]    Script Date: 07-May-18 11:41:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockIn](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[Quantity] [int] NULL,
	[Date] [date] NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_StockIn] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StockOut]    Script Date: 07-May-18 11:41:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockOut](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[Quantity] [int] NULL,
	[Status] [int] NULL,
	[Date] [date] NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_StockOut] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 07-May-18 11:41:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'Electronics')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Cloths')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Cosmetics')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (4, N'Stationary')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Companies] ON 

INSERT [dbo].[Companies] ([Id], [Name]) VALUES (1, N'Uniliver')
INSERT [dbo].[Companies] ([Id], [Name]) VALUES (2, N'RFL')
INSERT [dbo].[Companies] ([Id], [Name]) VALUES (3, N'Walton')
INSERT [dbo].[Companies] ([Id], [Name]) VALUES (5, N'Easy Fashion')
INSERT [dbo].[Companies] ([Id], [Name]) VALUES (6, N'addids')
SET IDENTITY_INSERT [dbo].[Companies] OFF
SET IDENTITY_INSERT [dbo].[Inventories] ON 

INSERT [dbo].[Inventories] ([Id], [ItemId], [Quantity]) VALUES (1, 5, 9)
INSERT [dbo].[Inventories] ([Id], [ItemId], [Quantity]) VALUES (2, 6, 11)
INSERT [dbo].[Inventories] ([Id], [ItemId], [Quantity]) VALUES (3, 3, 21)
INSERT [dbo].[Inventories] ([Id], [ItemId], [Quantity]) VALUES (4, 4, 9)
INSERT [dbo].[Inventories] ([Id], [ItemId], [Quantity]) VALUES (5, 8, 6)
INSERT [dbo].[Inventories] ([Id], [ItemId], [Quantity]) VALUES (6, 7, 18)
INSERT [dbo].[Inventories] ([Id], [ItemId], [Quantity]) VALUES (7, 1, 9)
INSERT [dbo].[Inventories] ([Id], [ItemId], [Quantity]) VALUES (8, 2, 7)
INSERT [dbo].[Inventories] ([Id], [ItemId], [Quantity]) VALUES (9, 9, 4)
INSERT [dbo].[Inventories] ([Id], [ItemId], [Quantity]) VALUES (10, 13, 16)
SET IDENTITY_INSERT [dbo].[Inventories] OFF
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [Name], [ReorderLevel]) VALUES (1, 4, 2, N'Chair', 10)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [Name], [ReorderLevel]) VALUES (2, 4, 2, N'Table', 5)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [Name], [ReorderLevel]) VALUES (3, 2, 5, N'T-Shirt', 15)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [Name], [ReorderLevel]) VALUES (4, 2, 5, N'Pant', 10)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [Name], [ReorderLevel]) VALUES (5, 2, 6, N'Shirt', 5)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [Name], [ReorderLevel]) VALUES (6, 2, 6, N'Cap', 10)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [Name], [ReorderLevel]) VALUES (7, 1, 3, N'Mobile', 10)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [Name], [ReorderLevel]) VALUES (8, 1, 3, N'Freez', 5)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [Name], [ReorderLevel]) VALUES (9, 4, 1, N'Disk', 3)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [Name], [ReorderLevel]) VALUES (10, 3, 2, N'new item', 3)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [Name], [ReorderLevel]) VALUES (11, 2, 5, N'Panjabi', 4)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [Name], [ReorderLevel]) VALUES (12, 2, 6, N'T-shirt', 8)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [Name], [ReorderLevel]) VALUES (13, 4, 3, N'Table', 7)
SET IDENTITY_INSERT [dbo].[Items] OFF
SET IDENTITY_INSERT [dbo].[StockIn] ON 

INSERT [dbo].[StockIn] ([Id], [ItemId], [Quantity], [Date], [UserId]) VALUES (1, 5, 8, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockIn] ([Id], [ItemId], [Quantity], [Date], [UserId]) VALUES (2, 6, 20, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockIn] ([Id], [ItemId], [Quantity], [Date], [UserId]) VALUES (3, 3, 30, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockIn] ([Id], [ItemId], [Quantity], [Date], [UserId]) VALUES (4, 4, 15, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockIn] ([Id], [ItemId], [Quantity], [Date], [UserId]) VALUES (5, 8, 10, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockIn] ([Id], [ItemId], [Quantity], [Date], [UserId]) VALUES (6, 7, 25, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockIn] ([Id], [ItemId], [Quantity], [Date], [UserId]) VALUES (7, 1, 20, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockIn] ([Id], [ItemId], [Quantity], [Date], [UserId]) VALUES (8, 2, 15, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockIn] ([Id], [ItemId], [Quantity], [Date], [UserId]) VALUES (9, 9, 3, CAST(N'2018-05-07' AS Date), 1)
INSERT [dbo].[StockIn] ([Id], [ItemId], [Quantity], [Date], [UserId]) VALUES (10, 9, 2, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockIn] ([Id], [ItemId], [Quantity], [Date], [UserId]) VALUES (11, 5, 5, CAST(N'2018-05-07' AS Date), 1)
INSERT [dbo].[StockIn] ([Id], [ItemId], [Quantity], [Date], [UserId]) VALUES (12, 13, 12, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockIn] ([Id], [ItemId], [Quantity], [Date], [UserId]) VALUES (13, 13, 7, CAST(N'2018-05-07' AS Date), 2)
SET IDENTITY_INSERT [dbo].[StockIn] OFF
SET IDENTITY_INSERT [dbo].[StockOut] ON 

INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (1, 5, 2, 1, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (2, 6, 1, 1, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (3, 4, 3, 1, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (4, 3, 6, 1, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (5, 7, 2, 1, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (6, 8, 1, 1, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (7, 1, 4, 1, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (8, 2, 3, 1, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (9, 4, 3, 2, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (10, 1, 2, 2, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (11, 5, 2, 3, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (12, 6, 5, 3, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (13, 1, 2, 3, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (14, 7, 5, 1, CAST(N'2018-05-07' AS Date), 1)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (15, 8, 3, 1, CAST(N'2018-05-07' AS Date), 1)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (16, 2, 4, 1, CAST(N'2018-05-07' AS Date), 1)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (17, 13, 3, 1, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (18, 6, 3, 1, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (19, 9, 1, 1, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (20, 1, 3, 2, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (21, 2, 1, 2, CAST(N'2018-05-07' AS Date), 2)
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Status], [Date], [UserId]) VALUES (22, 3, 3, 3, CAST(N'2018-05-07' AS Date), 2)
SET IDENTITY_INSERT [dbo].[StockOut] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Name], [Password]) VALUES (1, N'admin', N'13579')
INSERT [dbo].[Users] ([Id], [Name], [Password]) VALUES (2, N'moderator', N'2468')
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Categories]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Companies] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Companies] ([Id])
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Companies]
GO
ALTER TABLE [dbo].[StockIn]  WITH CHECK ADD  CONSTRAINT [FK_StockIn_Items] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Items] ([Id])
GO
ALTER TABLE [dbo].[StockIn] CHECK CONSTRAINT [FK_StockIn_Items]
GO
ALTER TABLE [dbo].[StockIn]  WITH CHECK ADD  CONSTRAINT [FK_StockIn_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[StockIn] CHECK CONSTRAINT [FK_StockIn_Users]
GO
ALTER TABLE [dbo].[StockOut]  WITH CHECK ADD  CONSTRAINT [FK_StockOut_Items] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Items] ([Id])
GO
ALTER TABLE [dbo].[StockOut] CHECK CONSTRAINT [FK_StockOut_Items]
GO
ALTER TABLE [dbo].[StockOut]  WITH CHECK ADD  CONSTRAINT [FK_StockOut_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[StockOut] CHECK CONSTRAINT [FK_StockOut_Users]
GO
USE [master]
GO
ALTER DATABASE [StockManagement] SET  READ_WRITE 
GO
