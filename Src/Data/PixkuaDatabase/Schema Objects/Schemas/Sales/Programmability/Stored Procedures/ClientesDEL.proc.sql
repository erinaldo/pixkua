-- =============================================
-- Author: RCO
-- Create date: 02-sep-2010
-- Description:	Elimina el Clientes especificado.
-- =============================================
CREATE PROCEDURE [Sales].[ClientesDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Sales.Clientes WHERE IdCliente=@ID


