USE [master]
GO
/****** Object:  Database [MySchool]    Script Date: 2016/9/28 11:01:11 ******/
CREATE DATABASE [MySchool]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MySchool', FILENAME = N'E:\GitHub\贯穿案例：MySchool 系统\MySchool 系统\DB\MySchool.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MySchool_log', FILENAME = N'E:\GitHub\贯穿案例：MySchool 系统\MySchool 系统\DB\MySchool_log.ldf' , SIZE = 3456KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MySchool] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MySchool].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MySchool] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MySchool] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MySchool] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MySchool] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MySchool] SET ARITHABORT OFF 
GO
ALTER DATABASE [MySchool] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MySchool] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MySchool] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MySchool] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MySchool] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MySchool] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MySchool] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MySchool] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MySchool] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MySchool] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MySchool] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MySchool] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MySchool] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MySchool] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MySchool] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MySchool] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MySchool] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MySchool] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MySchool] SET  MULTI_USER 
GO
ALTER DATABASE [MySchool] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MySchool] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MySchool] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MySchool] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MySchool] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MySchool', N'ON'
GO
USE [MySchool]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 2016/9/28 11:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[LoginId] [nvarchar](50) NOT NULL,
	[LoginPwd] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Admin_1] PRIMARY KEY CLUSTERED 
(
	[LoginId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department]    Script Date: 2016/9/28 11:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DeptId] [int] IDENTITY(1,1) NOT NULL,
	[DeptName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DeptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dept]    Script Date: 2016/9/28 11:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dept](
	[DeptId] [int] IDENTITY(1,1) NOT NULL,
	[DeptName] [nvarchar](20) NOT NULL,
	[ParentId] [int] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[DeptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee]    Script Date: 2016/9/28 11:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[EmpId] [int] IDENTITY(1,1) NOT NULL,
	[EmpName] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Phone] [char](20) NOT NULL,
	[Salary] [money] NULL,
	[DeptId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee1]    Script Date: 2016/9/28 11:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee1](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [nvarchar](30) NOT NULL,
	[Gender] [char](2) NULL DEFAULT ('男'),
	[Tel] [char](11) NOT NULL,
	[DeptId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 2016/9/28 11:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[GradeId] [int] IDENTITY(1,1) NOT NULL,
	[GradeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Grade] PRIMARY KEY CLUSTERED 
(
	[GradeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Result]    Script Date: 2016/9/28 11:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Result](
	[StudentNo] [int] NOT NULL,
	[SubjectId] [int] NOT NULL,
	[StudentResult] [int] NOT NULL,
	[ExamDate] [datetime] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student]    Script Date: 2016/9/28 11:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student](
	[StudentNo] [int] IDENTITY(1000,1) NOT NULL,
	[LoginPwd] [nvarchar](50) NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[Gender] [char](1) NOT NULL CONSTRAINT [DF_Student_Gender]  DEFAULT ((1)),
	[GradeId] [int] NOT NULL CONSTRAINT [DF_Student_GradeId]  DEFAULT ((1)),
	[Phone] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Birthday] [datetime] NOT NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 2016/9/28 11:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[SubjectId] [int] IDENTITY(1,1) NOT NULL,
	[SubjectName] [nchar](10) NOT NULL,
	[ClassHour] [int] NULL,
	[GradeId] [int] NOT NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[teacher]    Script Date: 2016/9/28 11:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[teacher](
	[TeacherID] [int] IDENTITY(1,1) NOT NULL,
	[TeacherName] [nvarchar](30) NOT NULL,
	[Sex] [char](5) NOT NULL,
	[BirthDay] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TeacherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Admin] ([LoginId], [LoginPwd]) VALUES (N'jbit', N'bdqn')
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([DeptId], [DeptName]) VALUES (1, N'市场部')
INSERT [dbo].[Department] ([DeptId], [DeptName]) VALUES (2, N'网络部')
INSERT [dbo].[Department] ([DeptId], [DeptName]) VALUES (3, N'行政部')
INSERT [dbo].[Department] ([DeptId], [DeptName]) VALUES (4, N'财务部')
SET IDENTITY_INSERT [dbo].[Department] OFF
SET IDENTITY_INSERT [dbo].[dept] ON 

INSERT [dbo].[dept] ([DeptId], [DeptName], [ParentId]) VALUES (1, N'市场部', 0)
INSERT [dbo].[dept] ([DeptId], [DeptName], [ParentId]) VALUES (2, N'网络部', 0)
INSERT [dbo].[dept] ([DeptId], [DeptName], [ParentId]) VALUES (3, N'行政部', 0)
INSERT [dbo].[dept] ([DeptId], [DeptName], [ParentId]) VALUES (4, N'财务部', 0)
SET IDENTITY_INSERT [dbo].[dept] OFF
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmpId], [EmpName], [Address], [Phone], [Salary], [DeptId]) VALUES (1, N'陈红', N'北京市崇文区东花市北里', N'13238282866         ', 10000.0000, 1)
INSERT [dbo].[Employee] ([EmpId], [EmpName], [Address], [Phone], [Salary], [DeptId]) VALUES (2, N'李刚', N'北京市崇文区东花市北里', N'13788888888         ', 10000.0000, 2)
INSERT [dbo].[Employee] ([EmpId], [EmpName], [Address], [Phone], [Salary], [DeptId]) VALUES (3, N'李楠', N'北京市崇文区东花市北里', N'13785282824         ', 10000.0000, 2)
INSERT [dbo].[Employee] ([EmpId], [EmpName], [Address], [Phone], [Salary], [DeptId]) VALUES (4, N'王明', N'北京市崇文区东花市北里', N'13788282824         ', 10000.0000, 1)
INSERT [dbo].[Employee] ([EmpId], [EmpName], [Address], [Phone], [Salary], [DeptId]) VALUES (5, N'张凯英', N'北京市崇文区东花市北里', N'13588282824         ', 10000.0000, 3)
INSERT [dbo].[Employee] ([EmpId], [EmpName], [Address], [Phone], [Salary], [DeptId]) VALUES (6, N'赵鹏', N'北京市崇文区东花市北里', N'13188282824         ', 10000.0000, 3)
INSERT [dbo].[Employee] ([EmpId], [EmpName], [Address], [Phone], [Salary], [DeptId]) VALUES (7, N'钱党徽', N'北京市崇文区东花市北里', N'13294843843         ', 10000.0000, 4)
SET IDENTITY_INSERT [dbo].[Employee] OFF
SET IDENTITY_INSERT [dbo].[Employee1] ON 

INSERT [dbo].[Employee1] ([EmployeeId], [EmployeeName], [Gender], [Tel], [DeptId]) VALUES (1, N'陈红', N'女', N'13238282866', 1)
INSERT [dbo].[Employee1] ([EmployeeId], [EmployeeName], [Gender], [Tel], [DeptId]) VALUES (2, N'李刚', N'男', N'13788888888', 2)
INSERT [dbo].[Employee1] ([EmployeeId], [EmployeeName], [Gender], [Tel], [DeptId]) VALUES (3, N'李楠', N'女', N'13785282824', 2)
INSERT [dbo].[Employee1] ([EmployeeId], [EmployeeName], [Gender], [Tel], [DeptId]) VALUES (4, N'王明', N'男', N'13788282824', 1)
INSERT [dbo].[Employee1] ([EmployeeId], [EmployeeName], [Gender], [Tel], [DeptId]) VALUES (5, N'张凯英', N'女', N'13588282824', 3)
INSERT [dbo].[Employee1] ([EmployeeId], [EmployeeName], [Gender], [Tel], [DeptId]) VALUES (6, N'赵鹏', N'男', N'13188282824', 3)
INSERT [dbo].[Employee1] ([EmployeeId], [EmployeeName], [Gender], [Tel], [DeptId]) VALUES (7, N'钱党徽', N'男', N'13294843843', 4)
SET IDENTITY_INSERT [dbo].[Employee1] OFF
SET IDENTITY_INSERT [dbo].[Grade] ON 

INSERT [dbo].[Grade] ([GradeId], [GradeName]) VALUES (1, N'S1')
INSERT [dbo].[Grade] ([GradeId], [GradeName]) VALUES (2, N'S2')
INSERT [dbo].[Grade] ([GradeId], [GradeName]) VALUES (3, N'Y2')
SET IDENTITY_INSERT [dbo].[Grade] OFF
INSERT [dbo].[Result] ([StudentNo], [SubjectId], [StudentResult], [ExamDate]) VALUES (23219, 1, 90, CAST(N'2008-09-20 00:00:00.000' AS DateTime))
INSERT [dbo].[Result] ([StudentNo], [SubjectId], [StudentResult], [ExamDate]) VALUES (23214, 1, 70, CAST(N'2009-09-12 00:00:00.000' AS DateTime))
INSERT [dbo].[Result] ([StudentNo], [SubjectId], [StudentResult], [ExamDate]) VALUES (23214, 1, 80, CAST(N'2009-09-09 00:00:00.000' AS DateTime))
INSERT [dbo].[Result] ([StudentNo], [SubjectId], [StudentResult], [ExamDate]) VALUES (23214, 1, 90, CAST(N'2009-09-09 00:00:00.000' AS DateTime))
INSERT [dbo].[Result] ([StudentNo], [SubjectId], [StudentResult], [ExamDate]) VALUES (23214, 2, 95, CAST(N'2009-09-09 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([StudentNo], [LoginPwd], [StudentName], [Gender], [GradeId], [Phone], [Address], [Birthday], [Email]) VALUES (23, N'23', N'灰太狼', N'1', 1, N'23', N'23dsfad', CAST(N'1982-06-04 00:00:00.000' AS DateTime), N'1@3')
INSERT [dbo].[Student] ([StudentNo], [LoginPwd], [StudentName], [Gender], [GradeId], [Phone], [Address], [Birthday], [Email]) VALUES (23213, N'12', N'李金香', N'0', 3, N'13835231533/13503542995', N'北京海淀区北宫门', CAST(N'1982-06-04 00:00:00.000' AS DateTime), N'')
INSERT [dbo].[Student] ([StudentNo], [LoginPwd], [StudentName], [Gender], [GradeId], [Phone], [Address], [Birthday], [Email]) VALUES (23214, N'0000', N'a', N'0', 2, N'aa', N'aa', CAST(N'1990-07-01 00:00:00.000' AS DateTime), N'')
INSERT [dbo].[Student] ([StudentNo], [LoginPwd], [StudentName], [Gender], [GradeId], [Phone], [Address], [Birthday], [Email]) VALUES (23219, N'0000', N'美洋洋', N'0', 1, N'6666666', N'北京市海淀区', CAST(N'1991-01-01 00:00:00.000' AS DateTime), N'')
INSERT [dbo].[Student] ([StudentNo], [LoginPwd], [StudentName], [Gender], [GradeId], [Phone], [Address], [Birthday], [Email]) VALUES (23221, N'0000', N'倒霉熊', N'1', 1, NULL, NULL, CAST(N'1990-01-01 00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Student] OFF
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([SubjectId], [SubjectName], [ClassHour], [GradeId]) VALUES (1, N'oop       ', 78, 1)
INSERT [dbo].[Subject] ([SubjectId], [SubjectName], [ClassHour], [GradeId]) VALUES (2, N'java      ', 67, 2)
INSERT [dbo].[Subject] ([SubjectId], [SubjectName], [ClassHour], [GradeId]) VALUES (3, N'C#        ', 78, 3)
SET IDENTITY_INSERT [dbo].[Subject] OFF
SET IDENTITY_INSERT [dbo].[teacher] ON 

INSERT [dbo].[teacher] ([TeacherID], [TeacherName], [Sex], [BirthDay]) VALUES (1, N'李楠', N'女   ', N'1984-09-09')
INSERT [dbo].[teacher] ([TeacherID], [TeacherName], [Sex], [BirthDay]) VALUES (2, N'李至', N'女   ', N'1984-09-09')
INSERT [dbo].[teacher] ([TeacherID], [TeacherName], [Sex], [BirthDay]) VALUES (3, N'王楠', N'女   ', N'1984-09-09')
INSERT [dbo].[teacher] ([TeacherID], [TeacherName], [Sex], [BirthDay]) VALUES (4, N'王强', N'男   ', N'1984-09-09')
INSERT [dbo].[teacher] ([TeacherID], [TeacherName], [Sex], [BirthDay]) VALUES (5, N'张楠', N'女   ', N'1984-09-09')
INSERT [dbo].[teacher] ([TeacherID], [TeacherName], [Sex], [BirthDay]) VALUES (6, N'章波', N'男   ', N'1984-09-09')
SET IDENTITY_INSERT [dbo].[teacher] OFF
ALTER TABLE [dbo].[Result]  WITH CHECK ADD  CONSTRAINT [FK_Result_Student] FOREIGN KEY([StudentNo])
REFERENCES [dbo].[Student] ([StudentNo])
GO
ALTER TABLE [dbo].[Result] CHECK CONSTRAINT [FK_Result_Student]
GO
ALTER TABLE [dbo].[Result]  WITH CHECK ADD  CONSTRAINT [FK_Result_Subject] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subject] ([SubjectId])
GO
ALTER TABLE [dbo].[Result] CHECK CONSTRAINT [FK_Result_Subject]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Grade] FOREIGN KEY([GradeId])
REFERENCES [dbo].[Grade] ([GradeId])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Grade]
GO
ALTER TABLE [dbo].[Subject]  WITH CHECK ADD  CONSTRAINT [FK_Subject_Grade] FOREIGN KEY([GradeId])
REFERENCES [dbo].[Grade] ([GradeId])
GO
ALTER TABLE [dbo].[Subject] CHECK CONSTRAINT [FK_Subject_Grade]
GO
USE [master]
GO
ALTER DATABASE [MySchool] SET  READ_WRITE 
GO
