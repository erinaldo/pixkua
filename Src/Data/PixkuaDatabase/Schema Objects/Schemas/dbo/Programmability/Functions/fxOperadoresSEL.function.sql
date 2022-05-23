-- =============================================
-- Author: RCO
-- Create date: 02-nov-2010
-- Description:	Obtiene la información del Operadores especificado.
-- =============================================
CREATE FUNCTION [dbo].[fxOperadoresSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM dbo.Operadores WHERE IdOperador=@ID)


