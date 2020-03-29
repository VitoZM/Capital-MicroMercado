--. POR VER 
CREATE PROC EDITARCOMPRA @IDCO INT,@COS FLOAT
AS
	DELETE FROM LOTE WHERE IdCompra = @IDCO
	UPDATE COMPRA SET CostoTotal = @COS

UPDATE PRODUCTO SET MARCA='S/MARCA PEQUEÑO' WHERE IDPRODUCTO=74
SELECT * FROM LISTARPRODUCTOS
UPDATE PRODUCTO SET NOMBRE = CONCAT('JUGO ',NOMBRE) WHERE NOMBRE LIKE 'TAMPICO%'
UPDATE PRODUCTO SET NOMBRE = 'PILAS ENERGYZER AA2' WHERE IDPRODUCTO=1120
---PRODUCTOS
-----------------------------------------------------------------------------------------------
--1.INSERCION DE PRODUCTOS
EXEC INSERTARPRODUCTO -1,'123456','PRUEBA','LACTEO','PAQUETE 12UN.',12.5,15,'ES MI PRIMER COMMIT'
EXEC INSERTARPRODUCTO -1,'223456','PRUEBA 2','CARNES','1 KILO',15,22.5,'ES MI SEGUNDO COMMIT'
EXEC INSERTARPRODUCTO -1,'323456','PRUEBA 3','PANES','UNIDAD',0.5,1,'ES MI TERCER COMMIT'
EXEC INSERTARPRODUCTO -1,'423456','PRUEBA 4','MASAS','PAQUETE 12UN.',1.5,3,'ES MI CUARTO COMMIT'
EXEC INSERTARPRODUCTO -1,'523456','PRUEBA 5','REFRESCOS','BOTELLA 2LTS',10,11,'ES MI QUINTO COMMIT'
EXEC INSERTARPRODUCTO -1,'7770105009873','GLUCOSAMIN','POLVO 15G','FARMACO',3,5,'A VER'

SELECT P.IDPRODUCTO,P.Codigo,P.Nombre,P.Descripcion,P.PrecioCompra,A.Cantidad FROM PRODUCTO P INNER JOIN ALMACEN A ON P.IdProducto = A.IdProducto
-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------
--2. EDICION DE PRODUCTOS
EXEC INSERTARPRODUCTO 16,'123457','PRUEBA','LACTEO','PAQUETE 12UN.',12.5,15,'ES MI PRIMER EDIT'

SELECT P.IDPRODUCTO,P.Codigo,P.Nombre,P.Descripcion,P.PrecioCompra,A.Cantidad FROM PRODUCTO P INNER JOIN ALMACEN A ON P.IdProducto = A.IdProducto
--------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------
--3. ELIMINACION DE PRODUCTOS
delete from ALMACEN where IdProducto=21
select * from PRODUCTO
EXEC ELIMINARPRODUCTO 20
update PRODUCTO set NOMBRE = 'ESPUMA GOLDERY CHICLE BLU' where IDPRODUCTO = 63
-------------------------------------------------------------------------------------------------
select * from LISTARCOMPRAS
-------------------------------------------------------------------------------------------------
--4. VISTA DE PRODUCTOS
SELECT * FROM LISTARPRODUCTOS
-------------------------------------------------------------------------------------------------
select * from listarventas

---COMPRAS
--------------------------------------------------------------------------------------------------
insert into distribuidora values('PIL','alla','7521')
--1. INSERCION DE COMPRAS     ALTER PROC INSERTARCOMPRA @COS FLOAT,@DES VARCHAR(200),@DIS VARCHAR(60),@DIR VARCHAR(60),@TEL VARCHAR(20)
EXEC INSERTARCOMPRA 22.5,'lacteos y bebidas','PIL','',''
EXEC INSERTARLOTE 16,5,'2020/05/21',12.5,2,5 ---INSERTARLOTE @IDPRO INT,@IDCO INT,@EXP VARCHAR(12),@COS FLOAT,@CANPA INT,@CANEN INT
EXEC CERRARCOMPRA 5
---------------------------------------------------------
EXEC INSERTARCOMPRA 69,'papas',1,'NUEVO','ALLACITO','2-12135'
EXEC INSERTARLOTE 16,6,'2020/06/21',3,23
EXEC CERRARCOMPRA 6
--------------------------------------------------------
EXEC INSERTARCOMPRA 52,'lacteos'
EXEC INSERTARLOTE 16,7,'2020/05/28',4,13
EXEC CERRARCOMPRA 7

SELECT * FROM COMPRA
UPDATE ALMACEN SET CANTIDAD=0
DELETE FROM CONTROLP
SELECT C.IdCompra,C.COSTOTOTAL,C.Fecha,P.NOMBRE,L.CANTIDAD FROM COMPRA C INNER JOIN LOTE L ON C.IdCompra = L.IdCompra
										 INNER JOIN PRODUCTO P ON P.IDPRODUCTO = L.IDPRODUCTO
--------------------------------------------------------------------------------------------------


--2. EDICION DE COMPRAS
--------------------------------------------------------------------------------------------------
EXEC EDITARCOMPRA 6,39,'EDITANDO'
EXEC ELIMINARCONTROL 19
EXEC INSERTARLOTE 16,6,'2020/06/21',3,13----SE INSERTA NUEVAMENTE TODOS LOS LOTES
EXEC CERRARCOMPRA 6
--------------------------------------------------------------------------------------------------

--3. ELIMINAR DE COMPRAS
--------------------------------------------------------------------------------------------------
EXEC ELIMINARCONTROL 20
EXEC ELIMINARCOMPRA 6
--------------------------------------------------------------------------------------------------

--4. VISTA DE COMPRAS
--------------------------------------------------------------------------------------------------
SELECT * FROM LISTARCOMPRAS
--------------------------------------------------------------------------------------------------

--4. VISTA DE LOTES
--------------------------------------------------------------------------------------------------
SELECT * FROM LISTARLOTES
--------------------------------------------------------------------------------------------------

--4. VISTA DE CONTROLES
--------------------------------------------------------------------------------------------------
SELECT * FROM LISTARCONTROLES ORDER BY EXPIRACION
--------------------------------------------------------------------------------------------------

---USUARIOS
--------------------------------------------------------------------------------------------------
--1. INSERCION DE USUARIOS
EXEC INSERTARUSUARIO -1,'1033','ALV','ZAP','793','DEV','AQUI','1','1'
EXEC INSERTARUSUARIO -1,'1055','LUIS','MOS','603','V170','ALLA','1','1'
---------------------------------------------------------

--------------------------------------------------------------------------------------------------
--2. EDICION DE USUARIOS
EXEC INSERTARUSUARIO 1,'10332','ALV','ZAP','793','DEV','AQUI','1','1'
---------------------------------------------------------

--------------------------------------------------------------------------------------------------
--3. DAR DE BAJA USUARIO
EXEC ELIMINARUSUARIO 2
---------------------------------------------------------

--------------------------------------------------------------------------------------------------
--4. LISTAR USUARIOS
SELECT * FROM LISTARUSUARIOS
---------------------------------------------------------

---CLIENTES
--------------------------------------------------------------------------------------------------
--1. INSERCION DE CLIENTES
EXEC INSERTARCLIENTE -1,'-','SIN REGISTRAR','-','-'
EXEC INSERTARCLIENTE -1,'1033','ALV','ZAP','793'
EXEC INSERTARCLIENTE -1,'1055','LUIS','MOS','603'
---------------------------------------------------------

--------------------------------------------------------------------------------------------------
--2. EDICION DE CLIENTES
EXEC INSERTARCLIENTE 1,'10332','ALV','ZAP','793'
---------------------------------------------------------

--------------------------------------------------------------------------------------------------
--3. LISTAR CLIENTES
SELECT * FROM LISTARCLIENTES
---------------------------------------------------------

---VENTAS
--------------------------------------------------------------------------------------------------
--1. INSERCION DE VENTAS ALTER PROC INSERTARVENTA @IDUSU INT,@CI VARCHAR(20),@NOM VARCHAR(60),@TEL VARCHAR(20),@COS FLOAT,@EFE FLOAT,@CAM FLOAT,@PA CHAR(1)
EXEC INSERTARVENTA 1,'1033','','',45,100,55,'1'
EXEC GETULTIMAVENTA
EXEC INSERTARLOTEVENTA 16,16,3,15 -----ALTER PROC INSERTARLOTEVENTA @IDVEN INT,@IDPRO INT,@CAN INT,@PREVE FLOAT
EXEC CERRARVENTA 16
---------------------------------------
EXEC INSERTARVENTA 1,'0',17,20,3,'2'
EXEC GETULTIMAVENTA
EXEC INSERTARLOTEVENTA 19,16,1,15,15
EXEC INSERTARLOTEVENTA 19,18,2,1,2
EXEC CERRARVENTA 19

select * from LOTEVENTA
select * from venta


DELETE FROM LOTEVENTA WHERE IDVENTA=14
DELETE FROM VENTA WHERE IDVENTA=14
UPDATE ALMACEN SET CANTIDAD=5 WHERE IDPRODUCTO=16
UPDATE ALMACEN SET CANTIDAD=10 WHERE IDPRODUCTO=18
UPDATE CONTROLP SET CANTIDAD=4 WHERE IDLOTE=21
SELECT * FROM ALMACEN
SELECT L.IDLOTE,L.IDPRODUCTO,L.EXPIRACION,L.CANTIDAD AS [LOTE CANTIDAD],C.Cantidad AS [CONTROL CANTIDAD] FROM LOTE L INNER JOIN CONTROLP C ON L.IdLote = C.IdLote
--------------------------------------------------------------------------------------------------

--------------------------------------------------------------------------------------------------
--2. BAJA DE VENTAS
SELECT * FROM VENTA
EXEC DARBAJAVENTA 17
EXEC DARBAJALOTEVENTA 17,16,1
EXEC DARBAJALOTEVENTA 17,18,2
--------------------------------
EXEC DARBAJAVENTA 16
EXEC DARBAJALOTEVENTA 16,16,3
--------------------------------------------------------------------------------------------------
SELECT * FROM VENTA V INNER JOIN LOTEVENTA LV ON V.IDVENTA=LV.IDVENTA
--------------------------------------------------------------------------------------------------
--3. ELIMINAR VENTAS
EXEC ELIMINARLOTEVENTA 18,16,1,1
EXEC ELIMINARLOTEVENTA 18,18,2,1
EXEC ELIMINARVENTA 18,1
----------------------------------

--------------------------------------------------------------------------------------------------
--4. LISTAR VENTAS
SELECT * FROM LISTARVENTAS
--------------------------------------------------------------------------------------------------

--------------------------------------------------------------------------------------------------
--4. LISTAR LOTEVENTAS
SELECT * FROM LISTARLOTEVENTAS
--------------------------------------------------------------------------------------------------
select * from LISTARPRODUCTOS
---EDITAR ALMACEN CON REGISTRO-----NO OLVIDAR
---LOG DE USUARIOS----------falta listar los productos en el almacen, para poder recuperar el producto desde ahi y tambien poder ordenarlo