-- =============================================
-- Author: alez Lopez
-- Create date: 19-ene-2011
-- Description:	Obtiene una lista de búsqueda de Articulos
-- =============================================
CREATE FUNCTION [Restaurant].[fxArticulosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT A.IdArticulo,AX.Nombre AS Articulo,C.Nombre as Categoria,
		CASE A.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Restaurant.Articulos A
	INNER JOIN Inventory.ArticulosStock AX ON AX.IdArticuloStock=A.IdArticuloStock
	INNER JOIN Restaurant.Categorias C ON C.IdCategoria=A.IdCategoria
	WHERE A.IdSucursal=@IdSucursal
	)


