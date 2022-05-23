-- =============================================
-- Author: alez Lopez
-- Create date: 28-oct-2011
-- Description:	Obtiene una lista de búsqueda de Departamentos
-- =============================================
CREATE FUNCTION [Purchasing].[fxDepartamentosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT D.IdDepartamento,Drh.Nombre AS Departamento,C.Nombre AS [Central de Compras],Cta.codigo AS Cuenta,Cta.Nombre as Concepto,
		CASE D.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Purchasing.Departamentos D
	INNER JOIN RH.Departamentos Drh ON Drh.IdDepartamento=D.IdDepartamento
	INNER JOIN Purchasing.Centrales C ON C.IdCentral=D.IdCentral
	LEFT  JOIN Accounting.Cuentas Cta on Cta.IdCuenta=D.IdCuenta
	WHERE D.IdSucursal=@IdSucursal
	)


