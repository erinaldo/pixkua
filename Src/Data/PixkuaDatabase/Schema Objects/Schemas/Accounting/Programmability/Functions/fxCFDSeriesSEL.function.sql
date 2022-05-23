-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Obtiene la información del CFDSeries especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxCFDSeriesSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(
	SELECT S.*, C.Nombre AS Certificado
	FROM Accounting.CFDSeries S JOIN Accounting.CFDCertificados C
		ON S.IdCFDCertificado=C.IdCFDCertificado
	WHERE IdCFDSerie=@ID
	)


