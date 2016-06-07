CREATE PROCEDURE LA_PETER_MACHINE.SP_Buscador_Publicaciones
@terminoBuscado as varchar(255)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM LA_PETER_MACHINE.publicacion
	WHERE publ_descripcion LIKE '%' + @terminoBuscado + '%'
	ORDER BY publicacion_id
END
GO