------------------------------------------------------
--  SE ELIMINAN LAS FK QUE REFERENCIAN OTRAS TABLAS --
------------------------------------------------------


IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_cliente_tipo_dni') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.cliente DROP CONSTRAINT FK_cliente_tipo_dni;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_cliente_vendedor') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.cliente DROP CONSTRAINT FK_cliente_vendedor;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = ('FK_cliente_vendedor') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.Cliente DROP CONSTRAINT FK_cliente_vendedor;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_factura_vendedor') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.Factura DROP CONSTRAINT FK_factura_vendedor;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_funcionalidad_rol_funcionalidad') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.Funcionalidad_Rol DROP CONSTRAINT FK_funcionalidad_rol_funcionalidad;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_funcionalidad_rol_rol') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.Funcionalidad_Rol DROP CONSTRAINT FK_funcionalidad_rol_rol;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_publicacion_estado') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.Publicacion DROP CONSTRAINT FK_publicacion_estado;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_publicacion_rubro') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.Publicacion DROP CONSTRAINT FK_publicacion_rubro;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_publicacion_tipo') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.Publicacion DROP CONSTRAINT FK_publicacion_tipo;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_publicacion_vendedor') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.Publicacion DROP CONSTRAINT FK_publicacion_vendedor;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_publicacion_visibilidad') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.Publicacion DROP CONSTRAINT FK_publicacion_visibilidad;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_roles_usuario_rol') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.roles_Usuario DROP CONSTRAINT FK_roles_usuario_rol;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_roles_usuario_usuario') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.roles_Usuario DROP CONSTRAINT FK_roles_usuario_usuario;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_vendedor_usuario') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.persona DROP CONSTRAINT FK_vendedor_usuario;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_costo_envio_visibilidad') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.costo_envio DROP CONSTRAINT FK_costo_envio_visibilidad;


------------------------------------------------------
--        SE REALIZAN LOS DROP DE LAS TABLAS        --
------------------------------------------------------


IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.calificacion') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.calificacion;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.cliente') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.cliente;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.compra') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.Compra;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.empresa') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.Empresa;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.publicacion') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.publicacion;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.estado') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.Estado;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.factura') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.Factura;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.funcionalidad_Rol') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.funcionalidad_Rol;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.funcionalidad') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.Funcionalidad;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.item_Factura') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.item_Factura;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.oferta') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.oferta;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.roles_Usuario') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.roles_Usuario;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.rol') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.rol;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.rubro') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.rubro;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.tipo') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.tipo;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.document_type') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.Document_Type;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.usuario') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.Usuario;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.persona') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.persona;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.visibilidad') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.visibilidad;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.costo_envio') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.costo_envio;



------------------------------------------------------
--     SE REALIZA DROP DEL SCRIPT DE MIGRACION      --
------------------------------------------------------

declare @dropSP nvarchar(max)
set @dropSP=(select
    'DROP PROCEDURE [' + routine_schema + '].[' + routine_name + ']'
from 
    information_schema.routines where routine_schema = 'LA_PETER_MACHINE' and routine_type = 'PROCEDURE'
	FOR XML PATH ('')
	)

EXEC(@dropSP)

declare @dropF nvarchar(max)
set @dropF=(select
    'DROP fUNCTION [' + routine_schema + '].[' + routine_name + ']'
from 
    information_schema.routines where routine_schema = 'LA_PETER_MACHINE' and routine_type = 'FUNCTION'
	FOR XML PATH ('')
	)
EXEC(@dropF)

IF EXISTS (SELECT * FROM sys.schemas WHERE name = 'LA_PETER_MACHINE')
DROP SCHEMA LA_PETER_MACHINE

GO

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
	comp_fecha datetime NOT NULL,
	comp_cantidad numeric(18) NOT NULL,
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
	ofer_fecha datetime NOT NULL,
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

create function LA_PETER_MACHINE.controlNull(@valor nvarchar(255))
returns nvarchar(255)
as
begin 
declare @rdo nvarchar(255)

if(@valor='')
begin
set @rdo=null
end
else
begin
set @rdo=@valor
end
return @rdo
end
GO

create procedure LA_PETER_MACHINE.agregar_funcionalidad_rol(@funcionalidad nvarchar(255),@rol nvarchar(255), @rdo nvarchar(255) output)
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
								set @rdo='funcionalidad habilitada correctamente'
								end
								else
								set @rdo='ya habilitada'
end
GO

create procedure LA_PETER_MACHINE.crear_funcionalidad(@descripcion nvarchar(255))
as
begin
if not exists(select *
				from LA_PETER_MACHINE.funcionalidad
				where func_descripcion=@descripcion)
	begin
	insert into LA_PETER_MACHINE.funcionalidad(func_descripcion)
	values(@descripcion)
	end
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
		set @rdo='Rol: ' + @descripcion + ' creado correctamente'
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
								set @rdo='funcionalidad deshabilitada correctamente'
								end
								else
								set @rdo='El rol no tiene esa funcionalidad'
end
select * from LA_PETER_MACHINE.funcionalidad
select * from LA_PETER_MACHINE.rol
GO

create procedure LA_PETER_MACHINE.eliminar_funcionalidad(@id numeric(18))
as
begin
delete from LA_PETER_MACHINE.funcionalidad
	where funcionalidad_id=@id
end
GO

create procedure LA_PETER_MACHINE.eliminarRol(@id numeric(18))
as
begin 
	delete from LA_PETER_MACHINE.rol
		where rol_id=@id
end
GO

create procedure LA_PETER_MACHINE.eliminarVisibilidad(@codigo numeric(18,0))
as
begin 
	delete from LA_PETER_MACHINE.visibilidad
		where visi_cod=@codigo
end
GO

create procedure LA_PETER_MACHINE.deshabilitar_rol(@rol nvarchar(255),@rdo nvarchar(255) output)
as
begin
	declare @id_rol numeric(18)
	set @id_rol=(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion=@rol)
	if exists (select * from LA_PETER_MACHINE.rol where rol_id=@id_rol)
	begin
	update LA_PETER_MACHINE.rol
	set rol_habilitado=0
	where rol_id=@id_rol
	set @rdo='Rol deshabilitado'
	delete from LA_PETER_MACHINE.funcionalidad_rol where furo_id_rol=@id_rol 
	end
	else
	set @rdo='no existe el rol'
end
GO

create procedure LA_PETER_MACHINE.habilitar_rol(@rol nvarchar(255),@rdo nvarchar(255) output)
as
begin
	declare @id_rol numeric(18)
	set @id_rol=(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion=@rol)
	if exists (select * from LA_PETER_MACHINE.rol where rol_id=@id_rol)
	begin
	update LA_PETER_MACHINE.rol
	set rol_habilitado=1
	where rol_id=@id_rol
	set @rdo='Rol habilitado'
	end
	else
	set @rdo='no existe el rol'
end
GO

create procedure LA_PETER_MACHINE.modificarDescripcionRol(@descripcion nvarchar(255),@id numeric(18))
as
begin
update LA_PETER_MACHINE.rol
	set rol_descripcion=@descripcion
	where rol_id=@id
end
GO

create procedure LA_PETER_MACHINE.modificarVisibilidad(@codigo numeric(18,0), @precio numeric(18,0), @porcentaje numeric(18,2), @envio bit, @descripcion nvarchar(255))
as
begin
update LA_PETER_MACHINE.visibilidad
	set visi_precio=@precio, visi_porcentaje=@porcentaje, visi_envio=@envio, visi_descripcion=@descripcion
	where visi_cod=@codigo
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
	LA_PETER_MACHINE.controlNull(@ciudad),LA_PETER_MACHINE.controlNull(@cod_postal),LA_PETER_MACHINE.controlNull(@depto),LA_PETER_MACHINE.controlNull(@calle),LA_PETER_MACHINE.controlNull(@mail),
	cast(LA_PETER_MACHINE.controlNull(@numero) as numeric),cast(LA_PETER_MACHINE.controlNull(@piso) as numeric),
	LA_PETER_MACHINE.controlNull(@telefono),@usuario,1,CONVERT(datetime,@fechaCreacion,121))
	insert into LA_PETER_MACHINE.cliente(clie_apellido,clie_dni,
	clie_fecha_nac,clie_nombre,clie_id_tipo_doc,clie_id_persona)values(@apellido,cast(@dni as numeric),
	@fecha,@nombre,(select type_id from LA_PETER_MACHINE.document_type where type_descripcion=@tipo_DNI),
	(select pers_id from LA_PETER_MACHINE.persona where pers_username=@usuario))
	insert into LA_PETER_MACHINE.roles_usuario(rolu_username,rolu_id_rol)values(@usuario,
	(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion='cliente'))
	set @rdo='cliente creado correctamente'
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

create procedure LA_PETER_MACHINE.Deshabilitar_Usuario(@Usuario nvarchar(255),@rdo nvarchar(255) output)
as
begin
	
	if exists (select * from LA_PETER_MACHINE.usuario where usua_username=@Usuario)
	begin
	update LA_PETER_MACHINE.usuario
	set usua_habilitado=0
	where usua_username=@Usuario
	set @rdo='usuario deshabilitado'
	end
	else
	begin
	set @rdo='usuario inexistente'
	end
end
GO

create procedure LA_PETER_MACHINE.Habilitar_Usuario(@Usuario nvarchar(255), @rdo nvarchar(255) output)
as
begin
	if exists (select * from LA_PETER_MACHINE.usuario where usua_username=@Usuario)
	begin
	update LA_PETER_MACHINE.usuario
	set usua_habilitado=1
	where usua_username=@Usuario
	set @rdo='usuario habilitado'
	end
	else
	begin
	set @rdo='usuario inexistente'
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
								set @rdo='rol asignado correctamente'
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
								set @rdo='Rol deshabilitado correctamente'
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
	LA_PETER_MACHINE.controlNull(@ciudad),LA_PETER_MACHINE.controlNull(@cod_postal),
	LA_PETER_MACHINE.controlNull(@depto),LA_PETER_MACHINE.controlNull(@calle),LA_PETER_MACHINE.controlNull(@mail),
	cast(LA_PETER_MACHINE.controlNull(@numero) as numeric),cast(LA_PETER_MACHINE.controlNull(@piso) as numeric),
	LA_PETER_MACHINE.controlNull(@telefono),@usuario,1,CONVERT(datetime,@fechaCreacion,121))
	insert into LA_PETER_MACHINE.empresa(empr_cuit,
	empr_nombre_contacto,empr_razon_social,empr_id_persona)values(@cuit,LA_PETER_MACHINE.controlNull(@contacto),
	@nombre,
	(select pers_id from LA_PETER_MACHINE.persona where pers_username=@usuario))
	insert into LA_PETER_MACHINE.roles_usuario(rolu_username,rolu_id_rol)values(@usuario,
	(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion='empresa'))
	set @rdo='empresa creada correctamente'
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
 @numero nvarchar(255),@dpto nvarchar(50),@piso nvarchar(255),@rdo nvarchar(255) output)
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
 set pers_ciudad=LA_PETER_MACHINE.controlNull(@ciudad),pers_cod_postal=LA_PETER_MACHINE.controlNull(@cod_postal),
 pers_depto=LA_PETER_MACHINE.controlNull(@dpto),pers_domicilio_calle=LA_PETER_MACHINE.controlNull(@calle),
 pers_mail=LA_PETER_MACHINE.controlNull(@mail),pers_numero_calle=cast(LA_PETER_MACHINE.controlNull(@numero) as numeric),
 pers_piso=cast(LA_PETER_MACHINE.controlNull(@piso) as numeric),pers_telefono=LA_PETER_MACHINE.controlNull(@telefono)
 where pers_username=@usuario
 
 update LA_PETER_MACHINE.empresa
 set empr_nombre_contacto=LA_PETER_MACHINE.controlNull(@contacto),empr_razon_social=@razon
 where empr_id_persona=(select pers_id from LA_PETER_MACHINE.persona where pers_username=@usuario)
 set @rdo='empresa modificada correctamente'
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
 @numero nvarchar(255),@dpto nvarchar(50),@piso nvarchar(255),@fecha nvarchar(255),@rdo nvarchar(255) output)
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
 set pers_ciudad=LA_PETER_MACHINE.controlNull(@ciudad),pers_cod_postal=LA_PETER_MACHINE.controlNull(@cod_postal),
 pers_depto=LA_PETER_MACHINE.controlNull(@dpto),pers_domicilio_calle=LA_PETER_MACHINE.controlNull(@calle),
 pers_mail=LA_PETER_MACHINE.controlNull(@mail),pers_numero_calle=cast(LA_PETER_MACHINE.controlNull(@numero) as numeric),
 pers_piso=cast(LA_PETER_MACHINE.controlNull(@piso) as numeric),pers_telefono=LA_PETER_MACHINE.controlNull(@telefono)
 where pers_username=@usuario
 
 update LA_PETER_MACHINE.cliente
 set clie_apellido=@apellido,clie_fecha_nac=@fech,clie_nombre=@nombre
 where clie_id_persona=(select pers_id from LA_PETER_MACHINE.persona where pers_username=@usuario)
 set @rdo='cliente modificado correctamente'
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
GO

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

begin
set @query = @query + ' order by fact_fecha desc' + ' OFFSET (' + convert(nvarchar(255),@numerosPagina) + ' - 1) *' +  convert(varchar(255),@registrosPorPagina)
						 + ' ROWS FETCH NEXT ' + convert(varchar(255),@registrosPorPagina) + ' ROWS ONLY'
end 

exec (@query)

end

GO

create procedure LA_PETER_MACHINE.SP_Cantidad_Paginas_Facturas 
(@fechaDesde varchar(15) , @fechaHasta varchar(15), @precioDesde nvarchar(200),
 @precioHasta nvarchar(200) , @descripcion nvarchar(255), @vendedor nvarchar(255))
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

create procedure LA_PETER_MACHINE.publicacionesParaModificar(@username nvarchar(255))
AS
	begin
	declare @vendedor_id numeric(18)
	set @vendedor_id = (select TOP 1 pers_id from LA_PETER_MACHINE.persona where pers_username = @username)

	select publicacion_id, publ_descripcion, publ_precio, publ_costo,(select rubr_descripcion_corta from LA_PETER_MACHINE.rubro where rubr_cod = publ_cod_rubro) as Rubro,
	(select visi_descripcion from LA_PETER_MACHINE.visibilidad where visi_cod = publ_cod_visibilidad) as Visibilidad,
	(select esta_descripcion from LA_PETER_MACHINE.estado where estado_id = publ_id_estado) as Estado,
	publ_fecha_inicio, publ_fecha_fin, publ_preguntas, publ_cantidad, (select tipo_descripcion from LA_PETER_MACHINE.tipo where tipo_id = publ_id_tipo) as Tipo, publ_envio_habilitado
	from LA_PETER_MACHINE.publicacion where publ_id_vendedor = @vendedor_id and 
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

create procedure LA_PETER_MACHINE.calificar(@idCompra numeric(18,0), @valor numeric(5,0), @detalle nvarchar(100), @vendedorId numeric(18,0))
	as
	begin
		DECLARE @idCalificacion numeric(18,0);

		insert into LA_PETER_MACHINE.calificacion(cali_valor,cali_detalle,cali_id_vendedor) values(@valor,@detalle,@vendedorId)

		select @idCalificacion=calificacion_id from LA_PETER_MACHINE.calificacion where cali_valor = @valor and cali_detalle = @detalle and cali_id_vendedor = @vendedorId

		update LA_PETER_MACHINE.compra set comp_id_calificacion = @idCalificacion where compra_id = @idCompra

	end
GO

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

create procedure LA_PETER_MACHINE.crearVisibilidad( @precio numeric(18,0), @porcentaje numeric(18,2), @envio bit, @descripcion nvarchar(255), @rdo nvarchar(255) output)
	as
	begin
		if not exists (select *
			from LA_PETER_MACHINE.visibilidad
			where visi_descripcion=@descripcion)
			begin
		insert into LA_PETER_MACHINE.visibilidad(visi_precio,visi_porcentaje,visi_envio,visi_descripcion) values(@descripcion,@porcentaje,@envio,@descripcion)
			set @rdo='ok'
			end
			else
			set @rdo='ya existe'
	end
GO


CREATE PROCEDURE LA_PETER_MACHINE.SP_ListadoRubros
AS
	select rubr_descripcion_corta from LA_PETER_MACHINE.rubro
GO

CREATE PROCEDURE LA_PETER_MACHINE.SP_InsertarFactura_ComprarOfertar
(@publ_id INT,
@date DATETIME,
@cantidad INT)
AS

DECLARE @costoEnvio INT,
		@costoPublicacion INT,
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
		SET @costoPublicacion = 0
		SET @costoPorcentaje = 0
	END
ELSE 
	BEGIN
		SET @costoPublicacion = (select visi_precio from LA_PETER_MACHINE.visibilidad where visi_cod = @codVisibilidad)
		SET @costoPorcentaje = @precioPubli * (select visi_porcentaje from LA_PETER_MACHINE.visibilidad where visi_cod = @codVisibilidad)
	END


SET @total = (@costoPorcentaje*@cantidad) + @costoEnvio + @costoPublicacion


INSERT INTO LA_PETER_MACHINE.factura(fact_fecha, fact_total, fact_forma_pago, fact_id_vendedor)
		VALUES (@fecha,@total,'Efectivo',@vendedor)

SET @numFact = (select TOP 1 fact_num from LA_PETER_MACHINE.factura)

IF @codVisibilidad != 10006
	BEGIN
		INSERT INTO LA_PETER_MACHINE.item_factura VALUES (@numFact,@publ_id, @cantidad, @costoPorcentaje)
		INSERT INTO LA_PETER_MACHINE.item_factura VALUES (@numFact,@publ_id, 1, @costoPublicacion)
		INSERT INTO LA_PETER_MACHINE.item_factura VALUES (@numFact,@publ_id, 1, @costoEnvio)
	END

GO

CREATE FUNCTION LA_PETER_MACHINE.ListaATabla_ComprarOfertar (@list nvarchar(MAX))
   RETURNS @tbl TABLE (number int NOT NULL) AS
BEGIN
   DECLARE @pos        int,
           @nextpos    int,
           @valuelen   int

   SELECT @pos = 0, @nextpos = 1

   WHILE @nextpos > 0
   BEGIN
      SELECT @nextpos = charindex(',', @list, @pos + 1)
      SELECT @valuelen = CASE WHEN @nextpos > 0
                              THEN @nextpos
                              ELSE len(@list) + 1
                         END - @pos - 1
      INSERT @tbl (number)
         VALUES (convert(int, substring(@list, @pos + 1, @valuelen)))
      SELECT @pos = @nextpos
   END
   RETURN
END
GO


CREATE PROCEDURE LA_PETER_MACHINE.SP_ListadoComprarOfertar
(@registrosPorPagina INT,
@numerosPagina INT,
@cliente INT,
@tipo VARCHAR(8),
@terminoBuscado as varchar(255),
@rubros as varchar(255))
AS
	DECLARE @ID_TIPO INT

	BEGIN 
	SET NOCOUNT ON
	
	IF (@tipo = 'SUBASTAS') 
		BEGIN 
			SET @ID_TIPO = 2
		END
	ELSE
		BEGIN
			SET @ID_TIPO = 1
		END	
		
	SELECT publicacion_id, publ_descripcion, publ_precio, publ_cantidad, publ_id_vendedor
		FROM LA_PETER_MACHINE.publicacion JOIN LA_PETER_MACHINE.ListaATabla_ComprarOfertar(@rubros) r on publ_cod_rubro = r.number,
			 LA_PETER_MACHINE.estado, LA_PETER_MACHINE.tipo		
		WHERE  publ_id_vendedor != @cliente
			and publ_id_estado = estado_id and esta_descripcion = 'Finalizada'
			and publ_id_tipo = @ID_TIPO
			and	publ_descripcion LIKE '%' + @terminoBuscado + '%'
			and publ_cantidad > 0
		GROUP BY publicacion_id, publ_descripcion, publ_precio, publ_id_vendedor, publ_id_tipo, publ_cantidad, publ_cod_visibilidad
		ORDER BY publ_cod_visibilidad asc

	OFFSET (@numerosPagina - 1) * @registrosPorPagina ROWS
	FETCH NEXT @registrosPorPagina ROWS ONLY
	END;
GO

CREATE PROCEDURE LA_PETER_MACHINE.SP_Cantidad_Paginas_ComprarOfertar
(@registrosPorPagina INT,
@totalDePaginas INT OUTPUT,
@cliente INT,
@tipo VARCHAR(8),
@terminoBuscado as varchar(255),
@rubros as varchar(255))
AS

DECLARE @cantidadFilas int
	
	DECLARE @ID_TIPO INT

	BEGIN 
	SET NOCOUNT ON
	
	BEGIN
	IF (@tipo = 'SUBASTAS') 
		BEGIN 
			SET @ID_TIPO = 2
		END
	ELSE
		BEGIN
			SET @ID_TIPO = 1
		END	
	END
		SET @cantidadFilas = 
			(select COUNT(distinct publicacion_id) 
			FROM LA_PETER_MACHINE.publicacion JOIN LA_PETER_MACHINE.ListaATabla_ComprarOfertar(@rubros) r on publ_cod_rubro = r.number,
			 LA_PETER_MACHINE.estado, LA_PETER_MACHINE.tipo		
					WHERE  publ_id_vendedor != @cliente
						and publ_id_estado = estado_id and esta_descripcion = 'Finalizada'
						and publ_id_tipo = @ID_TIPO
						and	publ_descripcion LIKE '%' + @terminoBuscado + '%'
						and publ_cantidad > 0)						
		SET @totalDePaginas = @cantidadFilas / @registrosPorPagina
		IF (@cantidadFilas % @registrosPorPagina) > 0
			BEGIN
				SET @totalDePaginas=@totalDePaginas+1
				RETURN;
			END
		IF @totalDePaginas = 0
			BEGIN
				SET @totalDePaginas=1
				RETURN;
			END
	END
GO

CREATE PROCEDURE LA_PETER_MACHINE.SP_ObtenerCodRubro_ComprarOfertar
(@detalleRubro NVARCHAR(255),
@CodRubro INT OUTPUT)
AS

SET @CodRubro = (select rubr_cod from LA_PETER_MACHINE.rubro where rubr_descripcion_corta = @detalleRubro)

GO

CREATE PROCEDURE LA_PETER_MACHINE.SP_EjecutarCompra_ComprarOfertar
(@publ_id INT,
@cantidad INT)
AS

UPDATE LA_PETER_MACHINE.publicacion SET publ_cantidad = (publ_cantidad - @cantidad) WHERE publicacion_id = @publ_id

GO

CREATE PROCEDURE LA_PETER_MACHINE.SP_ObtenerIdUser
(@username NVARCHAR(255),
@idUser INT OUTPUT)
AS

SET @idUser = (select pers_id from LA_PETER_MACHINE.persona where pers_username = @username)

GO

CREATE PROCEDURE LA_PETER_MACHINE.SP_EjecutarOferta_ComprarOfertar
(@publ_id INT,
@precio INT)
AS

UPDATE LA_PETER_MACHINE.publicacion SET publ_precio = @precio  WHERE publicacion_id = @publ_id

GO


create PROCEDURE LA_PETER_MACHINE.SP_ObtenerCalificacionProm_Historial
(@idUsuario INT, @calificacionPromedio numeric(12,3) OUTPUT)
AS

SET @calificacionPromedio = 
		(select AVG(E.cali_valor) as calif_prom from LA_PETER_MACHINE.compra C, LA_PETER_MACHINE.calificacion E
			where C.comp_id_calificacion is not null
				and C.comp_id_calificacion = E.calificacion_id
				and C.comp_id_comprador = @idUsuario
			group by C.comp_id_comprador
		)

	if (@calificacionPromedio is null)
		begin
		SET @calificacionPromedio = 0
		end
GO


CREATE PROCEDURE LA_PETER_MACHINE.SP_ObtenerComprasPorCalificar_Historial
(@idUsuario INT, @porCalificar int OUTPUT)
AS

SET @porCalificar = 
		(select COUNT(*) from LA_PETER_MACHINE.compra C
			where C.comp_id_calificacion is null
				and C.comp_id_comprador = @idUsuario
		)
GO

CREATE PROCEDURE LA_PETER_MACHINE.finalizarPublicaciones(@fechaSys nvarchar(255))
AS
BEGIN
update LA_PETER_MACHINE.publicacion
	SET publ_id_estado=4
	WHERE publ_id_estado != 4 and publ_fecha_fin is not null and publ_fecha_fin < CONVERT(datetime,@fechaSys,121)
END;
GO




CREATE PROCEDURE LA_PETER_MACHINE.SP_Listado_Historial
(@registrosPorPagina INT,
@numerosPagina INT,
@cliente nvarchar(255),
@tipo INT)
AS	
BEGIN

	if(@tipo = 1)	
		BEGIN
		SELECT C.comp_fecha as Fecha, P.publ_descripcion as Descripcion, C.comp_cantidad as Cantidad,
				 P.publ_precio as Precio, I.pers_username as Vendedor
			FROM LA_PETER_MACHINE.compra C, LA_PETER_MACHINE.publicacion P, LA_PETER_MACHINE.persona I 
			where C.comp_id_publicacion = P.publicacion_id 
				and C.comp_username = @cliente
				and C.comp_id_vendedor = I.pers_id
			order by C.comp_fecha
		OFFSET (@numerosPagina - 1) * @registrosPorPagina ROWS
		FETCH NEXT @registrosPorPagina ROWS ONLY
		END
		
	if(@tipo = 2)
		BEGIN
		SELECT O.ofer_fecha as Fecha, P.publ_descripcion as Descripcion, O.ofer_valor as Valor_de_Oferta, I.pers_username as Vendedor 
			FROM LA_PETER_MACHINE.oferta O, LA_PETER_MACHINE.publicacion P, LA_PETER_MACHINE.persona I
			where O.ofer_id_publicacion = P.publicacion_id 
				and O.ofer_username = @cliente
				and I.pers_id = P.publ_id_vendedor
			order by O.ofer_fecha
		OFFSET (@numerosPagina - 1) * @registrosPorPagina ROWS
		FETCH NEXT @registrosPorPagina ROWS ONLY
		END

END;
GO

CREATE PROCEDURE LA_PETER_MACHINE.SP_Cantidad_Paginas_Historial
(@registrosPorPagina INT,
@totalDePaginas INT OUTPUT,
@cliente nvarchar(255),
@tipo int)
AS

DECLARE @cantidadFilas int
	
BEGIN 
	SET NOCOUNT ON
	
	if(@tipo = 1)	
		BEGIN
			SET @cantidadFilas = (SELECT COUNT(*)
			FROM LA_PETER_MACHINE.compra C, LA_PETER_MACHINE.publicacion P, LA_PETER_MACHINE.persona I 
			where C.comp_id_publicacion = P.publicacion_id 
				and C.comp_username = @cliente
				and C.comp_id_vendedor = I.pers_id)
		END
		
	if(@tipo = 2)
		BEGIN
		SET @cantidadFilas = (SELECT COUNT(*)
			FROM LA_PETER_MACHINE.oferta O, LA_PETER_MACHINE.publicacion P, LA_PETER_MACHINE.persona I
			where O.ofer_id_publicacion = P.publicacion_id 
				and O.ofer_username = @cliente
				and I.pers_id = P.publ_id_vendedor)
		END

		SET @totalDePaginas = @cantidadFilas / @registrosPorPagina
		IF (@cantidadFilas % @registrosPorPagina) > 0
			BEGIN
				SET @totalDePaginas=@totalDePaginas+1
				RETURN;
			END
		IF @totalDePaginas = 0
			BEGIN
				SET @totalDePaginas=1
				RETURN;
			END
	END
GO




------------------------------------------------------
--             SE REALIZA LA MIGRACION              --
------------------------------------------------------


create PROCEDURE LA_PETER_MACHINE.SP_Migracion
AS

--DOCUMENT-TYPE
		insert into LA_PETER_MACHINE.document_type(type_descripcion) values('DNI')
		insert into LA_PETER_MACHINE.document_type(type_descripcion) values('CI')
		insert into LA_PETER_MACHINE.document_type(type_descripcion) values('LR')

--ROL
		insert into LA_PETER_MACHINE.rol(rol_descripcion,rol_habilitado) values('empresa',1)
		insert into LA_PETER_MACHINE.rol(rol_descripcion,rol_habilitado) values('cliente',1)
		insert into LA_PETER_MACHINE.rol(rol_descripcion,rol_habilitado) values('administrativo',1)
		
--FUNCIONALIDAD
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion, func_procedure) values('publicar',					'STORE_publicar')
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion, func_procedure) values('visibilidad',				'STORE_visibilidad')
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion, func_procedure) values('comprar_ofertar',			'STORE_comprar_ofertar')
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion, func_procedure) values('historial_cliente',		'STORE_historial_cliente')
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion, func_procedure) values('calificar',				'STORE_calificar')
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion, func_procedure) values('facturas_realizadas',		'STORE_facturas_realizadas')
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion, func_procedure) values('listado_estadistico',		'STORE_listado_estadistico')
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion, func_procedure) values('adm_usuario',				'STORE_administrar_usuario')
		insert into LA_PETER_MACHINE.funcionalidad(func_descripcion, func_procedure) values('adm_rol',					'STORE_administrar_rol')
		

--FUNCIONALIDAD_ROL
		-- Rol Admin
		insert into	 LA_PETER_MACHINE.funcionalidad_rol(furo_id_funcionalidad,furo_id_rol) 
		values((select funcionalidad_id from LA_PETER_MACHINE.funcionalidad where func_descripcion = 'adm_usuario'),
				(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'administrativo'))
		
		insert into LA_PETER_MACHINE.funcionalidad_rol(furo_id_funcionalidad, furo_id_rol)
		values ((select funcionalidad_id from LA_PETER_MACHINE.funcionalidad where func_descripcion = 'facturas_realizadas'),
			(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'administrativo'))

		insert into LA_PETER_MACHINE.funcionalidad_rol(furo_id_funcionalidad, furo_id_rol)
		values ((select funcionalidad_id from LA_PETER_MACHINE.funcionalidad where func_descripcion = 'listado_estadistico'),
			(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'administrativo'))

		insert into LA_PETER_MACHINE.funcionalidad_rol(furo_id_funcionalidad, furo_id_rol)
		values ((select funcionalidad_id from LA_PETER_MACHINE.funcionalidad where func_descripcion = 'adm_rol'),
		(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'administrativo'))


		
-- Rol Cliente
		insert into LA_PETER_MACHINE.funcionalidad_rol(furo_id_funcionalidad, furo_id_rol) 
		values((select funcionalidad_id from LA_PETER_MACHINE.funcionalidad where func_descripcion = 'comprar_ofertar'),
				(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'cliente'))

		insert into LA_PETER_MACHINE.funcionalidad_rol(furo_id_funcionalidad, furo_id_rol)
			values ((select funcionalidad_id from LA_PETER_MACHINE.funcionalidad where func_descripcion = 'publicar'),
			(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'cliente'))

		insert into LA_PETER_MACHINE.funcionalidad_rol (furo_id_funcionalidad, furo_id_rol)
		values ((select funcionalidad_id from LA_PETER_MACHINE.funcionalidad where func_descripcion = 'calificar'),
		(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'cliente'))

		insert into LA_PETER_MACHINE.funcionalidad_rol (furo_id_funcionalidad, furo_id_rol)
		values ((select funcionalidad_id from LA_PETER_MACHINE.funcionalidad where func_descripcion = 'visibilidad'),
		(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'cliente'))

		insert into LA_PETER_MACHINE.funcionalidad_rol (furo_id_funcionalidad, furo_id_rol)
		values ((select funcionalidad_id from LA_PETER_MACHINE.funcionalidad where func_descripcion = 'historial_cliente'),
		(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'cliente'))
		
-- Rol Empresa
		
		insert into LA_PETER_MACHINE.funcionalidad_rol(furo_id_funcionalidad, furo_id_rol) 
		values((select funcionalidad_id from LA_PETER_MACHINE.Funcionalidad where func_descripcion = 'publicar'),
				(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'empresa'))

		insert into LA_PETER_MACHINE.funcionalidad_rol(furo_id_funcionalidad, furo_id_rol)
		values (( select funcionalidad_id from LA_PETER_MACHINE.funcionalidad where func_descripcion = 'visibilidad'),
		(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'empresa'))


--USUARIO
	declare @hash varbinary(20)
	declare @pass nvarchar(20)
	set @pass = 'w23e'
	set @hash = hashbytes('sha2_256',@pass);

	insert into LA_PETER_MACHINE.usuario(usua_username,usua_password,usua_habilitado,usua_intentos_login) values ('admin',@hash,1,0)

--USUARIO (Empresa)
	insert into LA_PETER_MACHINE.usuario(usua_username, usua_password, usua_habilitado, usua_intentos_login)
	select distinct Publ_Empresa_Mail, @hash, 1, 0 from gd_esquema.Maestra
		where Publ_Empresa_Mail is not null
		group by Publ_Empresa_Mail

--USUARIO (Cliente)
	insert into LA_PETER_MACHINE.usuario(usua_username,usua_password,usua_habilitado, usua_intentos_login)
	select distinct Cli_Mail,@hash,1,0 from gd_esquema.Maestra
	where Cli_Mail is not null
	group by Cli_Mail

--ROLES_USUARIO
	insert into LA_PETER_MACHINE.roles_usuario(rolu_username, rolu_id_rol) values ('admin',(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion = 'administrativo'))

--PERSONA (Cliente)
	insert into LA_PETER_MACHINE.persona(pers_username, pers_mail, pers_domicilio_calle, pers_cod_postal, pers_habilitado,
		 pers_numero_calle, pers_piso, pers_depto,pers_fecha_creacion)
	select distinct Cli_Mail, Cli_Mail, Cli_Dom_Calle, Cli_Cod_Postal, 1, Cli_Nro_Calle, Cli_Piso, Cli_Depto, SYSDATETIME()
	from gd_esquema.Maestra
	where Cli_Mail is not null
	group by Cli_Mail, Cli_Mail, Cli_Dom_Calle, Cli_Cod_Postal, Cli_Nro_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Depto

	insert into LA_PETER_MACHINE.persona(pers_username, pers_habilitado) 
			values ('admin',1)
	

--ROLES_USUARIO (Cliente)
	insert into LA_PETER_MACHINE.roles_usuario(rolu_username, rolu_id_rol)
	select DISTINCT u.usua_username, r.rol_id from LA_PETER_MACHINE.rol r, LA_PETER_MACHINE.usuario u, LA_PETER_MACHINE.Persona p, gd_esquema.Maestra
	where p.pers_mail = Cli_Mail and p.pers_username = u.usua_username
	and r.rol_descripcion = 'cliente'



--PERSONA (Empresa)
	insert into LA_PETER_MACHINE.persona(pers_username, pers_mail, pers_domicilio_calle, pers_cod_postal, pers_habilitado,
		 pers_numero_calle, pers_piso, pers_depto,pers_fecha_creacion)
	select Publ_Empresa_Mail, Publ_Empresa_Mail, Publ_Empresa_Dom_Calle, Publ_Empresa_Cod_Postal, 1, Publ_Empresa_Nro_Calle,
		Publ_Empresa_Piso, Publ_Empresa_Depto, SYSDATETIME()
	from gd_esquema.Maestra
	where Publ_Empresa_Mail is not null
	group by Publ_Empresa_Mail, Publ_Empresa_Dom_Calle, Publ_Empresa_Cod_Postal, Publ_Empresa_Nro_Calle,
		Publ_Empresa_Piso, Publ_Empresa_Depto

--ROLES_USUARIO (Empresa)
	insert into LA_PETER_MACHINE.roles_usuario(rolu_username, rolu_id_rol)
	select DISTINCT u.usua_username, r.rol_id from LA_PETER_MACHINE.rol r, LA_PETER_MACHINE.usuario u, LA_PETER_MACHINE.Persona p, gd_esquema.Maestra
	where p.pers_mail = Publ_Empresa_Mail and p.pers_username = u.usua_username
	and r.rol_descripcion = 'empresa'

--CLIENTE
DECLARE		@clie_id_tipo_doc numeric(18,0)

set @clie_id_tipo_doc = (select type_id from LA_PETER_MACHINE.document_type where type_descripcion = 'DNI')
	
	insert into LA_PETER_MACHINE.cliente (clie_apellido, clie_nombre, clie_dni, clie_id_tipo_doc, clie_fecha_nac, clie_id_persona)
	select Cli_Apeliido, Cli_Nombre, Cli_Dni, @clie_id_tipo_doc ,Cli_Fecha_Nac,
		(select pers_id from LA_PETER_MACHINE.persona where pers_mail = Cli_Mail)
		from gd_esquema.Maestra
		where Cli_Dni is not null 
		group by Cli_Apeliido, Cli_Nombre, Cli_Dni, Cli_Fecha_Nac, Cli_Mail



--RUBRO
insert into LA_PETER_MACHINE.rubro(rubr_descripcion_corta)
	select distinct Publicacion_Rubro_Descripcion from gd_esquema.Maestra

--EMPRESA
insert into LA_PETER_MACHINE.empresa(empr_razon_social,empr_cuit,empr_id_persona)
	select distinct Publ_Empresa_Razon_Social, Publ_Empresa_Cuit,
	(select pers_id from LA_PETER_MACHINE.persona where pers_mail = Publ_Empresa_Mail)
		from gd_esquema.Maestra
		where Publ_Empresa_Cuit is not null


--VISIBILIDAD
	
	set identity_insert LA_PETER_MACHINE.visibilidad ON

	insert into LA_PETER_MACHINE.visibilidad(visi_cod, visi_precio, visi_porcentaje, visi_descripcion, visi_envio)
		select distinct Publicacion_Visibilidad_Cod, Publicacion_Visibilidad_Precio, Publicacion_Visibilidad_Porcentaje, 
			Publicacion_Visibilidad_Desc, 1
		 from gd_esquema.Maestra
		 where Publicacion_Visibilidad_Cod is not null

	update LA_PETER_MACHINE.visibilidad set visi_envio=0 where visi_descripcion = 'Gratis'

	set identity_insert LA_PETER_MACHINE.visibilidad OFF


--ESTADO
	insert into LA_PETER_MACHINE.estado(esta_descripcion) values ('Pausada')
	insert into LA_PETER_MACHINE.estado(esta_descripcion) values ('Borrador')
	insert into LA_PETER_MACHINE.estado(esta_descripcion) values ('Activa')
	insert into LA_PETER_MACHINE.estado(esta_descripcion) values ('Finalizada')

	
--TIPO
	insert into LA_PETER_MACHINE.tipo(tipo_descripcion) values ('Compra Inmediata')
	insert into LA_PETER_MACHINE.tipo(tipo_descripcion) values ('Subasta')

--COSTO_ENVIO		
	insert into LA_PETER_MACHINE.costo_envio (cost_visi_cod)
	select distinct visi_cod from LA_PETER_MACHINE.visibilidad 
	update LA_PETER_MACHINE.costo_envio set cost_costo=70 where (select visi_cod from LA_PETER_MACHINE.visibilidad where visi_descripcion='Platino') = cost_visi_cod
	update LA_PETER_MACHINE.costo_envio set cost_costo=100 where (select visi_cod from LA_PETER_MACHINE.visibilidad where visi_descripcion='Oro') = cost_visi_cod
	update LA_PETER_MACHINE.costo_envio set cost_costo=150 where (select visi_cod from LA_PETER_MACHINE.visibilidad where visi_descripcion='Plata') = cost_visi_cod
	update LA_PETER_MACHINE.costo_envio set cost_costo=180 where (select visi_cod from LA_PETER_MACHINE.visibilidad where visi_descripcion='Bronce') = cost_visi_cod
	update LA_PETER_MACHINE.costo_envio set cost_costo=300 where (select visi_cod from LA_PETER_MACHINE.visibilidad where visi_descripcion='Gratis') = cost_visi_cod

--PUBLICACION

	set identity_insert LA_PETER_MACHINE.publicacion ON

	insert into LA_PETER_MACHINE.publicacion (publicacion_id, publ_descripcion, publ_precio, publ_cod_rubro, publ_cod_visibilidad,
		publ_id_vendedor, publ_id_estado, publ_fecha_inicio, publ_fecha_fin, publ_preguntas, publ_cantidad, publ_id_tipo,
		publ_envio_habilitado)
	select DISTINCT Publicacion_Cod, Publicacion_Descripcion, Publicacion_Precio,
		(select rubr_cod from LA_PETER_MACHINE.rubro where rubr_descripcion_corta = Publicacion_Rubro_Descripcion),
		(select visi_cod from LA_PETER_MACHINE.visibilidad where visi_cod = Publicacion_Visibilidad_Cod),
		(select pers_id from LA_PETER_MACHINE.persona where Publ_Empresa_Mail = pers_mail OR Publ_Cli_Mail = pers_mail),
		(select estado_id from LA_PETER_MACHINE.estado where esta_descripcion = 'Finalizada'),
		Publicacion_Fecha, Publicacion_Fecha_Venc, 1, Publicacion_Stock, 
		(select tipo_id from LA_PETER_MACHINE.tipo where Publicacion_Tipo = tipo_descripcion),0
		from gd_esquema.Maestra

	set identity_insert LA_PETER_MACHINE.publicacion OFF
	
	--Poner el costo
	update LA_PETER_MACHINE.publicacion set publ_costo = 
		publ_precio*(select visi_porcentaje from LA_PETER_MACHINE.visibilidad where publ_cod_visibilidad = visi_cod)
		+ (select cost_costo from LA_PETER_MACHINE.costo_envio where publ_cod_visibilidad=cost_visi_cod)*publ_envio_habilitado 
		+ (select visi_precio from LA_PETER_MACHINE.visibilidad where publ_cod_visibilidad = visi_cod)


--FACTURA

	set identity_insert LA_PETER_MACHINE.factura ON

	insert into LA_PETER_MACHINE.factura(fact_num, fact_fecha, fact_total, fact_forma_pago, fact_id_vendedor)
	select  Factura_Nro, Factura_Fecha, Factura_Total, Forma_Pago_Desc,
		(select pers_id from LA_PETER_MACHINE.persona where Publ_Empresa_Mail = pers_mail OR Publ_Cli_Mail = pers_mail)
		from gd_esquema.Maestra
		where Factura_Nro is not null
		group by Factura_Nro, Factura_Fecha, Factura_Total, Forma_Pago_Desc, Publ_Empresa_Mail, Publ_Cli_Mail
		order by Factura_Nro

	set identity_insert LA_PETER_MACHINE.factura OFF


--ITEM_FACTURA
	insert into LA_PETER_MACHINE.item_factura(item_num_factura, item_cantidad, item_precio_unitario, item_id_publicacion)
	select Factura_Nro, Item_Factura_Cantidad, (Item_Factura_Monto / Item_Factura_Cantidad), Publicacion_Cod
		from gd_esquema.Maestra
		where Factura_Nro is not null
		order by Factura_Nro

--OFERTA
	insert into LA_PETER_MACHINE.oferta(ofer_id_publicacion, ofer_fecha, ofer_valor, ofer_username)
	select p.publicacion_id, Oferta_Fecha, Oferta_Monto, pe.pers_username
		from LA_PETER_MACHINE.publicacion p, LA_PETER_MACHINE.persona pe, gd_esquema.Maestra
		where p.publicacion_id = Publicacion_cod and pe.pers_mail = Cli_mail and Oferta_Monto is not NULL

--COMPRA
	insert into LA_PETER_MACHINE.compra(comp_id_publicacion, comp_id_vendedor, comp_id_comprador, comp_fecha, comp_cantidad,
											 comp_num_factura, comp_username, comp_id_calificacion)
	select p.publicacion_id, pe2.pers_id, pe.pers_id, Compra_Fecha, Compra_Cantidad,
			(select DISTINCT m2.Factura_Nro 
				from gd_esquema.Maestra m2 where m2.Publicacion_Cod = p.publicacion_id and m2.Factura_Nro is not null),
			 pe.pers_username, Calificacion_Codigo
		from LA_PETER_MACHINE.publicacion p, LA_PETER_MACHINE.persona pe, 
		gd_esquema.Maestra join LA_PETER_MACHINE.persona pe2 on
						 pe2.pers_mail = Publ_Cli_Mail or pe2.pers_mail = Publ_Empresa_Mail --Vendedor
		where p.publicacion_id = Publicacion_cod 
			and pe.pers_mail = Cli_mail --Comprador
			and Compra_Cantidad is not NULL
			and Calificacion_Codigo is not null

--CALIFICACION

	set identity_insert LA_PETER_MACHINE.calificacion ON

	insert into LA_PETER_MACHINE.calificacion (calificacion_id, cali_valor, cali_detalle,cali_id_vendedor)
	select distinct Calificacion_Codigo, Calificacion_Cant_Estrellas , Calificacion_Descripcion, (select pers_id from LA_PETER_MACHINE.persona where Publ_Empresa_Mail = pers_mail OR Publ_Cli_Mail = pers_mail) 
		from gd_esquema.Maestra
  		where Calificacion_Codigo is not NULL --and Calificacion_Cant_Estrellas < 6
		order by Calificacion_Codigo

	set identity_insert LA_PETER_MACHINE.calificacion OFF

	update LA_PETER_MACHINE.calificacion set cali_valor = 5 from LA_PETER_MACHINE.calificacion where cali_valor > 5 

GO

exec LA_PETER_MACHINE.SP_Migracion