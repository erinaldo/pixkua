-- =============================================
-- Author: RCO
-- Create date: 01-nov-2010
-- Description:	Obtiene la información del Proveedores especificado.
-- =============================================
CREATE FUNCTION [Purchasing].[fxProveedoresSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Purchasing.Proveedores WHERE IdProveedor=@ID)


