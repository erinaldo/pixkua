CREATE FUNCTION [dbo].[fxPoliticasDefault](@IdProceso as int)
RETURNS TABLE
AS
RETURN	(	
	SELECT P.*, PF.Forma, Cast(P.IdPolitica AS varchar(16)) AS Codigo, 
		PF.[Namespace] + '.' + PF.Clase AS ClaseForma 
	FROM dbo.Politicas P JOIN dbo.ProcesosFormas PF
		ON P.IdProcesoForma=PF.IdProcesoForma
	WHERE P.Comportamiento='T' AND P.IdStatus=1	
		)


