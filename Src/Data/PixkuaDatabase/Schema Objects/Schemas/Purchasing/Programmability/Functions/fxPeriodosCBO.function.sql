CREATE FUNCTION [Purchasing].[fxPeriodosCBO](@IdEmpresa as int)		
RETURNS TABLE
AS
	RETURN( SELECT	IdPeriodo,Nombre
			 FROM Purchasing.Periodos 
			 WHERE IdEmpresa=@IdEmpresa
)


