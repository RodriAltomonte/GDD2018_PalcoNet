USE [GD2C2018]
GO

CREATE PROCEDURE LOS_DE_GESTION.RolHabilitado
@idRol NUMERIC(18,0),
@estaHabilitado BIT OUTPUT
AS
BEGIN
	SELECT @estaHabilitado=habilitado FROM LOS_DE_GESTION.Rol WHERE id_Rol=@idRol
END
GO

------------- ABM Rol---------------
---------------ALTA---------------


CREATE PROCEDURE LOS_DE_GESTION.AltaRol
@nombreRol NVARCHAR(255),
@id_rol NUMERIC(18, 0),
@habilitado BIT
AS
	BEGIN
	IF(NOT EXISTS(SELECT nombre FROM LOS_DE_GESTION.Rol WHERE nombre = @nombreRol))
		BEGIN
			BEGIN TRANSACTION
				INSERT INTO LOS_DE_GESTION.Rol(nombre,habilitado,id_Rol)
				VALUES(@nombreRol,@habilitado,@id_rol)
			COMMIT TRANSACTION
		END
	ELSE
		BEGIN
			--THROW 50001, 'El rol ya existe!',1
			-- USO RAISERROR PORQUE THROW ME TIRA ERROR EN SQL SERVER 2008
			RAISERROR('El rol ya existe!',16,1)
		END
	END
GO

CREATE PROCEDURE LOS_DE_GESTION.FuncionalidadRol 
@id_Rol NVARCHAR(255),
@funcionalidadRol NUMERIC(18,0)
AS
	BEGIN

	IF(NOT EXISTS(SELECT id_Funcionalidad FROM LOS_DE_GESTION.Rol_X_Funcionalidad WHERE id_Funcionalidad = @funcionalidadRol))
		BEGIN
			BEGIN TRANSACTION
				INSERT INTO LOS_DE_GESTION.Rol_X_Funcionalidad(id_Rol,id_Funcionalidad)
				VALUES (@id_Rol,@funcionalidadRol)
			COMMIT TRANSACTION
		END

		ELSE 
			BEGIN
				RAISERROR('Funcionalidad existente para este rol',16,1)
			END
		
	END
GO


---------------BAJA---------------
CREATE PROCEDURE LOS_DE_GESTION.BajaRol
@id_Rol NUMERIC(18,0)
AS
	BEGIN	
		UPDATE LOS_DE_GESTION.Rol
		SET habilitado = 0
		WHERE id_Rol = @id_rol
	END
GO
---------------MODIFICACION---------------
CREATE PROCEDURE LOS_DE_GESTION.ModificarRol
@id_Rol NUMERIC(18,0),
@nombreRolNuevo NVARCHAR(255)
AS
	BEGIN
		UPDATE LOS_DE_GESTION.Rol
		SET nombre = @nombreRolNuevo
		WHERE id_Rol = @id_Rol
	END
GO
--ESTE ESTA DUPLICADO 
CREATE PROCEDURE LOS_DE_GESTION.AgregarFuncionalidad
@rolNombre NVARCHAR(255),
@funcionalidad NUMERIC(18,0)
AS
	BEGIN
		INSERT INTO LOS_DE_GESTION.Rol_X_Funcionalidad(id_Rol,id_Funcionalidad)
		VALUES((SELECT id_Rol FROM LOS_DE_GESTION.Rol WHERE nombre = @rolNombre),@funcionalidad)
	END
GO

CREATE PROCEDURE LOS_DE_GESTION.EliminarFuncionalidad
@id_rol NVARCHAR(255),
@funcionalidad NUMERIC(18,0)
AS
	BEGIN
		DELETE LOS_DE_GESTION.Rol_X_Funcionalidad
		WHERE id_Rol = @id_rol AND id_Funcionalidad=@funcionalidad
	END
GO

CREATE PROCEDURE LOS_DE_GESTION.HabilitarRol 
@id_Rol NUMERIC(18,0)
AS
BEGIN
	UPDATE LOS_DE_GESTION.Rol
	SET habilitado = 1
	WHERE id_Rol = @id_Rol
END
GO
---------------ABM USUARIOS---------------
---------------ALTA CLIENTE---------------

CREATE PROCEDURE LOS_DE_GESTION.AltaCliente
@habilitado BIT,
@username NVARCHAR(255),
@password NVARCHAR(255),
@id_rol NUMERIC(18,0),
@nombre NVARCHAR(255),
@apellido NVARCHAR(255),
@tipo_documento NVARCHAR(255),
@nro_documento NUMERIC(18,0),
@cuil NVARCHAR(255),
@mail NVARCHAR(255),
@telefono NVARCHAR(50),
@direccion_calle NVARCHAR(255),
@numero_calle NUMERIC(18,0),
@numero_piso NUMERIC(18,0),
@departamento NVARCHAR(255),
@localidad NVARCHAR(255),
@codigo_postal NVARCHAR(255),
@fecha_de_nacimiento DATETIME,
@fecha_de_creacion DATETIME,
@tarjeta NVARCHAR(255)
AS
	BEGIN
	
	IF(NOT EXISTS (SELECT username FROM LOS_DE_GESTION.Usuario WHERE username=@username))
		BEGIN
			INSERT INTO LOS_DE_GESTION.Usuario(username,password,habilitado,intentos_login,bloqueado_login_fallidos)
			VALUES(@username,@password,@habilitado,0,0)

			INSERT INTO LOS_DE_GESTION.Usuario_X_Rol(id_Rol,username)
			VALUES(@id_rol,@username)
		END
		ELSE
			BEGIN
				RAISERROR('Este username ya existe!',16,1)
		END

		IF(NOT EXISTS(SELECT numero_documento FROM LOS_DE_GESTION.Cliente WHERE numero_documento = @nro_documento)
				AND NOT EXISTS(SELECT cuil FROM LOS_DE_GESTION.Cliente WHERE cuil = @cuil) AND SUBSTRING(@cuil,3,9) = @nro_documento)
			BEGIN
				
					INSERT INTO LOS_DE_GESTION.Cliente(username,nombre,apellido,tipo_documento,numero_documento,
						cuil,mail,telefono,calle,nro_calle,nro_piso,depto,localidad,codigo_postal,fecha_nacimiento,fecha_creacion,tarjeta)
					VALUES(@username,@nombre,@apellido,@tipo_documento,@nro_documento,@cuil,@mail,@telefono,
						@direccion_calle,@numero_calle,@numero_piso,@departamento,@localidad,@codigo_postal,@fecha_de_nacimiento,@fecha_de_creacion,@tarjeta)
					
				END
			ELSE
				BEGIN
					RAISERROR('Numero de documento,cuil repetido o cuil incorrecto!',16,1)
				END
			
	END
GO

---------------BAJA CLIENTE---------------

CREATE PROCEDURE LOS_DE_GESTION.BajaCliente
@username NVARCHAR(255)
AS
	BEGIN
		UPDATE LOS_DE_GESTION.Usuario
		SET habilitado = 0
		WHERE username = @username
	END
GO

---------------MODIFICACION CLIENTE---------------

CREATE PROCEDURE LOS_DE_GESTION.HabilitarCliente
@username NVARCHAR(255)
AS
	BEGIN
		UPDATE LOS_DE_GESTION.Usuario
		SET habilitado = 1
		WHERE username=@username
	END
GO

CREATE PROCEDURE LOS_DE_GESTION.ModificacionPasswordCliente
@username NVARCHAR(255),
@password NVARCHAR(255)
AS
	BEGIN
		UPDATE LOS_DE_GESTION.Usuario
		SET password = @password
		WHERE username = @username
	END
GO

CREATE PROCEDURE LOS_DE_GESTION.ModificarCliente
@nro_documentoOriginal NUMERIC(18,0),
@cuil_original NVARCHAR(255),
@habilitado BIT,
@nombre NVARCHAR(255),
@apellido NVARCHAR(255),
@tipo_documento NVARCHAR(255),
@nro_documento NUMERIC(18,0),
@cuil NVARCHAR(255),
@mail NVARCHAR(255),
@telefono NVARCHAR(50),
@dir_calle NVARCHAR(255),
@nro_calle NUMERIC(18,0),
@nro_piso NUMERIC(18,0),
@depto NVARCHAR(255),
@localidad NVARCHAR(255),
@codigo_postal NVARCHAR(255),
@fecha_nacimiento DATETIME,
@fecha_de_creacion DATETIME,
@tarjeta NVARCHAR(255)
AS
	BEGIN
		IF(NOT EXISTS(SELECT cuil FROM LOS_DE_GESTION.Cliente WHERE cuil=@cuil AND cuil != @cuil_original) --Arreglar esto!
			AND NOT EXISTS(SELECT numero_documento FROM LOS_DE_GESTION.Cliente WHERE numero_documento=@nro_documento AND numero_documento!=@nro_documentoOriginal)
			AND SUBSTRING(@cuil,3,9) = @nro_documento)
			BEGIN
		UPDATE LOS_DE_GESTION.Cliente
		SET nombre = @nombre,
			apellido = @apellido,
			numero_documento = @nro_documento,
			tipo_documento = @tipo_documento,
			cuil = @cuil,
			mail = @mail,
			telefono = @telefono,
			calle = @dir_calle,
			nro_piso = @nro_piso,
			depto = @depto,
			localidad = @localidad,
			codigo_postal = @codigo_postal,
			fecha_nacimiento = @fecha_nacimiento,
			fecha_creacion = @fecha_de_creacion,
			tarjeta = @tarjeta	
	 WHERE numero_documento = @nro_documentoOriginal

	 UPDATE LOS_DE_GESTION.Usuario
	 SET habilitado = @habilitado
	 WHERE username = (SELECT username FROM LOS_DE_GESTION.Cliente WHERE numero_documento = @nro_documento)

	 END
	 ELSE
		BEGIN
			RAISERROR('Error al modificar cliente CUIL invalido o repetido!',16,1)
		END
	END
GO

---------------ALTA EMPRESA---------------
CREATE PROCEDURE LOS_DE_GESTION.AltaEmpresa
@habilitado BIT,
@username NVARCHAR(255),
@password NVARCHAR(255),
@rol NVARCHAR(255),
@razon_social NVARCHAR(255),
@mail NVARCHAR(50),
@telefono NUMERIC(18,0),
@direccion_calle NVARCHAR(255),
@nro_calle NUMERIC(18,0),
@codigo_postal NVARCHAR(50),
@ciudad NVARCHAR(255),
@cuit NVARCHAR(255)
AS
BEGIN
	
	IF(NOT EXISTS(SELECT username FROM LOS_DE_GESTION.Usuario WHERE username=@username))
		BEGIN
				INSERT INTO LOS_DE_GESTION.Usuario(username,password,habilitado,intentos_login,bloqueado_login_fallidos) --EXECUTE LOS_DE_GESTION.PR_ALTA_DE_USUARIO(args) 
				VALUES(@username,@password,@habilitado,0,0)

				INSERT INTO LOS_DE_GESTION.Usuario_X_Rol(username,id_Rol)
				VALUES(@username,@rol)
		END
		
		ELSE
		BEGIN
			RAISERROR('Este username ya existe',16,1)
		END
		
		IF(NOT EXISTS(SELECT razon_social FROM LOS_DE_GESTION.Empresa WHERE razon_social=@razon_social)
			AND NOT EXISTS(SELECT cuit FROM Empresa WHERE cuit=@cuit) AND LEN(@cuit) = 11 )
			BEGIN
				INSERT INTO LOS_DE_GESTION.Empresa(username,razon_social,mail,telefono,calle,nro_calle,codigo_postal,ciudad,cuit)
				VALUES(@username,@razon_social,@mail,@telefono,@direccion_calle,@nro_calle,@codigo_postal,@ciudad,@cuit)
			END
		ELSE
			BEGIN
				RAISERROR('Error al crear empresa revise los datos por favor!',16,1)
			END
END	
GO

---------------BAJA EMPRESA---------------
CREATE PROCEDURE LOS_DE_GESTION.BajaEmpresa
@username NVARCHAR(255)
AS
	BEGIN
		UPDATE LOS_DE_GESTION.Usuario
		SET habilitado=0
		WHERE username=@username
	END
GO

---------------MODIFICACION EMPRESA---------------
CREATE PROCEDURE LOS_DE_GESTION.HabilitarEmpresa
@username NVARCHAR(255)
AS 
	BEGIN
		UPDATE LOS_DE_GESTION.Usuario
		SET habilitado = 1
		WHERE username=@username
	END
GO

CREATE PROCEDURE LOS_DE_GESTION.ModificarPasswordEmpresa
@username NVARCHAR(255),
@passwordNuevo NVARCHAR(255)
AS
	BEGIN
		UPDATE LOS_DE_GESTION.Usuario
		SET password = @passwordNuevo
		WHERE username = @username
	END
GO

CREATE PROCEDURE LOS_DE_GESTION.ModificarEmpresa
@cuitOriginal NVARCHAR(255),
@razon_social NVARCHAR(255),
@mail NVARCHAR(255),
@telefono NUMERIC(18,0),
@direccion_calle NVARCHAR(50),
@numero_calle NUMERIC(18,0),
@nro_piso NUMERIC(18,0),
@depto NVARCHAR(50),
@localidad NVARCHAR(255),
@cod_postal NVARCHAR(50),
@ciudad NVARCHAR(255),
@cuit NVARCHAR(255)
AS
	BEGIN
	--falta comprobar que sea un cuit valido
		IF(NOT EXISTS(SELECT cuit FROM LOS_DE_GESTION.Empresa WHERE cuit = @cuit AND cuit != @cuitOriginal))
			BEGIN
				UPDATE LOS_DE_GESTION.Empresa
				SET razon_social = @razon_social,
					mail = @mail,
					telefono = @telefono,
					calle = @direccion_calle,
					nro_calle = @numero_calle,
					nro_piso = @nro_piso,
					depto = @depto,
					localidad = @localidad,
					codigo_postal = @cod_postal,
					ciudad = @ciudad,
					cuit = @cuit
				WHERE cuit = @cuitOriginal
			END
			ELSE
				BEGIN
					RAISERROR('Error al modificar empresa el cuit ya existe',16,1)
				END
	END
GO


-----PROCEDURES DE BUSQUEDA------
CREATE PROCEDURE LOS_DE_GESTION.ListadoClientes
@nombre NVARCHAR(255),
@apellido NVARCHAR(255),
@dni NUMERIC(18,0),
@mail NVARCHAR(255)
AS
BEGIN

	SELECT nombre,apellido,tipo_documento,
     numero_documento,cuil,mail,telefono,calle,nro_calle,
     nro_piso,depto,localidad,codigo_postal,
     fecha_nacimiento,fecha_creacion,tarjeta,username
     FROM LOS_DE_GESTION.Cliente
     WHERE nombre = @nombre OR @nombre IS NULL AND apellido = @apellido OR @apellido IS NULL
	 AND numero_documento = @dni OR @dni IS NULL AND mail=@mail OR @mail IS NULL

END
GO

CREATE PROCEDURE LOS_DE_GESTION.ListadoEmpresas
@razon_social NVARCHAR(255),
@CUIT NVARCHAR(255),
@mail NVARCHAR(50)
AS
BEGIN

	SELECT razon_social,mail,telefono,
    calle,nro_calle,depto,localidad,
    codigo_postal,ciudad,cuit,username
    FROM LOS_DE_GESTION.Empresa
    WHERE razon_social=@razon_social OR @razon_social IS NULL 
	AND cuit=@CUIT OR @CUIT IS NULL AND mail=@mail OR @mail IS NULL

END
GO
---PROCEDURES RENDICION-----

CREATE PROCEDURE LOS_DE_GESTION.CrearRendicion
@importe_total_ventas NUMERIC(18, 2),
@importe_comision_total NUMERIC(18, 2),
@importe_rendicion_total NUMERIC(18, 2),
@fecha_rendicion DATETIME,
@usuario_empresa_a_rendir NVARCHAR(255),
@forma_pago_a_empresa NVARCHAR(255)
AS
BEGIN


	INSERT INTO LOS_DE_GESTION.Rendicion(importe_total_ventas,importe_comision_total,importe_rendicion_total,
										fecha_rendicion,usuario_empresa_a_rendir,forma_pago_a_empresa)
	VALUES(@importe_total_ventas,@importe_comision_total,@importe_rendicion_total,@fecha_rendicion,@usuario_empresa_a_rendir,@forma_pago_a_empresa)


END
GO

CREATE PROCEDURE LOS_DE_GESTION.CrearItemRendicion
@id_Rendicion numeric(18, 0), -- FK
@importe_venta numeric(18, 2),
@importe_comision numeric(18, 2),
@importe_rendicion numeric(18, 2),
@descripcion nvarchar(60),
@cantidad_ubicaciones numeric(18, 0),
@id_Compra numeric(18, 0)
AS
BEGIN

	INSERT INTO LOS_DE_GESTION.Item_Rendicion(id_Rendicion,importe_venta,importe_comision,importe_rendicion,descripcion,cantidad_ubicaciones,
											id_Compra)
	VALUES(@id_Rendicion,@importe_venta,@importe_comision,@importe_rendicion,@descripcion,@cantidad_ubicaciones,@id_Compra)

END
GO

CREATE PROCEDURE LOS_DE_GESTION.ComprasDeEmpresa
@razon_social NVARCHAR(255),
@cantidad INT
AS
BEGIN
	SELECT TOP (@cantidad) * 
	FROM LOS_DE_GESTION.Compra c 
	JOIN LOS_DE_GESTION.Ubicacion u ON c.id_Compra = u.id_Compra
	JOIN LOS_DE_GESTION.Publicacion p ON u.cod_publicacion=p.cod_publicacion
	JOIN LOS_DE_GESTION.Empresa e ON p.usuario_empresa_vendedora=e.username 
	WHERE e.razon_social = @razon_social		 
END
GO

CREATE PROCEDURE LOS_DE_GESTION.NuevaCompra
@monto_total NUMERIC(18, 2),
@fecha_compra DATETIME,
@usuario_cliente_comprador nvarchar(255),
@tarjeta_comprador nvarchar(255),
@id_item_Rendicion numeric(18, 0),
@cantidad_ubicaciones numeric(18, 0)
AS
BEGIN
	INSERT INTO LOS_DE_GESTION.Compra(monto_total,fecha_compra,usuario_cliente_comprador,tarjeta_comprador,id_item_Rendicion,cantidad_ubicaciones)
	VALUES(@monto_total,@fecha_compra,@usuario_cliente_comprador,@tarjeta_comprador,@id_item_Rendicion,@cantidad_ubicaciones)
END
GO