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
	insert into LA_PETER_MACHINE.cliente(clie_apellido,clie_dni,clie_fecha_creacion,
	clie_fecha_nac,clie_nombre,clie_id_tipo_doc,clie_id_vendedor)values(@apellido,cast(@dni as numeric),
	GETDATE(),@fecha_nac,@nombre,(select type_id from LA_PETER_MACHINE.document_type where type_descripcion=@tipo_DNI),
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

--exec LA_PETER_MACHINE.Crear_Cliente @usuario='sasa',@apellido='apellido',@calle='una calle',
--@ciudad='solano',@cod_postal='1881',@depto='a',@dni='2121',@fecha_nac='22/12/1995',@mail='@',
--@nombre='pepe',@numero='2162',@pasword='contra',@piso='5',@telefono='42131522',@tipo_DNI='DNI',
--@rdo=''

