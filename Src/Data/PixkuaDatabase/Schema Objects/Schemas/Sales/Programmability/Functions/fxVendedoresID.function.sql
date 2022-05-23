-- =============================================
-- Author: alez lopez
-- ALTER  date: 29-ago-2011
-- Description:	Obtiene el ID de Vendedores en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Sales].[fxVendedoresID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdVendedor
	FROM Sales.Vendedores
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


