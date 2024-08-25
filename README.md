# Trabajo Final Curso C# Nivel 2 [.Net + SQL]


La finalidad de este proyecto es aplicar y demostrar todos los conocimientos adquiridos en el curso para obtener la certificacion del mismo.

El objetivo de la aplicacion es gestionar articulos genericos de una empresa de manera intuitiva, sencilla y rapida.

Se utilizo Windows Form App .NET Framework y MySQL.

El codigo esta basado en el paradigma de programacion orientada a objetos, usando buenas practicas, siendo prolijo, eficiente y tratando de no saturar de peticiones inecesaria a la DB. Tambien esta pensado para ser un proyecto facilmente escalable en el tiempo.

Contiene las validaciones necesarias para que la aplicacion no se rompa y el usuario no envie accidentalmente un registro incorrecto a la DB.

Para el uso correcto de la apliacion, ademas de la instalacion del proyecto y de la creacion de la DB, se debe crear una carpeta llamada "Imagenes_TPFinalNivel2_GabrielMartinez" en la direccion "C:", aqui se guardaran las imagenes locales.

A continuacion el SCRIPT para la generación de la DB:

use master
go
create database DISCOS_DB
go
USE DISCOS_DB
GO
/****** Object:  Table [dbo].[ESTILOS]    Script Date: 10/14/2021 12:55:21 AM ******/
CREATE TABLE [dbo].[ESTILOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_ESTILOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
)
GO
/****** Object:  Table [dbo].[TIPOSEDICION]    Script Date: 10/14/2021 12:55:32 AM ******/
CREATE TABLE [dbo].[TIPOSEDICION](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_TIPOSEDICION] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
)
GO
/****** Object:  Table [dbo].[DISCOS]    Script Date: 10/14/2021 12:55:42 AM ******/
CREATE TABLE [dbo].[DISCOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](100) NULL,
	[FechaLanzamiento] [smalldatetime] NULL,
	[CantidadCanciones] [int] NULL,
	[UrlImagenTapa] [varchar](200) NULL,
	[IdEstilo] [int] NULL,
	[IdTipoEdicion] [int] NULL,
 CONSTRAINT [PK_DISCOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
)
GO

insert into estilos values ('Pop Punk')
insert into estilos values ('Pop')
insert into estilos values ('Rock')
insert into estilos values ('Grunge')
insert into TIPOSEDICION values ('Vinilo')
insert into TIPOSEDICION values ('CD')
insert into TIPOSEDICION values ('Tape')
insert into DISCOS values ('Pablo Honey', '01-01-1992', 12, 'https://cdns-images.dzcdn.net/images/cover/f08424290260e58c6d76275253b316fd/264x264.jpg', 2, 1)
insert into DISCOS values ('Siempre es hoy', '01-01-2002', 17, 'https://www.cmtv.com.ar/tapas-cd/ceratisiempre.jpg', 3, 3)
