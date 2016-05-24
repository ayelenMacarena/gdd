--TODO: Faltan cambiar los nombres a los drops.

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Clientes_Tipo_Dni') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Clientes DROP CONSTRAINT FK_Clientes_Tipo_Dni
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Clientes_Vendedor') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Clientes DROP CONSTRAINT FK_Clientes_Vendedor
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Empresa_Rubro') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Empresa DROP CONSTRAINT FK_Empresa_Rubro
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Factura_Vendedor') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Factura DROP CONSTRAINT FK_Factura_Vendedor
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Funcionalidad_Rol_Funcionalidad') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Funcionalidad_Rol DROP CONSTRAINT FK_Funcionalidad_Rol_Funcionalidad
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Funcionalidad_Rol_Rol a') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Funcionalidad_Rol DROP CONSTRAINT FK_Funcionalidad_Rol_Rol a
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Publicacion_Estado') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Publicacion DROP CONSTRAINT FK_Publicacion_Estado
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Publicacion_Rubro') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Publicacion DROP CONSTRAINT FK_Publicacion_Rubro
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Publicacion_Tipo') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Publicacion DROP CONSTRAINT FK_Publicacion_Tipo
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Publicacion_Vendedor') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Publicacion DROP CONSTRAINT FK_Publicacion_Vendedor
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Publicacion_Visibilidad') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Publicacion DROP CONSTRAINT FK_Publicacion_Visibilidad
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Roles_Usuario_Rol a') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Roles_Usuario DROP CONSTRAINT FK_Roles_Usuario_Rol a
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Roles_Usuario_Usuario') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Roles_Usuario DROP CONSTRAINT FK_Roles_Usuario_Usuario
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_username') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Usuario DROP CONSTRAINT FK_username
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Vendedor_Usuario') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Vendedor DROP CONSTRAINT FK_Vendedor_Usuario
;



IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Calificacion') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Calificacion
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Clientes') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Clientes
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Compra') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Compra
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Empresa') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Empresa
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Estado') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Estado
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Factura') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Factura
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Funcionalidad') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Funcionalidad
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Funcionalidad_Rol') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Funcionalidad_Rol
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Item_Factura') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Item_Factura
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Oferta') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Oferta
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Operacion') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Operacion
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Publicacion') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Publicacion
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Rol') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Rol
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Roles_Usuario') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Roles_Usuario
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Rubro') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Rubro
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Tipo') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Tipo
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Tipo_Dni') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Tipo_Dni
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Usuario') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Usuario
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Vendedor') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Vendedor
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Visibilidad') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Visibilidad
;


CREATE TABLE calificacion ( 
	calificacion_id numeric(18) NOT NULL,
	cali_valor numeric(5),
	cali_detalle nvarchar(100)
)
;

CREATE TABLE clientes ( 
	clie_apellido nvarchar(255) NOT NULL,
	clie_nombre nvarchar(255) NOT NULL,
	clie_dni numeric(18) NOT NULL,
	clie_id_tipo_doc numeric(18) NOT NULL,
	clie_fecha_nac datetime,
	clie_fecha_creacion datetime NOT NULL,
	clie_id_vendedor numeric(18) NOT NULL
)
;

CREATE TABLE compra ( 
	comp_id_publicacion numeric(18) NOT NULL,
	compra_id numeric(18) NOT NULL,
	comp_id_vendedor numeric(18) NOT NULL,
	comp_id_comprador numeric(18) NOT NULL,
	comp_num_factura numeric(18) NOT NULL,
	comp_username nvarchar(20) NOT NULL
)
;

CREATE TABLE empresa ( 
	empr_razon_social nvarchar(255) NOT NULL,
	empr_ciudad nvarchar(255),
	empr_cuit nvarchar(50) NOT NULL,
	empr_nombre_contacto nvarchar(255),
	empr_cod_rubro numeric(18) NOT NULL,
	empr_id_vendedor numeric(18) NOT NULL
)
;

CREATE TABLE estado ( 
	esta_id int NOT NULL,
	esta_descripcion varchar(30)
)
;

CREATE TABLE factura ( 
	fact_num numeric(18) NOT NULL,
	fact_fecha datetime,
	fact_total numeric(18,2),
	fact_id_vendedor numeric(18),
	fact_id_publicacion numeric(18)
)
;

CREATE TABLE funcionalidad ( 
	func_id numeric(18) NOT NULL,
	func_descripcion nvarchar(255)
)
;

CREATE TABLE funcionalidad_rol ( 
	furo_id_funcionalidad numeric(18) NOT NULL,
	furo_id_rol numeric(18) NOT NULL
)
;

CREATE TABLE item_factura ( 
	item_num_factura numeric(18) NOT NULL,
	item_id_publicacion numeric(18) NOT NULL,
	item_cantidad numeric(18),
	item_precio_unitario numeric(18,2)
)
;

CREATE TABLE oferta ( 
	oferta_id numeric(18) NOT NULL,
	ofer_id_publicacion numeric(18) NOT NULL,
	ofer_valor numeric(18) NOT NULL,
	ofer_username nvarchar(20) NOT NULL
)
;

CREATE TABLE operacion ( 
	operacion_id numeric(18) NOT NULL,
	oper_id_vendedor numeric(18) NOT NULL,
	oper_id_comprador numeric(18) NOT NULL,
	oper_calif_vendedor numeric(18),
	oper_calif_comprador numeric(18)
)
;

CREATE TABLE publicacion ( 
	publicacion_id numeric(18) identity(1,1)  NOT NULL,
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
	publ_id_tipo numeric(18) NOT NULL
)
;

CREATE TABLE rol ( 
	rol_id numeric(18) NOT NULL,
	rol_descripcion nvarchar(255) NOT NULL,
	rol_habilitado bit NOT NULL
)
;

CREATE TABLE roles_usuario ( 
	rolu_id_rol numeric(18) NOT NULL,
	rolu_username nvarchar(20) NOT NULL
)
;

CREATE TABLE rubro ( 
	rubro_cod numeric(18) NOT NULL,
	rubr_descripcion_corta nvarchar(125),
	rubr_descripcion_larga nvarchar(255)
)
;

CREATE TABLE tipo ( 
	tipo_id numeric(18) NOT NULL,
	tipo_descripcion nvarchar(255)
)
;

CREATE TABLE document_type ( 
	type_id numeric(18) NOT NULL,
	type_descripcion nvarchar(255) NOT NULL
)
;

CREATE TABLE usuario ( 
	usua_username nvarchar(20) NOT NULL,
	usua_password nvarchar(20) NOT NULL
)
;

CREATE TABLE vendedor ( 
	vendedor_id numeric(18) NOT NULL,
	vend_username nvarchar(20) NOT NULL,
	vend_mail nvarchar(50),
	vend_telefono nvarchar(50),
	vend_domicilio_calle nvarchar(255),
	vend_cod_postal nvarchar(50),
	vend_habilitado bit NOT NULL,
	vend_calificacion numeric(18,2),
	vend_numero_calle numeric(18),
	vend_piso numeric(18),
	vend_depto nvarchar(50)
)
;

CREATE TABLE visibilidad ( 
	visibilidad_cod numeric(18) NOT NULL,
	visi_precio numeric(18,2),
	visi_porcentaje numeric(18,2),
	visi_envio bit,
	visi_descripcion nvarchar(255)
)
;


ALTER TABLE calificacion ADD CONSTRAINT PK_calificacion 
	PRIMARY KEY CLUSTERED (calificacion_id)
;

ALTER TABLE clientes ADD CONSTRAINT PK_clientes 
	PRIMARY KEY CLUSTERED (dni, clie_id_tipo_doc)
;

ALTER TABLE compra ADD CONSTRAINT PK_compra 
	PRIMARY KEY CLUSTERED (compra_id)
;

ALTER TABLE empresa ADD CONSTRAINT PK_empresa 
	PRIMARY KEY CLUSTERED (empr_cuit)
;

ALTER TABLE estado ADD CONSTRAINT PK_estado 
	PRIMARY KEY CLUSTERED (estado_id)
;

ALTER TABLE factura ADD CONSTRAINT PK_factura 
	PRIMARY KEY CLUSTERED (fact_num)
;

ALTER TABLE funcionalidad ADD CONSTRAINT PK_funcionalidad 
	PRIMARY KEY CLUSTERED (func_id)
;

ALTER TABLE funcionalidad_rol ADD CONSTRAINT PK_funcionalidad_rol 
	PRIMARY KEY CLUSTERED (func_id, rol_id)
;

ALTER TABLE item_factura ADD CONSTRAINT PK_item_factura 
	PRIMARY KEY CLUSTERED (fact_num, publ_id)
;

ALTER TABLE oferta ADD CONSTRAINT PK_oferta 
	PRIMARY KEY CLUSTERED (oferta_id)
;

ALTER TABLE operacion ADD CONSTRAINT PK_operacion 
	PRIMARY KEY CLUSTERED (operacion_id)
;

ALTER TABLE publicacion ADD CONSTRAINT PK_publicacion 
	PRIMARY KEY CLUSTERED (publ_id)
;

ALTER TABLE rol ADD CONSTRAINT PK_usuario 
	PRIMARY KEY CLUSTERED (rol_id)
;

ALTER TABLE roles_usuario ADD CONSTRAINT PK_roles_usuario 
	PRIMARY KEY CLUSTERED (rolu_id_rol, rolu_username)
;

ALTER TABLE rubro ADD CONSTRAINT PK_rubro 
	PRIMARY KEY CLUSTERED (rubro_cod)
;

ALTER TABLE tipo ADD CONSTRAINT PK_tipo 
	PRIMARY KEY CLUSTERED (tipo_id)
;

ALTER TABLE document_type ADD CONSTRAINT PK_document_type 
	PRIMARY KEY CLUSTERED (type_id)
;

ALTER TABLE usuario ADD CONSTRAINT PK_usuario 
	PRIMARY KEY CLUSTERED (usua_username)
;

ALTER TABLE vendedor ADD CONSTRAINT PK_vendedor 
	PRIMARY KEY CLUSTERED (vendedor_id)
;

ALTER TABLE visibilidad ADD CONSTRAINT PK_visibilidad 
	PRIMARY KEY CLUSTERED (visibilidad_cod)
;



ALTER TABLE clientes ADD CONSTRAINT FK_clientes_tipo_dni 
	FOREIGN KEY (clie_id_tipo_doc) REFERENCES document_type (type_id)
;

ALTER TABLE clientes ADD CONSTRAINT FK_clientes_vendedor 
	FOREIGN KEY (clie_id_vendedor) REFERENCES vendedor (vendedor_id)
;

ALTER TABLE empresa ADD CONSTRAINT FK_empresa_rubro 
	FOREIGN KEY (empr_cod_rubro) REFERENCES rubro (rubro_cod)
;

ALTER TABLE factura ADD CONSTRAINT FK_factura_vendedor 
	FOREIGN KEY (fact_id_vendedor) REFERENCES vendedor (vendedor_id)
;

ALTER TABLE funcionalidad_rol ADD CONSTRAINT FK_funcionalidad_rol_funcionalidad 
	FOREIGN KEY (furo_id_funcionalidad) REFERENCES funcionalidad (funcionalidad_id)
;

ALTER TABLE funcionalidad_rol ADD CONSTRAINT FK_funcionalidad_rol_rol a
	FOREIGN KEY (furo_id_rol) REFERENCES rol (rol_id)
;

ALTER TABLE publicacion ADD CONSTRAINT FK_publicacion_estado 
	FOREIGN KEY (publ_id_estado) REFERENCES estado (estado_id)
;

ALTER TABLE publicacion ADD CONSTRAINT FK_publicacion_rubro 
	FOREIGN KEY (publ_cod_rubro) REFERENCES rubro (rubro_cod)
;

ALTER TABLE publicacion ADD CONSTRAINT FK_publicacion_tipo 
	FOREIGN KEY (publ_id_tipo) REFERENCES tipo (tipo_id)
;

ALTER TABLE publicacion ADD CONSTRAINT FK_publicacion_vendedor 
	FOREIGN KEY (publ_id_vendedor) REFERENCES vendedor (vendedor_id)
;

ALTER TABLE publicacion ADD CONSTRAINT FK_publicacion_visibilidad 
	FOREIGN KEY (publ_cod_visibilidad) REFERENCES visibilidad (visibilidad_cod)
;

ALTER TABLE roles_usuario ADD CONSTRAINT FK_roles_usuario_rol a 
	FOREIGN KEY (rolu_id_rol) REFERENCES rol (rol_id)
;

ALTER TABLE roles_usuario ADD CONSTRAINT FK_roles_usuario_usuario 
	FOREIGN KEY (rolu_username) REFERENCES usuario (usua_username)
;

ALTER TABLE vendedor ADD CONSTRAINT FK_vendedor_usuario 
	FOREIGN KEY (vend_username) REFERENCES usuario (usua_username)
;
