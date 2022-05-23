-- =============================================
-- Author: alez lopez
-- Create date: 19-oct-2011
-- Description:	Elimina el CategoriasPresupuestales especificado.
-- =============================================
CREATE PROCEDURE [Purchasing].[CategoriasPresupuestalesDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Purchasing.CategoriasPresupuestales SET IdStatus=0 WHERE IdCategoriaPresupuestal=@ID


