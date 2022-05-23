CREATE FUNCTION [Accounting].[fxVistasContablesEntidadesCBO](@IdVistaContableTit as int)
RETURNS Table
AS
RETURN(	SELECT VE.IdVistaContableEntidad,VE.IdEntidad,E.Entidad
		FROM Accounting.VistasContablesEntidad VE 
		INNER JOIN Accounting.Entidades E ON E.IdEntidad=VE.IdEntidad
		WHERE VE.IdVistaContableTit=@IdVistaContableTit
		)


