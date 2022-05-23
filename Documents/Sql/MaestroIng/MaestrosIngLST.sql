-- =============================================
-- Author: Victor Moreno
-- Create date: 23-nov-2016
-- Description:	Obtiene una lista de búsqueda de MaestrosIng
-- =============================================
CREATE FUNCTION Production.fxMaestrosIngLST(@IdUsuario AS char(18), @IdSucursal AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdMaestroIng, Fecha
	FROM Production.MaestrosIng 
	WHERE IdSucursal=@IdSucursal
		)