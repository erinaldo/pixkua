CREATE FUNCTION [Purchasing].[fxDepartamentosCentrosRecepcionSEL](@IdDepartamento int)
RETURNS TABLE
AS
RETURN(	SELECT DC.IdCentroRecepcion,CR.Nombre AS CentroRecepcion
		FROM Purchasing.DepartamentosCentrosRecepcion DC
		INNER JOIN Purchasing.CentrosRecepcion CR ON CR.IdCentroRecepcion=DC.IdCentroRecepcion
		WHERE IdDepartamento=@IdDepartamento
		
)


