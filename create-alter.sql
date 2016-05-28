------------------------------------------------------
-- SE REALIZAN LOS CREATES DE LAS TABLAS Y COLUMNAS --
------------------------------------------------------

CREATE SCHEMA LA_PETER_MACHINE

CREATE TABLE calificacion ( 
	calificacion_id numeric(18) NOT NULL IDENTITY(1,1),
	cali_valor numeric(5),
	cali_detalle nvarchar(100)
)

CREATE TABLE cliente ( 
	clie_apellido nvarchar(255) NOT NULL,
	clie_nombre nvarchar(255) NOT NULL,
	clie_dni numeric(18) NOT NULL,
	clie_id_tipo_doc numeric(18) NOT NULL,
	clie_fecha_nac datetime,
	clie_fecha_creacion datetime NOT NULL,
	clie_id_vendedor numeric(18) NOT NULL
)


CREATE TABLE compra ( 
	compra_id numeric(18) NOT NULL IDENTITY(1,1),
	comp_id_publicacion numeric(18) NOT NULL,
	comp_id_vendedor numeric(18) NOT NULL,
	comp_id_comprador numeric(18) NOT NULL,
	comp_num_factura numeric(18) NOT NULL,
	comp_username nvarchar(20) NOT NULL
)


CREATE TABLE empresa ( 
	empr_razon_social nvarchar(255) NOT NULL,
	empr_ciudad nvarchar(255),
	empr_cuit nvarchar(50) NOT NULL,
	empr_nombre_contacto nvarchar(255),
	empr_cod_rubro numeric(18) NOT NULL,
	empr_id_vendedor numeric(18) NOT NULL
)


CREATE TABLE estado ( 
	estado_id numeric(18) NOT NULL IDENTITY(1,1),
	esta_descripcion varchar(30)
)


CREATE TABLE factura ( 
	fact_num numeric(18) NOT NULL,
	fact_fecha datetime,
	fact_total numeric(18,2),
	fact_id_vendedor numeric(18),
	fact_id_publicacion numeric(18)
)


CREATE TABLE funcionalidad ( 
	funcionalidad_id numeric(18) NOT NULL IDENTITY(1,1),
	func_descripcion nvarchar(255)
)


CREATE TABLE funcionalidad_rol ( 
	furo_id_funcionalidad numeric(18) NOT NULL,
	furo_id_rol numeric(18) NOT NULL
)


CREATE TABLE item_factura ( 
	item_num_factura numeric(18) NOT NULL,
	item_id_publicacion numeric(18) NOT NULL,
	item_cantidad numeric(18),
	item_precio_unitario numeric(18,2)
)


CREATE TABLE oferta ( 
	oferta_id numeric(18) NOT NULL IDENTITY(1,1),
	ofer_id_publicacion numeric(18) NOT NULL,
	ofer_valor numeric(18) NOT NULL,
	ofer_username nvarchar(20) NOT NULL
)

CREATE TABLE publicacion ( 
	publicacion_id numeric(18)  NOT NULL,
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


CREATE TABLE rol ( 
	rol_id numeric(18) NOT NULL IDENTITY(1,1),
	rol_descripcion nvarchar(255) NOT NULL,
	rol_habilitado bit NOT NULL
)


CREATE TABLE roles_usuario ( 
	rolu_id_rol numeric(18) NOT NULL,
	rolu_username nvarchar(20) NOT NULL
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
	usua_username nvarchar(20) NOT NULL,
	usua_password nvarchar(20) NOT NULL,
	usua_habilitado bit NOT NULL
)


CREATE TABLE vendedor ( 
	vendedor_id numeric(18) NOT NULL IDENTITY(1,1),
	vend_username nvarchar(20) NOT NULL,
	vend_mail nvarchar(50),
	vend_telefono nvarchar(50),
	vend_domicilio_calle nvarchar(255),
	vend_cod_postal nvarchar(50),
	vend_ciudad nvarchar(255),
	vend_habilitado bit NOT NULL,
	vend_calificacion numeric(18,2),
	vend_numero_calle numeric(18),
	vend_piso numeric(18),
	vend_depto nvarchar(50)
)


CREATE TABLE visibilidad ( 
	visi_cod numeric(18) NOT NULL,
	visi_precio numeric(18,2),
	visi_porcentaje numeric(18,2),
	visi_envio bit,
	visi_descripcion nvarchar(255)
)

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
	PRIMARY KEY CLUSTERED (item_num_factura, item_id_publicacion)


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


ALTER TABLE LA_PETER_MACHINE.vendedor ADD CONSTRAINT PK_vendedor 
	PRIMARY KEY CLUSTERED (vendedor_id)


ALTER TABLE LA_PETER_MACHINE.visibilidad ADD CONSTRAINT PK_visibilidad 
	PRIMARY KEY CLUSTERED (visi_cod)



ALTER TABLE LA_PETER_MACHINE.cliente ADD CONSTRAINT FK_cliente_tipo_dni 
	FOREIGN KEY (clie_id_tipo_doc) REFERENCES document_type (type_id)


ALTER TABLE LA_PETER_MACHINE.cliente ADD CONSTRAINT FK_cliente_vendedor 
	FOREIGN KEY (clie_id_vendedor) REFERENCES vendedor (vendedor_id)


ALTER TABLE LA_PETER_MACHINE.empresa ADD CONSTRAINT FK_empresa_rubro 
	FOREIGN KEY (empr_cod_rubro) REFERENCES rubro (rubr_cod)


ALTER TABLE LA_PETER_MACHINE.factura ADD CONSTRAINT FK_factura_vendedor 
	FOREIGN KEY (fact_id_vendedor) REFERENCES vendedor (vendedor_id)


ALTER TABLE LA_PETER_MACHINE.funcionalidad_rol ADD CONSTRAINT FK_funcionalidad_rol_funcionalidad 
	FOREIGN KEY (furo_id_funcionalidad) REFERENCES funcionalidad (funcionalidad_id)


ALTER TABLE LA_PETER_MACHINE.funcionalidad_rol ADD CONSTRAINT FK_funcionalidad_rol_rol
	FOREIGN KEY (furo_id_rol) REFERENCES rol (rol_id)


ALTER TABLE LA_PETER_MACHINE.publicacion ADD CONSTRAINT FK_publicacion_estado 
	FOREIGN KEY (publ_id_estado) REFERENCES estado (estado_id)


ALTER TABLE LA_PETER_MACHINE.publicacion ADD CONSTRAINT FK_publicacion_rubro 
	FOREIGN KEY (publ_cod_rubro) REFERENCES rubro (rubr_cod)


ALTER TABLE LA_PETER_MACHINE.publicacion ADD CONSTRAINT FK_publicacion_tipo 
	FOREIGN KEY (publ_id_tipo) REFERENCES tipo (tipo_id)


ALTER TABLE LA_PETER_MACHINE.publicacion ADD CONSTRAINT FK_publicacion_vendedor 
	FOREIGN KEY (publ_id_vendedor) REFERENCES vendedor (vendedor_id)


ALTER TABLE LA_PETER_MACHINE.publicacion ADD CONSTRAINT FK_publicacion_visibilidad 
	FOREIGN KEY (publ_cod_visibilidad) REFERENCES visibilidad (visi_cod)


ALTER TABLE LA_PETER_MACHINE.roles_usuario ADD CONSTRAINT FK_roles_usuario_rol
	FOREIGN KEY (rolu_id_rol) REFERENCES rol (rol_id)


ALTER TABLE LA_PETER_MACHINE.roles_usuario ADD CONSTRAINT FK_roles_usuario_usuario 
	FOREIGN KEY (rolu_username) REFERENCES usuario (usua_username)


ALTER TABLE LA_PETER_MACHINE.vendedor ADD CONSTRAINT FK_vendedor_usuario 
	FOREIGN KEY (vend_username) REFERENCES usuario (usua_username)

GO
