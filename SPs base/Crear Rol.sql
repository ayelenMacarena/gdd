create procedure LA_PETER_MACHINE.crearRol( @descripcion nvarchar(255),@rdo nvarchar(255) output)
	as
	begin
		if not exists (select *
			from LA_PETER_MACHINE.rol
			where rol_descripcion=@descripcion)
			begin
		insert into LA_PETER_MACHINE.Rol(rol_descripcion,rol_habilitado) values(@descripcion,1)
			set @rdo='ok'
			end
			else
			set @rdo='ya existe'
	end
