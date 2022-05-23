CREATE FUNCTION [dbo].[fxFechasSELDate](@IdCalendario as int, @Fecha AS datetime)
RETURNS TABLE
AS
RETURN 
	(SELECT * FROM Fechas WHERE Fecha=@Fecha AND IdCalendario=@IdCalendario)


