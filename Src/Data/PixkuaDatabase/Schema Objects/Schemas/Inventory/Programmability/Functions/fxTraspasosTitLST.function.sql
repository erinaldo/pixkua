-- =============================================
-- Author: RCO
-- Create date: 26-jun-2011
-- Description:	Obtiene una lista de búsqueda de TraspasosTit
-- =============================================
CREATE FUNCTION [Inventory].[fxTraspasosTitLST](@IdUsuario AS char(18), @IdSucursal AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.IdTraspasoTit, T.Fecha, C.Nombre AS Concepto, AO.Nombre AS [Almacén Origen], AD.Nombre AS [Almacén Destino],
		T.IdTraspasoTit AS Folio, S.[StatusApplied] AS Estatus
	FROM Inventory.TraspasosTit T JOIN Documents.[Status] S
		ON T.IdStatus=S.IdStatus
	JOIN Inventory.Conceptos C
		ON T.IdConcepto=C.IdConcepto
	JOIN Inventory.Almacenes AO
		ON AO.IdAlmacen=T.IdAlmacenOrigen
	JOIN Inventory.Almacenes AD
		ON AD.IdAlmacen=T.IdAlmacenDestino
	WHERE T.IdSucursal=@IdSucursal
		)


