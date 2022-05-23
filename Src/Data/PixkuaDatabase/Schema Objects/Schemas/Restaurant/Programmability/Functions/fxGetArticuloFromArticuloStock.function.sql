CREATE FUNCTION [Restaurant].[fxGetArticuloFromArticuloStock](@IdArticuloStock as int)
RETURNS INT
BEGIN
	DECLARE @IdArticulo as int
	
	SELECT @IdArticulo=IdArticulo
	FROM Restaurant.Articulos 
	WHERE IdArticuloStock=@IdArticuloStock
	
	SET @IdArticulo=ISNULL(@IdArticulo,0)
	
	RETURN @IdArticulo
END


