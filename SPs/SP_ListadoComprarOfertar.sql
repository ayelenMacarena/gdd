CREATE PROCEDURE LA_PETER_MACHINE.SP_ListadoComprarOfertar
(@registrosPorPagina INT,
@numerosPagina INT,
@cliente INT,
@tipo VARCHAR(8),
@terminoBuscado as varchar(255))
AS
	DECLARE @ID_TIPO INT

	BEGIN 
	SET NOCOUNT ON
	
	IF (@tipo = 'SUBASTAS') 
		BEGIN 
			SET @ID_TIPO = 2
		END
	ELSE
		BEGIN
			SET @ID_TIPO = 1
		END	
		
	SELECT publicacion_id, publ_descripcion, publ_precio, publ_cantidad, publ_id_vendedor
		FROM LA_PETER_MACHINE.publicacion, LA_PETER_MACHINE.estado, LA_PETER_MACHINE.tipo
		WHERE  publ_id_vendedor != @cliente
			and publ_id_estado = estado_id and esta_descripcion = 'Finalizada'
			and publ_id_tipo = @ID_TIPO
			and	publ_descripcion LIKE '%' + @terminoBuscado + '%'
			and publ_cantidad > 0
		GROUP BY publicacion_id, publ_descripcion, publ_precio, publ_id_vendedor, publ_id_tipo, publ_cantidad, publ_cod_visibilidad
		ORDER BY publ_cod_visibilidad asc

	OFFSET (@numerosPagina - 1) * @registrosPorPagina ROWS
	FETCH NEXT @registrosPorPagina ROWS ONLY
	END;
GO