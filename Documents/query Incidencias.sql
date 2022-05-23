
/*******Eliminacion de Movimientos Tit******************/
DECLARE @IdMovimientoTit AS VARCHAR(18)
DECLARE cTran CURSOR FOR 
	select t.IdMovimientoTit
	from inventory.movimientosTit t

	OPEN cTran
	FETCH NEXT FROM cTran INTO @IdMovimientoTit

	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		exec [Inventory].[MovimientosTitDEL] @IdMovimientoTit

		FETCH NEXT FROM cTran INTO @IdMovimientoTit
	END
CLOSE cTran
DEALLOCATE cTran

/*******Eliminacion de Movimientos Tit******************/
DECLARE @IdOrdenTit AS VARCHAR(18)
DECLARE cTran CURSOR FOR 
	select t.IdOrdenTit
	from purchasing.OrdenesTit t

	OPEN cTran
	FETCH NEXT FROM cTran INTO @IdOrdenTit

	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		exec [Purchasing].[OrdenesTitDEL] @IdOrdenTit

		FETCH NEXT FROM cTran INTO @IdOrdenTit
	END
CLOSE cTran
DEALLOCATE cTran

/*******Eliminacion de Requsiciones******************/
DECLARE @IdRequisicionTit AS VARCHAR(18)
DECLARE cTran CURSOR FOR 
	select t.IdRequisicion
	from purchasing.Requisiciones t

	OPEN cTran
	FETCH NEXT FROM cTran INTO @IdRequisicionTit

	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		exec [Purchasing].[RequisicionesDEL] @IdRequisicionTit

		FETCH NEXT FROM cTran INTO @IdRequisicionTit
	END
CLOSE cTran
DEALLOCATE cTran