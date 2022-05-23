-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: <<FECHA>>
-- Description:	Obtiene la información del <<>> especificado.
-- =============================================
CREATE FUNCTION [dbo].[fxPersonasSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS 
	RETURN
	(SELECT * FROM dbo.Personas WHERE IdPersona=@ID)


