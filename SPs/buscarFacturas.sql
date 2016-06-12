create procedure LA_PETER_MACHINE.buscarFacturas (@fechaDesde varchar(15) , @fechaHasta varchar(15), 
 	@precioDesde nvarchar(200) , @precioHasta nvarchar(200) , @descripcion nvarchar(255), @vendedor nvarchar(255))
as

begin


declare @miVendedor numeric(18,0)
if @vendedor is not null
	set @miVendedor = (select TOP 1 pers_id from LA_PETER_MACHINE.persona where pers_username = @vendedor ) ;

declare @query varchar(255)



IF @fechaDesde is Not NULL and @query is not NUll
	set @query = @query + ' AND fact_fecha >= "' + @fechaDesde + '"'
Else IF @fechaDesde is Not NULL 
	set @query = 'select * from LA_PETER_MACHINE.factura where fact_fecha >= "' + @fechaDesde + '"'

IF @fechaHasta is not Null and @query is not null
	set @query = @query + ' AND fact_fecha <= "' + @fechaHasta + '"'
else IF @fechaHasta is not Null
	set @query = 'select * from LA_PETER_MACHINE.factura where fact_fecha <= "' + @fechaHasta + '"'


IF @descripcion is not NUll and @query is not null
	set @query = @query + 'AND fact_num = ' + convert(varchar(255), @descripcion);
else
	set @query = 'select * from LA_PETER_MACHINE.factura where fact_num = ' +  convert(varchar(255), @descripcion) ;


if @miVendedor is not null and @query is not null
	set @query = @query + ' AND fact_id_vendedor = ' + convert(varchar(10),@miVendedor);
else if @miVendedor is not null
	set @query = 'select * from LA_PETER_MACHINE.factura where fact_id_vendedor = ' + convert(varchar(10),@miVendedor);


IF @precioDesde is Not NULL and @query is not NUll
	set @query = @query + ' AND ' + 'fact_total >= ' + @precioDesde
Else IF @precioDesde is Not NULL
	set @query = 'select * from LA_PETER_MACHINE.factura where fact_total >= ' + @precioDesde

IF @precioHasta is not Null and @query is not null
	set @query = @query + ' AND fact_total <= ' + @precioHasta
else IF @precioHasta is not Null
	set @query = 'select * from LA_PETER_MACHINE.factura where fact_total <= '+ @precioHasta

if @query is null and @precioHasta is null and @precioDesde is Null and @fechaDesde is null and @fechaHasta is null and @descripcion is null and @vendedor is null
	set @query = 'select * from LA_PETER_MACHINE.factura'

exec (@query)

end

GO