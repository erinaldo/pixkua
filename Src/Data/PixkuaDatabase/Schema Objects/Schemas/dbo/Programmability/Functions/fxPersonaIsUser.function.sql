CREATE FUNCTION [dbo].[fxPersonaIsUser](@IdPersona as Int)
RETURNS BIT
AS
BEGIN
  DECLARE @Result AS BIT

  SELECT @Result = CAST(IdUsuario AS BIT) 
  FROM Usuarios WHERE IdPersona = @IdPersona

  RETURN ISNULL(@Result, 0)
END


