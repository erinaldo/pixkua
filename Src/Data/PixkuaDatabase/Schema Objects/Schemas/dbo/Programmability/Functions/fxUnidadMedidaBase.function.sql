CREATE FUNCTION [dbo].[fxUnidadMedidaBase](@IdUnidadMedidaTipo AS Int) 
RETURNS BIT
AS
BEGIN
	DECLARE @Base AS Int

	SELECT @Base = Base 
	FROM UnidadesMedida
	WHERE IdUnidadMedidaTipo=@IdUnidadMedidaTipo
	
	RETURN IsNull(@Base,0)
END


