-- =============================================
-- Author: RCO
-- Create date: 14-jul-2011
-- Description:	Verifica la existencia de Calendarios
-- =============================================
CREATE FUNCTION [dbo].[fxCalendariosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdCalendario FROM dbo.Calendarios WHERE IdCalendario=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


