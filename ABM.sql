
----------------------ABM ROL--------------------
----------------------ALTA-----------------------
CREATE PROCEDURE LOS_DE_GESTION.RolNuevo @RolNombre NVARCHAR(255),@habilitado BIT
AS
	BEGIN
		DECLARE @result AS NUMERIC(12)
			BEGIN TRAN rolnuevo
				BEGIN TRY
					IF(NOT EXISTS(SELECT nombre FROM LOS_DE_GESTION.Rol WHERE nombre=@RolNombre))
						BEGIN
							INSERT INTO LOS_DE_GESTION.Rol(nombre,habilitado)
							VALUES (@RolNombre,@habilitado)
							SET @result =1
							END
					ELSE
						BEGIN
						SET @result = 0
						END
				SELECT @result AS resultado
				COMMIT TRAN rolnuevo
				END TRY

				BEGIN CATCH
				ROLLBACK TRAN rolnuevo
				SET @result = 2
				SELECT @result AS resultado
				END CATCH
				END
				GO

CREATE PROCEDURE LOS_DE_GESTION.RolFuncionalidades @RolNombre NVARCHAR(255),@FuncionalidadRol NUMERIC(18,0)
AS
	BEGIN
	DECLARE @result NUMERIC(12)
	BEGIN TRAN funcs
		BEGIN TRY 
		IF(NOT EXISTS(SELECT id_Funcionalidad FROM LOS_DE_GESTION.Rol_X_Funcionalidad WHERE id_Funcionalidad =@FuncionalidadRol))
		BEGIN
		INSERT INTO LOS_DE_GESTION.Rol_X_Funcionalidad(id_Rol,id_Funcionalidad)
		VALUES ((
					SELECT id_Rol
					FROM LOS_DE_GESTION.Rol
					WHERE nombre=@RolNombre),@FuncionalidadRol)
					SET @result = 1
		END
		ELSE
		BEGIN
		SET @result =0
		END
					SELECT @result AS resultado
					COMMIT TRAN funcs
		END TRY

		BEGIN CATCH
		ROLLBACK TRAN funcs
		SET @result = 0
		SELECT @result AS resultado
		END CATCH
	END
GO

-------------------------------------------BAJA---------------------------------------------
CREATE PROCEDURE LOS_DE_GESTION.BorrarRol @id_Rol NUMERIC(18,0)
AS
BEGIN
DECLARE @result NUMERIC(12)
BEGIN TRAN delrol
BEGIN TRY
UPDATE LOS_DE_GESTION.Rol
SET habilitado=0
WHERE nombre =@id_Rol
SET @result=1
SELECT @result as resultado
COMMIT TRAN delrol
END TRY
BEGIN CATCH
ROLLBACK TRAN delrol
SET @result = 0
SELECT @result AS resultado
END CATCH
END
GO

CREATE PROCEDURE LOS_DE_GESTION.BorrarFuncionalidades @RolNombre NVARCHAR(255)
AS
BEGIN 
DECLARE @result NUMERIC(12)
BEGIN TRAN delfuncs
BEGIN TRY
DELETE FROM LOS_DE_GESTION.Rol_X_Funcionalidad
WHERE id_Rol = @RolNombre
SET @result = 1
SELECT @result AS resultado
COMMIT TRAN delfuncs
END TRY

BEGIN CATCH
ROLLBACK TRAN delfuncs
SET @result =0
SELECT @result AS resultado
END CATCH

END
GO



--------------------MODIFICACION------------------------------------
CREATE PROCEDURE LOS_DE_GESTION.ModificarRol @RolNombreAntiguo NVARCHAR(255),@RolNombreNuevo NVARCHAR(255),@habilitado BIT
AS
BEGIN
DECLARE @result NUMERIC(12)
BEGIN TRAN modrol
BEGIN TRY
IF(NOT EXISTS(SELECT nombre FROM LOS_DE_GESTION.Rol WHERE nombre=@RolNombreNuevo) OR @RolNombreAntiguo=@RolNombreNuevo)
BEGIN
UPDATE LOS_DE_GESTION.Rol
SET nombre = @RolNombreNuevo
WHERE nombre =@RolNombreAntiguo
SET @result = 1
END
ELSE
BEGIN 
SET @result = 2
END
SELECT @result AS resultado
COMMIT TRAN modrol
END TRY
BEGIN CATCH
ROLLBACK TRAN modrol
SET @result = 0;
SELECT @result AS resultado
END CATCH
END
GO

--CREATE PROCEDURE ModificarFuncionalidad @id_funcionalidad NUMERIC(18,0)
--AS


-------------------------------ABM USUARIOS----------------------------------------
------------------------------ALTA CLIENTE------------------------------------------------
CREATE PROCEDURE LOS_DE_GESTION.NuevoCliente
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
DECLARE @result NUMERIC(12)
DECLARE @fecha_nacimiento DATETIME
DECLARE @fecha_de_creac DATETIME
SET @fecha_nacimiento = CONVERT(DATETIME,@fecha_de_nacimiento,121)
SET @fecha_de_creac = CONVERT(DATETIME,@fecha_de_creacion,121)
BEGIN TRAN nuclie

BEGIN TRY 
		IF(@nro_documento NOT IN (SELECT numero_documento FROM LOS_DE_GESTION.Cliente WHERE username = @username)
			AND @cuil NOT IN (SELECT cuil FROM LOS_DE_GESTION.Cliente WHERE @cuil=cuil))
			BEGIN 
				INSERT INTO LOS_DE_GESTION.Cliente(username,nombre,apellido,tipo_documento,numero_documento,
				cuil,mail,telefono,calle,nro_piso,depto,localidad,codigo_postal,fecha_nacimiento,fecha_creacion,tarjeta)
				VALUES (@username,@nombre,@apellido,@tipo_documento,@nro_documento,@cuil,@mail,@telefono,
				@direccion_calle,@numero_piso,@departamento,@localidad,@codigo_postal,@fecha_nacimiento,@fecha_creac,@tarjeta)


				INSERT INTO LOS_DE_GESTION.Usuario(username,password,id_Rol)
				VALUES (@username,@password,(SELECT id_Rol FROM LOS_DE_GESTION.Rol WHERE nombre =@rol))
				SET @result=1
			END

			ELSE
			BEGIN 
			SET @result = 0
			END
SELECT @result AS resultado
COMMIT TRAN nuclie
END TRY

BEGIN CATCH
ROLLBACK TRAN nuclie
SET @result = 2
SELECT @result AS resultado
END CATCH

END
GO



-----------------------ALTA EMPRESA-------------
CREATE PROCEDURE LOS_DE_GESTION.NuevaEmpresa
@username NVARCHAR(255),
@pasword NVARCHAR(255),
@rol NVARCHAR(255),
@razon_social NVARCHAR(255),
@mail NVARCHAR(50),
@telefono NUMERIC(18,0),
@direccion_calle NUMERIC(18,0),
@codigo_postal NVARCHAR(50),
@ciudad NVARCHAR(255),
@ciut NVARCHAR(255)

AS 
BEGIN
DECLARE @result NUMERIC(12)
BEGIN TRAN nuemp
BEGIN TRY
IF(@username NOT IN (SELECT username FROM LOS_DE_GESTION.Usuario WHERE username = @username)) --MODIFICAR ESTO
BEGIN 
INSERT INTO LOS_DE_GESTION.Empresa(username,razon_social,cuit,mail,telefono,calle,codigo_postal,ciudad)
VALUES (@username,@razon_social,@ciut,@mail,@telefono,@direccion_calle,@codigo_postal,@ciudad)

INSERT INTO LOS_DE_GESTION.Usuario(username,password,id_Rol)
VALUES(@username,@pasword,(SELECT id_rol FROM LOS_DE_GESTION.Rol WHERE nombre = @rol))


SET @result = 1
END
ELSE 
BEGIN
SET @result =0
END
SELECT @result AS resultado
COMMIT TRAN nuemp
END TRY

BEGIN CATCH
ROLLBACK TRAN nuemp
SET @result = 2
SELECT @result AS resultado
END CATCH
END
GO



---------------------------BAJA CLIENTE--------------------
CREATE PROCEDURE LOS_DE_GESTION.BorrarCliente
@nombre NVARCHAR(255)=NULL,
@apellido NVARCHAR(255)=NULL,
@dni NVARCHAR(255)=NULL,
@email NVARCHAR(255)=NULL
AS
BEGIN
DECLARE @result NUMERIC(12)
BEGIN TRAN delclie
BEGIN TRY
UPDATE LOS_DE_GESTION.Usuario
set habilitado = 0
WHERE username = (SELECT username FROM LOS_DE_GESTION.Cliente
				  WHERE nombre=@nombre OR @nombre IS NULL AND apellido = @apellido OR @apellido IS NULL
				  AND SUBSTRING(cuil,3,10) = @dni OR @dni IS NULL)
SET @result =1
SELECT @result AS resultado
COMMIT TRAN delclie
END TRY

BEGIN CATCH
ROLLBACK TRAN delclie
SET @result = 0
SELECT @result AS resultado
END CATCH
END
GO



-------------------------BAJA EMPRESA--------------------------
CREATE PROCEDURE LOS_DE_GESTION.BorrarEmpresa
@razon_social NVARCHAR(255)=NULL,
@cuit NVARCHAR(255)=NULL,
@email NVARCHAR(50)=NULL

AS 
BEGIN
DECLARE @result NUMERIC(12)
BEGIN TRAN delemp
BEGIN TRY
UPDATE LOS_DE_GESTION.Usuario
SET habilitado=0
WHERE username = (SELECT username from LOS_DE_GESTION.Empresa WHERE razon_social = @razon_social 
				 OR @razon_social IS NULL AND cuit = @cuit OR @cuit IS NULL
				 AND mail = @email OR @email IS NULL )

SET @result = 1
SELECT @result AS resultado
COMMIT TRAN delemp
END TRY

BEGIN CATCH
ROLLBACK TRAN delemp
SET @result = 2
SELECT @result AS resultado
END CATCH

END
GO


--------------------MODIFICACION CLIENTE----------------------------
CREATE PROCEDURE LOS_DE_GESTION.ModificarPasswordCliente @username NVARCHAR(255),@passwordNuevo NVARCHAR(255)
AS
BEGIN
DECLARE @result NUMERIC(12)
BEGIN TRAN modpass
BEGIN TRY 
UPDATE LOS_DE_GESTION.Usuario
SET password = @passwordNuevo
WHERE username = @username

SET @result = 1
SELECT @result AS resultado
COMMIT TRAN modpass
END TRY
BEGIN CATCH
ROLLBACK TRAN modpass
SET @result= 0
SELECT @result AS resultado
END CATCH
END
GO


CREATE PROCEDURE LOS_DE_GESTION.ModificarCliente
@nombre NVARCHAR(255)=NULL,
@apellido NVARCHAR(255)=NULL,
@dni NVARCHAR(255)=NULL,
@email NVARCHAR(255)=NULL,
@password NVARCHAR(255),
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
DECLARE @result NUMERIC(12)
BEGIN TRAN modclie
BEGIN TRY
UPDATE LOS_DE_GESTION.Cliente 
SET nombre =@nombre,
	apellido = @apellido,
	cuil =@cuil,
	mail = @email,
	tipo_documento=@tipo_documento,
	numero_documento=@nro_documento,
	telefono=@telefono,
	calle=@dir_calle,
	nro_piso=@nro_piso,
	depto=@depto,
	localidad=@localidad,
	codigo_postal=@codigo_postal,
	fecha_nacimiento= @fecha_nacimiento,
	fecha_creacion=@fecha_de_creacion

WHERE nombre = @nombre OR @nombre IS NULL AND apellido=@apellido OR @apellido IS NULL AND cuil=@cuil OR @cuil IS NULL
AND mail=@mail OR @mail IS NULL
COMMIT TRAN modclie
END TRY

BEGIN CATCH
ROLLBACK TRAN modclie
SET @result = 1
SELECT @result AS resultado
END CATCH
END
GO


-------------------MODIFICACION EMPRESA------------------------

CREATE PROCEDURE LOS_DE_GESTION.ModificarPasswordEmpresa @username NVARCHAR(255),@passwordNuevo NVARCHAR(255)
AS
BEGIN

DECLARE @result NUMERIC(12)
BEGIN TRAN modpass
BEGIN TRY

UPDATE LOS_DE_GESTION.Usuario
SET password = @passwordNuevo
WHERE username = @username

SET @result = 1
SELECT @result AS resultado
COMMIT TRAN modpass
END TRY
BEGIN CATCH
ROLLBACK TRAN modpass
SET @result= 0
SELECT @result AS resultado
END CATCH
END
GO

CREATE PROCEDURE LOS_DE_GESTION.ModificarEstadoEmpresa
@razon_social NVARCHAR(255)=NULL,
@cuit NVARCHAR(255)=NULL,
@email NVARCHAR(255)=NULL,
@habilitado BIT

AS
BEGIN
DECLARE @result NUMERIC(12)
BEGIN TRAN modemp
BEGIN TRY

UPDATE LOS_DE_GESTION.Usuario
SET habilitado = @habilitado
WHERE username = (SELECT username FROM Empresa WHERE razon_social=@razon_social OR @razon_social IS NULL
													AND cuit = @cuit OR @cuit IS NULL AND mail = @email OR @email IS NULL)


COMMIT TRAN modemp
END TRY

BEGIN CATCH
ROLLBACK TRAN modemp

END CATCH
END
GO


-----------------------ABM PUBLICACION--------------------
-----------------------ALTA------------------------------
/*
CREATE PROCEDURE LOS_DE_GESTION.NuevaPublicacion 
@descripcion NVARCHAR(255),
@fecha_publicacion DATETIME,
@fecha_hora_espectaculo DATETIME,
@rubro NUMERIC(18,0),
@direccion_espectaculo NVARCHAR(255),
@grado_publicacion NUMERIC(18,0),
@usuario_responsable NVARCHAR(255),
@estado_publicacion NUMERIC(18,0)

AS
BEGIN

BEGIN TRAN pub
BEGIN TRY


END 
GO
---------------------BAJA----------------------------------
CREATE PROCEDURE LOS_DE_GESTION.BorrarPublicacion



--------------------MODIFICACION----------------------------
CREATE PROCEDURE LOS_DE_GESTION.ModificarPublicacion
*/