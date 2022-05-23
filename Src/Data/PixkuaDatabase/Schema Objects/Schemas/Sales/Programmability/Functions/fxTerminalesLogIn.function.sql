CREATE FUNCTION [Sales].[fxTerminalesLogIn](@PC as varchar(64), @IdSucursal as int)
RETURNS TABLE
AS
	RETURN(		SELECT T.IdTerminal,T.Nombre AS Terminal,C.IdCaja,C.Nombre as Caja, C.IdCorteActual,IsNull(Cut.IdCajero,0)AS IdCajero,IsNull(P.Nombre+' '+P.ApellidoP+' '+P.ApellidoM,'') AS [Cajero]
				FROM Sales.Terminales T
				INNER JOIN Sales.Cajas C ON C.IdCaja=T.IdCaja
				LEFT  JOIN Sales.Cortes Cut ON Cut.IdCorte=C.IdCorteActual
				LEFT  JOIN Sales.Cajeros Cjr ON Cjr.IdCajero=Cut.IdCajero
				LEFT  JOIN RH.Empleados E ON E.IdEmpleado=Cjr.IdEmpleado
				LEFT  JOIN dbo.Personas P ON E.IdPersona=P.IdPersona
				WHERE T.IdSucursal=@IdSucursal AND PC=@PC
)


