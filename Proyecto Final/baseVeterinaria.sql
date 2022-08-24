USE [master]
GO
/****** Object:  Database [veterinariaBD]    Script Date: 20/08/2022 16:37:52 ******/
CREATE DATABASE [veterinariaBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'veterinariaBD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\veterinariaBD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'veterinariaBD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\veterinariaBD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [veterinariaBD] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [veterinariaBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [veterinariaBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [veterinariaBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [veterinariaBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [veterinariaBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [veterinariaBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [veterinariaBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [veterinariaBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [veterinariaBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [veterinariaBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [veterinariaBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [veterinariaBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [veterinariaBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [veterinariaBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [veterinariaBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [veterinariaBD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [veterinariaBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [veterinariaBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [veterinariaBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [veterinariaBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [veterinariaBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [veterinariaBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [veterinariaBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [veterinariaBD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [veterinariaBD] SET  MULTI_USER 
GO
ALTER DATABASE [veterinariaBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [veterinariaBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [veterinariaBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [veterinariaBD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [veterinariaBD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [veterinariaBD] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [veterinariaBD] SET QUERY_STORE = OFF
GO
USE [veterinariaBD]
GO
/****** Object:  Table [dbo].[Citas]    Script Date: 20/08/2022 16:37:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas](
	[NumeroCita] [int] IDENTITY(1,1) NOT NULL,
	[IDCliente] [int] NULL,
	[IDMascota] [int] NULL,
	[FechaCita] [date] NULL,
 CONSTRAINT [PK_Citas] PRIMARY KEY CLUSTERED 
(
	[NumeroCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 20/08/2022 16:37:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[IDCliente] [int] NOT NULL,
	[Nombre] [varchar](12) NULL,
	[PrimerApellido] [varchar](12) NULL,
	[SegundoApellido] [varchar](12) NULL,
	[Telefono] [numeric](18, 0) NULL,
	[CorreoElectronico] [varchar](50) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IDCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diagnósticos]    Script Date: 20/08/2022 16:37:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnósticos](
	[IDDiagnostico] [int] NOT NULL,
	[DescripcionDiagnostico] [varchar](100) NULL,
	[NumeroCita] [int] NULL,
 CONSTRAINT [PK_Diagnósticos] PRIMARY KEY CLUSTERED 
(
	[IDDiagnostico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturacion]    Script Date: 20/08/2022 16:37:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturacion](
	[NumeroFactura] [int] NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[NumeroCita] [int] NULL,
	[NombreCliente] [varchar](12) NULL,
	[NombreMascota] [varchar](12) NULL,
	[FechaCita] [date] NULL,
 CONSTRAINT [PK_Facturacion] PRIMARY KEY CLUSTERED 
(
	[NumeroFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 20/08/2022 16:37:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[NombreUsuario] [varchar](12) NULL,
	[Contraseña] [varchar](18) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mascotas]    Script Date: 20/08/2022 16:37:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mascotas](
	[IDMascota] [int] NOT NULL,
	[Nombre] [varchar](12) NULL,
	[IdCliente] [int] NULL,
 CONSTRAINT [PK_Mascotas] PRIMARY KEY CLUSTERED 
(
	[IDMascota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicios]    Script Date: 20/08/2022 16:37:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicios](
	[IDServicio] [int] NULL,
	[IDCliente] [int] NULL,
	[NombreCliente] [varchar](12) NULL,
	[NombreMascota] [varchar](12) NULL,
	[Descripcion] [varchar](100) NULL,
	[NumeroCita] [int] NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [veterinariaBD] SET  READ_WRITE 
GO
