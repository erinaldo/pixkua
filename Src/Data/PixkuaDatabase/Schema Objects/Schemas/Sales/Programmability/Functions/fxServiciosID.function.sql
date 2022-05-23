-- =============================================
-- Author: RCO
-- ALTER  date: 08-sep-2010
-- Description:	Obtiene el ID de Servicios en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Sales].[fxServiciosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdServicio
	FROM Sales.Servicios
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


