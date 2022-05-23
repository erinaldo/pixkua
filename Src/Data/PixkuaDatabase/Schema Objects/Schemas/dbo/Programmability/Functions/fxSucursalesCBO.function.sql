CREATE FUNCTION [dbo].[fxSucursalesCBO](@IdEmpresa as int)
RETURNS TABLE
AS
RETURN
(
	SELECT IdSucursal, IdEmpresa, Nombre
	FROM Sucursales
	WHERE IdStatus=1 AND IdEmpresa=@IdEmpresa
)


