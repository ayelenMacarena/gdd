create procedure LA_PETER_MACHINE.eliminar_funcionalidad_rol(@funcionalidad nvarchar(255),@rol nvarchar(255), @rdo nvarchar(255) output)
as
begin
declare @func_id numeric(18)
set @func_id=(select funcionalidad_id from LA_PETER_MACHINE.funcionalidad  where func_descripcion=@funcionalidad)
declare @rol_id numeric(18)
set @rol_id=(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion=@rol)
								
if  exists(select*
	from LA_PETER_MACHINE.funcionalidad_rol
	where furo_id_funcionalidad=@func_id and
								furo_id_rol=@rol_id)
								begin
								delete from LA_PETER_MACHINE.funcionalidad_rol where furo_id_funcionalidad=@func_id and furo_id_rol=@rol_id
								set @rdo='ok'
								end
								else
								set @rdo='El rol no tiene esa funcionalidad'
end
select * from LA_PETER_MACHINE.funcionalidad
select * from LA_PETER_MACHINE.rol