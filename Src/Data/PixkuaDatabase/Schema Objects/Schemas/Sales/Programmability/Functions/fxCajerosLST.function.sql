-- =============================================
-- Author: RCO
-- Create date: 01-jul-2011
-- Description:	Obtiene una lista de búsqueda de Cajeros
-- =============================================
CREATE FUNCTION [Sales].[fxCajerosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT C.IdCajero, P.ApellidoP AS [Apellido Paterno], P.ApellidoM AS [Apellido Materno], P.Nombre, C.Codigo,
		CASE C.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Sales.Cajeros C JOIN RH.Empleados E
		ON C.IdEmpleado=E.IdEmpleado
	JOIN dbo.Personas P
		ON E.IdPersona=P.IdPersona
	WHERE C.IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	)


