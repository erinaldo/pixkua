-- =============================================
-- Author: RCO
-- Create date: 15-oct-2010
-- Description:	Elimina el Marcas especificado.
-- =============================================
CREATE PROCEDURE [Sales].[MarcasDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Sales.Marcas WHERE IdMarca=@ID


