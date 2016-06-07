CREATE PROCEDURE LA_PETER_MACHINE.SP_Cantidad_Paginas_ComprarOfertar
@registrosPorPagina int,
@totalDePaginas int OUTPUT,
@cliente int
AS

DECLARE @cantidadFilas int
	
	BEGIN
		SET NOCOUNT ON
		SET @cantidadFilas = (select COUNT(publicacion_id) from LA_PETER_MACHINE.publicacion
									WHERE publ_id_vendedor != @cliente) 
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