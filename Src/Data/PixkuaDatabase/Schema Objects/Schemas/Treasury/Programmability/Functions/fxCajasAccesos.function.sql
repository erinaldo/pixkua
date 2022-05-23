CREATE FUNCTION [Treasury].[fxCajasAccesos](@IdCaja as int)
RETURNS TABLE
AS
RETURN(
	SELECT A.IdUsuario,U.Usuario, P.Nombre+' '+P.ApellidoP+' '+P.ApellidoM AS Nombre
	FROM Treasury.CajasAccesos A
	INNER JOIN Usuarios U ON U.IdUsuario=A.IdUsuario
	INNER JOIN Personas P ON P.IdPersona=U.IdPersona
	WHERE A.IdCaja=@IdCaja
)


