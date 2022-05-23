-- =============================================
-- Author: alez Lopez
-- Create date: 22-ago-2011
-- Description:	Obtiene una lista de búsqueda de GruposDescuento
-- =============================================
CREATE FUNCTION [Sales].[fxGruposDescuentoLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdGrupoDescuento,Nombre,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Sales.GruposDescuento
	WHERE IdSucursal=@IdSucursal
	)


