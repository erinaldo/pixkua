-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 30-DIC-2005
-- Description:	Obtiene la información de la sucursal especificada.
-- =============================================

CREATE  FUNCTION [dbo].[fxSucursalesSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM dbo.Sucursales WHERE IdSucursal=@ID)


