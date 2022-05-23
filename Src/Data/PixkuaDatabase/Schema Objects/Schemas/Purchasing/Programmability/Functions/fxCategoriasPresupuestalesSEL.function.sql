-- =============================================
-- Author: alez lopez
-- Create date: 19-oct-2011
-- Description:	Obtiene la información del CategoriasPresupuestales especificado.
-- =============================================
CREATE FUNCTION [Purchasing].[fxCategoriasPresupuestalesSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Purchasing.CategoriasPresupuestales WHERE IdCategoriaPresupuestal=@ID)


