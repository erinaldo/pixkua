CREATE FUNCTION [Treasury].[fxContrarecibosRPT](@FechaIni as DateTime,@FechaFin as DateTime,@Ids as Varchar(4000))
RETURNS TABLE
AS
RETURN(
	SELECT B.RazonSocial AS Beneficiario,T.IdContrareciboTit,Fecha,T.IdDocumento, B.DiasCredito,T.FechaPago,T.ReferenciaAlf,T.SubTotal,T.TotalImpuestosTras,T.TotalImpuestosRet,T.Total
	FROM Treasury.ContrarecibosTit T
	INNER JOIN Treasury.Beneficiarios AS B ON B.IdBeneficiario=T.IdBeneficiario
	WHERE T.Fecha BETWEEN @FechaINI AND @FechaFIN AND T.IdContrareciboTit IN (SELECT IdReturn FROM dbo.fxConvertIDsDoctosToTable(@Ids))
)


