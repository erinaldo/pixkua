CREATE FUNCTION [dbo].[fxFormatosLST](@IdEmpresa as int, @IdSucursal as int)
RETURNS TABLE
AS
RETURN	(
	SELECT Nombre, IdFormato
	FROM dbo.Formatos
	WHERE IdEmpresa=@IdEmpresa AND IdSucursal=@IdSucursal
		)


