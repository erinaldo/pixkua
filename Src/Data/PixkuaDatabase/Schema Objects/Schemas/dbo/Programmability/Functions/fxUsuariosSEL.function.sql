-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 30-DIC-2005
-- Description:	Obtiene la información del usuario especificado.
-- =============================================

CREATE FUNCTION [dbo].[fxUsuariosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT *, Usuario AS Codigo, Cast(0 AS bit) AS IsAdministrator 
	FROM dbo.Usuarios WHERE IdUsuario=@ID)


