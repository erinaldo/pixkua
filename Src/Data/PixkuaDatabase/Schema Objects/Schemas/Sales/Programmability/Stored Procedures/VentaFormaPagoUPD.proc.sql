CREATE PROCEDURE [Sales].[VentaFormaPagoUPD]
	@IdVentaTit AS char(18),
	@IdFormaPago as int,
	@Monto as decimal(19,4),
	@UpdateHeader as bit
AS
	SET NOCOUNT ON
	
	DECLARE @Fecha as datetime
	
	SET @Fecha=Documents.fxDocumentDate(@IdVentaTit)
	
	INSERT INTO Sales.VentasFormasPago(IdVentaTit, Fecha, IdFormaPago, Monto)
	VALUES (@IdVentaTit, @Fecha, @IdFormaPago, @Monto)
	
	IF @UpdateHeader=1
	print 'OK'
		--UPDATE Sales.VentasTit SET IdFormaPago=@IdFormaPago
		--WHERE IdVentaTit=@IdVentaTit AND Fecha=@Fecha


