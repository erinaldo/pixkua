-- =============================================
-- Author: alez lopez
-- ALTER  date: 19-ene-2011
-- Description:	Obtiene el ID de CentrosProduccion en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Restaurant].[fxCentrosProduccionID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdCentroProduccion
	FROM Restaurant.CentrosProduccion
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


