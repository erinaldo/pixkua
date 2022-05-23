-- =============================================
-- Author: RCO
-- Create date: 14-jul-2011
-- Description:	Elimina el Calendarios especificado.
-- =============================================
CREATE PROCEDURE [dbo].[CalendariosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE dbo.Calendarios WHERE IdCalendario=@ID


