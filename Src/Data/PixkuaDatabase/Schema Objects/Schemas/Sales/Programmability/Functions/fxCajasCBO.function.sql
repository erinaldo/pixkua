CREATE FUNCTION [Sales].[fxCajasCBO](@IdSucursal AS INT)
RETURNS TABLE
AS
	RETURN(	
			SELECT IdCaja,Nombre
			FROM Sales.Cajas
			WHERE IdSucursal=@IdSucursal AND IdStatus=1
	)


