CREATE FUNCTION [Restaurant].[fxMesaDataButtons](@IdCentroConsumo as integer)
RETURNS TABLE 
AS
	RETURN(SELECT M.IdMesa,Descripcion,M.IdComandaTit,IsNull(CT.IdStatus,0) AS IdStatus
			FROM Restaurant.Mesas M
			LEFT JOIN Restaurant.ComandaTit CT ON CT.IdComandaTit=M.IdComandaTit AND CT.Fecha=Documents.fxDocumentDate(M.IdComandaTit)
			WHERE M.IdCentroConsumo=@IdCentroConsumo
)


