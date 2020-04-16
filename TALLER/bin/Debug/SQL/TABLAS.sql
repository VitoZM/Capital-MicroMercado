CREATE TABLE PRODUCTO(
IdProducto int identity primary key,
Codigo varchar(20) unique,
Nombre varchar(100) not null,
Categoria varchar(25) not null,
Presentacion varchar(100) not null,
PrecioCompra float not null,
PrecioVenta float not null,
Descripcion varchar(100),
Estado char(1) DEFAULT '1',
Marca varchar(80),
Contenido varchar(40)
)

ALTER TABLE PRODUCTO ALTER COLUMN Nombre varchar(60)
select * from listarproductos
--1043 1042
CREATE TABLE ALMACEN(
IdProducto int not null,
Cantidad int not null,
ubicacion varchar(30),
PRIMARY KEY(IdProducto),
FOREIGN KEY(IdProducto)REFERENCES PRODUCTO(IdProducto)
)

CREATE TABLE COMPRA(
IdCompra int identity primary key,
Fecha datetime not null,
CostoTotal float not null,
Ultimo char(1),
Descripcion varchar(100),
IdDistribuidora int,
IdUsuario int,
foreign key(IdUsuario)references usuario(IdUsuario),
foreign key(IdDistribuidora)references distribuidora(IdDistribuidora)
)

CREATE TABLE DISTRIBUIDORA(
IdDistribuidora int identity primary key,
Nombre varchar(60) unique,
Direccion varchar(60),
Telefono varchar(20),
Categoria varchar(25)
)

ALTER TABLE DISTRIBUIDORA ADD

CREATE TABLE LOTE(
IdLote int identity primary key,
IdProducto int not null,
IdCompra int not null,
Expiracion date not null,
Cantidad int not null,
PrecioCompra float not null,
Costo float,
CantidadEnPaquete int,
CantidadPaquete int,
FOREIGN KEY(IdProducto)REFERENCES PRODUCTO(IdProducto),
FOREIGN KEY(IdCompra)REFERENCES COMPRA(IdCompra)
)

CREATE TABLE CONTROLP(
IdLote int not null,
IdProducto int not null,
Expiracion date not null,
Cantidad int not null,
PRIMARY KEY(IdLote),
FOREIGN KEY(IdLote)REFERENCES LOTE(IdLote),
FOREIGN KEY(IdProducto)REFERENCES PRODUCTO(IdProducto)
)

CREATE TABLE CLIENTE(
IdCliente int identity primary key,
CICliente varchar(20) unique,
Nombres varchar(60) not null,
Telefono varchar(20),
)

insert into cliente values('1033','al','zp','746531')
update cliente set CICliente='1044' where IdCliente=1

CREATE TABLE USUARIO(
IdUsuario int identity primary key,
CIUsuario varchar(20) unique,
Nombres varchar(60) not null,
Apellidos varchar(60) not null,
Telefono varchar(20) not null,
Email varchar(40),
Direccion varchar(60) not null,
Rol char(1) not null,
Estado char(1),
Contrasena varchar(20),
Sueldo float
)

CREATE TABLE VENTA(
IdVenta int identity primary key,
IdUsuario int not null,
IdCliente int not null,
Fecha datetime not null,
CostoTotal float not null,
Efectivo float not null,
Cambio float not null,
Estado char(1),
Ultimo char(1),
Pago varchar(10),
Descripcion varchar(120),
CostoTarjeta float,
FOREIGN KEY(IdUsuario)REFERENCES USUARIO(IdUsuario),
FOREIGN KEY(IdCliente)REFERENCES CLIENTE(IdCliente)
)

CREATE TABLE LOTEVENTA(
IdVenta int not null,
IdProducto int not null,
Cantidad int not null,
PrecioVenta float not null,
Estado char(1),
Costo float,
PRIMARY KEY(IdVenta,IdProducto),
FOREIGN KEY(IdVenta)REFERENCES VENTA(IdVenta),
FOREIGN KEY(IdProducto)REFERENCES PRODUCTO(IdProducto)
)

CREATE TABLE EGRESO
(
IdEgreso int identity primary key,
IdUsuario int not null,
Fecha datetime,
Categoria varchar(30),
Monto float,
Descripcion varchar(120),
FOREIGN KEY(IdUsuario)REFERENCES USUARIO(IdUsuario)
)

CREATE TABLE SALARIO
(
IdSalario int identity primary key,
IdUsuario int not null,
MesPagado varchar(10),
Sueldo float,
Descuento float,
LiquidoPagable float,
Fecha datetime,
Descripcion varchar(120),
foreign key(IdUsuario)references USUARIO(IdUsuario)
)

CREATE TABLE INVERSION
(
IdInversion int identity primary key,
CIInversor varchar(20),
NombreInversor varchar(40),
IdUsuario int not null,
Monto float not null,
Fecha datetime not null,
Descripcion varchar(120),
FOREIGN KEY(IdUsuario)REFERENCES USUARIO(IdUsuario)
)
drop table inversion

CREATE TABLE CAJA(
IdCaja int identity primary key,
IdUsuario int not null,
Monto float,
Fecha date,
Cierre char(1),
Ultimo char(1),
Primero char(1),
FOREIGN KEY(IdUsuario)REFERENCES USUARIO(IdUsuario)
)

---FALTA CAJA,REGISTRO VENTAS A CREDITO, REGISTRO DE DESCUENTO DE PRODUCTOS