-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: <<FECHA>>
-- Description:	Elimina el <<>> especificado.
-- =============================================
CREATE PROCEDURE [dbo].[GruposUsrDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE dbo.GruposUsr WHERE IdGrupo=@ID


