-- =============================================
-- Author: alex Lopez
-- Create date: 08-nov-2010
-- Description:	Cancela el proceso del PolizasTit especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[PolizasTitCNL]
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
	UPDATE Accounting.PolizasTit 
	SET IdStatus=@IdStatus, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=getdate()
	WHERE IdPolizaTit=@ID AND Fecha=Documents.fxDocumentDate(@ID)


