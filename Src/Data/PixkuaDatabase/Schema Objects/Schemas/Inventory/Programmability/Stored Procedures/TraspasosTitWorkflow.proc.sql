-- =============================================
-- Author: RCO
-- Create date: 26-jun-2011
-- Description:	Aplica el proceso de flujo de trabajo del TraspasosTit especificado.
-- =============================================
CREATE PROCEDURE [Inventory].[TraspasosTitWorkflow]
	@ID AS Char(18),
	@IdStatus as int,
	@FechaTrabajo as datetime,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	SET DATEFORMAT dmy
	
	DECLARE @Fecha as Datetime, @Hora as Datetime, @FechaDocumento as datetime, @IdStatusAct as int,
		@HoraMovto as datetime, @HoraApartado as datetime, @HoraCarga as datetime, @HoraAplicado as datetime,
		@TotalCantidad as decimal(19,4), @TotalFlete as decimal(19,4), @TotalCosto as decimal(19,4),
		@IdCorte as uniqueidentifier, @IdAlmacenOrigen as int

	SELECT @Fecha=CONVERT(varchar(10), getdate(), 112), @Hora=getdate(), 
		@FechaDocumento=Documents.fxDocumentDate(@ID)	
		   		   
	--Obtenemos los datos originales de la Traspaso
	SELECT @IdStatusAct=IdStatus, @HoraApartado=HoraApartado, @HoraAplicado=HoraAplicado, 
		@HoraCarga=HoraCarga, @HoraMovto=HoraMovto, @IdCorte=IdCorte,
		@IdAlmacenOrigen=IdAlmacenOrigen
	FROM Inventory.TraspasosTit 
	WHERE IdTraspasoTit=@ID AND Fecha=@FechaDocumento

	--Calcular totales
	SELECT @TotalCantidad=Sum(D.CantidadEnviada), @TotalFlete=SUM(D.Flete), @TotalCosto=SUM(D.CostoUnitario * D.CantidadEnviada)
	FROM Inventory.TraspasosDet D
	WHERE D.IdTraspasoTit=@ID AND D.Fecha=@FechaDocumento	
		
	IF @IdStatusAct=1 AND @IdStatus=3
	BEGIN
		SELECT @HoraMovto=@Hora, @HoraAplicado=@Hora
		
		SELECT @IdCorte=IdCorteActual
		FROM Inventory.Areas AR JOIN Inventory.Almacenes AL
			ON AR.IdArea=AL.IdArea
		WHERE AL.IdAlmacen=@IdAlmacenOrigen		
	END
	
	IF (@IdStatusAct=7 OR @IdStatusAct=8) AND @IdStatus=3
		SELECT @HoraAplicado=@Hora
	IF @IdStatus=7
		SELECT @HoraApartado=@Hora
	IF @IdStatus=8
	BEGIN
		SELECT @HoraMovto=@Hora, @HoraCarga=@Hora

		SELECT @IdCorte=IdCorteActual
		FROM Inventory.Areas AR JOIN Inventory.Almacenes AL
			ON AR.IdArea=AL.IdArea
		WHERE AL.IdAlmacen=@IdAlmacenOrigen				
	END
		

	UPDATE Inventory.TraspasosTit 
	SET HoraMovto=@Hora, HoraAplicado=@Hora, HoraApartado=@HoraApartado, HoraCarga=@HoraCarga,
		TotalCantidad=@TotalCantidad, TotalFlete=@TotalFlete, TotalCosto=@TotalCosto, IdCorte=@IdCorte,
		IdStatus=@IdStatus, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=@Hora
	WHERE IdTraspasoTit=@ID AND Fecha=@FechaDocumento


