-- =============================================
-- Author: alez Lopez
-- Create date: 30-jun-2011
-- Description:	Elimina el Cajas especificado.
-- =============================================
CREATE PROCEDURE [Sales].[CajasDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Sales.Cajas SET IdStatus=0 WHERE IdCaja=@ID


