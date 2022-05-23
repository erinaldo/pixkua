CREATE FUNCTION [Accounting].[fxImportesCBO]()
RETURNS TABLE
AS	
	RETURN(SELECT IdImporte as Id, Descripcion as Descripcion FROM Accounting.Importes)


