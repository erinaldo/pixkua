-- =============================================
-- Author: alez lopez
-- Create date: 04-mar-2011
-- Description:	Obtiene una lista de búsqueda de Insumos
-- =============================================
CREATE FUNCTION [Production].[fxInsumosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT I.IdInsumo, I.Nombre,MT.Nombre AS [Tipo Medida], C.Codigo as Cuenta,C.Nombre AS Concepto,
		CASE I.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
 	FROM Production.Insumos AS I
 	INNER JOIN Inventory.UnidadesMedidaTipos MT ON MT.IdUnidadMedidaTipo=I.IdUnidadMedidaTipo
 	LEFT JOIN Accounting.Cuentas C ON C.IdCuenta=I.IdCuenta
	WHERE I.IdSucursal=@IdSucursal
	)


