create procedure LA_PETER_MACHINE.deshabilitar_rol(@rol nvarchar(255),@rdo nvarchar(255))
as
begin
	declare @id_rol numeric(18)
	set @id_rol=(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion=@rol)
	if exists (select * from LA_PETER_MACHINE.rol where rol_id=@id_rol)
	begin
	update LA_PETER_MACHINE.rol
	set rol_habilitado=0
	where rol_id=@id_rol
	set @rdo='ok'
	delete from LA_PETER_MACHINE.funcionalidad_rol where furo_id_rol=@id_rol 
	end
	else
	set @rdo='no existe el rol'
end