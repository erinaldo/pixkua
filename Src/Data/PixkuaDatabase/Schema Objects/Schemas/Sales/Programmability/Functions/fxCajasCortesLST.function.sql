CREATe FUNCTION [Sales].[fxCajasCortesLST](@IdSucursal as int)
RETURNS TABLE
AS
RETURN(
		SELECT IdCorte,Cut.FechaApertura,Cut.HoraApertura,Cut.FechaCierre,Cut.HoraCierre,C.IdCaja,C.Nombre AS Caja,P.Nombre+' '+P.ApellidoP+' '+P.ApellidoM As Cajero,C.IdStatus,CASE WHEN C.IdStatus=1THEN 'Activo'ELSE'Cerrado'END AS Estatus
		FROM Sales.Cajas C
		LEFT JOIN Sales.Cortes Cut ON Cut.IdCorte=C.IdCorteActual --AND Cut.=Documents.fxDocumentDate(C.IdCorteActual)
		LEFT JOIN Sales.Cajeros Cjr ON Cjr.IdCajero=Cut.IdCajero
		LEFT JOIN RH.Empleados E ON E.IdEmpleado=Cjr.IdEmpleado
		LEFT JOIN Personas P ON P.IdPersona=E.IdPersona
		WHERE C.IdSucursal=@IdSucursal
)


