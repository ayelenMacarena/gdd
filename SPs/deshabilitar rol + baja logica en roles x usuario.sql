create procedure deshabilitar_rol_final(@id numeric(18))
as
begin
	call deshabilitar_rol(@id)
	delete from LA_PETER_MACHINE.roles_usuario
	where rolu_id_rol=@id
end