-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 31-Dic-2005
-- Description:	Obtiene la información del modulo especificado.
-- =============================================
CREATE FUNCTION [dbo].[fxModulosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT *, IdModulo AS Codigo FROM dbo.Modulos WHERE IdModulo=@ID)


