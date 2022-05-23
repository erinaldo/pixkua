CREATE PROCEDURE [Restaurant].[CentroConsumoMesasUPD]
@IdCentroConsumo as int,
@IdMesa as int
AS
	UPDATE Restaurant.Mesas SET IdCentroConsumo=@IdCentroConsumo WHERE IdMesa=@IdMesa


