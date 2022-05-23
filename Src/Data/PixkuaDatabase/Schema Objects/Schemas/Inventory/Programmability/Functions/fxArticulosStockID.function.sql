-- =============================================
-- Author: RCO
-- ALTER  date: 05-oct-2010
-- Description:	Obtiene el ID de ArticulosStock en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Inventory].[fxArticulosStockID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdArticuloStock
	FROM Inventory.ArticulosStock
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


