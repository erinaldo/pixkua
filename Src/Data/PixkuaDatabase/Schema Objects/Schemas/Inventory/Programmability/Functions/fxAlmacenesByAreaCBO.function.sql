CREATE FUNCTION [Inventory].[fxAlmacenesByAreaCBO](@IdArea as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdAlmacen, Codigo, Nombre, ReqCapturaFisico
	FROM Inventory.Almacenes
	WHERE IdStatus=1 AND IdArea=@IdArea
		)


