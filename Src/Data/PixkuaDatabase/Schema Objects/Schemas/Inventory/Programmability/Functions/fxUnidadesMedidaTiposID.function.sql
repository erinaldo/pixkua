-- =============================================
-- Author: RCO
-- ALTER  date: 05-oct-2010
-- Description:	Obtiene el ID de UnidadesMedidaTipos en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Inventory].[fxUnidadesMedidaTiposID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdUnidadMedidaTipo
	FROM Inventory.UnidadesMedidaTipos
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


