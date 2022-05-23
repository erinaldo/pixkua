-- =============================================
-- Author: alex Lopez
-- Create date: 02-nov-2011
-- Description:	Obtiene una lista de búsqueda de Presupuestos
-- =============================================
CREATE FUNCTION [Purchasing].[fxPresupuestosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT P.IdPresupuesto,Per.Nombre AS Periodo,D.Nombre AS Departamento,
		CASE P.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Purchasing.Presupuestos P
	INNER JOIN Purchasing.Periodos Per ON Per.IdPeriodo=P.IdPeriodo
	INNER JOIN RH.Departamentos D ON D.IdDepartamento=P.IdDepartamento
	WHERE P.IdSucursal=@IdSucursal
	
	)


