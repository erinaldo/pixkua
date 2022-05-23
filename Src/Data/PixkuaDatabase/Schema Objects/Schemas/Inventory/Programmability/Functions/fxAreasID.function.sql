-- =============================================
-- Author: RCO
-- ALTER  date: 26-sep-2010
-- Description:	Obtiene el ID de Areas en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Inventory].[fxAreasID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdArea
	FROM Inventory.Areas
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


