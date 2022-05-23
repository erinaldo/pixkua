CREATE FUNCTION [dbo].[fxCalendariosCBO](@IdEmpresa as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdCalendario, Codigo, Nombre
	FROM dbo.Calendarios
	WHERE IdEmpresa=@IdEmpresa AND IdStatus=1
		)


