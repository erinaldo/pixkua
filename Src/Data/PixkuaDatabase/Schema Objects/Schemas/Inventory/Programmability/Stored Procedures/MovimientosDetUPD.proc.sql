-- =============================================
-- Author: RCO
-- Create date: 07-dic-2010
-- Description:	Agrega o modifica la información de MovimientosDet
-- =============================================
CREATE PROCEDURE [Inventory].[MovimientosDetUPD]
	@Id AS char(18),
	@IdArticuloStock AS int,
	@Fecha AS datetime,
	@Cantidad AS decimal(19,4),
	@Unidades as int,
	@IdUnidadMedida AS int,
	@CantidadBase AS decimal(19,4),
	@CostoUnitario AS decimal(19,4),
	@Flete AS decimal(19,4),
	@DisponibleInicial AS decimal(19,4),
	@DisponibleFinal AS decimal(19,4),
	@ApartadoInicial AS decimal(19,4),
	@ApartadoFinal AS decimal(19,4),
	@TransitoInicial AS decimal(19,4),
	@TransitoFinal AS decimal(19,4),
	@ExistenciaInicial AS decimal(19,4),
	@ExistenciaFinal AS decimal(19,4),
	@CodigoArticulo as varchar(32),
	@NombreArticulo as varchar(128),
	@UnidadMedida as varchar(64),
	@IdUnidadMedidaTipo as int,
	@Existencia as decimal(19,4),
	@ExistenciaBase as decimal(19,4)
AS
	SET NOCOUNT ON
	
	-- Si el costo unitario es cero, obtener el último costo del artículo
	IF @CostoUnitario=0
		SELECT @CostoUnitario=CostoPromedio
		FROM Inventory.ArticulosStock
		WHERE IdArticuloStock=@IdArticuloStock
	
	IF NOT EXISTS(SELECT IdMovimientoTit FROM Inventory.MovimientosDet WHERE IdMovimientoTit=@Id and Fecha=Documents.fxDocumentDate(@Id) AND IdArticuloStock=@IdArticuloStock)
	BEGIN		
		INSERT INTO Inventory.MovimientosDet(IdMovimientoTit, IdArticuloStock, Fecha, Cantidad, IdUnidadMedida, 
			CantidadBase, CostoUnitario, Flete, DisponibleInicial, DisponibleFinal, ApartadoInicial, ApartadoFinal, TransitoInicial, TransitoFinal, ExistenciaInicial, ExistenciaFinal)
		VALUES (@Id, @IdArticuloStock, @Fecha, @Cantidad, @IdUnidadMedida, 
			@CantidadBase, @CostoUnitario, @Flete, @DisponibleInicial, @DisponibleFinal, @ApartadoInicial, @ApartadoFinal, @TransitoInicial, @TransitoFinal, @ExistenciaInicial, @ExistenciaFinal)
	END
	ELSE
		UPDATE Inventory.MovimientosDet SET Cantidad=@Cantidad, IdUnidadMedida=@IdUnidadMedida, 
			CantidadBase=@CantidadBase, CostoUnitario=@CostoUnitario, Flete=@Flete, DisponibleInicial=@DisponibleInicial, 
			DisponibleFinal=@DisponibleFinal, ApartadoInicial=@ApartadoInicial, ApartadoFinal=@ApartadoFinal, 
			TransitoInicial=@TransitoInicial, TransitoFinal=@TransitoFinal, ExistenciaInicial=@ExistenciaInicial, ExistenciaFinal=@ExistenciaFinal
		WHERE IdMovimientoTit= @Id and Fecha = Documents.fxDocumentDate(@Id) AND IdArticuloStock=@IdArticuloStock


