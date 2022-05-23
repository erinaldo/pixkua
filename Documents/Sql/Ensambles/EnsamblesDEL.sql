-- =============================================
-- Author: Victor Moreno
-- Create date: 16-nov-2016
-- Description:	Elimina el Ensambles especificado.
-- =============================================
CREATE PROCEDURE Production.EnsamblesDEL
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Production.Ensambles WHERE IdEnsamble=@ID