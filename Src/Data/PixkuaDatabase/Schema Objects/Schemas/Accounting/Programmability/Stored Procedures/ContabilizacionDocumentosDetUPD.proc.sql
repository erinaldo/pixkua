-- =============================================
-- Author: alexLopez
-- Create date: 15-oct-2010
-- Description:	Agrega o modifica la información de ContabilizacionDocumentosDet
-- =============================================
CREATE PROCEDURE [Accounting].[ContabilizacionDocumentosDetUPD]
	@IdContabilizacionDocumentoDet AS int out,
	@IdContabilizacionDocumentoTit AS int,
	@Variante as bit,
	@IdStatus AS int,
	@IdRacTit AS int
AS
	SET NOCOUNT ON
	
	IF @IdContabilizacionDocumentoDet=0
	BEGIN	
		INSERT INTO Accounting.ContabilizacionDocumentosDet( IdContabilizacionDocumentoTit, IdStatus, Variante,IdRacTit)
		VALUES ( @IdContabilizacionDocumentoTit, @IdStatus, @Variante,@IdRacTit)
		SELECT @IdContabilizacionDocumentoDet=@@IDENTITY
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Accounting.ContabilizacionDocumentosDet SET IdContabilizacionDocumentoTit=@IdContabilizacionDocumentoTit, IdStatus=@IdStatus, Variante=@Variante, IdRacTit=@IdRacTit
		WHERE IdContabilizacionDocumentoDet=@IdContabilizacionDocumentoDet


