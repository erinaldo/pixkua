-- =============================================
-- Author: RCO
-- Create date: 22-sep-2011
-- Description:	Elimina el DevolucionesCausas especificado.
-- =============================================
CREATE PROCEDURE [Sales].[DevolucionesCausasDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Sales.DevolucionesCausas WHERE IdDevolucionCausa=@ID


