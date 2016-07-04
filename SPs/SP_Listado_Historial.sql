CREATE PROCEDURE LA_PETER_MACHINE.SP_Listado_Historial
(@registrosPorPagina INT,
@numerosPagina INT,
@cliente nvarchar(255),
@tipo INT)
AS	
BEGIN

	if(@tipo = 1)	
		BEGIN
		SELECT C.comp_fecha as Fecha, P.publ_descripcion as Descripcion, C.comp_cantidad as Cantidad,
				 P.publ_precio as Precio, I.pers_username as Vendedor
			FROM LA_PETER_MACHINE.compra C, LA_PETER_MACHINE.publicacion P, LA_PETER_MACHINE.persona I 
			where C.comp_id_publicacion = P.publicacion_id 
				and C.comp_username = @cliente
				and C.comp_id_vendedor = I.pers_id
			order by C.comp_fecha
		OFFSET (@numerosPagina - 1) * @registrosPorPagina ROWS
		FETCH NEXT @registrosPorPagina ROWS ONLY
		END
		
	if(@tipo = 2)
		BEGIN
		SELECT O.ofer_fecha as Fecha, P.publ_descripcion as Descripcion, O.ofer_valor as Valor_de_Oferta, I.pers_username as Vendedor 
			FROM LA_PETER_MACHINE.oferta O, LA_PETER_MACHINE.publicacion P, LA_PETER_MACHINE.persona I
			where O.ofer_id_publicacion = P.publicacion_id 
				and O.ofer_username = @cliente
				and I.pers_id = P.publ_id_vendedor
			order by O.ofer_fecha
		OFFSET (@numerosPagina - 1) * @registrosPorPagina ROWS
		FETCH NEXT @registrosPorPagina ROWS ONLY
		END

END;
GO
