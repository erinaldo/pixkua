-- =============================================
-- Author: RCO
-- Create date: 02-dic-2011
-- Description:	Cancela el proceso del OrdenesTit especificado.
-- =============================================
CREATE PROCEDURE [Purchasing].[OrdenesTitCNL]
	@ID AS Char(18),
	@IdStatus as int,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON

	DECLARE @FechaTrabajo as datetime
	SET @FechaTrabajo=getdate()

	--Se genera una poliza contable en negativo siempre y cuando el documento esté configurado
	EXEC Accounting.Contabilizar @Id, @FechaTrabajo,@IdStatus,@PCUpdate,@UserUpdate, 1
	
	-->Obtener el estatus en que se quederá el documento
	DECLARE @IdDocumentoTipo as int, @IdStatusAnt as int
	SET @IdDocumentoTipo=Documents.fxDocumentType(@ID)
	SET @IdStatusAnt=[Documents].[fxDocumentStatusPrevID](@IdDocumentoTipo, @IdStatus)

	-->Actualizar estatus	
	UPDATE Purchasing.OrdenesTit 
	SET IdStatus=@IdStatusAnt, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=getdate()
	WHERE IdOrdenTit=@ID AND Fecha=Documents.fxDocumentDate(@ID)


