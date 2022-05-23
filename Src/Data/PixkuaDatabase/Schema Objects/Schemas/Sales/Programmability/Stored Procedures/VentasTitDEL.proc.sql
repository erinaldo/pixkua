-- =============================================
-- Author: RCO
-- Create date: 06-sep-2010
-- Description:	Elimina el VentasTit especificado.
-- =============================================
CREATE PROCEDURE [Sales].[VentasTitDEL]
	@ID AS Char(18)
AS
	SET NOCOUNT ON
	
	DELETE Sales.VentasTit WHERE IdVentaTit=@ID AND Fecha = Documents.fxDocumentDate(@Id)


