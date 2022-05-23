-- =============================================
-- Author: Victor Moreno
-- Create date: 01-dic-2016
-- Description:	Elimina el OrdenesTrabajo especificado.
-- =============================================
CREATE PROCEDURE Production.OrdenesTrabajoDEL
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Production.OrdenesTrabajo WHERE IdOrdenTrabajo=@ID