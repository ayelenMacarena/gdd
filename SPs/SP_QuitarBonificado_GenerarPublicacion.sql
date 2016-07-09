CREATE PROCEDURE LA_PETER_MACHINE.SP_QuitarBonificado_GenerarPublicacion
(@username NVARCHAR(255)) AS
BEGIN
	update LA_PETER_MACHINE.usuario set usua_bonificado = 0 where usua_username = @username
END
GO
