-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 31-Dic-2005
-- Description:	Obtiene la información del proceso especificado.
-- =============================================
CREATE FUNCTION [dbo].[fxProcesosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM dbo.Procesos WHERE IdProceso=@ID)


