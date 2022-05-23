CREATE FUNCTION [Purchasing].[fxRequisicionesTiposCBO](@IdUsuario as int)
RETURNS TABLE
AS
	RETURN(	SELECT IdRequisicionTipo,Nombre
			FROM Purchasing.RequisicionesTipos
			WHERE IdStatus=1
			
	)


