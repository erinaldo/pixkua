CREATE FUNCTION [Accounting].[fxComprobantesEmitidos](@IdEmpresa as int, @FechaIni as datetime, @FechaFin as datetime)
RETURNS TABLE
AS
RETURN	(
		SELECT Replace(Cast(C.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/@rfc)') AS varchar(110)), '&amp;', '&') AS RFC, 
			S.Serie, C.Folio, LTrim(RTrim(Str(C.AnioAprobacion))) + LTrim(RTrim(Str(C.NumAprobacion))) AS NumAprobacion, C.HoraComprobante, C.Total, C.ImpTrasladados, Cast(1 AS bit) AS Activa, CT.Efecto			
		FROM Accounting.CFD C with (readuncommitted) JOIN Accounting.CFDTipos CT with (readuncommitted) 
			ON C.IdCFDTipo=CT.IdCFDTipo
		JOIN Accounting.CFDSeries S
			ON C.IdCFDSerie=S.IdCFDSerie
		WHERE C.FechaComprobante between @FechaIni and @FechaFin and S.IdEmpresa=@IdEmpresa
	UNION ALL
		SELECT Replace(Cast(C.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/@rfc)') AS varchar(110)), '&amp;', '&') AS RFC, 
			S.Serie, C.Folio, LTrim(RTrim(Str(C.AnioAprobacion))) + LTrim(RTrim(Str(C.NumAprobacion))) AS NumAprobacion, C.HoraComprobante, C.Total, C.ImpTrasladados, Cast(0 AS bit) AS Activa, CT.Efecto			
		FROM Accounting.CFD C with (readuncommitted) JOIN Accounting.CFDTipos CT with (readuncommitted) 
			ON C.IdCFDTipo=CT.IdCFDTipo
		JOIN Accounting.CFDSeries S
			ON C.IdCFDSerie=S.IdCFDSerie
		WHERE C.FechaCancelacion between @FechaIni and dateadd(dd, 1, @FechaFin)
			AND S.IdEmpresa=@IdEmpresa
			AND C.FechaComprobante between dateadd(dd, -180, @FechaIni) and dateadd(dd, 3, @FechaFin)		
		)


