-- =============================================
-- Author: RCO
-- Create date: 07-dic-2010
-- Description:	Agrega o modifica la información de MovimientosTit
-- =============================================
CREATE PROCEDURE [Inventory].[MovimientosTitUPD]
	@Id AS char(18) out,
	@Fecha AS datetime,
	@IdConcepto AS int,
	@IdAlmacen AS int,
	@TotalCantidad AS decimal(19,4),
	@TotalCosto AS decimal(19,4),
	@TotalFlete AS decimal(19,4),
	@Direccion AS smallint,
	@Referencia AS char(18),
	@Observaciones AS varchar(128),
	@IdStatus AS int,
	@IdSucursal AS int,
	@UserUpdate AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32)
AS
	SET NOCOUNT ON
		
	IF @Id=''
	BEGIN
		-->Asignamos un guid vacío para el corte
		DECLARE @IdCorte as uniqueidentifier	
		SELECT @IdCorte=dbo.fxEmptyId()
	
		-->Obtenemos el tipo de documento en base al concepto
		DECLARE @IdTipoDocumento AS Int
		
		SELECT @IdTipoDocumento=IdDocumentoTipo
		FROM Inventory.Conceptos
		WHERE IdConcepto=@IdConcepto		
		
		-->Obtenemos el Folio consecutivo del documento
		EXEC Documents.NewDocumentFolio @IdTipoDocumento, @IdSucursal, @Fecha, @Id Out
						
		INSERT INTO Inventory.MovimientosTit(IdMovimientoTit, Fecha, IdConcepto, IdAlmacen, TotalCantidad, TotalCosto, TotalFlete, Direccion, 
			Referencia, Cancelacion, IdCorte, Observaciones, IdStatus, IdSucursal, UserUpdate, LastUpdate, PCUpdate)
		VALUES (@Id, @Fecha, @IdConcepto, @IdAlmacen, @TotalCantidad, @TotalCosto, @TotalFlete, @Direccion, 
			@Referencia, 0, @IdCorte, @Observaciones, @IdStatus, @IdSucursal, @UserUpdate, @LastUpdate, @PCUpdate)
	END
	ELSE
		UPDATE Inventory.MovimientosTit SET Fecha=@Fecha, IdConcepto=@IdConcepto, IdAlmacen=@IdAlmacen, 
			TotalCantidad=@TotalCantidad, TotalCosto=@TotalCosto, TotalFlete=@TotalFlete, Direccion=@Direccion, 
			Referencia=@Referencia, Observaciones=@Observaciones, IdStatus=@IdStatus, IdSucursal=@IdSucursal, UserUpdate=@UserUpdate, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate
		WHERE IdMovimientoTit=@ID and Fecha = Documents.fxDocumentDate(@id)


