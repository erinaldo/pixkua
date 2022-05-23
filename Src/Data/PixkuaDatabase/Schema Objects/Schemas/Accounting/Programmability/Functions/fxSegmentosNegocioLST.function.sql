CREATE FUNCTION [Accounting].[fxSegmentosNegocioLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdSegmentoNegocio,Descripcion,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Accounting.SegmentosNegocio 
	WHERE IdEmpresa= (SELECT IdEmpresa FROM Sucursales WHERE IdSucursal=@IdSucursal)
	)


