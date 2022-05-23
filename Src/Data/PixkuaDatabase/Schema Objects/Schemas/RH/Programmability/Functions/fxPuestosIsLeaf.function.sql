-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Verifica si el nodo especificado se refiere a uno de nivel inferior
-- =============================================

CREATE FUNCTION [RH].[fxPuestosIsLeaf](@Id AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit
	DECLARE @Cant AS int

	SELECT @Cant=Count(IdPuesto)
	FROM RH.Puestos
	WHERE IdPadre=@Id

	IF @Cant > 0
		SET @Result=0
	ELSE
		SET @Result=1

	RETURN @Result
END


