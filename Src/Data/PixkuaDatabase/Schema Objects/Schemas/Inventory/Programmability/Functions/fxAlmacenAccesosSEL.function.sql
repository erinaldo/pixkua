CREATE FUNCTION [Inventory].[fxAlmacenAccesosSEL](@IdAlmacen as int)
RETURNS TABLE
AS
RETURN	(
	SELECT AU.IdUsuario, U.Usuario AS UserName, P.ApellidoP, P.ApellidoM, P.Nombre, AU.Entrada, AU.Salida
	FROM Inventory.AlmacenesUsuarios AU JOIN dbo.Usuarios U
		ON AU.IdUsuario=U.IdUsuario
	JOIN dbo.Personas P
		ON U.IdPersona=P.IdPersona
	WHERE IdAlmacen=@IdAlmacen
		)


