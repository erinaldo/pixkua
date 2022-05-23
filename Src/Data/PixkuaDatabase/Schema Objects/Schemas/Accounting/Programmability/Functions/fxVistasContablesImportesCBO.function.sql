CREATE FUNCTION [Accounting].[fxVistasContablesImportesCBO](@IdVistaContableTit as int)
RETURNS Table
AS
RETURN(	SELECT VI.IdVistaContableImporte,VI.IdImporte,I.Descripcion AS Importe
		FROM Accounting.VistasContablesImporte VI 
		INNER JOIN Accounting.Importes I ON I.IdImporte=VI.IdImporte
		WHERE VI.IdVistaContableTit=@IdVistaContableTit
		)


