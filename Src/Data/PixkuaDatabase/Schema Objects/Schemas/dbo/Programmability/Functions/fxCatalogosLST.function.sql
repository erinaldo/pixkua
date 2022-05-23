-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 10-Mar-2006
-- Description:	Obtiene una lista de búsqueda de <<>>
-- =============================================
CREATE FUNCTION [dbo].[fxCatalogosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT IdCatalogo
	FROM dbo.Catalogos
	WHERE IdSucursal=@IdSucursal)


