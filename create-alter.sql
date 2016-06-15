------------------------------------------------------
-- SE REALIZAN LOS CREATES DE LAS TABLAS Y COLUMNAS --
------------------------------------------------------

CREATE SCHEMA LA_PETER_MACHINE
CREATE TABLE calificacion ( 
	calificacion_id numeric(18) NOT NULL IDENTITY(1,1),
	cali_valor numeric(5),
	cali_detalle nvarchar(100),
	cali_id_vendedor numeric(18) NOT NULL
)

CREATE TABLE cliente ( 
	clie_apellido nvarchar(255) NOT NULL,
	clie_nombre nvarchar(255) NOT NULL,
	clie_dni numeric(18) NOT NULL,
	clie_id_tipo_doc numeric(18) NOT NULL,
	clie_fecha_nac datetime,
	clie_id_persona numeric(18) NOT NULL
)


CREATE TABLE compra ( 
	compra_id numeric(18) NOT NULL IDENTITY(1,1),
	comp_id_publicacion numeric(18) NOT NULL,
	comp_id_vendedor numeric(18) NOT NULL,
	comp_id_comprador numeric(18) NOT NULL,
	comp_num_factura numeric(18),
	comp_username nvarchar(255) NOT NULL,
	comp_id_calificacion numeric(18))


CREATE TABLE empresa ( 
	empr_razon_social nvarchar(255) NOT NULL,
	empr_cuit nvarchar(50) NOT NULL,
	empr_nombre_contacto nvarchar(255),
	empr_id_persona numeric(18) NOT NULL
)


CREATE TABLE estado ( 
	estado_id numeric(18) NOT NULL IDENTITY(1,1),
	esta_descripcion varchar(30)
)


CREATE TABLE factura ( 
	fact_num numeric(18) NOT NULL IDENTITY(1,1),
	fact_fecha datetime,
	fact_total numeric(18,2),
	fact_forma_pago nvarchar(255),
	fact_id_vendedor numeric(18)
)


CREATE TABLE funcionalidad ( 
	funcionalidad_id numeric(18) NOT NULL IDENTITY(1,1),
	func_descripcion nvarchar(255),
	func_procedure nvarchar(255)
)


CREATE TABLE funcionalidad_rol ( 
	furo_id_funcionalidad numeric(18) NOT NULL,
	furo_id_rol numeric(18) NOT NULL
)


CREATE TABLE item_factura ( 
	item_id numeric(18) NOT NULL IDENTITY(1,1),
	item_num_factura numeric(18) NOT NULL,
	item_id_publicacion numeric(18) NOT NULL,
	item_cantidad numeric(18),
	item_precio_unitario numeric(18,2)
)


CREATE TABLE oferta ( 
	oferta_id numeric(18) NOT NULL IDENTITY(1,1),
	ofer_id_publicacion numeric(18) NOT NULL,
	ofer_valor numeric(18) NOT NULL,
	ofer_username nvarchar(255) NOT NULL
)

CREATE TABLE publicacion ( 
	publicacion_id numeric(18)  NOT NULL IDENTITY(1,1),
	publ_descripcion nvarchar(255),
	publ_precio numeric(18,2),
	publ_costo numeric(18,2),
	publ_cod_rubro numeric(18) NOT NULL,
	publ_cod_visibilidad numeric(18) NOT NULL,
	publ_id_vendedor numeric(18) NOT NULL,
	publ_id_estado numeric(18) NOT NULL,
	publ_fecha_inicio datetime,
	publ_fecha_fin datetime,
	publ_preguntas bit,
	publ_cantidad numeric(18),
	publ_id_tipo numeric(18) NOT NULL,
	publ_envio_habilitado bit
)

CREATE TABLE rol ( 
	rol_id numeric(18) NOT NULL IDENTITY(1,1),
	rol_descripcion nvarchar(255) NOT NULL,
	rol_habilitado bit NOT NULL
)


CREATE TABLE roles_usuario ( 
	rolu_id_rol numeric(18) NOT NULL,
	rolu_username nvarchar(255) NOT NULL
)


CREATE TABLE rubro ( 
	rubr_cod numeric(18) NOT NULL IDENTITY(1,1),
	rubr_descripcion_corta nvarchar(125),
	rubr_descripcion_larga nvarchar(255)
)


CREATE TABLE tipo ( 
	tipo_id numeric(18) NOT NULL IDENTITY(1,1),
	tipo_descripcion nvarchar(255)
)


CREATE TABLE document_type ( 
	type_id numeric(18) NOT NULL IDENTITY(1,1),
	type_descripcion nvarchar(255) NOT NULL
)


CREATE TABLE usuario ( 
	usua_username nvarchar(255) NOT NULL,
	usua_password varbinary(20) NOT NULL,
	usua_habilitado bit NOT NULL,
	usua_intentos_login numeric (1) DEFAULT 0
)


CREATE TABLE persona ( 
	pers_id numeric(18) NOT NULL IDENTITY(1,1),
	pers_username nvarchar(255) NOT NULL,
	pers_mail nvarchar(50),
	pers_telefono nvarchar(50),
	pers_domicilio_calle nvarchar(255),
	pers_cod_postal nvarchar(50),
	pers_ciudad nvarchar(255),
	pers_habilitado bit NOT NULL,
	pers_calificacion numeric(18,2),
	pers_numero_calle numeric(18),
	pers_piso numeric(18),
	pers_depto nvarchar(50),
	pers_fecha_creacion datetime
)


CREATE TABLE visibilidad ( 
	visi_cod numeric(18) NOT NULL IDENTITY(1,1),
	visi_precio numeric(18,2),
	visi_porcentaje numeric(18,2),
	visi_envio bit,
	visi_descripcion nvarchar(255)
)

CREATE TABLE costo_envio(
	cost_id numeric(18) not null IDENTITY(1,1),
	cost_costo numeric(18,2),
	cost_visi_cod numeric(18)
	)
--declare @costo_de_envio numeric(18,2)
--set @costo_de_envio = 100


GO


------------------------------------------------------
--  SE ALTERAN LAS TABLAS PARA COLOCAR LAS PK Y FK  --
------------------------------------------------------


ALTER TABLE LA_PETER_MACHINE.calificacion ADD CONSTRAINT PK_calificacion 
	PRIMARY KEY CLUSTERED (calificacion_id)

ALTER TABLE LA_PETER_MACHINE.cliente ADD CONSTRAINT PK_cliente 
	PRIMARY KEY CLUSTERED (clie_dni, clie_id_tipo_doc)


ALTER TABLE LA_PETER_MACHINE.compra ADD CONSTRAINT PK_compra 
	PRIMARY KEY CLUSTERED (compra_id)


ALTER TABLE LA_PETER_MACHINE.empresa ADD CONSTRAINT PK_empresa 
	PRIMARY KEY CLUSTERED (empr_cuit)


ALTER TABLE LA_PETER_MACHINE.estado ADD CONSTRAINT PK_estado 
	PRIMARY KEY CLUSTERED (estado_id)


ALTER TABLE LA_PETER_MACHINE.factura ADD CONSTRAINT PK_factura 
	PRIMARY KEY CLUSTERED (fact_num)


ALTER TABLE LA_PETER_MACHINE.funcionalidad ADD CONSTRAINT PK_funcionalidad 
	PRIMARY KEY CLUSTERED (funcionalidad_id)


ALTER TABLE LA_PETER_MACHINE.funcionalidad_rol ADD CONSTRAINT PK_funcionalidad_rol 
	PRIMARY KEY CLUSTERED (furo_id_funcionalidad, furo_id_rol)


ALTER TABLE LA_PETER_MACHINE.item_factura ADD CONSTRAINT PK_item_factura 
	PRIMARY KEY CLUSTERED (item_id)


ALTER TABLE LA_PETER_MACHINE.oferta ADD CONSTRAINT PK_oferta 
	PRIMARY KEY CLUSTERED (oferta_id)


ALTER TABLE LA_PETER_MACHINE.publicacion ADD CONSTRAINT PK_publicacion 
	PRIMARY KEY CLUSTERED (publicacion_id)


ALTER TABLE LA_PETER_MACHINE.rol ADD CONSTRAINT PK_rol
	PRIMARY KEY CLUSTERED (rol_id)


ALTER TABLE LA_PETER_MACHINE.roles_usuario ADD CONSTRAINT PK_roles_usuario 
	PRIMARY KEY CLUSTERED (rolu_id_rol, rolu_username)


ALTER TABLE LA_PETER_MACHINE.rubro ADD CONSTRAINT PK_rubro 
	PRIMARY KEY CLUSTERED (rubr_cod)


ALTER TABLE LA_PETER_MACHINE.tipo ADD CONSTRAINT PK_tipo 
	PRIMARY KEY CLUSTERED (tipo_id)


ALTER TABLE LA_PETER_MACHINE.document_type ADD CONSTRAINT PK_document_type 
	PRIMARY KEY CLUSTERED (type_id)


ALTER TABLE LA_PETER_MACHINE.usuario ADD CONSTRAINT PK_usuario 
	PRIMARY KEY CLUSTERED (usua_username)


ALTER TABLE LA_PETER_MACHINE.persona ADD CONSTRAINT PK_vendedor 
	PRIMARY KEY CLUSTERED (pers_id)


ALTER TABLE LA_PETER_MACHINE.visibilidad ADD CONSTRAINT PK_visibilidad 
	PRIMARY KEY CLUSTERED (visi_cod)


ALTER TABLE LA_PETER_MACHINE.costo_envio ADD CONSTRAINT PK_costo_envio 
	PRIMARY KEY CLUSTERED (cost_id)


ALTER TABLE LA_PETER_MACHINE.costo_envio ADD CONSTRAINT FK_costo_envio_visibilidad
	FOREIGN KEY (cost_visi_cod) REFERENCES LA_PETER_MACHINE.visibilidad (visi_cod)


ALTER TABLE LA_PETER_MACHINE.cliente ADD CONSTRAINT FK_cliente_tipo_dni 
	FOREIGN KEY (clie_id_tipo_doc) REFERENCES LA_PETER_MACHINE.document_type (type_id)


ALTER TABLE LA_PETER_MACHINE.cliente ADD CONSTRAINT FK_cliente_vendedor 
	FOREIGN KEY (clie_id_persona) REFERENCES LA_PETER_MACHINE.persona (pers_id)


ALTER TABLE LA_PETER_MACHINE.factura ADD CONSTRAINT FK_factura_vendedor 
	FOREIGN KEY (fact_id_vendedor) REFERENCES LA_PETER_MACHINE.persona (pers_id)


ALTER TABLE LA_PETER_MACHINE.funcionalidad_rol ADD CONSTRAINT FK_funcionalidad_rol_funcionalidad 
	FOREIGN KEY (furo_id_funcionalidad) REFERENCES LA_PETER_MACHINE.funcionalidad (funcionalidad_id)


ALTER TABLE LA_PETER_MACHINE.funcionalidad_rol ADD CONSTRAINT FK_funcionalidad_rol_rol
	FOREIGN KEY (furo_id_rol) REFERENCES LA_PETER_MACHINE.rol (rol_id)


ALTER TABLE LA_PETER_MACHINE.publicacion ADD CONSTRAINT FK_publicacion_estado 
	FOREIGN KEY (publ_id_estado) REFERENCES LA_PETER_MACHINE.estado (estado_id)


ALTER TABLE LA_PETER_MACHINE.publicacion ADD CONSTRAINT FK_publicacion_rubro 
	FOREIGN KEY (publ_cod_rubro) REFERENCES LA_PETER_MACHINE.rubro (rubr_cod)


ALTER TABLE LA_PETER_MACHINE.publicacion ADD CONSTRAINT FK_publicacion_tipo 
	FOREIGN KEY (publ_id_tipo) REFERENCES LA_PETER_MACHINE.tipo (tipo_id)


ALTER TABLE LA_PETER_MACHINE.publicacion ADD CONSTRAINT FK_publicacion_vendedor 
	FOREIGN KEY (publ_id_vendedor) REFERENCES LA_PETER_MACHINE.persona (pers_id)


ALTER TABLE LA_PETER_MACHINE.publicacion ADD CONSTRAINT FK_publicacion_visibilidad 
	FOREIGN KEY (publ_cod_visibilidad) REFERENCES LA_PETER_MACHINE.visibilidad (visi_cod)


ALTER TABLE LA_PETER_MACHINE.roles_usuario ADD CONSTRAINT FK_roles_usuario_rol
	FOREIGN KEY (rolu_id_rol) REFERENCES LA_PETER_MACHINE.rol (rol_id)


ALTER TABLE LA_PETER_MACHINE.roles_usuario ADD CONSTRAINT FK_roles_usuario_usuario 
	FOREIGN KEY (rolu_username) REFERENCES LA_PETER_MACHINE.usuario (usua_username)


ALTER TABLE LA_PETER_MACHINE.persona ADD CONSTRAINT FK_vendedor_usuario 
	FOREIGN KEY (pers_username) REFERENCES LA_PETER_MACHINE.usuario (usua_username)
GO


------------------------------------------------------
--     SE CREAN LOS STORE PROCEDURES UTILIZADOS     --
------------------------------------------------------


create procedure LA_PETER_machine.agregar_funcionalidad_rol(@funcionalidad nvarchar(255),@rol nvarchar(255), @rdo nvarchar(255) output)
as
begin
declare @func_id numeric(18)
set @func_id=(select funcionalidad_id from LA_PETER_MACHINE.funcionalidad  where func_descripcion=@funcionalidad)
declare @rol_id numeric(18)
set @rol_id=(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion=@rol)
								
if not exists(select*
	from LA_PETER_MACHINE.funcionalidad_rol
	where furo_id_funcionalidad=@func_id and
								furo_id_rol=@rol_id)
								begin
								insert into LA_PETER_MACHINE.funcionalidad_rol(furo_id_funcionalidad,furo_id_rol)
								values(@func_id,@rol_id)
								set @rdo='ok'
								end
								else
								set @rdo='ya habilitada'
end
GO
create procedure LA_PETER_MACHINE.crearRol( @descripcion nvarchar(255),@rdo nvarchar(255) output)
	as
	begin
		if not exists (select *
			from LA_PETER_MACHINE.rol
			where rol_descripcion=@descripcion)
			begin
		insert into LA_PETER_MACHINE.Rol(rol_descripcion,rol_habilitado) values(@descripcion,1)
			set @rdo='ok'
			end
			else
			set @rdo='ya existe'
	end
	GO
	create procedure LA_PETER_MACHINE.eliminar_funcionalidad_rol(@funcionalidad nvarchar(255),@rol nvarchar(255), @rdo nvarchar(255) output)
as
begin
declare @func_id numeric(18)
set @func_id=(select funcionalidad_id from LA_PETER_MACHINE.funcionalidad  where func_descripcion=@funcionalidad)
declare @rol_id numeric(18)
set @rol_id=(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion=@rol)
								
if  exists(select*
	from LA_PETER_MACHINE.funcionalidad_rol
	where furo_id_funcionalidad=@func_id and
								furo_id_rol=@rol_id)
								begin
								delete from LA_PETER_MACHINE.funcionalidad_rol where furo_id_funcionalidad=@func_id and furo_id_rol=@rol_id
								set @rdo='ok'
								end
								else
								set @rdo='El rol no tiene esa funcionalidad'
end
select * from LA_PETER_MACHINE.funcionalidad
select * from LA_PETER_MACHINE.rol
GO
create procedure LA_PETER_MACHINE.deshabilitar_rol(@rol nvarchar(255),@rdo nvarchar(255))
as
begin
	declare @id_rol numeric(18)
	set @id_rol=(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion=@rol)
	if exists (select * from LA_PETER_MACHINE.rol where rol_id=@id_rol)
	begin
	update LA_PETER_MACHINE.rol
	set rol_habilitado=0
	where rol_id=@id_rol
	set @rdo='ok'
	delete from LA_PETER_MACHINE.funcionalidad_rol where furo_id_rol=@id_rol 
	end
	else
	set @rdo='no existe el rol'
end
GO
create procedure LA_PETER_MACHINE.habilitar_rol(@rol nvarchar(255),@rdo nvarchar(255))
as
begin
	declare @id_rol numeric(18)
	set @id_rol=(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion=@rol)
	if exists (select * from LA_PETER_MACHINE.rol where rol_id=@id_rol)
	begin
	update LA_PETER_MACHINE.rol
	set rol_habilitado=1
	where rol_id=@id_rol
	set @rdo='ok'
	end
	else
	set @rdo='no existe el rol'
end
GO
create procedure LA_PETER_MACHINE.Controlar_Rol_Habilitado(@rol nvarchar(255),@rdo nvarchar(255) output)
as
begin
declare @hab bit
select @hab=rol_habilitado from LA_PETER_MACHINE.rol where @rol=rol_descripcion
	if(@hab=1)
	begin
	set @rdo='ok'
	end
	else
	
	set @rdo='rol deshabilitado'
end
GO

create procedure LA_PETER_MACHINE.Crear_Cliente(
@usuario nvarchar(255),@pasword nvarchar(20),@nombre nvarchar(255),
@apellido nvarchar(255),@dni nvarchar(255),@fecha_nac nvarchar(255),
@mail nvarchar(255),@telefono nvarchar(50),@calle nvarchar(255),@cod_postal nvarchar(50),
@ciudad nvarchar(255),@numero nvarchar(255),@piso nvarchar(255),@depto nvarchar(50),@tipo_DNI nvarchar(255),@fechaCreacion nvarchar(255),
@rdo nvarchar(255) output)
as
begin
begin try
	declare @hash varbinary(20)
	set @hash=HASHBYTES('sha2_256',@pasword)
	declare @fecha datetime
	set @fecha=@fecha_nac
	if not exists(select * from LA_PETER_MACHINE.cliente where clie_id_tipo_doc=(select type_id from LA_PETER_MACHINE.document_type where @tipo_DNI=type_descripcion) and clie_dni=CAST(@dni AS NUMERIC))
	begin
	if not exists(select * from LA_PETER_MACHINE.usuario where usua_username=@usuario)
	begin
	insert into LA_PETER_MACHINE.usuario(usua_username,usua_password,usua_habilitado)values(@usuario,@hash,1)
	insert into LA_PETER_MACHINE.persona(pers_ciudad,pers_cod_postal,pers_depto,
	pers_domicilio_calle,pers_mail,pers_numero_calle,pers_piso,pers_telefono,pers_username,pers_habilitado,pers_fecha_creacion)values(
	@ciudad,@cod_postal,@depto,@calle,@mail,cast(@numero as numeric),cast(@piso as numeric),@telefono,@usuario,1,CONVERT(datetime,@fechaCreacion,121))
	insert into LA_PETER_MACHINE.cliente(clie_apellido,clie_dni,
	clie_fecha_nac,clie_nombre,clie_id_tipo_doc,clie_id_persona)values(@apellido,cast(@dni as numeric),
	@fecha,@nombre,(select type_id from LA_PETER_MACHINE.document_type where type_descripcion=@tipo_DNI),
	(select pers_id from LA_PETER_MACHINE.persona where pers_username=@usuario))
	insert into LA_PETER_MACHINE.roles_usuario(rolu_username,rolu_id_rol)values(@usuario,
	(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion='cliente'))
	set @rdo='ok'
	end
	else
	set @rdo='usuario en uso'
	end
	else
	set @rdo='Ya existe el cliente'
 end try
begin catch
	if exists(select * from LA_PETER_MACHINE.usuario where usua_username=@usuario)
	begin
	delete from LA_PETER_MACHINE.usuario where usua_username=@usuario
	end
	set @rdo='Error de ingreso' 
end catch
end 

GO

create procedure LA_PETER_MACHINE.Controlar_Usuario_Habilitado(@Usuario nvarchar(255),@rdo nvarchar(255) output)
as
begin
declare @hab bit
select @hab=usua_habilitado from LA_PETER_MACHINE.usuario where usua_username=@Usuario
	if(@hab=1)
	begin
	set @rdo='ok'
	end
	else
	
	set @rdo='usuario deshabilitado'
end
GO
create procedure LA_PETER_MACHINE.Deshabilitar_Usuario(@Usuario nvarchar(255))
as
begin
	
	if exists (select * from LA_PETER_MACHINE.usuario where usua_username=@Usuario)
	begin
	update LA_PETER_MACHINE.usuario
	set usua_habilitado=0
	where usua_username=@Usuario
	end
end
GO
create procedure LA_PETER_MACHINE.Habilitar_Usuario(@Usuario nvarchar(255))
as
begin
	if exists (select * from LA_PETER_MACHINE.usuario where usua_username=@Usuario)
	begin
	update LA_PETER_MACHINE.usuario
	set usua_habilitado=1
	where usua_username=@Usuario
	end
end
GO
create procedure LA_PETER_machine.agregar_Usuario_Rol(@usuario nvarchar(255),@rol nvarchar(255), @rdo nvarchar(255) output)
as
begin
declare @rol_id numeric(18)
set @rol_id=(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion=@rol)
								
if not exists(select*
	from LA_PETER_MACHINE.roles_usuario
	where rolu_username=@usuario and
								rolu_id_rol=@rol_id)
								begin
								insert into LA_PETER_MACHINE.roles_usuario(rolu_username,rolu_id_rol)
								values(@usuario,@rol_id)
								set @rdo='ok'
								end
								else
								set @rdo='rol activo'
end
GO
create procedure LA_PETER_MACHINE.eliminar_usuario_rol(@usuario nvarchar(255),@rol nvarchar(255), @rdo nvarchar(255) output)
as
begin
declare @rol_id numeric(18)
set @rol_id=(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion=@rol)
								
if  exists(select*
	from LA_PETER_MACHINE.roles_usuario
	where @usuario=rolu_username and
								rolu_id_rol=@rol_id)
								begin
								delete from LA_PETER_MACHINE.roles_usuario where rolu_username=@usuario and rolu_id_rol=@rol_id
								set @rdo='ok'
								end
								else
								set @rdo='El usuario no tiene ese rol'
end
GO
create procedure LA_PETER_MACHINE.Crear_Empresa(@contacto nvarchar(255),
@usuario nvarchar(255),@pasword nvarchar(20),@nombre nvarchar(255),@cuit nvarchar(255),
@mail nvarchar(255),@telefono nvarchar(50),@calle nvarchar(255),@cod_postal nvarchar(50),
@ciudad nvarchar(255),@numero nvarchar(255),@piso nvarchar(255),@depto nvarchar(50), @fechaCreacion nvarchar(255),
@rdo nvarchar(255) output)
as
begin
begin try
	declare @hash varbinary(20)
	set @hash=HASHBYTES('sha2_256',@pasword)

	if not exists(select * from LA_PETER_MACHINE.empresa where empr_cuit=@cuit)
	begin
	if not exists(select * from LA_PETER_MACHINE.usuario where usua_username=@usuario)
	begin
	insert into LA_PETER_MACHINE.usuario(usua_username,usua_password,usua_habilitado)values(@usuario,@hash,1)
	insert into LA_PETER_MACHINE.persona(pers_ciudad,pers_cod_postal,pers_depto,
	pers_domicilio_calle,pers_mail,pers_numero_calle,pers_piso,pers_telefono,pers_username,pers_habilitado,pers_fecha_creacion)values(
	@ciudad,@cod_postal,@depto,@calle,@mail,cast(@numero as numeric),cast(@piso as numeric),@telefono,@usuario,1,CONVERT(datetime,@fechaCreacion,121))
	insert into LA_PETER_MACHINE.empresa(empr_cuit,
	empr_nombre_contacto,empr_razon_social,empr_id_persona)values(@cuit,@contacto,
	@nombre,
	(select pers_id from LA_PETER_MACHINE.persona where pers_username=@usuario))
	insert into LA_PETER_MACHINE.roles_usuario(rolu_username,rolu_id_rol)values(@usuario,
	(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion='empresa'))
	set @rdo='ok'
	end
	else
	set @rdo='usuario en uso'
	end
	else
	set @rdo='Ya existe la empresa'
 end try
begin catch
	if exists(select * from LA_PETER_MACHINE.usuario where usua_username=@usuario)
	begin
	delete from LA_PETER_MACHINE.usuario where usua_username=@usuario
	end
	set @rdo='Error de ingreso' 
end catch
end 

GO
 create procedure LA_PETER_MACHINE.Modificar_Empresa(@usuario nvarchar(255),@pass nvarchar(20),@ciudad nvarchar(255),
 @contacto nvarchar(255),@razon nvarchar(255),@mail nvarchar(255),@telefono nvarchar(50),@calle nvarchar(255),@cod_postal nvarchar(50),
 @numero numeric(18),@dpto nvarchar(50),@piso numeric(18),@rdo nvarchar(255) output)
 as
 begin
 begin try
	declare @hash varbinary(20)
	set @hash=HASHBYTES('sha2_256',@pass)
 if(@pass!='')
 begin
 update LA_PETER_MACHINE.usuario 
 set usua_password=@hash
 where usua_username=@usuario
 end
 update LA_PETER_MACHINE.persona
 set pers_ciudad=@ciudad,pers_cod_postal=@cod_postal,pers_depto=@dpto,pers_domicilio_calle=@calle,
 pers_mail=@mail,pers_numero_calle=@numero,pers_piso=@piso,pers_telefono=@telefono
 where pers_username=@usuario
 
 update LA_PETER_MACHINE.empresa
 set empr_nombre_contacto=@contacto,empr_razon_social=@razon
 where empr_id_persona=(select pers_id from LA_PETER_MACHINE.persona where pers_username=@usuario)
 set @rdo='ok'
 end try
 begin catch
 set @rdo='Error de ingreso'
 end catch
 end

GO
create procedure LA_PETER_MACHINE.CambiarContraseña(@usuario nvarchar(255),@contraseñaNueva nvarchar(20),@contraseñaVieja nvarchar(20),@rdo nvarchar(255) OUTPUT)
as 
begin
declare @hashViejo varbinary(20)
set @hashViejo=HASHBYTES('sha2_256',@contraseñaVieja)

if exists (select* from LA_PETER_MACHINE.usuario
where usua_username=@usuario and usua_password=@contraseñaVieja)
begin
declare @hashNuevo varbinary(20)
set @hashNuevo=HASHBYTES('sha2_256',@contraseñaNueva)
update LA_PETER_MACHINE.usuario
set usua_password=@hashNuevo
where usua_username=@usuario
set @rdo='OK'
end
else
set @rdo='Contraseña incorrecta'

end
 
GO
 create procedure LA_PETER_MACHINE.Modificar_Cliente(@usuario nvarchar(255),@pass nvarchar(20),@ciudad nvarchar(255),
 @apellido nvarchar(255),@nombre nvarchar(255),@mail nvarchar(255),@telefono nvarchar(50),@calle nvarchar(255),@cod_postal nvarchar(50),
 @numero numeric(18),@dpto nvarchar(50),@piso numeric(18),@fecha nvarchar(255),@rdo nvarchar(255) output)
 as
 begin
 begin try
	declare @fech datetime
		set @fech=@fecha
	declare @hash varbinary(20)
	set @hash=HASHBYTES('sha2_256',@pass)
 if(@pass!='')
 begin
 update LA_PETER_MACHINE.usuario 
 set usua_password=@hash
 where usua_username=@usuario
 end
 update LA_PETER_MACHINE.persona
 set pers_ciudad=@ciudad,pers_cod_postal=@cod_postal,pers_depto=@dpto,pers_domicilio_calle=@calle,
 pers_mail=@mail,pers_numero_calle=@numero,pers_piso=@piso,pers_telefono=@telefono
 where pers_username=@usuario
 
 update LA_PETER_MACHINE.cliente
 set clie_apellido=@apellido,clie_fecha_nac=@fech,clie_nombre=@nombre
 where clie_id_persona=(select pers_id from LA_PETER_MACHINE.persona where pers_username=@usuario)
 set @rdo='ok'
 end try
 begin catch
 set @rdo='Error de ingreso'
 end catch
 end
 GO

 create function LA_PETER_MACHINE.topDeVendedoresPorMontoFacturado(@fechaInicio nvarchar(255), @fechaFin nvarchar(255))
returns @T table(Nombre nvarchar(255))
as
begin
declare @fecha_inicio Datetime
set @fecha_inicio=@fechaInicio
declare @fecha_fin Datetime
set @fecha_fin=@fechaFin
insert into @T
select top 5 Nombre from (select clie_nombre + ' ' + clie_apellido as Nombre,fact_total from LA_PETER_MACHINE.factura, LA_PETER_MACHINE.cliente
where fact_id_vendedor=clie_id_persona and fact_fecha>=@fecha_inicio and fact_fecha<=@fecha_fin
union all
select empr_razon_social as Nombre, fact_total from LA_PETER_MACHINE.factura, LA_PETER_MACHINE.empresa 
where fact_id_vendedor=empr_id_persona and fact_fecha>=@fecha_inicio and fact_fecha<=@fecha_fin) as t
group by Nombre
order by sum(fact_total) desc
return
end
 Go

 create function LA_PETER_MACHINE.topDeProductosNoVendidos(@fechaInicio nvarchar(255), @fechaFin nvarchar(255), @visibilidad nvarchar(255))
returns @T table(Nombre nvarchar(255))
as
begin
declare @fecha_inicio Datetime
set @fecha_inicio=@fechaInicio
declare @fecha_fin Datetime
set @fecha_fin=@fechaFin
insert into @T
select top 5  Nombre from (select    clie_nombre +' '+ clie_apellido as Nombre, sum(publ_cantidad) as cantidad, publ_fecha_fin as fecha, publ_cod_visibilidad as visibilidad 
 from LA_PETER_MACHINE.publicacion, LA_PETER_MACHINE.cliente
where publ_cod_visibilidad=(select  visi_cod  from LA_PETER_MACHINE.visibilidad where 
visi_descripcion=@visibilidad) and
 publ_fecha_fin>=@fecha_inicio and publ_fecha_fin<=@fecha_fin and 
 publ_id_vendedor=clie_id_persona
 group by clie_nombre,clie_apellido,publ_cantidad,publ_fecha_fin,publ_cod_visibilidad
union all 
select  empr_razon_social as Nombre, sum(publ_cantidad) as cantidad, publ_fecha_fin as fecha, publ_cod_visibilidad as visibilidad from LA_PETER_MACHINE.publicacion, LA_PETER_MACHINE.empresa
where publ_cod_visibilidad=(select visi_cod  from LA_PETER_MACHINE.visibilidad where 
visi_descripcion=@visibilidad) and
 publ_fecha_fin>=@fecha_inicio and publ_fecha_fin<=@fecha_fin and 
 publ_id_vendedor=empr_id_persona 
 group by empr_razon_social,publ_cantidad,publ_fecha_fin, publ_cod_visibilidad
)as t
group by Nombre
order by sum(cantidad) DESC

return
end

GO

create function LA_PETER_MACHINE.topDeVendedoresPorFacturas(@fechaInicio nvarchar(255), @fechaFin nvarchar(255))
returns @T table(Nombre nvarchar(255))
as
begin
declare @fecha_inicio Datetime
set @fecha_inicio=@fechaInicio
declare @fecha_fin Datetime
set @fecha_fin=@fechaFin
insert into @T
select top 5 Nombre from (select clie_nombre + ' ' + clie_apellido as Nombre from LA_PETER_MACHINE.factura, LA_PETER_MACHINE.cliente
where fact_id_vendedor=clie_id_persona and fact_fecha>=@fecha_inicio and fact_fecha<=@fecha_fin
union all
select empr_razon_social as Nombre from LA_PETER_MACHINE.factura, LA_PETER_MACHINE.empresa 
where fact_id_vendedor=empr_id_persona and fact_fecha>=@fecha_inicio and fact_fecha<=@fecha_fin) as t
group by Nombre
order by count(*) desc
return
end

go
create function LA_PETER_MACHINE.ClienteConMasProductosComprados(@fechaInicio nvarchar(255), @fechaFin nvarchar(255), @rubro nvarchar(255))
returns @T table(Nombre nvarchar(255))
as
begin
insert into @T
select top 5 clie_nombre + ' ' + clie_apellido as Nombre
from LA_PETER_MACHINE.item_factura,LA_PETER_MACHINE.publicacion, LA_PETER_MACHINE.factura,LA_PETER_MACHINE.compra, LA_PETER_MACHINE.cliente
where item_id_publicacion=publicacion_id and  comp_num_factura=fact_num and clie_id_persona=comp_id_comprador and item_num_factura=comp_num_factura and publ_cod_rubro=(select rubr_cod from LA_PETER_MACHINE.rubro
where rubr_descripcion_corta=@rubro) and fact_fecha>=@fechaInicio and fact_fecha<=@fechaFin
group by clie_nombre + ' ' + clie_apellido
order by sum(item_cantidad) DESC
return
end

GO

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

create procedure LA_PETER_MACHINE.buscarFacturas (@fechaDesde varchar(15) , @fechaHasta varchar(15), 
 	@precioDesde nvarchar(200) , @precioHasta nvarchar(200) , @descripcion nvarchar(255), @vendedor nvarchar(255))
as

begin


declare @miVendedor numeric(18,0)
if @vendedor is not null
	set @miVendedor = (select TOP 1 pers_id from LA_PETER_MACHINE.persona where pers_username = @vendedor ) ;

declare @query varchar(255)
declare @fecha_inicio Datetime
set @fecha_inicio=@fechaDesde
declare @fecha_fin Datetime
set @fecha_fin=@fechaHasta


IF @fecha_inicio is Not NULL and @query is not NUll
	set @query = @query + ' AND fact_fecha >= "' + @fecha_inicio + '"'
Else IF @fecha_inicio is Not NULL 
	set @query = 'select * from LA_PETER_MACHINE.factura where fact_fecha >= "' + @fecha_inicio + '"'

IF @fecha_fin is not Null and @query is not null
	set @query = @query + ' AND fact_fecha <= "' + @fecha_fin + '"'
else IF @fecha_fin is not Null
	set @query = 'select * from LA_PETER_MACHINE.factura where fact_fecha <= "' + @fecha_fin + '"'


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


CREATE procedure LA_PETER_MACHINE.publicacionesParaModificar(@username nvarchar(255))
AS
	begin
	declare @vendedor_id numeric(18)
	set @vendedor_id = (select TOP 1 pers_id from LA_PETER_MACHINE.persona where pers_username = @username)

	select * from LA_PETER_MACHINE.publicacion where publ_id_vendedor = @vendedor_id and 
	publ_id_estado = (select estado_id from LA_PETER_MACHINE.estado where esta_descripcion = 'Borrador') or 
	publ_id_estado = (select estado_id from LA_PETER_MACHINE.estado where esta_descripcion = 'Activa')
	end
GO

create procedure LA_PETER_MACHINE.login(@username nvarchar(255), @pass nvarchar(20))
as 
declare @fails numeric(3)
declare @passEncontrada varbinary(20)
declare @habilitado bit
declare @passIngresadaEncript varbinary(20)
set @passIngresadaEncript = hashbytes('sha2_256',@pass);



select @fails=usua_intentos_login, @passEncontrada = usua_password, @habilitado = usua_habilitado
	from LA_PETER_MACHINE.usuario u 
	where u.usua_username = @username

IF @passIngresadaEncript = @passEncontrada 
	--Caso feliz, se encuentra el usuario y la contraseña es correcta
	begin
		if @habilitado = 1-- Verifico que esté habilitado, si lo está le seteo en 0 los intentos.
			update LA_PETER_MACHINE.usuario set usua_intentos_login = 0 
				where usua_username = @username;
	end
	
IF @passIngresadaEncript != @passEncontrada 
--Error de password
	begin
		declare @failsFinales numeric(3) = @fails + 1;
		-- Le incremento los intentos fallidos
		update LA_PETER_MACHINE.usuario set usua_intentos_login = @failsFinales
			where usua_username = @username;
	end
	if @failsFinales >= 3
		-- Si los intentos fallidos son 3, deshabilito el usuario
		begin
			update LA_PETER_MACHINE.usuario set usua_habilitado = 0 
				where usua_username = @username;
		end
	
/* Devuelvo usuario habilitado y roles */



SELECT usua_habilitado, rol_descripcion
	FROM LA_PETER_MACHINE.usuario us, LA_PETER_MACHINE.roles_usuario ru , LA_PETER_MACHINE.rol rol
	WHERE us.usua_username = @username 
	and us.usua_username = ru.rolu_username
	and @passIngresadaEncript =  us.usua_password
	and ru.rolu_id_rol = rol.rol_id;
GO

create procedure LA_PETER_MACHINE.buscarComprasSinCalificar(@username nvarchar(255))
	as
	begin
		select publ_descripcion, comp_id_vendedor, compra_id from LA_PETER_MACHINE.compra, LA_PETER_MACHINE.publicacion, LA_PETER_MACHINE.persona 
		where pers_username = @username and comp_id_vendedor = pers_id and publicacion_id = comp_id_publicacion and comp_id_calificacion is null
	end

go

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
