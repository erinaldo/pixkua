CREATE FUNCTION [Accounting].[fxEjerciciosFiscalesTitCBO](@IdEmpresa as int)
RETURNS TABLE
AS
	RETURN(
			SELECT IdEjercicioFiscalTit,YEAR(Fecha)AS Ejercicio,FechaIni,FechaFin,S.StatusApplied AS [Status]
			FROM Accounting.EjerciciosFiscalesTit T
			INNER JOIN Documents.Status  S ON S.IdStatus=T.IdStatus
			WHERE T.IdEmpresa=@IdEmpresa
	)


