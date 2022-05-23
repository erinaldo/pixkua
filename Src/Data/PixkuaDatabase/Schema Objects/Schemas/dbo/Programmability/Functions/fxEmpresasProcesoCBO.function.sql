CREATE FUNCTION [dbo].[fxEmpresasProcesoCBO](@IdUsuario AS int, @IdProceso AS int)
RETURNS TABLE
AS
	RETURN
	(
		SELECT DISTINCT E.IdEmpresa, E.Nombre
		FROM Empresas E JOIN Sucursales S
			ON E.IdEmpresa=S.IdEmpresa
		JOIN dbo.fxProcesosAccesos(@IdUsuario) AP
			ON AP.IdSucursal=S.IdSucursal
		WHERE E.IdStatus=1 AND AP.IdProceso=@IdProceso
	)


