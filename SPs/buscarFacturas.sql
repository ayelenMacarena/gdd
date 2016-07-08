alter procedure LA_PETER_MACHINE.buscarFacturas (@fechaDesde datetime , @fechaHasta datetime, 
 	@precioDesde nvarchar(200) , @precioHasta nvarchar(200) , @descripcion nvarchar(255), @vendedor nvarchar(255),
	@registrosPorPagina INT,
	@numerosPagina INT)
as

begin


declare @miVendedor numeric(18,0)
if @vendedor is not null
	set @miVendedor = (select TOP 1 pers_id from LA_PETER_MACHINE.persona where pers_username = @vendedor ) ;

declare @query varchar(255)



IF @fechaDesde is Not NULL and @query is not NUll
	set @query = @query + ' AND fact_fecha >= ''' + convert(varchar(4),year(@fechaDesde)) 
										+ convert(varchar(2),month(@fechaDesde)) + convert(varchar(2),day(@fechaDesde)) + ''''
Else IF @fechaDesde is Not NULL 
	set @query = 'select * from LA_PETER_MACHINE.factura where fact_fecha >= ''' + convert(varchar(4),year(@fechaDesde)) 
										+ convert(varchar(2),month(@fechaDesde)) + convert(varchar(2),day(@fechaDesde)) + ''''

IF @fechaHasta is not Null and @query is not null
	set @query = @query + ' AND fact_fecha <= ''' + convert(varchar(4),year(@fechaHasta)) 
											+ convert(varchar(2),month(@fechaHasta)) + convert(varchar(2),day(@fechaHasta)) + ''''
else IF @fechaHasta is not Null
	set @query = 'select * from LA_PETER_MACHINE.factura where fact_fecha <= ''' + convert(varchar(4),year(@fechaHasta)) 
											+ convert(varchar(2),month(@fechaHasta)) + convert(varchar(2),day(@fechaHasta)) + ''''


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

begin
set @query = @query + ' order by fact_fecha' + ' OFFSET (' + convert(nvarchar(255),@numerosPagina) + ' - 1) *' +  convert(varchar(255),@registrosPorPagina)
						 + ' ROWS FETCH NEXT ' + convert(varchar(255),@registrosPorPagina) + ' ROWS ONLY'
end 

exec (@query)

end

GO
