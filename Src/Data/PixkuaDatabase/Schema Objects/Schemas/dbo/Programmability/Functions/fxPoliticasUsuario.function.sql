CREATE FUNCTION [dbo].[fxPoliticasUsuario]
	(@IdSucursal AS int, @IdProceso AS int, @IdUsuario AS int)
RETURNS TABLE
AS
RETURN
(
	SELECT P.*, Cast(P.IdPolitica AS varchar(16)) AS Codigo, 
		PF.Forma, PF.[Namespace] + '.' + PF.Clase AS ClaseForma 
	FROM dbo.Politicas P 
	JOIN dbo.AccesoPoliticas AP 
		ON P.IdPolitica=AP.IdPolitica
	JOIN dbo.ProcesosFormas PF
		ON P.IdProcesoForma=PF.IdProcesoForma
	WHERE AP.IdSucursal=@IdSucursal AND AP.IdUsuario=@IdUsuario
	AND PF.IdProceso=@IdProceso
	
	UNION
	
	SELECT P.*, PF.Forma, Cast(P.IdPolitica AS varchar(16)) AS Codigo, 
		PF.[Namespace] + '.' + PF.Clase AS ClaseForma 
	FROM dbo.Politicas P JOIN dbo.ProcesosFormas PF
		ON P.IdProcesoForma=PF.IdProcesoForma
	JOIN dbo.GruposPoliticas GP
		ON P.IdPolitica=GP.IdPolitica
	JOIN dbo.GruposUsr G 
		ON GP.IdGrupo=G.IdGrupo
	JOIN dbo.UsuariosGrupos 
		UG ON G.IdGrupo=UG.IdGrupo AND UG.IdUsuario=@IdUsuario
	WHERE PF.IdProceso=@IdProceso
	
)


