CREATE FUNCTION [Production].[fxInsumosArticulosSEL](@IdInsumo as int)
RETURNS TABLE	
AS
	RETURN(	SELECT IA.IdArticuloStock,IA.Predeterminado,AX.Nombre AS ArticuloStock
			FROM Production.InsumosArticulos AS IA
			INNER JOIN Inventory.ArticulosStock AX ON AX.IdArticuloStock=IA.IdArticuloStock
			WHERE IA.IdInsumo=@IdInsumo		
	)


