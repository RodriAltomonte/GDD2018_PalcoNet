----------------------ABM ROL--------------------
----------------------ALTA-----------------------
CREATE PROCEDURE LOS_DE_GESTION.RolNuevo @RolNombre NVARCHAR(255)
AS
	BEGIN
		DECLARE @result AS NUMERIC(12)
			BEGIN TRAN rolnuevo
				BEGIN TRY
					IF(NOT EXISTS(SELECT nombre FROM LOS_DE_GESTION.Rol WHERE nombre=@RolNombre))
						BEGIN
							INSERT INTO LOS_DE_GESTION.Rol(nombre)
							VALUES (@RolNombre)
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
		INSERT INTO LOS_DE_GESTION.Rol_X_Funcionalidad(id_Rol,id_Funcionalidad)
		VALUES ((
					SELECT id_Rol
					FROM LOS_DE_GESTION.Rol
					WHERE nombre=@RolNombre),@FuncionalidadRol)
					SET @result = 1
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
--FALTA HACER ESTE NO SABIA HACERLO
--CREATE PROCEDURE LOS_DE_GESTION.BorrarRol @id_Rol NUMERIC(18,0)
--AS
--BEGIN



CREATE PROCEDURE LOS_DE_GESTION.BorrarFuncionalidades @RolNombre NVARCHAR(255)
AS
BEGIN 
DECLARE @result NUMERIC(12)
BEGIN TRAN delfuncs
BEGIN TRY
DELETE FROM LOS_DE_GESTION.Rol_X_Funcionalidad
WHERE id_Rol = (SELECT id_Rol FROM LOS_DE_GESTION.Rol WHERE nombre = @RolNombre)
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
