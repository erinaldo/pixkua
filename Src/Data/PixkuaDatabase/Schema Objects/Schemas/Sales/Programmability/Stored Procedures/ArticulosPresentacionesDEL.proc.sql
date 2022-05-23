CREATE PROCEDURE [Sales].[ArticulosPresentacionesDEL]
	@IdArticulo as int,
	@IdArticuloStock as int
AS
	SET NOCOUNT ON
	
	DELETE Sales.ArticulosPresentaciones 
	WHERE IdArticulo=@IdArticulo AND IdArticuloStock=@IdArticuloStock


