-- =============================================
-- Author: RCO
-- Create date: 13-abr-2011
-- Description:	Obtiene la información del SucursalesConfig especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxSucursalesConfigList](@IdEmpresa as int)
RETURNS TABLE
AS
	RETURN
	(
	SELECT S.IdSucursal, S.Nombre, IsNull(SC.IdFormatoNotaCargo, 0) AS IdFormatoNotaCargo, 
		IsNull(SC.IdFormatoNotaCredito, 0) AS IdFormatoNotaCredito,
		IsNull(SC.IdSerieNotasCargo, 0) AS IdSerieNotasCargo, 
		IsNull(SC.IdSerieNotasCredito, 0) AS IdSerieNotasCredito
	FROM dbo.Sucursales S LEFT JOIN Accounting.SucursalesConfig SC
		ON S.IdSucursal=SC.IdSucursal
	WHERE S.IdEmpresa=@IdEmpresa
	)


