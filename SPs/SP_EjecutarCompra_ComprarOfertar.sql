CREATE PROCEDURE LA_PETER_MACHINE.SP_EjecutarCompra_ComprarOfertar
(@publ_id INT,
@cantidad INT)
AS

UPDATE LA_PETER_MACHINE.publicacion SET publ_cantidad = (publ_cantidad - @cantidad) WHERE publicacion_id = @publ_id

GO