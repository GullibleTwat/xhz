USE [master]
GO
/****** Object:  Database [xhz]    Script Date: 04/23/2014 22:29:20 ******/
CREATE DATABASE [xhz] ON  PRIMARY 
( NAME = N'xhz', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\xhz.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'xhz_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\xhz_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [xhz] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [xhz].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [xhz] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [xhz] SET ANSI_NULLS OFF
GO
ALTER DATABASE [xhz] SET ANSI_PADDING OFF
GO
ALTER DATABASE [xhz] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [xhz] SET ARITHABORT OFF
GO
ALTER DATABASE [xhz] SET AUTO_CLOSE ON
GO
ALTER DATABASE [xhz] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [xhz] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [xhz] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [xhz] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [xhz] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [xhz] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [xhz] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [xhz] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [xhz] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [xhz] SET  DISABLE_BROKER
GO
ALTER DATABASE [xhz] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [xhz] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [xhz] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [xhz] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [xhz] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [xhz] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [xhz] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [xhz] SET  READ_WRITE
GO
ALTER DATABASE [xhz] SET RECOVERY SIMPLE
GO
ALTER DATABASE [xhz] SET  MULTI_USER
GO
ALTER DATABASE [xhz] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [xhz] SET DB_CHAINING OFF
GO
USE [xhz]
GO
/****** Object:  Table [dbo].[Message]    Script Date: 04/23/2014 22:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Message](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Title] [nvarchar](50) NULL,
	[Content] [nvarchar](max) NULL,
	[Time] [datetime] NULL,
	[Email] [nvarchar](50) NULL,
	[Mobile] [char](11) NULL,
	[Phone] [char](11) NULL,
	[S1] [nvarchar](100) NULL,
 CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'称呼' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Message', @level2type=N'COLUMN',@level2name=N'UserName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Message', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Message', @level2type=N'COLUMN',@level2name=N'Content'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发布时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Message', @level2type=N'COLUMN',@level2name=N'Time'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电子邮箱' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Message', @level2type=N'COLUMN',@level2name=N'Email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'手机' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Message', @level2type=N'COLUMN',@level2name=N'Mobile'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Message', @level2type=N'COLUMN',@level2name=N'Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备用' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Message', @level2type=N'COLUMN',@level2name=N'S1'
GO
/****** Object:  Table [dbo].[Evaluate]    Script Date: 04/23/2014 22:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluate](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[Content] [nvarchar](max) NULL,
	[Time] [datetime] NULL,
	[IsOpen] [bit] NULL,
	[Click] [int] NULL,
 CONSTRAINT [PK_Evaluate] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Evaluate', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Evaluate', @level2type=N'COLUMN',@level2name=N'Content'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发布时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Evaluate', @level2type=N'COLUMN',@level2name=N'Time'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否显示' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Evaluate', @level2type=N'COLUMN',@level2name=N'IsOpen'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'点击数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Evaluate', @level2type=N'COLUMN',@level2name=N'Click'
GO
/****** Object:  Table [dbo].[Essays]    Script Date: 04/23/2014 22:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Essays](
	[NewsID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[Content] [nvarchar](max) NULL,
	[Time] [datetime] NULL,
	[IsOpen] [bit] NULL,
	[S1] [nvarchar](100) NULL,
	[Click] [int] NULL,
 CONSTRAINT [PK_Essays] PRIMARY KEY CLUSTERED 
(
	[NewsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Essays', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Essays', @level2type=N'COLUMN',@level2name=N'Content'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发布时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Essays', @level2type=N'COLUMN',@level2name=N'Time'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否显示' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Essays', @level2type=N'COLUMN',@level2name=N'IsOpen'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备用' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Essays', @level2type=N'COLUMN',@level2name=N'S1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'点击数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Essays', @level2type=N'COLUMN',@level2name=N'Click'
GO
/****** Object:  Table [dbo].[ArtsMatterGroup]    Script Date: 04/23/2014 22:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArtsMatterGroup](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
 CONSTRAINT [PK_ArtsMatterGroup] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'组名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArtsMatterGroup', @level2type=N'COLUMN',@level2name=N'Title'
GO
/****** Object:  Table [dbo].[WorksItem]    Script Date: 04/23/2014 22:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorksItem](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
 CONSTRAINT [PK_WorksItem] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WorksItem', @level2type=N'COLUMN',@level2name=N'Title'
GO
/****** Object:  Table [dbo].[WorksGroup]    Script Date: 04/23/2014 22:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorksGroup](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
 CONSTRAINT [PK_WorksGroup] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'组名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WorksGroup', @level2type=N'COLUMN',@level2name=N'Title'
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 04/23/2014 22:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[ID] [nvarchar](10) NOT NULL,
	[Passwd] [nvarchar](50) NOT NULL,
	[Power] [int] NOT NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Admin', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Admin', @level2type=N'COLUMN',@level2name=N'Passwd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'权限' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Admin', @level2type=N'COLUMN',@level2name=N'Power'
GO
/****** Object:  Table [dbo].[NewsGroup]    Script Date: 04/23/2014 22:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewsGroup](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
 CONSTRAINT [PK_NewsGroup] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'组名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NewsGroup', @level2type=N'COLUMN',@level2name=N'Title'
GO
/****** Object:  Table [dbo].[News]    Script Date: 04/23/2014 22:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[News](
	[NewsID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[Content] [nvarchar](max) NULL,
	[Time] [datetime] NULL,
	[Attachment] [nvarchar](100) NULL,
	[GroupID] [int] NOT NULL,
	[IsOpen] [bit] NULL,
	[Click] [int] NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[NewsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'News', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'News', @level2type=N'COLUMN',@level2name=N'Content'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发布时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'News', @level2type=N'COLUMN',@level2name=N'Time'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'附件' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'News', @level2type=N'COLUMN',@level2name=N'Attachment'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分组' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'News', @level2type=N'COLUMN',@level2name=N'GroupID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否显示' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'News', @level2type=N'COLUMN',@level2name=N'IsOpen'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'点击数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'News', @level2type=N'COLUMN',@level2name=N'Click'
GO
/****** Object:  Table [dbo].[Works]    Script Date: 04/23/2014 22:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Works](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[Content] [nvarchar](max) NULL,
	[Time] [datetime] NULL,
	[Attachment] [nvarchar](100) NULL,
	[ItemID] [int] NOT NULL,
	[GroupID] [int] NOT NULL,
	[IsOpen] [bit] NULL,
	[Click] [int] NULL,
	[S1] [nvarchar](100) NULL,
	[S2] [nvarchar](100) NULL,
 CONSTRAINT [PK_Works] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Works', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Works', @level2type=N'COLUMN',@level2name=N'Content'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发布时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Works', @level2type=N'COLUMN',@level2name=N'Time'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'附件' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Works', @level2type=N'COLUMN',@level2name=N'Attachment'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Works', @level2type=N'COLUMN',@level2name=N'ItemID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分组' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Works', @level2type=N'COLUMN',@level2name=N'GroupID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否显示' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Works', @level2type=N'COLUMN',@level2name=N'IsOpen'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'点击数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Works', @level2type=N'COLUMN',@level2name=N'Click'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备用' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Works', @level2type=N'COLUMN',@level2name=N'S1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备用2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Works', @level2type=N'COLUMN',@level2name=N'S2'
GO
/****** Object:  Table [dbo].[ArtsMatter]    Script Date: 04/23/2014 22:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArtsMatter](
	[NewsID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[Content] [nvarchar](max) NULL,
	[Time] [datetime] NULL,
	[Attachment] [nvarchar](100) NULL,
	[GroupID] [int] NOT NULL,
	[IsOpen] [bit] NULL,
	[Click] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArtsMatter', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArtsMatter', @level2type=N'COLUMN',@level2name=N'Content'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发布时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArtsMatter', @level2type=N'COLUMN',@level2name=N'Time'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'附件' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArtsMatter', @level2type=N'COLUMN',@level2name=N'Attachment'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分组' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArtsMatter', @level2type=N'COLUMN',@level2name=N'GroupID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否显示' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArtsMatter', @level2type=N'COLUMN',@level2name=N'IsOpen'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'点击数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArtsMatter', @level2type=N'COLUMN',@level2name=N'Click'
GO
/****** Object:  Default [DF_Message_Time]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[Message] ADD  CONSTRAINT [DF_Message_Time]  DEFAULT (getdate()) FOR [Time]
GO
/****** Object:  Default [DF_Evaluate_Time]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[Evaluate] ADD  CONSTRAINT [DF_Evaluate_Time]  DEFAULT (getdate()) FOR [Time]
GO
/****** Object:  Default [DF_Evaluate_IsOpen]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[Evaluate] ADD  CONSTRAINT [DF_Evaluate_IsOpen]  DEFAULT ((1)) FOR [IsOpen]
GO
/****** Object:  Default [DF_Evaluate_Click]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[Evaluate] ADD  CONSTRAINT [DF_Evaluate_Click]  DEFAULT ((0)) FOR [Click]
GO
/****** Object:  Default [DF_Essays_Time]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[Essays] ADD  CONSTRAINT [DF_Essays_Time]  DEFAULT (getdate()) FOR [Time]
GO
/****** Object:  Default [DF_Essays_IsOpen]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[Essays] ADD  CONSTRAINT [DF_Essays_IsOpen]  DEFAULT ((1)) FOR [IsOpen]
GO
/****** Object:  Default [DF_Essays_Click]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[Essays] ADD  CONSTRAINT [DF_Essays_Click]  DEFAULT ((0)) FOR [Click]
GO
/****** Object:  Default [DF_News_Time]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[News] ADD  CONSTRAINT [DF_News_Time]  DEFAULT (getdate()) FOR [Time]
GO
/****** Object:  Default [DF_News_IsOpen]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[News] ADD  CONSTRAINT [DF_News_IsOpen]  DEFAULT ((1)) FOR [IsOpen]
GO
/****** Object:  Default [DF_News_Click]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[News] ADD  CONSTRAINT [DF_News_Click]  DEFAULT ((0)) FOR [Click]
GO
/****** Object:  Default [DF_Works_Time]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[Works] ADD  CONSTRAINT [DF_Works_Time]  DEFAULT (getdate()) FOR [Time]
GO
/****** Object:  Default [DF_Works_IsOpen]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[Works] ADD  CONSTRAINT [DF_Works_IsOpen]  DEFAULT ((1)) FOR [IsOpen]
GO
/****** Object:  Default [DF_Works_Click]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[Works] ADD  CONSTRAINT [DF_Works_Click]  DEFAULT ((0)) FOR [Click]
GO
/****** Object:  Default [DF_ArtsMatter_Time]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[ArtsMatter] ADD  CONSTRAINT [DF_ArtsMatter_Time]  DEFAULT (getdate()) FOR [Time]
GO
/****** Object:  Default [DF_ArtsMatter_IsOpen]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[ArtsMatter] ADD  CONSTRAINT [DF_ArtsMatter_IsOpen]  DEFAULT ((1)) FOR [IsOpen]
GO
/****** Object:  Default [DF_ArtsMatter_Click]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[ArtsMatter] ADD  CONSTRAINT [DF_ArtsMatter_Click]  DEFAULT ((0)) FOR [Click]
GO
/****** Object:  ForeignKey [FK_News_News]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[News]  WITH NOCHECK ADD  CONSTRAINT [FK_News_News] FOREIGN KEY([GroupID])
REFERENCES [dbo].[NewsGroup] ([ID])
GO
ALTER TABLE [dbo].[News] NOCHECK CONSTRAINT [FK_News_News]
GO
/****** Object:  ForeignKey [FK_Works_WorksGroup]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[Works]  WITH CHECK ADD  CONSTRAINT [FK_Works_WorksGroup] FOREIGN KEY([GroupID])
REFERENCES [dbo].[WorksGroup] ([ID])
GO
ALTER TABLE [dbo].[Works] CHECK CONSTRAINT [FK_Works_WorksGroup]
GO
/****** Object:  ForeignKey [FK_Works_WorksItem]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[Works]  WITH CHECK ADD  CONSTRAINT [FK_Works_WorksItem] FOREIGN KEY([ItemID])
REFERENCES [dbo].[WorksItem] ([ID])
GO
ALTER TABLE [dbo].[Works] CHECK CONSTRAINT [FK_Works_WorksItem]
GO
/****** Object:  ForeignKey [FK_ArtsMatter_ArtsMatterGroup]    Script Date: 04/23/2014 22:29:22 ******/
ALTER TABLE [dbo].[ArtsMatter]  WITH CHECK ADD  CONSTRAINT [FK_ArtsMatter_ArtsMatterGroup] FOREIGN KEY([GroupID])
REFERENCES [dbo].[ArtsMatterGroup] ([ID])
GO
ALTER TABLE [dbo].[ArtsMatter] CHECK CONSTRAINT [FK_ArtsMatter_ArtsMatterGroup]
GO
