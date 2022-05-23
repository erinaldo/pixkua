-- =============================================
-- Author: RCO
-- Create date: 14-oct-2010
-- Description:	Elimina el Articulos especificado.
-- =============================================
CREATE PROCEDURE [Sales].[ArticulosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Sales.Articulos WHERE IdArticulo=@ID


