CREATE PROCEDURE LA_PETER_MACHINE.SP_Cantidad_Paginas_Historial
(@registrosPorPagina INT,
@totalDePaginas INT OUTPUT,
@cliente nvarchar(255),
@tipo int)
AS

DECLARE @cantidadFilas int
	
BEGIN 
	SET NOCOUNT ON
	
	if(@tipo = 1)	
		BEGIN
			SET @cantidadFilas = (SELECT COUNT(*)
			FROM LA_PETER_MACHINE.compra C, LA_PETER_MACHINE.publicacion P, LA_PETER_MACHINE.persona I 
			where C.comp_id_publicacion = P.publicacion_id 
				and C.comp_username = @cliente
				and C.comp_id_vendedor = I.pers_id)
		END
		
	if(@tipo = 2)
		BEGIN
		SET @cantidadFilas = (SELECT COUNT(*)
			FROM LA_PETER_MACHINE.oferta O, LA_PETER_MACHINE.publicacion P, LA_PETER_MACHINE.persona I
			where O.ofer_id_publicacion = P.publicacion_id 
				and O.ofer_username = @cliente
				and I.pers_id = P.publ_id_vendedor)
		END

		SET @totalDePaginas = @cantidadFilas / @registrosPorPagina
		IF (@cantidadFilas % @registrosPorPagina) > 0
			BEGIN
				SET @totalDePaginas=@totalDePaginas+1
				RETURN;
			END
		IF @totalDePaginas = 0
			BEGIN
				SET @totalDePaginas=1
				RETURN;
			END
	END
GO
