USE [master]
GO
/****** Object:  Database [CourseManagementPortal]    Script Date: 08.03.2022 01:25:01 ******/
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
/****** Object:  Table [dbo].[AddStudentToGroup]    Script Date: 08.03.2022 01:25:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AddStudentToGroup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CourseId] [int] NOT NULL,
	[GroupId] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
 CONSTRAINT [PK_AddStudentToGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 08.03.2022 01:25:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CourseId] [int] NOT NULL,
	[GroupId] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
	[Lesson] [nvarchar](50) NOT NULL,
	[Date] [date] NOT NULL,
	[Attendance] [nvarchar](50) NOT NULL,
	[Comment] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 08.03.2022 01:25:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[Id] [int] IDENTITY(100,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Duration] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[CreationTime] [date] NOT NULL,
	[ModificationTime] [date] NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NewGroup]    Script Date: 08.03.2022 01:25:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewGroup](
	[GroupId] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [nvarchar](50) NOT NULL,
	[CourseId] [int] NOT NULL,
	[PlannedStartDate] [date] NOT NULL,
	[PlannedEndDate] [date] NOT NULL,
 CONSTRAINT [PK_NewGroup] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 08.03.2022 01:25:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(100,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[BirthDate] [datetime] NOT NULL,
	[CreationTime] [datetime] NOT NULL,
	[ModificationTime] [datetime] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 08.03.2022 01:25:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[Id] [int] IDENTITY(100,1) NOT NULL,
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
/****** Object:  Table [dbo].[TeacherAndCourses]    Script Date: 08.03.2022 01:25:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeacherAndCourses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TeacherId] [int] NOT NULL,
	[CourseId] [int] NOT NULL,
 CONSTRAINT [PK_TeacherAndCourses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AddStudentToGroup] ON 

INSERT [dbo].[AddStudentToGroup] ([Id], [CourseId], [GroupId], [StudentId]) VALUES (1, 100, 2, 100)
INSERT [dbo].[AddStudentToGroup] ([Id], [CourseId], [GroupId], [StudentId]) VALUES (2, 100, 1, 103)
INSERT [dbo].[AddStudentToGroup] ([Id], [CourseId], [GroupId], [StudentId]) VALUES (3, 103, 2, 106)
INSERT [dbo].[AddStudentToGroup] ([Id], [CourseId], [GroupId], [StudentId]) VALUES (4, 102, 8, 101)
INSERT [dbo].[AddStudentToGroup] ([Id], [CourseId], [GroupId], [StudentId]) VALUES (5, 100, 5, 103)
INSERT [dbo].[AddStudentToGroup] ([Id], [CourseId], [GroupId], [StudentId]) VALUES (6, 103, 2, 104)
INSERT [dbo].[AddStudentToGroup] ([Id], [CourseId], [GroupId], [StudentId]) VALUES (7, 106, 3, 100)
INSERT [dbo].[AddStudentToGroup] ([Id], [CourseId], [GroupId], [StudentId]) VALUES (8, 106, 3, 101)
SET IDENTITY_INSERT [dbo].[AddStudentToGroup] OFF
GO
SET IDENTITY_INSERT [dbo].[Comment] ON 

INSERT [dbo].[Comment] ([Id], [CourseId], [GroupId], [StudentId], [Lesson], [Date], [Attendance], [Comment]) VALUES (3, 102, 8, 101, N'Fizika nedir?', CAST(N'2022-02-26' AS Date), N'In Lesson', N'So good')
INSERT [dbo].[Comment] ([Id], [CourseId], [GroupId], [StudentId], [Lesson], [Date], [Attendance], [Comment]) VALUES (4, 100, 5, 103, N'Rasional  Ededler', CAST(N'2022-03-03' AS Date), N'Not In Lesson', N'')
SET IDENTITY_INSERT [dbo].[Comment] OFF
GO
SET IDENTITY_INSERT [dbo].[Course] ON 

INSERT [dbo].[Course] ([Id], [Name], [Duration], [Price], [CreationTime], [ModificationTime]) VALUES (100, N'Riyaziyyat', 10, 50, CAST(N'2022-02-24' AS Date), CAST(N'2022-12-24' AS Date))
INSERT [dbo].[Course] ([Id], [Name], [Duration], [Price], [CreationTime], [ModificationTime]) VALUES (101, N'Kimya', 10, 50, CAST(N'2022-02-24' AS Date), CAST(N'2022-12-24' AS Date))
INSERT [dbo].[Course] ([Id], [Name], [Duration], [Price], [CreationTime], [ModificationTime]) VALUES (102, N'Fizika', 10, 50, CAST(N'2022-02-24' AS Date), CAST(N'2022-12-24' AS Date))
INSERT [dbo].[Course] ([Id], [Name], [Duration], [Price], [CreationTime], [ModificationTime]) VALUES (103, N'Tarix', 7, 50, CAST(N'2022-02-24' AS Date), CAST(N'2022-09-24' AS Date))
INSERT [dbo].[Course] ([Id], [Name], [Duration], [Price], [CreationTime], [ModificationTime]) VALUES (104, N'Biologiya', 7, 50, CAST(N'2022-02-24' AS Date), CAST(N'2022-09-24' AS Date))
INSERT [dbo].[Course] ([Id], [Name], [Duration], [Price], [CreationTime], [ModificationTime]) VALUES (105, N'Informatika', 7, 50, CAST(N'2022-02-24' AS Date), CAST(N'2022-09-24' AS Date))
INSERT [dbo].[Course] ([Id], [Name], [Duration], [Price], [CreationTime], [ModificationTime]) VALUES (106, N'Programming', 6, 100, CAST(N'2022-02-24' AS Date), CAST(N'2022-08-24' AS Date))
INSERT [dbo].[Course] ([Id], [Name], [Duration], [Price], [CreationTime], [ModificationTime]) VALUES (107, N'English', 6, 90, CAST(N'2022-03-03' AS Date), CAST(N'2022-09-03' AS Date))
SET IDENTITY_INSERT [dbo].[Course] OFF
GO
SET IDENTITY_INSERT [dbo].[NewGroup] ON 

INSERT [dbo].[NewGroup] ([GroupId], [GroupName], [CourseId], [PlannedStartDate], [PlannedEndDate]) VALUES (1, N'Kimya 1', 101, CAST(N'2022-03-25' AS Date), CAST(N'2022-08-25' AS Date))
INSERT [dbo].[NewGroup] ([GroupId], [GroupName], [CourseId], [PlannedStartDate], [PlannedEndDate]) VALUES (2, N'Tarix 1', 103, CAST(N'2022-01-25' AS Date), CAST(N'2022-08-25' AS Date))
INSERT [dbo].[NewGroup] ([GroupId], [GroupName], [CourseId], [PlannedStartDate], [PlannedEndDate]) VALUES (3, N'Programming 1', 106, CAST(N'2022-01-25' AS Date), CAST(N'2022-08-25' AS Date))
INSERT [dbo].[NewGroup] ([GroupId], [GroupName], [CourseId], [PlannedStartDate], [PlannedEndDate]) VALUES (4, N'Kimya 2', 101, CAST(N'2022-01-25' AS Date), CAST(N'2022-08-25' AS Date))
INSERT [dbo].[NewGroup] ([GroupId], [GroupName], [CourseId], [PlannedStartDate], [PlannedEndDate]) VALUES (5, N'Riyaziyyat 1', 100, CAST(N'2022-01-25' AS Date), CAST(N'2022-08-25' AS Date))
INSERT [dbo].[NewGroup] ([GroupId], [GroupName], [CourseId], [PlannedStartDate], [PlannedEndDate]) VALUES (6, N'Kimya 3', 101, CAST(N'2022-01-25' AS Date), CAST(N'2022-08-25' AS Date))
INSERT [dbo].[NewGroup] ([GroupId], [GroupName], [CourseId], [PlannedStartDate], [PlannedEndDate]) VALUES (7, N'Riyaziyyat 2', 100, CAST(N'2022-01-25' AS Date), CAST(N'2022-08-25' AS Date))
INSERT [dbo].[NewGroup] ([GroupId], [GroupName], [CourseId], [PlannedStartDate], [PlannedEndDate]) VALUES (8, N'Fizika 1', 102, CAST(N'2022-02-26' AS Date), CAST(N'2022-08-25' AS Date))
SET IDENTITY_INSERT [dbo].[NewGroup] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (100, N'Shahali', N'Shahaliyev', CAST(N'2004-10-20T16:11:54.000' AS DateTime), CAST(N'2022-02-24T00:00:00.000' AS DateTime), CAST(N'2022-03-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (101, N'Ilkin', N'Shahaliyev', CAST(N'2002-09-15T19:09:30.000' AS DateTime), CAST(N'2022-02-24T00:00:00.000' AS DateTime), CAST(N'2022-02-24T00:00:00.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (102, N'Azad', N'Abbasov', CAST(N'2004-06-16T19:09:30.000' AS DateTime), CAST(N'2022-02-24T00:00:00.000' AS DateTime), CAST(N'2022-02-24T00:00:00.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (103, N'Malik', N'Memmedli', CAST(N'2004-08-22T19:09:30.000' AS DateTime), CAST(N'2022-02-24T00:00:00.000' AS DateTime), CAST(N'2022-02-24T00:00:00.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (104, N'Emrah', N'Eliyev', CAST(N'2004-07-27T19:09:30.000' AS DateTime), CAST(N'2022-02-24T00:00:00.000' AS DateTime), CAST(N'2022-02-24T00:00:00.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (105, N'Nihat', N'Veliyev', CAST(N'2004-09-24T19:09:30.000' AS DateTime), CAST(N'2022-02-24T00:00:00.000' AS DateTime), CAST(N'2022-02-24T00:00:00.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (106, N'Aysel', N'Memmedova', CAST(N'2005-10-19T19:09:30.000' AS DateTime), CAST(N'2022-02-24T00:00:00.000' AS DateTime), CAST(N'2022-02-24T00:00:00.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [CreationTime], [ModificationTime]) VALUES (107, N'Samire', N'Ehmedova', CAST(N'2003-06-01T19:09:30.000' AS DateTime), CAST(N'2022-02-24T00:00:00.000' AS DateTime), CAST(N'2022-02-24T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (100, N'Nurlan', N'Valizada', CAST(N'1992-06-06T19:55:23.000' AS DateTime), N'Programming')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (101, N'Samire', N'Ehmedova', CAST(N'1984-06-02T19:55:23.000' AS DateTime), N'Kimya')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (102, N'Tahir', N'Aydinov', CAST(N'1983-10-21T19:55:23.000' AS DateTime), N'Tarix')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (103, N'Abbas', N'Salayev', CAST(N'1989-01-18T19:55:23.000' AS DateTime), N'Riyaziyyat')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (104, N'Fikret', N'Nebiyev', CAST(N'1988-12-29T19:55:23.000' AS DateTime), N'Fizika')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (105, N'Feride', N'Nebiyeva', CAST(N'1997-03-13T19:55:23.000' AS DateTime), N'Biologiya')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (106, N'Mehdi', N'Ehmedov', CAST(N'1994-11-30T19:55:23.000' AS DateTime), N'Informatika')
SET IDENTITY_INSERT [dbo].[Teacher] OFF
GO
SET IDENTITY_INSERT [dbo].[TeacherAndCourses] ON 

INSERT [dbo].[TeacherAndCourses] ([Id], [TeacherId], [CourseId]) VALUES (6, 100, 106)
INSERT [dbo].[TeacherAndCourses] ([Id], [TeacherId], [CourseId]) VALUES (7, 103, 100)
SET IDENTITY_INSERT [dbo].[TeacherAndCourses] OFF
GO
ALTER TABLE [dbo].[AddStudentToGroup]  WITH CHECK ADD  CONSTRAINT [FK_AddStudentToGroup_Course] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([Id])
GO
ALTER TABLE [dbo].[AddStudentToGroup] CHECK CONSTRAINT [FK_AddStudentToGroup_Course]
GO
ALTER TABLE [dbo].[AddStudentToGroup]  WITH CHECK ADD  CONSTRAINT [FK_AddStudentToGroup_NewGroup] FOREIGN KEY([GroupId])
REFERENCES [dbo].[NewGroup] ([GroupId])
GO
ALTER TABLE [dbo].[AddStudentToGroup] CHECK CONSTRAINT [FK_AddStudentToGroup_NewGroup]
GO
ALTER TABLE [dbo].[AddStudentToGroup]  WITH CHECK ADD  CONSTRAINT [FK_AddStudentToGroup_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[AddStudentToGroup] CHECK CONSTRAINT [FK_AddStudentToGroup_Student]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Course] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([Id])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Course]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_NewGroup] FOREIGN KEY([GroupId])
REFERENCES [dbo].[NewGroup] ([GroupId])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_NewGroup]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Student]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Student1] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Student1]
GO
ALTER TABLE [dbo].[NewGroup]  WITH CHECK ADD  CONSTRAINT [FK_NewGroup_Course] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([Id])
GO
ALTER TABLE [dbo].[NewGroup] CHECK CONSTRAINT [FK_NewGroup_Course]
GO
ALTER TABLE [dbo].[TeacherAndCourses]  WITH CHECK ADD  CONSTRAINT [FK_TeacherAndCourses_Course] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([Id])
GO
ALTER TABLE [dbo].[TeacherAndCourses] CHECK CONSTRAINT [FK_TeacherAndCourses_Course]
GO
ALTER TABLE [dbo].[TeacherAndCourses]  WITH CHECK ADD  CONSTRAINT [FK_TeacherAndCourses_Teacher] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teacher] ([Id])
GO
ALTER TABLE [dbo].[TeacherAndCourses] CHECK CONSTRAINT [FK_TeacherAndCourses_Teacher]
GO
USE [master]
GO
ALTER DATABASE [CourseManagementPortal] SET  READ_WRITE 
GO
