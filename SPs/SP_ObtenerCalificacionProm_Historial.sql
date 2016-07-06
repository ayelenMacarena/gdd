create PROCEDURE LA_PETER_MACHINE.SP_ObtenerCalificacionProm_Historial
(@idUsuario INT, @calificacionPromedio numeric(12,3) OUTPUT)
AS

SET @calificacionPromedio = 
		(select AVG(E.cali_valor) as calif_prom from LA_PETER_MACHINE.compra C, LA_PETER_MACHINE.calificacion E
			where C.comp_id_calificacion is not null
				and C.comp_id_calificacion = E.calificacion_id
				and C.comp_id_comprador = @idUsuario
			group by C.comp_id_comprador
		)

	if (@calificacionPromedio is null)
		begin
		SET @calificacionPromedio = 0
		end
GO
