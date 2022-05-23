CREATE FUNCTION [Accounting].[fxTipoCambioActual](@IdDivisaOrigen as int, @IdDivisaDestino as int)
RETURNS decimal(19,4)
AS
BEGIN
	DECLARE @Result as decimal(19,4)
	
	SELECT @Result=PrecioVenta
	FROM Accounting.TiposCambio
	WHERE IdDivisaOrigen=@IdDivisaOrigen AND IdDivisaDestino=@IdDivisaDestino
	
	RETURN IsNull(@Result, 0.0)
END


