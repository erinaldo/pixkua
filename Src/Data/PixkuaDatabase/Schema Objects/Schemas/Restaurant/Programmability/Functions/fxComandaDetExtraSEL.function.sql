CREATE FUNCTION [Restaurant].[fxComandaDetExtraSEL](@IdComandaTit as varchar(18))
RETURNS Table
AS
	RETURN(	SELECT E.*,I.Nombre AS Insumo
			FROM Restaurant.ComandaDetExtras E
			INNER JOIN Production.Insumos I ON I.IdInsumo=E.IdInsumo
			WHERE E.IdComandaTit=@IdComandaTit AND E.Fecha=Documents.fxDocumentDate(@IdComandaTit)
)


