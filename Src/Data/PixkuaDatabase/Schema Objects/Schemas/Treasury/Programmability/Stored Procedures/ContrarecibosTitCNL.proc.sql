-- =============================================
-- Author: alex Lopez
-- Create date: 29-nov-2011
-- Description:	Cancela el proceso del ContrarecibosTit especificado.
-- =============================================
CREATE PROCEDURE [Treasury].[ContrarecibosTitCNL]
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
	UPDATE Treasury.ContrarecibosTit 
	SET IdStatus=@IdStatusAnt, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=getdate()
	WHERE IdContrareciboTit=@ID AND Fecha=Documents.fxDocumentDate(@ID)


