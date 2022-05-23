CREATE FUNCTION [Accounting].[fxSucursalesConfigSEL](@IdSucursal as int)
RETURNS TABLE
AS
	RETURN
	(
	SELECT IdFormatoNotaCargo, IdFormatoNotaCredito, IdSerieNotasCargo, IdSerieNotasCredito
	FROM Accounting.SucursalesConfig SC		
	WHERE IdSucursal=@IdSucursal
	)


