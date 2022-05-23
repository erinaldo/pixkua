-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: <<FECHA>>
-- Description:	Elimina el <<>> especificado.
-- =============================================
CREATE PROCEDURE [dbo].[PersonasDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE dbo.Personas WHERE IdPersona=@ID


