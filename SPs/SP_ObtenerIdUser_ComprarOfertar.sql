CREATE PROCEDURE LA_PETER_MACHINE.SP_ObtenerIdUser_ComprarOfertar
(@username NVARCHAR(255),
@idUser INT OUTPUT)
AS

SET @idUser = (select pers_id from LA_PETER_MACHINE.persona where pers_username = @username)

GO