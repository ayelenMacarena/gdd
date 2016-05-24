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


CREATE TABLE Calificacion ( 
	id_calificacion numeric(18) NOT NULL,
	valor numeric(5),
	detalle nvarchar(100)
)
;

CREATE TABLE Clientes ( 
	apellido nvarchar(255) NOT NULL,
	nombre nvarchar(255) NOT NULL,
	dni numeric(18) NOT NULL,
	id_tipo_doc numeric(18) NOT NULL,
	fecha_nac datetime,
	fecha_creacion datetime NOT NULL,
	id_vendedor numeric(18) NOT NULL
)
;

CREATE TABLE Compra ( 
	id_publicacion numeric(18) NOT NULL,
	id_compra numeric(18) NOT NULL,
	id_vendedor numeric(18) NOT NULL,
	id_comprador numeric(18) NOT NULL,
	num_factura numeric(18) NOT NULL,
	username nvarchar(20) NOT NULL
)
;

CREATE TABLE Empresa ( 
	razon_social nvarchar(255) NOT NULL,
	ciudad nvarchar(255),
	cuit nvarchar(50) NOT NULL,
	nombre_contacto nvarchar(255),
	cod_rubro numeric(18) NOT NULL,
	id_vendedor numeric(18) NOT NULL
)
;

CREATE TABLE Estado ( 
	id_estado int NOT NULL,
	descripcion varchar(30)
)
;

CREATE TABLE Factura ( 
	num_factura numeric(18) NOT NULL,
	fecha datetime,
	total numeric(18,2),
	id_vendedor numeric(18),
	id_publicacion numeric(18)
)
;

CREATE TABLE Funcionalidad ( 
	id_funcionalidad numeric(18) NOT NULL,
	descripcion nvarchar(255)
)
;

CREATE TABLE Funcionalidad_Rol ( 
	id_funcionalidad numeric(18) NOT NULL,
	id_rol numeric(18) NOT NULL
)
;

CREATE TABLE Item_Factura ( 
	num_factura numeric(18) NOT NULL,
	id_publicacion numeric(18) NOT NULL,
	cantidad numeric(18),
	precio_unitario numeric(18,2)
)
;

CREATE TABLE Oferta ( 
	id_oferta numeric(18) NOT NULL,
	id_publicacion numeric(18) NOT NULL,
	valor numeric(18) NOT NULL,
	username nvarchar(20) NOT NULL
)
;

CREATE TABLE Operacion ( 
	id_operacion numeric(18) NOT NULL,
	id_vendedor numeric(18) NOT NULL,
	id_comprador numeric(18) NOT NULL,
	calif_vendedor numeric(18),
	calif_comprador numeric(18)
)
;

CREATE TABLE Publicacion ( 
	id_publicacion numeric(18) identity(1,1)  NOT NULL,
	descripcion nvarchar(255),
	precio numeric(18,2),
	costo numeric(18,2),
	cod_rubro numeric(18) NOT NULL,
	cod_visibilidad numeric(18) NOT NULL,
	id_vendedor numeric(18) NOT NULL,
	id_estado numeric(18) NOT NULL,
	fecha_inicio datetime,
	fecha_fin datetime,
	preguntas bit,
	cantidad numeric(18),
	id_tipo numeric(18) NOT NULL
)
;

CREATE TABLE Rol ( 
	id_rol numeric(18) NOT NULL,
	descripcion nvarchar(255) NOT NULL,
	habilitado bit NOT NULL
)
;

CREATE TABLE Roles_Usuario ( 
	id_rol numeric(18) NOT NULL,
	username nvarchar(20) NOT NULL
)
;

CREATE TABLE Rubro ( 
	cod_rubro numeric(18) NOT NULL,
	descripcion_corta nvarchar(125),
	descripcion_larga nvarchar(255)
)
;

CREATE TABLE Tipo ( 
	id_tipo numeric(18) NOT NULL,
	descripcion nvarchar(255)
)
;

CREATE TABLE Tipo_Dni ( 
	id_tipo numeric(18) NOT NULL,
	descripcion nvarchar(255) NOT NULL
)
;

CREATE TABLE Usuario ( 
	username nvarchar(20) NOT NULL,
	password nvarchar(20) NOT NULL
)
;

CREATE TABLE Vendedor ( 
	id_vendedor numeric(18) NOT NULL,
	username nvarchar(20) NOT NULL,
	mail nvarchar(50),
	telefono nvarchar(50),
	domicilio_calle nvarchar(255),
	cod_postal nvarchar(50),
	habilitado bit NOT NULL,
	calificacion numeric(18,2),
	numero_calle numeric(18),
	piso numeric(18),
	depto nvarchar(50)
)
;

CREATE TABLE Visibilidad ( 
	cod_visibilidad numeric(18) NOT NULL,
	precio numeric(18,2),
	porcentaje numeric(18,2),
	envio bit,
	descripcion nvarchar(255)
)
;


ALTER TABLE Calificacion ADD CONSTRAINT PK_Calificacion 
	PRIMARY KEY CLUSTERED (id_calificacion)
;

ALTER TABLE Clientes ADD CONSTRAINT PK_Clientes 
	PRIMARY KEY CLUSTERED (dni, id_tipo_doc)
;

ALTER TABLE Compra ADD CONSTRAINT PK_Compra 
	PRIMARY KEY CLUSTERED (id_compra)
;

ALTER TABLE Empresa ADD CONSTRAINT PK_Empresa 
	PRIMARY KEY CLUSTERED (cuit)
;

ALTER TABLE Estado ADD CONSTRAINT PK_Estado 
	PRIMARY KEY CLUSTERED (id_estado)
;

ALTER TABLE Factura ADD CONSTRAINT PK_Factura 
	PRIMARY KEY CLUSTERED (num_factura)
;

ALTER TABLE Funcionalidad ADD CONSTRAINT PK_Funcionalidad 
	PRIMARY KEY CLUSTERED (id_funcionalidad)
;

ALTER TABLE Funcionalidad_Rol ADD CONSTRAINT PK_Funcionalidad_Rol 
	PRIMARY KEY CLUSTERED (id_funcionalidad, id_rol)
;

ALTER TABLE Item_Factura ADD CONSTRAINT PK_Item_Factura 
	PRIMARY KEY CLUSTERED (num_factura, id_publicacion)
;

ALTER TABLE Oferta ADD CONSTRAINT PK_Oferta 
	PRIMARY KEY CLUSTERED (id_oferta)
;

ALTER TABLE Operacion ADD CONSTRAINT PK_Operacion 
	PRIMARY KEY CLUSTERED (id_operacion)
;

ALTER TABLE Publicacion ADD CONSTRAINT PK_Publicacion 
	PRIMARY KEY CLUSTERED (id_publicacion)
;

ALTER TABLE Rol ADD CONSTRAINT PK_Usuario 
	PRIMARY KEY CLUSTERED (id_rol)
;

ALTER TABLE Roles_Usuario ADD CONSTRAINT PK_roles_usuario 
	PRIMARY KEY CLUSTERED (id_rol, username)
;

ALTER TABLE Rubro ADD CONSTRAINT PK_Rubro 
	PRIMARY KEY CLUSTERED (cod_rubro)
;

ALTER TABLE Tipo ADD CONSTRAINT PK_Tipo 
	PRIMARY KEY CLUSTERED (id_tipo)
;

ALTER TABLE Tipo_Dni ADD CONSTRAINT PK_Tipo 
	PRIMARY KEY CLUSTERED (id_tipo)
;

ALTER TABLE Usuario ADD CONSTRAINT PK_Usuario 
	PRIMARY KEY CLUSTERED (username)
;

ALTER TABLE Vendedor ADD CONSTRAINT PK_Vendedor 
	PRIMARY KEY CLUSTERED (id_vendedor)
;

ALTER TABLE Visibilidad ADD CONSTRAINT PK_Visibilidad 
	PRIMARY KEY CLUSTERED (cod_visibilidad)
;



ALTER TABLE Clientes ADD CONSTRAINT FK_Clientes_Tipo_Dni 
	FOREIGN KEY (id_tipo_doc) REFERENCES Tipo_Dni (id_tipo)
;

ALTER TABLE Clientes ADD CONSTRAINT FK_Clientes_Vendedor 
	FOREIGN KEY (id_vendedor) REFERENCES Vendedor (id_vendedor)
;

ALTER TABLE Empresa ADD CONSTRAINT FK_Empresa_Rubro 
	FOREIGN KEY (cod_rubro) REFERENCES Rubro (cod_rubro)
;

ALTER TABLE Factura ADD CONSTRAINT FK_Factura_Vendedor 
	FOREIGN KEY (id_vendedor) REFERENCES Vendedor (id_vendedor)
;

ALTER TABLE Funcionalidad_Rol ADD CONSTRAINT FK_Funcionalidad_Rol_Funcionalidad 
	FOREIGN KEY (id_funcionalidad) REFERENCES Funcionalidad (id_funcionalidad)
;

ALTER TABLE Funcionalidad_Rol ADD CONSTRAINT FK_Funcionalidad_Rol_Rol a 
	FOREIGN KEY (id_rol) REFERENCES Rol (id_rol)
;

ALTER TABLE Publicacion ADD CONSTRAINT FK_Publicacion_Estado 
	FOREIGN KEY (id_estado) REFERENCES Estado (id_estado)
;

ALTER TABLE Publicacion ADD CONSTRAINT FK_Publicacion_Rubro 
	FOREIGN KEY (cod_rubro) REFERENCES Rubro (cod_rubro)
;

ALTER TABLE Publicacion ADD CONSTRAINT FK_Publicacion_Tipo 
	FOREIGN KEY (id_tipo) REFERENCES Tipo (id_tipo)
;

ALTER TABLE Publicacion ADD CONSTRAINT FK_Publicacion_Vendedor 
	FOREIGN KEY (id_vendedor) REFERENCES Vendedor (id_vendedor)
;

ALTER TABLE Publicacion ADD CONSTRAINT FK_Publicacion_Visibilidad 
	FOREIGN KEY (cod_visibilidad) REFERENCES Visibilidad (cod_visibilidad)
;

ALTER TABLE Roles_Usuario ADD CONSTRAINT FK_Roles_Usuario_Rol a 
	FOREIGN KEY (id_rol) REFERENCES Rol (id_rol)
;

ALTER TABLE Roles_Usuario ADD CONSTRAINT FK_Roles_Usuario_Usuario 
	FOREIGN KEY (username) REFERENCES Usuario (username)
;

ALTER TABLE Vendedor ADD CONSTRAINT FK_Vendedor_Usuario 
	FOREIGN KEY (username) REFERENCES Usuario (username)
;
