-- =============================================
-- Author: RCO
-- Create date: 01-nov-2010
-- Description:	Obtiene una lista de búsqueda de Proveedores
-- =============================================
CREATE FUNCTION [Purchasing].[fxProveedoresLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdProveedor, Nombre, RazonSocial AS[Razon Social], RFC, Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Purchasing.Proveedores
	WHERE IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)	
	)


