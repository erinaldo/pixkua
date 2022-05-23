CREATE FUNCTION [Restaurant].[fxFormasPagoDataButtons](@IdSucursal as integer)
RETURNS TABLE
AS
	RETURN( SELECT IdFormaPago,Nombre,null AS Imagen 
			FROM Sales.FormasPago
			WHERE IdStatus=1
	)


