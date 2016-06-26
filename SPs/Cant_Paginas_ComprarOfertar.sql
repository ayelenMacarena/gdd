CREATE PROCEDURE LA_PETER_MACHINE.SP_Cantidad_Paginas_ComprarOfertar
(@registrosPorPagina INT,
@totalDePaginas INT OUTPUT,
@cliente INT,
@tipo VARCHAR(8),
@terminoBuscado as varchar(255),
@rubros as varchar(255))
AS

DECLARE @cantidadFilas int
	
	DECLARE @ID_TIPO INT

	BEGIN 
	SET NOCOUNT ON
	
	BEGIN
	IF (@tipo = 'SUBASTAS') 
		BEGIN 
			SET @ID_TIPO = 2
		END
	ELSE
		BEGIN
			SET @ID_TIPO = 1
		END	
	END
		SET @cantidadFilas = 
			(select COUNT(distinct publicacion_id) 
			FROM LA_PETER_MACHINE.publicacion JOIN LA_PETER_MACHINE.ListaATabla_ComprarOfertar(@rubros) r on publ_cod_rubro = r.number,
			 LA_PETER_MACHINE.estado, LA_PETER_MACHINE.tipo		
					WHERE  publ_id_vendedor != @cliente
						and publ_id_estado = estado_id and esta_descripcion = 'Finalizada'
						and publ_id_tipo = @ID_TIPO
						and	publ_descripcion LIKE '%' + @terminoBuscado + '%'
						and publ_cantidad > 0)						
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