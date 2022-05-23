-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: <<FECHA>>
-- Description:	Elimina el <<>> especificado.
-- =============================================
CREATE PROCEDURE [dbo].[EstadosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE dbo.Estados WHERE IdEstado=@ID


