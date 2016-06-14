create procedure LA_PETER_MACHINE.crearVisibilidad( @precio numeric(18,0), @porcentaje numeric(18,2), @envio bit, @descripcion nvarchar(255), @rdo nvarchar(255) output)
	as
	begin
		if not exists (select *
			from LA_PETER_MACHINE.visibilidad
			where visi_descripcion=@descripcion)
			begin
		insert into LA_PETER_MACHINE.visibilidad(visi_precio,visi_porcentaje,visi_envio,visi_descripcion) values(@descripcion,@porcentaje,@envio,@descripcion)
			set @rdo='ok'
			end
			else
			set @rdo='ya existe'
	end
