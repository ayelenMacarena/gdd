create procedure agregar_funcionalidad_rol(@funcionalidad_id numeric(18),@rol_id numeric(18))
as
begin
if not exists(select*
	from LA_PETER_MACHINE.funcionalidad_rol
	where furo_id_fufncionalidad=@funcionalidad_id and furo_id_rol=@rol_id)
	begin
insert into LA_PETER_MACHINE.funcionalidad_rol(furo_id_funcionalidad,furo_id_rol)
	values(@funcionalidad_id,@rol_id)
	end
end