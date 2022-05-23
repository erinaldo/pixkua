-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Obtiene una lista de los nodos que dependen del nodo especificado
-- =============================================
CREATE FUNCTION [Sales].[fxEstComChilds](@IdEmpresa as int, @IdPadre AS int)
RETURNS TABLE
AS
RETURN (
	SELECT IdEstCom AS [Identity], Codigo, Nombre, IdPadre, Orden, Nivel, [Path], IsLeaf
	FROM Sales.EstCom
	WHERE IdPadre=@IdPadre AND IdStatus=1 AND IdEmpresa=@IdEmpresa
		)


