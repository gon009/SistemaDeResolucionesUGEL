USE [master]
GO
/****** Object:  Database [DBResoluciones]    Script Date: 25/07/2016 9:04:49 p. m. ******/
CREATE DATABASE [DBResoluciones]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBResoluciones', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DBResoluciones.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBResoluciones_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DBResoluciones_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBResoluciones] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBResoluciones].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBResoluciones] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBResoluciones] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBResoluciones] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBResoluciones] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBResoluciones] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBResoluciones] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBResoluciones] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBResoluciones] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBResoluciones] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBResoluciones] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBResoluciones] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBResoluciones] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBResoluciones] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBResoluciones] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBResoluciones] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBResoluciones] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBResoluciones] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBResoluciones] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBResoluciones] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBResoluciones] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBResoluciones] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBResoluciones] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBResoluciones] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBResoluciones] SET  MULTI_USER 
GO
ALTER DATABASE [DBResoluciones] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBResoluciones] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBResoluciones] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBResoluciones] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DBResoluciones] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBResoluciones', N'ON'
GO
USE [DBResoluciones]
GO
/****** Object:  Table [dbo].[TBL_Concepto]    Script Date: 25/07/2016 9:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Concepto](
	[IN_Concepto] [int] NOT NULL,
	[DA_Concepto] [nvarchar](max) NULL,
 CONSTRAINT [PK_TBL_Concepto] PRIMARY KEY CLUSTERED 
(
	[IN_Concepto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TBL_Docente]    Script Date: 25/07/2016 9:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Docente](
	[IN_DNI] [char](8) NOT NULL,
	[DA_Nombres] [nvarchar](max) NULL,
	[DA_ApellidoPaterno] [nvarchar](max) NULL,
	[DA_ApellidoMaterno] [nvarchar](max) NULL,
 CONSTRAINT [PK_TBL_Docente] PRIMARY KEY CLUSTERED 
(
	[IN_DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Institucion_Educativa]    Script Date: 25/07/2016 9:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Institucion_Educativa](
	[IN_InstitucionEducativa] [int] IDENTITY(1,1) NOT NULL,
	[DA_InstitucionEducativa] [varchar](100) NULL,
	[DA_Direccion] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IN_InstitucionEducativa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Resolucion]    Script Date: 25/07/2016 9:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Resolucion](
	[IN_NroResolucion] [char](10) NOT NULL,
	[IN_NroProyecto] [char](10) NULL,
	[IN_Tipo_Resolucion] [int] NULL,
	[IN_UGEL] [int] NULL,
	[IN_InstitucionEducativa] [int] NULL,
	[IN_DNI] [char](8) NULL,
	[IN_Situacion] [int] NULL,
	[IN_Concepto] [int] NULL,
	[DA_ExpedienteJudicial] [char](10) NULL,
	[DA_Sentencia] [nvarchar](max) NULL,
	[DA_FechaSentencia] [date] NULL,
	[DA_Monto] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[IN_NroResolucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Situacion]    Script Date: 25/07/2016 9:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Situacion](
	[IN_Situacion] [int] NOT NULL,
	[DA_Situacion] [nvarchar](50) NULL,
 CONSTRAINT [PK_TBL_Situacion] PRIMARY KEY CLUSTERED 
(
	[IN_Situacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TBL_Tipo_Resolucion]    Script Date: 25/07/2016 9:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Tipo_Resolucion](
	[IN_TipoResolucion] [int] NOT NULL,
	[DA_TipoResolucion] [nvarchar](50) NULL,
 CONSTRAINT [PK_TBL_Tipo_Resolucion] PRIMARY KEY CLUSTERED 
(
	[IN_TipoResolucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TBL_UGEL]    Script Date: 25/07/2016 9:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_UGEL](
	[IN_UGEL] [int] NOT NULL,
	[DA_UGEL] [nvarchar](50) NULL,
 CONSTRAINT [PK_TBL_UGEL] PRIMARY KEY CLUSTERED 
(
	[IN_UGEL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (1, N'Adeudo Bonificacion Familiar')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (2, N'Adeudo Bonificacion Preparacion de Clases')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (3, N'Adeudo DU 037')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (4, N'Adeudo Maestria')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (5, N'Ascenso')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (6, N'Asignación por Tiempo de Servicio')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (7, N'Bonificacion Familiar')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (8, N'Bonificacion Personal')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (9, N'Bono de Desepeño Escolar ECE')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (10, N'Bonos de Atracción')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (11, N'Cese')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (12, N'Compensatoria por Tiempo de Servicio')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (13, N'Contrato')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (14, N'Maestria')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (15, N'Nombramiento')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (16, N'Permuta')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (17, N'Reajuste de Bonificacion Personal')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (18, N'Reasignación')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (19, N'Reubicación')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (20, N'Rotación')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (21, N'Sepelio y Luto')
INSERT [dbo].[TBL_Concepto] ([IN_Concepto], [DA_Concepto]) VALUES (22, N'Vacaciones Truncas')
INSERT [dbo].[TBL_Docente] ([IN_DNI], [DA_Nombres], [DA_ApellidoPaterno], [DA_ApellidoMaterno]) VALUES (N'30303030', N'Felipe Alfonso', N'Garcia', N'Valdivia')
INSERT [dbo].[TBL_Docente] ([IN_DNI], [DA_Nombres], [DA_ApellidoPaterno], [DA_ApellidoMaterno]) VALUES (N'65656565', N'Ferni Ferno', N'Garcho', N'Del Carpio')
INSERT [dbo].[TBL_Docente] ([IN_DNI], [DA_Nombres], [DA_ApellidoPaterno], [DA_ApellidoMaterno]) VALUES (N'71616531', N'Eduardo Alonso', N'Garcia', N'Martinez')
SET IDENTITY_INSERT [dbo].[TBL_Institucion_Educativa] ON 

INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (1, N'40001', N'Arequipa')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (2, N'40020', N'Arequipa')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (3, N'40099', N'Sachaca')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (4, N'40106', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (5, N'40616', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (6, N'40616', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (7, N'41024', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (8, N'12 de Octubre ', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (9, N'40002 AL Aire Libre', N'Arequipa')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (10, N'40007 Gilberto Ochoa', N'Arequipa')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (11, N'40025 Santa Dorotea', N'Arequipa')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (12, N'40035 Víctor Andrés Belaunde', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (13, N'40039 Santa María', N'Yanahuara')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (14, N'40040 José Trinidad Morán', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (15, N'40040 José Trinidad Morán', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (16, N'40042 República de Francia', N'Arequipa')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (17, N'40045 Livia Bernal de Baltazar', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (18, N'40046 José Cornejo Acosta', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (19, N'40046 José Cornejo Acosta', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (20, N'40048 Antonio José de Sucre', N'Yanahuara')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (21, N'40049 Francisco Bolognesi', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (22, N'40049 Francisco Bolognesi', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (23, N'40052 El Peruano del Milenio', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (24, N'40052 El Peruano del Milenio', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (25, N'40053 Manuel Tapia Fuentes', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (26, N'40055 Romeo Luna Victoria', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (27, N'40056 Horacio Zeballos Gamez', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (28, N'40056 Horacio Zeballos Gamez', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (29, N'40058 Ignacio Álvarez Thomas', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (30, N'40061 Estado de Suecia', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (31, N'40078 Sagrado Corazón', N'Sachaca')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (32, N'40081 Mazeyra Acosta', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (33, N'40092 José Domingo Zuzunaga', N'Uchumayo')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (34, N'40103 Libertadores de América', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (35, N'40141 Virgen de Guadalupe', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (36, N'40173 Divino Niño Jesús', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (37, N'40202 Charlotte', N'Yura')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (38, N'40669 Deán Valdivia', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (39, N'40670 El Edén Fe y Alegría', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (40, N'40672 DoreanWillians', N'Sachaca')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (41, N'40677 San Miguel Febres Cordero', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (42, N'40694 Centro de Innovación Pedagógico ISPA', N'Yura')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (43, N'40705 Peruarbo', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (44, N'41003 Almirante Miguel Grau', N'Arequipa')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (45, N'41005 Héroes de Angamos ', N'Arequipa')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (46, N'41014 Fortunata Gutiérrez', N'Arequipa')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (47, N'41019 República de Venezuela', N'Arequipa')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (48, N'41025 Doscientas Millas Peruanas', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (49, N'41026 María Murillo de Bernal', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (50, N'Arequipa', N'Arequipa')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (51, N'Casa de Caridad Artes y Oficios', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (52, N'Ciudad de Dios', N'Yura')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (53, N'Cristo Morado', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (54, N'Cristo Rey', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (55, N'Gran Pachacutec', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (56, N'Honorio Delgado Espinoza', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (57, N'Inicial Honorio Delgado Espinoza', N'Arequipa')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (58, N'Jose Canzina', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (59, N'José Caruana', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (60, N'La Recoleta', N'Arequipa')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (61, N'León XIII', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (62, N'León XIII – CIRCA', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (63, N'Mayta Capac', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (64, N'Micaela Bastidas', N'Arequipa')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (65, N'Newton (IEP) Gestion Privada', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (66, N'Nuestra Señora de la Asunción', N'Paucarpata')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (67, N'Nuestra Señora de los Dolores', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (68, N'San Bernardo', N'Yura')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (69, N'San Juan Apóstol', N'Cayma')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (70, N'San Juan Apóstol', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (71, N'San Pio X', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (72, N'Santo Tomás de Aquino', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (73, N'Santo Tomás de Aquino', N'Cerro Colorado')
INSERT [dbo].[TBL_Institucion_Educativa] ([IN_InstitucionEducativa], [DA_InstitucionEducativa], [DA_Direccion]) VALUES (74, N'Señor de los Milagros', N'Yura')
SET IDENTITY_INSERT [dbo].[TBL_Institucion_Educativa] OFF
INSERT [dbo].[TBL_Resolucion] ([IN_NroResolucion], [IN_NroProyecto], [IN_Tipo_Resolucion], [IN_UGEL], [IN_InstitucionEducativa], [IN_DNI], [IN_Situacion], [IN_Concepto], [DA_ExpedienteJudicial], [DA_Sentencia], [DA_FechaSentencia], [DA_Monto]) VALUES (N'1         ', N'1         ', 1, 1, 35, N'30303030', 1, 2, N'3         ', N'Sentencia', CAST(N'2016-07-25' AS Date), CAST(41545.22 AS Decimal(10, 2)))
INSERT [dbo].[TBL_Resolucion] ([IN_NroResolucion], [IN_NroProyecto], [IN_Tipo_Resolucion], [IN_UGEL], [IN_InstitucionEducativa], [IN_DNI], [IN_Situacion], [IN_Concepto], [DA_ExpedienteJudicial], [DA_Sentencia], [DA_FechaSentencia], [DA_Monto]) VALUES (N'2         ', N'1         ', 2, 3, 1, N'30303030', 1, 7, N'1234      ', N'123', CAST(N'2016-07-25' AS Date), CAST(23422.22 AS Decimal(10, 2)))
INSERT [dbo].[TBL_Resolucion] ([IN_NroResolucion], [IN_NroProyecto], [IN_Tipo_Resolucion], [IN_UGEL], [IN_InstitucionEducativa], [IN_DNI], [IN_Situacion], [IN_Concepto], [DA_ExpedienteJudicial], [DA_Sentencia], [DA_FechaSentencia], [DA_Monto]) VALUES (N'3         ', N'1         ', 1, 1, 2, N'30303030', 1, 12, N'12        ', N'Sentencia 1', CAST(N'2016-07-25' AS Date), CAST(323.22 AS Decimal(10, 2)))
INSERT [dbo].[TBL_Situacion] ([IN_Situacion], [DA_Situacion]) VALUES (1, N'Activo')
INSERT [dbo].[TBL_Situacion] ([IN_Situacion], [DA_Situacion]) VALUES (2, N'Cesante')
INSERT [dbo].[TBL_Tipo_Resolucion] ([IN_TipoResolucion], [DA_TipoResolucion]) VALUES (1, N'Administrativa')
INSERT [dbo].[TBL_Tipo_Resolucion] ([IN_TipoResolucion], [DA_TipoResolucion]) VALUES (2, N'Judicial')
INSERT [dbo].[TBL_UGEL] ([IN_UGEL], [DA_UGEL]) VALUES (1, N'Arequipa Norte')
INSERT [dbo].[TBL_UGEL] ([IN_UGEL], [DA_UGEL]) VALUES (2, N'La Joya')
INSERT [dbo].[TBL_UGEL] ([IN_UGEL], [DA_UGEL]) VALUES (3, N'Caylloma')
USE [master]
GO
ALTER DATABASE [DBResoluciones] SET  READ_WRITE 
GO
