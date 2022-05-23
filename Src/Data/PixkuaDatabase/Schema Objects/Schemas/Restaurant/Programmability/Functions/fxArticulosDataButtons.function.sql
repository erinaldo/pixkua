CREATE FUNCTION [Restaurant].[fxArticulosDataButtons](@IdSucursal as int)
RETURNS @RetTable TABLE (	IdArticulo int, IdArticuloStock int, IdCategoria	int,Articulo varchar(64),Imagen	image,IdProducto int,Color varchar(32),
							IdDivisa int,Precio	decimal(19,4),IdImpuesto1 int,IdImpuesto2 int,IdImpuesto3 int,
							PorImpto1 decimal(19,4),PorImpto2 decimal(19,4),PorImpto3 decimal(19,4),PrecioNeto decimal(19,4) )
AS
BEGIN

	INSERT INTO @RetTable
		SELECT  IdArticulo,A.IdArticuloStock,IdCategoria,AX.Nombre AS Articulo,A.Imagen,isNull(P.IdProducto,0)AS IdProducto,A.Color,
				AZ.IdDivisa,AZ.Precio,IsNull(AZ.IdImpuesto1,0)AS IdImpuesto1,IsNull(AZ.IdImpuesto2,0)AS IdImpuesto2,IsNull(AZ.IdImpuesto3,0)AS IdImpuesto3,
			    	IsNull(I1.Porcentaje,0) AS PorImpto1,IsNull(I2.Porcentaje,0) AS PorImpto2,IsNull(I3.Porcentaje,0) AS PorImpto3,AZ.Precio
		FROM Restaurant.Articulos A 
		INNER JOIN Inventory.ArticulosStock AX ON AX.IdArticuloStock=A.IdArticuloStock
		LEFT JOIN Production.Productos P ON P.IdArticuloStock=AX.IdArticuloStock
		INNER JOIN Sales.UnidadesNegocio UN ON UN.IdSucursal=A.IdSucursal
		INNER JOIN Sales.ArticulosZonasVenta AZ ON AZ.IdArticuloStock=AX.IdArticuloStock AND AZ.IdZonaVenta=UN.IdZonaVenta
		LEFT JOIN Accounting.Impuestos I1 ON I1.IdImpuesto=AZ.IdImpuesto1
		LEFT JOIN Accounting.Impuestos I2 ON I1.IdImpuesto=AZ.IdImpuesto2
		LEFT JOIN Accounting.Impuestos I3 ON I1.IdImpuesto=AZ.IdImpuesto3
		WHERE A.IdSucursal=@IdSucursal

	----Actualizamos los descuentos en caso de que se lleguen a utilizar
	--DECLARE @MontoDescuento1 Decimal(19,4),@MontoDescuento2 Decimal(19,4),@MontoDescuento3 Decimal(19,4),@MontoDescuento4 Decimal(19,4),@MontoDescuento5 Decimal(19,4)
	--SELECT @MontoDescuento1=round(PorcDescuento1 * @Precio,2), 
	--@MontoDescuento2=round(PorcDescuento2 * @Precio,2), @MontoDescuento3=round(PorcDescuento3 * @Precio,2), 
	--@MontoDescuento4=round(PorcDescuento4 * @Precio,2), @MontoDescuento5=round(PorcDescuento5 * @Precio,2)
	--FROM Sales.GruposDescuentoArticulos WITH (READUNCOMMITTED)
	--WHERE IdGrupoDescuento=@IdGrupoDescuentos AND IdArticulo=@IdArticuloStock
	---->Recalculo de Monto de descuento 2 (descuento adicional) ya que el descuento no es sobre la base
	--SET @MontoDescuento2 = round((@Precio - @MontoDescuento1) * @PorcDescuento2, 2)
	--SET @MontoDescuento3 = round((@Precio - @MontoDescuento1 - @MontoDescuento2) * @PorcDescuento3, 2)
	---->Obtener el precio con los descuentos aplicados
	--DECLARE @PrecioDesc AS decimal(19,6)
	--SET PrecioNeto=@Precio - @MontoDescuento1 - @MontoDescuento2 - @MontoDescuento3 - @MontoDescuento4 - @MontoDescuento5 

	
	/*Obtener los montos de los impuestos y se los aplicamos al precio neto*/
	UPDATE @RetTable SET PrecioNeto = PrecioNeto+round(PrecioNeto * IsNull(PorImpto1,0), 2)
	UPDATE @RetTable SET PrecioNeto = PrecioNeto+round(PrecioNeto * IsNull(PorImpto2,0), 2)
	UPDATE @RetTable SET PrecioNeto = PrecioNeto+round(PrecioNeto * IsNull(PorImpto3,0), 2)
	
	RETURN
END


