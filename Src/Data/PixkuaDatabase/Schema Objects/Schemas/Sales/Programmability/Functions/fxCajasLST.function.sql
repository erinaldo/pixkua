-- =============================================
-- Author: alez Lopez
-- Create date: 30-jun-2011
-- Description:	Obtiene una lista de búsqueda de Cajas
-- =============================================
CREATE FUNCTION [Sales].[fxCajasLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT C.IdCaja,C.Nombre,Cta.Codigo AS Cuenta,I.Nombre + '[' + I.Ruta +']' AS Impresora,
		CASE C.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Sales.Cajas C
	LEFT JOIN Accounting.Cuentas Cta ON Cta.IdCuenta=C.IdCuenta
	LEFT JOIN Impresoras I ON I.IdImpresora=C.IdImpresora
	WHERE C.IdSucursal=@IdSucursal
	)


