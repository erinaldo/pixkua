CREATE FUNCTION [dbo].[fxDiasFestivosSEL](@IdCalendario as int, @Anio AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT Fecha, Descr
	FROM dbo.Fechas
	WHERE Anio=@Anio AND Festivo=1 AND IdCalendario=@IdCalendario
		)


