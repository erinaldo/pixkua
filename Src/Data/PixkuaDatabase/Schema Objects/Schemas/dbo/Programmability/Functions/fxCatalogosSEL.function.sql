-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 10-Mar-2006
-- Description:	Obtiene la información del <<>> especificado.
-- =============================================
CREATE FUNCTION [dbo].[fxCatalogosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT *, IdCatalogo AS Codigo FROM dbo.Catalogos WHERE IdCatalogo=@ID)


