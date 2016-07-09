CREATE PROCEDURE LA_PETER_MACHINE.SP_ConsultarUsuarioBonificado_GenerarPublicacion
(@username NVARCHAR(255),
@estaBonificado BIT OUTPUT)
AS

SET @estaBonificado = (select usua_bonificado from LA_PETER_MACHINE.usuario where usua_username = @username)

GO