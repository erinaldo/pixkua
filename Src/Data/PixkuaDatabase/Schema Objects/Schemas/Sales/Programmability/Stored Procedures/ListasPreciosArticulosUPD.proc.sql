CREATE PROCEDURE [Sales].[ListasPreciosArticulosUPD]
@IdListaPrecios as int, 
@IdArticuloStock as int,
@Precio AS Decimal(19,4),
@IdDivisa as int,
@LastUpdate AS datetime,
@PCUpdate AS varchar(32),
@UserUpdate AS int
AS
	IF NOT EXISTS(SELECT IdListaPrecioArticulo FROM Sales.ListasPreciosArticulos WHERE IdListaPrecio=@IdListaPrecios AND IdArticuloStock=@IdArticuloStock)
		INSERT INTO Sales.ListasPreciosArticulos(IdListaPrecio,IdArticuloStock,Precio,IdDivisa,LastUpdate,UserUpdate,PCUpdate)
		VALUES (@IdListaPrecios,@IdArticuloStock,@Precio,@IdDivisa,@LastUpdate,@UserUpdate,@PCUpdate)
	ELSE
		UPDATE Sales.ListasPreciosArticulos 
		SET Precio=@Precio,IdDivisa=@IdDivisa,LastUpdate=@LastUpdate,UserUpdate=@UserUpdate,PcUpdate=@PcUpdate
		WHERE IdListaPrecio=@IdListaPrecios AND IdArticuloStock=@IdArticuloStock


