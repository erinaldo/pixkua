CREATE FUNCTION [dbo].[fxFormatosCBO](@IdSucursal as int, @IdEmpresa as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdFormato, Nombre
	FROM dbo.Formatos
	WHERE IdSucursal=0 AND IdEmpresa=@IdEmpresa
UNION ALL
	SELECT IdFormato, Nombre
	FROM dbo.Formatos
	WHERE IdSucursal=@IdSucursal
		)


