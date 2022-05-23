CREATE PROCEDURE [Accounting].[EjerciciosFiscalesPeriodoAbrir]
@IdEjercicioFiscalTit AS char(18),
@Mes as int
AS
	UPDATE Accounting.EjerciciosFiscalesDet SET Activo=1 
	WHERE IdEjercicioFiscalTit=@IdEjercicioFiscalTit AND Mes=@Mes


