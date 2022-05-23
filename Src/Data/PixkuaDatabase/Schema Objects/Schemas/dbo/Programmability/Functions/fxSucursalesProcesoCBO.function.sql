CREATE FUNCTION [dbo].[fxSucursalesProcesoCBO](@IdEmpresa as int, @IdUsuario AS int, @IdProceso AS int)
RETURNS TABLE
AS
	RETURN
	(
		SELECT S.IdSucursal, S.IdEmpresa, S.Nombre
		FROM Sucursales S 
		JOIN dbo.fxProcesosAccesos(@IdUsuario) AP
			ON AP.IdSucursal=S.IdSucursal
		WHERE S.IdStatus=1 AND AP.IdProceso=@IdProceso AND S.IdEmpresa=@IdEmpresa
	
	)


