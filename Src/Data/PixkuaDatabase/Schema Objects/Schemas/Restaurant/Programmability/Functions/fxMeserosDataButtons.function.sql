CREATE FUNCTION [Restaurant].[fxMeserosDataButtons](@IdSucursal AS INT)
RETURNS TABLE
AS
	RETURN(
			SELECT M.IdMesero,M.NombreCorto,Fotografia,U.Usuario,U.[Password]
			FROM Restaurant.Meseros M
			INNER JOIN Usuarios U ON U.IdUsuario=M.IdUsuario
			WHERE M.IdSucursal=@IdSucursal
)


