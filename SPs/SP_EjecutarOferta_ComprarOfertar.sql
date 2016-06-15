CREATE PROCEDURE LA_PETER_MACHINE.SP_EjecutarOferta_ComprarOfertar
(@publ_id INT,
@precio INT)
AS

UPDATE LA_PETER_MACHINE.publicacion SET publ_precio = @precio  WHERE publicacion_id = @publ_id

GO