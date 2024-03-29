USE [master]
GO
/****** Object:  Database [physics_db]    Script Date: 26/7/2019 9:53:30 PM ******/
CREATE DATABASE [physics_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'physics_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\physics_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'physics_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\physics_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [physics_db] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [physics_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [physics_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [physics_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [physics_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [physics_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [physics_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [physics_db] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [physics_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [physics_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [physics_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [physics_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [physics_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [physics_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [physics_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [physics_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [physics_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [physics_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [physics_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [physics_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [physics_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [physics_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [physics_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [physics_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [physics_db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [physics_db] SET  MULTI_USER 
GO
ALTER DATABASE [physics_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [physics_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [physics_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [physics_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [physics_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [physics_db] SET QUERY_STORE = OFF
GO
USE [physics_db]
GO
/****** Object:  User [connect]    Script Date: 26/7/2019 9:53:30 PM ******/
CREATE USER [connect] FOR LOGIN [connect] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Schema [m2ss]    Script Date: 26/7/2019 9:53:30 PM ******/
CREATE SCHEMA [m2ss]
GO
/****** Object:  Schema [physics_db]    Script Date: 26/7/2019 9:53:30 PM ******/
CREATE SCHEMA [physics_db]
GO
/****** Object:  UserDefinedFunction [dbo].[fnStringList2Table]    Script Date: 26/7/2019 9:53:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fnStringList2Table]
(
    @List varchar(MAX)
)
RETURNS 
@ParsedList table
(
    item int
)
AS
BEGIN
    DECLARE @item varchar(800), @Pos int

    SET @List = LTRIM(RTRIM(@List))+ ','
    SET @Pos = CHARINDEX(',', @List, 1)

    WHILE @Pos > 0
    BEGIN
        SET @item = LTRIM(RTRIM(LEFT(@List, @Pos - 1)))
        IF @item <> ''
        BEGIN
            INSERT INTO @ParsedList (item) 
            VALUES (CAST(@item AS int))
        END
        SET @List = RIGHT(@List, LEN(@List) - @Pos)
        SET @Pos = CHARINDEX(',', @List, 1)
    END

    RETURN
END
GO
/****** Object:  UserDefinedFunction [dbo].[fnStringList2TableDecimal]    Script Date: 26/7/2019 9:53:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fnStringList2TableDecimal]
(
    @List varchar(MAX)
)
RETURNS 
@ParsedList table
(
    item decimal(38,0)
)
AS
BEGIN
    DECLARE @item varchar(800), @Pos int

    SET @List = LTRIM(RTRIM(@List))+ ','
    SET @Pos = CHARINDEX(',', @List, 1)

    WHILE @Pos > 0
    BEGIN
        SET @item = LTRIM(RTRIM(LEFT(@List, @Pos - 1)))
        IF @item <> ''
        BEGIN
            INSERT INTO @ParsedList (item) 
            VALUES (CAST(@item AS decimal(38,0)))
        END
        SET @List = RIGHT(@List, LEN(@List) - @Pos)
        SET @Pos = CHARINDEX(',', @List, 1)
    END

    RETURN
END
GO
/****** Object:  UserDefinedFunction [dbo].[fnStringList2TableString]    Script Date: 26/7/2019 9:53:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fnStringList2TableString]
(
    @List varchar(MAX)
)
RETURNS 
@ParsedList table
(
    item nvarchar(MAX)
)
AS
BEGIN
    DECLARE @item varchar(800), @Pos int

    SET @List = LTRIM(RTRIM(@List))+ ','
    SET @Pos = CHARINDEX(',', @List, 1)

    WHILE @Pos > 0
    BEGIN
        SET @item = LTRIM(RTRIM(LEFT(@List, @Pos - 1)))
        IF @item <> ''
        BEGIN
            INSERT INTO @ParsedList (item) 
            VALUES (CAST(@item AS nvarchar(MAX)))
        END
        SET @List = RIGHT(@List, LEN(@List) - @Pos)
        SET @Pos = CHARINDEX(',', @List, 1)
    END

    RETURN
END
GO
/****** Object:  Table [dbo].[account_types]    Script Date: 26/7/2019 9:53:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account_types](
	[ID] [int] IDENTITY(3,1) NOT NULL,
	[AccountType] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_account_types_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[accounts]    Script Date: 26/7/2019 9:53:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[accounts](
	[ID] [int] IDENTITY(3,1) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[UserPassword] [nvarchar](255) NOT NULL,
	[Respon] [int] NOT NULL,
	[AccountType] [int] NOT NULL,
 CONSTRAINT [PK_accounts_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[device_status]    Script Date: 26/7/2019 9:53:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[device_status](
	[ID] [int] IDENTITY(4,1) NOT NULL,
	[Status] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_device_status_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[devices_tb]    Script Date: 26/7/2019 9:53:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[devices_tb](
	[device_name] [nvarchar](100) NOT NULL,
	[device_barcode] [decimal](38, 0) NOT NULL,
	[lab_name] [nvarchar](100) NOT NULL,
	[device_status] [nvarchar](20) NOT NULL,
	[exp_name] [nvarchar](100) NOT NULL,
	[exp_num] [int] NOT NULL,
	[respon] [nvarchar](100) NOT NULL,
	[description] [nvarchar](250) NULL,
	[ID] [int] IDENTITY(1903,1) NOT NULL,
 CONSTRAINT [PK_devices_tb_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[exp]    Script Date: 26/7/2019 9:53:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[exp](
	[ID] [int] IDENTITY(400,1) NOT NULL,
	[exp_name] [nvarchar](100) NOT NULL,
	[exp_num] [int] NOT NULL,
	[lab_name] [nvarchar](100) NOT NULL,
	[exp_img] [image] NULL,
 CONSTRAINT [PK_exp_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[labs]    Script Date: 26/7/2019 9:53:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[labs](
	[ID] [int] IDENTITY(12,1) NOT NULL,
	[lab_name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_labs_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[respon]    Script Date: 26/7/2019 9:53:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[respon](
	[ID] [int] IDENTITY(16,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_respon_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[account_types] ON 

INSERT [dbo].[account_types] ([ID], [AccountType]) VALUES (1, N'admin')
INSERT [dbo].[account_types] ([ID], [AccountType]) VALUES (2, N'employee')
SET IDENTITY_INSERT [dbo].[account_types] OFF
SET IDENTITY_INSERT [dbo].[accounts] ON 

INSERT [dbo].[accounts] ([ID], [UserName], [UserPassword], [Respon], [AccountType]) VALUES (1, N'admin', N'admin', 1, 1)
SET IDENTITY_INSERT [dbo].[accounts] OFF
SET IDENTITY_INSERT [dbo].[device_status] ON 

INSERT [dbo].[device_status] ([ID], [Status]) VALUES (1, N'يعمل')
INSERT [dbo].[device_status] ([ID], [Status]) VALUES (2, N'لا يعمل')
INSERT [dbo].[device_status] ([ID], [Status]) VALUES (3, N'مكهن')
SET IDENTITY_INSERT [dbo].[device_status] OFF
SET IDENTITY_INSERT [dbo].[respon] ON 

INSERT [dbo].[respon] ([ID], [name]) VALUES (1, N'admin')
SET IDENTITY_INSERT [dbo].[respon] OFF
/****** Object:  Index [Accounts_AccountType_ID_idx]    Script Date: 26/7/2019 9:53:31 PM ******/
CREATE NONCLUSTERED INDEX [Accounts_AccountType_ID_idx] ON [dbo].[accounts]
(
	[AccountType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER INDEX [Accounts_AccountType_ID_idx] ON [dbo].[accounts] DISABLE
GO
/****** Object:  Index [Accounts_respon_ID_idx]    Script Date: 26/7/2019 9:53:31 PM ******/
CREATE NONCLUSTERED INDEX [Accounts_respon_ID_idx] ON [dbo].[accounts]
(
	[Respon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER INDEX [Accounts_respon_ID_idx] ON [dbo].[accounts] DISABLE
GO
ALTER TABLE [dbo].[devices_tb] ADD  CONSTRAINT [DF__devices_t__descr__6B24EA82]  DEFAULT (NULL) FOR [description]
GO
ALTER TABLE [dbo].[accounts]  WITH NOCHECK ADD  CONSTRAINT [accounts$Accounts_AccountType_ID] FOREIGN KEY([AccountType])
REFERENCES [dbo].[account_types] ([ID])
GO
ALTER TABLE [dbo].[accounts] CHECK CONSTRAINT [accounts$Accounts_AccountType_ID]
GO
ALTER TABLE [dbo].[accounts]  WITH NOCHECK ADD  CONSTRAINT [accounts$Accounts_respon_ID] FOREIGN KEY([Respon])
REFERENCES [dbo].[respon] ([ID])
GO
ALTER TABLE [dbo].[accounts] CHECK CONSTRAINT [accounts$Accounts_respon_ID]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'physics_db.account_types' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'account_types'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'physics_db.accounts' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'accounts'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'physics_db.device_status' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'device_status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'physics_db.devices_tb' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'devices_tb'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'physics_db.`exp`' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'exp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'physics_db.labs' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'labs'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'physics_db.respon' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'respon'
GO
USE [master]
GO
ALTER DATABASE [physics_db] SET  READ_WRITE 
GO
