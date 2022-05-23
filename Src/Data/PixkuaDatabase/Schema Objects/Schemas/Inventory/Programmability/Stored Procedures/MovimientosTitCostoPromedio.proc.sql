CREATE PROCEDURE [Inventory].[MovimientosTitCostoPromedio]
	@IdMovimientoTit as char(18)
AS
	DECLARE @FechaDocumento as datetime, @IdAlmacen as int, @IdArticuloStock as int, @Existencia as decimal(19,6),
		@CantidadBase as decimal(19,6), @CostoUnitarioBase as decimal(19,4), @CostoPromedio as decimal(19,4),
		@CostoPromedioCalc as decimal(19,4)
		
	SET @FechaDocumento=Documents.fxDocumentDate(@IdMovimientoTit)						

	DECLARE cMovto CURSOR FAST_FORWARD READ_ONLY FOR
		SELECT T.IdAlmacen, D.IdArticuloStock, IsNull(I.Disponible + I.Apartado, 0), D.CantidadBase, (D.CostoUnitario / UM.Factor), IsNull(I.CostoPromedio, 0)
		FROM Inventory.MovimientosTit T INNER JOIN Inventory.MovimientosDet D 
			ON D.IdMovimientoTit=T.IdMovimientoTit and D.Fecha=T.Fecha
		JOIN Inventory.UnidadesMedida UM
			ON D.IdUnidadMedida=UM.IdUnidadMedida
		LEFT JOIN Inventory.Inventario I 
			ON I.IdArticuloStock=D.IdArticuloStock AND I.IdAlmacen = T.IdAlmacen
		WHERE T.IdMovimientoTit=@IdMovimientoTit AND T.Fecha=@FechaDocumento

	OPEN cMovto
	FETCH NEXT FROM cMovto INTO @IdAlmacen, @IdArticuloStock, @Existencia, @CantidadBase, @CostoUnitarioBase, @CostoPromedio

	WHILE @@FETCH_STATUS=0
	BEGIN
		IF @Existencia > 0 AND @CostoUnitarioBase >0
		BEGIN	
			SET @CostoPromedioCalc = ((@CostoUnitarioBase * @CantidadBase) + (@CostoPromedio * (@Existencia - @CantidadBase)))  / @Existencia
			--En el almacen 
			UPDATE Inventory.Inventario SET CostoPromedio=@CostoPromedioCalc, CostoUltimo=@CostoUnitarioBase
			WHERE IdAlmacen=@IdAlmacen and IdArticuloStock=@IdArticuloStock 
		END

		FETCH NEXT FROM cMovto INTO @IdAlmacen, @IdArticuloStock, @Existencia, @CantidadBase, @CostoUnitarioBase, @CostoPromedio
	END

	CLOSE cMovto
	DEALLOCATE cMovto


