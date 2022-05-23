CREATE FUNCTION [Restaurant].[fxComandaTitServicioDomicilioLST](@FechaIni as datetime, @FechaFin as datetime)
RETURNS TABLE

	RETURN(	SELECT	CT.IdComandaTit,CT.HoraInicio,CT.IdRepartidor,'['+C.Codigo +']'+C.Nombre AS Cliente,S.IdStatus, S.StatusApplied AS [Status],CT.Observaciones,
					SUM(   (CD.PrecioUnitario*CD.Cantidad) + (CD.PrecioUnitario*CD.Cantidad * IsNull(I1.Porcentaje,0)) )AS Total
			FROM Restaurant.ComandaTit CT
			INNER JOIN Sales.Clientes C ON  C.IdCliente=CT.IdCliente
			INNER JOIN Restaurant.ComandaDet CD ON CD.IdComandaTit=CT.IdComandaTit AND CD.Fecha=CT.Fecha
			LEFT  JOIN Accounting.Impuestos I1 ON I1.IdImpuesto=CD.IdImpuesto1
			LEFT  JOIN Accounting.Impuestos I2 ON I2.IdImpuesto=CD.IdImpuesto2
			LEFT  JOIN Accounting.Impuestos I3 ON I3.IdImpuesto=CD.IdImpuesto3
			INNER JOIN Documents.Status S ON S.IdStatus=CT.IdStatus
			WHERE CT.Fecha BETWEEN @FechaIni AND @FechaFin 
			GROUP BY CT.IdComandaTit,CT.HoraInicio,CT.IdRepartidor,C.Codigo,C.Nombre, S.IdStatus, S.StatusApplied,CT.Observaciones
)


