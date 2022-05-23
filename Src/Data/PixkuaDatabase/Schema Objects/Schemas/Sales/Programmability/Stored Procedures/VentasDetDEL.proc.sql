-- =============================================
-- Author: RCO
-- Create date: 07-sep-2010
-- Description:	Elimina el VentasDet especificado.
-- =============================================
CREATE PROCEDURE [Sales].[VentasDetDEL]
	@Id AS char(18)
AS
	SET NOCOUNT ON
	
	DELETE Sales.VentasDet 
	WHERE IdVentaTit=@Id and Fecha=Documents.fxDocumentDate(@Id)


