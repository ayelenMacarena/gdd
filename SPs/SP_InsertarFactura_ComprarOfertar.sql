CREATE PROCEDURE LA_PETER_MACHINE.SP_InsertarFactura_ComprarOfertar
(@publ_id INT,
@date DATETIME,
@cantidad INT)
AS

DECLARE @costoEnvio INT,
		@codVisibilidad INT,
		@envioHabilitado INT,
		@costoPorcentaje NUMERIC(18,2),
		@precioPubli NUMERIC(18,2),
		@vendedor NUMERIC(18,0),
		@numFact NUMERIC(18,0),
		@total INT,
		@fecha DATETIME

SET @fecha = @date
SET @codVisibilidad = (select publ_cod_visibilidad from LA_PETER_MACHINE.publicacion WHERE publicacion_id = @publ_id)
SET @envioHabilitado = (select publ_envio_habilitado from LA_PETER_MACHINE.publicacion WHERE publicacion_id = @publ_id)
SET @precioPubli = (select publ_precio from LA_PETER_MACHINE.publicacion WHERE publicacion_id = @publ_id)
SET @vendedor = (select publ_id_vendedor from LA_PETER_MACHINE.publicacion WHERE publicacion_id = @publ_id)

IF @envioHabilitado = 1
	BEGIN
		SET @costoEnvio = (select cost_costo from LA_PETER_MACHINE.costo_envio where cost_visi_cod = @codVisibilidad)
	END
ELSE 
	BEGIN
		SET @costoEnvio = 0
	END

IF @codVisibilidad = 10006
	BEGIN
		SET @costoPorcentaje = 0
	END
ELSE 
	BEGIN
		SET @costoPorcentaje = @precioPubli * (select visi_porcentaje from LA_PETER_MACHINE.visibilidad where visi_cod = @codVisibilidad)
	END


SET @total = (@costoPorcentaje*@cantidad) + @costoEnvio


INSERT INTO LA_PETER_MACHINE.factura(fact_fecha, fact_total, fact_forma_pago, fact_id_vendedor)
		VALUES (@fecha,@total,'Efectivo',@vendedor)

SET @numFact = (select TOP 1 fact_num from LA_PETER_MACHINE.factura order by fact_num desc)

IF @codVisibilidad != 10006
	BEGIN
		INSERT INTO LA_PETER_MACHINE.item_factura VALUES (@numFact,@publ_id, @cantidad, @costoPorcentaje)
		INSERT INTO LA_PETER_MACHINE.item_factura VALUES (@numFact,@publ_id, 1, @costoEnvio)
	END

GO