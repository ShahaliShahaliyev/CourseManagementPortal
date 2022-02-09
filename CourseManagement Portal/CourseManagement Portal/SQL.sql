USE [master]
GO
/****** Object:  Database [CourseManagementPortal]    Script Date: 09.02.2022 18:51:33 ******/
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
/****** Object:  Table [dbo].[CommentForStudent]    Script Date: 09.02.2022 18:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommentForStudent](
	[Student] [nvarchar](50) NOT NULL,
	[Course] [nvarchar](50) NOT NULL,
	[Lesson] [nvarchar](50) NOT NULL,
	[Date] [date] NOT NULL,
	[Attendance] [nvarchar](50) NOT NULL,
	[Comment] [nvarchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 09.02.2022 18:51:33 ******/
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
/****** Object:  Table [dbo].[StartedCourses]    Script Date: 09.02.2022 18:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StartedCourses](
	[StudentName] [nvarchar](50) NOT NULL,
	[CourseName] [nvarchar](50) NOT NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[Duration] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 09.02.2022 18:51:33 ******/
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
/****** Object:  Table [dbo].[Teacher]    Script Date: 09.02.2022 18:51:33 ******/
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
INSERT [dbo].[CommentForStudent] ([Student], [Course], [Lesson], [Date], [Attendance], [Comment]) VALUES (N'Azad', N'Riyaziyyat', N'Fiqurlar', CAST(N'2022-02-09' AS Date), N'İştirak edib', N'Hazirdir')
INSERT [dbo].[CommentForStudent] ([Student], [Course], [Lesson], [Date], [Attendance], [Comment]) VALUES (N'Malik', N'Fizika', N'Təcil', CAST(N'2022-02-09' AS Date), N'İştirak edib', N'Hazırdır')
INSERT [dbo].[CommentForStudent] ([Student], [Course], [Lesson], [Date], [Attendance], [Comment]) VALUES (N'Nərmin', N'Kimya', N'Qələvilər', CAST(N'2022-02-09' AS Date), N'İştirak etməyib', N'')
INSERT [dbo].[CommentForStudent] ([Student], [Course], [Lesson], [Date], [Attendance], [Comment]) VALUES (N'Ilkin', N'İngilis dili', N'Noun', CAST(N'2022-02-09' AS Date), N'İştirak edib', N'Hazırdır')
GO
SET IDENTITY_INSERT [dbo].[Course] ON 

INSERT [dbo].[Course] ([Id], [Name], [Duration], [Price], [CreationTime], [ModificationTime]) VALUES (9, N'Kimya', 5, 60, CAST(N'2022-01-01' AS Date), CAST(N'2022-02-09' AS Date))
INSERT [dbo].[Course] ([Id], [Name], [Duration], [Price], [CreationTime], [ModificationTime]) VALUES (10, N'Riyaziyyat', 6, 50, CAST(N'2021-11-29' AS Date), CAST(N'2022-02-07' AS Date))
INSERT [dbo].[Course] ([Id], [Name], [Duration], [Price], [CreationTime], [ModificationTime]) VALUES (11, N'Fizika', 6, 40, CAST(N'2021-12-01' AS Date), CAST(N'2022-05-01' AS Date))
INSERT [dbo].[Course] ([Id], [Name], [Duration], [Price], [CreationTime], [ModificationTime]) VALUES (12, N'Azərbaycan dili', 7, 50, CAST(N'2021-12-01' AS Date), CAST(N'2022-06-01' AS Date))
INSERT [dbo].[Course] ([Id], [Name], [Duration], [Price], [CreationTime], [ModificationTime]) VALUES (13, N'İngilis dili', 7, 60, CAST(N'2021-12-01' AS Date), CAST(N'2022-02-07' AS Date))
INSERT [dbo].[Course] ([Id], [Name], [Duration], [Price], [CreationTime], [ModificationTime]) VALUES (25, N'Biologiya', 5, 100, CAST(N'2022-02-07' AS Date), CAST(N'2022-07-07' AS Date))
SET IDENTITY_INSERT [dbo].[Course] OFF
GO
INSERT [dbo].[StartedCourses] ([StudentName], [CourseName], [StartDate], [EndDate], [Duration]) VALUES (N'Azad', N'Riyaziyyat', CAST(N'2022-02-08' AS Date), CAST(N'2022-06-08' AS Date), 4)
INSERT [dbo].[StartedCourses] ([StudentName], [CourseName], [StartDate], [EndDate], [Duration]) VALUES (N'Malik', N'Fizika', CAST(N'2022-02-08' AS Date), CAST(N'2022-08-08' AS Date), 6)
INSERT [dbo].[StartedCourses] ([StudentName], [CourseName], [StartDate], [EndDate], [Duration]) VALUES (N'Nərmin', N'Kimya', CAST(N'2022-02-08' AS Date), CAST(N'2022-06-08' AS Date), 4)
INSERT [dbo].[StartedCourses] ([StudentName], [CourseName], [StartDate], [EndDate], [Duration]) VALUES (N'Ilkin', N'İngilis dili', CAST(N'2022-02-09' AS Date), CAST(N'2022-07-09' AS Date), 5)
INSERT [dbo].[StartedCourses] ([StudentName], [CourseName], [StartDate], [EndDate], [Duration]) VALUES (N'Mehdi', N'Azərbaycan dili', CAST(N'2022-02-08' AS Date), CAST(N'2022-08-08' AS Date), 6)
INSERT [dbo].[StartedCourses] ([StudentName], [CourseName], [StartDate], [EndDate], [Duration]) VALUES (N'Ayan', N'Biologiya', CAST(N'2022-02-09' AS Date), CAST(N'2022-07-09' AS Date), 5)
INSERT [dbo].[StartedCourses] ([StudentName], [CourseName], [StartDate], [EndDate], [Duration]) VALUES (N'Arif', N'Kimya', CAST(N'2022-02-09' AS Date), CAST(N'2022-07-09' AS Date), 5)
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (3, N'Narmin', N'Vəliyeva', CAST(N'2004-10-20T23:14:09.000' AS DateTime), CAST(N'2021-12-01T23:14:09.000' AS DateTime), CAST(N'2022-02-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (4, N'Ilkin', N'Şahalıyev', CAST(N'2002-09-15T23:14:09.000' AS DateTime), CAST(N'2022-01-01T23:14:09.000' AS DateTime), CAST(N'2022-02-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (5, N'Azad', N'Abbasov', CAST(N'2004-06-16T23:14:09.000' AS DateTime), CAST(N'2022-01-13T23:14:09.000' AS DateTime), CAST(N'2022-05-01T23:14:09.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (6, N'Malik', N'Məmmədov', CAST(N'2004-08-22T23:14:09.000' AS DateTime), CAST(N'2022-01-13T23:14:09.000' AS DateTime), CAST(N'2022-02-07T00:00:00.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (7, N'Ayan', N'Ramazanova', CAST(N'2004-08-12T23:14:09.000' AS DateTime), CAST(N'2022-01-13T23:14:09.000' AS DateTime), CAST(N'2022-02-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (9, N'Arif', N'Vəliyev', CAST(N'2004-02-19T23:14:09.000' AS DateTime), CAST(N'2022-01-13T23:14:09.000' AS DateTime), CAST(N'2022-02-07T00:00:00.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (10, N'Mehdi', N'Əliyev', CAST(N'2004-12-13T23:14:09.000' AS DateTime), CAST(N'2022-01-13T23:14:09.000' AS DateTime), CAST(N'2022-02-07T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (4, N'Ələkbər', N'Mamedov', CAST(N'1985-03-01T23:19:43.000' AS DateTime), N'Kimya')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (5, N'Lalə', N'Abdulova', CAST(N'1990-06-06T23:19:43.000' AS DateTime), N'Azərbaycan dili')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (6, N'Samirə', N'Osmanova', CAST(N'1994-05-17T23:19:43.000' AS DateTime), N'Fizika')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (7, N'Samir', N'Əhmədov', CAST(N'1993-07-07T23:19:43.000' AS DateTime), N'İngilis dili')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (16, N'Abbas', N'Adilov', CAST(N'1997-06-05T16:30:23.000' AS DateTime), N'Riyaziyyat')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (17, N'Abdulla', N'Abdullayev', CAST(N'1990-01-31T03:05:41.000' AS DateTime), N'Biologiya')
SET IDENTITY_INSERT [dbo].[Teacher] OFF
GO
USE [master]
GO
ALTER DATABASE [CourseManagementPortal] SET  READ_WRITE 
GO
