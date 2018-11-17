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

INSERT INTO GD2C2018.LOS_DE_GESTION.Tipo_Ubicacion
(id_Tipo_Ubicacion, descripcion, puntos_cliente_frecuente)
VALUES(1, 'Ubicacion A', 50),(2, 'Ubicacion B', 100),(3, 'Ubicacion C', 200)


INSERT INTO GD2C2018.LOS_DE_GESTION.Usuario
(username, password, intentos_login, bloqueado_login_fallidos, habilitado, id_Rol)
VALUES('empresa', 'pass', 0, 0, 1, 3)


INSERT INTO GD2C2018.LOS_DE_GESTION.Empresa
(username, razon_social, cuit, mail, telefono, calle, nro_calle, nro_piso, depto, localidad, codigo_postal, ciudad, fecha_creacion)
VALUES('empresa', 'asd', '123123', 'asdasd@mail.com', 123123, 'asdasd', 123, 1, '1', 'asdasd', '1231', 'asdasdasd asdasd', getdate())

declare @codPub numeric(18,0);
EXEC LOS_DE_GESTION.PR_CREAR_PUBLICACION 'nueva', getdate(), getdate(), getdate(), 1, 'asd',1,'empresa', 1 ,@codPub output
EXEC LOS_DE_GESTION.PR_CREAR_UBICACIONES @codPub, null, 1, 10, 1000,1

delete from LOS_DE_GESTION.Ubicacion
delete from LOS_DE_GESTION.Publicacion