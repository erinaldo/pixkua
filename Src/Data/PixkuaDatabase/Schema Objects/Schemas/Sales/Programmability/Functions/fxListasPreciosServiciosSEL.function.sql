CREATE FUNCTION [Sales].[fxListasPreciosServiciosSEL](@IdListaPrecio as int)
RETURNS TABLE
AS
	RETURN(	SELECT S.IdServicio,IsNull(LPS.Precio,0)AS Precio,IsNull(LPS.IdDivisa,1)As IdDivisa,S.Codigo,S.Nombre As Servicio--,D.Nombre AS Divisa
			FROM Sales.Servicios S
			LEFT JOIN Sales.ListasPreciosServicios LPS ON LPS.IdServicio=S.IdServicio AND LPS.IdListaPrecio=@IdListaPrecio 
			LEFT JOIN Accounting.Divisas D ON D.IdDivisa=LPS.IdDivisa
			
)


