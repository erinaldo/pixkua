-- =============================================
-- Author: RCO
-- Create date: 22-sep-2011
-- Description:	Agrega o modifica la información de PedidosDet
-- =============================================
CREATE PROCEDURE [Sales].[PedidosDetUPD]
	@Id AS int out,
	@IdPedidoTit AS char(18),
	@Fecha AS datetime,
	@IdArticuloStock AS int,
	@IdServicio AS int,
	@Codigo AS varchar(32),
	@Descripcion AS varchar(256),
	@Cantidad AS decimal(19,4),
	@Saldo AS decimal(19,4),
	@IdUnidadMedida AS int,
	@PrecioUnitario AS decimal(19,4),
	@IdPromocion AS int,
	@PorcComision AS decimal(7,6),
	@MontoComision AS decimal(19,4),
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
	@MontoImpRet5 AS decimal(19,4),
	@Flete AS decimal(19,4),
	@CodigoArticulo as varchar(32),
	@NombreArticulo as varchar(128),
	@UnidadMedida as varchar(64)
AS
	SET NOCOUNT ON
	
	IF NOT EXISTS(SELECT IdPedidoTit FROM Sales.PedidosDet WHERE IdPedidoTit=@IdPedidoTit and Fecha=Documents.fxDocumentDate(@IdPedidoTit) AND IdArticuloStock=@IdArticuloStock)
	BEGIN		
		INSERT INTO Sales.PedidosDet(IdPedidoDet, IdPedidoTit, Fecha, IdArticuloStock, IdServicio, Codigo, Descripcion, Cantidad, Saldo, IdUnidadMedida, PrecioUnitario, IdPromocion, PorcComision, MontoComision, PorcDescuento1, PorcDescuento2, PorcDescuento3, PorcDescuento4, PorcDescuento5, MontoDesc1, MontoDesc2, MontoDesc3, MontoDesc4, MontoDesc5, IdImpuesto1, IdImpuesto2, IdImpuesto3, IdImpuesto4, IdImpuesto5, PorcImpTras1, PorcImpTras2, PorcImpTras3, PorcImpTras4, PorcImpTras5, MontoImpTras1, MontoImpTras2, MontoImpTras3, MontoImpTras4, MontoImpTras5, PorcImpRet1, PorcImpRet2, PorcImpRet3, PorcImpRet4, PorcImpRet5, MontoImpRet1, MontoImpRet2, MontoImpRet3, MontoImpRet4, MontoImpRet5, Flete)
		VALUES (@Id, @IdPedidoTit, @Fecha, @IdArticuloStock, @IdServicio, @Codigo, @Descripcion, @Cantidad, @Saldo, @IdUnidadMedida, @PrecioUnitario, @IdPromocion, @PorcComision, @MontoComision, @PorcDescuento1, @PorcDescuento2, @PorcDescuento3, @PorcDescuento4, @PorcDescuento5, @MontoDesc1, @MontoDesc2, @MontoDesc3, @MontoDesc4, @MontoDesc5, @IdImpuesto1, @IdImpuesto2, @IdImpuesto3, @IdImpuesto4, @IdImpuesto5, @PorcImpTras1, @PorcImpTras2, @PorcImpTras3, @PorcImpTras4, @PorcImpTras5, @MontoImpTras1, @MontoImpTras2, @MontoImpTras3, @MontoImpTras4, @MontoImpTras5, @PorcImpRet1, @PorcImpRet2, @PorcImpRet3, @PorcImpRet4, @PorcImpRet5, @MontoImpRet1, @MontoImpRet2, @MontoImpRet3, @MontoImpRet4, @MontoImpRet5, @Flete)
	END
	ELSE
		UPDATE Sales.PedidosDet SET IdPedidoTit=@IdPedidoTit, Fecha=@Fecha, IdArticuloStock=@IdArticuloStock, IdServicio=@IdServicio, Codigo=@Codigo, Descripcion=@Descripcion, Cantidad=@Cantidad, Saldo=@Saldo, IdUnidadMedida=@IdUnidadMedida, PrecioUnitario=@PrecioUnitario, IdPromocion=@IdPromocion, PorcComision=@PorcComision, MontoComision=@MontoComision, PorcDescuento1=@PorcDescuento1, PorcDescuento2=@PorcDescuento2, PorcDescuento3=@PorcDescuento3, PorcDescuento4=@PorcDescuento4, PorcDescuento5=@PorcDescuento5, MontoDesc1=@MontoDesc1, MontoDesc2=@MontoDesc2, MontoDesc3=@MontoDesc3, MontoDesc4=@MontoDesc4, MontoDesc5=@MontoDesc5, IdImpuesto1=@IdImpuesto1, IdImpuesto2=@IdImpuesto2, IdImpuesto3=@IdImpuesto3, IdImpuesto4=@IdImpuesto4, IdImpuesto5=@IdImpuesto5, PorcImpTras1=@PorcImpTras1, PorcImpTras2=@PorcImpTras2, PorcImpTras3=@PorcImpTras3, PorcImpTras4=@PorcImpTras4, PorcImpTras5=@PorcImpTras5, MontoImpTras1=@MontoImpTras1, MontoImpTras2=@MontoImpTras2, MontoImpTras3=@MontoImpTras3, MontoImpTras4=@MontoImpTras4, MontoImpTras5=@MontoImpTras5, PorcImpRet1=@PorcImpRet1, PorcImpRet2=@PorcImpRet2, PorcImpRet3=@PorcImpRet3, PorcImpRet4=@PorcImpRet4, PorcImpRet5=@PorcImpRet5, MontoImpRet1=@MontoImpRet1, MontoImpRet2=@MontoImpRet2, MontoImpRet3=@MontoImpRet3, MontoImpRet4=@MontoImpRet4, MontoImpRet5=@MontoImpRet5, Flete=@Flete
		WHERE IdPedidoTit= @Id and Fecha = Documents.fxDocumentDate(@Id)


