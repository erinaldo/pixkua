CREATE FUNCTION [Purchasing].[fxDepartamentosAccesosSEL](@IdDepartamento int)
RETURNS TABLE
AS
RETURN(	SELECT A.IdUsuario,Usuario,P.Nombre + ' ' + P.ApellidoP + ' ' +P.ApellidoM AS Nombre
		FROM Purchasing.DepartamentosAccesos A
		INNER JOIN Usuarios U ON U.IdUsuario = A.IdUsuario
		INNER JOIN Personas P ON P.IdPersona=U.IdPersona
		WHERE IdDepartamento=@IdDepartamento
)


