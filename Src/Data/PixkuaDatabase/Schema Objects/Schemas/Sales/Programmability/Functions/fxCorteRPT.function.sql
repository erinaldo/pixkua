CREATE FUNCTION [Sales].[fxCorteRPT](@IdCorte as uniqueidentifier)
RETURNS TABLE
AS
RETURN(
		SELECT C.Nombre As Caja,P.Nombre+' '+P.ApellidoP+' '+P.ApellidoM As Cajero,Cut.FechaApertura,Cut.HoraApertura, Cut.FechaCierre, Cut.HoraCierre, FP.Nombre AS FormaPago,SUM(Monto)AS Monto
		FROM Sales.Cortes Cut 
		INNER JOIN Sales.VentasTit VT ON VT.IdCorte=Cut.IdCorte AND VT.Fecha BETWEEN Cut.FechaApertura AND IsNull(Cut.FechaCierre,GETDATE())
		INNER JOIN Sales.VentasFormasPago VP ON VP.IdVentaTit=VT.IdVentaTit AND VP.Fecha=VT.Fecha
		INNER JOIN Sales.FormasPago FP ON FP.IdFormaPago=VP.IdFormaPago
		INNER JOIN Sales.Cajas C ON C.IdCaja=Cut.IdCaja
		INNER JOIN Sales.Cajeros Cjr ON Cjr.IdCajero=Cut.IdCajero
		INNER JOIN RH.Empleados E ON E.IdEmpleado=Cjr.IdEmpleado
		INNER JOIN Personas P ON P.IdPersona=E.IdPersona
		WHERE Cut.IdCorte=@IdCorte 
		GROUP BY C.Nombre,P.Nombre,P.ApellidoP,P.ApellidoM,Cut.FechaApertura,Cut.HoraApertura, Cut.FechaCierre,Cut.HoraCierre,FP.Nombre
)


