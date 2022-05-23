CREATE FUNCTION [Restaurant].[fxComandaCuentasLST]( @IdCaja as integer)
RETURNS TABLE
AS
RETURN(	SELECT M.IdComandaTit,CC.Nombre AS CentroConsumo, M.Descripcion AS Mesa,Mes.NombreCorto AS Mesero,CT.Observaciones
		FROM Restaurant.Mesas M
		INNER JOIN Restaurant.CentrosConsumo CC ON CC.IdCentroConsumo=M.IdCentroConsumo
		INNER JOIN Restaurant.ComandaTit CT ON CT.IdComandaTit=M.IdComandaTit AND CT.Fecha=Documents.fxDocumentDate(M.IdComandaTit)
		INNER JOIN Restaurant.Meseros Mes ON Mes.IdMesero=CT.IdMesero
		WHERE CC.IdCaja=@IdCaja AND CT.IdStatus=9
)


