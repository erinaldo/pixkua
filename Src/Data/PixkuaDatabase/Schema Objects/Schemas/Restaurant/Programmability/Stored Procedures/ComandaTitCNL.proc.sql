-- =============================================
-- Author: alez Lopez
-- Create date: 11-feb-2011
-- Description:	Cancela el proceso del ComandaTit especificado.
-- =============================================
CREATE PROCEDURE [Restaurant].[ComandaTitCNL]
	@ID AS Char(18),
	@IdStatus as int,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON

	--Se genera una poliza contable siempre y cuando el documento esté configurado
	
	DECLARE @FechaProceso as datetime
	SELECT @FechaProceso=CONVERT (varchar(8),GETDATE(),112)
	EXEC Accounting.Contabilizar @Id, @FechaProceso,@IdStatus,@PCUpdate,@UserUpdate, 1
		
	-->Obtener el estatus en que se quederá el documento
	DECLARE @IdDocumentoTipo as int, @IdStatusAnt as int
	SET @IdDocumentoTipo=Documents.fxDocumentType(@ID)
	SET @IdStatusAnt=[Documents].[fxDocumentStatusPrevID](@IdDocumentoTipo, @IdStatus)

	-->Actualizar estatus	
	UPDATE Restaurant.ComandaTit 
	SET IdStatus=@IdStatus, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=getdate()
	WHERE IdComandaTit=@ID AND Fecha=Documents.fxDocumentDate(@ID)


