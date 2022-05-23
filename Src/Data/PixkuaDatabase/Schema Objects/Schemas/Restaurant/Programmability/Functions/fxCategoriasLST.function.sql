-- =============================================
-- Author: alex Lopez
-- Create date: 18-ene-2011
-- Description:	Obtiene una lista de búsqueda de Categorias
-- =============================================
CREATE FUNCTION [Restaurant].[fxCategoriasLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdCategoria,Nombre,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Restaurant.Categorias
	WHERE IdSucursal=@IdSucursal
	)


