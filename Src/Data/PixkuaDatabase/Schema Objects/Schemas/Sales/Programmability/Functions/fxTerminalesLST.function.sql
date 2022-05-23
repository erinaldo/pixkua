-- =============================================
-- Author: alez Lopez
-- Create date: 31-ago-2011
-- Description:	Obtiene una lista de búsqueda de Terminales
-- =============================================
CREATE FUNCTION [Sales].[fxTerminalesLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdTerminal,T.Nombre as Terminal,C.Nombre AS Caja,
		CASE T.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Sales.Terminales T
	INNER JOIN  Sales.Cajas C on C.IdCaja=T.IdCaja
	WHERE T.IdSucursal=@IdSucursal
	)


