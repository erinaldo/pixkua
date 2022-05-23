-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 31-Dic-2005
-- Description:	Obtiene una lista de búsqueda de procesos
-- =============================================
CREATE FUNCTION [dbo].[fxProcesosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT P.IdProceso, P.Proceso, M.Modulo, PT.Tipo
	FROM dbo.Procesos P JOIN dbo.Modulos M ON P.IdModulo=M.IdModulo
	JOIN dbo.ProcesosTipos PT ON P.IdProcesoTipo=PT.IdProcesoTipo
	)


