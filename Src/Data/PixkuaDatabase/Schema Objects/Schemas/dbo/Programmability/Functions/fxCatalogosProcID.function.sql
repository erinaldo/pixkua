-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 30-May-2006
-- Description:	Obtiene la información del <<>> especificado.
-- =============================================
CREATE FUNCTION [dbo].[fxCatalogosProcID](@IdProceso AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(
	SELECT C.*, IdCatalogo AS Codigo FROM dbo.Catalogos C 
	WHERE IdProceso=@IdProceso
	)


