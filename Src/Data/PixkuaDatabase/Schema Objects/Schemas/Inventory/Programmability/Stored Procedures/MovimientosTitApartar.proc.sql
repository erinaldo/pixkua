CREATE PROCEDURE [Inventory].[MovimientosTitApartar]
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
		@Hora as datetime, @FechaDocumento as datetime, @ErrorMessage nvarchar(4000)
		
	-->Inicializar variables
	SELECT @Codigo ='',@Almacen='',@Articulo='', @FechaDocumento=Documents.fxDocumentDate(@Id), @Hora=getdate()

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
		-->Si es una salida, verificar que la existencia no sea menor a la cantidad que se requiere
		IF @Disponible < @CantidadBase AND @Direccion=-1
		BEGIN
			SET @ErrorMessage = N'No existe la cantidad suficiente del Producto "' + RTRIM(LTRIM(@Codigo)) + '-' + RTRIM(LTRIM(@Articulo)) + '" en el almacén "' + @Almacen + '" - (' + RTRIM(LTRIM(IsNull(@Disponible, 0))) + ')'
			RAISERROR (@ErrorMessage,18,1)
		END

		-->Si es una entrada, verificar que el apartado no sea menor a la cantidad que se requiere
		IF @Apartado < @CantidadBase AND @Direccion=1
		BEGIN
			SET @ErrorMessage = N'No existe el apartado suficiente del Producto "' + RTRIM(LTRIM(@Codigo)) + '-' + RTRIM(LTRIM(@Articulo)) + '" en el almacén "' + @Almacen + '" - (' + RTRIM(LTRIM(IsNull(@Disponible, 0))) + ')'
			RAISERROR (@ErrorMessage,18,1)
		END

		DECLARE @CantidadInv as decimal(19,6)
		-->Invertir signo cantidad del apartado
		SET @CantidadInv=@CantidadBase * -1
		-->Actualizar inventario
		EXEC Inventory.InventarioUPD @IdAlmacen=@IdAlmacen, @IdArticuloStock=@IdArticuloStock, @Disponible=@CantidadBase,
			@Apartado=@CantidadInv, @Transito=0, @Direccion=@Direccion, @UserUpdate=@UserUpdate, @LastUpdate=@Hora, @PCUpdate=@PCUpdate

		--Actualizamos el detalle del movimiento		
		UPDATE Inventory.MovimientosDet 
		SET CantidadBase=@CantidadBase, 
			DisponibleInicial=@Disponible, DisponibleFinal=@Disponible + (@CantidadBase * @Direccion),
			ApartadoInicial=@Apartado, ApartadoFinal=@Apartado + (@CantidadInv * @Direccion),
			TransitoInicial=@Transito, TransitoFinal=@Transito,
			ExistenciaInicial=(@Disponible + @Apartado), ExistenciaFinal=(@Disponible + @Apartado)
		WHERE IdMovimientoTit=@Id AND Fecha=@FechaDocumento AND IdArticuloStock=@IdArticuloStock

		FETCH NEXT FROM cMovto INTO @IdArticuloStock, @Codigo, @Articulo, @Direccion, 
			@Cantidad, @UltimoCosto, @CantidadBase, @Disponible, @Apartado, @Transito
	END
	CLOSE cMovto
	DEALLOCATE cMovto

	-->Actualizar hora del movimiento
	UPDATE Inventory.MovimientosTit SET HoraApartado=@Hora
	WHERE IdMovimientoTit=@Id AND Fecha=@FechaDocumento

END


