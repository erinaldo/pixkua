-- =============================================
-- Author: alez Lopez
-- Create date: 13-sep-2011
-- Description:	Cancela el proceso del EjerciciosFiscalesTit especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[EjerciciosFiscalesTitCNL]
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
	UPDATE Accounting.EjerciciosFiscalesTit 
	SET IdStatus=@IdStatusAnt, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=getdate()
	WHERE IdEjercicioFiscalTit=@ID AND Fecha=Documents.fxDocumentDate(@ID)


