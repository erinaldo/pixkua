CREATE FUNCTION [Accounting].[fxCFDCertificadoSeries](@IdCFDCertificado as int)
RETURNS TABLE
AS
RETURN	(
	SELECT S.IdCFDSerie, S.Codigo, S.Serie, S.UltimoFolio, S.FolioLimite,
		CASE S.IdStatus
			WHEN 0 THEN 'Inactiva'
			WHEN 1 THEN 'Activa'
		END AS Estatus
	FROM Accounting.CFDSeries S
	WHERE S.IdCFDCertificado=@IdCFDCertificado
		)


