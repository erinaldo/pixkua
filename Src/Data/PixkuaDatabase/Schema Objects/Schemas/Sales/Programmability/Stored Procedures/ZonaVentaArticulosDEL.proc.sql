CREATE PROCEDURE [Sales].[ZonaVentaArticulosDEL]
	@IdArticuloStock as int,
	@IdZonaVenta as int
AS
	SET NOCOUNT ON
	
	DELETE Sales.ArticulosZonasVenta
	WHERE IdArticuloStock=@IdArticuloStock AND IdZonaVenta=@IdZonaVenta


