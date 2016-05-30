create procedure LA_PETER_MACHINE.LaPeterMachine
as

declare @dni numeric(18),
		@apellido nvarchar(255),
		@nombre nvarchar(255),
		@fecha_nac datetime,
		@mail nvarchar(255),
		@calle nvarchar(255),
		@calle_numero numeric(18),
		@piso numeric (18),
		@depto nvarchar(50),
		@cod_postal nvarchar(50),
		@empr_razon_social nvarchar(255),
		@empr_cuit nvarchar(50),
		@empr_fecha_creacion datetime,
		@empr_mail nvarchar(50),
		@empr_calle nvarchar(100),
		@empr_calle_numero numeric(18),
		@empr_piso numeric(18),
		@empr_dpto nvarchar(50),
		@empr_cod_postal nvarchar(50),
		@publ_cod numeric(18),
		@publ_descripcion nvarchar(255),
		@publ_stock numeric(18),
		@publ_fecha datetime,
		@publ_fecha_venc datetime,
		@publ_precio numeric(18,2),
		@publ_tipo varchar(255),
		@visi_cod numeric(18,2),
		@visi_desc varchar(255),
		@visi_precio numeric(18,2),
		@visi_porcentaje numeric(18,2),
		@publ_estado varchar(255),
		@rubr_descr nvarchar(255),
		@clie_dni numeric(18),
		@clie_apellido nvarchar(255),
		@clie_nombre nvarchar(255),
		@clie_fecha_nac datetime,
		@clie_mail nvarchar(255),
		@clie_calle nvarchar(255),
		@clie_calle_numero numeric(18),
		@clie_piso numeric(18),
		@clie_dpto nvarchar(50),
		@clie_cod_postal nvarchar(50),
		@comp_fecha datetime,
		@comp_cantidad numeric(18),
		@ofer_fecha datetime,
		@ofer_monto numeric(18,2),
		@cali_codigo numeric(18),
		@cali_cant_estrellas numeric(18),
		@cali_desc nvarchar(255),	
		@ifac_monto numeric(18,2),
		@ifac_cant numeric(18),
		@fact_nro numeric(18),
		@fact_fecha datetime,
		@fact_total numeric(18,2),
		@fact_pago_desc nvarchar(255)
		
		

declare C cursor for 
select *
from gd_esquema.Maestra

open C
fetch next from C into  @dni ,
		@apellido,
		@nombre ,
		@fecha_nac,
		@mail ,
		@calle ,
		@calle_numero ,
		@piso ,
		@depto ,
		@cod_postal ,
		@empr_razon_social ,
		@empr_cuit ,
		@empr_fecha_creacion ,
		@empr_mail ,
		@empr_calle ,
		@empr_calle_numero ,
		@empr_piso ,
		@empr_dpto,
		@empr_cod_postal ,
		@publ_cod ,
		@publ_descripcion,
		@publ_stock ,
		@publ_fecha,
		@publ_fecha_venc ,
		@publ_precio ,
		@publ_tipo ,
		@visi_cod ,
		@visi_desc ,
		@visi_precio ,
		@visi_porcentaje,
		@publ_estado ,
		@rubr_descr ,
		@clie_dni ,
		@clie_apellido ,
		@clie_nombre ,
		@clie_fecha_nac ,
		@clie_mail ,
		@clie_calle ,
		@clie_calle_numero ,
		@clie_piso ,
		@clie_dpto ,
		@clie_cod_postal ,
		@comp_fecha ,
		@comp_cantidad ,
		@ofer_fecha ,
		@ofer_monto , 
		@cali_codigo ,
		@cali_cant_estrellas ,
		@cali_desc ,	
		@ifac_monto ,
		@ifac_cant ,
		@fact_nro ,
		@fact_fecha ,
		@fact_total ,
		@fact_pago_desc

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

while @@FETCH_STATUS=0 begin

--RUBRO
	if @rubr_descr is not NULL and not exists (select * from LA_PETER_MACHINE.rubro where rubr_descripcion_corta = @rubr_descr)
		BEGIN
			insert into LA_PETER_MACHINE.rubro (rubr_descripcion_corta) 
			values (@rubr_descr)
		END

--CALIFICACION
	if @cali_codigo is not NULL and not exists (select * from LA_PETER_MACHINE.calificacion where calificacion_id = @cali_codigo)
		BEGIN
			insert into LA_PETER_MACHINE.calificacion (calificacion_id,cali_valor,cali_detalle) 
			values (@cali_codigo,@cali_cant_estrellas,@cali_desc)
		END

--CLIENTES (Usuario - Vendedor - Cliente)
	--USUARIO CLIENTE
		if @mail is not NULL and not exists (select * from LA_PETER_MACHINE.usuario where usua_username = SUBSTRING(@mail,0,19))
			BEGIN
	 			insert into LA_PETER_MACHINE.usuario (usua_username, usua_password, usua_habilitado) 
				values (SUBSTRING(@mail,0,19), '12345', 1)
	 			insert into LA_PETER_MACHINE.roles_usuario (rolu_id_rol, rolu_username) 
				values (2, SUBSTRING(@mail,0,19))
	 		END
	
	--VENDEDOR CLIENTE
		if @mail is not NULL and not exists (select * from LA_PETER_MACHINE.vendedor where vend_mail = @mail)
			BEGIN
				insert into LA_PETER_MACHINE.vendedor (vend_username, vend_mail, vend_domicilio_calle, vend_cod_postal, vend_habilitado, vend_numero_calle, vend_piso, vend_depto) 
				values (SUBSTRING(@mail,0,19), @mail, @calle, @cod_postal, 1, @calle_numero, @piso, @depto)
			END

	--CLIENTE
		-- ?????????????????????????????????????????????????????????????????????????????????

--EMPRESAS (Usuario - Vendedor - Empresa)
	--USUARIO EMPRESA
		if @empr_mail is not NULL and not exists (select * from LA_PETER_MACHINE.usuario where usua_username = SUBSTRING(@empr_mail,0,19))
			BEGIN
	 			insert into LA_PETER_MACHINE.usuario (usua_username, usua_password, usua_habilitado) 
				values (SUBSTRING(@empr_mail,0,19), '12345', 1)
	 			insert into LA_PETER_MACHINE.roles_usuario (rolu_id_rol, rolu_username) 
				values (3, SUBSTRING(@empr_mail,0,19))
	 		END

	--VENDEDOR EMPRESA
		if @empr_mail is not NULL and not exists (select * from LA_PETER_MACHINE.vendedor where vend_mail = @empr_mail)
			BEGIN
				insert into LA_PETER_MACHINE.vendedor (vend_username, vend_mail, vend_domicilio_calle, vend_cod_postal, vend_habilitado, vend_numero_calle, vend_piso, vend_depto) 
				values (SUBSTRING(@empr_mail,0,19), @empr_mail, @empr_calle, @empr_cod_postal, 1, @empr_calle_numero, @empr_piso, @empr_dpto)
			END

	--EMPRESA
	-- Esta tabla debe migrarse una vez esten migradas Rubro y Vendedor
		if @empr_razon_social is not NULL and not exists (select * from LA_PETER_MACHINE.empresa where empr_razon_social = @empr_razon_social)
			BEGIN
				insert into LA_PETER_MACHINE.empresa (empr_razon_social, empr_cuit, empr_cod_rubro, empr_id_vendedor) 
				values (@empr_razon_social, @empr_cuit, (select r.rubr_cod from LA_PETER_MACHINE.rubro r where r.rubr_descripcion_corta = @rubr_descr), (select v.vendedor_id from LA_PETER_MACHINE.vendedor v where v.vend_mail = @empr_mail OR v.vend_mail = @mail))
			END

--ESTADO
	if @publ_estado is not NULL and not exists (select * from LA_PETER_MACHINE.estado where esta_descripcion = @publ_estado)
		BEGIN
			insert into LA_PETER_MACHINE.estado (esta_descripcion) 
			values (@publ_estado)
		END

--TIPO
	if @publ_tipo is not NULL and not exists (select * from LA_PETER_MACHINE.tipo where tipo_descripcion = @publ_tipo)
		BEGIN
			insert into LA_PETER_MACHINE.tipo (tipo_descripcion) 
			values (@publ_tipo)
		END

--VISIBILIDAD
	if @visi_cod is not NULL and not exists (select * from LA_PETER_MACHINE.visibilidad where visi_cod = @visi_cod)
		BEGIN
			insert into LA_PETER_MACHINE.visibilidad (visi_cod, visi_descripcion, visi_envio, visi_porcentaje, visi_precio)
			values (@visi_cod, @visi_desc, (select case when @visi_precio > 60 then 1 else 0 end), @visi_precio, @visi_porcentaje)
		END

--PUBLICACION
	-- Esta tabla debe migrarse una vez esten migradas Rubro, Estado, Tipo, Vendedor y Empresa
	if @publ_cod is not NULL and not exists (select * from LA_PETER_MACHINE.publicacion where publicacion_id = @publ_cod)
		BEGIN
			insert into LA_PETER_MACHINE.publicacion (publicacion_id, publ_cantidad, publ_cod_rubro, publ_cod_visibilidad, publ_costo, publ_descripcion, publ_fecha_fin, publ_fecha_inicio, publ_id_estado, publ_id_tipo, publ_id_vendedor, publ_precio, publ_preguntas)
			values (@publ_cod, @publ_stock, (select r.rubr_cod from LA_PETER_MACHINE.rubro r where r.rubr_descripcion_corta = @rubr_descr), @visi_cod, @publ_precio, @publ_descripcion, @publ_fecha_venc, @publ_fecha, (select e.estado_id from LA_PETER_MACHINE.estado e where e.esta_descripcion = @publ_estado), (select t.tipo_id from LA_PETER_MACHINE.tipo t where t.tipo_descripcion = @publ_tipo), (select v.vendedor_id from LA_PETER_MACHINE.vendedor v where v.vend_mail = @empr_mail OR v.vend_mail = @mail), @publ_precio, 0)
		END

--COMPRA
	-- Esta tabla debe migrarse una vez esten migradas Factura Vendedor y Empresa
	if @comp_cantidad is not NULL and not exists (select * from LA_PETER_MACHINE.compra where comp_id_publicacion = @publ_cod)
		BEGIN
			insert into LA_PETER_MACHINE.compra (comp_id_publicacion, comp_id_vendedor, comp_id_comprador, comp_num_factura, comp_username)
			values (@publ_cod, (select v.vendedor_id from LA_PETER_MACHINE.vendedor v where v.vend_mail = @empr_mail OR v.vend_mail = @mail), (select v.vendedor_id from LA_PETER_MACHINE.vendedor v join LA_PETER_MACHINE.cliente c on c.clie_id_vendedor = vendedor_id where c.clie_dni = @clie_dni), (select f.fact_num from LA_PETER_MACHINE.factura f where f.fact_id_publicacion = @publ_cod), (select v.vend_username from LA_PETER_MACHINE.vendedor v join LA_PETER_MACHINE.cliente c on c.clie_id_vendedor = vendedor_id where c.clie_dni = @clie_dni))
		END

--OFERTA
	-- Esta tabla debe migrarse una vez esten migradas Vendedor
	if @ofer_monto is not NULL and not exists (select * from LA_PETER_MACHINE.oferta where ofer_valor = @ofer_monto)
		BEGIN
			insert into LA_PETER_MACHINE.oferta (ofer_id_publicacion, ofer_valor, ofer_username)
			values (@publ_cod, @ofer_monto, (select v.vend_username from LA_PETER_MACHINE.vendedor v join LA_PETER_MACHINE.cliente c on c.clie_id_vendedor = vendedor_id where c.clie_dni = @clie_dni))
		END


	fetch next from C into  @dni ,
		@apellido,
		@nombre ,
		@fecha_nac,
		@mail ,
		@calle ,
		@calle_numero ,
		@piso ,
		@depto ,
		@cod_postal ,
		@empr_razon_social ,
		@empr_cuit ,
		@empr_fecha_creacion ,
		@empr_mail ,
		@empr_calle ,
		@empr_calle_numero ,
		@empr_piso ,
		@empr_dpto,
		@empr_cod_postal ,
		@publ_cod ,
		@publ_descripcion,
		@publ_stock ,
		@publ_fecha,
		@publ_fecha_venc ,
		@publ_precio ,
		@publ_tipo ,
		@visi_cod ,
		@visi_desc ,
		@visi_precio ,
		@visi_porcentaje,
		@publ_estado ,
		@rubr_descr ,
		@clie_dni ,
		@clie_apellido ,
		@clie_nombre ,
		@clie_fecha_nac ,
		@clie_mail ,
		@clie_calle ,
		@clie_calle_numero ,
		@clie_piso ,
		@clie_dpto ,
		@clie_cod_postal ,
		@comp_fecha ,
		@comp_cantidad ,
		@ofer_fecha ,
		@ofer_monto , 
		@cali_codigo ,
		@cali_cant_estrellas ,
		@cali_desc ,	
		@ifac_monto ,
		@ifac_cant ,
		@fact_nro ,
		@fact_fecha ,
		@fact_total ,
		@fact_pago_desc
end
close C
deallocate C