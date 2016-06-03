select * from gd_esquema.Maestra

exec LA_PETER_MACHINE.SP_Migracion

drop procedure LA_PETER_MACHINE.SP_Migracion

select * from LA_PETER_MACHINE.cliente
select * from LA_PETER_MACHINE.calificacion

GO



create PROCEDURE LA_PETER_MACHINE.SP_Migracion
AS


--DOCUMENT-TYPE
		insert into LA_PETER_MACHINE.document_type(type_descripcion) values('DNI')
		insert into LA_PETER_MACHINE.document_type(type_descripcion) values('CI')
		insert into LA_PETER_MACHINE.document_type(type_descripcion) values('LR')

--ROL
		insert into LA_PETER_MACHINE.rol(rol_descripcion,rol_habilitado) values('empresa',1)
		insert into LA_PETER_MACHINE.rol(rol_descripcion,rol_habilitado) values('cliente',1)
		insert into LA_PETER_MACHINE.rol(rol_descripcion,rol_habilitado) values('administrativo',1)
		
--FUNCIONALIDAD
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion) values('publicar')
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion) values('categorizar_publicacion')
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion) values('visibilidad')
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion) values('comprar_ofertar')
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion) values('historial_cliente')
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion) values('calificar')
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion) values('facturas_realizadas')
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion) values('listado_estadistico')
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion) values('administrar_usuario')
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion) values('administrar_rol')
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion) values('administrar_rubro')

--FUNCIONALIDAD_ROL
		-- Rol Admin
		insert into LA_PETER_MACHINE.funcionalidad_rol(furo_id_funcionalidad,furo_id_rol) 
		values((select funcionalidad_id from LA_PETER_MACHINE.funcionalidad where func_descripcion = 'administrar_usuario'),
				(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'administrativo'))

		insert into LA_PETER_MACHINE.funcionalidad_rol(furo_id_funcionalidad, furo_id_rol)
		values ((select funcionalidad_id from LA_PETER_MACHINE.funcionalidad where func_descripcion = 'administrar_rubro'),
			(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'administrativo'))

		insert into LA_PETER_MACHINE.funcionalidad_rol(furo_id_funcionalidad, furo_id_rol)
		values ((select funcionalidad_id from LA_PETER_MACHINE.funcionalidad where func_descripcion = 'administrar_rol'),
		(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'administrativo'))


			
-- Rol Cliente
		insert into LA_PETER_MACHINE.funcionalidad_rol(furo_id_funcionalidad, furo_id_rol) 
		values((select funcionalidad_id from LA_PETER_MACHINE.funcionalidad where func_descripcion = 'comprar_ofertar'),
				(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'cliente'))

		insert into LA_PETER_MACHINE.funcionalidad_rol(furo_id_funcionalidad, furo_id_rol)
			values ((select funcionalidad_id from LA_PETER_MACHINE.funcionalidad where func_descripcion = 'publicar'),
			(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'cliente'))

		insert into LA_PETER_MACHINE.funcionalidad_rol (furo_id_funcionalidad, furo_id_rol)
		values ((select funcionalidad_id from LA_PETER_MACHINE.funcionalidad where func_descripcion = 'calificar'),
		(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'cliente'))

		insert into LA_PETER_MACHINE.funcionalidad_rol (furo_id_funcionalidad, furo_id_rol)
		values ((select funcionalidad_id from LA_PETER_MACHINE.funcionalidad where func_descripcion = 'visibilidad'),
		(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'cliente'))

		insert into LA_PETER_MACHINE.funcionalidad_rol (furo_id_funcionalidad, furo_id_rol)
		values ((select funcionalidad_id from LA_PETER_MACHINE.funcionalidad where func_descripcion = 'historial_cliente'),
		(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'cliente'))
		
-- Rol Empresa
		
		insert into LA_PETER_MACHINE.funcionalidad_rol(furo_id_funcionalidad, furo_id_rol) 
		values((select funcionalidad_id from LA_PETER_MACHINE.Funcionalidad where func_descripcion = 'publicar'),
				(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'empresa'))

		insert into LA_PETER_MACHINE.funcionalidad_rol(furo_id_funcionalidad, furo_id_rol)
		values (( select funcionalidad_id from LA_PETER_MACHINE.funcionalidad where func_descripcion = 'visibilidad'),
		(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'empresa'))


--USUARIO (Empresa)
	declare @hash varbinary(20)
	select @hash = hashbytes('sha256','12345');

	insert into LA_PETER_MACHINE.usuario(usua_username, usua_password, usua_habilitado)
	select distinct Publ_Empresa_Mail, @hash, 1 from gd_esquema.Maestra
		where Publ_Empresa_Mail is not null
		group by Publ_Empresa_Mail

--USUARIO (Cliente)
	insert into LA_PETER_MACHINE.usuario(usua_username,usua_password,usua_habilitado, usua_intentos_login)
	select distinct Cli_Mail,@hash,1,0 from gd_esquema.Maestra
	where Cli_Mail is not null
	group by Cli_Mail

--PERSONA (Cliente)
	insert into LA_PETER_MACHINE.persona(pers_username, pers_mail, pers_domicilio_calle, pers_cod_postal, pers_habilitado,
		 pers_numero_calle, pers_piso, pers_depto)
	select distinct Cli_Mail, Cli_Mail, Cli_Dom_Calle, Cli_Cod_Postal, 1, Cli_Nro_Calle, Cli_Piso, Cli_Depto
	from gd_esquema.Maestra
	where Cli_Mail is not null
	group by Cli_Mail, Cli_Mail, Cli_Dom_Calle, Cli_Cod_Postal, Cli_Nro_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Depto


--PERSONA (Empresa)
	insert into LA_PETER_MACHINE.persona(pers_username, pers_mail, pers_domicilio_calle, pers_cod_postal, pers_habilitado,
		 pers_numero_calle, pers_piso, pers_depto)
	select Publ_Empresa_Mail, Publ_Empresa_Mail, Publ_Empresa_Dom_Calle, Publ_Empresa_Cod_Postal, 1, Publ_Empresa_Nro_Calle,
		Publ_Empresa_Piso, Publ_Empresa_Depto
	from gd_esquema.Maestra
	where Publ_Empresa_Mail is not null
	group by Publ_Empresa_Mail, Publ_Empresa_Dom_Calle, Publ_Empresa_Cod_Postal, Publ_Empresa_Nro_Calle,
		Publ_Empresa_Piso, Publ_Empresa_Depto


--CLIENTE
DECLARE		@clie_id_tipo_doc numeric(18,0)

set @clie_id_tipo_doc = (select type_id from LA_PETER_MACHINE.document_type where type_descripcion = 'DNI')
	
	insert into LA_PETER_MACHINE.cliente (clie_apellido, clie_nombre, clie_dni, clie_id_tipo_doc, clie_fecha_nac,
		clie_fecha_creacion, clie_id_vendedor)
	select Cli_Apeliido, Cli_Nombre, Cli_Dni, @clie_id_tipo_doc ,Cli_Fecha_Nac, SYSDATETIME(),
		(select pers_id from LA_PETER_MACHINE.persona where pers_mail = Cli_Mail)
		from gd_esquema.Maestra
		where Cli_Dni is not null 
		group by Cli_Apeliido, Cli_Nombre, Cli_Dni, Cli_Fecha_Nac, Cli_Mail


--RUBRO
insert into LA_PETER_MACHINE.rubro(rubr_descripcion_corta)
	select distinct Publicacion_Rubro_Descripcion from gd_esquema.Maestra


--EMPRESA
insert into LA_PETER_MACHINE.empresa(empr_razon_social,empr_cuit,empr_id_vendedor)
	select distinct Publ_Empresa_Razon_Social, Publ_Empresa_Cuit,
	(select pers_id from LA_PETER_MACHINE.persona where pers_mail = Publ_Empresa_Mail)
		from gd_esquema.Maestra
		where Publ_Empresa_Cuit is not null


--CALIFICACION
	insert into LA_PETER_MACHINE.calificacion (calificacion_id, cali_valor, cali_detalle,cali_id_vendedor)
	select distinct Calificacion_Codigo, Calificacion_Cant_Estrellas , Calificacion_Descripcion, (select pers_id from LA_PETER_MACHINE.persona where Publ_Empresa_Mail = pers_mail OR Publ_Cli_Mail = pers_mail) 
		from gd_esquema.Maestra
  		where Calificacion_Codigo is not NULL
		order by Calificacion_Codigo

	update LA_PETER_MACHINE.calificacion
	set cali_valor = 5 where cali_valor>5


--VISIBILIDAD
	
	set identity_insert LA_PETER_MACHINE.visibilidad ON

	insert into LA_PETER_MACHINE.visibilidad(visi_cod, visi_precio, visi_porcentaje, visi_descripcion, visi_envio)
		select distinct Publicacion_Visibilidad_Cod, Publicacion_Visibilidad_Precio, Publicacion_Visibilidad_Porcentaje, 
			Publicacion_Visibilidad_Desc, 1
		 from gd_esquema.Maestra
		 where Publicacion_Visibilidad_Cod is not null

	update LA_PETER_MACHINE.visibilidad set visi_envio=0 where visi_descripcion = 'Gratis'

	set identity_insert LA_PETER_MACHINE.visibilidad OFF


--ESTADO
	insert into LA_PETER_MACHINE.estado(esta_descripcion) values ('Pausada')
	insert into LA_PETER_MACHINE.estado(esta_descripcion) values ('Borrador')
	insert into LA_PETER_MACHINE.estado(esta_descripcion) values ('Activa')
	insert into LA_PETER_MACHINE.estado(esta_descripcion) values ('Finalizada')

	
--TIPO
	insert into LA_PETER_MACHINE.tipo(tipo_descripcion) values ('Compra Inmediata')
	insert into LA_PETER_MACHINE.tipo(tipo_descripcion) values ('Subasta')

--COSTO_ENVIO		
	insert into LA_PETER_MACHINE.costo_envio (cost_visibilidad_id)
	select distinct visi_cod from LA_PETER_MACHINE.visibilidad 
	update LA_PETER_MACHINE.costo_envio set cost_costo=100 where (select visi_cod from visibilidad where visi_descripcion='Oro')
	update LA_PETER_MACHINE.costo_envio set cost_costo=150 where (select visi_cod from visibilidad where visi_descripcion='Plata')
	update LA_PETER_MACHINE.costo_envio set cost_costo=180 where (select visi_cod from visibilidad where visi_descripcion='Bronce')
	update LA_PETER_MACHINE.costo_envio set cost_costo=70 where (select visi_cod from visibilidad where visi_descripcion='Platino')

--PUBLICACION

	set identity_insert LA_PETER_MACHINE.publicacion ON

	insert into LA_PETER_MACHINE.publicacion (publicacion_id, publ_descripcion, publ_precio, publ_cod_rubro,
		publ_id_vendedor, publ_id_estado, publ_fecha_inicio, publ_fecha_fin, publ_preguntas, publ_cantidad, publ_id_tipo,
		publ_envio_habilitado)
	select Publicacion_Cod, Publicacion_Descripcion, Publicacion_Precio,
		(select rubr_cod from LA_PETER_MACHINE.rubro where rubr_descripcion_corta = Publicacion_Rubro_Descripcion),
		(select pers_id from LA_PETER_MACHINE.persona where Publ_Empresa_Mail = pers_mail OR Publ_Cli_Mail = pers_mail),
		(select estado_id from LA_PETER_MACHINE.estado where Publicacion_Estado = 'Finalizada'),
		Publicacion_Fecha, Publicacion_Fecha_Venc, 1, Publicacion_Stock, 
		(select tipo_id from LA_PETER_MACHINE.tipo where Publicacion_Tipo = tipo_descripcion),0
		from gd_esquema.Maestra

	set identity_insert LA_PETER_MACHINE.publicacion OFF
	
	--Poner el costo
	update LA_PETER_MACHINE.publicacion set publ_costo = 
		publ_precio*(select visi_porcentaje from LA_PETER_MACHINE.visibilidad where publ_cod_visibilidad = visi_cod)
		+ (select cost_costo from LA_PETER_MACHINE.costo_envio where publ_cod_visibilidad=cost_visibilidad_id)*publ_envio_hablitado 
		+ (select visi_precio from LA_PETER_MACHINE.visibilidad where publ_cod_visibilidad = visi_cod)


--FACTURA

	set identity_insert LA_PETER_MACHINE.factura ON

	insert into LA_PETER_MACHINE.factura(fact_num, fact_fecha, fact_total, fact_forma_pago, fact_id_vendedor)
	select  Factura_Nro, Factura_Fecha, Factura_Total, Forma_Pago_Desc,
		(select pers_id from LA_PETER_MACHINE.persona where Publ_Empresa_Mail = pers_mail OR Publ_Cli_Mail = pers_mail)
		from gd_esquema.Maestra
		where Factura_Nro is not null
		group by Factura_Nro, Factura_Fecha, Factura_Total, Forma_Pago_Desc
		order by Factura_Nro

	set identity_insert LA_PETER_MACHINE.factura OFF


--ITEM_FACTURA
	insert into LA_PETER_MACHINE.item_factura(item_num_factura, item_cantidad, item_precio_unitario, item_id_publicacion)
	select Factura_Nro, Item_Factura_Cantidad, Item_Factura_Monto / Item_Factura_Cantidad,
		from gd_esquema.Maestra
		where Factura_Nro is not null
		order by Factura_Nro

GO