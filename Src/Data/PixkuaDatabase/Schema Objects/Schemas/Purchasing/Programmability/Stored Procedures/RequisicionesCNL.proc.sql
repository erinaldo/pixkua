-- =============================================
-- Author: alex lopez
-- Create date: 07-nov-2011
-- Description:	Cancela el proceso del Requisiciones especificado.
-- =============================================
CREATE PROCEDURE [Purchasing].[RequisicionesCNL]
	@ID AS Char(18),
	@IdStatus as int,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON

	-->Se genera una poliza contable en negativo cuando el documento se cancela, siempre y cuando el documento esté configurado
	DECLARE @FechaProceso as datetime
	SELECT @FechaProceso=CONVERT (varchar(8),GETDATE(),112)
	EXEC Accounting.Contabilizar @Id, @FechaProceso,@IdStatus,@PCUpdate,@UserUpdate,1

	----- Ejecutar codigo particular para cancelar el status Actual -----

	---------------------------------------------------------------------

	-->Obtener el estatus en que se quederá el documento
	DECLARE @IdDocumentoTipo as int, @IdStatusAnt as int
	SET @IdDocumentoTipo=Documents.fxDocumentType(@ID)
	SET @IdStatusAnt=[Documents].[fxDocumentStatusPrevID](@IdDocumentoTipo, @IdStatus)

	-->Actualizar estatus	
	UPDATE Purchasing.Requisiciones 
	SET IdStatus=@IdStatusAnt, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=getdate()
	WHERE IdRequisicion=@ID AND Fecha=Documents.fxDocumentDate(@ID)


