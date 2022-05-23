CREATE FUNCTION [Sales].[fxGrupoDescuentosClientesSEL](@IdEmpresa as int,@IdGrupoDescuentos as int)
RETURNS TABLE 
AS
	RETURN(	SELECT C.IdCliente,C.Codigo,C.Nombre,S.Nombre as Sucursal 
			FROM Sales.Clientes C
			INNER JOIN Sucursales S ON S.IdSucursal=C.IdSucursal
			WHERE C.IdEmpresa=@IdEmpresa AND C.IdGrupoDescuentos=@IdGrupoDescuentos
)


