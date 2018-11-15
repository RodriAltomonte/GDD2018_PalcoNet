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

INSERT INTO GD2C2018.LOS_DE_GESTION.Estado_Publicacion
(id_Estado_Publicacion, descripcion)
VALUES(1, 'Borrador'),(2, 'Activa'),(3, 'Finalizada')

INSERT INTO GD2C2018.LOS_DE_GESTION.Grado_Publicacion
(id_Grado_Publicacion, descripcion, porcentaje_costo)
VALUES(1, 'Grado1', 10),(2, 'Grado2', 15),(3, 'Grado3', 20),(4, 'Grado4', 30.25)

INSERT INTO GD2C2018.LOS_DE_GESTION.Rubro
(id_Rubro, descripcion)
VALUES(1, 'Rubro1'),(2, 'Rubro2'),(3, 'Rubro3'),(4, 'Rubro4')

