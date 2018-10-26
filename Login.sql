USE GD2C2018

CREATE PROCEDURE LOS_DE_GESTION.PR_Validar_login @username nvarchar(255), @password nvarchar(255),@loginCorrecto bit OUTPUT
AS 
BEGIN
	DECLARE @estaHabilitado bit
	DECLARE @estaBloqueadoPorLoginFallido bit
	SET NOCOUNT ON
	
	IF NOT EXISTS (select * from LOS_DE_GESTION.Usuario where username = @username)
		BEGIN
			THROW 50001, 'El username o password no existe',1
		END
	ELSE
		BEGIN
			--Password incorrecto
			IF NOT EXISTS(select * from LOS_DE_GESTION.Usuario where username = @username and password = LOS_DE_GESTION.FN_HASHPASS(@password))
				BEGIN
					BEGIN TRAN;
						update LOS_DE_GESTION.Usuario set intentos_login = intentos_login + 1--Ejecuta trigger
					COMMIT TRAN;
					THROW 50001, 'El username o password no existe',1
				END
			ELSE --Password valido
				BEGIN
					select @estaHabilitado = u.habilitado, @estaBloqueadoPorLoginFallido = u.bloqueado_login_fallidos
					from LOS_DE_GESTION.Usuario u where u.username = @username
					
					IF (@estaHabilitado = 0) 
						BEGIN
							THROW 50002, 'El usuario fue deshabilitado por el administrador.',1
						END
					ELSE IF (@estaBloqueadoPorLoginFallido = 1) 
						BEGIN
							THROW 50003, 'El usuario fue deshabilitado por exceder la cantidad de intentos de login.',1
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

CREATE TRIGGER LOS_DE_GESTION.TRG_BLOQUEAR_USUARIO_POR_LOGIN_FALLIDO ON LOS_DE_GESTION.Usuario AFTER UPDATE
AS
BEGIN
	IF (select intentos_login from inserted)>3
		update LOS_DE_GESTION.Usuario set bloqueado_login_fallidos = 1 where username = (select username from inserted)
END


