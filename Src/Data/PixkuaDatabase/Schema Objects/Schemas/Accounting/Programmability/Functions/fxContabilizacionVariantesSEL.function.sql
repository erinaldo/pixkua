CREATE FUNCTION [Accounting].[fxContabilizacionVariantesSEL](@IdVistaContableTit AS INT,@IdContabilizacionDocumentoDet AS INT)
RETURNS TABLE
AS
	RETURN(	SELECT VCE.Columna,VCE.IdEntidad,E.Entidad,IsNull(CC.IdContabilizacionCombinacion,0)AS IdContabilizacionCombinacion,
			CAST((CASE WHEN IsNull(CC.IdContabilizacionCombinacion,0) >0 THEN 1 ELSE 0 END)AS BIT) AS Sel
			FROM Accounting.VistasContablesEntidad VCE
			INNER JOIN Accounting.Entidades AS E ON E.IdEntidad=VCE.IdEntidad
			LEFT JOIN Accounting.ContabilizacionCombinaciones CC ON CC.IdEntidad=VCE.IdEntidad AND CC.IdContabilizacionDocumentoDet=@IdContabilizacionDocumentoDet
			WHERE VCE.IdVistaContableTit=@IdVistaContableTit 
)


