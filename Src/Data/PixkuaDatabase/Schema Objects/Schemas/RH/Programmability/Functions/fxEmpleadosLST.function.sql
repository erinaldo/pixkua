-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Obtiene una lista de búsqueda de Empleados
-- =============================================
CREATE FUNCTION [RH].[fxEmpleadosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdEmpleado, P.Nombre, P.ApellidoP + ' ' + P.ApellidoM AS Apellidos, E.FechaIngreso,
		E.FechaBaja, E.RFC, E.CURP, E.NSS, E.Codigo,
		CASE E.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM RH.Empleados E JOIN dbo.Personas P
		ON E.IdPersona=P.IdPersona	
	WHERE E.IdSucursal=@IdSucursal
	)


