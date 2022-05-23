CREATE FUNCTION [Sales].[fxArticuloPresentacionExists](@IdArticuloStock as int)
RETURNS bit
AS
BEGIN
	DECLARE @Result as bit
	
	IF EXISTS( SELECT * FROM Sales.ArticulosPresentaciones WHERE IdArticuloStock=@IdArticuloStock)
		SET @Result=1
	ELSE
		SET @Result=0
		
	RETURN @Result
END


