CREATE FUNCTION [dbo].[fxDiasNoLaborables](@IdCalendario as int, @FechaIni as datetime)
RETURNS TABLE
AS
RETURN	(
	SELECT Fecha, Descr
	FROM dbo.Fechas WHERE IdCalendario=@IdCalendario
		AND Fecha >= @FechaIni AND Habil=0
		)


