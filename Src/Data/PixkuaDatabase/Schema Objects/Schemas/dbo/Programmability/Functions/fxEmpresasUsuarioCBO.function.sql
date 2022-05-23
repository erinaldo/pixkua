CREATE  FUNCTION [dbo].[fxEmpresasUsuarioCBO](@IdUsuario AS int)
RETURNS TABLE
AS
	RETURN 
	(
		SELECT DISTINCT E.IdEmpresa, E.Nombre
		FROM Empresas E JOIN Sucursales S
			ON E.IdEmpresa=S.IdEmpresa
		JOIN UsuariosSucursales US ON S.IdSucursal=US.IdSucursal
		WHERE E.IdStatus=1 AND US.IdUsuario=@IdUsuario
	)


