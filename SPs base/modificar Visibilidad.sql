create procedure modificarVisibilidad(@codigo numeric(18,0), @precio numeric(18,0), @porcentaje numeric(18,2), @envio bit, @descripcion nvarchar(255))
as
begin
update LA_PETER_MACHINE.visibilidad
	set visi_precio=@precio, visi_porcentaje=@porcentaje, visi_envio=@envio, visi_descripcion=@descripcion
	where visi_cod=@codigo
end
