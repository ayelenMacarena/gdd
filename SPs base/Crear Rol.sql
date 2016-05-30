create procedure crearRol( @descripcion nvarchar(255))
	as
	begin
		if not exists (select *
			from LA_PETER_MACHINE.rol
			where rol_descripcion=@descripcion)
			begin
		insert into Rol(rol_descripcion,rol_habilitado) values(@descripcion,1)
			end
	end