-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: <<FECHA>>
-- Description:	Obtiene la información del <<>> especificado.
-- =============================================
CREATE FUNCTION [dbo].[fxEstadosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM dbo.Estados WHERE IdEstado=@ID)


