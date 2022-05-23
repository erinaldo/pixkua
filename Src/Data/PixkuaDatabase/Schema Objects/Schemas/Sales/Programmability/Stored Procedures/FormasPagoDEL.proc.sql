-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Elimina el FormasPago especificado.
-- =============================================
CREATE PROCEDURE [Sales].[FormasPagoDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Sales.FormasPago WHERE IdFormaPago=@ID


