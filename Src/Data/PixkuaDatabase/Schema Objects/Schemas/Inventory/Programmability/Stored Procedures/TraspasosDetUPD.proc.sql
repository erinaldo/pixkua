-- =============================================
-- Author: RCO
-- Create date: 26-jun-2011
-- Description:	Agrega o modifica la información de TraspasosDet
-- =============================================
CREATE PROCEDURE [Inventory].[TraspasosDetUPD]
	@Id AS char(18) out,
	@IdArticuloStock AS int,
	@Fecha as datetime,
	@CantidadEnviada AS decimal(19,4),
	@CantidadRecibida AS decimal(19,4),
	@Unidades as int,
	@IdUnidadMedida AS int,
	@CostoUnitario AS decimal(19,4),
	@Flete AS decimal(19,4),
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
	
	IF NOT EXISTS(SELECT IdTraspasoTit FROM Inventory.TraspasosDet WHERE IdTraspasoTit=@Id and Fecha=@Fecha AND IdArticuloStock=@IdArticuloStock)
	BEGIN		
		INSERT INTO Inventory.TraspasosDet(IdTraspasoTit, Fecha, IdArticuloStock, CantidadEnviada, 
			CantidadRecibida, IdUnidadMedida, CostoUnitario, Flete)
		VALUES (@Id, @Fecha, @IdArticuloStock, @CantidadEnviada, 
			@CantidadRecibida, @IdUnidadMedida, @CostoUnitario, @Flete)
	END
	ELSE
		UPDATE Inventory.TraspasosDet SET CantidadEnviada=@CantidadEnviada, CantidadRecibida=@CantidadRecibida, 
			IdUnidadMedida=@IdUnidadMedida, CostoUnitario=@CostoUnitario, Flete=@Flete
		WHERE IdTraspasoTit=@Id and Fecha=@Fecha and IdArticuloStock=@IdArticuloStock


