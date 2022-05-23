-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: <<FECHA>>
-- Description:	Obtiene la información del <<>> especificado.
-- =============================================
CREATE FUNCTION [dbo].[fxGruposUsrSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM dbo.GruposUsr WHERE IdGrupo=@ID)


