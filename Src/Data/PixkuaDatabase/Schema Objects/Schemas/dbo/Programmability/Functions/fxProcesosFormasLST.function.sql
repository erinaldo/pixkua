-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 26-Mar-2006
-- Description:	Obtiene una lista de búsqueda de Formas de proceso.
-- =============================================
CREATE FUNCTION [dbo].[fxProcesosFormasLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT IdProcesoForma, Forma, Ensamblado, Namespace, Clase
	FROM dbo.ProcesosFormas)


