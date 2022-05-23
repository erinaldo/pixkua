-- =============================================
-- Author: RCO
-- Create date: 22-sep-2011
-- Description:	Cancela el proceso del PedidosTit especificado.
-- =============================================
CREATE PROCEDURE [Sales].[PedidosTitCNL]
	@ID AS Char(18),
	@IdStatus as int,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON

	-->Obtener el estatus en que se quederá el documento
	DECLARE @IdDocumentoTipo as int, @IdStatusAnt as int
	SET @IdDocumentoTipo=Documents.fxDocumentType(@ID)
	SET @IdStatusAnt=[Documents].[fxDocumentStatusPrevID](@IdDocumentoTipo, @IdStatus)

	-->Actualizar estatus	
	UPDATE Sales.PedidosTit 
	SET IdStatus=@IdStatusAnt, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=getdate()
	WHERE IdPedidoTit=@ID AND Fecha=Documents.fxDocumentDate(@ID)


