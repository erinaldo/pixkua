-- =============================================
-- Author: RCO
-- ALTER  date: 14-oct-2010
-- Description:	Obtiene el ID de Articulos en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Sales].[fxArticulosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdArticulo
	FROM Sales.Articulos
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


