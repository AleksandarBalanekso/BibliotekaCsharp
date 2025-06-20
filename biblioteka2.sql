USE [master]
GO
/****** Object:  Database [Biblioteka]    Script Date: 6/2/2024 11:43:46 PM ******/
CREATE DATABASE [Biblioteka]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Biblioteka', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Biblioteka.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Biblioteka_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Biblioteka_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Biblioteka] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Biblioteka].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Biblioteka] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Biblioteka] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Biblioteka] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Biblioteka] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Biblioteka] SET ARITHABORT OFF 
GO
ALTER DATABASE [Biblioteka] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Biblioteka] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Biblioteka] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Biblioteka] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Biblioteka] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Biblioteka] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Biblioteka] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Biblioteka] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Biblioteka] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Biblioteka] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Biblioteka] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Biblioteka] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Biblioteka] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Biblioteka] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Biblioteka] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Biblioteka] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Biblioteka] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Biblioteka] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Biblioteka] SET  MULTI_USER 
GO
ALTER DATABASE [Biblioteka] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Biblioteka] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Biblioteka] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Biblioteka] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Biblioteka] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Biblioteka] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Biblioteka] SET QUERY_STORE = ON
GO
ALTER DATABASE [Biblioteka] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Biblioteka]
GO
/****** Object:  Table [dbo].[clan]    Script Date: 6/2/2024 11:43:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clan](
	[jmbg_clana] [char](13) NOT NULL,
	[ime] [varchar](50) NOT NULL,
	[prezime] [varchar](50) NOT NULL,
	[email] [varchar](50) NULL,
	[datum_rodjenja] [date] NULL,
	[aktivan] [bit] NOT NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[priviledge] [bit] NULL,
 CONSTRAINT [clan_pk] PRIMARY KEY CLUSTERED 
(
	[jmbg_clana] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[iznajmio]    Script Date: 6/2/2024 11:43:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[iznajmio](
	[id_iznajmljivanja] [int] IDENTITY(1,1) NOT NULL,
	[jmbg_clana] [char](13) NOT NULL,
	[id_knjige] [int] NOT NULL,
	[datum_izdavanja] [date] NOT NULL,
	[datum_vracanja] [date] NOT NULL,
	[vracena] [bit] NOT NULL,
 CONSTRAINT [iznajmio_pk] PRIMARY KEY CLUSTERED 
(
	[id_iznajmljivanja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[knjiga]    Script Date: 6/2/2024 11:43:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[knjiga](
	[id_knjige] [int] IDENTITY(1,1) NOT NULL,
	[naziv_knjige] [varchar](100) NOT NULL,
	[kolicina_u_biblioteci] [int] NOT NULL,
	[jmbg_pisca] [char](13) NOT NULL,
	[godina_izdavanja] [int] NULL,
 CONSTRAINT [knjiga_pk] PRIMARY KEY CLUSTERED 
(
	[id_knjige] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pisac]    Script Date: 6/2/2024 11:43:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pisac](
	[jmbg_pisca] [char](13) NOT NULL,
	[ime] [varchar](50) NOT NULL,
	[prezime] [varchar](50) NOT NULL,
	[datum_rodjenja] [date] NULL,
 CONSTRAINT [pisac_pk] PRIMARY KEY CLUSTERED 
(
	[jmbg_pisca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[clan] ([jmbg_clana], [ime], [prezime], [email], [datum_rodjenja], [aktivan], [username], [password], [priviledge]) VALUES (N'0            ', N'Aleksandar', N'Balanesko', N'aleksandarbalanesko@gmail.com', CAST(N'2024-06-02' AS Date), 1, N'AleksandarBalanesko', N'admin', 1)
INSERT [dbo].[clan] ([jmbg_clana], [ime], [prezime], [email], [datum_rodjenja], [aktivan], [username], [password], [priviledge]) VALUES (N'1            ', N'Andrej', N'Tetkic', N'andrejtetkic@gmail.com', CAST(N'2024-06-02' AS Date), 1, N'AndrejTetkic', N'andrejtetkic', 0)
INSERT [dbo].[clan] ([jmbg_clana], [ime], [prezime], [email], [datum_rodjenja], [aktivan], [username], [password], [priviledge]) VALUES (N'2            ', N'Dimitrije', N'Sakan', N'mita@gmail.com', CAST(N'2024-06-02' AS Date), 1, N'DimitrijeSakan', N'mitapita007', 0)
INSERT [dbo].[clan] ([jmbg_clana], [ime], [prezime], [email], [datum_rodjenja], [aktivan], [username], [password], [priviledge]) VALUES (N'3            ', N'Bogdan', N'Lucic', N'bogdan@gmail.com', CAST(N'2024-06-02' AS Date), 1, N'BogdanLucic', N'password123', 0)
GO
SET IDENTITY_INSERT [dbo].[iznajmio] ON 

INSERT [dbo].[iznajmio] ([id_iznajmljivanja], [jmbg_clana], [id_knjige], [datum_izdavanja], [datum_vracanja], [vracena]) VALUES (25, N'3            ', 13, CAST(N'2024-06-02' AS Date), CAST(N'2024-06-02' AS Date), 1)
INSERT [dbo].[iznajmio] ([id_iznajmljivanja], [jmbg_clana], [id_knjige], [datum_izdavanja], [datum_vracanja], [vracena]) VALUES (26, N'3            ', 15, CAST(N'2024-06-02' AS Date), CAST(N'0001-01-01' AS Date), 0)
INSERT [dbo].[iznajmio] ([id_iznajmljivanja], [jmbg_clana], [id_knjige], [datum_izdavanja], [datum_vracanja], [vracena]) VALUES (27, N'3            ', 17, CAST(N'2024-06-02' AS Date), CAST(N'0001-01-01' AS Date), 0)
INSERT [dbo].[iznajmio] ([id_iznajmljivanja], [jmbg_clana], [id_knjige], [datum_izdavanja], [datum_vracanja], [vracena]) VALUES (28, N'2            ', 14, CAST(N'2024-06-02' AS Date), CAST(N'0001-01-01' AS Date), 0)
INSERT [dbo].[iznajmio] ([id_iznajmljivanja], [jmbg_clana], [id_knjige], [datum_izdavanja], [datum_vracanja], [vracena]) VALUES (29, N'2            ', 16, CAST(N'2024-06-02' AS Date), CAST(N'0001-01-01' AS Date), 0)
INSERT [dbo].[iznajmio] ([id_iznajmljivanja], [jmbg_clana], [id_knjige], [datum_izdavanja], [datum_vracanja], [vracena]) VALUES (30, N'3            ', 13, CAST(N'2024-06-02' AS Date), CAST(N'2024-06-02' AS Date), 1)
INSERT [dbo].[iznajmio] ([id_iznajmljivanja], [jmbg_clana], [id_knjige], [datum_izdavanja], [datum_vracanja], [vracena]) VALUES (31, N'3            ', 16, CAST(N'2024-06-02' AS Date), CAST(N'0001-01-01' AS Date), 0)
INSERT [dbo].[iznajmio] ([id_iznajmljivanja], [jmbg_clana], [id_knjige], [datum_izdavanja], [datum_vracanja], [vracena]) VALUES (32, N'3            ', 13, CAST(N'2024-06-02' AS Date), CAST(N'0001-01-01' AS Date), 0)
INSERT [dbo].[iznajmio] ([id_iznajmljivanja], [jmbg_clana], [id_knjige], [datum_izdavanja], [datum_vracanja], [vracena]) VALUES (33, N'1            ', 13, CAST(N'2024-06-02' AS Date), CAST(N'0001-01-01' AS Date), 0)
INSERT [dbo].[iznajmio] ([id_iznajmljivanja], [jmbg_clana], [id_knjige], [datum_izdavanja], [datum_vracanja], [vracena]) VALUES (34, N'1            ', 16, CAST(N'2024-06-02' AS Date), CAST(N'0001-01-01' AS Date), 0)
SET IDENTITY_INSERT [dbo].[iznajmio] OFF
GO
SET IDENTITY_INSERT [dbo].[knjiga] ON 

INSERT [dbo].[knjiga] ([id_knjige], [naziv_knjige], [kolicina_u_biblioteci], [jmbg_pisca], [godina_izdavanja]) VALUES (13, N'Gorski Vjenac', 196, N'0            ', 1847)
INSERT [dbo].[knjiga] ([id_knjige], [naziv_knjige], [kolicina_u_biblioteci], [jmbg_pisca], [godina_izdavanja]) VALUES (14, N'Lazni Car Scepan Mali', 49, N'0            ', 2024)
INSERT [dbo].[knjiga] ([id_knjige], [naziv_knjige], [kolicina_u_biblioteci], [jmbg_pisca], [godina_izdavanja]) VALUES (15, N'Hajduci', 99, N'3            ', 1895)
INSERT [dbo].[knjiga] ([id_knjige], [naziv_knjige], [kolicina_u_biblioteci], [jmbg_pisca], [godina_izdavanja]) VALUES (16, N'Pesme', 97, N'2            ', 1847)
INSERT [dbo].[knjiga] ([id_knjige], [naziv_knjige], [kolicina_u_biblioteci], [jmbg_pisca], [godina_izdavanja]) VALUES (17, N'Zeleni Vitez', 99, N'4            ', 2024)
SET IDENTITY_INSERT [dbo].[knjiga] OFF
GO
INSERT [dbo].[pisac] ([jmbg_pisca], [ime], [prezime], [datum_rodjenja]) VALUES (N'0            ', N'Petar', N'Petrovic Njegos', CAST(N'1800-06-11' AS Date))
INSERT [dbo].[pisac] ([jmbg_pisca], [ime], [prezime], [datum_rodjenja]) VALUES (N'2            ', N'Branko', N'Radicevic', CAST(N'2024-06-02' AS Date))
INSERT [dbo].[pisac] ([jmbg_pisca], [ime], [prezime], [datum_rodjenja]) VALUES (N'3            ', N'Branislav', N'Nusic', CAST(N'2024-06-02' AS Date))
INSERT [dbo].[pisac] ([jmbg_pisca], [ime], [prezime], [datum_rodjenja]) VALUES (N'4            ', N'Desanka', N'Maksimovic', CAST(N'2024-06-02' AS Date))
GO
ALTER TABLE [dbo].[iznajmio]  WITH CHECK ADD  CONSTRAINT [iznajmio_clan_fk] FOREIGN KEY([jmbg_clana])
REFERENCES [dbo].[clan] ([jmbg_clana])
GO
ALTER TABLE [dbo].[iznajmio] CHECK CONSTRAINT [iznajmio_clan_fk]
GO
ALTER TABLE [dbo].[iznajmio]  WITH CHECK ADD  CONSTRAINT [iznajmio_knjiga_fk] FOREIGN KEY([id_knjige])
REFERENCES [dbo].[knjiga] ([id_knjige])
GO
ALTER TABLE [dbo].[iznajmio] CHECK CONSTRAINT [iznajmio_knjiga_fk]
GO
ALTER TABLE [dbo].[knjiga]  WITH CHECK ADD  CONSTRAINT [napisao_knjigu_fk] FOREIGN KEY([jmbg_pisca])
REFERENCES [dbo].[pisac] ([jmbg_pisca])
GO
ALTER TABLE [dbo].[knjiga] CHECK CONSTRAINT [napisao_knjigu_fk]
GO
USE [master]
GO
ALTER DATABASE [Biblioteka] SET  READ_WRITE 
GO
