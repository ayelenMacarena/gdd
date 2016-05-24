create procedure LaPeterMachine
as

declare @dni numeric(18),
		@apellido nvarchar(255),
		@nombre nvarchar(255),
		@fecha_nac datetime,
		@mail nvarchar(50),
		@calle nvarchar(255),
		@calle_numero numeric(18),
		@piso numeric (18),
		@depto nvarchar(50),
		@cod_postal nvarchar(50),
		@razon_social varchar(50),
		@cuit nvarchar(50),
		@fecha_creacion datetime,
		@empr_mail nvarchar(50),
		@empr_calle nvarchar(255),
		@empr_calle_numero numeric(18),
		@empr_piso numeric(18),
		@empr_dpto nvarchar(50),
		@empr_cod_postal nvarchar(50),
		@publ_cod numeric(18),
		@publ_descripcion nvarchar(255),
		@publ_stock numeric(18),
		@publ_fecha datetime,
		@publ_fecha_venc datetime,
		@publ_precio float(10),
		@publ_tipo varchar(20),
		@visi_cod numeric(10),
		@visi_desc varchar(20),
		@visi_precio float(10),
		@visi_porcentaje float(3),
		@publ_estado varchar(30),
		@rubro_descr nvarchar(125),
		@clie_dni numeric(18),
		@clie_apellido nvarchar(255),
		@clie_nombre nvarchar(255),
		@clie_fecha_nac datetime,
		@clie_mail nvarchar(50),
		@clie_calle nvarchar(255),
		@clie_calle_numero numeric(18),
		@clie_piso numeric(18),
		@clie_dpto nvarchar(50),
		@clie_cod_postal nvarchar(50),
		@comp_fecha datetime,
		@comp_cantidad numeric(18),
		@ofer_fecha datetime,
		@ofer_monto numeric(18,2)
		
		

declare C cursor for 
select *
from gd_esquema.Maestra

open C
fetch next into  @dni ,
		@apellido,
		@nombre ,
		@fecha_nac,
		@mail ,
		@calle ,
		@calle_numero ,
		@piso ,
		@depto ,
		@cod_postal ,
		@razon_social ,
		@cuit ,
		@fecha_creacion ,
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
		@ofer_fecha,
		@ofer_monto	

while @@FETCH_STATUS=0 begin
	if not isNull@razon_social and not exists(select *
	                                            from Empresa
	                                            where empr_razon_social=@razon_social)
	 BEGIN
	  insert into Empresa(empr_razon_social,empr_cuit... (me falta terminar de insertar en esta tabla y tengo que completar la otra)
	 END
	
