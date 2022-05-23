CREATE PROCEDURE [Sales].[VentasServiciosUPD]
	@IdVentaDet as int=0 out,
	@IdVentaTit AS char(18),
	@IdServicio AS int,
	@IdArticuloStock AS int,
	@Codigo AS varchar(32),
	@Descripcion AS varchar(512),
	@Cantidad AS decimal(19,4),
	@PrecioUnitario AS decimal(19,4),
	@IdPromocion AS int,
	@PorcComision as decimal(7,6),
	@MontoComision as decimal(19,4),
	@PorcDescuento1 AS decimal(7,6),
	@PorcDescuento2 AS decimal(7,6),
	@PorcDescuento3 AS decimal(7,6),
	@PorcDescuento4 AS decimal(7,6),
	@PorcDescuento5 AS decimal(7,6),
	@MontoDesc1 AS decimal(19,4),
	@MontoDesc2 AS decimal(19,4),
	@MontoDesc3 AS decimal(19,4),
	@MontoDesc4 AS decimal(19,4),
	@MontoDesc5 AS decimal(19,4),
	@IdImpuesto1 AS int,
	@IdImpuesto2 AS int,
	@IdImpuesto3 AS int,
	@IdImpuesto4 AS int,
	@IdImpuesto5 AS int,
	@PorcImpTras1 AS decimal(7,6),
	@PorcImpTras2 AS decimal(7,6),
	@PorcImpTras3 AS decimal(7,6),
	@PorcImpTras4 AS decimal(7,6),
	@PorcImpTras5 AS decimal(7,6),
	@MontoImpTras1 AS decimal(19,4),
	@MontoImpTras2 AS decimal(19,4),
	@MontoImpTras3 AS decimal(19,4),
	@MontoImpTras4 AS decimal(19,4),
	@MontoImpTras5 AS decimal(19,4),
	@PorcImpRet1 AS decimal(7,6),
	@PorcImpRet2 AS decimal(7,6),
	@PorcImpRet3 AS decimal(7,6),
	@PorcImpRet4 AS decimal(7,6),
	@PorcImpRet5 AS decimal(7,6),
	@MontoImpRet1 AS decimal(19,4),
	@MontoImpRet2 AS decimal(19,4),
	@MontoImpRet3 AS decimal(19,4),
	@MontoImpRet4 AS decimal(19,4),
	@MontoImpRet5 AS decimal(19,4)	
AS
	SET NOCOUNT ON
	DECLARE @Fecha as datetime, @IdEstCom as int
	SELECT @Fecha=Documents.fxDocumentDate(@IdVentaTit)
	
	SELECT @IdEstCom=S.IdEstCom
	FROM Sales.Servicios S
	WHERE IdServicio=@IdServicio
		
	IF EXISTS (SELECT IdVentaTit FROM Sales.VentasDet WHERE IdVentaTit=@IdVentaTit and Fecha=@Fecha AND IdArticuloStock=@IdArticuloStock AND IdServicio=@IdServicio AND IdVentaDet=@IdVentaDet)
		UPDATE Sales.VentasDet SET Codigo=@Codigo, Descripcion=@Descripcion, Cantidad=@Cantidad, 
			IdUnidadMedida=0, PrecioUnitario=@PrecioUnitario, 
			IdPromocion=@IdPromocion, PorcDescuento1=@PorcDescuento1, 
			PorcDescuento2=@PorcDescuento2, PorcDescuento3=@PorcDescuento3, 
			PorcDescuento4=@PorcDescuento4, PorcDescuento5=@PorcDescuento5, MontoDesc1=@MontoDesc1, 
			MontoDesc2=@MontoDesc2, MontoDesc3=@MontoDesc3, MontoDesc4=@MontoDesc4, 
			MontoDesc5=@MontoDesc5, IdImpuesto1=@IdImpuesto1, IdImpuesto2=@IdImpuesto2, 
			IdImpuesto3=@IdImpuesto3, IdImpuesto4=@IdImpuesto4, IdImpuesto5=@IdImpuesto5, 
			PorcImpTras1=@PorcImpTras1, PorcImpTras2=@PorcImpTras2, PorcImpTras3=@PorcImpTras3, 
			PorcImpTras4=@PorcImpTras4, PorcImpTras5=@PorcImpTras5, MontoImpTras1=@MontoImpTras1, 
			MontoImpTras2=@MontoImpTras2, MontoImpTras3=@MontoImpTras3, MontoImpTras4=@MontoImpTras4, 
			MontoImpTras5=@MontoImpTras5, PorcImpRet1=@PorcImpRet1, PorcImpRet2=@PorcImpRet2, 
			PorcImpRet3=@PorcImpRet3, PorcImpRet4=@PorcImpRet4, PorcImpRet5=@PorcImpRet5, 
			MontoImpRet1=@MontoImpRet1, MontoImpRet2=@MontoImpRet2, MontoImpRet3=@MontoImpRet3, 
			MontoImpRet4=@MontoImpRet4, MontoImpRet5=@MontoImpRet5, Flete=0, PorcComision=@PorcComision,
			MontoComision=@MontoComision
		WHERE IdVentaTit=@IdVentaTit and Fecha=@Fecha 
			AND IdArticuloStock=@IdArticuloStock AND IdServicio=@IdServicio AND IdVentaDet=@IdVentaDet
	
	ELSE
	BEGIN				
		INSERT INTO Sales.VentasDet(IdVentaTit, Fecha, IdArticuloStock, IdServicio, Codigo, Descripcion, 
			Cantidad, IdUnidadMedida, PrecioUnitario, IdPromocion, IdEstCom,
			PorcDescuento1, PorcDescuento2, PorcDescuento3, PorcDescuento4, PorcDescuento5, 
			MontoDesc1, MontoDesc2, MontoDesc3, MontoDesc4, MontoDesc5, IdImpuesto1, 
			IdImpuesto2, IdImpuesto3, IdImpuesto4, IdImpuesto5, PorcImpTras1, PorcImpTras2, 
			PorcImpTras3, PorcImpTras4, PorcImpTras5, MontoImpTras1, MontoImpTras2, 
			MontoImpTras3, MontoImpTras4, MontoImpTras5, PorcImpRet1, PorcImpRet2, PorcImpRet3, 
			PorcImpRet4, PorcImpRet5, MontoImpRet1, MontoImpRet2, MontoImpRet3, MontoImpRet4, 
			MontoImpRet5, Flete, PorcComision, MontoComision)
		VALUES (@IdVentaTit, @Fecha, @IdArticuloStock, @IdServicio, @Codigo, @Descripcion, 
			@Cantidad, 0, @PrecioUnitario, @IdPromocion, @IdEstCom,
			@PorcDescuento1, @PorcDescuento2, @PorcDescuento3, @PorcDescuento4, @PorcDescuento5, 
			@MontoDesc1, @MontoDesc2, @MontoDesc3, @MontoDesc4, @MontoDesc5, @IdImpuesto1, 
			@IdImpuesto2, @IdImpuesto3, @IdImpuesto4, @IdImpuesto5, @PorcImpTras1, @PorcImpTras2, 
			@PorcImpTras3, @PorcImpTras4, @PorcImpTras5, @MontoImpTras1, @MontoImpTras2, 
			@MontoImpTras3, @MontoImpTras4, @MontoImpTras5, @PorcImpRet1, @PorcImpRet2, @PorcImpRet3, 
			@PorcImpRet4, @PorcImpRet5, @MontoImpRet1, @MontoImpRet2, @MontoImpRet3, @MontoImpRet4, 
			@MontoImpRet5, 0, @PorcComision, @MontoComision)
			
		SET @IdVentaDet=@@IDENTITY		
	END


