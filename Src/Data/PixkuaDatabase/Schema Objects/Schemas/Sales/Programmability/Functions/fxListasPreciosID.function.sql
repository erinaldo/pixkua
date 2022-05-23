-- =============================================
-- Author: alez Lopez
-- ALTER  date: 16-ago-2011
-- Description:	Obtiene el ID de ListasPrecios en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Sales].[fxListasPreciosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdListaPrecio
	FROM Sales.ListasPrecios
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


