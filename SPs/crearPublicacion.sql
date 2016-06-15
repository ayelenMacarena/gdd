CREATE procedure LA_PETER_MACHINE.crearPublicacion(@username nvarchar(255), @estado nvarchar(255), @tipo nvarchar(255),
	@descripcion nvarchar(255), @precio nvarchar(255), @costo nvarchar(255), @rubro nvarchar(255), @visibilidad nvarchar(255), 
	@preguntas nvarchar(255), @envio nvarchar(255), @fecha_inicio nvarchar(255), @fecha_fin nvarchar(255), @stock nvarchar(255),@rdo nvarchar(255) output )
AS
	begin
	begin try
	declare @vendedor_id numeric(18)
	set @vendedor_id = (select TOP 1 pers_id from LA_PETER_MACHINE.persona where pers_username = @username)

	declare @estado_id numeric(18)
	set @estado_id = (select TOP 1 estado_id from LA_PETER_MACHINE.estado where esta_descripcion = @estado)

	declare @tipo_id numeric(18)
	set @tipo_id = (select TOP 1  tipo_id from LA_PETER_MACHINE.tipo where tipo_descripcion = @tipo)

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

	Insert into LA_PETER_MACHINE.publicacion (publ_descripcion, publ_precio, publ_costo, publ_cod_rubro, publ_cod_visibilidad, 
	publ_id_vendedor, publ_id_estado, publ_fecha_inicio,publ_fecha_fin, publ_preguntas, publ_cantidad, publ_id_tipo, publ_envio_habilitado)
	VALUES (@descripcion, convert(numeric(18,2),@precio),convert(numeric(18,2),@costo), @rubro_id, @visibilidad_id, @vendedor_id, 
	@estado_id, @fecha_desde, @fecha_hasta, @acepta_pregunta, convert(numeric(18),@stock), @tipo_id, @acepta_envio)
	set @rdo='ok'
	end try
	begin catch
	set @rdo='error de ingreso'
	end catch
	
	end
GO
