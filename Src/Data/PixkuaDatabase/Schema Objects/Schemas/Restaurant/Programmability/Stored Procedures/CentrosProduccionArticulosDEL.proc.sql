CREATE PROCEDURE [Restaurant].[CentrosProduccionArticulosDEL]
@IdCentroProduccionArticulo as int
AS
	DELETE Restaurant.CentrosProduccionArticulos WHERE IdCentroProduccionArticulo=@IdCentroProduccionArticulo


