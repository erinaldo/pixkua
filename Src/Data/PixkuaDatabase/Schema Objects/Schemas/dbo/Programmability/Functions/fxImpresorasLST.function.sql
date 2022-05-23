-- =============================================
-- Author: RCO
-- Create date: 30-jun-2011
-- Description:	Obtiene una lista de búsqueda de Impresoras
-- =============================================
CREATE FUNCTION [dbo].[fxImpresorasLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdImpresora, Nombre, Codigo, Ruta,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM dbo.Impresoras
	WHERE IdSucursal=@IdSucursal
	)


