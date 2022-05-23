CREATE FUNCTION [Purchasing].[fxProveedoresCBO](@IdEmpresa as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdProveedor, Codigo, Nombre, RFC, RazonSocial, Correo, PagWeb
	FROM Purchasing.Proveedores
	WHERE IdStatus=1 AND IdEmpresa=@IdEmpresa
		)


