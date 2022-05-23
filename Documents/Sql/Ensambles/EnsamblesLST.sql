-- =============================================
-- Author: Victor Moreno
-- Create date: 16-nov-2016
-- Description:	Obtiene una lista de b�squeda de Ensambles
-- =============================================
CREATE FUNCTION Production.fxEnsamblesLST(@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT IdEnsamble
	FROM Production.Ensambles
	WHERE IdSucursal=@IdSucursal)