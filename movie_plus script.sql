USE [movie_plus]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/2/2020 5:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AuditLogger]    Script Date: 7/2/2020 5:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuditLogger](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UseCaseName] [nvarchar](max) NULL,
	[Data] [nvarchar](max) NULL,
	[Actor] [nvarchar](max) NULL,
	[Time] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AuditLogger] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Auditoriums]    Script Date: 7/2/2020 5:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Auditoriums](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Auditoriums] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 7/2/2020 5:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](1500) NOT NULL,
	[Duration] [int] NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservations]    Script Date: 7/2/2020 5:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
	[UserId] [int] NOT NULL,
	[ScreeningId] [int] NOT NULL,
 CONSTRAINT [PK_Reservations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Screenings]    Script Date: 7/2/2020 5:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Screenings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
	[MovieId] [int] NOT NULL,
	[AuditoriumId] [int] NOT NULL,
	[ScreeningTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Screenings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SeatReserved]    Script Date: 7/2/2020 5:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SeatReserved](
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
	[SeatId] [int] NOT NULL,
	[ReservationId] [int] NOT NULL,
	[ScreeningId] [int] NOT NULL,
 CONSTRAINT [PK_SeatReserved] PRIMARY KEY CLUSTERED 
(
	[SeatId] ASC,
	[ScreeningId] ASC,
	[ReservationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seats]    Script Date: 7/2/2020 5:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seats](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
	[Number] [int] NOT NULL,
	[AuditoriumId] [int] NOT NULL,
 CONSTRAINT [PK_Seats] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/2/2020 5:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
	[FirstName] [nvarchar](32) NOT NULL,
	[LastName] [nvarchar](32) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Username] [nvarchar](32) NOT NULL,
	[Password] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserUseCases]    Script Date: 7/2/2020 5:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserUseCases](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
	[UserId] [int] NOT NULL,
	[UseCaseId] [int] NOT NULL,
 CONSTRAINT [PK_UserUseCases] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200629103944_initial', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200629104256_use-case seeder', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200629105359_update one to one rel', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200629141518_movie images', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200629214934_global query filter', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200701003229_Reservation seeder', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200701102245_SeatReserved table', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200701102925_SeatReserved configuration', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200701105159_SeatReserved composite key', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200701105426_Seat seeder', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200701132411_Use case seeder', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200701200355_seeder', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200701200703_remove seat res seeder', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200701212522_admin use cases', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200701234019_use case seeder #2', N'3.1.5')
GO
SET IDENTITY_INSERT [dbo].[AuditLogger] ON 

INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (1, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:41:02.7024365' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (2, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:41:02.2198056' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (3, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:41:04.5220773' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (4, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:41:05.3982188' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (5, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:41:47.5374416' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (6, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:41:49.3495836' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (7, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:41:50.6297826' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (8, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:41:51.1626147' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (9, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:43:26.4978663' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (10, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:43:35.4926306' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (11, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:43:36.4174743' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (12, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:44:49.8569825' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (13, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:44:55.9194219' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (14, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:46:02.1939522' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (15, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:46:03.5927242' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (16, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:46:03.6953295' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (17, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:46:04.3410776' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (18, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:47:44.1384795' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (19, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:47:50.2395085' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (20, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:47:50.6977422' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (21, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:47:51.2056872' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (22, N'Get Logs', N'{"UseCase":null,"Data":null,"Actor":null,"StartDate":null,"EndDate":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:47:57.0813873' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (23, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:47:59.2131982' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (24, N'Get Logs', N'{"UseCase":null,"Data":null,"Actor":null,"StartDate":null,"EndDate":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:48:06.4527353' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (25, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:48:49.9979586' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (26, N'Get Logs', N'{"UseCase":null,"Data":null,"Actor":null,"StartDate":null,"EndDate":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:48:51.6023683' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (27, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:48:53.5599024' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (28, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:49:05.9197237' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (29, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:49:07.5338137' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (30, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:53:35.5495342' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (31, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:53:43.1331818' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (32, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:54:04.3047014' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (33, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:54:15.2079737' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (34, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:54:54.1800763' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (35, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:55:06.5074902' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (36, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:55:15.6282098' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (37, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:55:28.8877983' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (38, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:55:31.2450756' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (39, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:55:32.1023927' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (40, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-01T23:55:32.4536962' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (41, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:45:03.9496921' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (42, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:45:05.2011631' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (43, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:45:08.8729043' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (44, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:45:22.9776816' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (45, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:45:23.9777016' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (46, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:45:25.0736630' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (47, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:45:26.6903550' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (48, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:45:38.1065172' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (49, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"undefined","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:48:06.4458430' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (50, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"undefined","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:48:36.1287959' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (51, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:48:37.9105867' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (52, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:48:43.6500359' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (53, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"undefined","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:48:46.5306958' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (54, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"undefined","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:48:53.4511426' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (55, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"undefined","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:48:59.7971470' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (56, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:49:08.4458263' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (57, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:49:16.4021201' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (58, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:49:31.9501713' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (59, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:49:33.6400963' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (60, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:49:34.6058728' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (61, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:49:35.4719809' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (62, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:49:59.3062371' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (63, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:50:00.8127801' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (64, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T00:50:07.5480523' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (65, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:04:26.8417260' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (66, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:04:32.3534075' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (67, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:04:33.5632369' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (68, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:04:37.3232722' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (69, N'Insert Screening', N'{"Id":0,"MovieId":1,"MovieName":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-02","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:07:17.0498005' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (70, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:07:27.0074602' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (71, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:07:29.3916898' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (72, N'Insert Screening', N'{"Id":0,"MovieId":1,"MovieName":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-02","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:07:38.3256150' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (73, N'Insert Screening', N'{"Id":0,"MovieId":4,"MovieName":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-02","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:09:37.9367401' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (74, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:10:02.7053384' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (75, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:10:03.7604901' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (76, N'Insert Screening', N'{"Id":0,"MovieId":3,"MovieName":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-02","Time":"17","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:10:11.8165939' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (77, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:10:13.3154477' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (78, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:10:14.4911260' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (79, N'Insert Screening', N'{"Id":0,"MovieId":7,"MovieName":null,"AuditoriumName":null,"AuditoriumId":2,"Seats":0,"Date":"2020-07-03","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:10:33.1127622' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (80, N'Insert Screening', N'{"Id":0,"MovieId":7,"MovieName":null,"AuditoriumName":null,"AuditoriumId":2,"Seats":0,"Date":"2020-07-03","Time":"17","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:10:39.5024617' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (81, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:10:41.1461014' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (82, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:10:42.2319767' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (83, N'Insert Screening', N'{"Id":0,"MovieId":5,"MovieName":null,"AuditoriumName":null,"AuditoriumId":2,"Seats":0,"Date":"2020-07-04","Time":"17","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:10:55.9828383' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (84, N'Insert Screening', N'{"Id":0,"MovieId":5,"MovieName":null,"AuditoriumName":null,"AuditoriumId":2,"Seats":0,"Date":"2020-07-04","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:11:05.7384649' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (85, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:11:07.3265720' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (86, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:11:08.1541781' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (87, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:13:10.6846589' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (88, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:13:27.0852590' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (89, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:13:29.4957203' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (90, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:13:30.1653638' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (91, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":2}', N'adminAdmin', CAST(N'2020-07-02T02:13:31.6162722' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (92, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:13:53.9734339' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (93, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:13:56.0485807' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (94, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:13:58.7523388' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (95, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:14:14.4370620' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (96, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:14:15.1098420' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (97, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":2}', N'adminAdmin', CAST(N'2020-07-02T02:14:16.2393323' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (98, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:15:02.2077130' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (99, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:15:22.6592589' AS DateTime2))
GO
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (100, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:15:25.2702445' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (101, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:15:25.8462874' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (102, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":2}', N'adminAdmin', CAST(N'2020-07-02T02:15:27.5392982' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (103, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:15:29.4276640' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (104, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":2}', N'adminAdmin', CAST(N'2020-07-02T02:15:30.9614065' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (105, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:15:31.8493745' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (106, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":2}', N'adminAdmin', CAST(N'2020-07-02T02:15:33.4987763' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (107, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:15:35.1700861' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (108, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:15:45.0446242' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (109, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:15:46.4251247' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (110, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:15:47.4332299' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (111, N'Get Logs', N'{"UseCase":null,"Data":null,"Actor":null,"StartDate":null,"EndDate":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:15:47.9795682' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (112, N'Get Logs', N'{"UseCase":null,"Data":null,"Actor":null,"StartDate":null,"EndDate":null,"ItemsPerPage":10,"CurrentPage":3}', N'adminAdmin', CAST(N'2020-07-02T02:15:49.0687416' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (113, N'Get Logs', N'{"UseCase":null,"Data":null,"Actor":null,"StartDate":null,"EndDate":null,"ItemsPerPage":10,"CurrentPage":2}', N'adminAdmin', CAST(N'2020-07-02T02:15:49.8019379' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (114, N'Get Logs', N'{"UseCase":null,"Data":null,"Actor":null,"StartDate":null,"EndDate":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:15:50.3217032' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (115, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:16:18.0937400' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (116, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:16:21.0870128' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (117, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:16:38.3259031' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (118, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:16:46.2567142' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (119, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:16:58.8447925' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (120, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:17:01.5733650' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (121, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":2}', N'adminAdmin', CAST(N'2020-07-02T02:17:02.8973337' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (122, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:17:03.9590988' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (123, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:18:30.0717921' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (124, N'get single Movie', N'1', N'adminAdmin', CAST(N'2020-07-02T02:18:31.9051125' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (125, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:18:34.5722442' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (126, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:18:43.3586297' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (127, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:19:41.9923063' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (128, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:19:46.0762459' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (129, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:19:46.9173135' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (130, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:20:06.9635920' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (131, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:20:15.7496421' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (132, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:20:19.8648557' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (133, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:20:28.3533161' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (134, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:33:01.7469259' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (135, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:33:04.6129958' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (136, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:33:05.8903358' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (137, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:33:07.1616132' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (138, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:33:08.9297916' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (139, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":2}', N'adminAdmin', CAST(N'2020-07-02T02:33:10.5752909' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (140, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:33:50.0747319' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (141, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:33:54.6463039' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (142, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:34:00.0427743' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (143, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:34:00.0552358' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (144, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:34:00.7468003' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (145, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":2}', N'adminAdmin', CAST(N'2020-07-02T02:34:02.2000096' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (146, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:34:36.1260237' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (147, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:34:36.8464533' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (148, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":2}', N'adminAdmin', CAST(N'2020-07-02T02:34:38.3469764' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (149, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:34:46.2869126' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (150, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:35:19.0622089' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (151, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:35:27.5628384' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (152, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:35:29.6923901' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (153, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:35:30.1267781' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (154, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:35:30.6578576' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (155, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:35:48.3248060' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (156, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:35:49.4285667' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (157, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:36:17.7719807' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (158, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:36:19.3080215' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (159, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:36:57.4691024' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (160, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:37:01.3715197' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (161, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:37:16.3549978' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (162, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:38:18.0906207' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (163, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:38:21.5101726' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (164, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":2}', N'adminAdmin', CAST(N'2020-07-02T02:39:06.3647876' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (165, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:40:28.9777176' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (166, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:40:30.4445142' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (167, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:40:31.5067515' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (168, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":2}', N'adminAdmin', CAST(N'2020-07-02T02:40:33.2399203' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (169, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:40:36.5029353' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (170, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:40:48.7536803' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (171, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:40:50.1010352' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (172, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:41:13.0789120' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (173, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:41:27.1007952' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (174, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:41:28.8360446' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (175, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:41:29.3361198' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (176, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:41:30.7098731' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (177, N'Get movies', N'{"Title":"as","Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:41:31.5862828' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (178, N'Get movies', N'{"Title":"as","Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:41:31.6954026' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (179, N'Get movies', N'{"Title":"a","Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:41:33.2157421' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (180, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:41:33.8437941' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (181, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:41:33.9995860' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (182, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:41:35.4192525' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (183, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:44:07.9877421' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (184, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:44:10.4659885' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (185, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:44:11.6091870' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (186, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:44:20.8477116' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (187, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:44:32.7764111' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (188, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:44:49.1610884' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (189, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:44:52.2751445' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (190, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:45:26.2907751' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (191, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:47:45.7286873' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (192, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:47:46.9199265' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (193, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:47:49.5024604' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (194, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:56:11.2286656' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (195, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:56:11.2286702' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (196, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:56:15.0001086' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (197, N'Delete Screening Time', N'13', N'adminAdmin', CAST(N'2020-07-02T02:56:16.6956800' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (198, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:56:25.7946045' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (199, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:56:27.1783815' AS DateTime2))
GO
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (200, N'Delete Screening Time', N'15', N'adminAdmin', CAST(N'2020-07-02T02:56:29.8651184' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (201, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:56:31.2749197' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (202, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:56:32.5939438' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (203, N'Insert Screening', N'{"Id":0,"MovieId":1,"MovieName":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-02","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:56:49.3365126' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (204, N'Insert Screening', N'{"Id":0,"MovieId":1,"MovieName":null,"AuditoriumName":null,"AuditoriumId":2,"Seats":0,"Date":"2020-07-02","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:57:08.6966162' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (205, N'Insert Screening', N'{"Id":0,"MovieId":3,"MovieName":null,"AuditoriumName":null,"AuditoriumId":2,"Seats":0,"Date":"2020-07-03","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:57:20.4705295' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (206, N'Insert Screening', N'{"Id":0,"MovieId":3,"MovieName":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-03","Time":"17","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:57:29.4828759' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (207, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:57:31.2636423' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (208, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:57:32.7370275' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (209, N'Insert Screening', N'{"Id":0,"MovieId":7,"MovieName":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-04","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:57:43.4988257' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (210, N'Insert Screening', N'{"Id":0,"MovieId":7,"MovieName":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-04","Time":"17","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:57:48.8743289' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (211, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:57:50.2270529' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (212, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:57:54.2943223' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (213, N'Insert Screening', N'{"Id":0,"MovieId":2,"MovieName":null,"AuditoriumName":null,"AuditoriumId":2,"Seats":0,"Date":"2020-07-05","Time":"20","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:58:11.8032441' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (214, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:58:13.1616852' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (215, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:58:15.7007378' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (216, N'Insert Screening', N'{"Id":0,"MovieId":1,"MovieName":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-03","Time":"20","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:58:35.5023168' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (217, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:58:36.8652842' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (218, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:58:39.2659393' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (219, N'Insert Screening', N'{"Id":0,"MovieId":4,"MovieName":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-03","Time":"20","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:58:49.9797865' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (220, N'Insert Screening', N'{"Id":0,"MovieId":4,"MovieName":null,"AuditoriumName":null,"AuditoriumId":2,"Seats":0,"Date":"2020-07-03","Time":"20","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:58:56.0296113' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (221, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:58:57.2713492' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (222, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:58:58.4082148' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (223, N'Insert Screening', N'{"Id":0,"MovieId":1,"MovieName":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-07","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:59:05.9237136' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (224, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:59:07.6091179' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (225, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:59:09.4952828' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (226, N'Insert Screening', N'{"Id":0,"MovieId":5,"MovieName":null,"AuditoriumName":null,"AuditoriumId":2,"Seats":0,"Date":"2020-07-04","Time":"17","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:59:21.6464230' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (227, N'Insert Screening', N'{"Id":0,"MovieId":5,"MovieName":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-04","Time":"17","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:59:29.6773819' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (228, N'Insert Screening', N'{"Id":0,"MovieId":5,"MovieName":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-06","Time":"20","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T02:59:37.6041725' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (229, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:59:39.0664923' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (230, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T02:59:40.0852782' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (231, N'Insert Screening', N'{"Id":0,"MovieId":6,"MovieName":null,"AuditoriumName":null,"AuditoriumId":2,"Seats":0,"Date":"2020-07-03","Time":"17","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T03:00:06.5590246' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (232, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:00:07.8264435' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (233, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:00:08.9489322' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (234, N'Insert Screening', N'{"Id":0,"MovieId":1,"MovieName":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-09","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T03:00:28.0254529' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (235, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:00:29.3210189' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (236, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:00:30.2148175' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (237, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:00:30.7136228' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (238, N'Insert Screening', N'{"Id":0,"MovieId":4,"MovieName":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-08","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T03:00:40.5781465' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (239, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:00:42.0674769' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (240, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:00:43.0345594' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (241, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:00:43.4929677' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (242, N'Insert Screening', N'{"Id":0,"MovieId":7,"MovieName":null,"AuditoriumName":null,"AuditoriumId":2,"Seats":0,"Date":"2020-07-07","Time":"20","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-02T03:00:52.6028196' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (243, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:00:53.9563074' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (244, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:00:55.2226894' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (245, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:00:56.2334396' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (246, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:01:02.1831196' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (247, N'Get movies', N'{"Title":null,"Description":null,"Time":"17","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:01:15.3013016' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (248, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:01:22.7704729' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (249, N'Get movies', N'{"Title":null,"Description":null,"Time":"17","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:01:33.5007958' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (250, N'Get movies', N'{"Title":null,"Description":null,"Time":"20","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:01:35.0250395' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (251, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:01:36.3942235' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (252, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:02:27.9556258' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (253, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:02:51.5321755' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (254, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:02:53.3637834' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (255, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:03:43.7557669' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (256, N'Get movies', N'{"Title":null,"Description":null,"Time":"20","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:03:47.6526570' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (257, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:03:54.7870074' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (258, N'Get movies', N'{"Title":null,"Description":null,"Time":"17","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:03:58.3345278' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (259, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:04:10.9729707' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (260, N'Get movies', N'{"Title":null,"Description":null,"Time":"17","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:04:13.4556669' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (261, N'Get movies', N'{"Title":null,"Description":null,"Time":"20","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:04:14.6849642' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (262, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:05:10.1574794' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (263, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:07:01.6540147' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (264, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:09:27.6693879' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (265, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:10:20.6301627' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (266, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:10:23.8621898' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (267, N'Insert reservation', N'{"UserId":1,"ScreeningId":8,"AuditoriumId":1}', N'adminAdmin', CAST(N'2020-07-02T03:10:25.9267810' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (268, N'Get single User', N'1', N'adminAdmin', CAST(N'2020-07-02T03:10:31.7974889' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (269, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:10:33.5942602' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (270, N'Get single User', N'1', N'adminAdmin', CAST(N'2020-07-02T03:10:34.5387221' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (271, N'Delete Reservation', N'5', N'adminAdmin', CAST(N'2020-07-02T03:10:35.4609683' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (272, N'Get single User', N'1', N'adminAdmin', CAST(N'2020-07-02T03:10:37.2909370' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (273, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:10:38.3435042' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (274, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:10:48.4880805' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (275, N'Insert reservation', N'{"UserId":1,"ScreeningId":8,"AuditoriumId":1}', N'adminAdmin', CAST(N'2020-07-02T03:10:55.5622794' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (276, N'Get movies', N'{"Title":null,"Description":null,"Time":"17","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:10:59.7186001' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (277, N'Insert reservation', N'{"UserId":1,"ScreeningId":11,"AuditoriumId":1}', N'adminAdmin', CAST(N'2020-07-02T03:11:00.6854517' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (278, N'Get movies', N'{"Title":null,"Description":null,"Time":"17","Date":"2020-07-03","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:11:05.7723722' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (279, N'Insert reservation', N'{"UserId":1,"ScreeningId":19,"AuditoriumId":1}', N'adminAdmin', CAST(N'2020-07-02T03:11:07.4814598' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (280, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-03","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:11:11.1780104' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (281, N'Get movies', N'{"Title":null,"Description":null,"Time":"20","Date":"2020-07-03","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:11:13.4702087' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (282, N'Insert reservation', N'{"UserId":1,"ScreeningId":23,"AuditoriumId":1}', N'adminAdmin', CAST(N'2020-07-02T03:11:14.7237641' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (283, N'Insert reservation', N'{"UserId":1,"ScreeningId":23,"AuditoriumId":1}', N'adminAdmin', CAST(N'2020-07-02T03:11:18.9686973' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (284, N'Get movies', N'{"Title":null,"Description":null,"Time":"20","Date":"2020-07-06","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-02T03:11:23.8518187' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (285, N'Insert reservation', N'{"UserId":1,"ScreeningId":29,"AuditoriumId":1}', N'adminAdmin', CAST(N'2020-07-02T03:11:24.9215808' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (286, N'Register user', N'{"Id":0,"FirstName":"User","LastName":"User","Email":"user@gmail.com","Username":"user","Password":"ciciban1","Tickets":null}', N'Anonymus user', CAST(N'2020-07-02T03:14:31.2286292' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (287, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'user', CAST(N'2020-07-02T03:14:40.5648819' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (288, N'Insert reservation', N'{"UserId":3,"ScreeningId":8,"AuditoriumId":1}', N'user', CAST(N'2020-07-02T03:14:41.8953451' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (289, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-03","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'user', CAST(N'2020-07-02T03:14:47.0760578' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (290, N'Insert reservation', N'{"UserId":3,"ScreeningId":3,"AuditoriumId":2}', N'user', CAST(N'2020-07-02T03:14:48.0771489' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (291, N'Get movies', N'{"Title":null,"Description":null,"Time":"17","Date":"2020-07-03","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'user', CAST(N'2020-07-02T03:14:49.7941023' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (292, N'Insert reservation', N'{"UserId":3,"ScreeningId":19,"AuditoriumId":1}', N'user', CAST(N'2020-07-02T03:14:52.1930069' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (293, N'Get movies', N'{"Title":null,"Description":null,"Time":"17","Date":"2020-07-04","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'user', CAST(N'2020-07-02T03:14:57.3190568' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (294, N'Insert reservation', N'{"UserId":3,"ScreeningId":5,"AuditoriumId":2}', N'user', CAST(N'2020-07-02T03:14:58.3296601' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (295, N'Insert reservation', N'{"UserId":3,"ScreeningId":5,"AuditoriumId":2}', N'user', CAST(N'2020-07-02T03:15:02.7747650' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (296, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-04","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'user', CAST(N'2020-07-02T03:15:08.3788441' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (297, N'Insert reservation', N'{"UserId":3,"ScreeningId":1,"AuditoriumId":1}', N'user', CAST(N'2020-07-02T03:15:09.3038400' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (298, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-08","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'user', CAST(N'2020-07-02T03:15:14.3279195' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (299, N'Insert reservation', N'{"UserId":3,"ScreeningId":32,"AuditoriumId":1}', N'user', CAST(N'2020-07-02T03:15:15.1925571' AS DateTime2))
GO
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (300, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-07","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'user', CAST(N'2020-07-02T03:15:19.8050703' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (301, N'Get movies', N'{"Title":null,"Description":null,"Time":"20","Date":"2020-07-07","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'user', CAST(N'2020-07-02T03:15:20.7068626' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (302, N'Insert reservation', N'{"UserId":3,"ScreeningId":33,"AuditoriumId":2}', N'user', CAST(N'2020-07-02T03:15:21.6758610' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (303, N'Get single User', N'3', N'user', CAST(N'2020-07-02T03:15:25.7575187' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (304, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'user', CAST(N'2020-07-02T03:15:58.9192806' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (305, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-09","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'user', CAST(N'2020-07-02T03:16:00.9597360' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (306, N'Insert reservation', N'{"UserId":3,"ScreeningId":31,"AuditoriumId":1}', N'user', CAST(N'2020-07-02T03:16:02.0383671' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (307, N'Get single User', N'3', N'user', CAST(N'2020-07-02T03:16:06.0472658' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (308, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'user', CAST(N'2020-07-02T03:16:12.9729495' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (309, N'Insert reservation', N'{"UserId":3,"ScreeningId":8,"AuditoriumId":1}', N'user', CAST(N'2020-07-02T03:16:14.3945981' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (310, N'Insert reservation', N'{"UserId":3,"ScreeningId":8,"AuditoriumId":1}', N'user', CAST(N'2020-07-02T03:16:17.8609032' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (311, N'Get single User', N'3', N'user', CAST(N'2020-07-02T03:16:21.9352520' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (312, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-02","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'user', CAST(N'2020-07-02T03:16:33.6366873' AS DateTime2))
SET IDENTITY_INSERT [dbo].[AuditLogger] OFF
GO
SET IDENTITY_INSERT [dbo].[Auditoriums] ON 

INSERT [dbo].[Auditoriums] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Name]) VALUES (1, CAST(N'2020-07-02T01:40:18.3302435' AS DateTime2), NULL, 0, NULL, 1, N'Auditorium 1')
INSERT [dbo].[Auditoriums] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Name]) VALUES (2, CAST(N'2020-07-02T01:40:18.3303438' AS DateTime2), NULL, 0, NULL, 1, N'Auditorium 2')
SET IDENTITY_INSERT [dbo].[Auditoriums] OFF
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Title], [Description], [Duration], [Image]) VALUES (1, CAST(N'2020-07-02T01:40:18.3290468' AS DateTime2), NULL, 0, NULL, 1, N'The Shawshank Redemption ', N'Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.', 142, N'd72a304f-b6b0-466f-806d-505756825176.jpg')
INSERT [dbo].[Movies] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Title], [Description], [Duration], [Image]) VALUES (2, CAST(N'2020-07-02T01:40:18.3293317' AS DateTime2), NULL, 0, NULL, 1, N'The Godfather', N'The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.', 175, N'6d5dd6aa-477a-4a6d-9e32-1133607881c5.jpg')
INSERT [dbo].[Movies] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Title], [Description], [Duration], [Image]) VALUES (3, CAST(N'2020-07-02T01:40:18.3293406' AS DateTime2), NULL, 0, NULL, 1, N'The Dark Knight', N'When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.', 152, N'38e87283-fa50-4509-8a34-0b92afda5cc2.jpg')
INSERT [dbo].[Movies] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Title], [Description], [Duration], [Image]) VALUES (4, CAST(N'2020-07-02T01:40:18.3293421' AS DateTime2), NULL, 0, NULL, 1, N'12 Angry Men', N'A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.', 96, N'6d16d467-e8ac-4990-b5cd-1c3d103e82c0.jpg')
INSERT [dbo].[Movies] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Title], [Description], [Duration], [Image]) VALUES (5, CAST(N'2020-07-02T01:40:18.3293431' AS DateTime2), NULL, 0, NULL, 1, N'Schindler''s List', N'In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.', 195, N'9b263823-5bf0-41a2-8ff2-a6c6f873c43c.jpg')
INSERT [dbo].[Movies] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Title], [Description], [Duration], [Image]) VALUES (6, CAST(N'2020-07-02T01:40:18.3293446' AS DateTime2), NULL, 0, NULL, 1, N'The Lord of the Rings: The Return of the King', N'Gandalf and Aragorn lead the World of Men against Sauron''s army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.', 201, N'09459e52-bee9-4adc-8724-605b4f95fe62.jpg')
INSERT [dbo].[Movies] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Title], [Description], [Duration], [Image]) VALUES (7, CAST(N'2020-07-02T01:40:18.3293457' AS DateTime2), NULL, 0, NULL, 1, N'Pulp Fiction', N'The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.', 154, N'fc2645ba-d817-4a60-8150-f3c66777361b.jpg')
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
SET IDENTITY_INSERT [dbo].[Reservations] ON 

INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (6, CAST(N'2020-07-02T05:10:55.5817486' AS DateTime2), NULL, 0, NULL, 1, 1, 8)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (7, CAST(N'2020-07-02T05:11:00.6915689' AS DateTime2), NULL, 0, NULL, 1, 1, 11)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (8, CAST(N'2020-07-02T05:11:07.4901483' AS DateTime2), NULL, 0, NULL, 1, 1, 19)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (9, CAST(N'2020-07-02T05:11:14.7284668' AS DateTime2), NULL, 0, NULL, 1, 1, 23)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (10, CAST(N'2020-07-02T05:11:18.9741526' AS DateTime2), NULL, 0, NULL, 1, 1, 23)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (11, CAST(N'2020-07-02T05:11:24.9498778' AS DateTime2), NULL, 0, NULL, 1, 1, 29)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (12, CAST(N'2020-07-02T05:14:41.9055692' AS DateTime2), NULL, 0, NULL, 1, 3, 8)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (13, CAST(N'2020-07-02T05:14:48.0795777' AS DateTime2), NULL, 0, NULL, 1, 3, 3)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (14, CAST(N'2020-07-02T05:14:52.1967383' AS DateTime2), NULL, 0, NULL, 1, 3, 19)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (15, CAST(N'2020-07-02T05:14:58.3414847' AS DateTime2), NULL, 0, NULL, 1, 3, 5)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (16, CAST(N'2020-07-02T05:15:02.7799073' AS DateTime2), NULL, 0, NULL, 1, 3, 5)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (17, CAST(N'2020-07-02T05:15:09.3066060' AS DateTime2), NULL, 0, NULL, 1, 3, 1)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (18, CAST(N'2020-07-02T05:15:15.1955904' AS DateTime2), NULL, 0, NULL, 1, 3, 32)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (19, CAST(N'2020-07-02T05:15:21.6811010' AS DateTime2), NULL, 0, NULL, 1, 3, 33)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (20, CAST(N'2020-07-02T05:16:02.0448132' AS DateTime2), NULL, 0, NULL, 1, 3, 31)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (21, CAST(N'2020-07-02T05:16:14.4008033' AS DateTime2), NULL, 0, NULL, 1, 3, 8)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (22, CAST(N'2020-07-02T05:16:17.8641153' AS DateTime2), NULL, 0, NULL, 1, 3, 8)
SET IDENTITY_INSERT [dbo].[Reservations] OFF
GO
SET IDENTITY_INSERT [dbo].[Screenings] ON 

INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (1, CAST(N'2020-07-02T01:40:18.3294331' AS DateTime2), NULL, 0, NULL, 1, 1, 1, CAST(N'2020-07-04T15:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (2, CAST(N'2020-07-02T01:40:18.3300973' AS DateTime2), NULL, 0, NULL, 1, 2, 2, CAST(N'2020-07-02T15:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (3, CAST(N'2020-07-02T01:40:18.3301136' AS DateTime2), NULL, 0, NULL, 1, 3, 2, CAST(N'2020-07-03T15:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (4, CAST(N'2020-07-02T01:40:18.3301160' AS DateTime2), NULL, 0, NULL, 1, 4, 1, CAST(N'2020-07-06T17:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (5, CAST(N'2020-07-02T01:40:18.3301176' AS DateTime2), NULL, 0, NULL, 1, 4, 2, CAST(N'2020-07-04T17:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (6, CAST(N'2020-07-02T01:40:18.3301194' AS DateTime2), NULL, 0, NULL, 1, 6, 1, CAST(N'2020-07-05T15:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (7, CAST(N'2020-07-02T01:40:18.3301212' AS DateTime2), NULL, 0, NULL, 1, 7, 1, CAST(N'2020-07-02T20:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (8, CAST(N'2020-07-02T04:07:24.1202245' AS DateTime2), NULL, 0, NULL, 1, 1, 1, CAST(N'2020-07-02T15:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (11, CAST(N'2020-07-02T04:10:11.8261598' AS DateTime2), NULL, 0, NULL, 1, 3, 1, CAST(N'2020-07-02T17:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (19, CAST(N'2020-07-02T04:57:29.4944077' AS DateTime2), NULL, 0, NULL, 1, 3, 1, CAST(N'2020-07-03T17:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (21, CAST(N'2020-07-02T04:57:48.8819989' AS DateTime2), NULL, 0, NULL, 1, 7, 1, CAST(N'2020-07-04T17:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (22, CAST(N'2020-07-02T04:58:11.8077605' AS DateTime2), NULL, 0, NULL, 1, 2, 2, CAST(N'2020-07-05T20:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (23, CAST(N'2020-07-02T04:58:35.5119892' AS DateTime2), NULL, 0, NULL, 1, 1, 1, CAST(N'2020-07-03T20:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (25, CAST(N'2020-07-02T04:58:56.0347867' AS DateTime2), NULL, 0, NULL, 1, 4, 2, CAST(N'2020-07-03T20:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (26, CAST(N'2020-07-02T04:59:05.9263522' AS DateTime2), NULL, 0, NULL, 1, 1, 1, CAST(N'2020-07-07T15:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (29, CAST(N'2020-07-02T04:59:37.6178922' AS DateTime2), NULL, 0, NULL, 1, 5, 1, CAST(N'2020-07-06T20:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (30, CAST(N'2020-07-02T05:00:06.5671812' AS DateTime2), NULL, 0, NULL, 1, 6, 2, CAST(N'2020-07-03T17:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (31, CAST(N'2020-07-02T05:00:28.0282439' AS DateTime2), NULL, 0, NULL, 1, 1, 1, CAST(N'2020-07-09T15:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (32, CAST(N'2020-07-02T05:00:40.5826515' AS DateTime2), NULL, 0, NULL, 1, 4, 1, CAST(N'2020-07-08T15:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (33, CAST(N'2020-07-02T05:00:52.6061391' AS DateTime2), NULL, 0, NULL, 1, 7, 2, CAST(N'2020-07-07T20:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Screenings] OFF
GO
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-02T05:16:14.4262790' AS DateTime2), NULL, 0, NULL, 1, 1, 21, 8)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-02T05:14:52.2134600' AS DateTime2), NULL, 0, NULL, 1, 1, 14, 19)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-02T05:15:15.2226280' AS DateTime2), NULL, 0, NULL, 1, 3, 18, 32)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-02T05:15:09.3271030' AS DateTime2), NULL, 0, NULL, 1, 4, 17, 1)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-02T05:11:00.7184570' AS DateTime2), NULL, 0, NULL, 1, 4, 7, 11)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-02T05:11:14.7532593' AS DateTime2), NULL, 0, NULL, 1, 4, 9, 23)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-02T05:16:17.8678473' AS DateTime2), NULL, 0, NULL, 1, 5, 22, 8)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-02T05:14:41.9317425' AS DateTime2), NULL, 0, NULL, 1, 6, 12, 8)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-02T05:10:55.6037062' AS DateTime2), NULL, 0, NULL, 1, 8, 6, 8)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-02T05:11:18.9776004' AS DateTime2), NULL, 0, NULL, 1, 8, 10, 23)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-02T05:11:07.5106408' AS DateTime2), NULL, 0, NULL, 1, 9, 8, 19)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-02T05:11:24.9676042' AS DateTime2), NULL, 0, NULL, 1, 10, 11, 29)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-02T05:16:02.0751812' AS DateTime2), NULL, 0, NULL, 1, 10, 20, 31)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-02T05:14:58.3747969' AS DateTime2), NULL, 0, NULL, 1, 11, 15, 5)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-02T05:15:02.7992673' AS DateTime2), NULL, 0, NULL, 1, 14, 16, 5)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-02T05:14:48.1047379' AS DateTime2), NULL, 0, NULL, 1, 18, 13, 3)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-02T05:15:21.7100862' AS DateTime2), NULL, 0, NULL, 1, 19, 19, 33)
GO
SET IDENTITY_INSERT [dbo].[Seats] ON 

INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (1, CAST(N'2020-07-02T01:40:18.3304617' AS DateTime2), NULL, 0, NULL, 1, 1, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (2, CAST(N'2020-07-02T01:40:18.3306193' AS DateTime2), NULL, 0, NULL, 1, 2, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (3, CAST(N'2020-07-02T01:40:18.3306243' AS DateTime2), NULL, 0, NULL, 1, 3, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (4, CAST(N'2020-07-02T01:40:18.3306254' AS DateTime2), NULL, 0, NULL, 1, 4, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (5, CAST(N'2020-07-02T01:40:18.3306261' AS DateTime2), NULL, 0, NULL, 1, 5, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (6, CAST(N'2020-07-02T01:40:18.3306274' AS DateTime2), NULL, 0, NULL, 1, 6, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (7, CAST(N'2020-07-02T01:40:18.3306283' AS DateTime2), NULL, 0, NULL, 1, 7, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (8, CAST(N'2020-07-02T01:40:18.3306290' AS DateTime2), NULL, 0, NULL, 1, 8, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (9, CAST(N'2020-07-02T01:40:18.3306298' AS DateTime2), NULL, 0, NULL, 1, 9, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (10, CAST(N'2020-07-02T01:40:18.3306309' AS DateTime2), NULL, 0, NULL, 1, 10, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (11, CAST(N'2020-07-02T01:40:18.3306317' AS DateTime2), NULL, 0, NULL, 1, 1, 2)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (12, CAST(N'2020-07-02T01:40:18.3306324' AS DateTime2), NULL, 0, NULL, 1, 2, 2)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (13, CAST(N'2020-07-02T01:40:18.3306332' AS DateTime2), NULL, 0, NULL, 1, 3, 2)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (14, CAST(N'2020-07-02T01:40:18.3306339' AS DateTime2), NULL, 0, NULL, 1, 4, 2)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (15, CAST(N'2020-07-02T01:40:18.3306346' AS DateTime2), NULL, 0, NULL, 1, 5, 2)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (16, CAST(N'2020-07-02T01:40:18.3306353' AS DateTime2), NULL, 0, NULL, 1, 6, 2)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (17, CAST(N'2020-07-02T01:40:18.3306362' AS DateTime2), NULL, 0, NULL, 1, 7, 2)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (18, CAST(N'2020-07-02T01:40:18.3306372' AS DateTime2), NULL, 0, NULL, 1, 8, 2)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (19, CAST(N'2020-07-02T01:40:18.3306379' AS DateTime2), NULL, 0, NULL, 1, 9, 2)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (20, CAST(N'2020-07-02T01:40:18.3306386' AS DateTime2), NULL, 0, NULL, 1, 10, 2)
SET IDENTITY_INSERT [dbo].[Seats] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [FirstName], [LastName], [Email], [Username], [Password]) VALUES (1, CAST(N'2020-07-02T01:40:18.3241186' AS DateTime2), NULL, 0, NULL, 1, N'Admin', N'Admin', N'admin@gmail.com', N'adminAdmin', N'A12450CFF6FB7A97C975BFB7FCBB8F7E')
INSERT [dbo].[Users] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [FirstName], [LastName], [Email], [Username], [Password]) VALUES (3, CAST(N'2020-07-02T05:14:31.3113659' AS DateTime2), NULL, 0, NULL, 1, N'User', N'User', N'user@gmail.com', N'user', N'B4D1A9DE821CCF32107A1F3C846EC5E3')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[UserUseCases] ON 

INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (1, CAST(N'2020-07-02T01:40:18.3287214' AS DateTime2), NULL, 0, NULL, 1, 1, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (2, CAST(N'2020-07-02T01:40:18.3288801' AS DateTime2), NULL, 0, NULL, 1, 1, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (3, CAST(N'2020-07-02T01:40:18.3288857' AS DateTime2), NULL, 0, NULL, 1, 1, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (4, CAST(N'2020-07-02T01:40:18.3288869' AS DateTime2), NULL, 0, NULL, 1, 1, 4)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (5, CAST(N'2020-07-02T01:40:18.3288878' AS DateTime2), NULL, 0, NULL, 1, 1, 5)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (6, CAST(N'2020-07-02T01:40:18.3288892' AS DateTime2), NULL, 0, NULL, 1, 1, 6)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (7, CAST(N'2020-07-02T01:40:18.3288900' AS DateTime2), NULL, 0, NULL, 1, 1, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (8, CAST(N'2020-07-02T01:40:18.3288908' AS DateTime2), NULL, 0, NULL, 1, 1, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (9, CAST(N'2020-07-02T01:40:18.3288917' AS DateTime2), NULL, 0, NULL, 1, 1, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (10, CAST(N'2020-07-02T01:40:18.3288930' AS DateTime2), NULL, 0, NULL, 1, 1, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (11, CAST(N'2020-07-02T01:40:18.3288938' AS DateTime2), NULL, 0, NULL, 1, 1, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (12, CAST(N'2020-07-02T01:40:18.3288945' AS DateTime2), NULL, 0, NULL, 1, 1, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (13, CAST(N'2020-07-02T01:40:18.3288953' AS DateTime2), NULL, 0, NULL, 1, 1, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (14, CAST(N'2020-07-02T01:40:18.3288961' AS DateTime2), NULL, 0, NULL, 1, 1, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (15, CAST(N'2020-07-02T01:40:18.3288969' AS DateTime2), NULL, 0, NULL, 1, 1, 15)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (16, CAST(N'2020-07-02T01:40:18.3288977' AS DateTime2), NULL, 0, NULL, 1, 1, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (17, CAST(N'2020-07-02T01:40:18.3288985' AS DateTime2), NULL, 0, NULL, 1, 1, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (18, CAST(N'2020-07-02T01:40:18.3289001' AS DateTime2), NULL, 0, NULL, 1, 1, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (25, CAST(N'2020-07-02T05:14:31.3530376' AS DateTime2), NULL, 0, NULL, 1, 3, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (26, CAST(N'2020-07-02T05:14:31.3604129' AS DateTime2), NULL, 0, NULL, 1, 3, 6)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (27, CAST(N'2020-07-02T05:14:31.3604924' AS DateTime2), NULL, 0, NULL, 1, 3, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (28, CAST(N'2020-07-02T05:14:31.3605382' AS DateTime2), NULL, 0, NULL, 1, 3, 12)
SET IDENTITY_INSERT [dbo].[UserUseCases] OFF
GO
ALTER TABLE [dbo].[Movies] ADD  DEFAULT (N'') FOR [Image]
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Reservations_Screenings_ScreeningId] FOREIGN KEY([ScreeningId])
REFERENCES [dbo].[Screenings] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_Reservations_Screenings_ScreeningId]
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Reservations_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_Reservations_Users_UserId]
GO
ALTER TABLE [dbo].[Screenings]  WITH CHECK ADD  CONSTRAINT [FK_Screenings_Auditoriums_AuditoriumId] FOREIGN KEY([AuditoriumId])
REFERENCES [dbo].[Auditoriums] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Screenings] CHECK CONSTRAINT [FK_Screenings_Auditoriums_AuditoriumId]
GO
ALTER TABLE [dbo].[Screenings]  WITH CHECK ADD  CONSTRAINT [FK_Screenings_Movies_MovieId] FOREIGN KEY([MovieId])
REFERENCES [dbo].[Movies] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Screenings] CHECK CONSTRAINT [FK_Screenings_Movies_MovieId]
GO
ALTER TABLE [dbo].[SeatReserved]  WITH CHECK ADD  CONSTRAINT [FK_SeatReserved_Reservations_ReservationId] FOREIGN KEY([ReservationId])
REFERENCES [dbo].[Reservations] ([Id])
GO
ALTER TABLE [dbo].[SeatReserved] CHECK CONSTRAINT [FK_SeatReserved_Reservations_ReservationId]
GO
ALTER TABLE [dbo].[SeatReserved]  WITH CHECK ADD  CONSTRAINT [FK_SeatReserved_Screenings_ScreeningId] FOREIGN KEY([ScreeningId])
REFERENCES [dbo].[Screenings] ([Id])
GO
ALTER TABLE [dbo].[SeatReserved] CHECK CONSTRAINT [FK_SeatReserved_Screenings_ScreeningId]
GO
ALTER TABLE [dbo].[SeatReserved]  WITH CHECK ADD  CONSTRAINT [FK_SeatReserved_Seats_SeatId] FOREIGN KEY([SeatId])
REFERENCES [dbo].[Seats] ([Id])
GO
ALTER TABLE [dbo].[SeatReserved] CHECK CONSTRAINT [FK_SeatReserved_Seats_SeatId]
GO
ALTER TABLE [dbo].[Seats]  WITH CHECK ADD  CONSTRAINT [FK_Seats_Auditoriums_AuditoriumId] FOREIGN KEY([AuditoriumId])
REFERENCES [dbo].[Auditoriums] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Seats] CHECK CONSTRAINT [FK_Seats_Auditoriums_AuditoriumId]
GO
ALTER TABLE [dbo].[UserUseCases]  WITH CHECK ADD  CONSTRAINT [FK_UserUseCases_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserUseCases] CHECK CONSTRAINT [FK_UserUseCases_Users_UserId]
GO
