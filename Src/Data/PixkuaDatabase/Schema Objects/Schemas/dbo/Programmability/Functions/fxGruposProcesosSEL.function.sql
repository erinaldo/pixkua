-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 03-Jun-2006
-- Description:	Obtiene los accesos a procesos de un grupo
-- =============================================
CREATE FUNCTION [dbo].[fxGruposProcesosSEL](@IdGrupo AS int)
RETURNS TABLE
AS
RETURN (
	SELECT GP.IdProceso
	FROM dbo.GruposProcesos GP
	WHERE GP.IdGrupo=@IdGrupo
		)


