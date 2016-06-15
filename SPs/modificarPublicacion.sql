CREATE procedure LA_PETER_MACHINE.modificarPublicacion(@publ_id nvarchar(255), @estado nvarchar(255), @descripcion nvarchar(255), @precio nvarchar(255), @costo nvarchar(255), @rubro nvarchar(255), @visibilidad nvarchar(255), 
	@preguntas nvarchar(255), @envio nvarchar(255), @fecha_inicio nvarchar(255), @fecha_fin nvarchar(255), @stock nvarchar(255),@rdo nvarchar(255) output )
AS
	begin
	begin try

	declare @estado_id numeric(18)
	set @estado_id = (select TOP 1 estado_id from LA_PETER_MACHINE.estado where esta_descripcion = @estado)

	declare @rubro_id numeric(18)
	set @rubro_id = (select TOP 1 rubr_cod from LA_PETER_MACHINE.rubro where rubr_descripcion_corta = @rubro)

	declare @visibilidad_id numeric(18)
	set @visibilidad_id = (select TOP 1 visi_cod from LA_PETER_MACHINE.visibilidad where visi_descripcion = @visibilidad)

	declare @acepta_pregunta bit
	IF @preguntas = 'Si'
		set @acepta_pregunta = 1
	else
		set @acepta_pregunta = 0

	declare @acepta_envio bit
	if @envio = 'Si'
		set @acepta_envio = 1
	else 
		set @acepta_envio = 0 

declare @fecha_desde Datetime
set @fecha_desde=@fecha_inicio
declare @fecha_hasta Datetime
set @fecha_hasta=@fecha_fin

	update LA_PETER_MACHINE.publicacion set publ_precio = convert(numeric(18,2),@precio) where publicacion_id = convert(numeric(18),@publ_id);
	update LA_PETER_MACHINE.publicacion set publ_costo = convert(numeric(18,2),@costo) where publicacion_id = convert(numeric(18),@publ_id);
	update LA_PETER_MACHINE.publicacion set publ_descripcion = @descripcion where publicacion_id = convert(numeric(18),@publ_id);
	update LA_PETER_MACHINE.publicacion set publ_cod_rubro = @rubro_id where publicacion_id = convert(numeric(18),@publ_id);
	update LA_PETER_MACHINE.publicacion set publ_cod_visibilidad = @visibilidad_id where publicacion_id = convert(numeric(18),@publ_id);
	update LA_PETER_MACHINE.publicacion set publ_id_estado = @estado_id where  publicacion_id = convert(numeric(18),@publ_id);
	update LA_PETER_MACHINE.publicacion set publ_fecha_inicio = @fecha_desde where publicacion_id = convert(numeric(18),@publ_id);
	update LA_PETER_MACHINE.publicacion set publ_fecha_fin = @fecha_hasta where publicacion_id = convert(numeric(18),@publ_id);
	update LA_PETER_MACHINE.publicacion set publ_preguntas = @acepta_pregunta where publicacion_id = convert(numeric(18),@publ_id);
	update LA_PETER_MACHINE.publicacion set publ_cantidad = convert(numeric(18),@stock) where publicacion_id = convert(numeric(18),@publ_id);
	update LA_PETER_MACHINE.publicacion set publ_envio_habilitado = @acepta_envio where publicacion_id = convert(numeric(18),@publ_id);

	set @rdo='Modificación correcta'
	end try
	begin catch
	set @rdo='No pudo efectuarse la modificación de la publicación'
	end catch
	
	end
GO
