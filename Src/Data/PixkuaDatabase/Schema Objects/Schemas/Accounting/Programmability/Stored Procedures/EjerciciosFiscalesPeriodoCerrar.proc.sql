CREATE PROCEDURE [Accounting].[EjerciciosFiscalesPeriodoCerrar]
@IdEjercicioFiscalTit AS char(18),
@Mes as int
AS
	UPDATE Accounting.EjerciciosFiscalesDet SET Activo=0 
	WHERE IdEjercicioFiscalTit=@IdEjercicioFiscalTit AND Mes=@Mes


