-- =============================================
-- Author: RCO
-- Create date: 11-nov-2010
-- Description:	Verifica la existencia de ConceptosClasificaciones
-- =============================================
CREATE FUNCTION [Inventory].[fxConceptosClasificacionesExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdConceptoClasificacion FROM Inventory.ConceptosClasificaciones WHERE IdConceptoClasificacion=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


