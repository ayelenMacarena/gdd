select empr_razon_social, empr_nombre_contacto, empr_cuit, pers_ciudad, pers_cod_postal, pers_depto, pers_domicilio_calle,pers_mail, pers_numero_calle, pers_piso, pers_telefono, usua_username, usua_password
 from LA_PETER_MACHINE.empresa,LA_PETER_MACHINE.usuario,LA_PETER_MACHINE.persona
 where empr_id_persona=pers_id and pers_username=usua_username


 create procedure LA_PETER_MACHINE.Modiciar_empresa(@usuario_viejo nvarchar(255),@usuario nvarchar(255),@pass nvarchar(20),@ciudad nvarchar(255),
 @contacto nvarchar(255),@razon nvarchar(255),@mail nvarchar(255),@telefono nvarchar(50),@calle nvarchar(255),@cod_postal nvarchar(50),
 @numero numeric(18),@dpto nvarchar(50),@piso numeric(18),@rdo nvarchar(255))
 as
 begin
 begin try
	declare @hash varbinary(20)
	set @hash=HASHBYTES('sha2_256',@pass)
 update LA_PETER_MACHINE.usuario 
 set usua_password=@hash,usua_username=@usuario
 where usua_username=@usuario_viejo
 
 update LA_PETER_MACHINE.persona
 set pers_username=@usuario,pers_ciudad=@ciudad,pers_cod_postal=@cod_postal,pers_depto=@dpto,pers_domicilio_calle=@calle,
 pers_mail=@mail,pers_numero_calle=@numero,pers_piso=@piso,pers_telefono=@telefono
 where pers_username=@usuario_viejo
 
 update LA_PETER_MACHINE.empresa
 set empr_nombre_contacto=@contacto,empr_razon_social=@razon
 where empr_id_persona=(select pers_id from LA_PETER_MACHINE.persona where pers_username=@usuario)
 set @rdo='ok'
 end try
 begin catch
 set @rdo='Error de ingreso'
 end catch
 end
 