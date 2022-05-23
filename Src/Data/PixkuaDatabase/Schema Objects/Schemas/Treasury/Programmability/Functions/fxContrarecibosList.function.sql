CREATE FUNCTION [Treasury].[fxContrarecibosList](@FechaIni AS Datetime,@FechaFin AS DateTime,@IdCaja AS int)
RETURNS TABLE
AS
RETURN(
		SELECT CAST(0 AS BIT)AS Sel, B.RazonSocial AS Beneficiario,T.IdContrareciboTit AS ID,Fecha,ReferenciaAlf,IdDocumento,FechaDocumento,FechaPago,Total,S.StatusApplied AS Estatus,T.IdStatus
		FROM Treasury.ContrarecibosTit T
		INNER JOIN Treasury.Beneficiarios AS B ON B.IdBeneficiario=t.IdBeneficiario
		INNER JOIN Documents.Status S ON S.IdStatus=T.IdStatus
		WHERE T.IdCaja=@IdCaja AND Fecha BETWEEN DATEADD(D,-5,@FechaINI) AND @FechaFin
)


