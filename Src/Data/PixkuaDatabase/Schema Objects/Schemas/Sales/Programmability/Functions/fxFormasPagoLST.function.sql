-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Obtiene una lista de búsqueda de FormasPago
-- =============================================
CREATE FUNCTION [Sales].[fxFormasPagoLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdFormaPago, Nombre, Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Sales.FormasPago	
	)


