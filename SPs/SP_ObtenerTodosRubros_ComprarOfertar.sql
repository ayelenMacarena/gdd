CREATE PROCEDURE LA_PETER_MACHINE.SP_ObtenerTodosRubros_ComprarOfertar
(@Rubros VARCHAR(500) OUTPUT)
AS
BEGIN
	Declare @rubro numeric
	
	Declare cRubros cursor for select rubr_cod from LA_PETER_MACHINE.rubro

	Open cRubros 

	fetch next from cRubros into @rubro
		
	while @@FETCH_STATUS = 0
	BEGIN
		set @Rubros += (convert(nvarchar,@rubro) + ', ')
		fetch next from cRubros into @rubro
	END

	close cRubros
	deallocate cRubros

END
GO