CREATE PROCEDURE [Inventory].[MovimientosTitCargar]
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
	SELECT @Codigo='', @Almacen='', @Articulo='', @Hora=getdate(), @FechaDocumento=Documents.fxDocumentDate(@Id)

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
		IF @Apartado < @CantidadBase AND @Direccion=-1
		BEGIN
			SET @ErrorMessage = N'No existe el apartado suficiente del Producto "' + RTRIM(LTRIM(@Codigo)) + '-' + RTRIM(LTRIM(@Articulo)) + '" en el almacén "' + @Almacen + '" - (' + RTRIM(LTRIM(IsNull(@Apartado, 0))) + ')'
			RAISERROR (@ErrorMessage,18,1)
			RETURN
		END
		
		-->Actualizar inventario
		EXEC Inventory.InventarioUPD @IdAlmacen=@IdAlmacen, @IdArticuloStock=@IdArticuloStock, @Disponible=0,
			@Apartado=@CantidadBase, @Transito=0, @Direccion=-1, @UserUpdate=@UserUpdate, @LastUpdate=@Hora, @PCUpdate=@PCUpdate

		--Actualizar saldos iniciales y finales
		UPDATE Inventory.MovimientosDet 
		SET CantidadBase=@CantidadBase, 
			DisponibleInicial=@Disponible, DisponibleFinal=@Disponible,
			ApartadoInicial=@Apartado, ApartadoFinal=@Apartado + (@CantidadBase * @Direccion),
			TransitoInicial=@Transito, TransitoFinal=@Transito,
			ExistenciaInicial=@Disponible + @Apartado, ExistenciaFinal= (@Disponible + @Apartado) + (@CantidadBase * @Direccion)
		WHERE IdMovimientoTit=@Id AND Fecha=@FechaDocumento AND IdArticuloStock=@IdArticuloStock

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

	-->Actualizar hora del movimiento
	UPDATE Inventory.MovimientosTit SET HoraAplicado=@Hora, HoraMovto=@Hora, IdCorte=@IdCorte
	WHERE IdMovimientoTit=@Id AND Fecha=@FechaDocumento

END


