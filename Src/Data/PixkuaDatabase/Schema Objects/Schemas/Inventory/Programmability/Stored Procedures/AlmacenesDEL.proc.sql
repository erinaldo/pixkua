-- =============================================
-- Author: RCO
-- Create date: 27-sep-2010
-- Description:	Elimina el Almacenes especificado.
-- =============================================
CREATE PROCEDURE [Inventory].[AlmacenesDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Inventory.Almacenes WHERE IdAlmacen=@ID


