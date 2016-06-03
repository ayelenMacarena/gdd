------------------------------------------------------
--  SE ELIMINAN LAS FK QUE REFERENCIAN OTRAS TABLAS --
------------------------------------------------------


IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_cliente_tipo_dni') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.cliente DROP CONSTRAINT FK_cliente_tipo_dni
;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_cliente_vendedor') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.cliente DROP CONSTRAINT FK_cliente_vendedor
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = ('FK_cliente_vendedor') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.Cliente DROP CONSTRAINT FK_cliente_vendedor
;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_factura_vendedor') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.Factura DROP CONSTRAINT FK_factura_vendedor
;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_funcionalidad_rol_funcionalidad') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.Funcionalidad_Rol DROP CONSTRAINT FK_funcionalidad_rol_funcionalidad
;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_funcionalidad_rol_rol') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.Funcionalidad_Rol DROP CONSTRAINT FK_funcionalidad_rol_rol
;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_publicacion_estado') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.Publicacion DROP CONSTRAINT FK_publicacion_estado
;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_publicacion_rubro') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.Publicacion DROP CONSTRAINT FK_publicacion_rubro
;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_publicacion_tipo') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.Publicacion DROP CONSTRAINT FK_publicacion_tipo
;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_publicacion_vendedor') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.Publicacion DROP CONSTRAINT FK_publicacion_vendedor
;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_publicacion_visibilidad') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.Publicacion DROP CONSTRAINT FK_publicacion_visibilidad
;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_roles_usuario_rol') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.roles_Usuario DROP CONSTRAINT FK_roles_usuario_rol
;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_roles_usuario_usuario') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.roles_Usuario DROP CONSTRAINT FK_roles_usuario_usuario
;

IF EXISTS (SELECT * FROM sysobjects WHERE name = ('FK_vendedor_usuario') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LA_PETER_MACHINE.persona DROP CONSTRAINT FK_vendedor_usuario
;


------------------------------------------------------
--        SE REALIZAN LOS DROP DE LAS TABLAS        --
------------------------------------------------------


IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.calificacion') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.calificacion
;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.cliente') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.cliente
;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.compra') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.Compra
;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.empresa') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.Empresa
;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.publicacion') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.publicacion
;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.estado') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.Estado
;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.factura') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.Factura
;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.funcionalidad_Rol') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.funcionalidad_Rol
;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.funcionalidad') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.Funcionalidad
;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.item_Factura') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.item_Factura
;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.oferta') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.oferta
;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.roles_Usuario') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.roles_Usuario
;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.rol') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.rol
;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.rubro') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.rubro
;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.tipo') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.tipo
;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.document_type') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.Document_Type
;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.usuario') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.Usuario
;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.persona') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.persona
;

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.visibilidad') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LA_PETER_MACHINE.visibilidad
;



------------------------------------------------------
--     SE REALIZA DROP DEL SCRIPT DE MIGRACION      --
------------------------------------------------------

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('LA_PETER_MACHINE.LaPeterMachine'))
DROP PROCEDURE LA_PETER_MACHINE.LaPeterMachine
;

DROP SCHEMA LA_PETER_MACHINE