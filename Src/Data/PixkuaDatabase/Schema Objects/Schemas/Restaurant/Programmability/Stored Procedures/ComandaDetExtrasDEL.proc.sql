CREATE PROCEDURE [Restaurant].[ComandaDetExtrasDEL]
@IdComandaTit varchar(18),
@Fecha datetime,
@IdArticulo int,
@Partida int,
@IdInsumo int
AS
	DELETE Restaurant.ComandaDetExtras 
	WHERE IdComandaTit=@IdComandaTit AND Fecha=@Fecha AND IdArticulo=@IdArticulo AND Partida=@Partida AND IdInsumo=@IdInsumo


