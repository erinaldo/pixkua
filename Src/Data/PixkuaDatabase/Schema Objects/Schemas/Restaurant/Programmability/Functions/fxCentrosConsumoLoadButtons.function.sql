CREATE FUNCTION [Restaurant].[fxCentrosConsumoLoadButtons](@IdMesero as integer)
RETURNS TABLE 
AS
	RETURN(SELECT IdCentroConsumo,CC.Nombre,Null as imagen, I.Ruta AS Impresora
			FROM Restaurant.CentrosConsumo CC
			INNER JOIN Sales.Cajas C ON C.IdCaja=CC.IdCaja
			INNER JOIN Impresoras I ON I.IdImpresora=C.IdImpresora
			--Incluir el filtro pa que el mesero solo vea las zonas a las q tiene acceso
)


