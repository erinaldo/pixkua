CREATE FUNCTION [dbo].[fxPropiedadesControlesCBO]()
RETURNS TABLE
AS
	RETURN
	(
	SELECT IdPropiedadControl, UINombre
	FROM PropiedadesControles
	WHERE IdStatus=1
	)


