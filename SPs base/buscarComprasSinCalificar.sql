create procedure LA_PETER_MACHINE.buscarComprasSinCalificar(@username nvarchar(255))
	as
	begin
		select publ_descripcion, comp_id_vendedor, compra_id from LA_PETER_MACHINE.compra, LA_PETER_MACHINE.publicacion, LA_PETER_MACHINE.persona 
		where pers_username = @username and comp_id_vendedor = pers_id and publicacion_id = comp_id_publicacion and comp_id_calificacion is null
	end