CREATE PROCEDURE [Production].[InsumosArticulosDEL]
@IdInsumo as int,
@IdArticuloStock as int
AS
	DELETE Production.InsumosArticulos 
	WHERE IdInsumo=@IdInsumo AND IdArticuloStock=@IdArticuloStock


