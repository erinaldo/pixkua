-- =============================================
-- Author: RCO
-- Create date: 06-sep-2010
-- Description:	Cancela el proceso del VentasTit especificado.
-- =============================================
CREATE PROCEDURE [Sales].[VentasTitCNL]
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
	
	
	IF @IdStatus=4
	BEGIN
		UPDATE Sales.VentasTit SET SerieFactura='', IdCFDSerie=0, FolioFactura=0, FechaFactura=NULL
		WHERE IdVentaTit=@ID AND Fecha = Documents.fxDocumentDate(@Id)
	END
	-->Obtener el estatus en que se quederá el pedido
	DECLARE @IdDocumentoTipo as int, @IdStatusAnt as int
	SET @IdDocumentoTipo=Documents.fxDocumentType(@ID)
	SET @IdStatusAnt=[Documents].[fxDocumentStatusPrevID](@IdDocumentoTipo, @IdStatus)

	UPDATE Sales.VentasTit 
	SET IdStatus=@IdStatusAnt, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=getdate()
	WHERE IdVentaTit=@ID AND Fecha = Documents.fxDocumentDate(@Id)


