CREATE FUNCTION [Sales].[fxPrecioArticuloCliente](@IdArticuloStock as int, @IdSucursal as int, @IdCliente as int, @PrecioFijo as decimal(19,4))
RETURNS @RetTable Table (
	Precio decimal(19,4), IdDivisa int, TipoCambio decimal(19,4),
	IdImpuesto1 int, IdImpuesto2 int, IdImpuesto3 int, 
	IdImpuesto4 int, IdImpuesto5 int, 
	PorcImpuesto1 decimal(7,6), PorcImpuesto2 decimal(7,6), PorcImpuesto3 decimal(7,6), 
	PorcImpuesto4 decimal(7,6), PorcImpuesto5 decimal(7,6),
	MontoImpuesto1 decimal(19,4), MontoImpuesto2 decimal(19,4), MontoImpuesto3 decimal(19,4), 
	MontoImpuesto4 decimal(19,4), MontoImpuesto5 decimal(19,4), 	
	PorcRetencion1 decimal(7,6), PorcRetencion2 decimal(7,6), PorcRetencion3 decimal(7,6),
	PorcRetencion4 decimal(7,6), PorcRetencion5 decimal(7,6),
	MontoRetencion1 decimal(19,4), MontoRetencion2 decimal(19,4), MontoRetencion3 decimal(19,4),
	MontoRetencion4 decimal(19,4), MontoRetencion5 decimal(19,4), 
	PorcDescuento1 decimal(7,6), PorcDescuento2 decimal(7,6), PorcDescuento3 decimal(7,6), 
	PorcDescuento4 decimal(7,6), PorcDescuento5 decimal(7,6),
	MontoDescuento1 decimal(19,4), MontoDescuento2 decimal(19,4), MontoDescuento3 decimal(19,4), 
	MontoDescuento4 decimal(19,4), MontoDescuento5 decimal(19,4)
	)
AS
BEGIN
	DECLARE @Precio decimal(19,4), @IdDivisa int, @TipoCambio decimal(19,4),
		@IdImpuesto1 int, @IdImpuesto2 int, @IdImpuesto3 int, 
		@IdImpuesto4 int, @IdImpuesto5 int, 
		@PorcImpuesto1 decimal(19,6), @PorcImpuesto2 decimal(19,6), @PorcImpuesto3 decimal(19,6), 
		@PorcImpuesto4 decimal(19,6), @PorcImpuesto5 decimal(19,6), 
		@MontoImpuesto1 decimal(19,4), @MontoImpuesto2 decimal(19,4), @MontoImpuesto3 decimal(19,4), 
		@MontoImpuesto4 decimal(19,4), @MontoImpuesto5 decimal(19,4), 
		@PorcRetencion1 decimal(7,6), @PorcRetencion2 decimal(7,6), @PorcRetencion3 decimal(7,6),
		@PorcRetencion4 decimal(7,6), @PorcRetencion5 decimal(7,6),
		@MontoRetencion1 decimal(19,4), @MontoRetencion2 decimal(19,4), @MontoRetencion3 decimal(19,4),
		@MontoRetencion4 decimal(19,4), @MontoRetencion5 decimal(19,4), 	
		@PorcDescuento1 decimal(19,6), @PorcDescuento2 decimal(19,6), @PorcDescuento3 decimal(19,6), 
		@PorcDescuento4 decimal(19,6), @PorcDescuento5 decimal(19,6),
		@MontoDescuento1 decimal(19,4), @MontoDescuento2 decimal(19,4), @MontoDescuento3 decimal(19,4), 
		@MontoDescuento4 decimal(19,4), @MontoDescuento5 decimal(19,4),
		@TipoPrecio as char(1), @IdZonaVenta as int, @IdDivisaBase as int

	/*Inicializar valores*/
	SELECT @Precio=0, @IdDivisa=0, @TipoCambio=0,
		@IdImpuesto1=0, @IdImpuesto2=0, @IdImpuesto3=0, 
		@IdImpuesto4=0, @IdImpuesto5=0, 
		@PorcImpuesto1=0, @PorcImpuesto2=0, @PorcImpuesto3=0, 
		@PorcImpuesto4=0, @PorcImpuesto5=0, @MontoImpuesto1=0, @MontoImpuesto2=0, @MontoImpuesto3=0, 
		@MontoImpuesto4=0, @MontoImpuesto5=0, @PorcRetencion1=0, @PorcRetencion2=0, @PorcRetencion3=0, 
		@PorcRetencion4=0, @PorcRetencion5=0, @MontoRetencion1=0, @MontoRetencion2=0, @MontoRetencion3=0, 
		@MontoRetencion4=0, @MontoRetencion5=0, 
		@PorcDescuento1=0, @PorcDescuento2=0, @PorcDescuento3=0, @PorcDescuento4=0, @PorcDescuento5=0, 
		@MontoDescuento1=0, @MontoDescuento2=0, @MontoDescuento3=0, @MontoDescuento4=0, @MontoDescuento5=0

	/*Obtener la lista de precios y grupo de descuentos del cliente*/
	DECLARE @IdListaPrecios as int, @IdGrupoDescuentos as int
	SELECT @IdListaPrecios=IdListaPrecio, @IdGrupoDescuentos=IdGrupoDescuentos
	FROM Sales.Clientes WITH (READUNCOMMITTED) 
	WHERE IdCliente=@IdCliente

	/*Verificar la configuración de la unidad de negocio para saber que tipo de precio tomar*/
	SELECT @TipoPrecio=TipoPrecio, @IdZonaVenta=IdZonaVenta 
	FROM Sales.UnidadesNegocio 
	WHERE IdSucursal=@IdSucursal

	/*Obtener precio e impuestos de la zona de ventas*/
	SELECT @Precio=Precio, @IdDivisa=IdDivisa, @IdImpuesto1=IdImpuesto1, @IdImpuesto2=IdImpuesto2, @IdImpuesto3=IdImpuesto3,
		@PorcRetencion1=PorcRetencion1, @PorcRetencion2=PorcRetencion2, @PorcRetencion3=PorcRetencion3
	FROM Sales.ArticulosZonasVenta WITH (READUNCOMMITTED)
	WHERE IdZonaVenta=@IdZonaVenta AND IdArticuloStock=@IdArticuloStock

	/*Obtener divisa base*/
	SET @IdDivisaBase=Cast(dbo.fxParamGetValue('Configuracion/Contabilidad/Divisas', 'Base') AS int)

	/*Obtener tipo de cambio de la divisa en que se vende el servicio*/
	SELECT @TipoCambio=Accounting.fxTipoCambioActual(@IdDivisa, @IdDivisaBase)
	
	/*Si es por listas de precio*/
	IF @TipoPrecio='L'
	BEGIN
		/*Obtener precio de articulo de la lista de precios*/
		SELECT @Precio=Precio FROM Sales.ListasPreciosArticulos WITH (READUNCOMMITTED)
		WHERE IdListaPrecio=@IdListaPrecios AND IdArticuloStock=@IdArticuloStock
	END

	--Si se envio por parametro un precio fijo, se respeta
    IF @PrecioFijo >0
		SET @Precio=@PrecioFijo

	/*Obtener porcentajes y montos de los descuentos del cliente*/
	SELECT @PorcDescuento1=PorcDescuento1, @PorcDescuento2=PorcDescuento2, 
		@PorcDescuento3=PorcDescuento3, @PorcDescuento4=PorcDescuento4, 
		@PorcDescuento5=PorcDescuento5, 
		@MontoDescuento1=round(PorcDescuento1 * @Precio,2), 
		@MontoDescuento2=round(PorcDescuento2 * @Precio,2), @MontoDescuento3=round(PorcDescuento3 * @Precio,2), 
		@MontoDescuento4=round(PorcDescuento4 * @Precio,2), @MontoDescuento5=round(PorcDescuento5 * @Precio,2)
	FROM Sales.GruposDescuentoArticulos WITH (READUNCOMMITTED)
	WHERE IdGrupoDescuento=@IdGrupoDescuentos AND IdArticuloStock=@IdArticuloStock
	-->Recalculo de Monto de descuento 2 (descuento adicional) ya que el descuento no es sobre la base
	SET @MontoDescuento2 = round((@Precio - @MontoDescuento1) * @PorcDescuento2, 2)
	SET @MontoDescuento3 = round((@Precio - @MontoDescuento1 - @MontoDescuento2) * @PorcDescuento3, 2)

	-->Obtener el precio con los descuentos aplicados
	DECLARE @PrecioDesc AS decimal(19,6)
	SET @PrecioDesc=@Precio - @MontoDescuento1 - @MontoDescuento2 - @MontoDescuento3 - @MontoDescuento4 - @MontoDescuento5 

	/*Obtener porcentajes y montos de los impuestos*/
	SELECT @PorcImpuesto1=Porcentaje, @MontoImpuesto1=round(Porcentaje * @PrecioDesc, 2)
	FROM Accounting.Impuestos
	WHERE IdImpuesto=@IdImpuesto1

	SELECT @PorcImpuesto2=Porcentaje, @MontoImpuesto2=round(Porcentaje * @PrecioDesc, 2)
	FROM Accounting.Impuestos
	WHERE IdImpuesto=@IdImpuesto2

	SELECT @PorcImpuesto3=Porcentaje, @MontoImpuesto3=round(Porcentaje * @PrecioDesc, 2) 
	FROM Accounting.Impuestos
	WHERE IdImpuesto=@IdImpuesto3
	
	/*Obtener los montos de las retenciones*/
	SET @MontoRetencion1=round(@PrecioDesc * @PorcRetencion1, 2)
	SET @MontoRetencion2=round(@PrecioDesc * @PorcRetencion2, 2)
	SET @MontoRetencion3=round(@PrecioDesc * @PorcRetencion3, 2)
	
	SET @Precio=round(@Precio, 2)

	/*Insertar valores en la tabla de retorno*/
	INSERT INTO @RetTable (Precio, IdDivisa, TipoCambio,
		IdImpuesto1, IdImpuesto2, IdImpuesto3, 
		IdImpuesto4, IdImpuesto5, PorcImpuesto1, PorcImpuesto2, PorcImpuesto3, 
		PorcImpuesto4, PorcImpuesto5, MontoImpuesto1, MontoImpuesto2, MontoImpuesto3, 
		MontoImpuesto4, MontoImpuesto5, PorcRetencion1, PorcRetencion2, PorcRetencion3, 
		PorcRetencion4, PorcRetencion5, MontoRetencion1, MontoRetencion2, MontoRetencion3, 
		MontoRetencion4, MontoRetencion5, 
		PorcDescuento1, PorcDescuento2, PorcDescuento3, 
		PorcDescuento4, PorcDescuento5, MontoDescuento1, MontoDescuento2, MontoDescuento3, 
		MontoDescuento4, MontoDescuento5)
	VALUES (@Precio, @IdDivisa, @TipoCambio,
		@IdImpuesto1, @IdImpuesto2, @IdImpuesto3, 
		@IdImpuesto4, @IdImpuesto5, @PorcImpuesto1, @PorcImpuesto2, @PorcImpuesto3, 
		@PorcImpuesto4, @PorcImpuesto5, @MontoImpuesto1, @MontoImpuesto2, @MontoImpuesto3, 
		@MontoImpuesto4, @MontoImpuesto5, @PorcRetencion1, @PorcRetencion2, @PorcRetencion3, 
		@PorcRetencion4, @PorcRetencion5, @MontoRetencion1, @MontoRetencion2, @MontoRetencion3, 
		@MontoRetencion4, @MontoRetencion5,
		@PorcDescuento1, @PorcDescuento2, @PorcDescuento3, 
		@PorcDescuento4, @PorcDescuento5, @MontoDescuento1, @MontoDescuento2, @MontoDescuento3, 
		@MontoDescuento4, @MontoDescuento5)

	RETURN
END


