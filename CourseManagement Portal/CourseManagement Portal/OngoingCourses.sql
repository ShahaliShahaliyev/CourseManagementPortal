USE [CourseManagementPortal]
GO

/****** Object:  Table [dbo].[OngoingCourses]    Script Date: 06.02.2022 11:47:55 ******/
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

