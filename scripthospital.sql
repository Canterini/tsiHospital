USE [master]
GO
/****** Object:  Database [Hospital_Universitario]    Script Date: 30/10/2013 13:22:42 ******/
CREATE DATABASE [Hospital_Universitario]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hospital_Universitario', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Hospital_Universitario.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Hospital_Universitario_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Hospital_Universitario_log.ldf' , SIZE = 2560KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Hospital_Universitario] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hospital_Universitario].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hospital_Universitario] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hospital_Universitario] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hospital_Universitario] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hospital_Universitario] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hospital_Universitario] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hospital_Universitario] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hospital_Universitario] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Hospital_Universitario] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hospital_Universitario] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hospital_Universitario] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hospital_Universitario] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hospital_Universitario] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hospital_Universitario] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hospital_Universitario] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hospital_Universitario] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hospital_Universitario] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hospital_Universitario] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hospital_Universitario] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hospital_Universitario] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hospital_Universitario] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hospital_Universitario] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hospital_Universitario] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hospital_Universitario] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hospital_Universitario] SET RECOVERY FULL 
GO
ALTER DATABASE [Hospital_Universitario] SET  MULTI_USER 
GO
ALTER DATABASE [Hospital_Universitario] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hospital_Universitario] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hospital_Universitario] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hospital_Universitario] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Hospital_Universitario]
GO
/****** Object:  Table [dbo].[Camillas]    Script Date: 30/10/2013 13:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Camillas](
	[idCamilla] [int] IDENTITY(1,1) NOT NULL,
	[estadoCamilla] [int] NULL,
 CONSTRAINT [PK_Camillas_1] PRIMARY KEY CLUSTERED 
(
	[idCamilla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 30/10/2013 13:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departamentos](
	[idDepartamento] [int] IDENTITY(1,1) NOT NULL,
	[nombreDepartamento] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Departamentos_1] PRIMARY KEY CLUSTERED 
(
	[nombreDepartamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Diagnostico]    Script Date: 30/10/2013 13:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Diagnostico](
	[idDiagnostico] [int] NOT NULL,
	[Diagnostico] [varchar](max) NULL,
 CONSTRAINT [PK_Diagnostico] PRIMARY KEY CLUSTERED 
(
	[idDiagnostico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[formaPago]    Script Date: 30/10/2013 13:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[formaPago](
	[Rut] [char](10) NOT NULL,
	[medioPago] [varchar](50) NULL,
	[Cuotas] [int] NULL,
 CONSTRAINT [PK_formaPago] PRIMARY KEY CLUSTERED 
(
	[Rut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 30/10/2013 13:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Paciente](
	[Rut] [char](10) NOT NULL,
	[Nombres] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[Sexo] [varchar](50) NULL,
	[EstadoCivil] [varchar](50) NULL,
	[Edad] [int] NULL,
	[Dirección] [varchar](100) NULL,
	[Aseguradora] [varchar](50) NULL,
	[Nombredepto] [varchar](50) NULL,
	[idCamilla] [int] NULL,
	[fechaIngreso] [date] NULL,
	[fechaSalida] [date] NULL,
	[Contraindicaciones] [varchar](255) NULL,
	[idDiagnostico] [int] NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[Rut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pacientePersonal]    Script Date: 30/10/2013 13:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pacientePersonal](
	[idDiagnostico] [int] NOT NULL,
	[rutPersonal] [char](10) NOT NULL,
	[rutPaciente] [char](10) NOT NULL,
	[Diagnostico] [varchar](max) NULL,
	[Receta] [varchar](255) NULL,
 CONSTRAINT [PK_pacientePersonal] PRIMARY KEY CLUSTERED 
(
	[idDiagnostico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Personal]    Script Date: 30/10/2013 13:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Personal](
	[Rut] [char](10) NOT NULL,
	[Nombres] [varchar](50) NOT NULL,
	[Apellidos] [varchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[Sexo] [varchar](50) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Estado] [varchar](50) NOT NULL,
	[Cargo] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Correo] [varchar](50) NULL,
	[Contraseña] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Personal] PRIMARY KEY CLUSTERED 
(
	[Rut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[personalDepartamento]    Script Date: 30/10/2013 13:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[personalDepartamento](
	[Rut] [char](10) NOT NULL,
	[idDepartamento] [int] NULL,
	[nombreDepto] [varchar](50) NULL,
 CONSTRAINT [PK_personalDepartamento] PRIMARY KEY CLUSTERED 
(
	[Rut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[pacientePersonal]  WITH CHECK ADD  CONSTRAINT [FK_pacientePersonal_Diagnostico] FOREIGN KEY([idDiagnostico])
REFERENCES [dbo].[Diagnostico] ([idDiagnostico])
GO
ALTER TABLE [dbo].[pacientePersonal] CHECK CONSTRAINT [FK_pacientePersonal_Diagnostico]
GO
USE [master]
GO
ALTER DATABASE [Hospital_Universitario] SET  READ_WRITE 
GO
