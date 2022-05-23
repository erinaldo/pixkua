-- =============================================
-- Author: Victor Moreno
-- Create date: 16-nov-2016
-- Description:	Obtiene la información del Ensambles especificado.
-- =============================================
CREATE FUNCTION Production.fxEnsamblesSEL(@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Production.Ensambles WHERE IdEnsamble=@ID)