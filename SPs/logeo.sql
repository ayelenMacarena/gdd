create procedure ingreso(@usuario nvarchar(20),@password nvarchar(20))
as
begin
if exists(select *
			from LA_PETER_MACHINE.usuario
			where usua_username=@usuario and usua_password=@password)
			declare @roles table(rol_id numeric(18))
			begin
			insert into @roles
			select rolu_id_rol
				from LA_PETER_MACHINE.roles_usuario
				where rolu_username=@usuario
			declare @cant numeric(18)
				select @cant=count(*)
				from @roles
				if(@cant>1)
				begin
					--mostrar Roles para seleccionar
				else
					--seleccionar directamente el rol
				end
				--limpar intentos fallidos
else
--sumar 1 a intentos fallidos
end
end