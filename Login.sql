USE GD2C2018
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_Validar_login') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_Validar_login
go

IF OBJECT_ID(N'LOS_DE_GESTION.PR_FUNCIONALIDADES_DE_UN_ROL') IS NOT NULL
DROP PROCEDURE LOS_DE_GESTION.PR_Validar_login
go

IF OBJECT_ID(N'LOS_DE_GESTION.TRG_BLOQUEAR_USUARIO_POR_LOGIN_FALLIDO') IS NOT NULL
DROP TRIGGER LOS_DE_GESTION.TRG_BLOQUEAR_USUARIO_POR_LOGIN_FALLIDO
go

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
						update LOS_DE_GESTION.Usuario set intentos_login = intentos_login + 1--Ejecuta trigger
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



CREATE TRIGGER LOS_DE_GESTION.TRG_BLOQUEAR_USUARIO_POR_LOGIN_FALLIDO ON LOS_DE_GESTION.Usuario AFTER UPDATE
AS
BEGIN
	IF (select intentos_login from inserted)>3
		update LOS_DE_GESTION.Usuario set bloqueado_login_fallidos = 1 where username = (select username from inserted)
END
go

Create procedure LOS_DE_GESTION.PR_FUNCIONALIDADES_DE_UN_ROL @idRol decimal
AS BEGIN
	select f.* from LOS_DE_GESTION.Funcionalidad f inner join LOS_DE_GESTION.Rol_X_Funcionalidad rf on f.id_Funcionalidad = rf.id_Funcionalidad
	where rf.id_Rol = @idRol
END
go

exec LOS_DE_GESTION.PR_FUNCIONALIDADES
