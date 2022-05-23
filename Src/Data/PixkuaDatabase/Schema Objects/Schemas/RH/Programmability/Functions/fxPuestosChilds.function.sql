-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Obtiene una lista de los nodos que dependen del nodo especificado
-- =============================================
CREATE FUNCTION [RH].[fxPuestosChilds](@IdEmpresa as int, @IdPadre AS int)
RETURNS TABLE
AS
RETURN (
	SELECT IdPuesto AS [Identity], Codigo, Nombre, IdPadre, Orden, Nivel, [Path], IsLeaf
	FROM RH.Puestos
	WHERE IdEmpresa=@IdEmpresa AND IdPadre=@IdPadre AND IdStatus=1
		)


