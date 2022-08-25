USE [master]
GO
/****** Object:  Database [ContactBook]    Script Date: 24/08/2022 11:06:49 p. m. ******/
CREATE DATABASE [ContactBook]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ContactBook', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ContactBook.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ContactBook_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ContactBook_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ContactBook] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ContactBook].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ContactBook] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ContactBook] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ContactBook] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ContactBook] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ContactBook] SET ARITHABORT OFF 
GO
ALTER DATABASE [ContactBook] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ContactBook] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ContactBook] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ContactBook] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ContactBook] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ContactBook] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ContactBook] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ContactBook] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ContactBook] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ContactBook] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ContactBook] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ContactBook] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ContactBook] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ContactBook] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ContactBook] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ContactBook] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ContactBook] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ContactBook] SET RECOVERY FULL 
GO
ALTER DATABASE [ContactBook] SET  MULTI_USER 
GO
ALTER DATABASE [ContactBook] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ContactBook] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ContactBook] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ContactBook] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ContactBook] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ContactBook] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ContactBook', N'ON'
GO
ALTER DATABASE [ContactBook] SET QUERY_STORE = OFF
GO
USE [ContactBook]
GO
/****** Object:  Table [dbo].[contact]    Script Date: 24/08/2022 11:06:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contact](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [nvarchar](50) NOT NULL,
	[lastName] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](10) NULL,
	[address] [nvarchar](100) NULL,
 CONSTRAINT [PK_contact] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[contact] ON 
GO
INSERT [dbo].[contact] ([id], [firstName], [lastName], [phone], [address]) VALUES (1, N'Jaider Alejandro', N'Cortes', N'3144312132', N'Cra 3a este N° 10-73 sur')
GO
INSERT [dbo].[contact] ([id], [firstName], [lastName], [phone], [address]) VALUES (2, N'María Helena', N'Salazar', N'3143922761', N'Cra 1a este N° 12-70 sur')
GO
INSERT [dbo].[contact] ([id], [firstName], [lastName], [phone], [address]) VALUES (3, N'Janire Valentina', N'Suarez Salazar', N'3123102702', N'Cra 2a este N° 10-78 sur')
GO
INSERT [dbo].[contact] ([id], [firstName], [lastName], [phone], [address]) VALUES (4, N'Luis Alberto', N'Gonzalez Florez', N'3228347219', N'Cll 12 N° 17-32')
GO
INSERT [dbo].[contact] ([id], [firstName], [lastName], [phone], [address]) VALUES (1002, N'Jorge', N'Salazar', N'3127328439', N'Cll 12a N° 17-72')
GO
INSERT [dbo].[contact] ([id], [firstName], [lastName], [phone], [address]) VALUES (1003, N'Laura', N'Fernandez', N'3108347293', N'Cra 12 N° 12-27')
GO
INSERT [dbo].[contact] ([id], [firstName], [lastName], [phone], [address]) VALUES (1005, N'Segundo Jorge', N'Salazar', N'3203080420', N'Some place in Colombia')
GO
INSERT [dbo].[contact] ([id], [firstName], [lastName], [phone], [address]) VALUES (1006, N'Brian', N'Salazar', N'3133629273', N'Some place in Boyacá')
GO
INSERT [dbo].[contact] ([id], [firstName], [lastName], [phone], [address]) VALUES (1007, N'Cecilia', N'Jiménez', N'3113661894', N'Vereda Santa Bárbara')
GO
INSERT [dbo].[contact] ([id], [firstName], [lastName], [phone], [address]) VALUES (1008, N'Pedro', N'Infante', N'3206349261', N'Ciudad de Mexico, Mexico')
GO
INSERT [dbo].[contact] ([id], [firstName], [lastName], [phone], [address]) VALUES (1009, N'Vicente', N'Fernandez', N'3112084392', N'Guadalajara, México')
GO
INSERT [dbo].[contact] ([id], [firstName], [lastName], [phone], [address]) VALUES (1010, N'Nicolas', N'Schurman', N'3107239513', N'Algún lugar en Nueva Zelanda')
GO
INSERT [dbo].[contact] ([id], [firstName], [lastName], [phone], [address]) VALUES (1011, N'Benito', N'Martínez', N'3126349287', N'Algún lugar en Puerto Rico')
GO
SET IDENTITY_INSERT [dbo].[contact] OFF
GO
USE [master]
GO
ALTER DATABASE [ContactBook] SET  READ_WRITE 
GO
