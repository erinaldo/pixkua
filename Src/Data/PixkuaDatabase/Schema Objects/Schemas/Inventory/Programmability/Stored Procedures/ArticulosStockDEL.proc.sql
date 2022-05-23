-- =============================================
-- Author: RCO
-- Create date: 05-oct-2010
-- Description:	Elimina el ArticulosStock especificado.
-- =============================================
CREATE PROCEDURE [Inventory].[ArticulosStockDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Inventory.ArticulosStock WHERE IdArticuloStock=@ID


