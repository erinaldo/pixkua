CREATE PROCEDURE [Sales].[CorteCerrar]
@IdCorte as uniqueidentifier

AS

	DECLARE @FechaCierre as datetime, @HoraCierre as datetime, @IdArea as int
	SELECT @FechaCierre=CONVERT(varchar(10), GETDATE(), 112), @HoraCierre=GETDATE()
	
	DECLARE @IdCaja as integer
	
	-->Obtener el área a la que pertenece el corte
	SELECT @IdCaja=IdCaja
	FROM Sales.Cortes
	WHERE IdCorte=@IdCorte

	--Actualizar la caja para liberar su referencia al corte
	UPDATE Sales.Cajas SET IdCorteActual=dbo.fxEmptyId() WHERE IdCaja=@IdCaja	
	-->Actualizar fecha de cierre 
	UPDATE Sales.Cortes SET FechaCierre=@FechaCierre, HoraCierre=@HoraCierre WHERE IdCorte=@IdCorte


