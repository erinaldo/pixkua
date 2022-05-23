CREATE PROCEDURE [Purchasing].[PresupuestoAfectar]
@IdPresupuesto as int,
@IdCategoriaPresupuestal as int,
@Monto as decimal(19,4),
@Apartar as bit,
@Origen as char(1),
@IdDocumento as char(18)
AS
	--En teoria no se debe validar q exista la categoria presupuestal ya q siempre debe existir
	
	--Validamos que el Presupuesto este abierto
	DECLARE @ErrorMessage nVarChar(4000),@Status char(1)
	SELECT @Status=Estatus FROM Purchasing.Presupuestos WHERE IdPresupuesto=@IdPresupuesto
	IF @Status='C'
	BEGIN
		SET @ErrorMessage=N'El Presupuesto seleccionado esta Cerrado'
		RAISERROR (@ErrorMessage,18,1)
		RETURN
	END
	
	
	--Variables
	DECLARE @MontoUtilizadoINI Decimal(19,4),@MontoApartadoINI Decimal(19,4),
			@MontoUtilizadoFIN Decimal(19,4),@MontoApartadoFIN Decimal(19,4),
			@FechaDocumento as datetime,@Hora as datetime,@Fecha as datetime
	
	SELECT  @MontoUtilizadoINI=0,@MontoApartadoINI=0,@MontoUtilizadoFIN=0,@MontoApartadoFIN=0
		
	--Obtenemos los saldos Iniciales		
	IF @IdCategoriaPresupuestal=0
		SELECT @MontoUtilizadoINI=MontoUtilizado, @MontoApartadoINI=MontoApartado
		FROM Purchasing.Presupuestos 
		WHERE IdPresupuesto=@IdPresupuesto 
	ELSE
	    SELECT @MontoUtilizadoINI=MontoUtilizado,@MontoApartadoINI =MontoApartado
		FROM Purchasing.PresupuestosCategorias
		WHERE IdPresupuesto=@IdPresupuesto AND IdCategoriaPresupuestal=@IdCategoriaPresupuestal
	
	
	-----------------------------------------CALCULAR Y AFECTAR EL PRESUPUESTO------------------------------------------------------------------
		
	--Afectar el Presupuesto de una Orden 
	IF @Origen='O' 
	BEGIN	
		--Calculamos
		SELECT @MontoApartadoFIN=@MontoApartadoINI  + (CASE WHEN @Apartar=1 THEN @Monto ELSE @Monto*-1 END) , --Si se aparta, se suma el monto, sino se esta utlizando y se resta
			  @MontoUtilizadoFIN=@MontoUtilizadoINI + (CASE WHEN @Apartar=1 THEN 0 ELSE @Monto END)
			  
		--Actualizamos
		IF  @IdCategoriaPresupuestal=0				--SIN Categoria Presupuestal	
			UPDATE Purchasing.Presupuestos
			SET MontoApartado =@MontoApartadoFIN,
				MontoUtilizado=@MontoUtilizadoFIN
			WHERE IdPresupuesto=@IdPresupuesto 		
		ELSE										--CON Categoria Presupuestal	
			UPDATE Purchasing.PresupuestosCategorias 
			SET MontoApartado =@MontoApartadoFIN,
				MontoUtilizado=@MontoUtilizadoFIN
			WHERE IdPresupuesto=@IdPresupuesto AND IdCategoriaPresupuestal=@IdCategoriaPresupuestal
 	END
			
			
	--Afectar el Presupuesto de un Gasto 
	IF @Origen='G' 
	BEGIN
		SELECT @MontoUtilizadoFIN=@MontoUtilizadoINI+@Monto
		
		IF  @IdCategoriaPresupuestal=0				--SIN Categoria Presupuestal	
			UPDATE Purchasing.Presupuestos
			SET MontoUtilizado=@MontoUtilizadoFIN
			WHERE IdPresupuesto=@IdPresupuesto 
		ELSE										--CON Categoria Presupuestal	
			UPDATE Purchasing.PresupuestosCategorias 
			SET MontoUtilizado=@MontoUtilizadoFIN
			WHERE IdPresupuesto=@IdPresupuesto AND IdCategoriaPresupuestal=@IdCategoriaPresupuestal
	END	
		

	------------------------------------------INSERTAMOS EN EL KARDEX LO QUE SE AFECTO------------------------------------
	
	SELECT @FechaDocumento=Documents.fxDocumentDate(@IdDocumento),@Hora=getdate()
	SET @Fecha=CONVERT(Varchar(10),@Hora,112)

	--Insertamos en el Kardex
	INSERT INTO Purchasing.Kardex (IdPresupuesto,IdCategoriaPresupuestal,IdDocumento,FechaDocumento, Fecha,Hora,Monto,MontoUtilizadoINI,MontoUtilizadoFIN,MontoApartadoINI,MontoApartadoFIN )
	VALUES	(@IdPresupuesto,@IdCategoriaPresupuestal,@IdDocumento,@FechaDocumento, @Fecha,@Hora,@Monto,@MontoUtilizadoINI,@MontoUtilizadoFIN,@MontoApartadoINI,@MontoApartadoFIN )


