CREATE function [dbo].[fxFechasAniosLST]()
RETURNS TABLE
AS
	RETURN
	(
	select top 100 percent  Anio from dbo.Fechas
	Group By Anio
	Order By Anio
	)


