-- =============================================
-- Author: RCO
-- Create date: 26-sep-2010
-- Description:	Elimina el Areas especificado.
-- =============================================
CREATE PROCEDURE [Inventory].[AreasDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Inventory.Areas WHERE IdArea=@ID


