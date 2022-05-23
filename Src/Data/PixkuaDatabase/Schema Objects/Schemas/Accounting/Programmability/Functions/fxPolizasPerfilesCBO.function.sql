CREATE FUNCTION [Accounting].[fxPolizasPerfilesCBO]()
RETURNS TABLE
AS	
	RETURN(SELECT IdPolizaPerfil as Id, Descripcion FROM Accounting.PolizasPerfiles)


