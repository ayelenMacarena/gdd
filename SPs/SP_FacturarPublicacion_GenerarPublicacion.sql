CREATE PROCEDURE LA_PETER_MACHINE.SP_FacturarPublicacion_GenerarPublicacion
(@visibilidad nvarchar(255), @usuario nvarchar(255), @publicacion int)
AS
BEGIN
	declare @total numeric(18,2),
			@idVendedor numeric(18,0),
			@fecha datetime

	set @fecha = GETDATE()	
	select @total = visi_precio from LA_PETER_MACHINE.visibilidad where visi_descripcion = @visibilidad
	select @idVendedor = pers_id from LA_PETER_MACHINE.persona where pers_username = @usuario

	if (not exists (select * from LA_PETER_MACHINE.item_factura where item_id_publicacion = @publicacion))
	begin
	insert into LA_PETER_MACHINE.factura (fact_fecha, fact_total, fact_forma_pago, fact_id_vendedor)
								values (@fecha, @total, 'Efectivo', @idVendedor)
	
	declare @numeroFactura numeric(18,0)

	select @numeroFactura = fact_num from LA_PETER_MACHINE.factura where fact_fecha = @fecha and fact_total = @total and fact_id_vendedor = @idVendedor

	insert into LA_PETER_MACHINE.item_factura (item_num_factura, item_id_publicacion, item_cantidad, item_precio_unitario)
								values (@numeroFactura, @publicacion, 1, @total)

	end
END
GO
