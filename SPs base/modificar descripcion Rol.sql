create procedure modificarDescripcionRol(@descripcion nvarchar(255),@id numeric(18))
as
begin
update LA_PETER_MACHINE.rol
	set rol_descripcion=@descripcion
	where rol_id=@id
end
