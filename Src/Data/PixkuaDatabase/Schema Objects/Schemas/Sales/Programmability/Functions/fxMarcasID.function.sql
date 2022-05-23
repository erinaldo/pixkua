-- =============================================
-- Author: RCO
-- ALTER  date: 15-oct-2010
-- Description:	Obtiene el ID de Marcas en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Sales].[fxMarcasID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdMarca
	FROM Sales.Marcas
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


