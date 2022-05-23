-- =============================================
-- Author: RCO
-- ALTER  date: 11-nov-2010
-- Description:	Obtiene el ID de ConceptosClasificaciones en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Inventory].[fxConceptosClasificacionesID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdConceptoClasificacion
	FROM Inventory.ConceptosClasificaciones
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


