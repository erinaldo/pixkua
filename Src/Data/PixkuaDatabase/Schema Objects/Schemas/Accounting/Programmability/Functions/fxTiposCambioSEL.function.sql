CREATE FUNCTION [Accounting].[fxTiposCambioSEL](@IdDivisa as int)
RETURNS TABLE
AS
RETURN	(
	SELECT D.IdDivisa, D.Codigo, D.Nombre AS Divisa, IsNull(TC.PrecioCompra, 0) AS PrecioCompra, 
		IsNull(TC.PrecioVenta, 0) AS PrecioVenta, TC.LastUpdate
	FROM Accounting.Divisas D LEFT JOIN Accounting.TiposCambio TC
		ON D.IdDivisa=TC.IdDivisaOrigen AND TC.IdDivisaDestino=@IdDivisa
	WHERE D.IdDivisa <> @IdDivisa
		)


