-- =============================================
-- Author: RCO
-- Create date: 07-dic-2010
-- Description:	Aplica el proceso de flujo de trabajo del MovimientosTit especificado.
-- =============================================
CREATE PROCEDURE [Inventory].[MovimientosTitWorkflow]
	@ID AS Char(18),
	@IdStatus as int,
	@FechaTrabajo as datetime,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON
	SET DATEFORMAT dmy
	SET XACT_ABORT ON
	
	DECLARE @ErrorMessage nvarchar(4000), @Err as decimal(19,0)
		
	DECLARE @TotalCantidad as decimal(19,4), @TotalFlete as decimal(19,4), @TotalCosto as decimal(19,4),
		@FechaActual as datetime, @HorActual as datetime,
		@FechaDocumento as datetime, @IdAlmacen as int, @Direccion AS SmallInt, @IdStatusAct as int,
		@IdConcepto as int, @DiasVigencia as int, @IdCorte as uniqueidentifier, @IdTurnoActivo as int
	
	SELECT @HorActual=GETDATE(), @FechaDocumento=Documents.fxDocumentDate(@ID)
	
	SELECT @TotalCantidad=Sum(D.Cantidad), @TotalFlete=SUM(D.Flete), @TotalCosto=SUM(D.CostoUnitario * D.Cantidad)
	FROM Inventory.MovimientosDet D
	WHERE D.IdMovimientoTit=@ID AND D.Fecha=@FechaDocumento
	
	--Se recuperan los datos del encabezado del movimiento
	SELECT @IdAlmacen=IdAlmacen, @Direccion=Direccion, @IdStatusAct=T.IdStatus, @DiasVigencia=CM.DiasVigencia, 
		@IdCorte=T.IdCorte, @IdConcepto=T.IdConcepto
	FROM Inventory.MovimientosTit T INNER JOIN Inventory.Conceptos CM 
		ON CM.IdConcepto=T.IdConcepto
	WHERE T.IdMovimientoTit=@Id and T.Fecha = @FechaDocumento
		
	--Si dias de vigencia >0 es porque este tipo de documento se valida en dias de vigencia, sino lo validamos en turno en el else
	IF @DiasVigencia > 0	
	BEGIN
		IF datediff(dd, @FechaDocumento, @HorActual) > @DiasVigencia
		BEGIN
			SET @ErrorMessage = N'El movimiento [' + ltrim(str(@IdConcepto)) +'] se generó el ' + CONVERT(varchar(10), @FechaDocumento )  + ' y su periodo de vigencia expiró.[' + @Id + ']'
			RAISERROR (@ErrorMessage,18,1)
			RETURN;
		END 	   
	END

	--APLICAR MOVIMIENTO
	IF @IdStatus=3
	BEGIN
		--Validar el estatus actual, sobre el cual se decidirá la acción a realizar
		IF @IdStatusAct=1 -- Si el estatus actual es guardado, entonces mover documento inmediatamente
			EXEC @Err=Inventory.MovimientosTitMove @Id, @IdAlmacen,@Direccion,@UserUpdate,@PCUpdate
		IF @IdStatusAct=7 -- Si el estatus actual es apartado, entonces cargar documento
			EXEC @Err=Inventory.MovimientosTitCargar @Id, @IdAlmacen,@Direccion,@UserUpdate,@PCUpdate
		IF @IdStatusAct=6 -- Si el estatus actual es cargado, entonces recibir documento
			EXEC @Err=Inventory.MovimientosTitRecibir @Id, @IdAlmacen,@Direccion,@UserUpdate,@PCUpdate

		-- Si es una entrada, calcular costo promedio
		IF @Direccion=1
			EXEC Inventory.MovimientosTitCostoPromedio @IdMovimientoTit=@ID
	END
	
	--APARTAR MOVIMIENTO
	IF @IdStatus=7
		EXEC @Err=Inventory.MovimientosTitApartar @Id, @IdAlmacen, @Direccion, @UserUpdate, @PCUpdate

	--PONER EN TRANSITO
	IF @IdStatus=8
		EXEC @Err=Inventory.MovimientosTitTransito @Id, @IdAlmacen, @Direccion, @UserUpdate, @PCUpdate
		
	UPDATE Inventory.MovimientosTit 
		SET IdStatus=@IdStatus, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=@HorActual,
		TotalCantidad=IsNull(@TotalCantidad, 0), TotalCosto=ISNULL(@TotalCosto, 0), TotalFlete=ISNULL(@TotalFlete, 0)
	WHERE IdMovimientoTit=@ID AND Fecha = Documents.fxDocumentDate(@Id)
	
	RETURN IsNull(@Err, 0)


