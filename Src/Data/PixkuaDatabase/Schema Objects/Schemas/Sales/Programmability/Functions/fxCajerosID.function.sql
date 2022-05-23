-- =============================================
-- Author: RCO
-- ALTER  date: 01-jul-2011
-- Description:	Obtiene el ID de Cajeros en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Sales].[fxCajerosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdCajero
	FROM Sales.Cajeros
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


