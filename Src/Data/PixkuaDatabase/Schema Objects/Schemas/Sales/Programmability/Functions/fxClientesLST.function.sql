-- =============================================
-- Author: RCO
-- Create date: 02-sep-2010
-- Description:	Obtiene una lista de búsqueda de Clientes
-- =============================================
CREATE FUNCTION [Sales].[fxClientesLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(
	SELECT C.IdCliente, C.Nombre,C.Telefonos, P.Poblacion, M.Nombre AS Municipio, C.Calle, C.RFC, C.RazonSocial, C.Codigo,
		CASE C.IdStatus
			WHEN 0 THEN 'Inactivo'
			WHEN 1 THEN 'Activo'
		END AS Estatus
	FROM Sales.Clientes C LEFT JOIN dbo.Poblaciones P
		ON C.IdPoblacion=P.IdPoblacion
	LEFT JOIN dbo.Municipios M
		ON M.IdMunicipio=P.IdMunicipio
	WHERE C.IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)	
	)


