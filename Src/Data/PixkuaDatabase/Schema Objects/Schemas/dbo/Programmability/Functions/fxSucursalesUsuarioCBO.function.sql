CREATE FUNCTION [dbo].[fxSucursalesUsuarioCBO](@IdEmpresa as int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN 
	(
		SELECT S.IdSucursal, S.IdEmpresa, S.Nombre
		FROM Sucursales S JOIN UsuariosSucursales US
			ON S.IdSucursal=US.IdSucursal
		WHERE S.IdStatus=1 AND US.IdUsuario=@IdUsuario and (S.IdEmpresa=@IdEmpresa OR @IdEmpresa=0)
	)


