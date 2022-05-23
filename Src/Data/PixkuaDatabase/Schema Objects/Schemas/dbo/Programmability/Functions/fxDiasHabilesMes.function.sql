create function [dbo].[fxDiasHabilesMes] (@Anio as int, @Mes as int, @IdSucursal as int)
returns int
as 
begin
	declare @Result as int
	
	select @Result = Count(*)
	from dbo.Fechas
	where Mes = @Mes and Anio = @Anio and IdSucursal = @IdSucursal
	
	return @Result
end


