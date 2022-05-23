CREATE FUNCTION [Sales].[fxClienteContactosSEL](@IdCliente as int)
RETURNS TABLE
AS
RETURN	(
	SELECT P.IdPersona, P.Nombre, P.ApellidoP + ' ' + P.ApellidoM AS Apellidos, 
		P.TelOficina AS Telefono, P.Celular, P.Correo
	FROM Sales.ClientesContactos CC JOIN dbo.Personas P
		ON CC.IdPersona=P.IdPersona
	WHERE CC.IdCliente=@IdCliente
		)


