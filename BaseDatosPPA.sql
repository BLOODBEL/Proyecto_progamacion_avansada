USE [master]
GO
/****** Object:  Database [ProyectoPA]    Script Date: 14/11/2023 02:22:08 p. m. ******/
CREATE DATABASE [ProyectoPA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProyectoPA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\ProyectoPA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProyectoPA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\ProyectoPA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ProyectoPA] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProyectoPA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProyectoPA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProyectoPA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProyectoPA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProyectoPA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProyectoPA] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProyectoPA] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ProyectoPA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProyectoPA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProyectoPA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProyectoPA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProyectoPA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProyectoPA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProyectoPA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProyectoPA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProyectoPA] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ProyectoPA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProyectoPA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProyectoPA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProyectoPA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProyectoPA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProyectoPA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProyectoPA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProyectoPA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProyectoPA] SET  MULTI_USER 
GO
ALTER DATABASE [ProyectoPA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProyectoPA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProyectoPA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProyectoPA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProyectoPA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProyectoPA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ProyectoPA] SET QUERY_STORE = ON
GO
ALTER DATABASE [ProyectoPA] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ProyectoPA]
GO
/****** Object:  Table [dbo].[Clase]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clase](
	[IdClase] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Descripcion] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdClase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClaseEntrenador]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClaseEntrenador](
	[IdClaseEntrenador] [bigint] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [bigint] NOT NULL,
	[IdClase] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdClaseEntrenador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Direccion]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direccion](
	[IdDireccion] [bigint] IDENTITY(1,1) NOT NULL,
	[Calle] [varchar](255) NOT NULL,
	[CodPostal] [varchar](10) NOT NULL,
	[OtraSena] [varchar](30) NOT NULL,
	[IdUsuario] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDireccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estadisticas]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estadisticas](
	[IdEstadisticas] [bigint] IDENTITY(1,1) NOT NULL,
	[Altura] [decimal](5, 2) NOT NULL,
	[Peso] [decimal](5, 2) NOT NULL,
	[Fecha] [date] NOT NULL,
	[IdUsuario] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEstadisticas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[IdFactura] [bigint] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Total] [decimal](10, 2) NOT NULL,
	[Precio] [decimal](10, 2) NOT NULL,
	[IdSuscripcion] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InscritoEn]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InscritoEn](
	[IdInscritoEn] [bigint] IDENTITY(1,1) NOT NULL,
	[IdClase] [bigint] NOT NULL,
	[IdUsuario] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdInscritoEn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[IdRol] [bigint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salario]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salario](
	[idSalario] [bigint] IDENTITY(1,1) NOT NULL,
	[salario] [decimal](18, 4) NOT NULL,
	[descripcion] [varchar](250) NOT NULL,
	[IdUsuario] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idSalario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suscripcion]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suscripcion](
	[IdSuscripcion] [bigint] IDENTITY(1,1) NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFin] [date] NOT NULL,
	[Precio] [decimal](10, 2) NOT NULL,
	[IdUsuario] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSuscripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [bigint] IDENTITY(1,1) NOT NULL,
	[Identificacion] [varchar](25) NOT NULL,
	[Nombre] [varchar](250) NOT NULL,
	[Apellidos1] [varchar](250) NOT NULL,
	[Apellidos2] [varchar](250) NOT NULL,
	[CorreoElectronico] [varchar](100) NOT NULL,
	[Contrasenna] [varchar](25) NOT NULL,
	[Telefono] [varchar](25) NOT NULL,
	[Estado] [bit] NOT NULL,
	[IdRol] [bigint] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_Identificacion] UNIQUE NONCLUSTERED 
(
	[Identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ClaseEntrenador]  WITH CHECK ADD FOREIGN KEY([IdClase])
REFERENCES [dbo].[Clase] ([IdClase])
GO
ALTER TABLE [dbo].[ClaseEntrenador]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Direccion]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Estadisticas]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD FOREIGN KEY([IdSuscripcion])
REFERENCES [dbo].[Suscripcion] ([IdSuscripcion])
GO
ALTER TABLE [dbo].[InscritoEn]  WITH CHECK ADD FOREIGN KEY([IdClase])
REFERENCES [dbo].[Clase] ([IdClase])
GO
ALTER TABLE [dbo].[InscritoEn]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Salario]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Suscripcion]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Rol] ([IdRol])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Rol]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarClase]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarClase]
    @Nombre varchar(30),
	@Descripcion varchar(30),
	@IdClase	BIGINT
AS
BEGIN
	
	UPDATE	dbo.Clase

	SET     Nombre = @Nombre,	
	        Descripcion = @Descripcion
			
	WHERE	IdClase = @IdClase

END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarCuenta]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarCuenta]
	@Identificacion varchar(25),
    @Nombre         varchar(250),
    @Apellidos1 varchar(250),
	@Apellidos2 varchar(250), 
	@CorreoElectronico varchar(100), 
	@Telefono varchar(25),
	@IdUsuario		BIGINT
AS
BEGIN
	
	UPDATE	dbo.Usuario
	SET		Identificacion = @Identificacion,
			Nombre = @Nombre,
			Apellidos1 = @Apellidos1,
			Apellidos2 = @Apellidos2,
	        Telefono = @Telefono,
		    CorreoElectronico = @CorreoElectronico
			
	WHERE	IdUsuario = @IdUsuario

END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarDireccion]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ActualizarDireccion]
	 @Calle varchar(255),
	 @CodPostal varchar(10),
	 @OtraSena varchar(30),
	@IdUsuario BIGINT,
	@IdDireccion BIGINT
AS
BEGIN
	IF EXISTS (SELECT * FROM dbo.Direccion WHERE IdDireccion = @IdDireccion)
	BEGIN
		UPDATE dbo.Direccion
		SET Calle = @Calle,
			CodPostal = @CodPostal,
			OtraSena = @OtraSena,
			IdUsuario = @IdUsuario
		WHERE IdDireccion = @IdDireccion
	END
END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarEstadistica]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarEstadistica]
	@Altura decimal(5,2),
	@Peso decimal(5,2),
	@Fecha date,
	@IdUsuario BIGINT,
	@IdEstadisticas BIGINT
AS
BEGIN
	IF EXISTS (SELECT * FROM dbo.Estadisticas WHERE IdEstadisticas = @IdEstadisticas)
	BEGIN
		UPDATE dbo.Estadisticas
		SET Altura = @Altura,
			Peso = @Peso,
			Fecha = @Fecha,
			IdUsuario = @IdUsuario
		WHERE IdEstadisticas = @IdEstadisticas
	END
END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarEstadoUsuario]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ActualizarEstadoUsuario]
	@IdUsuario BIGINT
AS
BEGIN

	UPDATE	Usuario
	SET		Estado = (CASE WHEN Estado = 1 THEN 0 ELSE 1 END)
	WHERE	IdUsuario = @IdUsuario

END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarRol]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarRol]
	@Descripcion varchar(30),
	@IdRol		BIGINT
AS
BEGIN
	
	UPDATE	dbo.Rol
	SET		Descripcion = @Descripcion
			
	WHERE	IdRol = @IdRol

END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarSalario]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarSalario]
	   @idSalario BIGINT,
    @Salario DECIMAL(18, 4),
    @Descripcion VARCHAR(250)
AS
BEGIN
  IF EXISTS (SELECT * FROM dbo.Salario WHERE idSalario = @idSalario)
    BEGIN
		  UPDATE dbo.salario
        SET salario = @salario,
            descripcion = @descripcion
        WHERE idSalario = @idSalario
	END
END
GO
/****** Object:  StoredProcedure [dbo].[IniciarSesion]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[IniciarSesion]
	@CorreoElectronico varchar(100),
    @Contrasenna varchar(25)
AS
BEGIN
	
	SELECT IdUsuario,
		   Identificacion,
		   Nombre,
		   Apellidos1,
	       Apellidos2, 
		   CorreoElectronico,
		   Contrasenna,
		   Estado,
		   R.Descripcion 'DescripcionRol'
	  FROM dbo.Usuario	  U
	  INNER JOIN dbo.Rol R ON U.IdRol = R.IdRol

	  WHERE CorreoElectronico = @CorreoElectronico
	  AND   Contrasenna = @Contrasenna
	  AND	Estado = 1

END
GO
/****** Object:  StoredProcedure [dbo].[RegistrarClase]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarClase]
    @Nombre varchar(30),
	@Descripcion varchar(30)
	
    
AS
BEGIN

	INSERT INTO dbo.Clase(Nombre,Descripcion)
    VALUES (@Nombre,@Descripcion)

END
GO
/****** Object:  StoredProcedure [dbo].[RegistrarCuenta]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarCuenta]
	@Identificacion varchar(25),
    @Nombre         varchar(250),
   @Apellidos1 varchar(250),
	@Apellidos2 varchar(250), 
	@CorreoElectronico varchar(100), 
	@Contrasenna varchar(25),
	@Telefono varchar(25) 
AS
BEGIN

	INSERT INTO dbo.Usuario (Identificacion,Nombre,Apellidos1,Apellidos2,CorreoElectronico,Contrasenna,Telefono,Estado,IdRol)
    VALUES (@Identificacion,@Nombre,@Apellidos1,@Apellidos2,@CorreoElectronico,@Contrasenna,@Telefono,1,2)

END
GO
/****** Object:  StoredProcedure [dbo].[RegistrarDireccion]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[RegistrarDireccion]
	 @Calle varchar(255),
	 @CodPostal varchar(10),
	 @OtraSena varchar(30),
	 @IdUsuario BIGINT
AS
BEGIN

	INSERT INTO dbo.Direccion(Calle, CodPostal, OtraSena, IdUsuario)
    VALUES (@Calle, @CodPostal, @OtraSena, @IdUsuario)

END
GO
/****** Object:  StoredProcedure [dbo].[RegistrarEstadistica]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarEstadistica]
	@Altura		decimal(5,2),
    @Peso       decimal(5,2),
    @Fecha		date,
	@IdUsuario BIGINT
AS
BEGIN

	INSERT INTO dbo.Estadisticas (Altura, Peso, Fecha, IdUsuario)
    VALUES (@Altura, @Peso, @Fecha, @IdUsuario)

END
GO
/****** Object:  StoredProcedure [dbo].[RegistrarRol]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarRol]
	@Descripcion varchar(30)
    
AS
BEGIN

	INSERT INTO dbo.Rol(Descripcion)
    VALUES (@Descripcion)

END
GO
/****** Object:  StoredProcedure [dbo].[RegistrarSalario]    Script Date: 14/11/2023 02:22:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarSalario]

    @descripcion        varchar(250),
	@Salario decimal(18,4) ,
	@IdUsuario Bigint
AS
BEGIN

	INSERT INTO dbo.Salario ( descripcion, Salario,IdUsuario )
    VALUES (@Salario,@descripcion,@IdUsuario)

END
GO
USE [master]
GO
ALTER DATABASE [ProyectoPA] SET  READ_WRITE 
GO
