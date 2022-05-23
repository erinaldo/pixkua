-- =============================================
-- Author: alez lopez
-- Create date: 19-oct-2011
-- Description:	Verifica la existencia de CategoriasPresupuestales
-- =============================================
CREATE FUNCTION [Purchasing].[fxCategoriasPresupuestalesExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdCategoriaPresupuestal FROM Purchasing.CategoriasPresupuestales WHERE IdCategoriaPresupuestal=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


