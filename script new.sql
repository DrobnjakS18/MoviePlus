USE [movie_plus]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/12/2020 4:23:52 PM ******/
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
/****** Object:  Table [dbo].[AuditLogger]    Script Date: 7/12/2020 4:23:52 PM ******/
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
/****** Object:  Table [dbo].[Auditoriums]    Script Date: 7/12/2020 4:23:52 PM ******/
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
/****** Object:  Table [dbo].[Movies]    Script Date: 7/12/2020 4:23:52 PM ******/
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
/****** Object:  Table [dbo].[Reservations]    Script Date: 7/12/2020 4:23:52 PM ******/
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
/****** Object:  Table [dbo].[Screenings]    Script Date: 7/12/2020 4:23:52 PM ******/
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
/****** Object:  Table [dbo].[SeatReserved]    Script Date: 7/12/2020 4:23:52 PM ******/
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
/****** Object:  Table [dbo].[Seats]    Script Date: 7/12/2020 4:23:52 PM ******/
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
/****** Object:  Table [dbo].[Users]    Script Date: 7/12/2020 4:23:52 PM ******/
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
/****** Object:  Table [dbo].[UserUseCases]    Script Date: 7/12/2020 4:23:52 PM ******/
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
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200710211017_Auditorium 3', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200710214405_Auditorium 4', N'3.1.5')
GO
SET IDENTITY_INSERT [dbo].[AuditLogger] ON 

INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (1, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-10","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:40:15.1399335' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (2, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-10","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:40:22.0433344' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (3, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:40:24.8923191' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (4, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:40:26.0078190' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (5, N'Insert Screening', N'{"Id":0,"MovieId":1,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":3,"Seats":0,"Date":"2020-07-11","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:40:35.2356380' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (6, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:40:36.8931052' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (7, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-10","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:40:38.5762049' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (8, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-11","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:40:40.6585357' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (9, N'Insert reservation', N'{"UserId":1,"ScreeningId":8,"AuditoriumId":3}', N'adminAdmin', CAST(N'2020-07-10T21:40:42.6858569' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (10, N'Get single User', N'1', N'adminAdmin', CAST(N'2020-07-10T21:40:48.6078647' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (11, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-10","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:44:54.6324619' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (12, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-11","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:45:07.2688991' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (13, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:45:11.6854163' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (14, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:45:12.3909535' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (15, N'Insert Screening', N'{"Id":0,"MovieId":3,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":2,"Seats":0,"Date":"2020-07-11","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:45:19.4992178' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (16, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:45:21.1198114' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (17, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:45:21.9444290' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (18, N'Insert Screening', N'{"Id":0,"MovieId":4,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":3,"Seats":0,"Date":"2020-07-11","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:45:29.0400311' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (19, N'Insert Screening', N'{"Id":0,"MovieId":4,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":4,"Seats":0,"Date":"2020-07-11","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:45:43.5973586' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (20, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:45:45.3108144' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (21, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:45:46.3391385' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (22, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-10","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:45:51.3300996' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (23, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-11","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:45:53.0830356' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (24, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:46:13.7452559' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (25, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:46:14.4385355' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (26, N'Insert Screening', N'{"Id":0,"MovieId":1,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-10","Time":"17","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:46:18.0086702' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (27, N'Insert Screening', N'{"Id":0,"MovieId":1,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-10","Time":"17","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:46:22.9364040' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (28, N'Insert Screening', N'{"Id":0,"MovieId":1,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-11","Time":"17","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:46:27.6325786' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (29, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:46:29.3412303' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (30, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:46:30.1231579' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (31, N'Insert Screening', N'{"Id":0,"MovieId":6,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-11","Time":"17","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:46:37.8574417' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (32, N'Insert Screening', N'{"Id":0,"MovieId":4,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":4,"Seats":0,"Date":"2020-07-11","Time":"17","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:46:48.6417336' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (33, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:46:50.0720502' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (34, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:46:51.7338746' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (35, N'Insert Screening', N'{"Id":0,"MovieId":2,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-12","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:47:01.8663225' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (36, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:47:03.5247699' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (37, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:47:04.7148718' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (38, N'Insert Screening', N'{"Id":0,"MovieId":5,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":4,"Seats":0,"Date":"2020-07-11","Time":"20","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:47:12.5216670' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (39, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:47:32.1114196' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (40, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:47:32.8744728' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (41, N'Insert Screening', N'{"Id":0,"MovieId":3,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":3,"Seats":0,"Date":"2020-07-12","Time":"17","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:47:42.6901201' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (42, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:47:44.2307655' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (43, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:47:44.9040457' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (44, N'Insert Screening', N'{"Id":0,"MovieId":7,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":2,"Seats":0,"Date":"2020-07-12","Time":"20","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:47:55.5552108' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (45, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:47:56.7889830' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (46, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:47:57.6846527' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (47, N'Insert Screening', N'{"Id":0,"MovieId":3,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":2,"Seats":0,"Date":"2020-07-13","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:48:05.2003708' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (48, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:48:06.6169425' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (49, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:48:07.5039368' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (50, N'Insert Screening', N'{"Id":0,"MovieId":4,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":4,"Seats":0,"Date":"2020-07-13","Time":"20","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:48:15.4888256' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (51, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:48:16.9018925' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (52, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:48:17.6448768' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (53, N'Insert Screening', N'{"Id":0,"MovieId":5,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":2,"Seats":0,"Date":"2020-07-13","Time":"20","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:48:26.7704698' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (54, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:48:28.1420876' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (55, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:48:29.1749846' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (56, N'Insert Screening', N'{"Id":0,"MovieId":2,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":3,"Seats":0,"Date":"2020-07-14","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:48:38.1698587' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (57, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:48:39.3039966' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (58, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:48:40.1729515' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (59, N'Insert Screening', N'{"Id":0,"MovieId":5,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":4,"Seats":0,"Date":"2020-07-14","Time":"20","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:48:47.9819138' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (60, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:48:49.0925371' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (61, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:48:50.1839298' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (62, N'Insert Screening', N'{"Id":0,"MovieId":7,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":2,"Seats":0,"Date":"2020-07-14","Time":"17","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:49:01.6118394' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (63, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:49:03.1030398' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (64, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:49:04.2026165' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (65, N'Insert Screening', N'{"Id":0,"MovieId":3,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-15","Time":"17","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:49:13.6887756' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (66, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:49:14.9917149' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (67, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:49:15.8578389' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (68, N'Insert Screening', N'{"Id":0,"MovieId":3,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":1,"Seats":0,"Date":"2020-07-15","Time":"20","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:49:23.7107316' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (69, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:49:25.0593492' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (70, N'Get single User', N'1', N'adminAdmin', CAST(N'2020-07-10T21:49:25.9730385' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (71, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-10","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:49:27.5520405' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (72, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:49:31.0637865' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (73, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:49:31.6004995' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (74, N'Insert Screening', N'{"Id":0,"MovieId":4,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":2,"Seats":0,"Date":"2020-07-15","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:49:39.4060274' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (75, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:49:40.7807915' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (76, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:49:41.6779588' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (77, N'Insert Screening', N'{"Id":0,"MovieId":2,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":4,"Seats":0,"Date":"2020-07-16","Time":"17","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:49:49.2278913' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (78, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:49:50.5017177' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (79, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:49:52.3264890' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (80, N'Insert Screening', N'{"Id":0,"MovieId":6,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":2,"Seats":0,"Date":"2020-07-15","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:50:00.5971620' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (81, N'Insert Screening', N'{"Id":0,"MovieId":6,"MovieName":null,"Description":null,"Duration":0,"Image":null,"AuditoriumName":null,"AuditoriumId":3,"Seats":0,"Date":"2020-07-15","Time":"15","ScreeningTime":"0001-01-01T00:00:00"}', N'adminAdmin', CAST(N'2020-07-10T21:50:08.0341594' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (82, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Usernam":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:50:09.2792808' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (83, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:50:10.7063775' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (84, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":3}', N'adminAdmin', CAST(N'2020-07-10T21:50:12.2942974' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (85, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-10","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:50:17.6358740' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (86, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-14","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:50:19.7145808' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (87, N'Insert reservation', N'{"UserId":1,"ScreeningId":22,"AuditoriumId":3}', N'adminAdmin', CAST(N'2020-07-10T21:50:20.5145881' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (88, N'Insert reservation', N'{"UserId":1,"ScreeningId":22,"AuditoriumId":3}', N'adminAdmin', CAST(N'2020-07-10T21:50:27.1790034' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (89, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-10","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:50:29.6049156' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (90, N'Get single User', N'1', N'adminAdmin', CAST(N'2020-07-10T21:50:31.9823050' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (91, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-10","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:50:34.2308348' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (92, N'Get single User', N'1', N'adminAdmin', CAST(N'2020-07-10T21:50:35.1127798' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (93, N'Get single User', N'1', N'adminAdmin', CAST(N'2020-07-10T21:50:36.2904901' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (94, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-10","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:50:42.3368584' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (95, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-10","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:50:48.2481287' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (96, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-15","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:50:50.6036496' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (97, N'Insert reservation', N'{"UserId":1,"ScreeningId":27,"AuditoriumId":2}', N'adminAdmin', CAST(N'2020-07-10T21:50:51.5515031' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (98, N'Insert reservation', N'{"UserId":1,"ScreeningId":27,"AuditoriumId":2}', N'adminAdmin', CAST(N'2020-07-10T21:50:55.3474386' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (99, N'Get movies', N'{"Title":null,"Description":null,"Time":"17","Date":"2020-07-15","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:50:59.4583711' AS DateTime2))
GO
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (100, N'Insert reservation', N'{"UserId":1,"ScreeningId":25,"AuditoriumId":1}', N'adminAdmin', CAST(N'2020-07-10T21:51:00.6023032' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (101, N'Get movies', N'{"Title":null,"Description":null,"Time":"17","Date":"2020-07-16","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:51:05.2731111' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (102, N'Insert reservation', N'{"UserId":1,"ScreeningId":28,"AuditoriumId":4}', N'adminAdmin', CAST(N'2020-07-10T21:51:06.2714885' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (103, N'Get movies', N'{"Title":null,"Description":null,"Time":"17","Date":"2020-07-13","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:51:11.1042354' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (104, N'Get movies', N'{"Title":null,"Description":null,"Time":"20","Date":"2020-07-13","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:51:12.3561350' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (105, N'Insert reservation', N'{"UserId":1,"ScreeningId":20,"AuditoriumId":4}', N'adminAdmin', CAST(N'2020-07-10T21:51:13.9374050' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (106, N'Get single User', N'1', N'adminAdmin', CAST(N'2020-07-10T21:51:18.5312997' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (107, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-10","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-10T21:51:22.1345595' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (108, N'Register user', N'{"Id":0,"FirstName":"User","LastName":"User","Email":"user@gmail.com","Username":"userUser","Password":"ciciban1","Tickets":null}', N'Anonymus user', CAST(N'2020-07-10T21:52:13.0149558' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (109, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-10","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'userUser', CAST(N'2020-07-10T21:52:25.1526645' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (110, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-11","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'userUser', CAST(N'2020-07-10T21:52:29.8790627' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (111, N'Insert reservation', N'{"UserId":3,"ScreeningId":8,"AuditoriumId":3}', N'userUser', CAST(N'2020-07-10T21:52:31.7623213' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (112, N'Insert reservation', N'{"UserId":3,"ScreeningId":8,"AuditoriumId":3}', N'userUser', CAST(N'2020-07-10T21:52:35.5004580' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (113, N'Get movies', N'{"Title":null,"Description":null,"Time":"17","Date":"2020-07-11","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'userUser', CAST(N'2020-07-10T21:52:39.9435632' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (114, N'Insert reservation', N'{"UserId":3,"ScreeningId":12,"AuditoriumId":1}', N'userUser', CAST(N'2020-07-10T21:52:41.2514587' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (115, N'Get movies', N'{"Title":null,"Description":null,"Time":"17","Date":"2020-07-12","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'userUser', CAST(N'2020-07-10T21:52:45.8934018' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (116, N'Insert reservation', N'{"UserId":3,"ScreeningId":17,"AuditoriumId":3}', N'userUser', CAST(N'2020-07-10T21:52:46.8725625' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (117, N'Get movies', N'{"Title":null,"Description":null,"Time":"17","Date":"2020-07-13","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'userUser', CAST(N'2020-07-10T21:52:51.5312255' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (118, N'Get movies', N'{"Title":null,"Description":null,"Time":"20","Date":"2020-07-13","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'userUser', CAST(N'2020-07-10T21:52:53.0304172' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (119, N'Insert reservation', N'{"UserId":3,"ScreeningId":20,"AuditoriumId":4}', N'userUser', CAST(N'2020-07-10T21:52:54.5495697' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (120, N'Get movies', N'{"Title":null,"Description":null,"Time":"20","Date":"2020-07-14","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'userUser', CAST(N'2020-07-10T21:53:02.5180393' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (121, N'Insert reservation', N'{"UserId":3,"ScreeningId":23,"AuditoriumId":4}', N'userUser', CAST(N'2020-07-10T21:53:03.5407332' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (122, N'Get single User', N'3', N'userUser', CAST(N'2020-07-10T21:53:07.2446898' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (123, N'Register user', N'{"Id":0,"FirstName":"User2","LastName":"User2","Email":"user2@gmail.com","Username":"userUser2","Password":"ciciban2","Tickets":null}', N'Anonymus user', CAST(N'2020-07-10T21:53:25.1841390' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (124, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-10","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'userUser2', CAST(N'2020-07-10T21:53:39.4180717' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (125, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-11","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'userUser2', CAST(N'2020-07-10T21:53:43.6037396' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (126, N'Insert reservation', N'{"UserId":4,"ScreeningId":8,"AuditoriumId":3}', N'userUser2', CAST(N'2020-07-10T21:53:44.8410867' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (127, N'Insert reservation', N'{"UserId":4,"ScreeningId":8,"AuditoriumId":3}', N'userUser2', CAST(N'2020-07-10T21:53:48.6661739' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (128, N'Get movies', N'{"Title":null,"Description":null,"Time":"17","Date":"2020-07-11","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'userUser2', CAST(N'2020-07-10T21:53:52.9103958' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (129, N'Insert reservation', N'{"UserId":4,"ScreeningId":12,"AuditoriumId":1}', N'userUser2', CAST(N'2020-07-10T21:53:54.2999404' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (130, N'Get movies', N'{"Title":null,"Description":null,"Time":"17","Date":"2020-07-14","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'userUser2', CAST(N'2020-07-10T21:53:58.7544472' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (131, N'Insert reservation', N'{"UserId":4,"ScreeningId":24,"AuditoriumId":2}', N'userUser2', CAST(N'2020-07-10T21:53:59.6261578' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (132, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-14","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'userUser2', CAST(N'2020-07-10T21:54:03.6887159' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (133, N'Insert reservation', N'{"UserId":4,"ScreeningId":22,"AuditoriumId":3}', N'userUser2', CAST(N'2020-07-10T21:54:04.5035661' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (134, N'Get single User', N'4', N'userUser2', CAST(N'2020-07-10T21:54:09.8507092' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (135, N'Get Reservation', N'20', N'adminAdmin', CAST(N'2020-07-12T00:02:56.0452705' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (136, N'Get Reservation', N'20', N'adminAdmin', CAST(N'2020-07-12T00:04:08.2918128' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (137, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-12","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T00:04:58.6091924' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (138, N'Get Reservation', N'20', N'adminAdmin', CAST(N'2020-07-12T00:05:09.6021715' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (139, N'Search Auditoirums', N'{"Name":"Auditorium 1","ItemsPerPage":10,"CurrentPage":1}', N'Anonymus user', CAST(N'2020-07-12T09:05:03.3364013' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (140, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-12","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T09:06:14.6271521' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (141, N'Search Auditoirums', N'{"Name":"Auditorium 1","ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T09:06:31.1545377' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (142, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-12","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T09:08:19.1596703' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (143, N'Search Auditoirums', N'{"Name":"Auditorium 1","ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T09:08:29.9286619' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (144, N'Search Auditoirums', N'{"Name":"Auditorium","ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T09:09:10.1399180' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (145, N'Search Auditoirums', N'{"Name":"Auditorium","ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T09:12:11.5480201' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (146, N'Search Auditoirums', N'{"Name":"Auditorium","ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T09:19:59.8394341' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (147, N'Search Auditoirums', N'{"Name":"Auditorium","ItemsPerPage":2,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T09:20:21.1540510' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (148, N'Search Auditoirums', N'{"Name":"Auditorium","ItemsPerPage":2,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T09:44:17.5562876' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (149, N'Get Single Auditorium', N'1', N'adminAdmin', CAST(N'2020-07-12T09:59:54.4190420' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (150, N'Get Single Auditorium', N'1', N'adminAdmin', CAST(N'2020-07-12T10:01:25.0542027' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (151, N'Get Single Auditorium', N'1', N'adminAdmin', CAST(N'2020-07-12T10:03:25.5539307' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (152, N'Insert Auditoirum', N'{"Id":0,"Name":"a","CreatedAt":"0001-01-01T00:00:00","SeatsSum":0,"AuditoirumSeats":[]}', N'adminAdmin', CAST(N'2020-07-12T10:28:46.5737962' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (153, N'Insert Auditoirum', N'{"Id":0,"Name":"Auditorium 1","CreatedAt":"0001-01-01T00:00:00","SeatsSum":0,"AuditoirumSeats":[]}', N'adminAdmin', CAST(N'2020-07-12T10:29:09.6546640' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (154, N'Insert Auditoirum', N'{"Id":0,"Name":"Auditorium 5","CreatedAt":"0001-01-01T00:00:00","SeatsSum":0,"AuditoirumSeats":[]}', N'adminAdmin', CAST(N'2020-07-12T10:29:20.0967688' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (155, N'Update Auditorium', N'{"Id":5,"Name":"Auditorium 5"}', N'adminAdmin', CAST(N'2020-07-12T11:02:17.2009935' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (156, N'Update Auditorium', N'{"Id":5,"Name":"Auditorium 1"}', N'adminAdmin', CAST(N'2020-07-12T11:02:29.1308263' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (157, N'Update Auditorium', N'{"Id":5,"Name":"Auditorium 10"}', N'adminAdmin', CAST(N'2020-07-12T11:02:41.6375251' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (158, N'Search Auditoirums', N'{"Name":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T11:02:46.7215828' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (159, N'Delete Auditorium', N'5', N'adminAdmin', CAST(N'2020-07-12T11:07:46.5579927' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (160, N'Search Auditoirums', N'{"Name":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T11:07:55.6030195' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (161, N'Search Seats', N'{"MinSeatNumber":0,"MaxSeatNumber":0,"ItemsPerPage":10,"CurrentPage":1}', N'Anonymus user', CAST(N'2020-07-12T11:50:22.1519851' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (162, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-12","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T11:50:54.9013730' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (163, N'Search Seats', N'{"MinSeatNumber":0,"MaxSeatNumber":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T11:51:40.0440854' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (164, N'Search Seats', N'{"MinSeatNumber":0,"MaxSeatNumber":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T11:52:43.2333564' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (165, N'Search Seats', N'{"MinSeatNumber":0,"MaxSeatNumber":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T11:54:14.4453770' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (166, N'Search Seats', N'{"MinSeatNumber":0,"MaxSeatNumber":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T11:54:48.6459400' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (167, N'Search Seats', N'{"MinSeatNumber":5,"MaxSeatNumber":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T11:55:03.2908909' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (168, N'Search Seats', N'{"MinSeatNumber":0,"MaxSeatNumber":0,"Auditorium":"Auditorium 1","ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T11:57:37.1866131' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (169, N'Search Seats', N'{"MinSeatNumber":0,"MaxSeatNumber":0,"Auditorium":"Auditorium 2","ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T11:57:45.3008746' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (170, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-12","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T12:00:55.1575628' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (171, N'Search Seats', N'{"MinSeatNumber":0,"MaxSeatNumber":0,"Auditorium":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T12:13:57.4530934' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (172, N'Get single Seat', N'1', N'adminAdmin', CAST(N'2020-07-12T12:16:28.5479047' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (173, N'Get single Seat', N'1', N'adminAdmin', CAST(N'2020-07-12T12:19:21.8180760' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (174, N'Get single Seat', N'1', N'adminAdmin', CAST(N'2020-07-12T12:20:22.8168492' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (175, N'Get single Seat', N'1', N'adminAdmin', CAST(N'2020-07-12T12:22:10.8252945' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (176, N'Seat insert', N'{"Number":1,"AuditoriumName":null}', N'adminAdmin', CAST(N'2020-07-12T12:57:30.6304758' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (177, N'Seat insert', N'{"Number":1,"AuditoriumName":null}', N'adminAdmin', CAST(N'2020-07-12T12:57:51.6233053' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (178, N'Seat insert', N'{"Number":1,"AuditoriumName":null}', N'adminAdmin', CAST(N'2020-07-12T13:00:13.8220606' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (179, N'Seat insert', N'{"Number":1,"AuditoriumName":null}', N'adminAdmin', CAST(N'2020-07-12T13:02:29.1859369' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (180, N'Seat insert', N'{"Number":1,"AuditoriumName":null}', N'adminAdmin', CAST(N'2020-07-12T13:03:45.2957432' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (181, N'Seat insert', N'{"Number":1,"AuditoriumName":null}', N'adminAdmin', CAST(N'2020-07-12T13:04:25.8012702' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (182, N'Seat insert', N'{"Number":1,"AuditoriumName":null}', N'adminAdmin', CAST(N'2020-07-12T13:05:42.3203350' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (183, N'Seat insert', N'{"Number":1,"AuditoriumName":" asdads"}', N'adminAdmin', CAST(N'2020-07-12T13:06:03.4692850' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (184, N'Seat insert', N'{"Number":1,"AuditoriumName":" asdads"}', N'adminAdmin', CAST(N'2020-07-12T13:06:56.9216040' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (185, N'Seat insert', N'{"Number":1,"AuditoriumName":" asdads"}', N'adminAdmin', CAST(N'2020-07-12T13:09:04.0261618' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (186, N'Seat insert', N'{"Number":1,"AuditoriumName":"Auditorium 1"}', N'adminAdmin', CAST(N'2020-07-12T13:09:26.1595197' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (187, N'Seat insert', N'{"Number":11,"AuditoriumName":"Auditorium 1"}', N'adminAdmin', CAST(N'2020-07-12T13:09:37.1001097' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (188, N'Get single Seat', N'1', N'adminAdmin', CAST(N'2020-07-12T13:30:08.8127692' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (189, N'Get single Seat', N'45', N'adminAdmin', CAST(N'2020-07-12T13:30:16.5144101' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (190, N'Get single Seat', N'35', N'adminAdmin', CAST(N'2020-07-12T13:30:30.7899897' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (191, N'Update Seat', N'{"Id":35,"Number":11,"AuditoriumName":null}', N'adminAdmin', CAST(N'2020-07-12T13:30:56.5702144' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (192, N'Update Seat', N'{"Id":35,"Number":11,"AuditoriumName":"Auditorium 1"}', N'adminAdmin', CAST(N'2020-07-12T13:31:23.0748288' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (193, N'Update Seat', N'{"Id":35,"Number":11,"AuditoriumName":"Auditorium 4"}', N'adminAdmin', CAST(N'2020-07-12T13:31:36.5163579' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (194, N'Get single Seat', N'35', N'adminAdmin', CAST(N'2020-07-12T13:31:42.3334967' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (195, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-12","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T13:43:22.1090074' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (196, N'Get single Seat', N'51', N'adminAdmin', CAST(N'2020-07-12T13:44:35.0233719' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (197, N'Search Seats', N'{"MinSeatNumber":0,"MaxSeatNumber":0,"Auditorium":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T13:44:54.0498452' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (198, N'Delete Seat', N'51', N'adminAdmin', CAST(N'2020-07-12T13:45:44.7651172' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (199, N'Search Seats', N'{"MinSeatNumber":0,"MaxSeatNumber":0,"Auditorium":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T13:45:54.0785175' AS DateTime2))
GO
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (200, N'Insert Auditoirum', N'{"Id":0,"Name":"Auditorium 5","CreatedAt":"0001-01-01T00:00:00","SeatsSum":0,"AuditoirumSeats":[]}', N'adminAdmin', CAST(N'2020-07-12T13:56:12.9884577' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (201, N'Delete User', N'6', N'adminAdmin', CAST(N'2020-07-12T13:56:28.3841624' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (202, N'Delete Auditorium', N'6', N'adminAdmin', CAST(N'2020-07-12T13:57:08.3863407' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (203, N'Delete Auditorium', N'6', N'adminAdmin', CAST(N'2020-07-12T13:59:47.6660521' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (204, N'Insert Auditoirum', N'{"Id":0,"Name":"Auditorium 5","CreatedAt":"0001-01-01T00:00:00","SeatsSum":0,"AuditoirumSeats":[]}', N'adminAdmin', CAST(N'2020-07-12T14:02:07.5202297' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (205, N'Delete Auditorium', N'7', N'adminAdmin', CAST(N'2020-07-12T14:02:16.2724686' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (206, N'Get movies', N'{"Title":null,"Description":null,"Time":"15","Date":"2020-07-12","Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T14:08:17.1877920' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (207, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Username":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T14:08:19.8209649' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (208, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T14:08:22.1389686' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (209, N'Insert movie', N'{"Id":0,"Title":"PIcture 1","Description":"sadsasadasd","Duration":3,"Auditorium":null,"Image":"b0d80e2b-6e17-415f-8eb1-90aab558a497.png","Date":null,"Time":null,"SeatNumber":0,"ReservationId":0,"ScreeningTime":"0001-01-01T00:00:00","Screening":null}', N'adminAdmin', CAST(N'2020-07-12T14:08:51.6814058' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (210, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Username":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T14:08:53.6018747' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (211, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T14:08:55.4945783' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (212, N'Delete movie', N'8', N'adminAdmin', CAST(N'2020-07-12T14:08:58.7248389' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (213, N'Get users', N'{"FirstName":null,"LastName":null,"Email":null,"Username":null,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T14:09:00.7724444' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (214, N'Get movies', N'{"Title":null,"Description":null,"Time":null,"Date":null,"Duration":0,"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T14:09:02.5029661' AS DateTime2))
INSERT [dbo].[AuditLogger] ([Id], [UseCaseName], [Data], [Actor], [Time]) VALUES (215, N'Get Screening Time', N'{"ItemsPerPage":10,"CurrentPage":1}', N'adminAdmin', CAST(N'2020-07-12T14:09:12.0819570' AS DateTime2))
SET IDENTITY_INSERT [dbo].[AuditLogger] OFF
GO
SET IDENTITY_INSERT [dbo].[Auditoriums] ON 

INSERT [dbo].[Auditoriums] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Name]) VALUES (1, CAST(N'2020-07-10T23:44:03.9522987' AS DateTime2), NULL, 0, NULL, 1, N'Auditorium 1')
INSERT [dbo].[Auditoriums] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Name]) VALUES (2, CAST(N'2020-07-10T23:44:03.9523948' AS DateTime2), NULL, 0, NULL, 1, N'Auditorium 2')
INSERT [dbo].[Auditoriums] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Name]) VALUES (3, CAST(N'2020-07-10T23:44:03.9523995' AS DateTime2), NULL, 0, NULL, 1, N'Auditorium 3')
INSERT [dbo].[Auditoriums] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Name]) VALUES (4, CAST(N'2020-07-10T23:44:03.9524018' AS DateTime2), NULL, 0, NULL, 1, N'Auditorium 4')
SET IDENTITY_INSERT [dbo].[Auditoriums] OFF
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Title], [Description], [Duration], [Image]) VALUES (1, CAST(N'2020-07-10T23:44:03.9513501' AS DateTime2), NULL, 0, NULL, 1, N'The Shawshank Redemption ', N'Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.', 142, N'd72a304f-b6b0-466f-806d-505756825176.jpg')
INSERT [dbo].[Movies] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Title], [Description], [Duration], [Image]) VALUES (2, CAST(N'2020-07-10T23:44:03.9517181' AS DateTime2), NULL, 0, NULL, 1, N'The Godfather', N'The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.', 175, N'6d5dd6aa-477a-4a6d-9e32-1133607881c5.jpg')
INSERT [dbo].[Movies] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Title], [Description], [Duration], [Image]) VALUES (3, CAST(N'2020-07-10T23:44:03.9517317' AS DateTime2), NULL, 0, NULL, 1, N'The Dark Knight', N'When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.', 152, N'38e87283-fa50-4509-8a34-0b92afda5cc2.jpg')
INSERT [dbo].[Movies] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Title], [Description], [Duration], [Image]) VALUES (4, CAST(N'2020-07-10T23:44:03.9517336' AS DateTime2), NULL, 0, NULL, 1, N'12 Angry Men', N'A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.', 96, N'6d16d467-e8ac-4990-b5cd-1c3d103e82c0.jpg')
INSERT [dbo].[Movies] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Title], [Description], [Duration], [Image]) VALUES (5, CAST(N'2020-07-10T23:44:03.9517349' AS DateTime2), NULL, 0, NULL, 1, N'Schindler''s List', N'In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.', 195, N'9b263823-5bf0-41a2-8ff2-a6c6f873c43c.jpg')
INSERT [dbo].[Movies] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Title], [Description], [Duration], [Image]) VALUES (6, CAST(N'2020-07-10T23:44:03.9517432' AS DateTime2), NULL, 0, NULL, 1, N'The Lord of the Rings: The Return of the King', N'Gandalf and Aragorn lead the World of Men against Sauron''s army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.', 201, N'09459e52-bee9-4adc-8724-605b4f95fe62.jpg')
INSERT [dbo].[Movies] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Title], [Description], [Duration], [Image]) VALUES (7, CAST(N'2020-07-10T23:44:03.9517448' AS DateTime2), NULL, 0, NULL, 1, N'Pulp Fiction', N'The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.', 154, N'fc2645ba-d817-4a60-8150-f3c66777361b.jpg')
INSERT [dbo].[Movies] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Title], [Description], [Duration], [Image]) VALUES (8, CAST(N'2020-07-12T16:08:51.7657563' AS DateTime2), NULL, 1, CAST(N'2020-07-12T16:08:58.7965549' AS DateTime2), 0, N'PIcture 1', N'sadsasadasd', 3, N'b0d80e2b-6e17-415f-8eb1-90aab558a497.png')
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
SET IDENTITY_INSERT [dbo].[Reservations] ON 

INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (5, CAST(N'2020-07-10T23:40:42.7029239' AS DateTime2), NULL, 0, NULL, 1, 1, 8)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (6, CAST(N'2020-07-10T23:50:20.5240656' AS DateTime2), NULL, 0, NULL, 1, 1, 22)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (7, CAST(N'2020-07-10T23:50:27.2132210' AS DateTime2), NULL, 0, NULL, 1, 1, 22)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (8, CAST(N'2020-07-10T23:50:51.5634802' AS DateTime2), NULL, 0, NULL, 1, 1, 27)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (9, CAST(N'2020-07-10T23:50:55.3518000' AS DateTime2), NULL, 0, NULL, 1, 1, 27)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (10, CAST(N'2020-07-10T23:51:00.6052707' AS DateTime2), NULL, 0, NULL, 1, 1, 25)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (11, CAST(N'2020-07-10T23:51:06.2739698' AS DateTime2), NULL, 0, NULL, 1, 1, 28)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (12, CAST(N'2020-07-10T23:51:13.9405526' AS DateTime2), NULL, 0, NULL, 1, 1, 20)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (13, CAST(N'2020-07-10T23:52:31.7660017' AS DateTime2), NULL, 0, NULL, 1, 3, 8)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (14, CAST(N'2020-07-10T23:52:35.5056437' AS DateTime2), NULL, 0, NULL, 1, 3, 8)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (15, CAST(N'2020-07-10T23:52:41.2548510' AS DateTime2), NULL, 0, NULL, 1, 3, 12)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (16, CAST(N'2020-07-10T23:52:46.8804658' AS DateTime2), NULL, 0, NULL, 1, 3, 17)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (17, CAST(N'2020-07-10T23:52:54.5525510' AS DateTime2), NULL, 0, NULL, 1, 3, 20)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (18, CAST(N'2020-07-10T23:53:03.5476425' AS DateTime2), NULL, 0, NULL, 1, 3, 23)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (19, CAST(N'2020-07-10T23:53:44.8466262' AS DateTime2), NULL, 0, NULL, 1, 4, 8)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (20, CAST(N'2020-07-10T23:53:48.6695976' AS DateTime2), NULL, 0, NULL, 1, 4, 8)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (21, CAST(N'2020-07-10T23:53:54.3030109' AS DateTime2), NULL, 0, NULL, 1, 4, 12)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (22, CAST(N'2020-07-10T23:53:59.6294425' AS DateTime2), NULL, 0, NULL, 1, 4, 24)
INSERT [dbo].[Reservations] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [ScreeningId]) VALUES (23, CAST(N'2020-07-10T23:54:04.5064059' AS DateTime2), NULL, 0, NULL, 1, 4, 22)
SET IDENTITY_INSERT [dbo].[Reservations] OFF
GO
SET IDENTITY_INSERT [dbo].[Screenings] ON 

INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (1, CAST(N'2020-07-10T23:44:03.9518539' AS DateTime2), NULL, 0, NULL, 1, 1, 1, CAST(N'2020-07-04T15:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (2, CAST(N'2020-07-10T23:44:03.9521633' AS DateTime2), NULL, 0, NULL, 1, 2, 2, CAST(N'2020-07-02T15:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (3, CAST(N'2020-07-10T23:44:03.9521739' AS DateTime2), NULL, 0, NULL, 1, 3, 2, CAST(N'2020-07-03T15:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (4, CAST(N'2020-07-10T23:44:03.9521765' AS DateTime2), NULL, 0, NULL, 1, 4, 1, CAST(N'2020-07-06T17:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (5, CAST(N'2020-07-10T23:44:03.9521776' AS DateTime2), NULL, 0, NULL, 1, 4, 2, CAST(N'2020-07-04T17:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (6, CAST(N'2020-07-10T23:44:03.9521793' AS DateTime2), NULL, 0, NULL, 1, 6, 1, CAST(N'2020-07-05T15:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (7, CAST(N'2020-07-10T23:44:03.9521805' AS DateTime2), NULL, 0, NULL, 1, 7, 1, CAST(N'2020-07-02T20:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (8, CAST(N'2020-07-10T23:40:35.2652065' AS DateTime2), NULL, 0, NULL, 1, 1, 3, CAST(N'2020-07-11T15:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (9, CAST(N'2020-07-10T23:45:19.5235558' AS DateTime2), NULL, 0, NULL, 1, 3, 2, CAST(N'2020-07-11T15:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (11, CAST(N'2020-07-10T23:45:43.6190188' AS DateTime2), NULL, 0, NULL, 1, 4, 4, CAST(N'2020-07-11T15:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (12, CAST(N'2020-07-10T23:46:27.6375089' AS DateTime2), NULL, 0, NULL, 1, 1, 1, CAST(N'2020-07-11T17:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (14, CAST(N'2020-07-10T23:46:48.6511574' AS DateTime2), NULL, 0, NULL, 1, 4, 4, CAST(N'2020-07-11T17:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (15, CAST(N'2020-07-10T23:47:01.8702608' AS DateTime2), NULL, 0, NULL, 1, 2, 1, CAST(N'2020-07-12T15:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (16, CAST(N'2020-07-10T23:47:12.5242563' AS DateTime2), NULL, 0, NULL, 1, 5, 4, CAST(N'2020-07-11T20:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (17, CAST(N'2020-07-10T23:47:42.6928458' AS DateTime2), NULL, 0, NULL, 1, 3, 3, CAST(N'2020-07-12T17:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (18, CAST(N'2020-07-10T23:47:55.5585394' AS DateTime2), NULL, 0, NULL, 1, 7, 2, CAST(N'2020-07-12T20:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (19, CAST(N'2020-07-10T23:48:05.2029917' AS DateTime2), NULL, 0, NULL, 1, 3, 2, CAST(N'2020-07-13T15:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (20, CAST(N'2020-07-10T23:48:15.4928988' AS DateTime2), NULL, 0, NULL, 1, 4, 4, CAST(N'2020-07-13T20:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (21, CAST(N'2020-07-10T23:48:26.7731791' AS DateTime2), NULL, 0, NULL, 1, 5, 2, CAST(N'2020-07-13T20:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (22, CAST(N'2020-07-10T23:48:38.1730447' AS DateTime2), NULL, 0, NULL, 1, 2, 3, CAST(N'2020-07-14T15:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (23, CAST(N'2020-07-10T23:48:47.9845969' AS DateTime2), NULL, 0, NULL, 1, 5, 4, CAST(N'2020-07-14T20:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (24, CAST(N'2020-07-10T23:49:01.6158659' AS DateTime2), NULL, 0, NULL, 1, 7, 2, CAST(N'2020-07-14T17:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (25, CAST(N'2020-07-10T23:49:13.6910625' AS DateTime2), NULL, 0, NULL, 1, 3, 1, CAST(N'2020-07-15T17:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (26, CAST(N'2020-07-10T23:49:23.7169043' AS DateTime2), NULL, 0, NULL, 1, 3, 1, CAST(N'2020-07-15T20:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (27, CAST(N'2020-07-10T23:49:39.4081166' AS DateTime2), NULL, 0, NULL, 1, 4, 2, CAST(N'2020-07-15T15:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (28, CAST(N'2020-07-10T23:49:49.2434901' AS DateTime2), NULL, 0, NULL, 1, 2, 4, CAST(N'2020-07-16T17:00:00.0000000' AS DateTime2))
INSERT [dbo].[Screenings] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [MovieId], [AuditoriumId], [ScreeningTime]) VALUES (30, CAST(N'2020-07-10T23:50:08.0366515' AS DateTime2), NULL, 0, NULL, 1, 6, 3, CAST(N'2020-07-15T15:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Screenings] OFF
GO
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-10T23:53:54.3166172' AS DateTime2), NULL, 0, NULL, 1, 6, 21, 12)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-10T23:51:00.6305839' AS DateTime2), NULL, 0, NULL, 1, 7, 10, 25)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-10T23:52:41.2855458' AS DateTime2), NULL, 0, NULL, 1, 8, 15, 12)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-10T23:53:59.6492030' AS DateTime2), NULL, 0, NULL, 1, 12, 22, 24)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-10T23:50:55.3546764' AS DateTime2), NULL, 0, NULL, 1, 18, 9, 27)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-10T23:50:51.6013671' AS DateTime2), NULL, 0, NULL, 1, 19, 8, 27)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-10T23:50:42.8042485' AS DateTime2), NULL, 0, NULL, 1, 21, 7, 22)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-10T23:52:35.5240142' AS DateTime2), NULL, 0, NULL, 1, 22, 14, 8)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-10T23:53:48.6725065' AS DateTime2), NULL, 0, NULL, 1, 24, 20, 8)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-10T23:40:42.8003460' AS DateTime2), NULL, 0, NULL, 1, 26, 5, 8)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-10T23:50:20.5914223' AS DateTime2), NULL, 0, NULL, 1, 26, 6, 22)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-10T23:53:44.8664808' AS DateTime2), NULL, 0, NULL, 1, 28, 19, 8)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-10T23:52:46.9003034' AS DateTime2), NULL, 0, NULL, 1, 29, 16, 17)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-10T23:54:04.5194954' AS DateTime2), NULL, 0, NULL, 1, 29, 23, 22)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-10T23:52:31.7929793' AS DateTime2), NULL, 0, NULL, 1, 30, 13, 8)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-10T23:53:03.5662860' AS DateTime2), NULL, 0, NULL, 1, 36, 18, 23)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-10T23:51:06.2992138' AS DateTime2), NULL, 0, NULL, 1, 36, 11, 28)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-10T23:52:54.5653940' AS DateTime2), NULL, 0, NULL, 1, 37, 17, 20)
INSERT [dbo].[SeatReserved] ([CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [SeatId], [ReservationId], [ScreeningId]) VALUES (CAST(N'2020-07-10T23:51:13.9661963' AS DateTime2), NULL, 0, NULL, 1, 38, 12, 20)
GO
SET IDENTITY_INSERT [dbo].[Seats] ON 

INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (1, CAST(N'2020-07-10T23:44:03.9525091' AS DateTime2), NULL, 0, NULL, 1, 1, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (2, CAST(N'2020-07-10T23:44:03.9526881' AS DateTime2), NULL, 0, NULL, 1, 2, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (3, CAST(N'2020-07-10T23:44:03.9526945' AS DateTime2), NULL, 0, NULL, 1, 3, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (4, CAST(N'2020-07-10T23:44:03.9526961' AS DateTime2), NULL, 0, NULL, 1, 4, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (5, CAST(N'2020-07-10T23:44:03.9526970' AS DateTime2), NULL, 0, NULL, 1, 5, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (6, CAST(N'2020-07-10T23:44:03.9526985' AS DateTime2), NULL, 0, NULL, 1, 6, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (7, CAST(N'2020-07-10T23:44:03.9526996' AS DateTime2), NULL, 0, NULL, 1, 7, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (8, CAST(N'2020-07-10T23:44:03.9527005' AS DateTime2), NULL, 0, NULL, 1, 8, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (9, CAST(N'2020-07-10T23:44:03.9527013' AS DateTime2), NULL, 0, NULL, 1, 9, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (10, CAST(N'2020-07-10T23:44:03.9527025' AS DateTime2), NULL, 0, NULL, 1, 10, 1)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (11, CAST(N'2020-07-10T23:44:03.9527035' AS DateTime2), NULL, 0, NULL, 1, 1, 2)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (12, CAST(N'2020-07-10T23:44:03.9527044' AS DateTime2), NULL, 0, NULL, 1, 2, 2)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (13, CAST(N'2020-07-10T23:44:03.9527052' AS DateTime2), NULL, 0, NULL, 1, 3, 2)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (14, CAST(N'2020-07-10T23:44:03.9527062' AS DateTime2), NULL, 0, NULL, 1, 4, 2)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (15, CAST(N'2020-07-10T23:44:03.9527073' AS DateTime2), NULL, 0, NULL, 1, 5, 2)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (16, CAST(N'2020-07-10T23:44:03.9527082' AS DateTime2), NULL, 0, NULL, 1, 6, 2)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (17, CAST(N'2020-07-10T23:44:03.9527092' AS DateTime2), NULL, 0, NULL, 1, 7, 2)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (18, CAST(N'2020-07-10T23:44:03.9527107' AS DateTime2), NULL, 0, NULL, 1, 8, 2)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (19, CAST(N'2020-07-10T23:44:03.9527120' AS DateTime2), NULL, 0, NULL, 1, 9, 2)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (20, CAST(N'2020-07-10T23:44:03.9527131' AS DateTime2), NULL, 0, NULL, 1, 10, 2)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (21, CAST(N'2020-07-10T23:44:03.9527141' AS DateTime2), NULL, 0, NULL, 1, 1, 3)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (22, CAST(N'2020-07-10T23:44:03.9527150' AS DateTime2), NULL, 0, NULL, 1, 2, 3)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (23, CAST(N'2020-07-10T23:44:03.9527159' AS DateTime2), NULL, 0, NULL, 1, 3, 3)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (24, CAST(N'2020-07-10T23:44:03.9527170' AS DateTime2), NULL, 0, NULL, 1, 4, 3)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (25, CAST(N'2020-07-10T23:44:03.9527180' AS DateTime2), NULL, 0, NULL, 1, 5, 3)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (26, CAST(N'2020-07-10T23:44:03.9527191' AS DateTime2), NULL, 0, NULL, 1, 6, 3)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (27, CAST(N'2020-07-10T23:44:03.9527200' AS DateTime2), NULL, 0, NULL, 1, 7, 3)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (28, CAST(N'2020-07-10T23:44:03.9527210' AS DateTime2), NULL, 0, NULL, 1, 8, 3)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (29, CAST(N'2020-07-10T23:44:03.9527219' AS DateTime2), NULL, 0, NULL, 1, 9, 3)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (30, CAST(N'2020-07-10T23:44:03.9527229' AS DateTime2), NULL, 0, NULL, 1, 10, 3)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (31, CAST(N'2020-07-10T23:44:03.9527241' AS DateTime2), NULL, 0, NULL, 1, 1, 4)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (32, CAST(N'2020-07-10T23:44:03.9527251' AS DateTime2), NULL, 0, NULL, 1, 2, 4)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (33, CAST(N'2020-07-10T23:44:03.9527267' AS DateTime2), NULL, 0, NULL, 1, 3, 4)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (34, CAST(N'2020-07-10T23:44:03.9527285' AS DateTime2), NULL, 0, NULL, 1, 4, 4)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (35, CAST(N'2020-07-10T23:44:03.9527304' AS DateTime2), NULL, 0, NULL, 1, 11, 4)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (36, CAST(N'2020-07-10T23:44:03.9527316' AS DateTime2), NULL, 0, NULL, 1, 6, 4)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (37, CAST(N'2020-07-10T23:44:03.9527528' AS DateTime2), NULL, 0, NULL, 1, 7, 4)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (38, CAST(N'2020-07-10T23:44:03.9527561' AS DateTime2), NULL, 0, NULL, 1, 8, 4)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (39, CAST(N'2020-07-10T23:44:03.9527573' AS DateTime2), NULL, 0, NULL, 1, 9, 4)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (40, CAST(N'2020-07-10T23:44:03.9527582' AS DateTime2), NULL, 0, NULL, 1, 10, 4)
INSERT [dbo].[Seats] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [Number], [AuditoriumId]) VALUES (51, CAST(N'2020-07-12T15:09:37.1166454' AS DateTime2), NULL, 1, CAST(N'2020-07-12T15:45:47.1301090' AS DateTime2), 0, 11, 1)
SET IDENTITY_INSERT [dbo].[Seats] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [FirstName], [LastName], [Email], [Username], [Password]) VALUES (1, CAST(N'2020-07-10T23:44:03.9439543' AS DateTime2), NULL, 0, NULL, 1, N'Admin', N'Admin', N'admin@gmail.com', N'adminAdmin', N'A12450CFF6FB7A97C975BFB7FCBB8F7E')
INSERT [dbo].[Users] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [FirstName], [LastName], [Email], [Username], [Password]) VALUES (3, CAST(N'2020-07-10T23:52:13.0895423' AS DateTime2), NULL, 0, NULL, 1, N'User', N'User', N'user@gmail.com', N'userUser', N'B4D1A9DE821CCF32107A1F3C846EC5E3')
INSERT [dbo].[Users] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [FirstName], [LastName], [Email], [Username], [Password]) VALUES (4, CAST(N'2020-07-10T23:53:25.1951505' AS DateTime2), NULL, 0, NULL, 1, N'User2', N'User2', N'user2@gmail.com', N'userUser2', N'7206FC1DB018E7F7489F411BDB9E7CA4')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[UserUseCases] ON 

INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (1, CAST(N'2020-07-10T23:44:03.9509819' AS DateTime2), NULL, 0, NULL, 1, 1, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (2, CAST(N'2020-07-10T23:44:03.9511910' AS DateTime2), NULL, 0, NULL, 1, 1, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (3, CAST(N'2020-07-10T23:44:03.9511982' AS DateTime2), NULL, 0, NULL, 1, 1, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (4, CAST(N'2020-07-10T23:44:03.9511999' AS DateTime2), NULL, 0, NULL, 1, 1, 4)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (5, CAST(N'2020-07-10T23:44:03.9512013' AS DateTime2), NULL, 0, NULL, 1, 1, 5)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (6, CAST(N'2020-07-10T23:44:03.9512156' AS DateTime2), NULL, 0, NULL, 1, 1, 6)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (7, CAST(N'2020-07-10T23:44:03.9512178' AS DateTime2), NULL, 0, NULL, 1, 1, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (8, CAST(N'2020-07-10T23:44:03.9512191' AS DateTime2), NULL, 0, NULL, 1, 1, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (9, CAST(N'2020-07-10T23:44:03.9512203' AS DateTime2), NULL, 0, NULL, 1, 1, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (10, CAST(N'2020-07-10T23:44:03.9512224' AS DateTime2), NULL, 0, NULL, 1, 1, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (11, CAST(N'2020-07-10T23:44:03.9512239' AS DateTime2), NULL, 0, NULL, 1, 1, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (12, CAST(N'2020-07-10T23:44:03.9512250' AS DateTime2), NULL, 0, NULL, 1, 1, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (13, CAST(N'2020-07-10T23:44:03.9512261' AS DateTime2), NULL, 0, NULL, 1, 1, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (14, CAST(N'2020-07-10T23:44:03.9512272' AS DateTime2), NULL, 0, NULL, 1, 1, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (15, CAST(N'2020-07-10T23:44:03.9512283' AS DateTime2), NULL, 0, NULL, 1, 1, 15)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (16, CAST(N'2020-07-10T23:44:03.9512296' AS DateTime2), NULL, 0, NULL, 1, 1, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (17, CAST(N'2020-07-10T23:44:03.9512307' AS DateTime2), NULL, 0, NULL, 1, 1, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (18, CAST(N'2020-07-10T23:44:03.9512326' AS DateTime2), NULL, 0, NULL, 1, 1, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (25, CAST(N'2020-07-10T23:52:13.1300118' AS DateTime2), NULL, 0, NULL, 1, 3, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (26, CAST(N'2020-07-10T23:52:13.1329426' AS DateTime2), NULL, 0, NULL, 1, 3, 6)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (27, CAST(N'2020-07-10T23:52:13.1330145' AS DateTime2), NULL, 0, NULL, 1, 3, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (28, CAST(N'2020-07-10T23:52:13.1330595' AS DateTime2), NULL, 0, NULL, 1, 3, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (29, CAST(N'2020-07-10T23:53:25.2071256' AS DateTime2), NULL, 0, NULL, 1, 4, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (30, CAST(N'2020-07-10T23:53:25.2072801' AS DateTime2), NULL, 0, NULL, 1, 4, 6)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (31, CAST(N'2020-07-10T23:53:25.2073489' AS DateTime2), NULL, 0, NULL, 1, 4, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (32, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 4, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (33, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 1, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (34, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 1, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (35, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 1, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (36, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 1, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (37, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 1, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (38, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 1, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (39, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 1, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (40, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 1, 26)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (41, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 1, 27)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (42, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 1, 28)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (43, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 1, 29)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (44, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 3, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (45, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 3, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (46, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 3, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (47, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 3, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (48, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 3, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (50, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 3, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (51, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 3, 26)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (52, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 4, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (53, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 4, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (54, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 4, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (55, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 4, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (56, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 4, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (57, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 4, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [UpdatedAt], [IsDeleted], [DeletedAt], [IsActive], [UserId], [UseCaseId]) VALUES (58, CAST(N'2020-07-10T23:53:25.2078330' AS DateTime2), NULL, 0, NULL, 1, 4, 26)
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
ON DELETE CASCADE
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
