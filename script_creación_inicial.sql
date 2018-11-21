USE GD2C2018
GO

------------------------------DROP PROCEDURES-----------------------------
IF OBJECT_ID('LOS_DE_GESTION.PR_MIGRACION') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_MIGRACION;
GO

IF OBJECT_ID(N'LOS_DE_GESTION.PR_Validar_login') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_Validar_login
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_FUNCIONALIDADES_DE_UN_ROL') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_FUNCIONALIDADES_DE_UN_ROL
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_ROL_DE_USUARIO') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_ROL_DE_USUARIO
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_ALTA_DE_USUARIO') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_ALTA_DE_USUARIO
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_ROLES_CLIENTE_Y_EMPRESA') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_ROLES_CLIENTE_Y_EMPRESA
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_CAMBIAR_PASSWORD') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_CAMBIAR_PASSWORD
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_DAR_BAJA_USUARIO_POR_ADMIN') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_DAR_BAJA_USUARIO_POR_ADMIN
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_VALIDAR_VENCIMIENTO_DE_PUNTOS') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_VALIDAR_VENCIMIENTO_DE_PUNTOS
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_CLIENTES_CON_MAS_COMPRAS') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_CLIENTES_CON_MAS_COMPRAS
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_EMPRESAS_CON_MAS_LOCALIDADES_NO_VENDIDAS') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_EMPRESAS_CON_MAS_LOCALIDADES_NO_VENDIDAS
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_CLIENTES_CON_MAS_PUNTOS_VENCIDOS') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_CLIENTES_CON_MAS_PUNTOS_VENCIDOS
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_TODOS_LOS_PREMIOS_DISPONIBLES') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_TODOS_LOS_PREMIOS_DISPONIBLES
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_CANJEAR_PREMIO') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_CANJEAR_PREMIO
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_PUNTOS_DE_USUARIO') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_PUNTOS_DE_USUARIO
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_ES_USUARIO_MIGRADO') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_ES_USUARIO_MIGRADO
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_BUSCAR_USUARIOS') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_BUSCAR_USUARIOS
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_ACTUALIZAR_USUARIO_MIGRADO') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_ACTUALIZAR_USUARIO_MIGRADO
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_TODOS_LOS_RUBROS') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_TODOS_LOS_RUBROS
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_TODOS_LOS_GRADOS') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_TODOS_LOS_GRADOS
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_TODOS_LOS_ESTADOS') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_TODOS_LOS_ESTADOS
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_TODOS_LOS_TIPOS_DE_UBICACION') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_TODOS_LOS_TIPOS_DE_UBICACION
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_CREAR_PUBLICACION') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_CREAR_PUBLICACION 
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_CREAR_UBICACIONES') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_CREAR_UBICACIONES
go

/*IF OBJECT_ID(N'') IS NOT NULL
DROP PROCEDURE 
go*/

------------------------------DROP FUNCIONES------------------------------
IF OBJECT_ID('LOS_DE_GESTION.FN_HASHPASS','FN') IS NOT NULL
DROP FUNCTION LOS_DE_GESTION.FN_HASHPASS
go

IF OBJECT_ID('LOS_DE_GESTION.FN_CLIENTE_TIENE_PUNTOS_SUFICIENTES') IS NOT NULL
DROP FUNCTION LOS_DE_GESTION.FN_CLIENTE_TIENE_PUNTOS_SUFICIENTES
go
------------------------------DROP VISTAS---------------------------------
------------------------------DROP TRIGGERS ------------------------------
IF OBJECT_ID(N'LOS_DE_GESTION.TRG_BLOQUEAR_USUARIO_POR_LOGIN_FALLIDO') IS NOT NULL
DROP TRIGGER LOS_DE_GESTION.TRG_BLOQUEAR_USUARIO_POR_LOGIN_FALLIDO
go

------------------------------DROP DE FOREIGN KEYS------------------------------
IF OBJECT_ID('LOS_DE_GESTION.Premio_Canjeado') IS NOT NULL AND OBJECT_ID('LOS_DE_GESTION.FK_Premio_Canjeado_Premio','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Premio_Canjeado DROP CONSTRAINT FK_Premio_Canjeado_Premio
GO
IF OBJECT_ID('LOS_DE_GESTION.Premio_Canjeado') IS NOT NULL AND OBJECT_ID('LOS_DE_GESTION.FK_Premio_Canjeado_Cliente','F') IS NOT NULL
ALTER TABLE LOS_DE_GESTION.Premio_Canjeado DROP CONSTRAINT FK_Premio_Canjeado_Cliente
GO
IF OBJECT_ID('LOS_DE_GESTION.Historial_puntos_vencidos') IS NOT NULL AND OBJECT_ID('LOS_DE_GESTION.FK_Historial_puntos_vencidos_Cliente','F') IS NOT NULL
/*ALTER TABLE LOS_DE_GESTION.FK_Historial_puntos_vencidos_Cliente DROP CONSTRAINT FK_Historial_puntos_vencidos_Cliente*/
ALTER TABLE LOS_DE_GESTION.Historial_puntos_vencidos DROP CONSTRAINT FK_Historial_puntos_vencidos_Cliente
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
IF OBJECT_ID('LOS_DE_GESTION.Historial_puntos_vencidos') IS NOT NULL
DROP TABLE LOS_DE_GESTION.Historial_puntos_vencidos;
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
 	id_premio_canjeado numeric(18,0) PRIMARY KEY IDENTITY(1,1) NOT NULL,
	id_premio numeric(18, 0) NOT NULL,
	usuario_cliente nvarchar(255) NOT NULL,
	fecha_canje datetime
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
	maestra_Espectaculo_Cod numeric(18, 0),
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
 
 CREATE TABLE LOS_DE_GESTION.Historial_puntos_vencidos(
	id_historial_puntos_vencidos numeric(18,0) PRIMARY KEY IDENTITY(1,1) NOT NULL,
	usuario_cliente nvarchar(255) NOT NULL,
	puntos_vencidos int NOT NULL,
	fecha_de_vencimiento datetime NOT NULL
 )
 go

-----------------------------VISTAS---------------------------------------
-----------------------------FUNCIONES------------------------------------
CREATE FUNCTION LOS_DE_GESTION.FN_HASHPASS(@password nvarchar(255))
RETURNS nvarchar(255)
AS
BEGIN
	RETURN CONVERT(nvarchar(255),HASHBYTES('SHA2_256',@password),1)
END
go

CREATE FUNCTION LOS_DE_GESTION.FN_CLIENTE_TIENE_PUNTOS_SUFICIENTES(@clienteUsername nvarchar(255), @idPremio numeric(18,0))
RETURNS bit
AS
BEGIN
	DECLARE @returnValue bit
	
	IF((select c.puntos_acum_validos from LOS_DE_GESTION.Cliente c where c.username = @clienteUsername) >= (select p.puntos_requeridos from LOS_DE_GESTION.Premio p where p.id_Premio = @idPremio))
		SET @returnValue = 1
	ELSE
		SET @returnValue = 0
	
	RETURN @returnValue
END
go

-----------------------------STORE PROCEDURE------------------------------
/*LOGIN*/
/*DROP procedure LOS_DE_GESTION.PR_Validar_login desp saar*/
CREATE PROCEDURE LOS_DE_GESTION.PR_Validar_login @username nvarchar(255), @password nvarchar(255),@loginCorrecto bit OUTPUT
AS 
BEGIN
	DECLARE @estaHabilitado bit
	DECLARE @estaBloqueadoPorLoginFallido bit
	SET NOCOUNT ON
	
	IF NOT EXISTS (select * from LOS_DE_GESTION.Usuario where username = @username)
		BEGIN
			THROW 50001, 'El username/password no existe.',1
		END
	ELSE
		BEGIN
			--Password incorrecto
			IF NOT EXISTS(select * from LOS_DE_GESTION.Usuario where username = @username and password = LOS_DE_GESTION.FN_HASHPASS(@password))
				BEGIN
					BEGIN TRAN;
						update LOS_DE_GESTION.Usuario set intentos_login = intentos_login + 1 where username = @username--Ejecuta trigger
					COMMIT TRAN;
					THROW 50002, 'El username/password no existe.',1
				END
			ELSE --Password valido
				BEGIN
					select @estaHabilitado = u.habilitado, @estaBloqueadoPorLoginFallido = u.bloqueado_login_fallidos
					from LOS_DE_GESTION.Usuario u where u.username = @username
					
					IF (@estaHabilitado = 0) 
						BEGIN
							THROW 50003, 'El usuario fue deshabilitado por el administrador.',1
						END
					ELSE IF (@estaBloqueadoPorLoginFallido = 1) 
						BEGIN
							THROW 50004, 'El usuario fue deshabilitado por exceder la cantidad de intentos de login.',1
						END
					ELSE IF EXISTS(select * from LOS_DE_GESTION.Usuario where username = @username and intentos_login = -1)
						BEGIN
							set @loginCorrecto = 1
							RETURN;
						END
					ELSE
						BEGIN
							set @loginCorrecto = 1
							BEGIN TRAN;
								update LOS_DE_GESTION.Usuario set intentos_login = 0 where username = @username
							COMMIT TRAN;
							RETURN;
						END					
				END
		END		
END
go

Create procedure LOS_DE_GESTION.PR_FUNCIONALIDADES_DE_UN_ROL @idRol decimal
AS BEGIN
	select f.* from LOS_DE_GESTION.Funcionalidad f inner join LOS_DE_GESTION.Rol_X_Funcionalidad rf on f.id_Funcionalidad = rf.id_Funcionalidad
	where rf.id_Rol = @idRol
END
go

create procedure LOS_DE_GESTION.PR_ROL_DE_USUARIO @username nvarchar(255)
as begin
	select r.* from LOS_DE_GESTION.Rol r inner join LOS_DE_GESTION.Usuario u on r.id_Rol = u.id_Rol
	where u.username = @username
end
go

create procedure LOS_DE_GESTION.PR_ES_USUARIO_MIGRADO @username nvarchar(255), @esMigrado bit output
as
begin
	if(exists(select * from LOS_DE_GESTION.Usuario u where u.username = @username and u.intentos_login = -1))
		set @esMigrado = 1
	else
		set @esMigrado = 0
	
	return
end
go

/*3.REGISTRO DE USUARIO*/
CREATE PROCEDURE LOS_DE_GESTION.PR_ALTA_DE_USUARIO @username nvarchar(255), @password nvarchar(255), @idRol numeric(18,0)
AS
BEGIN
	BEGIN TRY
		INSERT INTO GD2C2018.LOS_DE_GESTION.Usuario
		(username, password, intentos_login, bloqueado_login_fallidos, habilitado, id_Rol)
		VALUES(@username, LOS_DE_GESTION.FN_HASHPASS(@password), 0, 0, 1, @idRol)
	END TRY
	BEGIN CATCH
		IF (select ERROR_NUMBER()) = 2627 --Violacion de PK
			THROW 50001, 'El usuario ingresado ya existe.',1
	END CATCH
END
go

CREATE PROCEDURE LOS_DE_GESTION.PR_ROLES_CLIENTE_Y_EMPRESA
AS BEGIN select * from LOS_DE_GESTION.Rol where id_Rol in(2,3) END
go

CREATE PROCEDURE LOS_DE_GESTION.PR_CAMBIAR_PASSWORD @username nvarchar(255), @password nvarchar(255)
AS
BEGIN
	UPDATE LOS_DE_GESTION.Usuario
	SET password = LOS_DE_GESTION.FN_HASHPASS(@password)
	WHERE username = @username
END
go

CREATE PROCEDURE LOS_DE_GESTION.PR_DAR_BAJA_USUARIO_POR_ADMIN @username nvarchar(255)
AS
BEGIN
	UPDATE LOS_DE_GESTION.Usuario
	SET habilitado = 0
	WHERE username = @username
END
go

CREATE PROCEDURE LOS_DE_GESTION.PR_VALIDAR_VENCIMIENTO_DE_PUNTOS @clienteUsername nvarchar(255), @fechaHoy datetime
AS
BEGIN
	declare @puntosAVencer int
	declare @fechaDeVencimiento datetime
	IF((select c.fecha_vencimiento_puntos from LOS_DE_GESTION.Cliente c where c.username = @clienteUsername) < @fechaHoy )
	BEGIN
		select @puntosAVencer = puntos_acum_validos, @fechaDeVencimiento = fecha_vencimiento_puntos from LOS_DE_GESTION.Cliente where username = @clienteUsername
		
		INSERT INTO LOS_DE_GESTION.Historial_puntos_vencidos
		(usuario_cliente, puntos_vencidos, fecha_de_vencimiento)
		VALUES(@clienteUsername, @puntosAVencer, @fechaDeVencimiento)		
	
		UPDATE LOS_DE_GESTION.Cliente
		SET puntos_vencidos = puntos_vencidos + @puntosAVencer,
			puntos_acum_validos = 0,
			fecha_vencimiento_puntos = DATEADD(year, 1 , @fechaDeVencimiento)
		WHERE username = @clienteUsername
	END
END
go

CREATE PROCEDURE LOS_DE_GESTION.PR_BUSCAR_USUARIOS @usernameFilter nvarchar(255)
AS
BEGIN
	select u.username from LOS_DE_GESTION.Usuario u where u.username like '%'+ @usernameFilter +'%'
END
go

CREATE PROCEDURE LOS_DE_GESTION.PR_ACTUALIZAR_USUARIO_MIGRADO @username nvarchar(255)
AS
BEGIN
	update LOS_DE_GESTION.Usuario set intentos_login = 0 where username = @username	
END
go

/*8. GENERAR PUBLICACION*/

CREATE PROCEDURE LOS_DE_GESTION.PR_TODOS_LOS_RUBROS
AS 
BEGIN
	select r.* from LOS_DE_GESTION.Rubro r
END
go

CREATE PROCEDURE LOS_DE_GESTION.PR_TODOS_LOS_GRADOS
AS 
BEGIN
	select g.* from LOS_DE_GESTION.Grado_Publicacion g
END
go

CREATE PROCEDURE LOS_DE_GESTION.PR_TODOS_LOS_ESTADOS
AS 
BEGIN
	select e.* from LOS_DE_GESTION.Estado_Publicacion e	
END
go

CREATE PROCEDURE LOS_DE_GESTION.PR_TODOS_LOS_TIPOS_DE_UBICACION
AS 
BEGIN
	select t.* from LOS_DE_GESTION.Tipo_Ubicacion t;
END
go

CREATE PROCEDURE LOS_DE_GESTION.PR_CREAR_PUBLICACION 
@descripcion nvarchar(255),
@fechaDePublicacion datetime,
@fechaVencimiento datetime,
@fechaHoraEspectaculo datetime,
@idRubro numeric(18,0),
@direccion nvarchar(255),
@idGradoPublicacion numeric(18,0),
@usuarioEmpresa nvarchar(255),
@idEstadoPublicacion numeric(18,0),
@codPublicacionNueva numeric(18,0) output
AS
BEGIN
	INSERT INTO LOS_DE_GESTION.Publicacion
	(descripcion, fecha_publicacion, fecha_vencimiento_publicacion, fecha_hora_espectaculo, id_Rubro, direccion_espectaculo, id_Grado_Publicacion, usuario_empresa_vendedora, id_Estado_Publicacion)
	VALUES(@descripcion, @fechaDePublicacion, @fechaVencimiento, @fechaHoraEspectaculo, @idRubro, @direccion, @idGradoPublicacion, @usuarioEmpresa, @idEstadoPublicacion)
	set @codPublicacionNueva = SCOPE_IDENTITY()
	return	
END
go

CREATE PROCEDURE LOS_DE_GESTION.PR_CREAR_UBICACIONES
@codPublicacion numeric(18,0),
@fila varchar(3),
@sinNumerar bit,
@cantidad int,
@precio numeric(18,0),
@idTipoUbicacion numeric(18,0)
AS
BEGIN
	declare @contador int
	set @contador = 1
	
	WHILE @contador <= @cantidad
	BEGIN
		IF @sinNumerar = 1
		BEGIN
			INSERT INTO LOS_DE_GESTION.Ubicacion
			(cod_publicacion, fila, asiento, ubicacion_sin_numerar, precio, id_Tipo_Ubicacion)
			VALUES(@codPublicacion, null, null, 1, @precio, @idTipoUbicacion)			
		END
		ELSE
		BEGIN
			INSERT INTO GD2C2018.LOS_DE_GESTION.Ubicacion
			(cod_publicacion, fila, asiento, ubicacion_sin_numerar, precio, id_Tipo_Ubicacion)
			VALUES(@codPublicacion, @fila, @contador, 0, @precio, @idTipoUbicacion)
		END
		set @contador = @contador+1
	END
END
go

/*12.CANJE Y ADMINISTRACION DE PUNTOS*/
CREATE PROCEDURE LOS_DE_GESTION.PR_TODOS_LOS_PREMIOS_DISPONIBLES
AS
BEGIN
	SELECT id_Premio, descripcion, puntos_requeridos
	FROM LOS_DE_GESTION.Premio
END
go

CREATE PROCEDURE LOS_DE_GESTION.PR_CANJEAR_PREMIO @username nvarchar(255), @idPremio numeric(18,0)
AS
BEGIN
	IF((select LOS_DE_GESTION.FN_CLIENTE_TIENE_PUNTOS_SUFICIENTES(@username, @idPremio)) = 1)
		BEGIN 
		INSERT INTO GD2C2018.LOS_DE_GESTION.Premio_Canjeado (id_premio, usuario_cliente, fecha_canje) VALUES(@idPremio, @username, getdate())
		
		UPDATE LOS_DE_GESTION.Cliente SET puntos_acum_validos = puntos_acum_validos - (select p.puntos_requeridos from LOS_DE_GESTION.Premio p where p.id_Premio = @idPremio)
		WHERE username = @username		
		END
	ELSE
		BEGIN
			THROW 50001, 'No posee los puntos suficientes para canjear el item seleccionado.', 1
		END
END
go

CREATE PROCEDURE LOS_DE_GESTION.PR_PUNTOS_DE_USUARIO @username nvarchar(255)
AS
BEGIN
	select username, puntos_acum_validos, fecha_vencimiento_puntos from LOS_DE_GESTION.Cliente where username = @username
END
go
/*14.LISTADO ESTADISTICO*/
CREATE PROCEDURE LOS_DE_GESTION.PR_CLIENTES_CON_MAS_COMPRAS @fechaDesde datetime, @fechaHasta datetime
AS
BEGIN
	select top 5 c.usuario_cliente_comprador as Cliente, e.razon_social as Empresa, count(*) as 'Cantidad de compras'
	from LOS_DE_GESTION.Compra c
	inner join LOS_DE_GESTION.Ubicacion u on u.id_Compra = c.id_Compra
	inner join LOS_DE_GESTION.Publicacion p on u.cod_publicacion = p.cod_publicacion
	inner join LOS_DE_GESTION.Empresa e on e.username = p.usuario_empresa_vendedora
	where c.fecha_compra between @fechaDesde and @fechaHasta
	group by c.usuario_cliente_comprador, e.razon_social
END
go

CREATE PROCEDURE LOS_DE_GESTION.PR_EMPRESAS_CON_MAS_LOCALIDADES_NO_VENDIDAS @fechaDesde datetime, @fechaHasta datetime, @fechaHoy datetime
AS
BEGIN
	select top 5 e.razon_social as Empresa, count(*) as 'Localidades no vendidas', (select descripcion from LOS_DE_GESTION.Grado_Publicacion where id_Grado_Publicacion = g.id_Grado_Publicacion) as 'Grado de publicacion' 
	from LOS_DE_GESTION.Empresa e
	inner join LOS_DE_GESTION.Publicacion p on p.usuario_empresa_vendedora = e.username
	inner join LOS_DE_GESTION.Grado_Publicacion g on g.id_Grado_Publicacion = p.id_Grado_Publicacion
	inner join LOS_DE_GESTION.Ubicacion u on u.cod_publicacion = p.cod_publicacion
	where p.fecha_publicacion < @fechaHoy and p.fecha_publicacion between @fechaDesde and @fechaHasta
	group by e.razon_social, g.id_Grado_Publicacion, year(p.fecha_publicacion), month(p.fecha_publicacion)
	order by year(p.fecha_publicacion), month(p.fecha_publicacion), g.id_Grado_Publicacion desc
END
go

CREATE PROCEDURE LOS_DE_GESTION.PR_CLIENTES_CON_MAS_PUNTOS_VENCIDOS @fechaDesde datetime, @fechaHasta datetime
AS
BEGIN
	select 1 as TODO
END
go

------------------------------MIGRACION-----------------------------------
 
CREATE PROCEDURE LOS_DE_GESTION.PR_MIGRACION
AS
BEGIN
/*si intentos_login -1 -> el usuario viene de migracion*/
/* inserto Usuarios de Empresas*/
		 insert into LOS_DE_GESTION.Usuario(username, password, intentos_login, bloqueado_login_fallidos, habilitado, id_Rol)
		 SELECT distinct Espec_Empresa_Mail,HashBytes('SHA2_256', Espec_Empresa_Cuit),-1, 0,1,3
		 FROM gd_esquema.Maestra
	
/* inserto Empresas*/
		 insert into LOS_DE_GESTION.Empresa(username,cuit, razon_social, fecha_creacion, mail, calle, nro_calle, nro_piso,depto, codigo_postal)
		 SELECT distinct Espec_Empresa_Mail,Espec_Empresa_Cuit,Espec_Empresa_Razon_Social, Espec_Empresa_Fecha_Creacion,Espec_Empresa_Mail,Espec_Empresa_Dom_Calle,
						 Espec_Empresa_Nro_Calle,Espec_Empresa_Piso,Espec_Empresa_Depto, Espec_Empresa_Cod_Postal
		 FROM gd_esquema.Maestra
	

/* inserto Usuarios de clientes*/
		 insert into LOS_DE_GESTION.Usuario(username, password, intentos_login, bloqueado_login_fallidos, habilitado, id_Rol)
		 SELECT distinct Cli_Dni,HashBytes('SHA2_256', convert(nvarchar(255), Cli_Dni)),-1, 0,1,2
		 FROM gd_esquema.Maestra where Cli_Dni is not NULL
	
/* inserto clientes*/
		 insert into LOS_DE_GESTION.Cliente(username,tipo_documento,numero_documento, apellido,nombre,fecha_nacimiento, mail,calle,nro_calle,nro_piso,depto,codigo_postal)
		 SELECT distinct Cli_Dni,'DNI',Cli_Dni, Cli_Apeliido,Cli_Nombre,Cli_Fecha_Nac,Cli_Mail, Cli_Dom_Calle,Cli_Nro_Calle,Cli_Piso, Cli_Depto,Cli_Cod_Postal
		 FROM gd_esquema.Maestra where Cli_Mail is not NULL
/*decision de implementacion*/
/* deshabilito Clientes con mismo mail*/
		 update LOS_DE_GESTION.Usuario
		 set habilitado = 0
		 where id_Rol = 2 and 
			   username in (SELECT a.numero_documento FROM LOS_DE_GESTION.Cliente a ,LOS_DE_GESTION.Cliente b 
							where  b.mail = a.mail and b.numero_documento != a.numero_documento )
  
/* inserto Estado Publicacion*/
		 insert into LOS_DE_GESTION.Estado_Publicacion(id_Estado_Publicacion,descripcion)
		 SELECT distinct 1, Espectaculo_Estado
		 FROM gd_esquema.Maestra

	insert into  LOS_DE_GESTION.Estado_Publicacion(id_Estado_Publicacion,descripcion) 
	values (2,'Borrador'), (3,'Finalizada')

/*decision de implementacion*/
/* inserto rubro vacio*/
	insert into  LOS_DE_GESTION.Rubro(id_Rubro,descripcion) 
	values (1,' ')

/*decision de implementacion*/ -- fecha_publicacion,id_Rubro,direccion_espectaculo,id_Grado_Publicacion estan en null y id_Estado_Publicacion,id_Rubro en 1
/* inserto Publicacion*/
		 insert into LOS_DE_GESTION.Publicacion(maestra_Espectaculo_Cod,descripcion,fecha_publicacion,fecha_vencimiento_publicacion,fecha_hora_espectaculo,id_Rubro,direccion_espectaculo,id_Grado_Publicacion,usuario_empresa_vendedora,id_Estado_Publicacion)
		 SELECT distinct Espectaculo_Cod, Espectaculo_Descripcion,null,Espectaculo_Fecha_Venc,Espectaculo_Fecha,1,null,null,Espec_Empresa_Mail,1
		 FROM gd_esquema.Maestra

/* inserto tipo_Ubicacion*/
		 insert into LOS_DE_GESTION.Tipo_Ubicacion(id_Tipo_Ubicacion,descripcion)
		 SELECT distinct Ubicacion_Tipo_Codigo, Ubicacion_Tipo_Descripcion
		 FROM gd_esquema.Maestra


/* inserto Ubicacion*/
		 insert into LOS_DE_GESTION.Ubicacion(fila,asiento,ubicacion_sin_numerar,precio)
		 SELECT distinct Ubicacion_Fila, Ubicacion_Asiento,Ubicacion_Sin_numerar,Ubicacion_Precio
		 FROM gd_esquema.Maestra

/* inserto rendicion*/
		 insert into LOS_DE_GESTION.Rendicion(id_Rendicion,importe_total_ventas,importe_comision_total,importe_rendicion_total,fecha_rendicion,usuario_empresa_a_rendir,forma_pago_a_empresa)
		 SELECT distinct Factura_Nro, null,null,Factura_Total,Factura_Fecha,Espec_Empresa_Mail,Forma_Pago_Desc
		 FROM gd_esquema.Maestra where Factura_Nro is not null

/* inserto Item_Rendicion*/
		 insert into LOS_DE_GESTION.Item_Rendicion(id_Rendicion,importe_venta,importe_comision,importe_rendicion,descripcion,cantidad_ubicaciones)
		 SELECT distinct Factura_Nro, null,null,Item_Factura_Monto,Item_Factura_Descripcion,Item_Factura_Cantidad
		 FROM gd_esquema.Maestra where Factura_Nro is not null


END
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
(14, 'Dar de baja un usuario'),
(15, 'Canje y administracion de puntos')--Admin
go

/*FUNCIONALIDADES DEL CLIENTE*/
INSERT INTO LOS_DE_GESTION.Rol_X_Funcionalidad (id_Rol, id_Funcionalidad) VALUES
(2, 9),
(2, 10),
(2, 13),
(2, 15)
go
/*FUNCIONALIDADES DE LA EMPRESA*/
INSERT INTO LOS_DE_GESTION.Rol_X_Funcionalidad (id_Rol, id_Funcionalidad) VALUES
(3, 7),
(3, 8),
(3, 13)
go
/*FUNCIONALIDADES DEL ADMINISTRADOR*/


/*PREMIOS*/
INSERT INTO GD2C2018.LOS_DE_GESTION.Premio
(descripcion, puntos_requeridos)
VALUES('Prueba', 500)
go

-----------------------GENERACION DE ADMINISTRADOR GENERAL----------------

-----------------------------TRIGGERS-------------------------------------
/*LOGIN*/
CREATE TRIGGER LOS_DE_GESTION.TRG_BLOQUEAR_USUARIO_POR_LOGIN_FALLIDO ON LOS_DE_GESTION.Usuario AFTER UPDATE
AS
BEGIN
	IF (select intentos_login from inserted)>3
		update LOS_DE_GESTION.Usuario set bloqueado_login_fallidos = 1 where username = (select username from inserted)
END
go


------------------------------FOREING KEYS---------------------------------
ALTER TABLE LOS_DE_GESTION.Premio_Canjeado ADD CONSTRAINT FK_Premio_Canjeado_Premio FOREIGN KEY ([id_premio]) REFERENCES [LOS_DE_GESTION].Premio
ALTER TABLE LOS_DE_GESTION.Premio_Canjeado ADD CONSTRAINT FK_Premio_Canjeado_Cliente FOREIGN KEY ([usuario_cliente]) REFERENCES [LOS_DE_GESTION].Cliente

ALTER TABLE LOS_DE_GESTION.Historial_puntos_vencidos ADD CONSTRAINT FK_Historial_puntos_vencidos_Cliente FOREIGN KEY ([usuario_cliente]) REFERENCES [LOS_DE_GESTION].Cliente

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

--select* from LOS_DE_GESTION.Cliente
--select* from LOS_DE_GESTION.Usuario
--select* from LOS_DE_GESTION.Tipo_Ubicacion
--select* from LOS_DE_GESTION.Rubro
--select* from LOS_DE_GESTION.Publicacion
--select* from LOS_DE_GESTION.Ubicacion
--select* from gd_esquema.Maestra

