create procedure eliminarVisibilidad(@codigo numeric(18,0))
as
begin 
	delete from LA_PETER_MACHINE.visibilidad
		where visi_cod=@codigo
	end