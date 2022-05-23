CREATE PROCEDURE [Sales].[ListasPreciosServiciosUPD]
@IdListaPrecios as int, 
@IdServicio as int,
@Precio AS Decimal(19,4),
@IdDivisa as int,
@LastUpdate AS datetime,
@PCUpdate AS varchar(32),
@UserUpdate AS int
AS
	IF NOT EXISTS(SELECT IdListaPrecioServicio FROM Sales.ListasPreciosServicios WHERE IdListaPrecio=@IdListaPrecios AND IdServicio=@IdServicio)
		INSERT INTO Sales.ListasPreciosServicios(IdListaPrecio,IdServicio,Precio,IdDivisa,LastUpdate,UserUpdate,PCUpdate)
		VALUES (@IdListaPrecios,@IdServicio,@Precio,@IdDivisa,@LastUpdate,@UserUpdate,@PCUpdate)
	ELSE
		UPDATE Sales.ListasPreciosServicios 
		SET Precio=@Precio,IdDivisa=@IdDivisa,LastUpdate=@LastUpdate,UserUpdate=@UserUpdate,PcUpdate=@PcUpdate
		WHERE IdListaPrecio=@IdListaPrecios AND @IdServicio=@IdServicio


