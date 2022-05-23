CREATE FUNCTION [Accounting].[fxPolizasPerfilesRacList](@IdPolizaPerfil as int)
RETURNS Table
AS
RETURN(	SELECT IdRacTit,Nombre AS Rac
		FROM Accounting.RacTit					
		WHERE IdPolizaPerfil=@IdPolizaPerfil AND IdStatus=1)


