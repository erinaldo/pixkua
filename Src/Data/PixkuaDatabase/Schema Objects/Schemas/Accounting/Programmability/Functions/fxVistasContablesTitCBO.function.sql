CREATE FUNCTION [Accounting].[fxVistasContablesTitCBO](@IdDocumentoTipo as int)
RETURNS TABLE
AS
	RETURN(
			SELECT IdVistaContableTit AS Id,Descripcion, IdDocumentoTipo  
			FROM Accounting.VistasContablesTit
			WHERE IdDocumentoTipo=@IdDocumentoTipo OR @IdDocumentoTipo=0
			)


