CREATE PROCEDURE [Production].[ProductosInsumosDEL]
@IdProducto as int,
@IdInsumo as int
AS
	DELETE Production.ProductosInsumos
	WHERE IdInsumo=@IdInsumo AND IdProducto=@IdProducto


