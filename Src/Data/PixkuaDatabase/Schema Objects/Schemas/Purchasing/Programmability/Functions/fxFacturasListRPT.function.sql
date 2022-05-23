CREATE FUNCTION [Purchasing].[fxFacturasListRPT](@FechaIni as datetime, @FechaFin as datetime, @IdEmpresa as int, @IdProveedor as int)
RETURNS TABLE
AS
RETURN	(

SELECT F.FechaComprobante, F.HoraComprobante, F.Serie, F.Folio,UUID,
		F.SubTotal, F.ImpTrasladados, F.Total, F.FechaCancelacion, F.IdDocumento, F.IdProveedor,
		REPLACE(CAST(F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/@rfc)') AS varchar(32)), '&AMP;', '&') AS RFC, 
		REPLACE(CAST(F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/@nombre)') AS varchar(256)), '&AMP;', '&') AS RazonSocial, 
		CASE F.Activa
			WHEN 1 THEN 'Activa'
			WHEN 0 THEN 'Cancelada'
		END AS Estatus, F.Referencia
	FROM Purchasing.CFD F 
	WHERE F.FechaComprobante between @FechaIni AND @FechaFin
		AND F.IdEmpresa=@IdEmpresa AND (F.IdProveedor=@IdProveedor OR @IdProveedor=0)
		AND F.IdCFDTipo=1
		)


