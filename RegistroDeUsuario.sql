IF OBJECT_ID(N'LOS_DE_GESTION.PR_ALTA_DE_USUARIO') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_ALTA_DE_USUARIO

CREATE PROCEDURE LOS_DE_GESTION.PR_ALTA_DE_USUARIO @username nvarchar(255), @password nvarchar(255), @idRol numeric(18,0)
AS
BEGIN
	BEGIN TRY
		INSERT INTO GD2C2018.LOS_DE_GESTION.Usuario
		(username, password, intentos_login, bloqueado_login_fallidos, habilitado, id_Rol)
		VALUES(@username, LOS_DE_GESTION.FN_HASHPASS(@password), 0, 0, 1, @idRol)
	END TRY
	BEGIN CATCH
		IF (select ERROR_NUMBER()) = 2627
			THROW 50001, 'El usuario ingresado ya existe.',1
	END CATCH
END
go

use master
select * from sysmessages
where description like '%duplicate%'

use master
select * from sysmessages
where error = 2627