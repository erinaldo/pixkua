CREATE FUNCTION [Production].[fxProductoInsumosOpcionalesSEL](@IdProducto as int)
RETURNS TABLE
AS
RETURN(	SELECT Pin.IdInsumo,I.Nombre AS Insumo
		FROM Production.ProductosInsumos Pin
		INNER JOIN Production.Insumos I ON I.IdInsumo=Pin.IdInsumo
		WHERE Pin.IdProducto=@IdProducto AND Pin.Opcional=1
)


