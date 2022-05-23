CREATE FUNCTION [dbo].[fxModulosTree]()
RETURNS TABLE
AS
RETURN
(
	SELECT IdModulo, IdParent, Modulo, Orden, Descr, ImageFile, IdModuloCategoria AS IdCategoria
	FROM Modulos
	WHERE IdStatus=1
)


