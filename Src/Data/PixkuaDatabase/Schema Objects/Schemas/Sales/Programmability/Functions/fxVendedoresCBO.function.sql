CREATE FUNCTION [Sales].[fxVendedoresCBO](@IdSucursal as int)
RETURNS TABLE
AS
RETURN	(
	SELECT V.IdVendedor, V.Codigo, P.ApellidoP + ' ' + P.ApellidoM + ' ' + P.Nombre AS Nombre
	FROM Sales.Vendedores V JOIN RH.Empleados E
		ON V.IdEmpleado=E.IdEmpleado
	JOIN dbo.Personas P
		ON E.IdPersona=P.IdPersona
	WHERE V.IdStatus=1 AND V.IdSucursal=@IdSucursal
		)


