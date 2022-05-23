CREATE FUNCTION [dbo].[fxEventLogSEL](@FechaIni as datetime, @FechaFin as datetime, @Source as varchar(64), @WorkStation as varchar(32))
RETURNS TABLE
AS
RETURN	(
	SELECT [Date], [Time], [Message], [Type], [Source], WorkStation
	FROM dbo.EventLog with (readuncommitted)
	WHERE [Date] between @FechaIni AND @FechaFin
		AND ([Source] LIKE @Source OR @Source='%')
		AND (WorkStation LIKE @WorkStation OR @WorkStation='%')
		)


