-- =============================================
-- Author: alez Lopez
-- Create date: 16-ago-2011
-- Description:	Obtiene una lista de búsqueda de ListasPrecios
-- =============================================
CREATE FUNCTION [Sales].[fxListasPreciosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdListaPrecio,Nombre,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Sales.ListasPrecios
	WHERE IdSucursal=@IdSucursal
	)


