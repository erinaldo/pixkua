CREATE PROCEDURE [Sales].[VentaFormasPagoDEL]
	@IdVentaTit as char(18)
AS
	SET NOCOUNT ON
	
	DELETE Sales.VentasFormasPago 
	WHERE IdVentaTit=@IdVentaTit AND Fecha=Documents.fxDocumentDate(@IdVentaTit)


