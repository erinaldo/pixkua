CREATE FUNCTION [Inventory].[fxUnidadMedidaBase](@IdUnidadMedidaTipo as int)
RETURNS int
AS
BEGIN
	DECLARE @Result as int
	
	SELECT @Result=IdUnidadMedida
	FROM Inventory.UnidadesMedida
	WHERE IdUnidadMedidaTipo=@IdUnidadMedidaTipo AND Base=1
	
	RETURN IsNull(@Result, 0)
END


