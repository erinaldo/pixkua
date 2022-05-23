-- =============================================
-- Author: alez Lopez
-- Create date: 19-ene-2011
-- Description:	Obtiene la información del Articulos especificado.
-- =============================================
CREATE FUNCTION [Restaurant].[fxArticulosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT A.*,AX.Nombre AS Articulo 
	 FROM Restaurant.Articulos A
	 INNER JOIN Inventory.ArticulosStock AX ON AX.IdArticuloStock=A.IdArticuloStock
	 WHERE IdArticulo=@ID)


