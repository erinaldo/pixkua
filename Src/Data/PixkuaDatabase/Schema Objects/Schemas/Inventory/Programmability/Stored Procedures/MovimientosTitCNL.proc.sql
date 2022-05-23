-- =============================================
-- Author: RCO
-- Create date: 07-dic-2010
-- Description:	Cancela el proceso del MovimientosTit especificado.
-- =============================================
CREATE PROCEDURE [Inventory].[MovimientosTitCNL]
	@ID AS Char(18),
	@IdStatus as int,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON
	
	DECLARE @IdAlmacen as int, @IdCancel as char(18), @Direccion AS SmallInt, @IdConcepto as int,
		@TotalCantidad AS decimal(19,4), @TotalCosto AS decimal(19,4), @TotalFlete AS decimal(19,4),
		@Fecha as datetime, @Hora as datetime, @FechaDocumento as datetime, @IdSucursal as int, @Observaciones as varchar(128)

	SELECT @Fecha = CONVERT(varchar(10),getDate(),112), @Hora=GETDATE()
	SET @FechaDocumento=Documents.fxDocumentDate(@Id)
	--Se recuperan los datos del encabezado del movimiento
	SELECT  @IdCancel='', @IdAlmacen=IdAlmacen, @Direccion=(Direccion * -1), @IdConcepto=IdConcepto, @IdSucursal=IdSucursal, @TotalCantidad=TotalCantidad, 
			@TotalCosto=TotalCosto,@TotalFlete=TotalFlete, @Observaciones = 'Cancelacion del documento[' + @Id + ']'
	FROM Inventory.MovimientosTit
	WHERE IdMovimientoTit=@Id and Fecha=@FechaDocumento

	--Insertamos el encabezado del nuevo documento que cancela el original
	EXEC Inventory.MovimientosTitUPD  @Id=@IdCancel output, @Fecha=@Fecha, @IdConcepto=@IdConcepto, @IdAlmacen=@IdAlmacen, 
		@TotalCantidad=@TotalCantidad, @TotalCosto=@TotalCosto, @TotalFlete=@TotalFlete, @Direccion=@Direccion, @Referencia=@ID, 
		@Observaciones=@Observaciones, @IdStatus=1, @IdSucursal=@IdSucursal, @UserUpdate=@UserUpdate, @LastUpdate=@Hora, @PCUpdate=@PCUpdate

	-- Actualizar campo que indica que se trata de un movimiento de cancelación
	UPDATE Inventory.MovimientosTit SET Cancelacion=1
	WHERE IdMovimientoTit=@IdCancel and Fecha=@Fecha
	
	--Insertamos el detalle del nuevo documento que cancela el original
	INSERT INTO Inventory.MovimientosDet(IdMovimientoTit, IdArticuloStock, Fecha, Cantidad, IdUnidadMedida, 
			CantidadBase, CostoUnitario, Flete, DisponibleInicial, DisponibleFinal, ApartadoInicial, ApartadoFinal, TransitoInicial, TransitoFinal, ExistenciaInicial, ExistenciaFinal)
	SELECT  @IdCancel, IdArticuloStock, Fecha, Cantidad, IdUnidadMedida, 
			CantidadBase, CostoUnitario, Flete, DisponibleInicial, DisponibleFinal, ApartadoInicial, ApartadoFinal, TransitoInicial, TransitoFinal, ExistenciaInicial, ExistenciaFinal
	FROM Inventory.MovimientosDet
	WHERE IdMovimientoTit=@Id and Fecha=@FechaDocumento
	
	--Procesamos el nuevo documento
	EXEC Inventory.MovimientosTitWorkflow @ID=@IdCancel, @IdStatus=@IdStatus, @FechaTrabajo=@Fecha, @UserUpdate=@UserUpdate, @PCUpdate=@PCUpdate
    
	--Marcamos el original como Cancelado
	UPDATE Inventory.MovimientosTit SET IdStatus=2, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=@Hora
	WHERE IdMovimientoTit=@Id and Fecha=@FechaDocumento


