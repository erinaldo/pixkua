-- =============================================
-- Author: alex Lopez
-- Create date: 23-nov-2011
-- Description:	Elimina el Gastos especificado.
-- =============================================
CREATE PROCEDURE [Purchasing].[GastosDEL]
	@ID AS Char(18)
AS
	SET NOCOUNT ON
	
	DELETE Purchasing.Gastos WHERE IdGasto=@ID AND Fecha = Documents.fxDocumentDate(@Id)


