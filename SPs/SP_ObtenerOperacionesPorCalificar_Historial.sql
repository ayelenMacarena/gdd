CREATE PROCEDURE LA_PETER_MACHINE.SP_ObtenerComprasPorCalificar_Historial
(@idUsuario INT, @porCalificar int OUTPUT)
AS

SET @porCalificar = 
		(select COUNT(*) from LA_PETER_MACHINE.compra C
			where C.comp_id_calificacion is null
				and C.comp_id_comprador = @idUsuario
		)
GO
