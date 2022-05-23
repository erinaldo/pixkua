CREATE FUNCTION [Restaurant].[fxComandaTicketPedimento](@IdComandaTit as varchar(18))
RETURNS TABLE
AS
RETURN(		SELECT	T.IdComandaTit,T.Fecha,Mes.NombreCorto AS Mesero,T.Observaciones AS ObservacionGral, M.Descripcion AS Mesa,D.IdCentroProduccion,CP.Nombre AS CentroProduccion,I.Ruta,
					AX.Descripcion AS Articulo,D.Observaciones, Cantidad , Entregado,PrecioUnitario,DE.Partida,Ins.Nombre AS Insumo
			FROM Restaurant.ComandaTit T			
			INNER JOIN Restaurant.ComandaDet D ON D.IdComandaTit=T.IdComandaTit AND D.Fecha=T.Fecha			
			INNER JOIN Restaurant.Meseros Mes ON Mes.IdMesero=T.IdMesero
			INNER JOIN Restaurant.Mesas M ON M.IdMesa=T.IdMesa
			INNER JOIN Restaurant.Articulos A ON A.IdArticulo=D.IdArticulo
			INNER JOIN Inventory.ArticulosStock AX ON AX.IdArticuloStock=A.IdArticuloStock
			INNER JOIN Restaurant.CentrosProduccion CP ON CP.IdCentroProduccion=D.IdCentroProduccion
			LEFT JOIN Impresoras I ON I.IdEmpresa=CP.IdImpresora
			LEFT JOIN Restaurant.ComandaDetExtras DE ON DE.IdComandaTit=D.IdComandaTit AND DE.IdArticulo=D.IdArticulo
			LEFT JOIN Production.Insumos Ins ON Ins.IdInsumo=DE.IdInsumo
			WHERE T.IdComandaTit=@IdComandaTit AND T.Fecha=Documents.fxDocumentDate(@IdComandaTit)
)


