-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Obtiene una lista de búsqueda de CFDSeries
-- =============================================
CREATE FUNCTION [Accounting].[fxCFDSeriesLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(
	SELECT S.IdCFDSerie, S.Serie, C.Nombre AS Certificado, S.UltimoFolio, S.FolioLimite
	FROM Accounting.CFDSeries S JOIN Accounting.CFDCertificados C
		ON S.IdCFDCertificado=C.IdCFDCertificado
	JOIN dbo.Sucursales SU
		ON C.IdSucursal=SU.IdSucursal
	WHERE S.IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)	
	)


