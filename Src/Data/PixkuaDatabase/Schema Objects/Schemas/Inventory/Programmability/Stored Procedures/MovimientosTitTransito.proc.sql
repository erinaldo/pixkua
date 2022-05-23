CREATE PROCEDURE [Inventory].[MovimientosTitTransito]
	@Id as char(18),
	@IdAlmacen as int,
	@Direccion AS SmallInt,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
BEGIN
	SET NOCOUNT ON
	SET xact_abort ON

	DECLARE @IdArticuloStock as int, @Codigo as Char(16), @Articulo as varchar(128), @Almacen as varchar(128),
		@Disponible as decimal(19,6), @Apartado as decimal(19,6), @Transito as decimal(19,6), 
		@CantidadBase as decimal(19,6), @UltimoCosto as decimal(19,6), @Cantidad as decimal(19,6), 
		@Hora as datetime, @FechaDocumento as datetime, @IdStatusAct as int, @ErrorMessage nvarchar(4000)

	-->Inicializar variables
	SELECT @Codigo='', @Almacen='', @Articulo='', @Hora=getdate(), @FechaDocumento=Documents.fxDocumentDate(@Id)
	
	--Obtener estatus actual del documento
	SELECT @IdStatusAct=IdStatus
	FROM Inventory.MovimientosTit
	WHERE IdMovimientoTit=@Id AND Fecha=@FechaDocumento

	DECLARE cMovto CURSOR FAST_FORWARD READ_ONLY FOR
	SELECT D.IdArticuloStock, AX.Codigo, AX.Nombre, 
		T.Direccion, D.Cantidad, AX.UltimoCosto, D.Cantidad * UM.Factor,
		IsNull(I.Disponible,0), IsNull(I.Apartado,0), IsNull(I.Transito,0)
	FROM Inventory.MovimientosDet D JOIN Inventory.MovimientosTit T
		ON D.IdMovimientoTit=T.IdMovimientoTit AND D.Fecha=T.Fecha
	LEFT JOIN Inventory.Inventario I 
		ON D.IdArticuloStock=I.IdArticuloStock AND I.IdAlmacen=@IdAlmacen
	JOIN Inventory.ArticulosStock AX
		ON D.IdArticuloStock=AX.IdArticuloStock
	JOIN Inventory.UnidadesMedida AS UM 
		ON UM.IdUnidadMedida= D.IdUnidadMedida
	WHERE D.IdMovimientoTit=@Id AND D.Fecha=@FechaDocumento

	OPEN cMovto
	FETCH NEXT FROM cMovto INTO @IdArticuloStock, @Codigo, @Articulo, @Direccion, 
		@Cantidad, @UltimoCosto, @CantidadBase, @Disponible, @Apartado, @Transito
	WHILE @@FETCH_STATUS=0
	BEGIN
		-->Si es una salida y se tomará de la existencia, verificar que la existencia no sea menor a la cantidad que se requiere
		IF @Disponible < @CantidadBase AND @Direccion=-1 AND @IdStatusAct = 1
		BEGIN
			SET @ErrorMessage = N'A --No existe la cantidad suficiente (existencia) del Producto "' + RTRIM(LTRIM(@Codigo)) + '-' + RTRIM(LTRIM(@Articulo)) + '" en el almacén "' + @Almacen + '" - (' + RTRIM(LTRIM(IsNull(@Disponible, 0))) + ')'
			RAISERROR (@ErrorMessage,18,1)
			RETURN
		END

		-->Si es una salida y se tomará del apartado, verificar que el apartado no sea menor a la cantidad que se requiere
		IF @Apartado < @CantidadBase AND @Direccion=-1 AND @IdStatusAct = 7
		BEGIN
			SET @ErrorMessage = N'A --No existe la cantidad suficiente (apartado) del Producto "' + RTRIM(LTRIM(@Codigo)) + '-' + RTRIM(LTRIM(@Articulo)) + '" en el almacén "' + @Almacen + '" - (' + RTRIM(LTRIM(IsNull(@Apartado, 0))) + ')'
			RAISERROR (@ErrorMessage,18,1)
			RETURN
		END

		-->Si es una entrada, verificar que el producto en transito no sea menor a la cantidad que se requiere
		IF @Transito < @CantidadBase AND @Direccion=1
		BEGIN
			SET @ErrorMessage = N'B--No existe producto en transito suficiente de "' + RTRIM(LTRIM(@Codigo)) + '-' + RTRIM(LTRIM(@Articulo)) + '" en el almacén "' + @Almacen + '" - (' + RTRIM(LTRIM(IsNull(@Transito, 0))) + ')'
			RAISERROR (@ErrorMessage,18,1)
			RETURN
		END

		DECLARE @CantidadInv as decimal(19,4)
		-->Invertir cantidad del transito
		SET @CantidadInv=(@CantidadBase * -1)

		-->Si el movimiento se encontraba en apartado
		IF @IdStatusAct=7 
		BEGIN
			-->Decrementar apartado e incrementar transito
			EXEC Inventory.InventarioUPD @IdAlmacen=@IdAlmacen, @IdArticuloStock=@IdArticuloStock, @Disponible=0,
				@Apartado=@CantidadBase, @Transito=@CantidadInv, @Direccion=-1, @UserUpdate=@UserUpdate, @LastUpdate=@Hora, @PCUpdate=@PCUpdate

			--Actualizar saldos iniciales y finales
			UPDATE Inventory.MovimientosDet 
			SET CantidadBase=@CantidadBase,
				DisponibleInicial=@Disponible, DisponibleFinal=@Disponible,
				ApartadoInicial=@Apartado, ApartadoFinal=@Apartado + (@CantidadBase * @Direccion),
				TransitoInicial=@Transito, TransitoFinal=@Transito + (@CantidadInv * @Direccion),
				ExistenciaInicial=(@Disponible + @Apartado), ExistenciaFinal = (@Disponible + @Apartado) + (@CantidadBase * @Direccion)
			WHERE IdMovimientoTit=@Id AND Fecha=@FechaDocumento AND IdArticuloStock=@IdArticuloStock
				
		END				
		ELSE
		BEGIN
			-->Decrementar existencia e incrementar transito
			EXEC Inventory.InventarioUPD @IdAlmacen=@IdAlmacen, @IdArticuloStock=@IdArticuloStock, @Disponible=@CantidadBase,
				@Apartado=0, @Transito=@CantidadInv, @Direccion=@Direccion, @UserUpdate=@UserUpdate, @LastUpdate=@Hora, @PCUpdate=@PCUpdate

			--Actualizar saldos iniciales y finales
			UPDATE Inventory.MovimientosDet 
			SET CantidadBase=@CantidadBase,
				DisponibleInicial=@Disponible, DisponibleFinal=@Disponible + (@Cantidad * @Direccion),
				ApartadoInicial=@Apartado, ApartadoFinal=@Apartado,
				TransitoInicial=@Transito, TransitoFinal=@Transito + (@CantidadInv * @Direccion),
				ExistenciaInicial=(@Disponible + @Apartado), ExistenciaFinal = (@Disponible + @Apartado) + (@CantidadBase * @Direccion)
			WHERE IdMovimientoTit=@Id AND Fecha=@FechaDocumento AND IdArticuloStock=@IdArticuloStock
		END

		FETCH NEXT FROM cMovto INTO @IdArticuloStock, @Codigo, @Articulo, @Direccion, 
			@Cantidad, @UltimoCosto, @CantidadBase, @Disponible, @Apartado, @Transito
	END
	CLOSE cMovto
	DEALLOCATE cMovto

	-->Obtenemos el corte actual
	DECLARE @IdCorte as uniqueidentifier
	
	SELECT @IdCorte=IdCorteActual
	FROM Inventory.Areas AR JOIN Inventory.Almacenes AL
		ON AR.IdArea=AL.IdArea
	WHERE AL.IdAlmacen=@IdAlmacen

	-->Si no esta apartado, actualizar hora del movimiento	
	UPDATE Inventory.MovimientosTit SET HoraCarga=@Hora, HoraMovto=@Hora, IdCorte=@IdCorte
	WHERE IdMovimientoTit=@Id AND Fecha=@FechaDocumento

END


