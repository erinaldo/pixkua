CREATE PROCEDURE [Restaurant].[ComandaDetExtrasUPD]
@IdComandaTit varchar(18),
@Fecha datetime,
@IdArticulo int,
@Partida int,
@IdInsumo int
AS
	INSERT INTO Restaurant.ComandaDetExtras(IdComandaTit,Fecha,IdArticulo,Partida,IdInsumo)
	VALUES(@IdComandaTit,@Fecha,@IdArticulo,@Partida,@IdInsumo)


