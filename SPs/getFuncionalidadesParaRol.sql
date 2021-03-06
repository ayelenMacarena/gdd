CREATE procedure LA_PETER_MACHINE.get_funcionalidades_para_rol
	@rol_desc nvarchar(255)
AS
	select f.func_procedure, f.func_descripcion
	from LA_PETER_MACHINE.funcionalidad f, LA_PETER_MACHINE.funcionalidad_rol fr, LA_PETER_MACHINE.rol r
	where f.funcionalidad_id = fr.furo_id_funcionalidad
	and fr.furo_id_rol = r.rol_id
	and r.rol_descripcion = @rol_desc
	and r.rol_habilitado = 1
GO


--EXEC 
--Esto lo dejo aca comentado porque es la forma de ejecutarlo (cambiando la X por la descripcion del rol deseado)

	--EXECUTE LA_PETER_MACHINE.get_funcionalidades_para_rol @rol_desc = X

--DROP

	--IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.get_funcionalidades_para_rol')) DROP PROCEDURE LA_PETER_MACHINE.get_funcionalidades_para_rol