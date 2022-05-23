-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: <<FECHA>>
-- Description:	Obtiene una lista de búsqueda de Grupos de Usuario
-- =============================================
CREATE  FUNCTION [dbo].[fxGruposUsrLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT IdGrupo, Grupo, Codigo
	FROM dbo.GruposUsr)


