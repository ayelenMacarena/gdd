create TRIGGER LA_PETER_MACHINE.TR_FinalizarPublicacionSinStock
ON LA_PETER_MACHINE.publicacion
AFTER UPDATE
AS
BEGIN
	declare @cantidad numeric (18,0),
			@publicacion numeric (18,0),
			@finalizado numeric (18,0)

	declare cPublicacion cursor for select publicacion_id, publ_cantidad from inserted 
	select @finalizado = estado_id from LA_PETER_MACHINE.estado where esta_descripcion = 'Finalizada'

	open cPublicacion
	fetch next from cPublicacion into @publicacion, @cantidad

	while @@FETCH_STATUS = 0
	begin
		if(@cantidad = 0)
			update LA_PETER_MACHINE.publicacion set publ_id_estado = @finalizado 
				from LA_PETER_MACHINE.publicacion where publicacion_id = @publicacion
		fetch next from cPublicacion into @publicacion, @cantidad
	end
	
	close cPublicacion
	deallocate cPublicacion
END;
GO	
	