-- =============================================
-- Author: RCO
-- Create date: 01-jul-2011
-- Description:	Elimina el Cajeros especificado.
-- =============================================
CREATE PROCEDURE [Sales].[CajerosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Sales.Cajeros WHERE IdCajero=@ID


