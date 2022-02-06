USE [master]
GO
/****** Object:  Database [CourseManagementPortal]    Script Date: 06.02.2022 13:34:34 ******/
CREATE DATABASE [CourseManagementPortal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CourseManagementPortal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLSERVER\MSSQL\DATA\CourseManagementPortal.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CourseManagementPortal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLSERVER\MSSQL\DATA\CourseManagementPortal_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CourseManagementPortal] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CourseManagementPortal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CourseManagementPortal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CourseManagementPortal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CourseManagementPortal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CourseManagementPortal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CourseManagementPortal] SET ARITHABORT OFF 
GO
ALTER DATABASE [CourseManagementPortal] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CourseManagementPortal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CourseManagementPortal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CourseManagementPortal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CourseManagementPortal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CourseManagementPortal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CourseManagementPortal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CourseManagementPortal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CourseManagementPortal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CourseManagementPortal] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CourseManagementPortal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CourseManagementPortal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CourseManagementPortal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CourseManagementPortal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CourseManagementPortal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CourseManagementPortal] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CourseManagementPortal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CourseManagementPortal] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CourseManagementPortal] SET  MULTI_USER 
GO
ALTER DATABASE [CourseManagementPortal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CourseManagementPortal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CourseManagementPortal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CourseManagementPortal] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CourseManagementPortal] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CourseManagementPortal] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CourseManagementPortal] SET QUERY_STORE = OFF
GO
USE [CourseManagementPortal]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 06.02.2022 13:34:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NOT NULL,
	[Comment] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 06.02.2022 13:34:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [nvarchar](50) NULL,
	[Comment] [nvarchar](500) NULL,
 CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 06.02.2022 13:34:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Duration] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[CreationTime] [date] NOT NULL,
	[ModificationTime] [date] NOT NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OngoingCourses]    Script Date: 06.02.2022 13:34:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OngoingCourses](
	[StudentId] [int] NOT NULL,
	[CourseId] [int] NOT NULL,
	[TeacherId] [int] NOT NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 06.02.2022 13:34:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[BirthDate] [datetime] NOT NULL,
	[CreationTime] [datetime] NOT NULL,
	[ModificationTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 06.02.2022 13:34:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[BirthDate] [datetime] NOT NULL,
	[Profession] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Comments] ON 

INSERT [dbo].[Comments] ([Id], [StudentName], [Comment]) VALUES (14, N'Şahalı', N'Dərsə hazırdır./Tarix- 04.02.2022 22:17:47')
INSERT [dbo].[Comments] ([Id], [StudentName], [Comment]) VALUES (15, N'İlkin', N'Dərsə hazırdır./Tarix- 04.02.2022 22:17:55')
INSERT [dbo].[Comments] ([Id], [StudentName], [Comment]) VALUES (16, N'Azad', N'Dərsə hazırdır./Tarix- 04.02.2022 22:18:00')
INSERT [dbo].[Comments] ([Id], [StudentName], [Comment]) VALUES (17, N'Malik', N'Tapşırıqları yazmayıb./Tarix- 04.02.2022 22:18:26')
INSERT [dbo].[Comments] ([Id], [StudentName], [Comment]) VALUES (18, N'Ayşə', N'Tapşırıqları yazmayıb./Tarix- 04.02.2022 22:18:35')
INSERT [dbo].[Comments] ([Id], [StudentName], [Comment]) VALUES (19, N'Arif', N'Dərsdə səs salır://Tarix- 04.02.2022 22:19:04')
INSERT [dbo].[Comments] ([Id], [StudentName], [Comment]) VALUES (20, N'Mehdi', N'Tapşırıqları yazmayıb./Tarix- 04.02.2022 22:19:19')
INSERT [dbo].[Comments] ([Id], [StudentName], [Comment]) VALUES (21, N'Nərmin', N'İştirak etməyib./Tarix- 04.02.2022 22:20:39')
SET IDENTITY_INSERT [dbo].[Comments] OFF
GO
SET IDENTITY_INSERT [dbo].[Course] ON 

INSERT [dbo].[Course] ([Id], [Name], [Duration], [Price], [CreationTime], [ModificationTime]) VALUES (9, N'Kimya', 5, 75, CAST(N'2022-01-01' AS Date), CAST(N'2022-05-01' AS Date))
INSERT [dbo].[Course] ([Id], [Name], [Duration], [Price], [CreationTime], [ModificationTime]) VALUES (10, N'Riyaziyyat', 6, 40, CAST(N'2021-12-01' AS Date), CAST(N'2022-05-01' AS Date))
INSERT [dbo].[Course] ([Id], [Name], [Duration], [Price], [CreationTime], [ModificationTime]) VALUES (11, N'Fizika', 6, 40, CAST(N'2021-12-01' AS Date), CAST(N'2022-05-01' AS Date))
INSERT [dbo].[Course] ([Id], [Name], [Duration], [Price], [CreationTime], [ModificationTime]) VALUES (12, N'Azərbaycan dili', 7, 50, CAST(N'2021-12-01' AS Date), CAST(N'2022-06-01' AS Date))
INSERT [dbo].[Course] ([Id], [Name], [Duration], [Price], [CreationTime], [ModificationTime]) VALUES (13, N'İngilis dili', 7, 50, CAST(N'2021-12-01' AS Date), CAST(N'2022-06-01' AS Date))
SET IDENTITY_INSERT [dbo].[Course] OFF
GO
INSERT [dbo].[OngoingCourses] ([StudentId], [CourseId], [TeacherId], [StartDate], [EndDate]) VALUES (3, 9, 7, CAST(N'2021-01-01' AS Date), CAST(N'2021-01-08' AS Date))
INSERT [dbo].[OngoingCourses] ([StudentId], [CourseId], [TeacherId], [StartDate], [EndDate]) VALUES (4, 10, 3, CAST(N'2021-01-01' AS Date), CAST(N'2021-01-06' AS Date))
INSERT [dbo].[OngoingCourses] ([StudentId], [CourseId], [TeacherId], [StartDate], [EndDate]) VALUES (5, 11, 4, CAST(N'2021-01-01' AS Date), CAST(N'2021-01-07' AS Date))
INSERT [dbo].[OngoingCourses] ([StudentId], [CourseId], [TeacherId], [StartDate], [EndDate]) VALUES (6, 12, 5, CAST(N'2021-01-01' AS Date), CAST(N'2021-01-07' AS Date))
INSERT [dbo].[OngoingCourses] ([StudentId], [CourseId], [TeacherId], [StartDate], [EndDate]) VALUES (7, 13, 7, CAST(N'2021-01-01' AS Date), CAST(N'2021-01-08' AS Date))
INSERT [dbo].[OngoingCourses] ([StudentId], [CourseId], [TeacherId], [StartDate], [EndDate]) VALUES (8, 9, 3, CAST(N'2021-01-01' AS Date), CAST(N'2021-01-06' AS Date))
INSERT [dbo].[OngoingCourses] ([StudentId], [CourseId], [TeacherId], [StartDate], [EndDate]) VALUES (9, 10, 4, CAST(N'2021-01-01' AS Date), CAST(N'2021-01-07' AS Date))
INSERT [dbo].[OngoingCourses] ([StudentId], [CourseId], [TeacherId], [StartDate], [EndDate]) VALUES (10, 11, 5, CAST(N'2021-01-01' AS Date), CAST(N'2021-01-07' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (3, N'Şahalı', N'Şahalıyev', CAST(N'2004-10-20T23:14:09.000' AS DateTime), CAST(N'2021-12-01T23:14:09.000' AS DateTime), CAST(N'2022-05-01T23:14:09.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (4, N'İlkin', N'Şahalıyev', CAST(N'2002-09-15T23:14:09.000' AS DateTime), CAST(N'2022-01-01T23:14:09.000' AS DateTime), CAST(N'2022-05-01T23:14:09.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (5, N'Azad', N'Abbasov', CAST(N'2004-06-16T23:14:09.000' AS DateTime), CAST(N'2022-01-13T23:14:09.000' AS DateTime), CAST(N'2022-05-01T23:14:09.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (6, N'Malik', N'Məmmədov', CAST(N'2004-08-22T23:14:09.000' AS DateTime), CAST(N'2022-01-13T23:14:09.000' AS DateTime), CAST(N'2022-04-22T23:14:09.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (7, N'Ayşə', N'Ramazanova', CAST(N'2004-08-12T23:14:09.000' AS DateTime), CAST(N'2022-01-13T23:14:09.000' AS DateTime), CAST(N'2022-04-22T23:14:09.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (8, N'Nərmin', N'Vəliyeva', CAST(N'2004-08-12T23:14:09.000' AS DateTime), CAST(N'2022-01-13T23:14:09.000' AS DateTime), CAST(N'2022-04-22T23:14:09.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (9, N'Arif', N'Vəliyev', CAST(N'2004-02-19T23:14:09.000' AS DateTime), CAST(N'2022-01-13T23:14:09.000' AS DateTime), CAST(N'2022-04-22T23:14:09.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (10, N'Mehdi', N'Əliyev', CAST(N'2004-12-13T23:14:09.000' AS DateTime), CAST(N'2022-01-13T23:14:09.000' AS DateTime), CAST(N'2022-04-22T23:14:09.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (3, N'Namiq', N'Atayev', CAST(N'1989-01-01T23:19:43.000' AS DateTime), N'Riyaziyyat ')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (4, N'Ələkbər', N'Mamedov', CAST(N'1985-03-01T23:19:43.000' AS DateTime), N'Kimya')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (5, N'Lalə', N'Abdulova', CAST(N'1990-06-06T23:19:43.000' AS DateTime), N'Azərbaycan dili')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (6, N'Samirə', N'Osmanova', CAST(N'1994-05-17T23:19:43.000' AS DateTime), N'Fizika')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (7, N'Samir', N'Əhmədov', CAST(N'1993-07-07T23:19:43.000' AS DateTime), N'İngilis dili')
SET IDENTITY_INSERT [dbo].[Teacher] OFF
GO
USE [master]
GO
ALTER DATABASE [CourseManagementPortal] SET  READ_WRITE 
GO
