create procedure LA_PETER_MACHINE.Controlar_Rol_Habilitado(@rol nvarchar(255),@rdo nvarchar(255) output)
as
begin
declare @hab bit
select @hab=rol_habilitado from LA_PETER_MACHINE.rol where @rol=rol_descripcion
	if(@hab=1)
	begin
	set @rdo='ok'
	end
	else
	
	set @rdo='rol deshabilitado'
end