-- =============================================
-- Author: RCO
-- Create date: 14-jul-2011
-- Description:	Obtiene la información del Calendarios especificado.
-- =============================================
CREATE FUNCTION [dbo].[fxCalendariosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM dbo.Calendarios WHERE IdCalendario=@ID)


