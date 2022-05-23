-- =============================================
-- Author: RCO
-- Create date: 01-nov-2010
-- Description:	Verifica la existencia de Proveedores
-- =============================================
CREATE FUNCTION [Purchasing].[fxProveedoresExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdProveedor FROM Purchasing.Proveedores WHERE IdProveedor=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


