create procedure eliminar_funcionalidad_rol(@funcionalidad_id numeric(18),@rol_id numeric(18))
as
begin
delete from LA_PETER_MACHINE.funcionalidad_rol
	where furo_id_funcionalidad=@funcionalidad_id and furo_id_rol=@rol_id
end