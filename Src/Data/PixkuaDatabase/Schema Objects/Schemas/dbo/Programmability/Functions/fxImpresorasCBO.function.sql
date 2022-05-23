CREATE FUNCTION [dbo].[fxImpresorasCBO](@IdSucursal as int)
RETURNS TABLE
AS	
RETURN	(
	SELECT IdImpresora, Codigo, Nombre, Ruta
	FROM dbo.Impresoras
	WHERE IdSucursal=@IdSucursal AND IdStatus=1
		)


