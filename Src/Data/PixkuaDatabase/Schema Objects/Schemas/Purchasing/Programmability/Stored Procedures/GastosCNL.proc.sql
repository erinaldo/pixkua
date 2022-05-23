-- =============================================
-- Author: alex Lopez
-- Create date: 23-nov-2011
-- Description:	Cancela el proceso del Gastos especificado.
-- =============================================
CREATE PROCEDURE [Purchasing].[GastosCNL]
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
	
	
	DECLARE @IdPresupuesto int,@IdCategoriaPresupuestal int,@Monto decimal(19,4),@IdProveedor int,@AnioAprobacion int
	
	SELECT @IdPresupuesto=IdPresupuesto,@IdCategoriaPresupuestal=IdCategoriaPresupuestal,@Monto=SubTotal,@IdProveedor=IdProveedor,@AnioAprobacion=AnioAprobacion
	FROM Purchasing.Gastos 
	WHERE IdGasto=@ID AND Fecha=Documents.fxDocumentDate(@ID)
	
	IF @IdStatus=3
	BEGIN
		--Afectamos el presupuesto
		IF @IdPresupuesto>0
			EXEC Purchasing.PresupuestoAfectarCNL @IdPresupuesto,@IdCategoriaPresupuestal,@Monto,'G'
		--Marcamos la Factura del Proveedor como Refernciada para que no se vuelva a utilizar en otra ocasion
		IF @IdProveedor>0 AND @AnioAprobacion>0
			Print 'Desmarcar Marcando Factura'			
	END
	
	-->Obtener el estatus en que se quederá el documento
	DECLARE @IdDocumentoTipo as int, @IdStatusAnt as int
	SET @IdDocumentoTipo=Documents.fxDocumentType(@ID)
	SET @IdStatusAnt=[Documents].[fxDocumentStatusPrevID](@IdDocumentoTipo, @IdStatus)

	-->Actualizar estatus	
	UPDATE Purchasing.Gastos 
	SET IdStatus=@IdStatus, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=getdate()
	WHERE IdGasto=@ID AND Fecha=Documents.fxDocumentDate(@ID)


