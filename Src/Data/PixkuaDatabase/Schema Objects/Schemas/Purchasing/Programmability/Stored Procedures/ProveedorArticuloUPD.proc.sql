CREATE PROCEDURE [Purchasing].[ProveedorArticuloUPD]
	@IdZonaCompra as int,
	@IdProveedor as int,
	@IdArticuloStock as int,
	@Costo as decimal(19,4),
	@IdDivisa as int,
	@DiasCredito as int,
	@DiasEntrega as int,
	@IdUnidadMedida as int,
	@IdImpuesto1 as int,
	@IdImpuesto2 as int,
	@IdImpuesto3 as int,
	@IdRetencion1 as int,
	@IdRetencion2 as int,
	@IdRetencion3 as int,
	@PorcDescuento1 as decimal(7,6),
	@PorcDescuento2 as decimal(7,6),
	@PorcDescuento3 as decimal(7,6),
	@Predeterminado as bit
AS
	SET NOCOUNT ON
	
	/*Si se marcó como proveedor predeterminado para éste artículo asegurarse de que los demás proveedores no tengan la marca*/
	IF @Predeterminado=1
		UPDATE Purchasing.ProveedoresArticulos SET Predeterminado=0
		WHERE IdArticuloStock=@IdArticuloStock AND IdZonaCompra=@IdZonaCompra

	/*Verificar si ya existe un registro para el artículo con el mismo proveedor y zona*/	
	IF EXISTS(SELECT IdArticuloStock FROM Purchasing.ProveedoresArticulos WHERE IdZonaCompra=@IdZonaCompra AND IdProveedor=@IdProveedor AND IdArticuloStock=@IdArticuloStock)
		UPDATE Purchasing.ProveedoresArticulos SET Costo=@Costo, IdDivisa=@IdDivisa, DiasCredito=@DiasCredito, DiasEntrega=@DiasEntrega,
			IdUnidadMedida=@IdUnidadMedida, IdImpuesto1=@IdImpuesto1, IdImpuesto2=@IdImpuesto2, IdImpuesto3=@IdImpuesto3, 
			IdRetencion1=@IdRetencion1, IdRetencion2=@IdRetencion2, IdRetencion3=@IdRetencion3, PorcDescuento1=@PorcDescuento1,
			PorcDescuento2=@PorcDescuento2, PorcDescuento3=@PorcDescuento3,
			Predeterminado=@Predeterminado
		WHERE IdZonaCompra=@IdZonaCompra AND IdProveedor=@IdProveedor AND IdArticuloStock=@IdArticuloStock
	ELSE	
		INSERT INTO Purchasing.ProveedoresArticulos (IdZonaCompra, IdProveedor, IdArticuloStock, Costo, IdDivisa, DiasCredito, DiasEntrega,
			IdUnidadMedida, IdImpuesto1, IdImpuesto2, IdImpuesto3, IdRetencion1, IdRetencion2, IdRetencion3, 
			PorcDescuento1, PorcDescuento2, PorcDescuento3, Predeterminado)
		VALUES (@IdZonaCompra, @IdProveedor, @IdArticuloStock, @Costo, @IdDivisa, @DiasCredito, @DiasEntrega,
			@IdUnidadMedida, @IdImpuesto1, @IdImpuesto2, @IdImpuesto3, @IdRetencion1, @IdRetencion2, @IdRetencion3, 
			@PorcDescuento1, @PorcDescuento2, @PorcDescuento3, @Predeterminado)


