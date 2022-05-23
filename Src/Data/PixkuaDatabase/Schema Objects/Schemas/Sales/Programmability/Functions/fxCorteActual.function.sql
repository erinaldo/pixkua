CREATE FUNCTION [Sales].[fxCorteActual](@IdCaja as int)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @Result as uniqueidentifier
	
	SELECT @Result=IdCorteActual
	FROM Sales.Cajas
	WHERE IdCaja=@IdCaja
	
	RETURN @Result	
END


