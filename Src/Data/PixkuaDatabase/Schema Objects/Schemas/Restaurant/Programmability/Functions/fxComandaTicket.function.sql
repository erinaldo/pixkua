CREATE FUNCTION [Restaurant].[fxComandaTicket](@IdComandaTit as varchar(18))
RETURNS TABLE
AS
	RETURN(	SELECT	T.IdComandaTit,T.Fecha,Mes.NombreCorto AS Mesero,M.Descripcion AS Mesa,--CP.Nombre AS CentroProduccion,
					AX.Descripcion AS Articulo,Cantidad, Entregado,PrecioUnitario
			FROM Restaurant.ComandaTit T
			INNER JOIN Restaurant.ComandaDet D ON D.IdComandaTit=T.IdComandaTit AND D.Fecha=T.Fecha
			INNER JOIN Restaurant.Meseros Mes ON Mes.IdMesero=T.IdMesero
			INNER JOIN Restaurant.Mesas M ON M.IdMesa=T.IdMesa
			INNER JOIN Restaurant.Articulos A ON A.IdArticulo=D.IdArticulo
			INNER JOIN Inventory.ArticulosStock AX ON AX.IdArticuloStock=A.IdArticuloStock
			--INNER JOIN Restaurant.CentrosProduccion CP ON CP.IdCentroProduccion=D.IdCentroProduccion
			WHERE T.IdComandaTit=@IdComandaTit AND T.Fecha=Documents.fxDocumentDate(@IdComandaTit)
)


