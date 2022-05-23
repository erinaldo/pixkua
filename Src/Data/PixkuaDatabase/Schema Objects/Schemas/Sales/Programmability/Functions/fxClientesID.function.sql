-- =============================================
-- Author: RCO
-- ALTER  date: 02-sep-2010
-- Description:	Obtiene el ID de Clientes en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Sales].[fxClientesID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdCliente
	FROM Sales.Clientes
	WHERE Codigo=@Codigo  AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


