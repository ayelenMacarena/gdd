create procedure eliminar_funcionalidad(@id numeric(18))
as
begin
delete from LA_PETER_MACHINE.funcionalidad
	where func_id=@id
end