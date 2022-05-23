-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 19-Mar-2006
-- Description:	Obtiene una lista de búsqueda de estados.
-- =============================================
CREATE FUNCTION [dbo].[fxEstadosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(
	SELECT IdEstado, Estado, P.Pais
	FROM dbo.Estados E JOIN dbo.Paises P
		ON E.IdPais=P.IdPais
	)


