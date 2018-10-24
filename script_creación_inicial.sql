USE GD2C2018
GO
------------------------------DROP PROCEDURES-----------------------------
IF OBJECT_ID('LOS_DE_GESTION.PR_MIGRACION') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_MIGRACION;

------------------------------DROP FUNCIONES------------------------------
------------------------------DROP VISTAS---------------------------------
------------------------------DROP TRIGGERS ------------------------------
------------------------------DROP DE TABLAS------------------------------

IF OBJECT_ID('LOS_DE_GESTION.Ubicacion') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Ubicacion;
go
IF OBJECT_ID('LOS_DE_GESTION.Publicacion') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Publicacion;
go
IF OBJECT_ID('LOS_DE_GESTION.Estado_Publicacion') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Estado_Publicacion;
go
IF OBJECT_ID('LOS_DE_GESTION.Grado_Publicacion') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Grado_Publicacion;
go
IF OBJECT_ID('LOS_DE_GESTION.Tipo_Ubicacion') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Tipo_Ubicacion;
go
IF OBJECT_ID('LOS_DE_GESTION.Rubro') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Rubro;
go
IF OBJECT_ID('LOS_DE_GESTION.Rol_X_Funcionalidad') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Rol_X_Funcionalidad;
go
IF OBJECT_ID('LOS_DE_GESTION.Funcionalidad') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Funcionalidad;
go
IF OBJECT_ID('LOS_DE_GESTION.Item_Rendicion') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Item_Rendicion;
go
IF OBJECT_ID('LOS_DE_GESTION.Compra') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Compra;
go
IF OBJECT_ID('LOS_DE_GESTION.Rendicion') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Rendicion;																																												;
go
IF OBJECT_ID('LOS_DE_GESTION.Empresa') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Empresa;
go
IF OBJECT_ID('LOS_DE_GESTION.Usuario') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Usuario;
go
IF OBJECT_ID('LOS_DE_GESTION.Premio_Canjeado') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Premio_Canjeado;
go
IF OBJECT_ID('LOS_DE_GESTION.Cliente') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Cliente;
go
IF OBJECT_ID('LOS_DE_GESTION.Rol') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Rol;
go
IF OBJECT_ID('LOS_DE_GESTION.Premio') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Premio;
go

GO

------------------------------DROP SCHEMA---------------------------------
IF SCHEMA_ID('LOS_DE_GESTION') IS NOT NULL
	DROP SCHEMA LOS_DE_GESTION
GO
-----------------------------CREACION SCHEMA -----------------------------
CREATE SCHEMA LOS_DE_GESTION
GO
 
-----------------------------CREACION TABLAS -----------------------------

CREATE TABLE LOS_DE_GESTION.Premio(
	id_Premio numeric(18, 0) PRIMARY KEY,
	descripcion nvarchar(255) ,
	puntos_requeridos numeric(18, 0) NOT NULL
 )
 go

 CREATE TABLE LOS_DE_GESTION.Rol(
	id_Rol numeric(18, 0) PRIMARY KEY,
	nombre nvarchar(255) ,
	habilitado bit
 )
 go

 CREATE TABLE LOS_DE_GESTION.Cliente(
	username nvarchar(255) PRIMARY KEY,
	nombre nvarchar(255),
	apellido nvarchar(255),
	tipo_documento nvarchar(255) NOT NULL,
	numero_documento numeric(18, 0) NOT NULL,
	cuil numeric(18, 0),
	mail nvarchar(50),
	telefono numeric(18, 0),
	calle nvarchar(50),
	nro_calle numeric(18, 0),
	nro_piso numeric(18, 0),
	depto nvarchar(50),
	localidad nvarchar(255),
	codigo_postal nvarchar(50),
	fecha_nacimiento datetime,
	fecha_creacion datetime,
	tarjeta nvarchar(255),
	puntos_acum_validos nvarchar(255),
	fecha_vencimiento_puntos datetime,
	puntos_vencidos nvarchar(255)
 )
 go

 CREATE TABLE LOS_DE_GESTION.Premio_Canjeado(
	id_premio numeric(18, 0) ,
	usuario_cliente nvarchar(255) ,
	echa_creacion datetime,
	PRIMARY KEY(id_premio,usuario_cliente)
 )
 go

 CREATE TABLE LOS_DE_GESTION.Usuario(
	username nvarchar(255) PRIMARY KEY,
	password nvarchar(255),
	intentos_login numeric(18, 0) ,
	bloqueado_login_fallidos bit,
	habilitado bit,
	id_Rol numeric(18, 0)
 )
 go

 CREATE TABLE LOS_DE_GESTION.Empresa(
	username nvarchar(255) PRIMARY KEY,
	razon_social nvarchar(255) UNIQUE,
	cuit nvarchar(255) UNIQUE,
	mail nvarchar(50),
	telefono numeric(18, 0),
	calle nvarchar(50),
	nro_calle numeric(18, 0),
	nro_piso numeric(18, 0),
	depto nvarchar(50),
	localidad nvarchar(255),
	codigo_postal nvarchar(50),
	ciudad nvarchar(255),
	fecha_creacion datetime
 )
 go

 CREATE TABLE LOS_DE_GESTION.Rendicion(
	id_Rendicion numeric(18, 0) PRIMARY KEY,
	importe_total_ventas numeric(18, 2),
	importe_comision_total numeric(18, 2),
	importe_rendicion_total numeric(18, 2),
	fecha_rendicion datetime,
	usuario_empresa_a_rendir nvarchar(255),
	forma_pago_a_empresa nvarchar(255),
 )
 go

 CREATE TABLE LOS_DE_GESTION.Compra(
	id_Compra numeric(18, 0) PRIMARY KEY,
	monto_total numeric(18, 0),
	fecha_compra datetime,
	usuario_cliente_comprador nvarchar(255),
	tarjeta_comprador numeric(18, 0),
	id_Rendicion numeric(18, 0),
	cantidad_ubicaciones numeric(18, 0)
 )
 go

 CREATE TABLE LOS_DE_GESTION.Item_Rendicion(
	id_Item_Rendicion numeric(18, 0) PRIMARY KEY,
	id_Rendicion numeric(18, 0),
	importe_venta numeric(18, 2),
	importe_comision numeric(18, 2),
	importe_rendicion numeric(18, 2),
	descripcion nvarchar(60),
	cantidad_ubicaciones numeric(18, 0)
 )
 go

 CREATE TABLE LOS_DE_GESTION.Funcionalidad(
	id_Funcionalidad numeric(18, 0) PRIMARY KEY,
	nombre nvarchar(255) ,
)
 go

 CREATE TABLE LOS_DE_GESTION.Rol_X_Funcionalidad(
	id_Rol numeric(18, 0),
	id_Funcionalidad numeric(18, 0),
	PRIMARY KEY(id_Rol,id_Funcionalidad)
 )
 go

 CREATE TABLE LOS_DE_GESTION.Rubro(
	id_Rubro numeric(18, 0) PRIMARY KEY,
	descripcion nvarchar(255)
 )
 go

 CREATE TABLE LOS_DE_GESTION.Tipo_Ubicacion(
	id_Tipo_Ubicacion numeric(18, 0) PRIMARY KEY,
	descripcion nvarchar(255),
	puntos_cliente_frecuente numeric(18, 0)
 )
 go

 CREATE TABLE LOS_DE_GESTION.Grado_Publicacion(
	id_Grado_Publicacion numeric(18, 0) PRIMARY KEY,
	descripcion nvarchar(255),
	porcentaje_costo numeric(18, 0)
 )
 go

 CREATE TABLE LOS_DE_GESTION.Estado_Publicacion(
	id_Estado_Publicacion numeric(18, 0) PRIMARY KEY,
	descripcion nvarchar(255),
 )
 go

  CREATE TABLE LOS_DE_GESTION.Publicacion(
	cod_publicacion numeric(18, 0) PRIMARY KEY,
	descripcion nvarchar(255),
	fecha_publicacion datetime,
	fecha_vencimiento_publicacion datetime,
	fecha_hora_espectaculo datetime,
	id_Rubro numeric(18, 0),
	direccion_espectaculo nvarchar(255),
	id_Grado_Publicacion numeric(18, 0),
	usuario_empresa_vendedora nvarchar(255),
	id_Estado_Publicacion numeric(18, 0)
 )
 go

 CREATE TABLE LOS_DE_GESTION.Ubicacion(
	id_Ubicacion numeric(18, 0) PRIMARY KEY,
	cod_publicacion numeric(18, 0),
	fila varchar(3),
	asiento numeric(18, 0),
	ubicacion_sin_numerar bit,
	precio numeric(18, 0),
	id_Tipo_Ubicacion numeric(18, 0),
	id_Compra numeric(18, 0)
 )
 go
-----------------------------TRIGGERS-------------------------------------
-----------------------------VISTAS---------------------------------------
-----------------------------FUNCIONES------------------------------------
-----------------------------STORE PROCEDURE------------------------------
------------------------------MIGRACION-----------------------------------
 
 CREATE PROCEDURE LOS_DE_GESTION.PR_MIGRACION
AS

GO


------------------------------FOREING KEYS---------------------------------
ALTER TABLE LOS_DE_GESTION.Premio_Canjeado ADD FOREIGN KEY ([id_premio]) REFERENCES [LOS_DE_GESTION].Premio
ALTER TABLE LOS_DE_GESTION.Premio_Canjeado ADD FOREIGN KEY ([usuario_cliente]) REFERENCES [LOS_DE_GESTION].Cliente

ALTER TABLE LOS_DE_GESTION.Usuario ADD FOREIGN KEY (id_Rol) REFERENCES [LOS_DE_GESTION].Rol

ALTER TABLE LOS_DE_GESTION.Rol_X_Funcionalidad ADD FOREIGN KEY (id_Rol) REFERENCES [LOS_DE_GESTION].Rol
ALTER TABLE LOS_DE_GESTION.Rol_X_Funcionalidad ADD FOREIGN KEY (id_Funcionalidad) REFERENCES [LOS_DE_GESTION].Funcionalidad

ALTER TABLE LOS_DE_GESTION.Publicacion ADD FOREIGN KEY (id_Rubro) REFERENCES [LOS_DE_GESTION].Rubro
ALTER TABLE LOS_DE_GESTION.Publicacion ADD FOREIGN KEY (id_Grado_Publicacion) REFERENCES [LOS_DE_GESTION].Grado_Publicacion
ALTER TABLE LOS_DE_GESTION.Publicacion ADD FOREIGN KEY (usuario_empresa_vendedora) REFERENCES [LOS_DE_GESTION].Empresa
ALTER TABLE LOS_DE_GESTION.Publicacion ADD FOREIGN KEY (id_Estado_Publicacion) REFERENCES [LOS_DE_GESTION].Estado_Publicacion

ALTER TABLE LOS_DE_GESTION.Item_Rendicion ADD FOREIGN KEY (id_Rendicion) REFERENCES [LOS_DE_GESTION].Rendicion

ALTER TABLE LOS_DE_GESTION.Rendicion ADD FOREIGN KEY (usuario_empresa_a_rendir) REFERENCES [LOS_DE_GESTION].Empresa

ALTER TABLE LOS_DE_GESTION.Compra ADD FOREIGN KEY (usuario_cliente_comprador) REFERENCES [LOS_DE_GESTION].Cliente
ALTER TABLE LOS_DE_GESTION.Compra ADD FOREIGN KEY (id_Rendicion) REFERENCES [LOS_DE_GESTION].Rendicion

ALTER TABLE LOS_DE_GESTION.Empresa ADD FOREIGN KEY (username) REFERENCES [LOS_DE_GESTION].Usuario

ALTER TABLE LOS_DE_GESTION.Ubicacion ADD FOREIGN KEY (cod_publicacion) REFERENCES [LOS_DE_GESTION].Publicacion
ALTER TABLE LOS_DE_GESTION.Ubicacion ADD FOREIGN KEY (id_Tipo_Ubicacion) REFERENCES [LOS_DE_GESTION].Tipo_Ubicacion
ALTER TABLE LOS_DE_GESTION.Ubicacion ADD FOREIGN KEY (id_Compra) REFERENCES [LOS_DE_GESTION].Compra

GO
------------------------------EJECUTO MIGRACION-----------------------------
EXECUTE LOS_DE_GESTION.PR_MIGRACION
GO


--select* from gd_esquema.Maestra

