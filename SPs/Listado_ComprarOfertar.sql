CREATE PROCEDURE LA_PETER_MACHINE.SP_Listado_ComprarOfertar 
(@registrosPorPagina INT,
@numerosPagina INT,
@cliente INT)
AS
	BEGIN 
	SET NOCOUNT ON
	
	SELECT publ_descripcion, publ_precio, publ_id_vendedor FROM LA_PETER_MACHINE.publicacion
	WHERE publ_id_vendedor != @cliente
	ORDER BY publicacion_id

	OFFSET (@numerosPagina - 1) * @registrosPorPagina ROWS
	FETCH NEXT @registrosPorPagina ROWS ONLY
	END;
GO