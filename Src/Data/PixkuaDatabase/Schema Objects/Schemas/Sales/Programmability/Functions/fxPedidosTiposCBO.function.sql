CREATE FUNCTION [Sales].[fxPedidosTiposCBO](@IdEmpresa as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdPedidoTipo, Codigo, Nombre
	FROM Sales.PedidosTipos
	WHERE IdEmpresa=@IdEmpresa AND IdStatus=1
		)


