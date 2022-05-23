CREATE PROCEDURE [Sales].[ServicioZonaVentaDEL]
	@IdServicio as int,
	@IdZonaVenta as int
AS
	SET NOCOUNT ON
	
	DELETE Sales.ServiciosZonasVenta
	WHERE IdServicio=@IdServicio AND IdZonaVenta=@IdZonaVenta


