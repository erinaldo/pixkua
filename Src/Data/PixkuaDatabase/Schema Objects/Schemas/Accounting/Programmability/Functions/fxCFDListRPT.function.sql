CREATE FUNCTION [Accounting].[fxCFDListRPT](@FechaIni as datetime, @FechaFin as datetime, @IdEmpresa as int, @IdSucursal as int, @IdCFDTipo as int, @IdCliente as int)
RETURNS TABLE
AS
RETURN	(
	SELECT F.FechaComprobante, F.FechaDocumento, F.HoraComprobante, F.IdCFDSerie, S.Serie, F.Folio,
		F.SubTotal, F.ImpTrasladados, F.Total, F.FechaCancelacion, F.IdDocumento, F.IdCliente,
		Cast(F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/@rfc)') AS CHAR(13)) AS RFC, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/@nombre)') AS RazonSocial, 		
		CASE F.Activa
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Cancelado'
		END AS Estatus
	FROM Accounting.CFD F JOIN Accounting.CFDSeries S
		ON F.IdCFDSerie=S.IdCFDSerie
	WHERE F.FechaComprobante between @FechaIni AND @FechaFin
		AND S.IdEmpresa=@IdEmpresa AND (F.IdSucursal=@IdSucursal OR @IdSucursal=0)
		AND (F.IdCliente=@IdCliente OR @IdCliente=0) AND F.IdCFDTipo=@IdCFDTipo
		)


