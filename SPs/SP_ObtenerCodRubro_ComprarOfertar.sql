CREATE PROCEDURE LA_PETER_MACHINE.SP_ObtenerCodRubro_ComprarOfertar
(@detalleRubro NVARCHAR(255),
@CodRubro INT OUTPUT)
AS

SET @CodRubro = (select rubr_cod from LA_PETER_MACHINE.rubro where rubr_descripcion_corta = @detalleRubro)

GO