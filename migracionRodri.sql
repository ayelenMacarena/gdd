create PROCEDURE LA_PETER_MACHINE.SP_Migracion
AS


--DOCUMENT-TYPE
		insert into LA_PETER_MACHINE.document_type(type_descripcion) values('DNI')
		insert into LA_PETER_MACHINE.document_type(type_descripcion) values('CI')
		insert into LA_PETER_MACHINE.document_type(type_descripcion) values('LR')


--CALIFICACION
DECLARE		@calif_id_vendedor numeric(18,0)

set @calif_id_vendedor = 1

--Declare C cursor For 
	
	--ESTO PRODRIA IR EN ID_VENDEDOR CUANDO ANDE
	--(select V.vendedor_id from LA_PETER_MACHINE.vendedor V where Publ_Empresa_Mail = vend_mail OR Publ_Cli_Mail = vend_mail)

	insert into LA_PETER_MACHINE.calificacion (calificacion_id, cali_valor, cali_detalle,cali_id_vendedor)
	select distinct Calificacion_Codigo, Calificacion_Cant_Estrellas, Calificacion_Descripcion, @calif_id_vendedor 
		from gd_esquema.Maestra
  		where Calificacion_Codigo is not NULL
		order by Calificacion_Codigo


--CLIENTE
DECLARE		@clie_id_tipo_doc numeric(18,0),
			@clie_fecha_creacion datetime,
			@clie_id_vendedor numeric(18,0)

set @clie_fecha_creacion = SYSDATETIME()
set @clie_id_tipo_doc = (select type_id from LA_PETER_MACHINE.document_type where type_descripcion = 'DNI')
set @clie_id_vendedor = 1
	
	insert into LA_PETER_MACHINE.cliente (clie_apellido, clie_nombre, clie_dni, clie_id_tipo_doc, clie_fecha_nac,
		clie_fecha_creacion, clie_id_vendedor)
	select Cli_Apeliido, Cli_Nombre, Cli_Dni, @clie_id_tipo_doc ,Cli_Fecha_Nac, @clie_fecha_creacion, @clie_id_vendedor
		from gd_esquema.Maestra
		where Cli_Dni is not null 
		group by Cli_Apeliido, Cli_Nombre, Cli_Dni, Cli_Fecha_Nac
		order by Cli_Dni


--FACTURA
	insert into LA_PETER_MACHINE.factura(fact_num, fact_fecha, fact_total, fact_forma_pago, fact_id_vendedor)
	select  Factura_Nro, Factura_Fecha, Factura_Total, Forma_Pago_Desc
		from gd_esquema.Maestra
		where Factura_Nro is not null
		group by Factura_Nro, Factura_Fecha, Factura_Total, Forma_Pago_Desc
		order by Factura_Nro


--ITEM_FACTURA
	insert into LA_PETER_MACHINE.item_factura(item_num_factura, item_cantidad, item_precio_unitario, item_id_publicacion)
	select Factura_Nro, Item_Factura_Cantidad, Item_Factura_Monto / Item_Factura_Cantidad
		from gd_esquema.Maestra
		where Factura_Nro is not null
		order by Factura_Nro

GO