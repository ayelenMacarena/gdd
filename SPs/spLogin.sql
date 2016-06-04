create procedure LA_PETER_MACHINE.login(@username nvarchar(255), @pass nvarchar(20))
as 
declare @fails numeric(3)
declare @passEncontrada varbinary(20)
declare @habilitado bit


select @fails=usua_intentos_login, @passEncontrada = usua_password, @habilitado = usua_habilitado
	from LA_PETER_MACHINE.usuario u 
	where u.usua_username = @username

IF @passEncontrada is not Null and HASHBYTES('SHA256', @pass) = @passEncontrada 
	--Caso feliz, se encuentra el usuario y la contraseña es correcta
	begin
		if @habilitado = 1-- Verifico que esté habilitado, si lo está le seteo en 0 los intentos.
			update LA_PETER_MACHINE.usuario set usua_intentos_login = 0 
				where usua_username = @username;
	end
	
IF HASHBYTES('SHA256', @pass) != @passEncontrada 
--Error de password
	begin
		declare @failsFinales numeric(3) = @fails + 1;
		-- Le incremento los intentos fallidos
		update LA_PETER_MACHINE.usuario set usua_intentos_login = @failsFinales
			where usua_username = @username;
	end
	if @failsFinales >= 3
		-- Si los intentos fallidos son 3, deshabilito el usuario
		begin
			update LA_PETER_MACHINE.usuario set usua_habilitado = 0 
				where usua_username = @username;
		end
	
/* Devuelvo usuario habilitado y roles */

SELECT usua_habilitado, rol_descripcion
	FROM LA_PETER_MACHINE.usuario us, LA_PETER_MACHINE.roles_usuario ru , LA_PETER_MACHINE.rol rol
	WHERE us.usua_username = @username 
	and us.usua_username = ru.rolu_username
	and ru.rolu_id_rol = rol.rol_id;

GO