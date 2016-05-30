create procedure habilitarRol(@id numeric(18))
as
begin
	update LA_PETER_MACHINE.rol
	set rol_habilitado=1
	where rol_id=@id
end