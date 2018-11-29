------------- ABM Rol---------------
---------------ALTA---------------

CREATE PROCEDURE LOS_DE_GESTION.AltaRol
@nombreRol NVARCHAR(255),
@habilitado BIT
AS
	BEGIN
	IF(NOT EXISTS(SELECT nombre FROM LOS_DE_GESTION.Rol WHERE nombre = @nombreRol))
		BEGIN
			BEGIN TRANSACTION
				INSERT INTO LOS_DE_GESTION.Rol(nombre,habilitado)
				VALUES(@nombreRol,@habilitado)
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
@rolNombre NVARCHAR(255),
@funcionalidadRol NUMERIC(18,0)
AS
	BEGIN

	IF(NOT EXISTS(SELECT id_Funcionalidad FROM LOS_DE_GESTION.Rol_X_Funcionalidad WHERE id_Funcionalidad = @funcionalidadRol))
		BEGIN
			BEGIN TRANSACTION
				INSERT INTO LOS_DE_GESTION.Rol_X_Funcionalidad(id_Rol,id_Funcionalidad)
				VALUES ((SELECT id_Rol FROM LOS_DE_GESTION.Rol WHERE nombre=@rolNombre),@funcionalidadRol)
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
@nombreRol NUMERIC(18,0)
AS
	BEGIN
		UPDATE LOS_DE_GESTION.Usuario
		SET habilitado = 0
		WHERE id_Rol = (SELECT id_Rol FROM LOS_DE_GESTION.Rol WHERE nombre=@nombreRol)
	END
GO
---------------MODIFICACION---------------
CREATE PROCEDURE LOS_DE_GESTION.ModificarRol
@nombreRolAntiguo NVARCHAR(255),
@nombreRolNuevo NVARCHAR(255)
AS
	BEGIN
		UPDATE LOS_DE_GESTION.Rol
		SET nombre = @nombreRolNuevo
		WHERE id_Rol = (SELECT id_Rol FROM LOS_DE_GESTION.Rol WHERE nombre = @nombreRolAntiguo)
	END
GO

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
@rolNombre NVARCHAR(255),
@funcionalidad NUMERIC(18,0)
AS
	BEGIN
		DELETE LOS_DE_GESTION.Rol_X_Funcionalidad
		WHERE id_Rol = (SELECT id_Rol FROM LOS_DE_GESTION.Rol WHERE nombre=@rolNombre) AND id_Funcionalidad = @funcionalidad
	END
GO


---------------ABM USUARIOS---------------
---------------ALTA CLIENTE---------------

CREATE PROCEDURE LOS_DE_GESTION.AltaCliente
@username NVARCHAR(255),
@password NVARCHAR(255),
@rol NVARCHAR(255),
@nombre NVARCHAR(255),
@apellido NVARCHAR(255),
@tipo_documento NVARCHAR(255),
@nro_documento NUMERIC(18,0),
@cuil NVARCHAR(255),
@mail NVARCHAR(255),
@telefono NVARCHAR(50),
@direccion_calle NVARCHAR(255),
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
				AND NOT EXISTS(SELECT cuil FROM LOS_DE_GESTION.Cliente WHERE cuil = @cuil) AND SUBSTRING(@cuil,3,8) = @nro_documento)
			BEGIN
				IF(NOT EXISTS(SELECT username FROM LOS_DE_GESTION.Usuario WHERE username = @username))
				BEGIN
					INSERT INTO LOS_DE_GESTION.Cliente(username,nombre,apellido,tipo_documento,numero_documento,
						cuil,mail,telefono,calle,nro_piso,depto,localidad,codigo_postal,fecha_nacimiento,fecha_creacion,tarjeta)
					VALUES(@username,@password,@nombre,@apellido,@tipo_documento,@nro_documento,@cuil,@mail,@telefono,
						@direccion_calle,@numero_piso,@departamento,@localidad,@codigo_postal,@fecha_de_nacimiento,@fecha_de_creacion,@tarjeta)
					INSERT INTO LOS_DE_GESTION.Usuario(username,password,id_Rol)
					VALUES(@username,@password,@rol)
				END
				ELSE
					BEGIN
						RAISERROR('username ya existe!',16,1)
					END
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
@nombre NVARCHAR(255),
@apellido NVARCHAR(255),
@email NVARCHAR(255),
@tipo_documento NVARCHAR(255),
@nro_documento NUMERIC(18,0),
@cuil NVARCHAR(255),
@mail NVARCHAR(255),
@telefono NVARCHAR(50),
@dir_calle NVARCHAR(255),
@nro_piso NUMERIC(18,0),
@depto NVARCHAR(255),
@localidad NVARCHAR(255),
@codigo_postal NVARCHAR(255),
@fecha_nacimiento DATETIME,
@fecha_de_creacion DATETIME
AS
	BEGIN
		UPDATE LOS_DE_GESTION.Cliente
		SET nombre = @nombre,
			apellido = @apellido,
			numero_documento = @nro_documento,
			mail = @email,
			tipo_documento = @tipo_documento,
			cuil = @cuil,
			mail = @email,
			telefono = @telefono,
			calle = @dir_calle,
			nro_piso = @nro_piso,
			depto = @depto,
			localidad = @localidad,
			codigo_postal = @codigo_postal,
			fecha_nacimiento = @fecha_nacimiento,
			fecha_creacion = @fecha_de_creacion
	 WHERE numero_documento = @nro_documento
	END
GO

---------------ALTA EMPRESA---------------
CREATE PROCEDURE LOS_DE_GESTION.AltaEmpresa
@username NVARCHAR(255),
@pasword NVARCHAR(255),
@rol NVARCHAR(255),
@razon_social NVARCHAR(255),
@mail NVARCHAR(50),
@telefono NUMERIC(18,0),
@direccion_calle NUMERIC(18,0),
@codigo_postal NVARCHAR(50),
@ciudad NVARCHAR(255),
@cuit NVARCHAR(255)
AS
	BEGIN
	--falta validar el cuit 
		IF(NOT EXISTS(SELECT razon_social FROM LOS_DE_GESTION.Empresa WHERE razon_social=@razon_social)
			AND NOT EXISTS(SELECT cuit FROM Empresa WHERE cuit=@cuit) )
			BEGIN
				INSERT INTO LOS_DE_GESTION.Empresa(username,razon_social,mail,telefono,calle,codigo_postal,ciudad,cuit)
				VALUES(@username,@razon_social,@mail,@telefono,@direccion_calle,@codigo_postal,@ciudad,@cuit)

				INSERT INTO LOS_DE_GESTION.Usuario(username,id_Rol)
				VALUES(@username,@rol)
			END
		ELSE
			BEGIN
				RAISERROR('Error al crear usuario',16,1)
			END
	END

GO

---------------BAJA EMPRESA---------------
CREATE PROCEDURE LOS_DE_GESTION.BajaEmpresa
@razon_social NVARCHAR(255)
AS
	BEGIN
		UPDATE LOS_DE_GESTION.Usuario
		SET habilitado=0
		WHERE username=(SELECT username FROM LOS_DE_GESTION.Empresa WHERE razon_social = @razon_social)
	END
GO

---------------MODIFICACION EMPRESA---------------
CREATE PROCEDURE LOS_DE_GESTION.HabiltarEmpresa
@username NVARCHAR(255)
AS 
	BEGIN
		UPDATE LOS_DE_GESTION.Usuario
		SET habilitado = 1
		WHERE username=@username
	END
GO