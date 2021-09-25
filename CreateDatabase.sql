USE [master]
GO
/****** Object:  Database [Hrms]    Script Date: 25.09.2021 18:11:16 ******/
CREATE DATABASE [Hrms]
 CONTAINMENT = NONE
GO
ALTER DATABASE [Hrms] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hrms].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hrms] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [Hrms] SET ANSI_NULLS ON 
GO
ALTER DATABASE [Hrms] SET ANSI_PADDING ON 
GO
ALTER DATABASE [Hrms] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [Hrms] SET ARITHABORT ON 
GO
ALTER DATABASE [Hrms] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hrms] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hrms] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hrms] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hrms] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [Hrms] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [Hrms] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hrms] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [Hrms] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hrms] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hrms] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hrms] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hrms] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hrms] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hrms] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hrms] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hrms] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hrms] SET RECOVERY FULL 
GO
ALTER DATABASE [Hrms] SET  MULTI_USER 
GO
ALTER DATABASE [Hrms] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hrms] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hrms] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hrms] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hrms] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hrms] SET QUERY_STORE = OFF
GO
USE [Hrms]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Hrms]
GO
/****** Object:  Table [dbo].[Applicants]    Script Date: 25.09.2021 18:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Applicants](
	[UserId] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[IdentityNo] [nvarchar](11) NOT NULL,
	[BirthDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employers]    Script Date: 25.09.2021 18:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employers](
	[UserId] [int] NOT NULL,
	[CompanyName] [nvarchar](75) NOT NULL,
	[WebSite] [nvarchar](75) NOT NULL,
	[PhoneNumber] [nvarchar](75) NOT NULL,
	[StaffApproval] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobAdverts]    Script Date: 25.09.2021 18:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobAdverts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobPositionId] [int] NOT NULL,
	[EmployerId] [int] NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
	[City] [nvarchar](75) NOT NULL,
	[MinSalary] [int] NULL,
	[MaxSalary] [int] NULL,
	[Vacancies] [int] NOT NULL,
	[LastApplyDate] [datetime] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_JobAdverts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobPositions]    Script Date: 25.09.2021 18:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobPositions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobName] [nvarchar](75) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 25.09.2021 18:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](75) NOT NULL,
	[Password] [nvarchar](75) NOT NULL,
	[MailStatus] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employers] ADD  DEFAULT ((0)) FOR [StaffApproval]
GO
ALTER TABLE [dbo].[JobAdverts] ADD  CONSTRAINT [DF_JobAdverts_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[JobAdverts] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((0)) FOR [MailStatus]
GO
ALTER TABLE [dbo].[Applicants]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Employers]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[JobAdverts]  WITH CHECK ADD  CONSTRAINT [FK_JobAdverts_Employers] FOREIGN KEY([EmployerId])
REFERENCES [dbo].[Employers] ([UserId])
GO
ALTER TABLE [dbo].[JobAdverts] CHECK CONSTRAINT [FK_JobAdverts_Employers]
GO
ALTER TABLE [dbo].[JobAdverts]  WITH CHECK ADD  CONSTRAINT [FK_JobAdverts_JobPositions] FOREIGN KEY([JobPositionId])
REFERENCES [dbo].[JobPositions] ([Id])
GO
ALTER TABLE [dbo].[JobAdverts] CHECK CONSTRAINT [FK_JobAdverts_JobPositions]
GO
USE [master]
GO
ALTER DATABASE [Hrms] SET  READ_WRITE 
GO
