-- =============================================
-- Author: RCO
-- Create date: 22-sep-2011
-- Description:	Aplica el proceso de flujo de trabajo del PedidosTit especificado.
-- =============================================
CREATE PROCEDURE [Sales].[PedidosTitWorkflow]
	@ID AS Char(18),
	@IdStatus as int,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON
	
	UPDATE Sales.PedidosTit 
	SET IdStatus=@IdStatus, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=getdate()
	WHERE IdPedidoTit=@ID AND Fecha = Documents.fxDocumentDate(@Id)


