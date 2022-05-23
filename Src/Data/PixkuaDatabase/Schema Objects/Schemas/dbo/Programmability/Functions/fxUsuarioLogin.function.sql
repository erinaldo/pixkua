-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 27-Dic-2005
-- Description:	Autentifica el ingreso de un usuario al sistema.
-- =============================================
CREATE FUNCTION [dbo].[fxUsuarioLogin]
(
	@UserName AS varchar(32), 
	@Password AS varchar(128)
)
RETURNS bit
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result AS bit

	SELECT @Result=Cast(U.IdUsuario AS bit)
	FROM Usuarios U
	WHERE U.Usuario=@UserName AND U.Password=@Password

	RETURN IsNull(@Result,0)
END


