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
			IF(NOT EXISTS (SELECT username FROM LOS_DE_GESTION.Usuario WHERE username=@username))
				BEGIN
					INSERT INTO LOS_DE_GESTION.Usuario(username,password,id_Rol,habilitado,intentos_login)
					VALUES(@username,@password,@id_rol,@habilitado,0)
				END
			ELSE
				BEGIN
				RAISERROR('Este username ya existe!',16,1)
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
		IF(NOT EXISTS(SELECT cuil FROM LOS_DE_GESTION.Cliente WHERE cuil=@cuil) 
			AND NOT EXISTS(SELECT numero_documento FROM LOS_DE_GESTION.Cliente WHERE numero_documento=@nro_documento)
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
	--falta validar el cuit 
		IF(NOT EXISTS(SELECT razon_social FROM LOS_DE_GESTION.Empresa WHERE razon_social=@razon_social)
			AND NOT EXISTS(SELECT cuit FROM Empresa WHERE cuit=@cuit) )
			BEGIN
				INSERT INTO LOS_DE_GESTION.Empresa(username,razon_social,mail,telefono,calle,nro_calle,codigo_postal,ciudad,cuit)
				VALUES(@username,@razon_social,@mail,@telefono,@direccion_calle,@nro_calle,@codigo_postal,@ciudad,@cuit)
				
				INSERT INTO LOS_DE_GESTION.Usuario(username,id_Rol,habilitado)
				VALUES(@username,@rol,@habilitado)
			END
		ELSE
			BEGIN
				RAISERROR('Error al crear empresa',16,1)
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
		IF(NOT EXISTS(SELECT cuit FROM LOS_DE_GESTION.Empresa WHERE cuit=@cuit))
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
					RAISERROR('Error al modificar empresa',16,1)
				END
	END
GO