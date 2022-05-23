-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Obtiene una lista de los nodos que dependen del nodo especificado
-- =============================================
CREATE FUNCTION [RH].[fxDepartamentosChilds](@IdEmpresa as int, @IdPadre AS int)
RETURNS TABLE
AS
RETURN (
	SELECT IdDepartamento AS [Identity], Codigo, Nombre, IdPadre, Orden, Nivel, [Path], IsLeaf
	FROM RH.Departamentos
	WHERE IdEmpresa=@IdEmpresa AND IdPadre=@IdPadre AND IdStatus=1
		)


