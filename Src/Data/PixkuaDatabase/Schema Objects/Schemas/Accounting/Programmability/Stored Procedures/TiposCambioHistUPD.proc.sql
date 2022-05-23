CREATE PROCEDURE [Accounting].[TiposCambioHistUPD]	
	@IdDivisaOrigen as int,
	@IdDivisaDestino as int,
	@PrecioCompra as decimal(19,4),
	@PrecioVenta as decimal(19,4),
	@UserUpdate as int	
AS
	SET NOCOUNT ON
	
	DECLARE @LastUpdate as datetime
	SET @LastUpdate=GETDATE()
	
	IF EXISTS (SELECT IdDivisaOrigen FROM Accounting.TiposCambio WHERE IdDivisaOrigen=@IdDivisaOrigen AND IdDivisaDestino=@IdDivisaDestino)
		UPDATE Accounting.TiposCambio SET PrecioCompra=@PrecioCompra, PrecioVenta=@PrecioVenta, LastUpdate=@LastUpdate
		WHERE IdDivisaOrigen=@IdDivisaOrigen AND IdDivisaOrigen=@IdDivisaOrigen
	ELSE
		INSERT INTO Accounting.TiposCambio (IdDivisaOrigen, IdDivisaDestino, PrecioCompra, PrecioVenta, UserUpdate)
		VALUES (@IdDivisaOrigen, @IdDivisaDestino, @PrecioCompra, @PrecioVenta, @UserUpdate)

	-->Insertar registro en histórico
	INSERT INTO Accounting.TiposCambioHist(Fecha, IdDivisaOrigen, IdDivisaDestino, PrecioCompra, PrecioVenta, UserUpdate)
	VALUES (@LastUpdate, @IdDivisaOrigen, @IdDivisaDestino, @PrecioCompra, @PrecioVenta, @UserUpdate)


