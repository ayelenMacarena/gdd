create procedure crear_funcionalidad(@descripcion nvarchar(255))
as
begin
if not exists(select *
				from LA_PETER_MACHINE.funcionalidad
				where func_descripcion=@descripcion)
	begin
	insert into LA_PETER_MACHINE.funcionalidad(func_descripcion)
	values(@descripcion)
	end
end