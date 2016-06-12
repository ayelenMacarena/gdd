create procedure LA_PETER_MACHINE.listarVisibilidades
	as
	begin
		Select visi_cod,visi_precio,visi_porcentaje,visi_envio,visi_descripcion from LA_PETER_MACHINE.visibilidad
	end