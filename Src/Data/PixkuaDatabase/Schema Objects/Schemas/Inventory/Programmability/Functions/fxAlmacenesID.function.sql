-- =============================================
-- Author: RCO
-- ALTER  date: 27-sep-2010
-- Description:	Obtiene el ID de Almacenes en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Inventory].[fxAlmacenesID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdAlmacen
	FROM Inventory.Almacenes
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


