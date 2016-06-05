------------------------------------------------------
-- SE REALIZAN LOS CREATES DE LAS TABLAS Y COLUMNAS --
------------------------------------------------------

CREATE SCHEMA LA_PETER_MACHINE
CREATE TABLE calificacion ( 
	calificacion_id numeric(18) NOT NULL,
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
	empr_ciudad nvarchar(255),
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
--STORE PROCEDURES	
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
@ciudad nvarchar(255),@numero nvarchar(255),@piso nvarchar(255),@depto nvarchar(50),@tipo_DNI nvarchar(255),
@rdo nvarchar(255) output)
as
begin
begin try
	declare @hash varbinary(20)
	set @hash=HASHBYTES('sha2_256',@pasword)
	if not exists(select * from LA_PETER_MACHINE.cliente where clie_id_tipo_doc=(select type_id from LA_PETER_MACHINE.document_type where @tipo_DNI=type_descripcion) and clie_dni=CAST(@dni AS NUMERIC))
	begin
	if not exists(select * from LA_PETER_MACHINE.usuario where usua_username=@usuario)
	begin
	insert into LA_PETER_MACHINE.usuario(usua_username,usua_password,usua_habilitado)values(@usuario,@hash,1)
	insert into LA_PETER_MACHINE.persona(pers_ciudad,pers_cod_postal,pers_depto,
	pers_domicilio_calle,pers_mail,pers_numero_calle,pers_piso,pers_telefono,pers_username,pers_habilitado)values(
	@ciudad,@cod_postal,@depto,@calle,@mail,cast(@numero as numeric),cast(@piso as numeric),@telefono,@usuario,1)
	insert into LA_PETER_MACHINE.cliente(clie_apellido,clie_dni,
	clie_fecha_nac,clie_nombre,clie_id_tipo_doc,clie_id_persona)values(@apellido,cast(@dni as numeric)
	,@fecha_nac,@nombre,(select type_id from LA_PETER_MACHINE.document_type where type_descripcion=@tipo_DNI),
	(select pers_id from LA_PETER_MACHINE.persona where pers_username=@usuario))
	set @rdo='ok'
	end
	else
	set @rdo='usuario en uso'
	end
	else
	set @rdo='Ya existe el cliente'
 end try
begin catch
	set @rdo='Error de ingreso'

end catch
end 

GO

