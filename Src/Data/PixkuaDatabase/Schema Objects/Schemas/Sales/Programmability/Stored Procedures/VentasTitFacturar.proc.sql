CREATE PROCEDURE [Sales].[VentasTitFacturar] 
	@IdVentaTit as char(18), 
	@IdCFDSerie as int,
	@SerieFactura as char(10),
	@FolioFactura as int,
	@FechaFactura as datetime
AS
	SET NOCOUNT ON
	
	-->Obtener el tipo de cambio con el que se guardó la factura
	DECLARE @TipoCambio as decimal(19,4)
	
	SELECT @TipoCambio=TipoCambio
	FROM Accounting.CFD WHERE IdCFDSerie=@IdCFDSerie AND Folio=@FolioFactura
	
	UPDATE Sales.VentasTit 
	SET IdCFDSerie=@IdCFDSerie, SerieFactura=@SerieFactura,  FolioFactura=@FolioFactura,
		FechaFactura=@FechaFactura, TipoCambio=@TipoCambio
	WHERE IdVentaTit=@IdVentaTit AND Fecha=Documents.fxDocumentDate(@IdVentaTit)


