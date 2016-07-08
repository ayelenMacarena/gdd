create TRIGGER LA_PETER_MACHINE.TR_AdjudicarSubasta
ON LA_PETER_MACHINE.publicacion
AFTER UPDATE
AS
BEGIN
	declare @publicacion numeric (18,0),
			@vendedor numeric (18,0),
			@cantidad numeric (18,0),
			@comprador nvarchar(255),
			@estado numeric (18,0),
			@valor numeric (18,0),
			@fechaFin datetime,
			@user numeric (18,0)


	declare cPublicacion2 cursor for select publicacion_id, publ_id_vendedor, publ_cantidad, publ_id_estado, publ_fecha_fin from inserted

	open cPublicacion2

	fetch next from cPublicacion2 into @publicacion, @vendedor, @cantidad, @estado, @fechaFin

	while @@FETCH_STATUS = 0
	begin
		if(@estado = 4)
		begin

			select TOP 1 @comprador = ofer_username, @valor = ofer_valor from LA_PETER_MACHINE.oferta 
				where ofer_id_publicacion = @publicacion 
				order by ofer_valor desc

			exec LA_PETER_MACHINE.SP_InsertarFactura_ComprarOfertar @publicacion, @fechaFin, @cantidad
			
			set @user = (select pers_id from LA_PETER_MACHINE.persona where pers_username = @comprador)

			exec LA_PETER_MACHINE.SP_EjecutarCompra_ComprarOfertar @publicacion, @cantidad, @user, @vendedor, @fechaFin

		end
		fetch next from cPublicacion2 into @publicacion, @vendedor, @cantidad, @estado, @fechaFin
	end

	close cPublicacion
	deallocate cPublicacion
end;	
GO