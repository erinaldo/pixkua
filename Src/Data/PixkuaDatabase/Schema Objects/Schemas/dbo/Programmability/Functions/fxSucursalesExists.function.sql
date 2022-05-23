-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 30-DIC-2005
-- Description:	Verifica la existencia de la sucursal especificada.
-- =============================================

CREATE  FUNCTION [dbo].[fxSucursalesExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdSucursal FROM dbo.Sucursales WHERE IdSucursal=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


