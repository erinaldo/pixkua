-- =============================================
-- Author: RCO
-- Create date: 30-jun-2011
-- Description:	Obtiene la información del Impresoras especificado.
-- =============================================
CREATE FUNCTION [dbo].[fxImpresorasSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM dbo.Impresoras WHERE IdImpresora=@ID)


