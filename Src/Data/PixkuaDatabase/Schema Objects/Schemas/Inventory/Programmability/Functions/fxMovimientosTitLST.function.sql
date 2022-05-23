-- =============================================
-- Author: RCO
-- Create date: 07-dic-2010
-- Description:	Obtiene una lista de búsqueda de MovimientosTit
-- =============================================
CREATE FUNCTION [Inventory].[fxMovimientosTitLST](@IdUsuario AS char(18), @IdSucursal AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.IdMovimientoTit, T.Fecha, A.Nombre AS Almacen, C.Nombre AS Concepto, T.HoraAplicado AS [Hora Aplicacion],
		CASE T.Direccion
			WHEN 1 THEN 'ENTRADA'
			WHEN -1 THEN 'SALIDA'
		END AS Direccion,
		T.IdMovimientoTit AS Folio, S.[StatusApplied] AS Estatus, T.TotalCantidad AS [Cantidad Total]
	FROM Inventory.MovimientosTit T JOIN Documents.[Status] S
		ON T.IdStatus=S.IdStatus
	JOIN Inventory.Almacenes A
		ON A.IdAlmacen=T.IdAlmacen
	JOIN Inventory.Conceptos C
		ON T.IdConcepto=C.IdConcepto
	WHERE T.IdSucursal=@IdSucursal AND T.Cancelacion=0
		)


