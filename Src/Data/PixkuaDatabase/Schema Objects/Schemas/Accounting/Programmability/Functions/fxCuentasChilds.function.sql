-- =============================================
-- Author: Alejandro Lopez Cadena
-- Create date: 20-sep-2007
-- Description:	Obtiene una lista de los nodos que dependen del nodo especificado
-- =============================================
CREATE FUNCTION [Accounting].[fxCuentasChilds](@IdEmpresa as int, @IdPadre AS int)
RETURNS TABLE
AS
RETURN (
	SELECT IdCuenta AS [Identity], Codigo,Codigo + ' - ' +  Nombre as Nombre, IdPadre, Orden, Nivel, [Path], IsLeaf
	FROM Accounting.Cuentas
	WHERE IdEmpresa=@IdEmpresa AND IdPadre=@IdPadre AND IdStatus=1
		)


