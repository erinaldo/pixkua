-- =============================================
-- Author: RCO
-- Create date: 02-dic-2011
-- Description:	Obtiene una lista de búsqueda de OrdenesTit
-- =============================================
CREATE FUNCTION [Purchasing].[fxOrdenesTitLST](@IdUsuario AS char(18), @IdSucursal AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.IdOrdenTit, T.Fecha, P.Nombre AS Proveedor, P.RFC, T.FechaEntrega AS [FechaEntrega],
		D.NamedPath AS Departamento, CR.Nombre AS [Centro Recepcion], IsNull(PE.Nombre, 'N/A') AS Periodo,
		S.[StatusApplied] AS Estatus
	FROM Purchasing.OrdenesTit T JOIN Documents.[Status] S
		ON T.IdStatus=S.IdStatus
	JOIN Purchasing.Proveedores P
		ON T.IdProveedor=P.IdProveedor
	JOIN RH.Departamentos D
		ON T.IdDepartamento=D.IdDepartamento
	JOIN Purchasing.CentrosRecepcion CR
		ON T.IdCentroRecepcion=CR.IdCentroRecepcion
	LEFT JOIN Purchasing.Presupuestos PR
		ON T.IdPresupuesto=PR.IdPresupuesto
	LEFT JOIN Purchasing.Periodos PE
		ON PR.IdPeriodo=PE.IdPeriodo
	WHERE T.IdSucursal=@IdSucursal
		)


