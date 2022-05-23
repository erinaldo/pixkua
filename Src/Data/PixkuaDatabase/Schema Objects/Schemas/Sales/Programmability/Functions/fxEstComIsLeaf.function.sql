-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Verifica si el nodo especificado se refiere a uno de nivel inferior
-- =============================================

CREATE FUNCTION [Sales].[fxEstComIsLeaf](@Id AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit
	DECLARE @Cant AS int

	SELECT @Cant=Count(IdEstCom)
	FROM Sales.EstCom
	WHERE IdPadre=@Id

	IF @Cant > 0
		SET @Result=0
	ELSE
		SET @Result=1

	RETURN @Result
END


