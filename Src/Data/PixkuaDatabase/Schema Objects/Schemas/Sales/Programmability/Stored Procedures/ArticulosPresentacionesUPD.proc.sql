CREATE PROCEDURE [Sales].[ArticulosPresentacionesUPD]
	@IdArticulo as int,
	@IdArticuloStock as int
AS
	SET NOCOUNT ON
	
	IF NOT EXISTS (SELECT IdArticulo FROM Sales.ArticulosPresentaciones WHERE IdArticulo=@IdArticulo AND IdArticuloStock=@IdArticuloStock)	
		INSERT INTO Sales.ArticulosPresentaciones(IdArticulo, IdArticuloStock)
		VALUES (@IdArticulo, @IdArticuloStock)


