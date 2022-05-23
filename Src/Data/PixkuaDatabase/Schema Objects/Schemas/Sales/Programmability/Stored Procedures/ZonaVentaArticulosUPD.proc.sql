CREATE PROCEDURE [Sales].[ZonaVentaArticulosUPD]
	@IdArticuloStock as int,
	@IdZonaVenta as int,
	@IdDivisa as int,
	@Precio as decimal(19,4),
	@DiasEntrega as int,
	@IdImpuesto1 as int,
	@IdImpuesto2 as int,
	@IdImpuesto3 as int,
	@PorcRetencion1 as decimal(7,6),
	@PorcRetencion2 as decimal(7,6),
	@PorcRetencion3 as decimal(7,6)
AS
	SET NOCOUNT ON

	IF EXISTS(SELECT IdArticuloStock FROM Sales.ArticulosZonasVenta WHERE IdArticuloStock=@IdArticuloStock AND IdZonaVenta=@IdZonaVenta)
		UPDATE Sales.ArticulosZonasVenta SET IdDivisa=@IdDivisa, Precio=@Precio, DiasEntrega=@DiasEntrega,
			IdImpuesto1=@IdImpuesto1, IdImpuesto2=@IdImpuesto2, IdImpuesto3=@IdImpuesto3,
			PorcRetencion1=@PorcRetencion1, PorcRetencion2=@PorcRetencion2, PorcRetencion3=@PorcRetencion3
		WHERE IdArticuloStock=@IdArticuloStock AND IdZonaVenta=@IdZonaVenta
	ELSE
		INSERT INTO Sales.ArticulosZonasVenta(IdArticuloStock, IdZonaVenta, IdDivisa, Precio, DiasEntrega, 
			IdImpuesto1, IdImpuesto2, IdImpuesto3, PorcRetencion1, PorcRetencion2, PorcRetencion3)
		VALUES (@IdArticuloStock, @IdZonaVenta, @IdDivisa, @Precio, @DiasEntrega, 
			@IdImpuesto1, @IdImpuesto2, @IdImpuesto3, @PorcRetencion1, @PorcRetencion2, @PorcRetencion3)


