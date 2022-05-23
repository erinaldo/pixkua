-- =============================================
-- Author: RCO
-- ALTER  date: 05-oct-2010
-- Description:	Obtiene el ID de UnidadesMedida en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Inventory].[fxUnidadesMedidaID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdUnidadMedida
	FROM Inventory.UnidadesMedida
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


