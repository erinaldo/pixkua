-- =============================================
-- Author: alez lopez
-- Create date: 29-ago-2011
-- Description:	Obtiene una lista de búsqueda de Vendedores
-- =============================================
CREATE FUNCTION [Sales].[fxVendedoresLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdVendedor, P.Nombre, P.ApellidoP + ' ' + P.ApellidoM AS Apellidos,
		CASE V.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Sales.Vendedores V
	INNER JOIN RH.Empleados E ON E.IdEmpleado=V.IdEmpleado
	INNER JOIN dbo.Personas P	ON E.IdPersona=P.IdPersona	
	WHERE V.IdSucursal=@IdSucursal
	)


