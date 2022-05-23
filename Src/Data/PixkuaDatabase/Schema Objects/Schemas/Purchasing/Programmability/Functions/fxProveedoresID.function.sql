-- =============================================
-- Author: RCO
-- ALTER  date: 01-nov-2010
-- Description:	Obtiene el ID de Proveedores en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Purchasing].[fxProveedoresID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdProveedor
	FROM Purchasing.Proveedores
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


