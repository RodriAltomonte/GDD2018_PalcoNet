USE GD2C2018
GO

------------------------------DROP PROCEDURES-----------------------------
IF OBJECT_ID('LOS_DE_GESTION.PR_MIGRACION') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_MIGRACION;

------------------------------DROP FUNCIONES------------------------------
IF OBJECT_ID('LOS_DE_GESTION.FN_HASHPASS','FN') IS NOT NULL
DROP FUNCTION LOS_DE_GESTION.FN_HASHPASS
go
------------------------------DROP VISTAS---------------------------------
------------------------------DROP TRIGGERS ------------------------------

------------------------------DROP DE FOREIGN KEYS------------------------------
IF OBJECT_ID('LOS_DE_GESTION.Premio_Canjeado') IS NOT NULL AND OBJECT_ID('LOS_DE_GESTION.FK_Premio_Canjeado_Premio','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Premio_Canjeado DROP CONSTRAINT FK_Premio_Canjeado_Premio
GO
IF OBJECT_ID('LOS_DE_GESTION.Premio_Canjeado') IS NOT NULL AND OBJECT_ID('LOS_DE_GESTION.FK_Premio_Canjeado_Cliente','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Premio_Canjeado DROP CONSTRAINT FK_Premio_Canjeado_Cliente
GO
IF OBJECT_ID('LOS_DE_GESTION.Usuario') IS NOT NULL AND OBJECT_ID('LOS_DE_GESTION.FK_Usuario_Rol','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Usuario DROP CONSTRAINT FK_Usuario_Rol
GO
IF OBJECT_ID('LOS_DE_GESTION.Rol_X_Funcionalidad') IS NOT NULL AND OBJECT_ID('FK_Rol_X_Funcionalidad_Rol','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Rol_X_Funcionalidad DROP CONSTRAINT FK_Rol_X_Funcionalidad_Rol
GO
IF OBJECT_ID('LOS_DE_GESTION.Rol_X_Funcionalidad') IS NOT NULL AND OBJECT_ID('FK_Rol_X_Funcionalidad_Funcionalidad','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Rol_X_Funcionalidad DROP CONSTRAINT FK_Rol_X_Funcionalidad_Funcionalidad
GO
IF OBJECT_ID('LOS_DE_GESTION.Publicacion') IS NOT NULL AND OBJECT_ID('FK_Publicacion_Rubro','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Publicacion DROP CONSTRAINT FK_Publicacion_Rubro
GO
IF OBJECT_ID('LOS_DE_GESTION.Publicacion') IS NOT NULL AND OBJECT_ID('FK_Publicacion_Grado_Publicacion','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Publicacion DROP CONSTRAINT FK_Publicacion_Grado_Publicacion
GO
IF OBJECT_ID('LOS_DE_GESTION.Publicacion') IS NOT NULL AND OBJECT_ID('FK_Publicacion_Empresa','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Publicacion DROP CONSTRAINT FK_Publicacion_Empresa
GO
IF OBJECT_ID('LOS_DE_GESTION.Publicacion') IS NOT NULL AND OBJECT_ID('FK_Publicacion_Estado_Publicacion','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Publicacion DROP CONSTRAINT FK_Publicacion_Estado_Publicacion
GO
IF OBJECT_id('LOS_DE_GESTION.Item_Rendicion') IS NOT NULL AND OBJECT_ID('FK_Item_Rendicion_Rendicion','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Item_Rendicion DROP CONSTRAINT FK_Item_Rendicion_Rendicion
GO
IF OBJECT_id('LOS_DE_GESTION.Rendicion') IS NOT NULL AND OBJECT_ID('FK_Rendicion_Empresa','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Rendicion DROP CONSTRAINT FK_Rendicion_Empresa
GO
IF OBJECT_id('LOS_DE_GESTION.Compra') IS NOT NULL AND OBJECT_ID('FK_Compra_Cliente','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Compra DROP CONSTRAINT FK_Compra_Cliente
GO
IF OBJECT_id('LOS_DE_GESTION.Compra') IS NOT NULL AND OBJECT_ID('FK_Compra_Rendicion','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Compra DROP CONSTRAINT FK_Compra_Rendicion
GO
IF OBJECT_id('LOS_DE_GESTION.Empresa') IS NOT NULL AND OBJECT_ID('FK_Empresa_Usuario','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Empresa DROP CONSTRAINT FK_Empresa_Usuario
GO
IF OBJECT_id('LOS_DE_GESTION.Cliente') IS NOT NULL AND OBJECT_ID('FK_Cliente_Usuario','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Cliente DROP CONSTRAINT FK_Cliente_Usuario
GO
IF OBJECT_id('LOS_DE_GESTION.Ubicacion') IS NOT NULL AND OBJECT_ID('FK_Ubicacion_Publicacion','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Ubicacion DROP CONSTRAINT FK_Ubicacion_Publicacion
GO
IF OBJECT_id('LOS_DE_GESTION.Ubicacion') IS NOT NULL AND OBJECT_ID('FK_Ubicacion_Tipo_Ubicacion','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Ubicacion DROP CONSTRAINT FK_Ubicacion_Tipo_Ubicacion
GO
IF OBJECT_id('LOS_DE_GESTION.Ubicacion') IS NOT NULL AND OBJECT_ID('FK_Ubicacion_Compra','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Ubicacion DROP CONSTRAINT FK_Ubicacion_Compra
GO

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
IF OBJECT_ID('LOS_DE_GESTION.Premio_Canjeado') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Premio_Canjeado;
go
IF OBJECT_ID('LOS_DE_GESTION.Cliente') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Cliente;
go
IF OBJECT_ID('LOS_DE_GESTION.Usuario') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Usuario;
go
IF OBJECT_ID('LOS_DE_GESTION.Premio_Canjeado') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Premio_Canjeado;
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
	id_Premio numeric(18, 0) PRIMARY KEY IDENTITY(1,1) NOT NULL,
	descripcion nvarchar(255) ,
	puntos_requeridos int NOT NULL
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
	cuil nvarchar(255),
	mail nvarchar(255),
	telefono nvarchar(50),
	calle nvarchar(255),
	nro_calle numeric(18, 0),
	nro_piso numeric(18, 0),
	depto nvarchar(255),
	localidad nvarchar(255),
	codigo_postal nvarchar(255),
	fecha_nacimiento datetime,
	fecha_creacion datetime,
	tarjeta nvarchar(255),
	puntos_acum_validos int,
	fecha_vencimiento_puntos datetime,
	puntos_vencidos int
 )
 go

 CREATE TABLE LOS_DE_GESTION.Premio_Canjeado(
	id_premio numeric(18, 0) ,
	usuario_cliente nvarchar(255) ,
	fecha_canje datetime,
	PRIMARY KEY(id_premio,usuario_cliente)
 )
 go

 CREATE TABLE LOS_DE_GESTION.Usuario(
	username nvarchar(255) PRIMARY KEY,
	password nvarchar(255),
	intentos_login int ,
	bloqueado_login_fallidos bit,
	habilitado bit,
	id_Rol numeric(18, 0)
 )
 go

 CREATE TABLE LOS_DE_GESTION.Empresa(
	username nvarchar(255) PRIMARY KEY,
	razon_social nvarchar(255),
	cuit nvarchar(255),
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
	id_Rendicion numeric(18, 0) PRIMARY KEY IDENTITY(1,1) NOT NULL,
	importe_total_ventas numeric(18, 2),
	importe_comision_total numeric(18, 2),
	importe_rendicion_total numeric(18, 2),
	fecha_rendicion datetime,
	usuario_empresa_a_rendir nvarchar(255),
	forma_pago_a_empresa nvarchar(255),
 )
 go

 CREATE TABLE LOS_DE_GESTION.Compra(
	id_Compra numeric(18, 0) PRIMARY KEY IDENTITY(1,1) NOT NULL,
	monto_total numeric(18, 2),
	fecha_compra datetime,
	usuario_cliente_comprador nvarchar(255),
	tarjeta_comprador nvarchar(255),
	id_Rendicion numeric(18, 0),
	cantidad_ubicaciones numeric(18, 0)
 )
 go

 CREATE TABLE LOS_DE_GESTION.Item_Rendicion(
	id_Item_Rendicion numeric(18, 0) PRIMARY KEY IDENTITY(1,1) NOT NULL,
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
	puntos_cliente_frecuente int
 )
 go

 CREATE TABLE LOS_DE_GESTION.Grado_Publicacion(
	id_Grado_Publicacion numeric(18, 0) PRIMARY KEY,
	descripcion nvarchar(255),
	porcentaje_costo numeric(5, 2)
 )
 go

 CREATE TABLE LOS_DE_GESTION.Estado_Publicacion(
	id_Estado_Publicacion numeric(18, 0) PRIMARY KEY,
	descripcion nvarchar(255)
 )
 go

  CREATE TABLE LOS_DE_GESTION.Publicacion(
	cod_publicacion numeric(18, 0) PRIMARY KEY IDENTITY(1,1) NOT NULL,
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
	id_Ubicacion numeric(18, 0) PRIMARY KEY IDENTITY(1,1) NOT NULL,
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
CREATE FUNCTION LOS_DE_GESTION.FN_HASHPASS(@password nvarchar(255))
RETURNS nvarchar(255)
AS
BEGIN
	RETURN CONVERT(nvarchar(255),HASHBYTES('SHA2_256',@password),1)
END
-----------------------------STORE PROCEDURE------------------------------
------------------------------MIGRACION-----------------------------------
 
 CREATE PROCEDURE LOS_DE_GESTION.PR_MIGRACION
AS

GO


------------------------------FOREING KEYS---------------------------------
ALTER TABLE LOS_DE_GESTION.Premio_Canjeado ADD CONSTRAINT FK_Premio_Canjeado_Premio FOREIGN KEY ([id_premio]) REFERENCES [LOS_DE_GESTION].Premio
ALTER TABLE LOS_DE_GESTION.Premio_Canjeado ADD CONSTRAINT FK_Premio_Canjeado_Cliente FOREIGN KEY ([usuario_cliente]) REFERENCES [LOS_DE_GESTION].Cliente

ALTER TABLE LOS_DE_GESTION.Usuario ADD CONSTRAINT FK_Usuario_Rol FOREIGN KEY (id_Rol) REFERENCES [LOS_DE_GESTION].Rol

ALTER TABLE LOS_DE_GESTION.Rol_X_Funcionalidad ADD CONSTRAINT FK_Rol_X_Funcionalidad_Rol FOREIGN KEY (id_Rol) REFERENCES [LOS_DE_GESTION].Rol
ALTER TABLE LOS_DE_GESTION.Rol_X_Funcionalidad ADD CONSTRAINT FK_Rol_X_Funcionalidad_Funcionalidad FOREIGN KEY (id_Funcionalidad) REFERENCES [LOS_DE_GESTION].Funcionalidad

ALTER TABLE LOS_DE_GESTION.Publicacion ADD CONSTRAINT FK_Publicacion_Rubro FOREIGN KEY (id_Rubro) REFERENCES [LOS_DE_GESTION].Rubro
ALTER TABLE LOS_DE_GESTION.Publicacion ADD CONSTRAINT FK_Publicacion_Grado_Publicacion FOREIGN KEY (id_Grado_Publicacion) REFERENCES [LOS_DE_GESTION].Grado_Publicacion
ALTER TABLE LOS_DE_GESTION.Publicacion ADD CONSTRAINT FK_Publicacion_Empresa FOREIGN KEY (usuario_empresa_vendedora) REFERENCES [LOS_DE_GESTION].Empresa
ALTER TABLE LOS_DE_GESTION.Publicacion ADD CONSTRAINT FK_Publicacion_Estado_Publicacion FOREIGN KEY (id_Estado_Publicacion) REFERENCES [LOS_DE_GESTION].Estado_Publicacion

ALTER TABLE LOS_DE_GESTION.Item_Rendicion ADD CONSTRAINT FK_Item_Rendicion_Rendicion FOREIGN KEY (id_Rendicion) REFERENCES [LOS_DE_GESTION].Rendicion

ALTER TABLE LOS_DE_GESTION.Rendicion ADD CONSTRAINT FK_Rendicion_Empresa FOREIGN KEY (usuario_empresa_a_rendir) REFERENCES [LOS_DE_GESTION].Empresa

ALTER TABLE LOS_DE_GESTION.Compra ADD CONSTRAINT FK_Compra_Cliente FOREIGN KEY (usuario_cliente_comprador) REFERENCES [LOS_DE_GESTION].Cliente
ALTER TABLE LOS_DE_GESTION.Compra ADD CONSTRAINT FK_Compra_Rendicion FOREIGN KEY (id_Rendicion) REFERENCES [LOS_DE_GESTION].Rendicion

ALTER TABLE LOS_DE_GESTION.Empresa ADD CONSTRAINT FK_Empresa_Usuario FOREIGN KEY (username) REFERENCES [LOS_DE_GESTION].Usuario

ALTER TABLE LOS_DE_GESTION.Cliente ADD CONSTRAINT FK_Cliente_Usuario FOREIGN KEY (username) REFERENCES [LOS_DE_GESTION].Usuario

ALTER TABLE LOS_DE_GESTION.Ubicacion ADD CONSTRAINT FK_Ubicacion_Publicacion FOREIGN KEY (cod_publicacion) REFERENCES [LOS_DE_GESTION].Publicacion
ALTER TABLE LOS_DE_GESTION.Ubicacion ADD CONSTRAINT FK_Ubicacion_Tipo_Ubicacion FOREIGN KEY (id_Tipo_Ubicacion) REFERENCES [LOS_DE_GESTION].Tipo_Ubicacion
ALTER TABLE LOS_DE_GESTION.Ubicacion ADD CONSTRAINT FK_Ubicacion_Compra FOREIGN KEY (id_Compra) REFERENCES [LOS_DE_GESTION].Compra

GO

------------------------------EJECUTO MIGRACION-----------------------------
EXECUTE LOS_DE_GESTION.PR_MIGRACION
GO

------------------------------INSERTS INICIALES-----------------------------
INSERT INTO LOS_DE_GESTION.Rol (id_Rol, nombre, habilitado) VALUES
(1, 'Administrativo', 1),
(2, 'Cliente', 1),
(3, 'Empresa', 1)
go

INSERT INTO LOS_DE_GESTION.Funcionalidad (id_Funcionalidad, nombre) VALUES
(1, 'ABM de Rol'), --Admin
(2, 'Registro de Usuario'),--Admin
(3, 'ABM de Clientes'),--Admin
(4, 'ABM de Empresa de Espectaculos'),--Admin
(5, 'ABM de Rubro'),--Admin
(6, 'ABM de Grado de Publicacion'),--
(7, 'Generar Publicacion'),--Empresa
(8, 'Editar Publicacion'),--Empresa
(9, 'Comprar'),--Cliente
(10, 'Historial de Cliente'),--Cliente
(11, 'Generar rendicion de comisiones'),--Admin
(12, 'Listado Estadistico'),--Admin
(13, 'Modificar password'),--Cliente,Admin
(14, 'Dar de baja un usuario')--Admin
go

/*INSERT INTO LOS_DE_GESTION.Rol_X_Funcionalidad (id_Rol, id_Funcionalidad) VALUES(0, 0);
go*/




------------------------------GENERACION DE ADMINISTRADOR GENERAL-----------------------------


--select* from gd_esquema.Maestra

