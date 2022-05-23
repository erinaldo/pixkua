CREATE FUNCTION [dbo].[fxProcesoPoliticas](@IdProceso AS int)
RETURNS TABLE
AS
RETURN (
	SELECT P.*, Cast(P.IdPolitica AS varchar(16)) AS Codigo,
		PF.Forma, PF.Namespace + '.' + PF.Clase AS ClaseForma 
	FROM Politicas P JOIN ProcesosFormas PF 
		ON P.IdProcesoForma=PF.IdProcesoForma
	WHERE PF.IdProceso=@IdProceso
		)


