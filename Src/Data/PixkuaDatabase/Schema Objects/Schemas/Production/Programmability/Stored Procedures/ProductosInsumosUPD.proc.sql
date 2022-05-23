CREATE PROCEDURE [Production].[ProductosInsumosUPD]
	@IdProducto AS int,
	@IdInsumo AS int,
	@IdUnidadMedida as int,
	@Cantidad AS decimal(19,4),
	@IdMetaAlmacen AS int,
	@PorcMerma AS int,
	@Opcional as bit
AS
	SET NOCOUNT ON
	
	IF NOT EXISTS(SELECT IdProductoInsumo FROM Production.ProductosInsumos WHERE IdInsumo=@IdInsumo AND IdProducto=@IdProducto)
	BEGIN		
		INSERT INTO Production.ProductosInsumos (IdProducto,IdInsumo,IdUnidadMedida,Cantidad, IdMetaAlmacen, PorcMerma, Opcional)
		VALUES (@IdProducto, @IdInsumo, @IdUnidadMedida, @Cantidad, @IdMetaAlmacen, @PorcMerma, @Opcional)
	END
	ELSE
		UPDATE Production.ProductosInsumos  SET IdUnidadMedida=@IdUnidadMedida, Cantidad=@Cantidad, IdMetaAlmacen=@IdMetaAlmacen, PorcMerma=@PorcMerma, Opcional=@Opcional
		WHERE IdInsumo=@IdInsumo AND IdProducto=@IdProducto


