-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 10-Mar-2006
-- Description:	Elimina el <<>> especificado.
-- =============================================
CREATE PROCEDURE [dbo].[CatalogosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE dbo.Catalogos WHERE IdCatalogo=@ID


