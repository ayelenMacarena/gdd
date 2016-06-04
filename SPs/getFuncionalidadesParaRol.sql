CREATE procedure LA_PETER_MACHINE.get_funcionalidades_para_rol 
	@rol_id Integer 
AS
	select f.func_procedure, func_descripcion
	from LA_PETER_MACHINE.funcionalidad f, LA_PETER_MACHINE.funcionalidad_rol fr
	where f.funcionalidad_id = fr.furo_id_funcionalidad
	and fr.furo_id_rol = @rol_id
GO


--EXEC 
--Esto lo dejo aca comentado porque es la forma de ejecutarlo (cambiando la X por el id del rol deseado)

	--EXECUTE LA_PETER_MACHINE.get_funcionalidades_para_rol @rol_id = X

--DROP

	--IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.get_funcionalidades_para_rol')) DROP PROCEDURE LA_PETER_MACHINE.get_funcionalidades_para_rol