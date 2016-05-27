------------------------------------------------------
--  SE ELIMINAN LAS FK QUE REFERENCIAN OTRAS TABLAS --
------------------------------------------------------


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_cliente_tipo_dni') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Cliente DROP CONSTRAINT FK_cliente_tipo_dni
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_cliente_vendedor') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Cliente DROP CONSTRAINT FK_cliente_vendedor
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_empresa_rubro') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Empresa DROP CONSTRAINT FK_empresa_rubro
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_factura_vendedor') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Factura DROP CONSTRAINT FK_factura_vendedor
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_funcionalidad_rol_funcionalidad') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Funcionalidad_Rol DROP CONSTRAINT FK_funcionalidad_rol_funcionalidad
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_funcionalidad_rol_rol') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Funcionalidad_Rol DROP CONSTRAINT FK_funcionalidad_rol_rol
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_publicacion_estado') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Publicacion DROP CONSTRAINT FK_publicacion_estado
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_publicacion_rubro') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Publicacion DROP CONSTRAINT FK_publicacion_rubro
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_publicacion_tipo') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Publicacion DROP CONSTRAINT FK_publicacion_tipo
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_publicacion_vendedor') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Publicacion DROP CONSTRAINT FK_publicacion_vendedor
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_publicacion_visibilidad') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Publicacion DROP CONSTRAINT FK_publicacion_visibilidad
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_roles_usuario_rol') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Roles_Usuario DROP CONSTRAINT FK_roles_usuario_rol
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_roles_usuario_usuario') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Roles_Usuario DROP CONSTRAINT FK_roles_usuario_usuario
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_vendedor_usuario') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Vendedor DROP CONSTRAINT FK_vendedor_usuario
;


------------------------------------------------------
--        SE REALIZAN LOS DROP DE LAS TABLAS        --
------------------------------------------------------


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Calificacion') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Calificacion
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Cliente') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Cliente
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

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Document_Type') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Document_Type
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



------------------------------------------------------
--     SE REALIZA DROP DEL SCRIPT DE MIGRACION      --
------------------------------------------------------

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LaPeterMachine'))
DROP PROCEDURE LaPeterMachine
;