CREATE FUNCTION [Sales].[fxCortesLST](@IdCaja as int,@FechaIni as datetime,@FechaFin as datetime)
RETURNS TABLE
AS
RETURN(
	SELECT Cut.IdCorte, Cut.FechaApertura,Cut.FechaCierre,Cut.HoraCierre,P.Nombre+' '+P.ApellidoP+' '+P.ApellidoM As Cajero
	FROM Sales.Cortes Cut 
	INNER JOIN Sales.Cajeros Cjr ON Cjr.IdCajero=Cut.IdCajero
	INNER JOIN RH.Empleados E ON E.IdEmpleado=Cjr.IdEmpleado
	INNER JOIN Personas P ON P.IdPersona=E.IdPersona
	WHERE IdCaja=@IdCaja AND FechaCierre BETWEEN @FechaIni AND @FechaFin AND Cut.IdStatus=1
)


