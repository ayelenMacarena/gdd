create procedure deshabilitar_rol(@id numeric(18))
as
begin
	update LA_PETER_MACHINE.rol
	set rol_habilitado=0
	where rol_id=@id
end