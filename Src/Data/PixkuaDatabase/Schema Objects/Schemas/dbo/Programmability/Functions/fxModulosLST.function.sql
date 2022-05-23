-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 31-Dic-2005
-- Description:	Obtiene una lista de búsqueda de modulos
-- =============================================
CREATE FUNCTION [dbo].[fxModulosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT M.IdModulo, P.Modulo AS Padre, M.Modulo
	FROM dbo.Modulos M LEFT JOIN dbo.Modulos P
		ON M.IdParent=P.IdModulo)


