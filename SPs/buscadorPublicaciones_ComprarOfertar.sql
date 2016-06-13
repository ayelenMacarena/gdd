CREATE PROCEDURE LA_PETER_MACHINE.SP_Buscador_Publicaciones
@terminoBuscado as varchar(255),
@cliente INT,
@tipo VARCHAR(8)
AS
BEGIN
	DECLARE @ID_TIPO INT

	IF (@tipo = 'SUBASTAS') 
		BEGIN 
			SET @ID_TIPO = 2
		END
	ELSE
		BEGIN
			SET @ID_TIPO = 1
		END	

	SET NOCOUNT ON;

	SELECT publicacion_id, publ_descripcion, publ_precio, publ_id_vendedor, publ_id_tipo, publ_cantidad, publ_cod_visibilidad
	FROM LA_PETER_MACHINE.publicacion, LA_PETER_MACHINE.estado, LA_PETER_MACHINE.tipo
	WHERE  publ_id_vendedor != @cliente
		and publ_id_estado = estado_id 
		and esta_descripcion = 'Finalizada'
		and publ_id_tipo = @ID_TIPO
		and	publ_descripcion LIKE '%' + @terminoBuscado + '%'
	GROUP BY publicacion_id, publ_descripcion, publ_precio, publ_id_vendedor, publ_id_tipo, publ_cantidad, publ_cod_visibilidad
	ORDER BY publ_cod_visibilidad asc

END
GO