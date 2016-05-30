create procedure eliminarRol(@id numeric(18))
as
begin 
	delete from LA_PETER_MACHINE.rol
		where rol_id=@id
	end