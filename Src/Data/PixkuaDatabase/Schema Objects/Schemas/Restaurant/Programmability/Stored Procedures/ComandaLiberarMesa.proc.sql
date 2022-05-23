CREATE PROCEDURE [Restaurant].[ComandaLiberarMesa]
@IdMesa as int
AS
	UPDATE Restaurant.Mesas SET IdComandaTit='' WHERE IdMesa=@IdMesa


