create procedure LaPeterMachine
as

declare @dni numeric(18),
		@apellido nvarchar(255),
		@nombre nvarchar(255),
		@fecha_nac datetime,
		@mail nvarchar(255),
		@calle nvarchar(255),
		@calle_numero numeric(18),
		@piso numeric (18),
		@depto nvarchar(50),
		@cod_postal nvarchar(50),
		@empr_razon_social nvarchar(255),
		@empr_cuit nvarchar(50),
		@empr_fecha_creacion datetime,
		@empr_mail nvarchar(50),
		@empr_calle nvarchar(100),
		@empr_calle_numero numeric(18),
		@empr_piso numeric(18),
		@empr_dpto nvarchar(50),
		@empr_cod_postal nvarchar(50),
		@publ_cod numeric(18),
		@publ_descripcion nvarchar(255),
		@publ_stock numeric(18),
		@publ_fecha datetime,
		@publ_fecha_venc datetime,
		@publ_precio numeric(18,2),
		@publ_tipo varchar(255),
		@visi_cod numeric(18,2),
		@visi_desc varchar(255),
		@visi_precio numeric(18,2),
		@visi_porcentaje numeric(18,2),
		@publ_estado varchar(255),
		@rubro_descr nvarchar(255),
		@clie_dni numeric(18),
		@clie_apellido nvarchar(255),
		@clie_nombre nvarchar(255),
		@clie_fecha_nac datetime,
		@clie_mail nvarchar(255),
		@clie_calle nvarchar(255),
		@clie_calle_numero numeric(18),
		@clie_piso numeric(18),
		@clie_dpto nvarchar(50),
		@clie_cod_postal nvarchar(50),
		@comp_fecha datetime,
		@comp_cantidad numeric(18),
		@ofer_fecha datetime,
		@ofer_monto numeric(18,2),
		@cali_codigo numeric(18),
		@cali_cant_estrellas numeric(18),
		@cali_desc nvarchar(255),	
		@ifac_monto numeric(18,2),
		@ifac_cant numeric(18),
		@fact_nro numeric(18),
		@fact_fecha datetime,
		@fact_total numeric(18,2),
		@fact_pago_desc nvarchar(255)
		
		

declare C cursor for 
select *
from gd_esquema.Maestra

open C
fetch next from C into  @dni ,
		@apellido,
		@nombre ,
		@fecha_nac,
		@mail ,
		@calle ,
		@calle_numero ,
		@piso ,
		@depto ,
		@cod_postal ,
		@empr_razon_social ,
		@empr_cuit ,
		@empr_fecha_creacion ,
		@empr_mail ,
		@empr_calle ,
		@empr_calle_numero ,
		@empr_piso ,
		@empr_dpto,
		@empr_cod_postal ,
		@publ_cod ,
		@publ_descripcion,
		@publ_stock ,
		@publ_fecha,
		@publ_fecha_venc ,
		@publ_precio ,
		@publ_tipo ,
		@visi_cod ,
		@visi_desc ,
		@visi_precio ,
		@visi_porcentaje,
		@publ_estado ,
		@rubro_descr ,
		@clie_dni ,
		@clie_apellido ,
		@clie_nombre ,
		@clie_fecha_nac ,
		@clie_mail ,
		@clie_calle ,
		@clie_calle_numero ,
		@clie_piso ,
		@clie_dpto ,
		@clie_cod_postal ,
		@comp_fecha ,
		@comp_cantidad ,
		@ofer_fecha ,
		@ofer_monto , 
		@cali_codigo ,
		@cali_cant_estrellas ,
		@cali_desc ,	
		@ifac_monto ,
		@ifac_cant ,
		@fact_nro ,
		@fact_fecha ,
		@fact_total ,
		@fact_pago_desc

while @@FETCH_STATUS=0 begin
	if @publ_estado is not NULL and not exists (select * from Estado where esta_descripcion = @publ_estado)
		BEGIN
			insert into Estado (esta_descripcion) 
			values (@publ_estado)
		END
	
	if @publ_tipo is not NULL and not exists (select * from Tipo where tipo_descripcion = @publ_tipo)
		BEGIN
			insert into Tipo (tipo_descripcion) 
			values (@publ_tipo)
		END

	if @visi_cod is not NULL and not exists (select * from Visibilidad where visi_cod = @visi_cod)
		BEGIN
			insert into Visibilidad (visi_cod, visi_descripcion, visi_envio, visi_porcentaje, visi_precio)
			values (@visi_cod, @visi_desc, (select case when @visi_precio > 60 then 1 else 0 end), @visi_precio, @visi_porcentaje)
		END



	fetch next from C into  @dni ,
		@apellido,
		@nombre ,
		@fecha_nac,
		@mail ,
		@calle ,
		@calle_numero ,
		@piso ,
		@depto ,
		@cod_postal ,
		@empr_razon_social ,
		@empr_cuit ,
		@empr_fecha_creacion ,
		@empr_mail ,
		@empr_calle ,
		@empr_calle_numero ,
		@empr_piso ,
		@empr_dpto,
		@empr_cod_postal ,
		@publ_cod ,
		@publ_descripcion,
		@publ_stock ,
		@publ_fecha,
		@publ_fecha_venc ,
		@publ_precio ,
		@publ_tipo ,
		@visi_cod ,
		@visi_desc ,
		@visi_precio ,
		@visi_porcentaje,
		@publ_estado ,
		@rubro_descr ,
		@clie_dni ,
		@clie_apellido ,
		@clie_nombre ,
		@clie_fecha_nac ,
		@clie_mail ,
		@clie_calle ,
		@clie_calle_numero ,
		@clie_piso ,
		@clie_dpto ,
		@clie_cod_postal ,
		@comp_fecha ,
		@comp_cantidad ,
		@ofer_fecha ,
		@ofer_monto , 
		@cali_codigo ,
		@cali_cant_estrellas ,
		@cali_desc ,	
		@ifac_monto ,
		@ifac_cant ,
		@fact_nro ,
		@fact_fecha ,
		@fact_total ,
		@fact_pago_desc
end
close C
deallocate C
GO

	----corrobora que no exista la empresa
	--if not ISNULL @publ_cod and not exists(select * from Publicacion where publicacion_id = @publ_cod)
	--	insert into Publicacion (publicacion_id, publ_cantidad)


	--if not isNull@razon_social and not exists(select *
	--                                            from Empresa
	--                                            where empr_razon_social=@razon_social)
	-- BEGIN
	-- --crea la empresa
	--  insert into Empresa(empr_razon_social,empr_cuit,empr_cod_rubro,empr_id_vendedor) values(@empr_razon_social,@empr_cuit,@cont_rubro,@cont_vendedor)
	----crea el rubro	(sigue un contador para los ids)
	--	if not exists(select *
	--			from Rubro
	--			where rubr_descripcion_corta=@rubr:descr)
	--			begin
	--			insert into Rubro(rubro_cod,rubr_descripcion_corta) values(next value for cont_rubro,@rubr_descr)
	--			end
	-- --crea el vendedor (sigue un contador para los ids)
	-- insert into Vendedor(vendedor_id,vend_username,vend_mail,vend_domicilio_calle,vend_cod_postal,vend_habilitado,vend_numero_calle,vend_piso,vend_depto) 
	-- values(@cont_vendedor,@empr_mail,@empr_calle,@empr_cod_postal,1,@empr_calle_numero,@empr_piso,@empr_dpto)
	-- @cont_vendedor++
	-- --crea un usuario con el mail y de contra 12345
	-- if not exists(select*
	-- 		from Usuario
	-- 		where usua_username=@empr_mail)
	-- 		begin
	-- 		insert into Usuario(usua_username,usua_password) values(@empr_mail,"12345")
	-- 		end
	-- end
