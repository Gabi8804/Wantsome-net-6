/*Please do not change order*/



USE [master]
GO
/****** Object:  Database [SmartStoreDB]    Script Date: 2020-11-15 6:09:47 PM ******/
CREATE DATABASE [SmartStoreDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SmartStoreDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SmartStoreDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SmartStoreDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SmartStoreDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SmartStoreDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SmartStoreDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SmartStoreDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SmartStoreDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SmartStoreDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SmartStoreDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SmartStoreDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SmartStoreDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SmartStoreDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SmartStoreDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SmartStoreDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SmartStoreDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SmartStoreDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SmartStoreDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SmartStoreDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SmartStoreDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SmartStoreDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SmartStoreDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SmartStoreDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SmartStoreDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SmartStoreDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SmartStoreDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SmartStoreDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SmartStoreDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SmartStoreDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SmartStoreDB] SET  MULTI_USER 
GO
ALTER DATABASE [SmartStoreDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SmartStoreDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SmartStoreDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SmartStoreDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SmartStoreDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SmartStoreDB] SET QUERY_STORE = OFF
GO
USE [SmartStoreDB]
GO
/****** Object:  Table [dbo].[BrandCategories]    Script Date: 2020-11-15 6:09:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BrandCategories](
	[BrandCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[BrandId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BrandCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 2020-11-15 6:09:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[BrandId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BrandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 2020-11-15 6:09:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategorySpecs]    Script Date: 2020-11-15 6:09:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategorySpecs](
	[CategorySpecsId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[SpecId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategorySpecsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prod_CatSpec]    Script Date: 2020-11-15 6:09:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prod_CatSpec](
	[Prod_CatSpecId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[CategorySpecsId] [int] NOT NULL,
	[SpecValue] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Prod_CatSpecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 2020-11-15 6:09:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[Price] [float] NOT NULL,
	[BrandCategoryId] [int] NOT NULL,
	[Image] [nvarchar](100) NULL,
	[DateCreated] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductSubCategories]    Script Date: 2020-11-15 6:09:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductSubCategories](
	[ProductSubCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[SubCategoryId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductSubCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specs]    Script Date: 2020-11-15 6:09:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specs](
	[SpecId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SpecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubCategories]    Script Date: 2020-11-15 6:09:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubCategories](
	[SubCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SubCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT (getdate()) FOR [DateCreated]
GO
ALTER TABLE [dbo].[BrandCategories]  WITH CHECK ADD FOREIGN KEY([BrandId])
REFERENCES [dbo].[Brands] ([BrandId])
GO
ALTER TABLE [dbo].[BrandCategories]  WITH CHECK ADD FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[CategorySpecs]  WITH CHECK ADD FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[CategorySpecs]  WITH CHECK ADD FOREIGN KEY([SpecId])
REFERENCES [dbo].[Specs] ([SpecId])
GO
ALTER TABLE [dbo].[Prod_CatSpec]  WITH CHECK ADD FOREIGN KEY([CategorySpecsId])
REFERENCES [dbo].[CategorySpecs] ([CategorySpecsId])
GO
ALTER TABLE [dbo].[Prod_CatSpec]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Product_BrandCategory] FOREIGN KEY([BrandCategoryId])
REFERENCES [dbo].[BrandCategories] ([BrandCategoryId])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Product_BrandCategory]
GO
ALTER TABLE [dbo].[ProductSubCategories]  WITH CHECK ADD FOREIGN KEY([SubCategoryId])
REFERENCES [dbo].[SubCategories] ([SubCategoryId])
GO
ALTER TABLE [dbo].[ProductSubCategories]  WITH CHECK ADD  CONSTRAINT [FK_ProductSubCategory_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[ProductSubCategories] CHECK CONSTRAINT [FK_ProductSubCategory_Product]
GO
ALTER TABLE [dbo].[SubCategories]  WITH CHECK ADD FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
USE [SmartStoreDB]
GO

/****** Object:  Trigger [dbo].[CreatedDate_Products]    Script Date: 2020-11-15 6:13:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE TRIGGER [dbo].[CreatedDate_Products] ON [dbo].[Products]
AFTER INSERT 
AS BEGIN

UPDATE Products
SET DateCreated = GETDATE()
FROM Products p join inserted i ON p.ProductId=i.ProductId
end

ALTER TABLE [dbo].[Products] ENABLE TRIGGER [CreatedDate_Products]
GO

ALTER TABLE [dbo].[Products] ENABLE TRIGGER [CreatedDate_Products]
GO



USE [master]
GO
ALTER DATABASE [SmartStoreDB] SET  READ_WRITE 
GO
