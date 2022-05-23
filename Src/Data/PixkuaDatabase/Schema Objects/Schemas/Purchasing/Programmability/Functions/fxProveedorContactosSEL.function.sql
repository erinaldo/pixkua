CREATE FUNCTION [Purchasing].[fxProveedorContactosSEL](@IdProveedor as int)
RETURNS TABLE
AS
RETURN	(
	SELECT PC.IdPersona, P.Nombre, P.ApellidoP + ' ' + P.ApellidoM AS Apellidos,
		P.TelOficina AS Telefono, P.Celular, P.Correo
	FROM Purchasing.ProveedoresContactos PC JOIN dbo.Personas P
		ON PC.IdPersona=P.IdPersona
	WHERE PC.IdProveedor=@IdProveedor
		)


