USE GD2C2018

INSERT INTO GD2C2018.LOS_DE_GESTION.Premio (descripcion, puntos_requeridos) VALUES
('PremioA', 100),
('PremioB', 50),
('PremioC', 1000)

select * from LOS_DE_GESTION.Usuario where username = 'user' and intentos_login = -1
update LOS_DE_GESTION.Usuario set intentos_login = -1 where username = 'user'

declare @loginCorrecto bit
exec LOS_DE_GESTION.PR_Validar_login 'user', 'pass1',@loginCorrecto
select @loginCorrecto