-- =============================================
-- Author: RCO
-- Create date: 27-sep-2010
-- Description:	Obtiene la información del Almacenes especificado.
-- =============================================
CREATE FUNCTION [Inventory].[fxAlmacenesSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Inventory.Almacenes WHERE IdAlmacen=@ID)


