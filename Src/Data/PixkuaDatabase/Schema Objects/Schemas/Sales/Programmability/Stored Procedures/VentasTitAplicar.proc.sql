CREATE PROCEDURE [Sales].[VentasTitAplicar]
	@IdVentaTit as char(18),
	@IdSalida as char(18)
AS
	SET NOCOUNT ON
	
	DECLARE @Fecha as datetime
	SET @Fecha=Documents.fxDocumentDate(@IdVentaTit)	
	
	/*Actualizar estructura comercial de las partidas*/
	UPDATE Sales.VentasDet SET IdEstCom=S.IdEstCom
	FROM Sales.VentasDet D JOIN Sales.Servicios S
		ON D.IdServicio=S.IdServicio
	WHERE D.IdVentaTit=@IdVentaTit AND D.Fecha=@Fecha
		
	UPDATE Sales.VentasDet SET IdEstCom=A.IdEstCom
	FROM Sales.VentasDet D JOIN Inventory.ArticulosStock AX
		ON D.IdArticuloStock=AX.IdArticuloStock
	JOIN Sales.ArticulosPresentaciones AP
		ON D.IdArticuloStock=AP.IdArticuloStock
	JOIN Sales.Articulos A
		ON A.IdArticulo=AP.IdArticulo
	WHERE D.IdVentaTit=@IdVentaTit AND D.Fecha=@Fecha
	
	
	/*Obtener fecha de pago*/
	DECLARE @FechaPago as datetime
	SET @FechaPago=Convert(varchar(10), getdate(), 112)
	
	-->Cargar información de la venta
	DECLARE @IdCaja as int
	
	SELECT @IdCaja=IdCaja
	FROM Sales.VentasTit
	WHERE IdVentaTit=@IdVentaTit AND Fecha=@Fecha
	
	-->Obtenemos el corte actual
	DECLARE @IdCorte as uniqueidentifier
	
	SELECT @IdCorte=IdCorteActual
	FROM Sales.Cajas 		
	WHERE IdCaja=@IdCaja
	
	-->Obtenemos la terminal de la caja
	DECLARE @IdTerminal as int
	
	SELECT @IdTerminal=IdTerminal
	FROM Sales.Terminales
	WHERE IdCaja=@IdCaja

	/*Actualizar información de la venta*/	
	UPDATE Sales.VentasTit 
	SET IdSalida=@IdSalida, IdCorte=@IdCorte, IdTerminal=ISNULL(@IdTerminal, 0),
		FechaPago=@FechaPago
	WHERE IdVentaTit=@IdVentaTit AND Fecha=@Fecha


