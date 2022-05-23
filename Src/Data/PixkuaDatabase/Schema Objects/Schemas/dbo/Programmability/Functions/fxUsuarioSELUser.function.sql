-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 27-Dic-2005
-- Description:	Obtiene la información de un usuario en base a su nombre.
-- =============================================
CREATE FUNCTION [dbo].[fxUsuarioSELUser]
(	
	@UserName AS varchar(32)
)
RETURNS TABLE 
AS
RETURN 
(	
	SELECT *, Usuario AS Codigo, Cast(0 AS bit) AS IsAdministrator 
	FROM Usuarios WHERE Usuario=@UserName
)


