-- =============================================
-- Author: RCO
-- Create date: 20-sep-2010
-- Description:	Obtiene la información del Paises especificado.
-- =============================================
CREATE FUNCTION [dbo].[fxPaisesSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM dbo.Paises WHERE IdPais=@ID)


