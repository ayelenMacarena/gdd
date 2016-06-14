create procedure LA_PETER_MACHINE.calificar(@idCompra numeric(18,0), @valor numeric(5,0), @detalle nvarchar(100), @vendedorId numeric(18,0))
	as
	begin
		DECLARE @idCalificacion numeric(18,0);

		insert into LA_PETER_MACHINE.calificacion(cali_valor,cali_detalle,cali_id_vendedor) values(@valor,@detalle,@vendedorId)

		select @idCalificacion=calificacion_id from LA_PETER_MACHINE.calificacion where cali_valor = @valor and cali_detalle = @detalle and cali_id_vendedor = @vendedorId

		update LA_PETER_MACHINE.compra set comp_id_calificacion = @idCalificacion where compra_id = @idCompra

	end
