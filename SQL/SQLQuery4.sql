USE [CAPITAL2]
GO
/****** Object:  User [devop]    Script Date: 24/2/2020 19:35:05 ******/
CREATE USER [devop] FOR LOGIN [devop] WITH DEFAULT_SCHEMA=[devop]
GO
/****** Object:  Schema [devop]    Script Date: 24/2/2020 19:35:05 ******/
CREATE SCHEMA [devop]
GO
/****** Object:  StoredProcedure [dbo].[BAJAVENTA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BAJAVENTA] @IDVEN INT
AS
	UPDATE VENTA SET ESTADO='0' WHERE IDVENTA=@IDVEN
GO
/****** Object:  StoredProcedure [dbo].[CERRARCAJA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CERRARCAJA] @IDUSU INT,@FECINI DATE,@FECFIN DATE,@BAN CHAR(1)
AS
	IF @BAN='1'
		SELECT SUM(COSTOTOTAL) AS VENTATOTAL
		FROM VENTA
		WHERE FECHA BETWEEN @FECINI AND DATEADD(d,1,@FECFIN) AND ESTADO = '1'
	ELSE
		SELECT SUM(COSTOTOTAL) AS VENTATOTAL
		FROM VENTA
		WHERE IDUSUARIO = @IDUSU AND FECHA BETWEEN @FECINI AND DATEADD(d,1,@FECFIN) AND ESTADO = '1'
GO
/****** Object:  StoredProcedure [dbo].[CERRARCOMPRA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CERRARCOMPRA] @IDCOM INT
AS
	UPDATE COMPRA SET ULTIMO = '0' WHERE IDCOMPRA = @IDCOM
GO
/****** Object:  StoredProcedure [dbo].[CERRARVENTA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CERRARVENTA] @IDVEN INT
AS
	UPDATE VENTA SET ULTIMO='0' WHERE IDVENTA=@IDVEN
GO
/****** Object:  StoredProcedure [dbo].[DARBAJALOTEVENTA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DARBAJALOTEVENTA] @IDVEN INT,@IDPRO INT,@CAN INT
AS
	DECLARE @IDLO INT,@AUX INT
	UPDATE ALMACEN SET CANTIDAD = CANTIDAD + @CAN WHERE IDPRODUCTO=@IDPRO
	WHILE @CAN>0
		BEGIN
		SELECT @IDLO=MAX(L.IDLOTE),@AUX=L.Cantidad-C.Cantidad
		FROM CONTROLP C INNER JOIN LOTE L ON C.IdLote = L.IdLote
		WHERE C.Cantidad < L.Cantidad AND L.IDPRODUCTO=@IDPRO
		GROUP BY L.IDLOTE,C.EXPIRACION,C.CANTIDAD,L.CANTIDAD
		HAVING C.Expiracion = (SELECT MAX(C.EXPIRACION)FROM CONTROLP C INNER JOIN LOTE L ON C.IdLote = L.IdLote
													 WHERE C.Cantidad < L.Cantidad AND L.IDPRODUCTO=@IDPRO)
		IF @AUX >= @CAN
			BEGIN
			UPDATE CONTROLP SET CANTIDAD=CANTIDAD+@CAN WHERE IDLOTE=@IDLO
			SET @CAN=0
			END
		ELSE
			BEGIN
			UPDATE CONTROLP SET CANTIDAD=CANTIDAD+@AUX WHERE IDLOTE=@IDLO
			SET @CAN=@CAN-@AUX
			END
		END
GO
/****** Object:  StoredProcedure [dbo].[DARBAJAVENTA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DARBAJAVENTA] @IDVEN INT
AS
	UPDATE VENTA SET ESTADO='0' WHERE IDVENTA=@IDVEN
	UPDATE LOTEVENTA SET ESTADO='0' WHERE IDVENTA=@IDVEN
GO
/****** Object:  StoredProcedure [dbo].[EDITARCOMPRA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EDITARCOMPRA] @IDCOM INT,@COS FLOAT,@DES VARCHAR(100)
AS
	UPDATE COMPRA SET CostoTotal=@COS,ULTIMO='1',DESCRIPCION=@DES WHERE IdCompra=@IDCOM
GO
/****** Object:  StoredProcedure [dbo].[EDITARVENTA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EDITARVENTA] @IDVEN INT,@COS FLOAT,@EFE FLOAT,@CAM FLOAT
AS
	UPDATE VENTA SET CostoTotal=@COS,Efectivo=@EFE,Cambio=@CAM WHERE IdVenta=@IDVEN
GO
/****** Object:  StoredProcedure [dbo].[ELIMINARCOMPRA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ELIMINARCOMPRA] @IDCOM INT
AS
	DELETE FROM COMPRA WHERE IdCompra=@IDCOM
GO
/****** Object:  StoredProcedure [dbo].[ELIMINARCONTROL]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ELIMINARCONTROL] @IDLO INT
AS
	DELETE FROM CONTROLP WHERE IDLOTE=@IDLO
GO
/****** Object:  StoredProcedure [dbo].[ELIMINARLOTEVENTA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ELIMINARLOTEVENTA] @IDVEN INT,@IDPRO INT,@CAN INT,@BAN INT
AS
	IF @BAN=1
		EXEC DARBAJALOTEVENTA @IDVEN,@IDPRO,@CAN
	DELETE FROM LOTEVENTA WHERE IDVENTA=@IDVEN AND IDPRODUCTO=@IDPRO
GO
/****** Object:  StoredProcedure [dbo].[ELIMINARPRODUCTO]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ELIMINARPRODUCTO] @IDPRO INT
AS
	UPDATE PRODUCTO SET ESTADO='0' WHERE IDPRODUCTO=@IDPRO
GO
/****** Object:  StoredProcedure [dbo].[ELIMINARUSUARIO]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ELIMINARUSUARIO] @ID INT
AS
	UPDATE USUARIO SET ESTADO='0' WHERE IDUSUARIO=@ID
GO
/****** Object:  StoredProcedure [dbo].[ELIMINARVENTA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ELIMINARVENTA] @IDVEN INT,@BAN INT
AS
	IF @BAN=1
		EXEC DARBAJAVENTA @IDVEN
	DELETE FROM VENTA WHERE IDVENTA=@IDVEN
GO
/****** Object:  StoredProcedure [dbo].[GETCLIENTE]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GETCLIENTE] @CI VARCHAR(20)
AS
	SELECT * FROM LISTARCLIENTES WHERE CICLIENTE=@CI
GO
/****** Object:  StoredProcedure [dbo].[GETPRODUCTO]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GETPRODUCTO] @COD VARCHAR(20)
AS
	SELECT * FROM LISTARPRODUCTOS WHERE CODIGO=@COD
GO
/****** Object:  StoredProcedure [dbo].[GETULTIMACOMPRA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GETULTIMACOMPRA]
AS
	SELECT IDCOMPRA FROM COMPRA WHERE ULTIMO='1'
GO
/****** Object:  StoredProcedure [dbo].[GETULTIMAVENTA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GETULTIMAVENTA]
AS
	SELECT IDVENTA FROM VENTA WHERE ULTIMO='1'
GO
/****** Object:  StoredProcedure [dbo].[GETUSUARIO]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GETUSUARIO] @CI VARCHAR(20)
AS
	SELECT * FROM LISTARUSUARIOS WHERE CIUSUARIO=@CI
GO
/****** Object:  StoredProcedure [dbo].[INSERTARALMACEN]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERTARALMACEN] @IDPRO INT,@CAN INT
AS
	UPDATE ALMACEN SET Cantidad = Cantidad + @CAN WHERE IdProducto = @IDPRO
GO
/****** Object:  StoredProcedure [dbo].[INSERTARCLIENTE]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERTARCLIENTE] @ID INT,@CI VARCHAR(20),@NOM VARCHAR(60),@APE VARCHAR(60),@TEL VARCHAR(20)
AS
	IF EXISTS(SELECT * FROM CLIENTE WHERE IDCLIENTE=@ID)
		UPDATE CLIENTE SET CICliente=@CI,Nombres=@NOM,Apellidos=@APE,Telefono=@TEL WHERE IdCliente=@ID
	ELSE
		INSERT INTO CLIENTE VALUES(@CI,@NOM,@APE,@TEL)
GO
/****** Object:  StoredProcedure [dbo].[INSERTARCOMPRA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERTARCOMPRA] @COS FLOAT,@DES VARCHAR(200),@DIS VARCHAR(60),@DIR VARCHAR(60),@TEL VARCHAR(20),@CAT VARCHAR(25)
AS
	DECLARE @ID INT
	IF NOT EXISTS(SELECT * FROM DISTRIBUIDORA WHERE NOMBRE=@DIS)
		INSERT INTO DISTRIBUIDORA VALUES(@DIS,@DIR,@TEL,@CAT)
	SET @ID = (SELECT IDDISTRIBUIDORA FROM DISTRIBUIDORA WHERE NOMBRE=@DIS)
	INSERT INTO COMPRA VALUES(GETDATE(),@COS,1,@DES,@ID)
GO
/****** Object:  StoredProcedure [dbo].[INSERTARDISTRIBUIDORA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERTARDISTRIBUIDORA] @NOM VARCHAR(60),@DIR VARCHAR(60),@TEL VARCHAR(20),@CAT VARCHAR(40)
AS
	IF EXISTS(SELECT * FROM DISTRIBUIDORA WHERE NOMBRE=@NOM)
		UPDATE DISTRIBUIDORA SET NOMBRE=@NOM,DIRECCION=@DIR,TELEFONO=@TEL,CATEGORIA=@CAT
	ELSE
		INSERT INTO DISTRIBUIDORA VALUES(@NOM,@DIR,@TEL,@CAT)
GO
/****** Object:  StoredProcedure [dbo].[INSERTARLOTE]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERTARLOTE] @IDPRO INT,@IDCO INT,@EXP VARCHAR(12),@COS FLOAT,@CANPA INT,@CANEN INT
AS
	DECLARE @PRECO FLOAT,@CAN INT
	SET @CAN = @CANPA * @CANEN
	SET @PRECO = @COS / @CAN
	INSERT INTO LOTE VALUES(@IDPRO,@IDCO,@EXP,@CAN,@PRECO,@COS,@CANPA,@CANEN)
	EXEC INSERTARALMACEN @IDPRO,@CAN
	UPDATE PRODUCTO SET PRECIOCOMPRA=@PRECO WHERE IDPRODUCTO=@IDPRO
GO
/****** Object:  StoredProcedure [dbo].[INSERTARLOTEVENTA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERTARLOTEVENTA] @IDVEN INT,@IDPRO INT,@CAN INT,@PREVE FLOAT,@COS FLOAT
AS
	DECLARE @NCAN INT
	SET @NCAN = @CAN * (-1)
	INSERT INTO LOTEVENTA VALUES(@IDVEN,@IDPRO,@CAN,@PREVE,'1',@COS)
	EXEC INSERTARALMACEN @IDPRO,@NCAN
	EXEC REDUCIRCONTROL @IDPRO,@CAN
GO
/****** Object:  StoredProcedure [dbo].[INSERTARPRODUCTO]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERTARPRODUCTO] @IDPRO INT,@COD VARCHAR(20),@NOM VARCHAR(100),@CAT VARCHAR(25),@PRES VARCHAR(20),@PRECO FLOAT,@PREVE FLOAT,@DES VARCHAR(100),@UBI VARCHAR(20)
AS
	IF EXISTS(SELECT * FROM PRODUCTO WHERE IDPRODUCTO = @IDPRO)
		BEGIN
		UPDATE PRODUCTO SET Codigo=@COD,Nombre=@NOM,Categoria=@CAT,Presentacion=@PRES,PrecioCompra=@PRECO,PrecioVenta=@PREVE,Descripcion=@DES WHERE IdProducto=@IDPRO
		UPDATE ALMACEN SET UBICACION=@UBI WHERE IdProducto=@IDPRO
		END
	ELSE
		BEGIN
		INSERT INTO PRODUCTO VALUES(@COD,@NOM,@CAT,@PRES,@PRECO,@PREVE,@DES,'1')
		SET @IDPRO = (SELECT IDPRODUCTO FROM PRODUCTO WHERE CODIGO=@COD)
		INSERT INTO ALMACEN VALUES(@IDPRO,0,@UBI)
		END
GO
/****** Object:  StoredProcedure [dbo].[INSERTARUSUARIO]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERTARUSUARIO] @ID INT,@CI VARCHAR(20),@NOM VARCHAR(60),@APE VARCHAR(60),@TEL VARCHAR(20),@EM VARCHAR(40),@DIR VARCHAR(60),@ROL CHAR(1),@EST CHAR(1)
AS
	IF EXISTS(SELECT * FROM USUARIO WHERE IDUSUARIO=@ID)
		UPDATE USUARIO SET CIUsuario=@CI,Nombres=@NOM,Apellidos=@APE,Telefono=@TEL,Email=@EM,Direccion=@DIR,ROL=@ROL,ESTADO=@EST WHERE IDUSUARIO=@ID
	ELSE
		INSERT INTO USUARIO VALUES(@CI,@NOM,@APE,@TEL,@EM,@DIR,@ROL,'1')
GO
/****** Object:  StoredProcedure [dbo].[INSERTARVENTA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERTARVENTA] @IDUSU INT,@CI VARCHAR(20),@NOM VARCHAR(60),@TEL VARCHAR(20),@COS FLOAT,@EFE FLOAT,@CAM FLOAT,@PA VARCHAR(10)
AS
	DECLARE @IDCLI INT
	IF NOT EXISTS(SELECT * FROM CLIENTE WHERE CICLIENTE=@CI)
		INSERT INTO CLIENTE VALUES(@CI,@NOM,'',@TEL)
	SET @IDCLI = (SELECT IDCLIENTE FROM CLIENTE WHERE CICLIENTE=@CI)
	INSERT INTO VENTA VALUES(@IDUSU,@IDCLI,GETDATE(),@COS,@EFE,@CAM,'1','1',@PA)
GO
/****** Object:  StoredProcedure [dbo].[LISTARLOTEVENTA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LISTARLOTEVENTA] @ID INT
AS
	SELECT * FROM LISTARLOTEVENTAS
	WHERE IDVENTA=@ID
GO
/****** Object:  StoredProcedure [dbo].[LISTARVENTAUSUARIO]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LISTARVENTAUSUARIO] @IDUSU INT,@FECINI DATE,@FECFIN DATE,@BAN CHAR(1)
AS
	IF @BAN='1'
		SELECT V.IDVENTA,CONCAT(U.NOMBRES,' ',U.APELLIDOS) AS VENDEDOR,C.NOMBRES,V.FECHA,V.COSTOTOTAL,V.PAGO,V.ESTADO,V.EFECTIVO,V.CAMBIO
		FROM VENTA V INNER JOIN CLIENTE C ON V.IdCliente=C.IdCliente INNER JOIN USUARIO U ON U.IdUsuario=V.IdUsuario
		WHERE V.FECHA BETWEEN @FECINI AND DATEADD(d,1,@FECFIN) AND V.ESTADO = '1'
	ELSE
		SELECT V.IDVENTA,CONCAT(U.NOMBRES,' ',U.APELLIDOS) AS VENDEDOR,C.NOMBRES,V.FECHA,V.COSTOTOTAL,V.PAGO,V.ESTADO,V.EFECTIVO,V.CAMBIO
		FROM VENTA V INNER JOIN CLIENTE C ON V.IdCliente=C.IdCliente INNER JOIN USUARIO U ON U.IdUsuario=V.IdUsuario
		WHERE U.IDUSUARIO = @IDUSU AND V.FECHA BETWEEN @FECINI AND DATEADD(d,1,@FECFIN) AND V.ESTADO = '1'
GO
/****** Object:  StoredProcedure [dbo].[LOGINSYSTEM]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LOGINSYSTEM] @CI VARCHAR(20),@CON VARCHAR(20)
AS
	IF EXISTS(SELECT * FROM USUARIO WHERE CIUsuario=@CI AND CONTRASENA=@CON AND ESTADO='1')
		SELECT * FROM LISTARUSUARIOS WHERE CIUSUARIO=@CI AND CONTRASENA=@CON
GO
/****** Object:  StoredProcedure [dbo].[REDUCIRCONTROL]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[REDUCIRCONTROL] @IDPRO INT,@CAN INT
AS
	DECLARE @IDLO INT,@AUX INT
	WHILE @CAN>0
		BEGIN
			SELECT @IDLO=MIN(IDLOTE),@AUX=CANTIDAD FROM CONTROLP
			WHERE Cantidad>0 AND IDPRODUCTO=@IDPRO
			GROUP BY IDLOTE,EXPIRACION,CANTIDAD
			HAVING Expiracion = (SELECT MIN(EXPIRACION)FROM CONTROLP WHERE CANTIDAD>0 AND IDPRODUCTO=@IDPRO)
			-----AQUI PUEDE ENTRAR EL FACTOR NULL
				IF @AUX>=@CAN
					BEGIN
					UPDATE CONTROLP SET CANTIDAD = CANTIDAD - @CAN WHERE IDLOTE=@IDLO
					SET @CAN = 0
					END
				ELSE
					BEGIN
					UPDATE CONTROLP SET CANTIDAD = 0 WHERE IDLOTE=@IDLO
					SET @CAN = @CAN - @AUX
					END

		END
GO
/****** Object:  StoredProcedure [dbo].[SEPARAR]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SEPARAR] @ID INT,@NOM VARCHAR(60),@MAR VARCHAR(80)
AS
	UPDATE PRODUCTO SET NOMBRE = @NOM,MARCA=@MAR WHERE IDPRODUCTO=@ID
GO
/****** Object:  Table [dbo].[ALMACEN]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ALMACEN](
	[IdProducto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[ubicacion] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[CICliente] [varchar](20) NULL,
	[Nombres] [varchar](60) NOT NULL,
	[Apellidos] [varchar](60) NOT NULL,
	[Telefono] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[COMPRA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[COMPRA](
	[IdCompra] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[CostoTotal] [float] NOT NULL,
	[Ultimo] [char](1) NULL,
	[Descripcion] [varchar](100) NULL,
	[IdDistribuidora] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CONTROLP]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONTROLP](
	[IdLote] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Expiracion] [date] NOT NULL,
	[Cantidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdLote] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DISTRIBUIDORA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DISTRIBUIDORA](
	[IdDistribuidora] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](60) NULL,
	[Direccion] [varchar](60) NULL,
	[Telefono] [varchar](20) NULL,
	[Categoria] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDistribuidora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOTE]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOTE](
	[IdLote] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[IdCompra] [int] NOT NULL,
	[Expiracion] [date] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioCompra] [float] NOT NULL,
	[Costo] [float] NULL,
	[CantidadPaquete] [int] NULL,
	[CantidadEnPaquete] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdLote] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOTEVENTA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOTEVENTA](
	[IdVenta] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioVenta] [float] NOT NULL,
	[Estado] [char](1) NULL,
	[Costo] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC,
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PRODUCTO]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PRODUCTO](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](20) NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Categoria] [varchar](25) NULL,
	[Presentacion] [varchar](100) NULL,
	[PrecioCompra] [float] NOT NULL,
	[PrecioVenta] [float] NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estado] [char](1) NULL,
	[Marca] [varchar](80) NULL,
	[Contenido] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USUARIO](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[CIUsuario] [varchar](20) NULL,
	[Nombres] [varchar](60) NOT NULL,
	[Apellidos] [varchar](60) NOT NULL,
	[Telefono] [varchar](20) NOT NULL,
	[Email] [varchar](40) NULL,
	[Direccion] [varchar](60) NOT NULL,
	[Rol] [char](1) NOT NULL,
	[Estado] [char](1) NULL,
	[Contrasena] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VENTA]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VENTA](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[CostoTotal] [float] NOT NULL,
	[Efectivo] [float] NOT NULL,
	[Cambio] [float] NOT NULL,
	[Estado] [char](1) NULL,
	[Ultimo] [char](1) NULL,
	[Pago] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[LISTARCLIENTES]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[LISTARCLIENTES]
AS
	SELECT ROW_NUMBER() OVER(ORDER BY NOMBRES ASC) AS N,*
	FROM CLIENTE
	WHERE IDCLIENTE>1
GO
/****** Object:  View [dbo].[LISTARCOMPRAS]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[LISTARCOMPRAS]
AS
	SELECT IDCOMPRA,CONCAT(DAY(FECHA),'/',MONTH(FECHA),'/',YEAR(FECHA),' ',CONVERT(CHAR(8),FECHA, 108)) AS FECHA,COSTOTOTAL,DESCRIPCION FROM COMPRA
GO
/****** Object:  View [dbo].[LISTARCONTROLES]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[LISTARCONTROLES]
AS
	SELECT CP.IDLOTE,P.NOMBRE,P.PRESENTACION,CP.EXPIRACION,CP.CANTIDAD
	FROM CONTROLP CP INNER JOIN PRODUCTO P ON CP.IDPRODUCTO=P.IDPRODUCTO
GO
/****** Object:  View [dbo].[LISTARLOTES]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[LISTARLOTES]
AS
	SELECT L.IDCOMPRA,L.IDLOTE,P.NOMBRE,P.PRESENTACION,L.PRECIOCOMPRA,L.CANTIDAD,L.CANTIDAD*L.PRECIOCOMPRA AS COSTO
	FROM LOTE L INNER JOIN PRODUCTO P ON P.IDPRODUCTO=L.IDPRODUCTO
GO
/****** Object:  View [dbo].[LISTARLOTEVENTAS]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[LISTARLOTEVENTAS]
AS
	SELECT LV.IDVENTA,P.CODIGO,P.NOMBRE,P.PRESENTACION,LV.PRECIOVENTA,LV.CANTIDAD,LV.CANTIDAD*LV.PRECIOVENTA AS COSTO,LV.ESTADO
	FROM LOTEVENTA LV INNER JOIN PRODUCTO P ON LV.IDPRODUCTO=P.IDPRODUCTO
GO
/****** Object:  View [dbo].[LISTARPRODUCTOS]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[LISTARPRODUCTOS]
AS
	SELECT ROW_NUMBER() OVER(ORDER BY P.NOMBRE ASC) AS N,P.IDPRODUCTO,P.CODIGO,P.NOMBRE,P.MARCA,P.CATEGORIA,P.PRESENTACION,P.PRECIOCOMPRA,P.PRECIOVENTA,P.DESCRIPCION,A.UBICACION,A.CANTIDAD
	FROM PRODUCTO P INNER JOIN ALMACEN A ON P.IdProducto = A.IdProducto
	WHERE P.ESTADO='1'
GO
/****** Object:  View [dbo].[LISTARUSUARIOS]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[LISTARUSUARIOS]
AS
	SELECT ROW_NUMBER() OVER(ORDER BY NOMBRES ASC) AS N,*
	FROM USUARIO
GO
/****** Object:  View [dbo].[LISTARVENTAS]    Script Date: 24/2/2020 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[LISTARVENTAS]
AS
	SELECT V.IDVENTA,U.IDUSUARIO,C.IDCLIENTE,CONCAT(U.NOMBRES,' ',U.APELLIDOS) AS VENDEDOR,C.NOMBRES AS CLIENTE,CONCAT(DAY(V.FECHA),'/',MONTH(V.FECHA),'/',YEAR(V.FECHA),' ',convert(char(8), V.FECHA, 108)) AS FECHA,V.COSTOTOTAL,V.PAGO,V.EFECTIVO,V.CAMBIO,V.ESTADO
	FROM VENTA V INNER JOIN USUARIO U ON V.IDUSUARIO=U.IDUSUARIO
				 INNER JOIN CLIENTE C ON V.IDCLIENTE=C.IDCLIENTE
GO
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (23, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (24, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (25, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (26, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (27, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (28, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (29, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (30, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (31, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (32, 10, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (33, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (34, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (35, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (36, 10, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (37, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (38, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (39, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (40, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (41, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (42, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (43, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (44, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (45, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (46, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (47, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (48, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (49, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (50, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (51, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (52, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (53, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (54, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (55, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (56, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (57, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (58, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (59, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (60, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (61, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (62, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (63, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (64, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (65, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (66, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (67, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (68, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (69, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (70, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (71, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (72, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (73, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (74, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (75, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (76, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (77, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (78, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (79, 0, N'LADO DERECHO')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1038, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1039, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1040, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1041, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1042, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1043, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1044, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1045, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1046, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1047, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1048, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1049, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1050, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1051, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1052, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1053, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1054, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1055, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1056, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1057, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1058, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1059, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1060, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1061, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1062, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1063, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1064, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1065, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1066, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1067, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1068, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1069, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1070, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1071, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1072, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1073, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1074, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1075, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1076, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1077, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1078, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1079, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1080, 0, N'LADO ENTRADA')
GO
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1081, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1082, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1083, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1084, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1085, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1086, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1087, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1088, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1089, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1090, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1091, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1092, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1093, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1094, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1095, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1096, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1097, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1098, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1099, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1100, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1101, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1102, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1103, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1104, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1105, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1106, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1107, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1108, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1109, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1110, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1111, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1112, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1113, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1114, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1115, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1116, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1117, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1118, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1119, 0, N'LADO ENTRADA')
INSERT [dbo].[ALMACEN] ([IdProducto], [Cantidad], [ubicacion]) VALUES (1120, 0, N'LADO ENTRADA')
SET IDENTITY_INSERT [dbo].[CLIENTE] ON 

INSERT [dbo].[CLIENTE] ([IdCliente], [CICliente], [Nombres], [Apellidos], [Telefono]) VALUES (1, N'0', N'SIN REGISTRAR', N'-', N'-')
INSERT [dbo].[CLIENTE] ([IdCliente], [CICliente], [Nombres], [Apellidos], [Telefono]) VALUES (2, N'1033', N'ALV', N'ZAP', N'793')
INSERT [dbo].[CLIENTE] ([IdCliente], [CICliente], [Nombres], [Apellidos], [Telefono]) VALUES (3, N'1055', N'LUIS', N'MOS', N'603')
INSERT [dbo].[CLIENTE] ([IdCliente], [CICliente], [Nombres], [Apellidos], [Telefono]) VALUES (4, N'10376878', N'MARIBEL ARANCIBIA', N'', N'60305087')
SET IDENTITY_INSERT [dbo].[CLIENTE] OFF
SET IDENTITY_INSERT [dbo].[COMPRA] ON 

INSERT [dbo].[COMPRA] ([IdCompra], [Fecha], [CostoTotal], [Ultimo], [Descripcion], [IdDistribuidora]) VALUES (1008, CAST(0x0000AB6701044C72 AS DateTime), 145, N'0', N'MI PRIMER COMPRA', 2)
SET IDENTITY_INSERT [dbo].[COMPRA] OFF
INSERT [dbo].[CONTROLP] ([IdLote], [IdProducto], [Expiracion], [Cantidad]) VALUES (22, 36, CAST(0xEB400B00 AS Date), 10)
INSERT [dbo].[CONTROLP] ([IdLote], [IdProducto], [Expiracion], [Cantidad]) VALUES (23, 32, CAST(0x09410B00 AS Date), 10)
SET IDENTITY_INSERT [dbo].[DISTRIBUIDORA] ON 

INSERT [dbo].[DISTRIBUIDORA] ([IdDistribuidora], [Nombre], [Direccion], [Telefono], [Categoria]) VALUES (1, N'PIL', N'Alla', N'7935', NULL)
INSERT [dbo].[DISTRIBUIDORA] ([IdDistribuidora], [Nombre], [Direccion], [Telefono], [Categoria]) VALUES (2, N'COCA DISTRI', N'ALLACITO', N'796321455', N'ZUMOS Y BEBIDAS')
SET IDENTITY_INSERT [dbo].[DISTRIBUIDORA] OFF
SET IDENTITY_INSERT [dbo].[LOTE] ON 

INSERT [dbo].[LOTE] ([IdLote], [IdProducto], [IdCompra], [Expiracion], [Cantidad], [PrecioCompra], [Costo], [CantidadPaquete], [CantidadEnPaquete]) VALUES (22, 36, 1008, CAST(0xEB400B00 AS Date), 12, 9.1666666666666661, 110, 2, 6)
INSERT [dbo].[LOTE] ([IdLote], [IdProducto], [IdCompra], [Expiracion], [Cantidad], [PrecioCompra], [Costo], [CantidadPaquete], [CantidadEnPaquete]) VALUES (23, 32, 1008, CAST(0x09410B00 AS Date), 12, 2.9166666666666665, 35, 2, 6)
SET IDENTITY_INSERT [dbo].[LOTE] OFF
INSERT [dbo].[LOTEVENTA] ([IdVenta], [IdProducto], [Cantidad], [PrecioVenta], [Estado], [Costo]) VALUES (1025, 32, 2, 5, N'1', 10)
INSERT [dbo].[LOTEVENTA] ([IdVenta], [IdProducto], [Cantidad], [PrecioVenta], [Estado], [Costo]) VALUES (1025, 36, 1, 13, N'1', 13)
INSERT [dbo].[LOTEVENTA] ([IdVenta], [IdProducto], [Cantidad], [PrecioVenta], [Estado], [Costo]) VALUES (2025, 36, 1, 13, N'1', 13)
SET IDENTITY_INSERT [dbo].[PRODUCTO] ON 

INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (23, N'7759185002158', N'PAÑUELO ELITE MENTOL TRIPLE HOJA', N'HIGIENE Y CUIDADO PER.', N'1 UN.', -1, 2, N'KLEENEX', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (24, N'77942388', N'CHICLE BELDENT MENTA FUERTE', N'GOLOSINAS
', N'10 GR.', -1, 4, N'CHICLE', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (25, N'77716088', N'SODA COCA COLA ORIGINAL', N'ZUMOS Y BEBIDAS', N'2LT.', -1, 10, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (26, N'7771609000960', N'SODA COCA COLA ORIGINAL', N'ZUMOS Y BEBIDAS', N'3LT.', -1, 13, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (27, N'7771609000250', N'AGUA VITAL', N'ZUMOS Y BEBIDAS', N'600ML.', -1, 4, N'', N'1', N'VITAL', NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (28, N'7771605000032', N'SODA FANTA NARANJA', N'ZUMOS Y BEBIDAS', N'2 LT.', -1, 10, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (29, N'7771609001646', N'SODA FANTA NARANJA', N'ZUMOS Y BEBIDAS', N'3 LT.', -1, 13, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (30, N'7771609000120', N'SODA SIMBA DURAZNO', N'ZUMOS Y BEBIDAS', N'2 LT.', -1, 8.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (31, N'7771609000496', N'ENERGIZANTE POWERADE MORA AZUL', N'ZUMOS Y BEBIDAS', N'473 ML.', -1, 6, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (32, N'7771609000649', N'REFRESCO AQUARIUS PERA', N'ZUMOS Y BEBIDAS', N'500 ML.', 2.9166666666666665, 5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (33, N'7771605000124', N'SODA FANTA NARANJA', N'ZUMOS Y BEBIDAS', N'500 ML.', -1, 5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (34, N'7771609001486', N'AGUA VITAL', N'ZUMOS Y BEBIDAS', N'1 LT.', -1, 6.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (35, N'77716064', N'SODA COCA COLA ORIGINAL', N'ZUMOS Y BEBIDAS', N'500 ML.', -1, 5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (36, N'7771609002520', N'REFRESCO AQUARIUS PERA', N'ZUMOS Y BEBIDAS', N'3 LT.', 9.1666666666666661, 13, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (37, N'7771609002377', N'SODA SPRITE LIMA LIMON', N'ZUMOS Y BEBIDAS', N'3 LT.', -1, 13, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (38, N'7771609002032', N'SODA SPRITE LIMA LIMON', N'ZUMOS Y BEBIDAS', N'2 LT.', -1, 10, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (39, N'7771609001264', N'JUGO DEL VALLE DURAZNO', N'ZUMOS Y BEBIDAS', N'1 LT.', -1, 9, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (40, N'7771609001684', N'JUGO DEL VALLE DURAZNO', N'ZUMOS Y BEBIDAS', N'200 ML.', -1, 2.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (41, N'7771609001523', N'ENERGIZANTE POWERADE  MULTIFRUTAS', N'ZUMOS Y BEBIDAS', N'1 LT.', -1, 10, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (42, N'7771609001998', N'SODA COCA COLA SIN AZUCAR', N'ZUMOS Y BEBIDAS', N'3 LT.', -1, 13, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (43, N'070847028406', N'ENERGIZANTE MONSTER ENERGY', N'ZUMOS Y BEBIDAS', N'473 ML.', -1, 15, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (44, N'7771609001493', N'ENERGIZANTE POWERADE MORA AZUL', N'ZUMOS Y BEBIDAS', N'1 LT.', -1, 10, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (45, N'7790895643835', N'JUGO ADES SOJA MANZANA', N'ZUMOS Y BEBIDAS', N'1 LT.', -1, 10, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (46, N'7771609002872', N'JUGO DEL VALLE FRESH CITRUS NARANJA', N'ZUMOS Y BEBIDAS', N'3 LT.', -1, 13, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (47, N'7771609000526', N'ENERGIZANTE POWERADE MULTIFRUTAS', N'ZUMOS Y BEBIDAS', N'473 ML.', -1, 6, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (48, N'7771609001455', N'SODA FANTA NARANJA', N'ZUMOS Y BEBIDAS', N'300 ML.', -1, 3.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (49, N'7771609001448', N'SODA COCA COLA ORIGINAL', N'ZUMOS Y BEBIDAS', N'300 ML.', -1, 3.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (50, N'856472002031', N'REFRESCO SAVIA ALOE VERA PIÑA', N'ZUMOS Y BEBIDAS', N'500 ML.', -1, 10, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (51, N'7771224008112', N'JUGO FRUSH DELIZIA DURAZNO', N'ZUMOS Y BEBIDAS', N'600 ML.', -1, 5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (52, N'7771224008129', N'JUGO FRUSH DELIZIA MANZANA', N'ZUMOS Y BEBIDAS', N'600 ML.', -1, 5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (53, N'7771605000469', N'SODA SIMBA MANZANA', N'ZUMOS Y BEBIDAS', N'2 LT.', -1, 8.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (54, N'7771224006354', N'JUGO ICE FRUIT DELIZIA MANGO', N'ZUMOS Y BEBIDAS', N'2 LT.', -1, 8.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (55, N'7771224006309', N'JUGO ICE FRUIT DELIZIA CITRUS PUNCH', N'ZUMOS Y BEBIDAS', N'2 LT.', -1, 8.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (56, N'7771224001755', N'JUGO TAMPICO CITRUS PUNCH', N'ZUMOS Y BEBIDAS', N'2.5 LT.', -1, 10, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (57, N'7771224002202', N'JUGO TAMPICO MANGO', N'ZUMOS Y BEBIDAS', N'2.5 LT.', -1, 10, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (58, N'7771224003018', N'JUGO TAMPICO CITRUS PUNCH', N'ZUMOS Y BEBIDAS', N'3 LT.', -1, 12, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (59, N'7771224006323', N'JUGO ICE FRUIT DELIZIA CITRUS PUNCH', N'ZUMOS Y BEBIDAS', N'5 LT.', -1, 20, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (60, N'7771224006798', N'JUGO ICE FRUIT DELIZIA CITRUS PUNCH', N'ZUMOS Y BEBIDAS', N'3 LT.', -1, 12, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (61, N'7771224003049', N'JUGO TAMPICO MANGO', N'ZUMOS Y BEBIDAS', N'3 LT.', -1, 12, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (62, N'7771224006361', N'JUGO ICE FRUIT DELIZIA MANGO', N'ZUMOS Y BEBIDAS', N'3 LT.', -1, 12, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (63, N'7862100143338', N'ESPUMA GOLDERY CHICLE BLU', N'OTROS
', N'540 ML.', -1, 10, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (64, N'7751851030489', N'BETUN SAPOLIO NEGRO', N'HOGAR Y LIMPIEZA', N'40 GR.', -1, 5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (65, N'7750034000097', N'BETUN SANTIAGO NEGRO', N'HOGAR Y LIMPIEZA', N'45 ML.', -1, 4, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (66, N'7750034000202', N'BETUN SANTIAGO NEGRO', N'HOGAR Y LIMPIEZA', N'30 ML.', -1, 3, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (67, N'7751851028684', N'BETUN SAPOLIO NEGRO', N'HOGAR Y LIMPIEZA', N'100 ML.', -1, 6, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (68, N'7790037000311', N'ESPUMA REY MOMO', N'OTROS
', N'380 GR.', -1, 10, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (69, N'7862100143192', N'ESPUMA GOLDERY VINCEREZA', N'OTROS
', N'1000 ML.', -1, 13, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (70, N'7751851016162', N'BETUN LIQUIDO SAPOLIO MARRON', N'HOGAR Y LIMPIEZA', N'60 ML.', -1, 10, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (71, N'7750034000936', N'BETUN LIQUIDO SANTIAGO NEGRO', N'HOGAR Y LIMPIEZA', N'60 ML.', -1, 0, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (72, N'7751851027335', N'BETUN LIQUIDO SAPOLIO INCOLORO', N'HOGAR Y LIMPIEZA', N'70 ML.', -1, 10, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (73, N'6928632700041', N'PEGAMENTO OUSTOOLS SUPER GLUE', N'LIBRERIA
', N'3 GR.', -1, 2, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (74, N'6920180416023', N'CEPILLO CERDAS PEQUEÑAS', N'HOGAR Y LIMPIEZA
', N'1 UN.', -1, 4, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (75, N'7775000010528', N'ESPONJA OLA ANTIBACTERIAL', N'HOGAR Y LIMPIEZA
', N'3 UN.', -1, 9, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (76, N'7891055112601', N'CEPILLO CONDOR OVALADO', N'HOGAR Y LIMPIEZA
', N'1 UN.', -1, 5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (77, N'7896001045446', N'ESPONJA ESFREBOM MULTIUSO', N'HOGAR Y LIMPIEZA
', N'4 UN,', -1, 6, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (78, N'7771224007078', N'JUGO FRUSH DELIZIA PERA', N'ZUMOS Y BEBIDAS', N'2 LT..', -1, 12, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (79, N'7771224007252', N'JUGO FRUSH DELIZIA TAMARINDO', N'ZUMOS Y BEBIDAS', N'2 LT.', -1, 12, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1038, N'7501065911919', N'RASURADORA GILLETTE DOBLE HOJA', N'HIGIENE Y CUIDADO PERSONA', N'1 UN.', -1, 6.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1039, N'7033071753', N'RASURADORA BIC COMFORT NORMAL', N'HIGIENE Y CUIDADO PERSONA', N'1 UN.', -1, 7, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1040, N'7033073180', N'RASURADORA BIC SOLEIL', N'HIGIENE Y CUIDADO PERSONA', N'1 UN.', -1, 6, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1041, N'7702018880409', N'RASURADORA GILLETE TRIPLE HOJA', N'HIGIENE Y CUIDADO PERSONA', N'1 UN.', -1, 10, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1042, N'7509546015040', N'CEPILLO DENTAL COLGATE NORMAL', N'HIGIENE Y CUIDADO PERSONA', N'1 UN.', -1, 5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1043, N'6946357156882', N'CEPILLO DENTAL ASTRAL NORMAL', N'HIGIENE Y CUIDADO PERSONA', N'1 UN,', -1, 1.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1044, N'7779970673073', N'SHAMPOO SEDAL RECARGA PALTA Y MANTECA', N'HIGIENE Y CUIDADO PERSONA', N'50 ML.', -1, 3, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1045, N'7779970673325', N'SHAMPOO SEDAL CASPA CONTROL', N'HIGIENE Y CUIDADO PERSONA', N'45 ML.', -1, 3, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1046, N'7896058595390', N'GOMITAS DORI MINHOCA', N'GOLOSINAS', N'85 GR.', -1, 7, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1047, N'7896058595284', N'GOMITAS DORI TIJOLO ACIDO', N'GOLOSINAS
', N'85 GR.', -1, 7, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1048, N'7896058595376', N'GOMITAS DORI BOCA', N'GOLOSINAS
', N'85 GR.', -1, 7, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1049, N'7896058595369', N'GOMITAS DORI BANANA', N'GOLOSINAS
', N'85 GR.', -1, 7, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1050, N'7896058595277', N'GOMITAS DORI FLOR', N'GOLOSINAS
', N'85 GR.', -1, 7, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1051, N'7896058595383', N'GOMITAS DORI URSO', N'GOLOSINAS
', N'85 GR.', -1, 7, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1052, N'7896058595413', N'GOMITAS DORI AMORA', N'GOLOSINAS
', N'85 GR.', -1, 7, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1053, N'7896058595406', N'GOMITAS DORI MINHOCA ACIDA', N'GOLOSINAS
', N'85 GR.', -1, 7, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1054, N'7798094220963', N'ALFAJOR GENIO DULCE LECHE', N'GOLOSINAS
', N'60 GR.', -1, 2, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1055, N'7798094220956', N'ALFAJOR GENIO CAFE', N'GOLOSINAS
', N'60 GR.', -1, 2, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1056, N'7622300124526', N'GALLETA RITZ QUESO', N'GALLETAS', N'34 GR.', -1, 2, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1057, N'7773401005174', N'GALLETA CREMOSITAS DULCE LECHE', N'GALLETAS', N'38 GR.', -1, 1, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1058, N'7779604120232', N'GALLETA ALINA MARGARITAS', N'GALLETAS', N'36 GR.', -1, 2, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1059, N'7773401005129', N'GALLETA CREMOSITAS CHOCOLATE', N'GALLETAS', N'38 GR.', -1, 1, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1060, N'7773401005150', N'GALLETA CREMOSITAS FRUTILLA', N'GALLETAS', N'38 GR.', -1, 1, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1061, N'7773401006065', N'GALLETA CREMOSITAS NEGRITA', N'GALLETAS', N'38 GR.', -1, 1, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1062, N'7622210675569', N'GALLETA FIELD CHOKOSODA', N'GALLETAS', N'36 GR.', -1, 2, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1063, N'7773401005167', N'GALLETA CREMOSITAS', N'GALLETAS', N'38 GR.', -1, 0, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1064, N'7771223000469', N'GALLETA FERRARI G. ANIMALITOS', N'GALLETAS', N'35 GR.', -1, 0.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1065, N'7771257590158', N'GALLETA FERRARI GHEZZI MINI CRACKERS', N'GALLETAS', N'35 GR.', -1, 0.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1066, N'7590011251100', N'GALLETA OREO ORIGINAL', N'GALLETAS', N'36 GR.', -1, 2, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1067, N'7771257590141', N'GALLETA TENTACIONES', N'GALLETAS', N'45 GR.', -1, 0.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1068, N'7771257590134', N'GALLETA FERRARI G. WAFERIN', N'GALLETAS', N'30 GR.', -1, 1, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1069, N'7773401006027', N'GALLETA MINI CREMOSITAS VAINILLA', N'GALLETAS', N'24 GR.', -1, 0.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1070, N'7773401006003', N'GALLETA MINICREMOSITAS VAINILLA', N'GALLETAS', N'24 GR.', -1, 0.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1071, N'7773401006010', N'GALLETA MINICREMOSITAS FRUTILLA', N'GALLETAS', N'24 GR.', -1, 0.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1072, N'7590011205158', N'GALLETA CLUB SOCIAL ORIGINAL', N'GALLETAS', N'26 GR.', -1, 2, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1073, N'7771257590110', N'GALLETA FERRARI G. WAFERIN', N'GALLETAS', N'30 GR.', -1, 1, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1074, N'7771223000445', N'GALLETA FERRARI G. PRIMAVERA', N'GALLETAS', N'35 GR.', -1, 0.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1075, N'7779604120270', N'GALLETA ALINA MINI CHIPS', N'GALLETAS', N'50 GR.', -1, 2.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1076, N'78912359', N'CHOCOLATE BATON', N'CHOCOLATES
', N'16 GR.', -1, 2, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1077, N'7613035049628', N'CHOCOLATE SUBLIME CLASICO', N'CHOCOLATES
', N'30 GR.', -1, 3, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1078, N'7771718071837', N'CHOCOLATE MORDISCO', N'CHOCOLATES
', N'20 GR.', -1, 1.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1079, N'7613035395732', N'CHOCOLATE TRIANGULA', N'CHOCOLATES
', N'30 GR.', -1, 3, N'', N'1', NULL, NULL)
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1080, N'7702993023600', N'MASTICABLE NEXT LIMON', N'GOLOSINAS
', N'14 GR.', -1, 1, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1081, N'7702993030165', N'MASTICABLE NEXT MENTA', N'GOLOSINAS
', N'14 GR.', -1, 1, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1082, N'7702993032954', N'MASTICABLE NEXT FRESA', N'GOLOSINAS
', N'14 GR.', -1, 1, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1083, N'7702993019887', N'GOMITAS OKA LOKA FUSION', N'GOLOSINAS
', N'14 GR.', -1, 2, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1084, N'7702993019573', N'GOMITAS OKA LOKA FUSION ROJO', N'GOLOSINAS
', N'14 GR.', -1, 2, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1085, N'7771259751489', N'JUGO PILFRUT DURAZNO', N'ZUMOS Y BEBIDAS', N'200 ML.', -1, 1, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1086, N'7771259750253', N'YOGURT ESCOLAR FRUTILLA', N'HUEVOS Y LACTEOS
', N'100 ML.', -1, 1, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1087, N'7791014001178', N'PRESERVATIVOS TULIPAN FRUTILLA', N'HIGIENE Y CUIDADO PERSONA', N'3 UN.', -1, 13, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1088, N'7791014090332', N'PRESERVATIVOS TULIPAN TEXTURADO', N'HIGIENE Y CUIDADO PERSONA', N'3 UN,', -1, 13, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1089, N'7791014001161', N'PRESERVATIVOS TULIPAN ULTRA RESISTENTE', N'HIGIENE Y CUIDADO PERSONA', N'3 UN.', -1, 13, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1090, N'7791014001789', N'PRESERVATIVO TULIPAN TANTRICO', N'HIGIENE Y CUIDADO PERSONA', N'3 UN.', -1, 13, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1091, N'7791014001772', N'PRESERVATIVOS TULIPAN RETARDANTE', N'HIGIENE Y CUIDADO PERSONA', N'3 UN.', -1, 13, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1092, N'7791014090325', N'PRESERVATIVOS TULIPAN CLASICO', N'HIGIENE Y CUIDADO PERSONA', N'3 UN.', -1, 13, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1093, N'7791014001765', N'PRESERVATIVOS TULIPAN NEON', N'HIGIENE Y CUIDADO PERSONA', N'3 UN.', -1, 13, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1094, N'7791014001093', N'PRESERVATIVOS TULIPAN TACHAS', N'HIGIENE Y CUIDADO PERSONA', N'3 UN.', -1, 13, N'ULTRA LUBRICADOS', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1095, N'7791014001604', N'PRESERVATIVOS TULIPAN CHOCOLATE', N'HIGIENE Y CUIDADO PERSONA', N'3 UN.', -1, 13, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1096, N'7791014001802', N'PRESERVATIVOS TULIPAN ULTRAFINO', N'HIGIENE Y CUIDADO PERSONA', N'3 UN.', -1, 13, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1097, N'7891151035293', N'PASTILLA COFFE', N'GOLOSINAS
', N'3 UN.', -1, 1, N'MINI PASTILLAS', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1098, N'7802200132696', N'PASTILLAS AMBROSOLI MENTITAS', N'GOLOSINAS
', N'25 GR.', -1, 3, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1099, N'77901651', N'CHICLE BELDENT FRUTILLA', N'GOLOSINAS
', N'10 GR.', -1, 4, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1100, N'77959508', N'CHICLE TOPLINE MENTA', N'GOLOSINAS
', N'11 GR.', -1, 3, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1101, N'77959539', N'CHICLE TOPLINE FRUTA', N'GOLOSINAS
', N'11 GR.', -1, 3, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1102, N'77921246', N'CHICLE TOPLINE ', N'GOLOSINAS
', N'11 GR.', -1, 3, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1103, N'77942371', N'CHICLE BELDENT MENTA', N'GOLOSINAS
', N'10 GR.', -1, 5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1104, N'7702993018316', N'GOMITAS SUPER TRULULU', N'GOLOSINAS
', N'12 GR.', -1, 0.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1105, N'7771259752714', N'CAFE PIL MONACO', N'MERIENDA
', N'1.5 GR.', -1, 1, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1106, N'77766755', N'CIGARRILLOS L&M SUAVE MENTA', N'OTROS
', N'20 UN.', -1, 13.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1107, N'77738035', N'CIGARRILLOS DERBY CLASE A', N'OTROS
', N'20 UN.', -1, 20, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1108, N'7773800000329', N'CIGARRILLOS DERBY CLICK MENTA', N'OTROS
', N'20 UN.', -1, 12, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1109, N'77766199', N'CIGARRILLOS DERBY COOL', N'OTROS
', N'20 UN.', -1, 10, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1110, N'42139621', N'CIGARRILLOS CAMEL ACTIVATE', N'OTROS
', N'20 UN.', -1, 18, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1111, N'77768049', N'CIGARRILLOS L&M KRETEK MINT', N'OTROS
', N'20 UN.', -1, 13.5, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1112, N'77738028', N'CIGARRILLOS L&M AZUL', N'OTROS
', N'20 UN.', -1, 11, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1113, N'77766717', N'CIGARRILLOS L&M ROJO', N'OTROS
', N'10 UN.', -1, 6, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1114, N'039800014009', N'PILAS ENERGYZER AAA2', N'LIBRERIA', N'2 UN.', -1, 12, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1115, N'039800013613', N'BATERIA ENERGYZER MAX', N'OTROS
', N'1 UN.', -1, 20, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1116, N'77766724', N'CIGARRILLOS L&M AZUL', N'OTROS
', N'10 UN,', -1, 6, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1117, N'77738042', N'CIGARRILLOS L&M ROJO', N'OTROS
', N'20 UN.', -1, 11, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1118, N'77769060', N'CIGARRILLOS CAMEL ACTIVATE DOUBLE', N'OTROS
', N'20 UN.', -1, 20, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1119, N'7790129100127', N'ENCENDEDOR LGQ', N'LIBRERIA
', N'1 UN.', -1, 2, N'', N'1', NULL, NULL)
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Categoria], [Presentacion], [PrecioCompra], [PrecioVenta], [Descripcion], [Estado], [Marca], [Contenido]) VALUES (1120, N'03980001546', N'PILAS ENERGYZER AA2', N'LIBRERIA
', N'2 UN.', -1, 12, N'', N'1', NULL, NULL)
SET IDENTITY_INSERT [dbo].[PRODUCTO] OFF
SET IDENTITY_INSERT [dbo].[USUARIO] ON 

INSERT [dbo].[USUARIO] ([IdUsuario], [CIUsuario], [Nombres], [Apellidos], [Telefono], [Email], [Direccion], [Rol], [Estado], [Contrasena]) VALUES (1, N'10332', N'ALV', N'ZAP', N'793', N'DEV', N'AQUI', N'1', N'1', N'1234')
INSERT [dbo].[USUARIO] ([IdUsuario], [CIUsuario], [Nombres], [Apellidos], [Telefono], [Email], [Direccion], [Rol], [Estado], [Contrasena]) VALUES (2, N'1055', N'LUIS', N'MOS', N'603', N'V170', N'ALLA', N'1', N'0', N'1234')
SET IDENTITY_INSERT [dbo].[USUARIO] OFF
SET IDENTITY_INSERT [dbo].[VENTA] ON 

INSERT [dbo].[VENTA] ([IdVenta], [IdUsuario], [IdCliente], [Fecha], [CostoTotal], [Efectivo], [Cambio], [Estado], [Ultimo], [Pago]) VALUES (1025, 1, 1, CAST(0x0000AB67011A3A31 AS DateTime), 23, 30, 7, N'1', N'0', N'EFECTIVO')
INSERT [dbo].[VENTA] ([IdVenta], [IdUsuario], [IdCliente], [Fecha], [CostoTotal], [Efectivo], [Cambio], [Estado], [Ultimo], [Pago]) VALUES (2025, 1, 1, CAST(0x0000AB6800B24D30 AS DateTime), 13, 15, 2, N'1', N'0', N'EFECTIVO')
SET IDENTITY_INSERT [dbo].[VENTA] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__CLIENTE__4C6BBEAB249062EC]    Script Date: 24/2/2020 19:35:05 ******/
ALTER TABLE [dbo].[CLIENTE] ADD UNIQUE NONCLUSTERED 
(
	[CICliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__DISTRIBU__75E3EFCFA2580481]    Script Date: 24/2/2020 19:35:05 ******/
ALTER TABLE [dbo].[DISTRIBUIDORA] ADD UNIQUE NONCLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__PRODUCTO__06370DACAFB163A1]    Script Date: 24/2/2020 19:35:05 ******/
ALTER TABLE [dbo].[PRODUCTO] ADD UNIQUE NONCLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__USUARIO__61D792F2773C40B5]    Script Date: 24/2/2020 19:35:05 ******/
ALTER TABLE [dbo].[USUARIO] ADD UNIQUE NONCLUSTERED 
(
	[CIUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PRODUCTO] ADD  DEFAULT ('1') FOR [Estado]
GO
ALTER TABLE [dbo].[ALMACEN]  WITH CHECK ADD FOREIGN KEY([IdProducto])
REFERENCES [dbo].[PRODUCTO] ([IdProducto])
GO
ALTER TABLE [dbo].[COMPRA]  WITH CHECK ADD FOREIGN KEY([IdDistribuidora])
REFERENCES [dbo].[DISTRIBUIDORA] ([IdDistribuidora])
GO
ALTER TABLE [dbo].[CONTROLP]  WITH CHECK ADD FOREIGN KEY([IdLote])
REFERENCES [dbo].[LOTE] ([IdLote])
GO
ALTER TABLE [dbo].[CONTROLP]  WITH CHECK ADD FOREIGN KEY([IdProducto])
REFERENCES [dbo].[PRODUCTO] ([IdProducto])
GO
ALTER TABLE [dbo].[LOTE]  WITH CHECK ADD FOREIGN KEY([IdCompra])
REFERENCES [dbo].[COMPRA] ([IdCompra])
GO
ALTER TABLE [dbo].[LOTE]  WITH CHECK ADD FOREIGN KEY([IdProducto])
REFERENCES [dbo].[PRODUCTO] ([IdProducto])
GO
ALTER TABLE [dbo].[LOTEVENTA]  WITH CHECK ADD FOREIGN KEY([IdProducto])
REFERENCES [dbo].[PRODUCTO] ([IdProducto])
GO
ALTER TABLE [dbo].[LOTEVENTA]  WITH CHECK ADD FOREIGN KEY([IdVenta])
REFERENCES [dbo].[VENTA] ([IdVenta])
GO
ALTER TABLE [dbo].[VENTA]  WITH CHECK ADD FOREIGN KEY([IdCliente])
REFERENCES [dbo].[CLIENTE] ([IdCliente])
GO
ALTER TABLE [dbo].[VENTA]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[USUARIO] ([IdUsuario])
GO
USE [master]
GO
ALTER DATABASE [CAPITAL] SET  READ_WRITE 
GO
