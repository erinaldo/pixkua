-- =============================================
-- Author: alez Lopez
-- Create date: 16-ago-2011
-- Description:	Elimina el ListasPrecios especificado.
-- =============================================
CREATE PROCEDURE [Sales].[ListasPreciosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Sales.ListasPrecios SET IdStatus=0 WHERE IdListaPrecio=@ID


