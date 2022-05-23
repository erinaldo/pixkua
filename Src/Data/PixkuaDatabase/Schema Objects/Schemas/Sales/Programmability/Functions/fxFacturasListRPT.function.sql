CREATE FUNCTION [Sales].[fxFacturasListRPT](@FechaIni as datetime, @FechaFin as datetime, @IdEmpresa as int, @IdSucursal as int, @IdCliente as int)
RETURNS TABLE
AS
RETURN	(
	SELECT F.FechaComprobante, F.HoraComprobante, F.IdCFDSerie, S.Serie, F.Folio,
		F.SubTotal, F.ImpTrasladados, F.Total, F.FechaCancelacion, F.IdDocumento, F.IdCliente,
		REPLACE(CAST(F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/@rfc)') AS varchar(32)), '&AMP;', '&') AS RFC, 
		REPLACE(CAST(F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/@nombre)') AS varchar(32)), '&AMP;', '&') AS RazonSocial, 		
		CASE F.Activa
			WHEN 1 THEN 'Activa'
			WHEN 0 THEN 'Cancelada'
		END AS Estatus
	FROM Accounting.CFD F JOIN Accounting.CFDSeries S
		ON F.IdCFDSerie=S.IdCFDSerie
	WHERE F.FechaComprobante between @FechaIni AND @FechaFin
		AND S.IdEmpresa=@IdEmpresa AND (F.IdSucursal=@IdSucursal OR @IdSucursal=0)
		AND (F.IdCliente=@IdCliente OR @IdCliente=0) AND F.IdCFDTipo=1
		)


